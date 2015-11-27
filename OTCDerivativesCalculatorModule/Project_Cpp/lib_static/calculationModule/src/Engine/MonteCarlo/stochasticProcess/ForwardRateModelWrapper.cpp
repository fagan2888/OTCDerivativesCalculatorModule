#include "ForwardRateModelWrapper.hpp"
#include <ql/math/solvers1d/bisection.hpp>
#include <iostream>
#include <ql/indexes/indexmanager.hpp>

namespace QuantLib {


ForwardRateModelWrapper::ForwardRateModelWrapper(const std::string& code,
												const boost::shared_ptr<YieldTermStructure>& fittingCurve,
												Real initialValue,
												Period& tenor)
												//Real r0)
: fittingCurve_(fittingCurve), tenor_(tenor)
{
	this->initialValue_ = initialValue;
	this->code_ = code;
	this->s_perturbation_ = 0.001;
}

void ForwardRateModelWrapper::generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	//targerPath[assetPosition][todayPosition] = r0_;

	for( Size i=todayPosition ; i < this->positionNum_ ; i++)
	{
		targerPath[assetPosition][i] = this->values_[i];
	}
}

void ForwardRateModelWrapper::generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	for( Size i=todayPosition ; i < this->positionNum_ ; i++)
	{
		targerPath[assetPosition][i] = this->values_[i] + s_perturbation_;
	}
}
void ForwardRateModelWrapper::generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{
	for( Size i=todayPosition ; i < this->positionNum_ ; i++)
	{
		targerPath[assetPosition][i] = this->values_[i] - s_perturbation_;
	}
}

void ForwardRateModelWrapper::generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{

}

void ForwardRateModelWrapper::generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition)
{

}

void ForwardRateModelWrapper::initialize(const TimeGrid& timeGrid)
{
	this->values_ = std::vector<Real>(timeGrid.size(),0.0);

	Date today = Settings::instance().evaluationDate();

	DayCounter dayCounter = this->fittingCurve_->dayCounter();
	Calendar calendar =	this->fittingCurve_->calendar();
	
	Size todayPosition = timeGrid.dateIndex(today);
	this->positionNum_ = this->values_.size();

	Real t1 = 0.0;
	Real t2 = dayCounter.yearFraction(today,calendar.advance(today,this->tenor_));

	Date t1_date = Date();
	Date t2_date = Date();

	const std::vector<Date>& dates = timeGrid.dates();
	
	for ( Size i = todayPosition ; i< this->values_.size() ; i++ )
	{
		t1_date = timeGrid.dateAt(i);

		t1 = dayCounter.yearFraction(today,t1_date);
		
		this->values_[i] = fittingCurve_->forwardRate(t1,t1+t2,Compounded);
	}

}

Real ForwardRateModelWrapper::indexAdjustment(Real r)
{
	return r;
}


}