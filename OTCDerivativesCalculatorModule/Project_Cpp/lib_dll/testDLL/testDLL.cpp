#include "testDLL.hpp"

// testDLL.cpp : DLL 응용 프로그램을 위해 내보낸 함수를 정의합니다.
//

using namespace XmlFactory;

std::string readFile(std::string fileName)
{
	TiXmlDocument doc(fileName.c_str());
	doc.LoadFile();

	std::string str;

	str << doc;

	//if ( str.size() < 5 ) 
	//{
	//	std::cout << fileName << " : load Error! " << std::endl;
	//}
	//else
	//{
	//	std::cout << fileName << " : load Success!" << std::endl;
	//}

	return str;
}

void __stdcall testFunction(const char* calculationType,
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

void __stdcall calculate(const char* fileName,
						 char* result)
{
	// file 로드

	std::cout << "test calculation start" << std::endl;

	qlTypeFactory typeFactory = qlTypeFactory();
	
	boost::shared_ptr<InstrumentFactory> instFactory = typeFactory.getInstFactory_file(fileName);
	
	// -------------------
	
	instFactory->calculate();

	sprintf(result,"%s",instFactory->result().c_str());

	std::cout << "test calculation end" << std::endl;
}