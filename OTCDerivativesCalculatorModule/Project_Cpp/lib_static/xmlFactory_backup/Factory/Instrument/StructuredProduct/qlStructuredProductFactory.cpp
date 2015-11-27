#include "qlstructuredProductFactory.hpp"
#include <xmlFactory/Factory/Instrument/StructuredProduct/qlStructuredProductPayoffFactory.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variablevalue/all.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/IndexSymbolManager.hpp>

namespace XmlFactory {

qlStructuredProductFactory::qlStructuredProductFactory()
{

}
		
void qlStructuredProductFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::StructuredProduct>& sp)
{
	//------------------------나중에 이거 모듈로 추가해야함-----------------------------

	boost::shared_ptr<QuantLib::VariableValue> ql_initialS1 
					=boost::shared_ptr<QuantLib::ConstVariableValue>(new QuantLib::ConstVariableValue(1500,"initial_Stock1",QuantLib::Date()));

	ql_initialS1->registManager();

	boost::shared_ptr<QuantLib::VariableValue> ql_initialS2
					=boost::shared_ptr<QuantLib::ConstVariableValue>(new QuantLib::ConstVariableValue(354,"initial_Stock2",QuantLib::Date()));

	ql_initialS2->registManager();


	//---------------------------------------------------------------------------------

	qlStructuredProductPayoffFactory ql_sppf = qlStructuredProductPayoffFactory();

	ql_sppf.setSerialClass(sp->getStructuredProductPayoff());
	const boost::shared_ptr<StructuredProductPayoff>& ql_spp = ql_sppf.getSPP();

	const boost::shared_ptr<FpmlSerialized::IssueInformation>& serial_ii = sp->getIssueInformation();

	const std::string& productType = serial_ii->getProductType()->SValue();
	const std::string& instrumentID = serial_ii->getInstrumentID()->SValue();

	Real notional = serial_ii->getProductType()->DValue();

	const Date& issueDate = serial_ii->getIssueDate()->getDateSingle()->dateValue();
	const Date& maturityDate = serial_ii->getMaturityDate()->getDateSingle()->dateValue();

	structuredProduct_ = boost::shared_ptr<QuantLib::StructuredProduct>(
							new QuantLib::StructuredProduct(productType,
														    instrumentID,
														    notional,
														    issueDate,
														    maturityDate,
														    ql_spp));


	
}

boost::shared_ptr<QuantLib::StructuredProduct> qlStructuredProductFactory::getSP()
{
	return structuredProduct_;
}

}

