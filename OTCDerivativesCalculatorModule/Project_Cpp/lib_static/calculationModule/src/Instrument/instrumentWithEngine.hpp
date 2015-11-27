#ifndef quantLib_instrumentWithEngine_hpp
#define quantLib_instrumentWithEngine_hpp

#include <ql/instrument.hpp>
#include <ql/pricingengine.hpp>

namespace QuantLib {

	class InstrumentWithEngine {
		public:
			InstrumentWithEngine(const boost::shared_ptr<QuantLib::Instrument>& inst,
						   const boost::shared_ptr<QuantLib::PricingEngine>& pricingEngine);

			Real NPV(); 

		private:
			boost::shared_ptr<QuantLib::Instrument> inst_;
			boost::shared_ptr<QuantLib::PricingEngine> pricingEngine_;

	};

}

#endif