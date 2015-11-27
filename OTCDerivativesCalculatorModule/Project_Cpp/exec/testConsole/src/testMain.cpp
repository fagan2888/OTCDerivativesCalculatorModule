
//#include "ProductTest\credit\creditDefaultSwap\creditDefaultSwapTest.hpp"
#include "ProductTest/equity/stepDownKI/stepDownKI_Test.hpp"
#include "tinyxml/tinyxml.h"

//std::string directory = "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\book\\mrogen_position\\prototype\\";
//std::string directory = "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\ExcelInterface\\bin\\Debug\\";
std::string directory = "D:\\OTC_Batch\\";
unsigned int resultStrLen = 10000;

std::string fileLoad(const std::string& fileName)
{
	std::string fullPath = directory + fileName;
	TiXmlDocument doc(fullPath.c_str());
	doc.LoadFile();

	std::string str;

	str << doc;

	if ( str.size() < 5 ) 
	{
		std::cout << fileName << " : load Error! " << std::endl;
	}
	else
	{
		std::cout << fileName << " : load Success!" << std::endl;
	}

	return str;
}

int main(int, char* [])
{
	/*std::string instInfo = fileLoad("SingleNameCDS.xml");
	std::string paraInfo = fileLoad("SingleNameCDSParameter.xml");*/
	/*std::string instInfo = fileLoad("MultiNameCDS.xml");
	std::string paraInfo = fileLoad("MultiNameCDSParameter20131007.xml");*/
	char* result = "";
	char* log = "";
	
	//std::string historyInfo = fileLoad("historyData.xml");
	std::string historyInfo = fileLoad("testUnderHistDataInfo.xml");
	
	//TestProduct::creditDefaultSwapTest(instInfo.c_str(),
	//								   paraInfo.c_str(),
	//								   result,
	//								   resultStrLen);


	//stepDownKI_unfunded
	//std::string instInfo = fileLoad("3star_004_stepDownKI_unfunded.xml");
	//std::string paraInfo = fileLoad("00000000_3star_004_stepDownKI_unfunded.xml");

	std::string instInfo = fileLoad("testInst.xml");
	std::string paraInfo = fileLoad("testInst_20141210.xml");

	//TestProduct::stepDownKIGeneral_Test(instInfo.c_str(),
	//								   paraInfo.c_str(),
	//								   result,
	//								   resultStrLen);

	//TestProduct::stepDownKI_Test(instInfo.c_str(),
	//								   paraInfo.c_str(),
	//								   result,
	//								   resultStrLen);

	//TestProduct::testFunction("STRUCTUREDSWAP",
	//							instInfo.c_str(),
	//							paraInfo.c_str(),
	//							historyInfo.c_str(),
	//							41983,
	//							result,
	//							log,
	//							resultStrLen);

	//TestProduct::testFunction2("D:\\OTC_Batch\\testInst.xml");
	TestProduct::testFunction2("D:\\OTC_Batch\\mergedInstHist.xml");

	return 0;
}