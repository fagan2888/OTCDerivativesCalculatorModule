#ifndef xmlFactory_qlJointEventFactory_hpp
#define xmlFactory_qlJointEventFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>
//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointTimeEvent.hpp>


#include <fpmlserialized/genclass/ahn-product-1-0/JointFunctionEvent.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/JointSubEvent.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/JointFSubEvent.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/JointTimeEvent.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
	class qlJointEventFactory {
		public:
			qlJointEventFactory();

			void setSerialClass(const boost::shared_ptr<FpmlSerialized::JointFunctionEvent>& serial_jfe);
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::JointSubEvent>& jse);
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::JointFSubEvent>& jfse);
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::JointTimeEvent>& fte);

			boost::shared_ptr<QuantLib::JointEvent> getJFE();
			boost::shared_ptr<QuantLib::JointEvent> getJSE();
			boost::shared_ptr<QuantLib::JointEvent> getJFSE();
			boost::shared_ptr<QuantLib::JointTimeEvent> getJTE();

		private:

			boost::shared_ptr<QuantLib::JointEvent> build(std::valarray<bool> tfs,const std::string& setOper);
//			void build(std::vector<std::string> tfs,const std::string& setOper);
			boost::shared_ptr<QuantLib::JointTimeEvent> timeBuild(const std::string& setOper);

			boost::shared_ptr<QuantLib::JointEvent> jointFunctionEvent_;
			boost::shared_ptr<QuantLib::JointEvent> jointSubEvent_;
			boost::shared_ptr<QuantLib::JointEvent> jointFSubEvent_;
			boost::shared_ptr<QuantLib::JointTimeEvent> jointTimeEvent_;

	};

}

#endif