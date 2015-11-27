#include "vanillaRateETI.hpp"

namespace QuantLib {

VanillaRateETI::VanillaRateETI(const DayCounter& dayCounter,
								const Date& calculationStartDate,
								const Date& calculationEndDate,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
								const boost::shared_ptr<ReferenceCalculation>& refCalc,
								Real gearing,
								Real spread,
								Real outGearing,
								Real outSpread,
								Real cap,
								Real floor,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList)
: RateCalculation(dayCounter,calculationStartDate,calculationEndDate,usingVariableInfoList), 
  refCalc_(refCalc), gearing_(gearing),spread_(spread), outGearing_(outGearing),
  outSpread_(outSpread),cap_(cap),floor_(floor)
{
	this->isExpired_ = false;
	this->payoffDateInfo_ = payoffDateInfo;
	//couponYearFraction_ = dayCounter_.yearFraction(calculationStartDate,calculationEndDate);
}

void VanillaRateETI::initializeImpl(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	this->setYearFracValues(timeGrid);

	this->payoffDateInfo_->initialize(timeGrid, discountCurve, pathGenFactory);
	
	//this->calculationStartPosition_ = timeGrid.dateIndex(this->calculationStartDate_);
	//this->calculationEndPosition_ = timeGrid.dateIndex(this->calculationEndDate_);
	
	//this->couponYearFraction_ = this->dayCounter_.yearFraction(this->calculationStartDate_,this->calculationEndDate_);

	this->refCalc_->initialize(timeGrid, discountCurve, pathGenFactory);

}

bool VanillaRateETI::pastEventOcc()
{
	return true;
}

bool VanillaRateETI::checkEvent(const MultiPath& path,Size endPosition)
{
	return true;
}

Real VanillaRateETI::payoffImpl(const MultiPath& path,Size endPosition)
{
	Real refCal = refCalc_->calculate(path,endPosition);

	Real vanillaRate = this->outGearing_ * 
							std::min( std::max( 
								this->gearing_ * refCal + this->spread_ ,
										this->floor_),
												this->cap_) + this->outSpread_; 

	//Real value = vanillaRate * couponYearFraction_ * this->payoffDateInfo_->discount();
	Real value = vanillaRate * couponYearFraction_ ;

	#ifdef LogPrint
	std::ostringstream ss;

	ss << "vanillaRateETI calc start" << " calculationDate : [ " << this->calculationStartDate_ << " , " << this->calculationEndDate_ << " ]";
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

	ss << " refCal : " << refCal;
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();

	ss << "vanillaRate : " << this->outGearing_ << " * " << "min(max( " << this->gearing_ << " * " << refCal << " + " << this->spread_
	   << " , " << this->floor_ << " ), " << this->cap_ << " ) + " << this->outSpread_;
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

	ss << " value : " << value << " yearFrac : " << couponYearFraction_ << " discount : " << this->payoffDateInfo_->discount() << " vanillaRate : " << vanillaRate ;
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

	ss << "vanillaRateETI calc end ";
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

	#endif

	//yearFraction
	return value;

}

Real VanillaRateETI::payoffImplEarlyEx(const MultiPath& path,Size endPosition)
{
	Real v = 0.0;
	Real yearFraction = 0.0;

	if ( this->calculationStartPosition_ < endPosition )
	{
		Date earlyExDate;

		if ( this->calculationEndPosition_ <= endPosition )
		{
			earlyExDate = this->calculationEndDate_;
		}
		else
		{
			earlyExDate = path[0].timeGrid().dateAt(endPosition);
		}

		yearFraction = this->dayCounter_.yearFraction(this->calculationStartDate_,earlyExDate);

	}

	Real fixed = refCalc_->calculate(path,endPosition);

	//yearFraction
	return fixed * yearFraction * this->payoffDateInfo_->discount();

}

Real VanillaRateETI::accrualRate(const MultiPath& path,const Date& refDate) const
{
	//Date today = Settings::instance().evaluationDate();

	Real acc = 0.0;
	Real refCal = this->refCalc_->calculate(path,9999);

	if ( this->calculationStartDate_ < refDate && refDate <= this->calculationEndDate_ )
	{
		Real yearF = dayCounter_.yearFraction(this->calculationStartDate_,refDate);
		acc = refCal * yearF;
	}

	#ifdef LogPrint

	std::ostringstream ss;

	ss << "vanillaRateETI accrualRate calc start" << " calculationDate : [ " << this->calculationStartDate_ << " , " << this->calculationEndDate_ << " ]";
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

	ss << " refCal : " << refCal;
	path.log_.push_back(ss.str());
	ss.str("");ss.clear();

	ss << " acc : " << acc << " accYearFrac : " << dayCounter_.yearFraction(this->calculationStartDate_,today) 
		<< " today : " << today;
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();

	ss << "vanillaRateETI accrualRate calc end";
			path.log_.push_back(ss.str());
			ss.str("");ss.clear();
	
	#endif

	return acc; 
}

std::vector<Date> VanillaRateETI::fixingDates() const
{
	return std::vector<Date>();
}

std::vector<Date> VanillaRateETI::payoffDates() const
{
	return std::vector<Date>();
}

}

