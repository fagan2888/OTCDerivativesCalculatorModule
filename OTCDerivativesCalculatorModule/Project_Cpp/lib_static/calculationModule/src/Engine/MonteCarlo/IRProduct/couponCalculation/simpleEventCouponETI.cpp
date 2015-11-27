#include "simpleEventCouponETI.hpp"

namespace QuantLib {

SimpleEventCouponETI::SimpleEventCouponETI(const boost::shared_ptr<EventCalculation>& eventCal,
											const boost::shared_ptr<ReturnCalculation>& returnCal,
											const boost::shared_ptr<ReturnCalculation>& complementReturnCal,
											const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
											bool isExpired,
											const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: CouponCalculation(usingVariableInfoList), eventCal_(eventCal), complementReturnCal_(complementReturnCal)
{
	this->returnCal_ = returnCal;
	this->payoffDateInfo_ = payoffDateInfo;
	this->isExpired_ = isExpired;
}

void SimpleEventCouponETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->eventCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->returnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->complementReturnCal_->initialize(timeGrid,discountCurve,pathGenFactory);
	this->payoffDateInfo_->initialize(timeGrid,discountCurve,pathGenFactory);

}

bool SimpleEventCouponETI::pastEventOcc()
{
	return true;
}

bool SimpleEventCouponETI::checkEvent(const MultiPath& path,Size endPosition)
{
	bool tf = this->eventCal_->checkEvent(path);

	return tf;
}

Real SimpleEventCouponETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real value = 0.0;

	//Real discount = payoffDateInfo_->discount();

	bool tf = this->eventCal_->checkEvent(path,endPosition);

	#ifdef LogPrint

	std::ostringstream ss;
	
	ss << "simpleEventCouponETI start";
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();

	path.log_.push_back("event Calc start");

	ss << "event Calc end , occ : " << tf;
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();

	#endif

	if ( tf )
	{
		double returnValue = returnCal_->calculate(path,endPosition);
		//value = returnValue * discount;
		value = returnValue ;

		#ifdef LogPrint
		
		path.log_.push_back("return calc start");

		ss << "return calc end , value : " << value << "( " << returnValue << "*" << discount << ")";
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();

		#endif

	}
	else 
	{
		double compReturnValue = complementReturnCal_->calculate(path,endPosition);
		//value = compReturnValue * discount;
		value = compReturnValue ;

		#ifdef LogPrint

		path.log_.push_back("compReturn calc start");

		ss << "compReturn calc end , value : " << value << "( " << compReturnValue << "*" << discount << ")";
		path.log_.push_back(ss.str());
		ss.str("");ss.clear();

		#endif
	}

	#ifdef LogPrint
	
	ss << "simpleEventCouponETI End , paoff value : " << value;
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();
	
	#endif

	return value;
}

//Real SimpleEventCouponETI::payoffImplEarlyEx(const MultiPath& path,Size endPosition)
//{
//	Real value = 0.0;
//
//	bool tf = this->eventCalInfo_->checkEventEarlyEx(path,endPosition);
//	Real discout = payoffDateInfo_->discount(endPosition);
//
//	if (tf  )
//	{
//		value = returnCalInfo_->calculateEarlyEx(path,endPosition) * discout;
//	}
//	else 
//	{
//		value = complementReturnCalInfo_->calculateEarlyEx(path,endPosition) * discout;
//	}
//
//	return value;
//}


std::vector<Date> SimpleEventCouponETI::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();
	
	helper.mergeDates(fixingDates,this->eventCal_->fixingDates());
	helper.mergeDates(fixingDates,this->returnCal_->fixingDates());

	return fixingDates;
}

std::vector<Date> SimpleEventCouponETI::payoffDates() const
{
	std::vector<Date> payoffDates;
	return payoffDates;
}


}

