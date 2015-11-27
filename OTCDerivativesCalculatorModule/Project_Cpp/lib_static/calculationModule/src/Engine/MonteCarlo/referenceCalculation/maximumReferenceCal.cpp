#include "MaximumReferenceCal.hpp"

namespace QuantLib {

MaximumReferenceCal::MaximumReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
										 const std::vector<std::string>& selectedUnder,
										 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReferenceCalculation(usingVariableInfoList)
{
	this->fixingDateInfo_ = fixingDateInfo;
	fixingDatePositions_ = std::valarray<Size>(1);

	QL_REQUIRE( selectedUnder.size() > 0 , "selectec under must be positive" );
	this->selectedUnder_ = selectedUnder;
}

void MaximumReferenceCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{

	this->fixingDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	this->selectedAssetNum_ = this->selectedUnder_.size();

	this->selectedAssetPosition_ = std::vector<Size>(this->selectedUnder_.size());

	for ( Size i=0 ; i<this->selectedUnder_.size() ; i++ )
	{
		this->selectedAssetPosition_[i] 
			= pathGenFactory->getProcessNum(this->selectedUnder_[i]);
		
		QL_REQUIRE(this->selectedAssetPosition_[i] != 99 , "underlyingPosition does not exist, underName : " << this->selectedUnder_[i] );
	}

	val_ = std::valarray<Real>(this->selectedAssetNum_);


	//if ( maxRefVarExistFlag_ == true )
	//{
	//	valueTypeRefPosition_ = std::valarray<boost::shared_ptr<variableStore>>(1);
	//	this->valueTypeRefPosition_[0] = pathGenFactory->registValueTypeReferenceValue(maxRefVarName_);
	//}

}

Real MaximumReferenceCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	for ( Size i=0 ; i < this->selectedAssetNum_ ; i++ )
	{
		val_[i] = path[this->selectedAssetPosition_[i]][fixingDateInfo_->fixingDatePosition()];
	}

	Real value = this->calSlice(val_);

	//if ( this->maxRefVarExistFlag_ == true )
	//{
	//	this->valueTypeRefPosition_[0]->value_ = value;
	//}
	
	//value = this->referenceRefVariable_->execute(value);

	#ifdef LogPrint

	std::ostringstream ss;

	ss << "MaximumReferenceCal " << value << " = (" ;
		
	for ( Size i=0 ;i < this->selectedAssetNum_; i++ )
	{
		ss << " under[" << this->selectedAssetPosition_[i] << "][" << fixingDateInfo_->fixingDatePosition() << "] ";
		ss << " = " << val_[i];
	}
	
	ss << " )";

	path.log_.push_back(ss.str());

	#endif

	return value;
}

Real MaximumReferenceCal::calSlice(const std::valarray<Real>& val) 
{
	double max = val[0];

	for ( Size i=1 ; i < this->selectedAssetNum_ ; i++ )
	{
		 if ( val[i] > max )
		 {
			 max = val[i];
		 }
	}

	return max;
}

Real MaximumReferenceCal::calSlice(const MultiPath& path,Size position)
{
	double max = path[0][position];
	double dummy = 0.0;

	for ( Size i=1 ; i < this->selectedAssetNum_ ; i++ )
	{
		dummy = path[i][position];
		 if ( dummy > max )
		 {
			 max = dummy;
		 }
	}

	return max;
}


std::vector<Date> MaximumReferenceCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	fixingDates.push_back(this->fixingDateInfo_->fixingDate());

	return fixingDates;
}

}