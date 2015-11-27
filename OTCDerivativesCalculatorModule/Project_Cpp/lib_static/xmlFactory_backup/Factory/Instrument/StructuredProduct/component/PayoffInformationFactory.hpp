#ifndef xmlFactory_payoffinformationfactory_hpp
#define xmlFactory_payoffinformationfactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunction.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunctionManager.hpp>

namespace XmlFactory {

	class PayoffInformationFactory {
		public:
			PayoffInformationFactory();
		
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::PayoffInformation>& pi);

			boost::shared_ptr<QuantLib::PayoffInformation> getPI(){return payoffInformation_;}

		protected:
			
		private:
			boost::shared_ptr<QuantLib::PayoffInformation> payoffInformation_;
	};
}

#endif