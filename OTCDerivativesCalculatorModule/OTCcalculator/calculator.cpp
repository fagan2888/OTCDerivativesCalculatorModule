// return value
// 0 : success
// 1 : unknownType
// 1000 : instXml load Fail
// 1001 : instXml error
// 2000 : paraXml load Fail
// 2001 : paraXml error

#include <iostream>
#include <fstream>
#include <string>
#include <xmlFactory/Factory/qlTypeFactory.hpp>
#include <xmlFactory\util\convertFunction.hpp>
#include <boost/shared_ptr.hpp>
#include "tinyxml/tinyxml.h"

using namespace XmlFactory;

#define READBUFFERNUM 1000
#define LogPrint


int fileExist(std::string fileName)
{
	return 0;
}

void writeXmlFile(std::string fileName,std::string addStr)
{

	TiXmlDocument result;
	result.Parse(addStr.c_str(),0,TIXML_ENCODING_UTF8);
	
	TiXmlNode * ele = result.FirstChild("pricingResult");
	TiXmlNode * eleClone = ele->Clone();

	TiXmlDocument doc;
	doc.LoadFile(fileName.c_str(),TIXML_ENCODING_UTF8) ;
	TiXmlNode * pricingEle = doc.FirstChild("pricing");

	pricingEle->LinkEndChild(eleClone);

	//pricingEle->LinkEndChild(new TiXmlText("<kkk></kkk>"));

	//std::ofstream file(fileName,std::ios::app);
	//file << addStr;
	//file.close();
	//
	//result.Parse(ConvertFunction::tiXmlToStr(doc.))

	doc.SaveFile();
}

void writeFile(std::string fileName,std::string addStr)
{
	std::ofstream file(fileName,std::ios::app);
	file << addStr;
	file.close();
}

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

// argv[1] : typeStr , argv[2] : instXmlFile , argv[3] : paraXmlFile
int main(int argc,char**  argv)
{
	//std::cout << "arg num : " << argc << std::endl;
	//
	//for ( int i=0 ; i<argc ; ++i)
	//{
	//	std::cout << "arg[" << i << "] : " << argv[i] << std::endl;
	//}
	
	//std::ostringstream ss;
	//double k = 1.2;
	//bool bb = true;
	//ss << "MaximumReferenceCal value : " << k << " " << bb;

	//std::cout << ss.str();
	
	//std::string instInfo = readFile(argv[2]);
	//std::string paraInfo = readFile(argv[3]);
	//boost::current_path 
	std::string path = "D:\\Project File\\OTCDerivativesCalculatorModule\\Debug\\";

	//std::string typeStr = "stepDownKI";
	/*std::string instInfo = readFile(path + argv[2]);
	std::string paraInfo = readFile(path + argv[3]);*/
	
	std::string typeStr = "HIFIVE"; //argv[1];

	//std::string instInfo = readFile(argv[2]);
	//std::string paraInfo = readFile(argv[3]);
	std::string instInfo = readFile(path + "hifiveTest.xml");
	std::string paraInfo = readFile(path + "hifiveTest_para.xml");
	std::string historyInfo = readFile(path + "historyData.xml");
	

	qlTypeFactory typeFactory = qlTypeFactory();

	boost::shared_ptr<InstrumentFactory> instFactory = typeFactory.getInstFactory(typeStr);
	
	instFactory->setInstrument(instInfo,paraInfo,historyInfo);
	instFactory->calculate();


	const char *cstr = instFactory->result().c_str();
	std::string resultStr = instFactory->result();

	std::string krCode = instFactory->getKRCode();
	std::string value = ConvertFunction::doubleToStr( instFactory->getValue() );
	std::string price = ConvertFunction::doubleToStr( instFactory->getPrice() );

	std::string outPut = krCode + "|" + value + "|" + price + "\n";

	if( READBUFFERNUM < strlen(resultStr.c_str())+1 ) {
		resultStr = "NULL";
		return 0;
	}
	
	//writeXmlFile(argv[3],resultStr);

	//writeFile(argv[4],outPut);

	//file·Î error log Âï±â 

	return 0;
}