#ifndef xmlFactory_eventcheckFactory_hpp
#define xmlFactory_eventcheckFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventCheck/all.hpp>

#include <xmlFactory/Factory/Instrument/StructuredProduct/Component/qlDateIntervalMakerFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/Component/qlFunctionEventsFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/Component/qlEventIndexTransformationFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/Component/qlJointEventFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/Component/qlPayoffMFactory.hpp>

#include <fpmlserialized/genclass/ahn-product-1-0/EventCheck.hpp>

namespace XmlFactory{

	class qlEventCheckFactory {
		public:
			//typedef

			typedef boost::shared_ptr<FpmlSerialized::EventCheck> fpml_EC_ptr_type;
			typedef boost::shared_ptr<FpmlSerialized::EventCheckNormal> fpml_normalEC_ptr_type;
			typedef boost::shared_ptr<FpmlSerialized::EventCheckTime> fpml_timeEC_ptr_type;

			typedef boost::shared_ptr<FpmlSerialized::EventIndexTransformation> fpml_EIT_ptr_type;
			typedef boost::shared_ptr<FpmlSerialized::FunctionEvents> fpml_FE_ptr_type;
			typedef boost::shared_ptr<FpmlSerialized::PayoffBase> fpml_PB_ptr_type;
			//typedef boost::shared_ptr<FpmlSerialized::JointFunctionEvent> fpml_JFE_ptr_type;
			typedef boost::shared_ptr<FpmlSerialized::JointSubEvent> fpml_JSE_ptr_type;
			typedef boost::shared_ptr<FpmlSerialized::JointFSubEvent> fpml_JFSE_ptr_type;
			typedef boost::shared_ptr<FpmlSerialized::JointTimeEvent> fpml_JTE_ptr_type;

			typedef boost::shared_ptr<QuantLib::IEventCheck> ql_IEC_ptr_type;
			typedef boost::shared_ptr<QuantLib::NormalEC> ql_normalEC_ptr_type;
			typedef boost::shared_ptr<QuantLib::NormalTimeEC> ql_timeEC_ptr_type;

			typedef boost::shared_ptr<QuantLib::EventIndexTransformation> ql_EIT_ptr_type;
			typedef boost::shared_ptr<QuantLib::FunctionEvents> ql_FE_ptr_type;
			typedef boost::shared_ptr<QuantLib::PayoffBase> ql_PB_ptr_type;
			typedef boost::shared_ptr<QuantLib::JointEvent> ql_JE_ptr_type;
			typedef boost::shared_ptr<QuantLib::JointTimeEvent> ql_JTE_ptr_type;

			//constructor

			qlEventCheckFactory();
			
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::EventCheck>& serial_ec);
			void setBaseIndex(const std::vector<std::string>& baseIndex); // 쓰이나?
			boost::shared_ptr<QuantLib::IEventCheck> getIEC();

		protected:
			std::vector<std::string> baseIndex();

		protected:
			std::string eventCheckID_;
			boost::shared_ptr<QuantLib::IEventCheck> iEventCheck_;
			std::vector<std::string> baseIndex_;
		
		//내부 구분용 using choice str
		private:
			boost::shared_ptr<QuantLib::IEventCheck> getNormalEC(const fpml_normalEC_ptr_type& serial_ecNormal);
			boost::shared_ptr<QuantLib::IEventCheck> getTimeEC(const fpml_timeEC_ptr_type& serial_ecTime);
			

		private:
			boost::shared_ptr<QuantLib::EventIndexTransformation> getEIT(const fpml_EIT_ptr_type& serial_Class);
			boost::shared_ptr<QuantLib::FunctionEvents> getFE(const fpml_FE_ptr_type& serial_Class);
			boost::shared_ptr<QuantLib::PayoffBase> getPB(const fpml_PB_ptr_type& serial_Class);
			boost::shared_ptr<QuantLib::SubEvents> getSubEvents(const boost::shared_ptr<FpmlSerialized::JointSubEvent>& serial_jse);

			boost::shared_ptr<QuantLib::JointEvent> getF_SubJE(const fpml_JFSE_ptr_type& serial_Class);
			boost::shared_ptr<QuantLib::JointTimeEvent> getJTE(const fpml_JTE_ptr_type& serial_Class);

	};
}
#endif