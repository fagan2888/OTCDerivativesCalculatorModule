#ifndef xmlFactory_qlPayoffMFactory_hpp
#define xmlFactory_qlPayoffMFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/Payoff/all.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/PayoffBase.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/ConstPayoff.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/NullPayoff.hpp>

namespace XmlFactory {

	class qlPayoffMFactory {
	
		public:
			qlPayoffMFactory();
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::PayoffBase>& pc);
			boost::shared_ptr<QuantLib::PayoffBase> getPB();
		
		private: 
			boost::shared_ptr<QuantLib::ConstPayoff> constPayoff(const boost::shared_ptr<FpmlSerialized::ConstPayoff>& serial_cp);
			boost::shared_ptr<QuantLib::AverPayoff> averPayoff(const boost::shared_ptr<FpmlSerialized::AverPayoff>& serial_ap);
			//boost::shared_ptr<QuantLib::ExprPayoff> exprPayoff(const boost::shared_ptr<FpmlSerialized::ExprPayoff>& serial_ep);
			//boost::shared_ptr<PreFixPayoff> preFixPayoff(const boost::shared_ptr<FpmlSerialized::PreFixPayoff>& serial_pfp);
			boost::shared_ptr<QuantLib::NullPayoff> nullPayoff(const boost::shared_ptr<FpmlSerialized::NullPayoff>& serial_nc);

		private: 
			boost::shared_ptr<QuantLib::PayoffBase> payoffBase_;
			QuantLib::Date payoffDate_;

	};








	


}

#endif