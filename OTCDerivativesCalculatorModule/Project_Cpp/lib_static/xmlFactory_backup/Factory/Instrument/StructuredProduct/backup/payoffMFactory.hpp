#pragma once

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/PayoffBase.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/all.hpp>
#include <ql/testClass/StandardSwap/NullPayoffM.hpp>
#include <xmlFactory/Instrument/Structuredproduct/IndexTransMFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class PayoffMFactory {
	
		public:

			PayoffMFactory();
			PayoffMFactory(TiXmlNode* xmlNode);

			boost::shared_ptr<PayoffBase> getPayoff(TiXmlNode* xmlNode){return payoff_}
		
		private: 
		
			boost::shared_ptr<PayoffBase> payoff_;

	};

	namespace Factory {
		class IPayoff {
			protected:
				boost::shared_ptr<PayoffBase> getPayoff(){return thisPayoff_;}
				boost::shared_ptr<PayoffBase> thisPayoff_;
		};

		class AverPayoff {
			public:
				AverPayoff(TiXmlNode* xmlNode);
		};

		class ConstPayoff {
			public:
				ConstPayoff(TiXmlNode* xmlNode);
		};

		class ExprPayoff {
			public:
				ExprPayoff(TiXmlNode* xmlNode);
		};

		class PreFixPayoff {
			public:
				PreFixPayoff(TiXmlNode* xmlNode);
		};

		class NullPayoff {
			public:
				NullPayoff(TiXmlNode* xmlNode);
		};

	}


}