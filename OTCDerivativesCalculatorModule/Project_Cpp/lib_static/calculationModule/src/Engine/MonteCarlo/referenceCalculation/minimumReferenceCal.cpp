#include "MinimumReferenceCal.hpp"

namespace QuantLib {

MinimumReferenceCal::MinimumReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
										 const std::vector<std::string>& selectedUnder,
										 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: ReferenceCalculation(usingVariableInfoList)
{
	this->definedVarNameList_.push_back("minimumValue");
	this->fixingDateInfo_ = fixingDateInfo;

	QL_REQUIRE( selectedUnder.size() > 0 , "selectec under must be positive" );
	this->selectedUnder_ = selectedUnder;
}

void MinimumReferenceCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->fixingDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

	//Date today = Settings::instance().evaluationDate();
	
	//DayCounter dayCounter = Actual365Fixed();

	//double fixingTime = dayCounter.yearFraction( today , fixingDates_[0] );
	//fixingDatePositions_[0] = timeGrid.closestIndex(fixingTime);

	this->selectedAssetNum_ = this->selectedUnder_.size();

	this->selectedAssetPosition_ = std::vector<Size>(this->selectedUnder_.size());

	for ( Size i=0 ; i<this->selectedUnder_.size() ; i++ )
	{
		this->selectedAssetPosition_[i] 
			= pathGenFactory->getProcessNum(this->selectedUnder_[i]);
	}

	val_ = std::valarray<Real>(this->selectedAssetNum_);

	//this->initializeSelectedUnder();

}

Real MinimumReferenceCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	
	for ( Size i=0 ; i < this->selectedAssetNum_ ; i++ )
	{
		val_[i] = path[this->selectedAssetPosition_[i]][fixingDateInfo_->fixingDatePosition()];
	}

	Real value = this->calSlice(val_);

	//if ( this->usedVarFlagList_[0] == true )
	//{
	//	this->valueTypeRefPosition_[0]->value_ = value;
	//}

	#ifdef LogPrint

	std::ostringstream ss;

	ss << "MinimumReferenceCal " << value << " = (" ;
		
	for ( Size i=0 ;i < this->selectedAssetNum_; i++ )
	{
		ss << " under[" << this->selectedAssetPosition_[i] << "][" << fixingDateInfo_->fixingDatePosition() << "] ";
		ss << " = " << val_[i];
	}
	
	ss << " )";

	path.log_.push_back(ss.str());

	#endif

	return value;

	//	Size position = fixingDatePositions_[0];

	//double min = path[0][position];

	//for ( Size i=1 ; i < this->assetNum_ ; i++ )
	//{
	//	 if ( path[i][position] < min )
	//	 {
	//		 min = path[i][position];
	//	 }
	//}

	//return min;
	
}

Real MinimumReferenceCal::calSlice(const std::valarray<Real>& val)
{

	double min = val[this->selectedAssetPosition_[0]];

	for ( Size i=1 ; i < this->selectedAssetNum_ ; i++ )
	{
		 if ( val[i] < min )
		 {
			 min = val[i];
		 }
	}

	return min;
}

Real MinimumReferenceCal::calSlice(const MultiPath& path,Size position)
{
	double min = path[this->selectedAssetPosition_[0]][position];
	Real v = 0.0;

	for ( Size i=1 ; i < this->selectedAssetNum_ ; i++ )
	{
		 v = path[this->selectedAssetPosition_[i]][position];
		 if ( v < min )
		 {
			 min = v;
		 }
	}

	return min;
}

std::vector<Date> MinimumReferenceCal::fixingDates() const
{
	std::vector<Date> fixingDates;

	fixingDates.push_back(this->fixingDateInfo_->fixingDate());

	return fixingDates;
}

}