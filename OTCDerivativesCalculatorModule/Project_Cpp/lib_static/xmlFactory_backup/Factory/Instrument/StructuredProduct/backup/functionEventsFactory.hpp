#pragma once

#include <xmlFactory/Factory/Instrument/StructuredProduct/IFactory.hpp>

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/EventFunctionMFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/JointEventFactory.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/functionEventsManager.hpp>

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunction.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunctionManager.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/JointEvent/JointEvent.hpp>


using namespace QuantLib;

namespace XmlFactory {

class FunctionEventsFactory : public IFactory {

	public:
		FunctionEventsFactory();
		FunctionEventsFactory(TiXmlNode* xmlNode){}
		void parseXml(TiXmlNode* xmlNode);

	protected:
		boost::shared_ptr<FunctionEvents> getFunctionEvents()
		{return functionEvents_;}
		
		void build();

	protected:
		boost::shared_ptr<FunctionEvents> functionEvents_;


};

}