#include "InstrumentWithEngine.hpp"

namespace QuantLib {

InstrumentWithEngine::InstrumentWithEngine(const boost::shared_ptr<QuantLib::Instrument>& inst,
				const boost::shared_ptr<QuantLib::PricingEngine>& pricingEngine)
: inst_(inst), pricingEngine_(pricingEngine)
{

}

Real InstrumentWithEngine::NPV()
{
	Real v = 0.0;

	this->inst_->setPricingEngine(this->pricingEngine_);

	v = this->inst_->NPV();

	return v;
}

}

