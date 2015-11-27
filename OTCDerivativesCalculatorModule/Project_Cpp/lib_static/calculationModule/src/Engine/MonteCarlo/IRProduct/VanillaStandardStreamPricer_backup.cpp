#include "VanillaStandardStreamPricer.hpp"
#include <src/util/DateHelper.hpp>

namespace QuantLib {

VanillaStandardStreamPricer::VanillaStandardStreamPricer(const std::vector<boost::shared_ptr<RateCalculation>>& irCalcList,
														 const boost::shared_ptr<YieldTermStructure>& discountCurve)
: irCalcList_(irCalcList), discountCurve_(discountCurve)
{
			
}

void VanillaStandardStreamPricer::initialize(const TimeGrid& timeGrid,
										   const boost::shared_ptr<YieldTermStructure>& discountCurve,
										   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i = 0 ; i < irCalcList_.size() ; i++ )
	{
		irCalcList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);

		if ( irCalcList_[i]->isExpired() )
		{
			remainEventPosition_ = i + 1;
		}
	}

}

std::vector<Date> VanillaStandardStreamPricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	for ( Size i = 0 ; i < irCalcList_.size() ; i++ )
	{
		helper.mergeDates(fixingDates,irCalcList_[i]->fixingDates());

	}

	return fixingDates;
}

std::vector<Date> VanillaStandardStreamPricer::payoffDates() const
{
	std::vector<Date> payoffDates;

	//for ( Size i = 0 ; i < eventTriggerList_.size() ; i++ )
	//{
	//	payoffDates.push_back(eventTriggerList_[i]->payoffDate());
	//}

	////payoffDates.push_back(this->kiBarrierEventTrigger_->payoffDate());
	////payoffDates.push_back(this->nonOccBarrierEventTrigger_->payoffDate());
	//
	//DateHelper helper = DateHelper ();

	//std::vector<Date> results = helper.removeDuplicateDate(payoffDates);

	return payoffDates;
}

Real VanillaStandardStreamPricer::calculate(const MultiPath& path) const
{
	Real value = 0.0;
	
	for ( Size i = remainEventPosition_ ; i < irCalcList_.size() ; i++ )
	{
		value += irCalcList_[i]->payoff(path);
	}

	return value;
}

void VanillaStandardStreamPricer::reset()
{

}

}
