#include <string>
#include <iostream>

#include <Factory/instrumentFactory.hpp>
#include <xmlFactory/Factory/qlTypeFactory.hpp>
#include <string>

using namespace XmlFactory;
using namespace std;

namespace TestProduct {

void testFunction(const char* calculationType,
							const char* instInfo, 
							const char* paraInfo ,
							const char* historyInfo ,
							int dateSerialNumber,
							char* result,
							char* log,
							unsigned int resultStrLen)
{
	
std::cout << "test calculation start" << std::endl;

	qlTypeFactory typeFactory = qlTypeFactory();

	std::string typeStr = calculationType;
	
	Settings::instance().evaluationDate() = QuantLib::Date(dateSerialNumber);

	boost::shared_ptr<InstrumentFactory> instFactory = typeFactory.getInstFactory(typeStr);
	
	// -------------------

	instFactory->setInstrument(instInfo,paraInfo,historyInfo);
	
	instFactory->calculate();
	//

	//sprintf(result,"%f",instFactory->getValue());
	
	sprintf(result,"%s",instFactory->result().c_str());

	//const std::string& logStr = instFactory->engine()->getLogList();

	//log = (char*)logStr.c_str();

	//sprintf(log,"%s",instFactory->engine()->getLogList());
	
	//sprintf(log,"%f",instFactory->getDebugLog());

	std::cout << "success" << std::endl;


}

void testFunction2(const char* fileName)
{
	std::cout << "test calculation start" << std::endl;

	qlTypeFactory typeFactory = qlTypeFactory();
	
	boost::shared_ptr<InstrumentFactory> instFactory = typeFactory.getInstFactory_file(fileName);
	
	// -------------------
	
	instFactory->calculate();

}

}
