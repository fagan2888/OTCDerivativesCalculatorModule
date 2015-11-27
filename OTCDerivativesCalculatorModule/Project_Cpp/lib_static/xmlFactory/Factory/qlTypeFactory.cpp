#include "qlTypeFactory.hpp"
#include <util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <factory\Etc\qlYieldTermStructureFactory.hpp>
#include <boost/lexical_cast.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <Factory\Etc\all.hpp>

#include <Factory/ELS/Hifive/qlHifiveFactory.hpp>
#include <Factory/ELS/CompositeOption/qlCompositeOptionFactory.hpp>
#include <Factory/ELS/CompositeOption/qlMultiAssetCompositeOptionFactory.hpp>
#include <Factory/structuredBond/qlStructuredBondFactory.hpp>
#include <Factory/structuredSwap/qlStructuredSwapFactory.hpp>
#include <Factory/nullFactory.hpp>


using namespace QuantLib;
using namespace ConvertFunction;

namespace XmlFactory {

qlTypeFactory::qlTypeFactory()
{
}

boost::shared_ptr<InstrumentFactory> qlTypeFactory::getInstFactory(const std::string& typeStr)
{
	std::string upperStr = boost::to_upper_copy(typeStr);
	
	boost::shared_ptr<InstrumentFactory> instFactory;

	if ( upperStr == "HIFIVE")
	{
		instFactory = boost::shared_ptr<InstrumentFactory>(
								new qlHifiveFactory());
	}
	else if ( upperStr == "COMPOSITEOPTION")
	{
		instFactory = boost::shared_ptr<InstrumentFactory>(
								new qlCompositeOptionFactory());
	}
	else if ( upperStr == "MULTIASSETCOMPOSITEOPTION")
	{
		instFactory = boost::shared_ptr<InstrumentFactory>(
								new qlMultiAssetCompositeOptionFactory());
	}
	else if ( upperStr == "STRUCTUREDBOND")
	{
		instFactory = boost::shared_ptr<InstrumentFactory>(
								new qlStructuredBondFactory());
	}
	else if ( upperStr == "STRUCTUREDSWAP")
	{
		instFactory = boost::shared_ptr<InstrumentFactory>(
								new qlStructuredSwapFactory());
	}
	else
	{
		instFactory = boost::shared_ptr<InstrumentFactory>(
							new NullFactory());
	}
	
	return instFactory;

}

boost::shared_ptr<InstrumentFactory> qlTypeFactory::getInstFactory_file(const char* fileName)
{
	std::cout << "test calculation start" << std::endl;

	qlTypeFactory typeFactory = qlTypeFactory();

	std::string instParaHistxmlStr; // xml ·ÎµåÇÔ

	//FILE *file = fopen(fileName,"r");
	
	TiXmlDocument document = TiXmlDocument(fileName);

	document.LoadFile();

	//	std::string str;

	//str << document;

	//document.Parse(instParaHistxmlStr.c_str(), 0, TIXML_ENCODING_UTF8);
	
	//TiXmlNode* gridCalcNode = document.FirstChildElement("gridCalculation")->FirstChildElement("");
	TiXmlNode* gridCalcNode = 
		document.FirstChildElement("message")
			->FirstChildElement("messageBody")
				->FirstChildElement("gridCalculation");

	FpmlSerialized::GridCalculation xml_girdCalc = FpmlSerialized::GridCalculation(gridCalcNode );

	boost::shared_ptr<FpmlSerialized::ProductInnerXml> xml_productInnerXml = 
		xml_girdCalc.getProductInnerXml();

	std::string typeStr = xml_girdCalc.getInst_type()->SValue();;
	
	Settings::instance().evaluationDate() = xml_girdCalc.getPara_refDate()->dateValue();

	boost::shared_ptr<InstrumentFactory> instFactory = typeFactory.getInstFactory(typeStr);
	
	// -------------------

	instFactory->setInstrument(xml_productInnerXml);
	
	//instFactory->calculate();

	//sprintf(result,"%s",instFactory->result().c_str());

	//const std::string& logStr = instFactory->engine()->getLogList();

	//log = (char*)logStr.c_str();

	//sprintf(log,"%s",instFactory->engine()->getLogList());
	
	//sprintf(log,"%f",instFactory->getDebugLog());

	//std::cout << "success" << std::endl;

	return instFactory;

}

std::string qlTypeFactory::readFile(std::string fileName)
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

}
