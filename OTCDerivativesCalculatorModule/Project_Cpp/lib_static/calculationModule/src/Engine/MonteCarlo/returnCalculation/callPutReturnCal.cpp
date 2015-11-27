#include "callPutReturnCal.hpp"

namespace QuantLib {

CallPutReturnCal::CallPutReturnCal(bool callPut,
								   Real partiRate,
								   Real strike,
								   Real spread,
								   const boost::shared_ptr<QuantLib::ReferenceCalculation>& refCal,
								   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList  )
: ReturnCalculation(usingVariableInfoList), callPut_(callPut), refCal_(refCal), 
  partiRate_(partiRate), strike_(strike), spread_(spread)
{

}

void CallPutReturnCal::initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->refCal_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real CallPutReturnCal::calculateImpl(const MultiPath& path,Size endPosition)
{
	/*#ifdef LogPrint
	path.log_.push_back("CallPutReturnCal start");
	#endif

	Real refValue = this->refCal_->calculate(path,endPosition);
	
	Real value = gearing_ * refValue + spread_;

	#ifdef LogPrint

	std::ostringstream ss;

	ss << "VanillaReturnCal end , value : " << value << " ( " << this->gearing_ << " * " << refValue << " + " << this->spread_ << " )";

	path.log_.push_back(ss.str());

	#endif

	return value;*/

	return 0.0;

}

//Real VanillaReturnCal::calculateImplEarlyEx(const MultiPath& path,Size endPosition)
//{
//	Real refValue = this->refCal_->calculateEarlyEx(path,endPosition);
//
//	return gearing_ * refValue + spread_;
//
//}

Real CallPutReturnCal::calSlice(const std::valarray<Real>& val)
{

	//double min = val[0];

	//for ( Size i=1 ; i < this->assetNum_ ; i++ )
	//{
	//	 if ( val[i] < min )
	//	 {
	//		 min = val[i];
	//	 }
	//}

	//return min;

	return 0.0;
}

Real CallPutReturnCal::calSlice(const MultiPath& path,Size position)
{
	return 0.0;
}

std::vector<Date> CallPutReturnCal::fixingDates() const
{
	return this->fixingDates_;
}


}