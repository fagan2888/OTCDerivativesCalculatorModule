#include "qlReturnCalculationFactory.hpp"
#include <Factory/Etc/qlReferenceCalculationFactory.hpp>
#include <Factory/Etc/qlOperatorFactory.hpp>
#include <Factory/Etc/qlVariableInfoFactory.hpp>
#include <Factory/Etc/qlPostCalculationFactory.hpp>
#include <Factory/Etc/qlOptionPayoffFunctionFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlReturnCalculationFactory::qlReturnCalculationFactory()
{
}

//boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCalculationFactory::returnCal(const boost::shared_ptr<FpmlSerialized::ReturnCalculation>& xml_serial)
//{
//	boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCal;
//
//	std::string returnType = xml_serial->getType()->SValue();
//
//	if ( returnType == "vanillaReturnCal" )
//	{
//		const boost::shared_ptr<FpmlSerialized::VanillaReturnCal>& xml_vanillaReturnCal
//			= xml_serial->getVanillaReturnCal();
//
//		qlReturnCal = this->vanillaReturnCal(xml_vanillaReturnCal);
//	}
//	else if ( returnType == "constReturnCal" )
//	{
//		const boost::shared_ptr<FpmlSerialized::ConstReturnCal>& xml_constCal
//			= xml_serial->getConstReturnCal();
//
//		qlReturnCal = this->constReturnCal(xml_constCal);
//	
//	}
//	else if ( returnType == "stopLossReturnCal" )
//	{
//		const boost::shared_ptr<FpmlSerialized::StopLossReturnCal>& xml_stopLossReturnCal
//			= xml_serial->getStopLossReturnCal();
//
//		qlReturnCal = this->stopLossReturnCal(xml_stopLossReturnCal);
//	
//	}
//	else if ( returnType == "zeroReturnCal" )
//	{
//		const boost::shared_ptr<FpmlSerialized::ZeroReturnCal>& xml_stopLossReturnCal
//						= xml_serial->getZeroReturnCal();
//
//		qlReturnCal = boost::shared_ptr<QuantLib::ReturnCalculation>(new ZeroReturnCal());
//	
//	}
//	else if ( returnType == "callPutCompositeReturnCal" )
//	{
//		const boost::shared_ptr<FpmlSerialized::CallPutCompositeReturnCal>& xml_callPutCompositeReturnCal
//						= xml_serial->getCallPutCompositeReturnCal();
//
//		qlReturnCal = this->callPutCompositeReturnCal(xml_callPutCompositeReturnCal);
//	
//	}
//	else
//	{
//		QL_FAIL("unknown returnType : " << returnType );
//	}
//
//	//preCal set
//	if ( !xml_serial->isPreCalculation() )
//	{
//		const boost::shared_ptr<FpmlSerialized::PreCalculation>& xml_preCal = xml_serial->getPreCalculation();
//		const boost::shared_ptr<QuantLib::PreCalculation>& ql_preCal = this->preCal(xml_preCal);
//		qlReturnCal->setPreCalculation(ql_preCal);
//	}
//
//	//postCal set
//	if ( !xml_serial->isPostCalculation() )
//	{
//		qlPostCalculationFactory qlPostCalFactory = qlPostCalculationFactory();
//		const boost::shared_ptr<FpmlSerialized::PostCalculation>& xml_postCal = xml_serial->getPostCalculation();
//		const boost::shared_ptr<QuantLib::PostCalculation>& ql_postCal = qlPostCalFactory.postCal( xml_postCal );
//		qlReturnCal->setPostCalculation(ql_postCal);
//	}
//
//	qlVariableInfoFactory qlVarFactory = qlVariableInfoFactory();
//
//	//refVariable_returnValue set
//	if ( !xml_serial->isRefVariable_returnValue() )
//	{
//		const boost::shared_ptr<FpmlSerialized::RefVariable_returnValue>& xml_refReturn = xml_serial->getRefVariable_returnValue();
//		const boost::shared_ptr<QuantLib::VariableInfo>& ql_varInfo = qlVarFactory.variableInfo(xml_refReturn->getVariableInfo());
//		qlReturnCal->setReturnRefVariable(ql_varInfo);
//	}
//
//	//resetRefVariable set
//	if ( !xml_serial->isResetVariableInfo() )
//	{
//		const boost::shared_ptr<FpmlSerialized::ResetVariableInfo>& xml_resetRef = xml_serial->getResetVariableInfo();
//		const boost::shared_ptr<QuantLib::VariableInfo>& ql_varInfo = qlVarFactory.resetVariableInfo(xml_resetRef);
//		qlReturnCal->setResetRefVariable(ql_varInfo);
//	}
//
//	return qlReturnCal;
//}
//
//boost::shared_ptr<QuantLib::ReturnCalculationInfo> qlReturnCalculationFactory::returnCalInfo(const boost::shared_ptr<FpmlSerialized::ReturnCalculationInfo>& xml_serial)
//{
//	boost::shared_ptr<QuantLib::ReturnCalculationInfo> qlReturnCalInfo;
//
//	const std::vector<boost::shared_ptr<FpmlSerialized::ReturnCalculation>>& xml_returnCalList
//		= xml_serial->getReturnCalculation();
//
//	std::vector<boost::shared_ptr<QuantLib::ReturnCalculation>> ql_returnCalList;
//
//	for ( Size i=0 ; i<xml_returnCalList.size() ; i++)
//	{
//		ql_returnCalList.push_back(this->returnCal(xml_returnCalList[i]));
//	}
//	
//	boost::shared_ptr<QuantLib::OperatorND> ql_operatorND
//		= boost::shared_ptr<QuantLib::OperatorND>(
//					new QuantLib::IdentityOperatorND());
//
//	if ( !xml_serial->isOperatorND() && xml_returnCalList.size() > 1 )
//	{
//		boost::shared_ptr<FpmlSerialized::OperatorND> xml_operatorND
//			= xml_serial->getOperatorND();
//
//		qlOperatorFactory qlOF = qlOperatorFactory();
//
//		ql_operatorND = qlOF.operatorND(xml_operatorND);
//	}
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	qlReturnCalInfo = boost::shared_ptr<QuantLib::ReturnCalculationInfo>(
//				new ReturnCalculationInfo(ql_returnCalList,
//										ql_operatorND,
//										usingVariableInfoList));
//
//	return qlReturnCalInfo;
//}

boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCalculationFactory::e_returnCal(const boost::shared_ptr<FpmlSerialized::Excel_returnCalcInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCal;

	std::string returnType = xml_serial->getExcel_type()->SValue();

	if ( returnType == "excel_vanillaReturnCal" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_vanillaReturnCal>& e_vanillaReturnCal
			= xml_serial->getExcel_vanillaReturnCal();

		qlReturnCal = this->e_vanillaReturnCal(e_vanillaReturnCal);
	}
	else if ( returnType == "excel_constReturnCal" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_constReturnCal>& e_constReturnCal
			= xml_serial->getExcel_constReturnCal();

		qlReturnCal = this->e_constReturnCal(e_constReturnCal);
	}
	else
	{
		QL_FAIL("unknown returnType : " << returnType );
	}

	return qlReturnCal;
}


boost::shared_ptr<QuantLib::ReturnCalculationInfo> qlReturnCalculationFactory::e_returnCalcInfo(const boost::shared_ptr<FpmlSerialized::Excel_returnCalcInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReturnCalculationInfo> qlReturnCalcInfo;

	return qlReturnCalcInfo;

}

boost::shared_ptr<QuantLib::PreCalculation> qlReturnCalculationFactory::preCal(const boost::shared_ptr<FpmlSerialized::PreCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::PreCalculation> ql_preCal;



	return ql_preCal;
}

boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCalculationFactory::e_vanillaReturnCal(const boost::shared_ptr<FpmlSerialized::Excel_vanillaReturnCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReturnCalculation> vanillaReturnCal;

	qlReferenceCalculationFactory qlRefCalFactory = qlReferenceCalculationFactory();
	
	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_refCalc 
		= qlRefCalFactory.underlyingCalc(xml_serial->getExcel_underlyingCalcID());

	Real gearing = xml_serial->getGearing()->DValue();
	Real spread = xml_serial->getSpread()->DValue();

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	vanillaReturnCal = boost::shared_ptr<VanillaReturnCal>(
						new VanillaReturnCal(ql_refCalc,
											 gearing,
											 spread,
											 usingVariableInfoList));

	return vanillaReturnCal;
}

boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCalculationFactory::e_constReturnCal(const boost::shared_ptr<FpmlSerialized::Excel_constReturnCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReturnCalculation> constReturnCal;

	double constReturn = xml_serial->getConstReturn()->DValue();

	constReturnCal = boost::shared_ptr<ConstReturnCal>(
						new ConstReturnCal(constReturn));

	return constReturnCal;
}

//boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCalculationFactory::stopLossReturnCal(const boost::shared_ptr<FpmlSerialized::StopLossReturnCal>& xml_serial)
//{
//	boost::shared_ptr<QuantLib::ReturnCalculation> stopLossReturnCal;
//
//	qlReferenceCalculationFactory qlRefCalFactory = qlReferenceCalculationFactory();
//	
//	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_refCalInfo 
//		= qlRefCalFactory.referenceCalInfo(xml_serial->getReferenceCalculationInfo());
//
//	Real power = xml_serial->getPower()->DValue();
//	Real lossTrigger = xml_serial->getLossTrigger()->DValue();
//	Real maximumLoss = xml_serial->getMaximumLoss()->DValue();
//	//Real withNotional = xml_serial->getWithNotional()->DValue();
//
//	stopLossReturnCal = boost::shared_ptr<QuantLib::ReturnCalculation>(
//							new StopLossReturnCal(ql_refCalInfo,
//												power,
//												lossTrigger,
//												maximumLoss
//												//withNotional
//												));
//
//						
//
//	return stopLossReturnCal;
//}
//
//boost::shared_ptr<QuantLib::ReturnCalculation> qlReturnCalculationFactory::callPutCompositeReturnCal(const boost::shared_ptr<FpmlSerialized::CallPutCompositeReturnCal>& xml_serial)
//{
//	boost::shared_ptr<QuantLib::ReturnCalculation> ql_ReturnCal;
//
//	//Weight
//	std::vector<Real> ql_weight; 
//
//	for ( Size i=0 ;i<xml_serial->getWeight().size(); i++)
//	{
//		ql_weight.push_back(xml_serial->getWeight()[i]->DValue());
//	}
//
//	qlReferenceCalculationFactory qlRefCalFactory = qlReferenceCalculationFactory();
//	
//	//ReferenceCalculation
//	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_refCalInfo 
//		= qlRefCalFactory.referenceCalInfo(xml_serial->getReferenceCalculationInfo());
//
//	//OptionPayoffFunction
//	const std::vector<boost::shared_ptr<FpmlSerialized::OptionPayoffFunction>>& xml_optionPayoffFunction
//		= xml_serial->getOptionPayoffFunction();
//
//	std::vector<boost::shared_ptr<QuantLib::OptionPayoffFunction>> ql_optionPayoffFunction;
//
//	qlOptionPayoffFunctionFactory qlOPF = qlOptionPayoffFunctionFactory();
//
//	for ( Size i=0 ;i<xml_optionPayoffFunction.size(); i++)
//	{
//		ql_optionPayoffFunction.push_back(qlOPF.optionPayoff(xml_optionPayoffFunction[i]));
//	}
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	ql_ReturnCal = boost::shared_ptr<QuantLib::ReturnCalculation>(
//		new CallPutCompositeReturnCal(ql_weight,
//									  ql_refCalInfo,
//									  ql_optionPayoffFunction,
//									  usingVariableInfoList));
//
//	return ql_ReturnCal;
//}

}

