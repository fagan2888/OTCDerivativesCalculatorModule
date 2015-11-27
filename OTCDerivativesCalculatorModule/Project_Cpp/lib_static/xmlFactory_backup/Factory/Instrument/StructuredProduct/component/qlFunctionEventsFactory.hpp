#ifndef xmlFactory_qlFunctionEventsFactory_hpp
#define xmlFactory_qlFunctionEventsFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/FunctionEvents.hpp>

#include <fpmlserialized/genclass/ahn-product-1-0/FunctionEvents.hpp>

using namespace QuantLib;

namespace XmlFactory {

class qlFunctionEventsFactory {

	public:
		qlFunctionEventsFactory(){}
		void setSerialClass(const boost::shared_ptr<FpmlSerialized::FunctionEvents>& fe);
		boost::shared_ptr<QuantLib::FunctionEvents> getFE();

	protected:
		boost::shared_ptr<QuantLib::EventFunctionManager> efm(const boost::shared_ptr<FpmlSerialized::EventFunctionM>& ef);
		boost::shared_ptr<QuantLib::UpEventCheck> qlFunctionEventsFactory::getUpEventCheck(const boost::shared_ptr<FpmlSerialized::UpEventCheck>& serial_uec);
		boost::shared_ptr<QuantLib::DownEventCheck> qlFunctionEventsFactory::getDownEventCheck(const boost::shared_ptr<FpmlSerialized::DownEventCheck>& serial_dec);

		//boost::shared_ptr<QuantLib::UpDownEventCheck> qlFunctionEventsFactory::getUpDownEventCheck(const boost::shared_ptr<FpmlSerialized::UpDownEventCheck>& serial_udec);
		//boost::shared_ptr<QuantLib::RangeEventCheck> qlFunctionEventsFactory::getRangeEventCheck(const boost::shared_ptr<FpmlSerialized::RangeEventCheck>& serial_rec);

	protected:
		boost::shared_ptr<QuantLib::FunctionEvents> functionEvents_;
		
};

}

#endif