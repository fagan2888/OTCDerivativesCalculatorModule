#include "vanillaSwapPricer.hpp"
#include <src/util/DateHelper.hpp>

namespace QuantLib {

VanillaSwapPricer::VanillaSwapPricer(const boost::shared_ptr<MCPricer>& payPart,
									const boost::shared_ptr<MCPricer>& recievePart)
: payPart_(payPart), recievePart_(recievePart)

{
			
}

void VanillaSwapPricer::initializeImpl(const TimeGrid& timeGrid,
									   const boost::shared_ptr<YieldTermStructure>& discountCurve,
									   const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	payPart_->initialize(timeGrid,discountCurve,pathGenFactory);
	recievePart_->initialize(timeGrid,discountCurve,pathGenFactory);
}

Real VanillaSwapPricer::calculate(const MultiPath& path,Size endPosition) const
{
	Real payPartValue = 0.0;
	Real recievePartValue = 0.0;

	payPartValue = this->payPart_->calculate(path);
	recievePartValue = this->recievePart_->calculate(path);

	value_ = payPartValue + recievePartValue;

	return value_;
}

std::vector<Date> VanillaSwapPricer::fixingDates() const
{
	std::vector<Date> fixingDates;

	DateHelper helper = DateHelper();

	helper.mergeDates(fixingDates, this->payPart_->fixingDates() );
	helper.mergeDates(fixingDates, this->recievePart_->fixingDates() );

	return fixingDates;
}

std::vector<Date> VanillaSwapPricer::payoffDates() const
{
	std::vector<Date> payoffDates;

	return payoffDates;
}

void VanillaSwapPricer::resetImpl() const
{
	this->value_ = 0.0;
}

}
