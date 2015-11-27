#include "qlReferenceCalculationFactory.hpp"
#include <src/Engine/MonteCarlo/pricer/event/constPayoffEventTriggerInfo.hpp>
//#include <src/Engine/MonteCarlo/pricer/event/autoCallConstReturneventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/pricer/event/barrierEvent/all.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/all.hpp>
#include <Factory/Etc/qlFixingDateInfoFactory.hpp>
#include <Factory/Etc/qlVariableInfoFactory.hpp>
#include <Factory/Etc/qlPostCalculationFactory.hpp>
#include <Factory/Etc/qlOperatorFactory.hpp>
#include <Factory/Etc/qlFixingInformationFactory.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlReferenceCalculationFactory::qlReferenceCalculationFactory()
{

}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::referenceCal(const boost::shared_ptr<FpmlSerialized::ReferenceCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCal;

	std::string referType = xml_serial->getType()->SValue();

	if ( referType == "identityReferenceCal" )
	{
		const boost::shared_ptr<FpmlSerialized::IdentityReferenceCal>& xml_identityCal
			= xml_serial->getIdentityReferenceCal();

		qlReferenceCal = this->identityReferenceCal(xml_identityCal);
	}
	else if ( referType == "choiceReferenceCal" )
	{
		const boost::shared_ptr<FpmlSerialized::ChoiceReferenceCal>& xml_choiceCal
			= xml_serial->getChoiceReferenceCal();

		qlReferenceCal = this->choiceReferenceCal(xml_choiceCal);
	}
	else if ( referType == "maximumReferenceCal" )
	{
		const boost::shared_ptr<FpmlSerialized::MaximumReferenceCal>& xml_maximumCal
			= xml_serial->getMaximumReferenceCal();

		qlReferenceCal = this->maximumReferenceCal(xml_maximumCal);
	
	}
	else if ( referType == "minimumReferenceCal" )
	{
		const boost::shared_ptr<FpmlSerialized::MinimumReferenceCal>& xml_minimumCal
			= xml_serial->getMinimumReferenceCal();

		qlReferenceCal = this->minimumReferenceCal(xml_minimumCal);
	
	}
	else if ( referType == "refVariableReferenceCal" )
	{
		const boost::shared_ptr<FpmlSerialized::RefVariableReferenceCal>& xml_refVariableReferenceCal
			= xml_serial->getRefVariableReferenceCal();

		qlReferenceCal = this->refVariableReferenceCal(xml_refVariableReferenceCal);
	
	}
	else if ( referType == "dailyReturnReferenceCal" )
	{
		const boost::shared_ptr<FpmlSerialized::DailyReturnReferenceCal>& xml_dailyReturnReferenceCal
			= xml_serial->getDailyReturnReferenceCal();

		qlReferenceCal = this->dailyReturnReferenceCal(xml_dailyReturnReferenceCal);
	
	}
	else
	{
		QL_FAIL("unknown referenceType : " << referType );	
	}

	
	
	//preFixed set
	//if ( !xml_serial->isFixingInformation() )
	//{
	//	const boost::shared_ptr<FpmlSerialized::FixingInformation>& xml_fixingInfo = xml_serial->getFixingInformation();

	//	qlFixingInformationFactory qlFIF = qlFixingInformationFactory();

	//	const boost::shared_ptr<QuantLib::FixingInformation>& ql_fixingInfo =
	//					qlFIF.fixingInfo(xml_fixingInfo);
	//	qlReferenceCal->setFixingInformation(ql_fixingInfo);
	//}

	//postCal set
	if ( !xml_serial->isPostCalculation() )
	{
		qlPostCalculationFactory qlPostCalFactory = qlPostCalculationFactory();
		const boost::shared_ptr<FpmlSerialized::PostCalculation>& xml_postCal = xml_serial->getPostCalculation();
		const boost::shared_ptr<QuantLib::PostCalculation>& ql_postCal = qlPostCalFactory.postCal( xml_postCal );
		qlReferenceCal->setPostCalculation(ql_postCal);
	}

	qlVariableInfoFactory qlVarFactory = qlVariableInfoFactory();

	//refVariable_returnValue set
	if ( !xml_serial->isRefVariable_referenceValue() )
	{
		const boost::shared_ptr<FpmlSerialized::RefVariable_referenceValue>& xml_refReturn = xml_serial->getRefVariable_referenceValue();
		const boost::shared_ptr<QuantLib::VariableInfo>& ql_varInfo = qlVarFactory.variableInfo(xml_refReturn->getVariableInfo());
		qlReferenceCal->setReferenceRefVariable(ql_varInfo);
	}


	return qlReferenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::underlyingCalc(const boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcID>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCal;

	std::string referType = xml_serial->getExcel_type()->SValue();

	if ( referType == "excel_maximumUnderlyingCalcID" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_maximumUnderlyingCalcID>& xml_maximumCal
			= xml_serial->getExcel_maximumUnderlyingCalcID();

		qlReferenceCal = this->e_maximumReferenceCal(xml_maximumCal);
	
	}
	else if ( referType == "excel_minimumUnderlyingCalcID" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_minimumUnderlyingCalcID>& xml_minimumCal
			= xml_serial->getExcel_minimumUnderlyingCalcID();

		qlReferenceCal = this->e_minimumReferenceCal(xml_minimumCal);	
	}
	else if ( referType == "excel_choiceUnderlyingCalcID" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_choiceUnderlyingCalcID>& xml_choiceCal
			= xml_serial->getExcel_choiceUnderlyingCalcID();

		qlReferenceCal = this->e_choiceReferenceCal(xml_choiceCal);	
	}
	
	else
	{
		QL_FAIL("unknown referenceType : " << referType );	
	}

	return qlReferenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculationInfo> qlReferenceCalculationFactory::referenceCalInfo(const boost::shared_ptr<FpmlSerialized::ReferenceCalculationInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculationInfo> ql_refCalInfo;

	const std::vector<boost::shared_ptr<FpmlSerialized::ReferenceCalculation>>& xml_referenceCalList
		= xml_serial->getReferenceCalculation();

	std::vector<boost::shared_ptr<QuantLib::ReferenceCalculation>> ql_referenceCalList;

	for ( Size i=0 ; i<xml_referenceCalList.size() ; i++)
	{
		ql_referenceCalList.push_back(this->referenceCal(xml_referenceCalList[i]));
	}
	
	qlOperatorFactory qlOF = qlOperatorFactory();

	boost::shared_ptr<QuantLib::OperatorND> ql_operatorND
		= qlOF.identityOperND();

	if ( !xml_serial->isOperatorND() && xml_referenceCalList.size() != 1 )
	{
		boost::shared_ptr<FpmlSerialized::OperatorND> xml_operatorND
			= xml_serial->getOperatorND();

		ql_operatorND = qlOF.operatorND(xml_operatorND);
	}

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	ql_refCalInfo = boost::shared_ptr<QuantLib::ReferenceCalculationInfo>(
				new ReferenceCalculationInfo(ql_referenceCalList,
										ql_operatorND,
										usingVariableInfoList));

	return ql_refCalInfo;
}


//e_maximumReferenceCal
boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::e_maximumReferenceCal(const boost::shared_ptr<FpmlSerialized::Excel_maximumUnderlyingCalcID>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> maximumReferenceCal;
	
	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
	
	QuantLib::Date eventDate = xml_serial->getEventDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(eventDate);

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	std::vector<std::string> ql_selectedUnderName;

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_selectedUnderlying>> xml_selectedUnder
		= xml_serial->getExcel_selectedUnderlying();

	for ( Size i=0 ; i<xml_selectedUnder.size() ; i++ )
	{
		std::string code = xml_selectedUnder[i]->getCode()->SValue();
		bool checked = xml_selectedUnder[i]->getChecked()->BValue();
		
		if ( checked )
		//if ( true )
		{
			ql_selectedUnderName.push_back(code);
		}
	}

	maximumReferenceCal = boost::shared_ptr<QuantLib::MaximumReferenceCal>( 
						new MaximumReferenceCal(fixingDateInfo,
												ql_selectedUnderName,
												usingVariableInfoList) );

	return maximumReferenceCal;
}

//e_minimumReferenceCal
boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::e_minimumReferenceCal(const boost::shared_ptr<FpmlSerialized::Excel_minimumUnderlyingCalcID>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> minimumReferenceCal;
	
	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
	
	QuantLib::Date eventDate = xml_serial->getEventDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(eventDate);

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	std::vector<std::string> ql_selectedUnderName;

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_selectedUnderlying>> xml_selectedUnder
		= xml_serial->getExcel_selectedUnderlying();

	for ( Size i=0 ; i<xml_selectedUnder.size() ; i++ )
	{
		std::string code = xml_selectedUnder[i]->getCode()->SValue();
		bool checked = xml_selectedUnder[i]->getChecked()->BValue();
		
		if ( checked )
		{
			ql_selectedUnderName.push_back(code);
		}
	}

	minimumReferenceCal = boost::shared_ptr<QuantLib::MinimumReferenceCal>( 
						new MinimumReferenceCal(fixingDateInfo,
												ql_selectedUnderName,
												usingVariableInfoList) );

	return minimumReferenceCal;
}

//e_choiceReferenceCal
boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::e_choiceReferenceCal(const boost::shared_ptr<FpmlSerialized::Excel_choiceUnderlyingCalcID>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> choiceReferenceCal;
	
	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
	
	QuantLib::Date eventDate = xml_serial->getEventDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(eventDate);

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	std::vector<std::string> ql_selectedUnderName;

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_selectedUnderlying>> xml_selectedUnder
		= xml_serial->getExcel_selectedUnderlying();

	for ( Size i=0 ; i<xml_selectedUnder.size() ; i++ )
	{
		std::string code = xml_selectedUnder[i]->getCode()->SValue();
		bool checked = xml_selectedUnder[i]->getChecked()->BValue();
		
		if ( checked )
		//if ( true )
		{
			ql_selectedUnderName.push_back(code);
		}
	}

	choiceReferenceCal = boost::shared_ptr<QuantLib::ChoiceReferenceCal>( 
						new ChoiceReferenceCal(fixingDateInfo,
												ql_selectedUnderName[0],
												usingVariableInfoList) );

	return choiceReferenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::e_choiceReferenceCal_singeCode(const std::string& code , Date fixingDate )
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> choice_referenceCal;

	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(fixingDate);

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	choice_referenceCal = boost::shared_ptr<QuantLib::ChoiceReferenceCal>( 
								new ChoiceReferenceCal(ql_fixingDate,
														code ,
														usingVariableInfoList) );

	return choice_referenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::e_identityReferenceCal_singeCode(const std::string& code , Date fixingDate )
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> identity_referenceCal;

	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(fixingDate);

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	identity_referenceCal = boost::shared_ptr<QuantLib::IdentityReferenceCal>( 
								new QuantLib::IdentityReferenceCal(ql_fixingDate,
														code ,
														usingVariableInfoList) );

	return identity_referenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::identityReferenceCal(const boost::shared_ptr<FpmlSerialized::IdentityReferenceCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> identityRefCal;

	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());

	const std::string& code = xml_serial->getKrCode()->SValue();
	
	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	identityRefCal = boost::shared_ptr<IdentityReferenceCal>(
						new IdentityReferenceCal(fixingDateInfo,
												code,
												usingVariableInfoList));

	return identityRefCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::choiceReferenceCal(const boost::shared_ptr<FpmlSerialized::ChoiceReferenceCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> choiceRefCal;

	std::string code = xml_serial->getSelectedUnderName()->SValue();

	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	choiceRefCal = boost::shared_ptr<QuantLib::ChoiceReferenceCal>(
						new QuantLib::ChoiceReferenceCal(fixingDateInfo,
														code,
														usingVariableInfoList));

	return choiceRefCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::maximumReferenceCal(const boost::shared_ptr<FpmlSerialized::MaximumReferenceCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> maximumReferenceCal;
	
	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	std::vector<std::string> ql_selectedUnderName;

	std::vector<boost::shared_ptr<FpmlSerialized::XsdTypeToken>> xml_selectedUnderName
		= xml_serial->getSelectedUnderName();

	for ( Size i=0 ; i<xml_selectedUnderName.size() ; i++ )
	{
		ql_selectedUnderName.push_back(xml_selectedUnderName[i]->SValue());
	}

	maximumReferenceCal = boost::shared_ptr<QuantLib::MaximumReferenceCal>( 
						new MaximumReferenceCal(fixingDateInfo,
												ql_selectedUnderName,
												usingVariableInfoList) );

	return maximumReferenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::minimumReferenceCal(const boost::shared_ptr<FpmlSerialized::MinimumReferenceCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> minimumReferenceCal;

	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	std::vector<std::string> ql_selectedUnderName;

	std::vector<boost::shared_ptr<FpmlSerialized::XsdTypeToken>> xml_selectedUnderName
		= xml_serial->getSelectedUnderName();

	for ( Size i=0 ; i<xml_selectedUnderName.size() ; i++ )
	{
		ql_selectedUnderName.push_back(xml_selectedUnderName[i]->SValue());
	}

	minimumReferenceCal = boost::shared_ptr<QuantLib::MinimumReferenceCal>( 
						new MinimumReferenceCal(fixingDateInfo,
												ql_selectedUnderName,
												usingVariableInfoList));

	return minimumReferenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::refVariableReferenceCal(const boost::shared_ptr<FpmlSerialized::RefVariableReferenceCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> refVarReferenceCal;

	const std::string& refName = xml_serial->getRefName()->SValue();

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	refVarReferenceCal = boost::shared_ptr<QuantLib::ReferenceCalculation>(
								new RefVariableReferenceCal(refName,
															usingVariableInfoList));

	return refVarReferenceCal;
}

boost::shared_ptr<QuantLib::ReferenceCalculation> qlReferenceCalculationFactory::dailyReturnReferenceCal(const boost::shared_ptr<FpmlSerialized::DailyReturnReferenceCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::ReferenceCalculation> dailyReturnRefCal;

	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();

	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());

	const std::string& code = xml_serial->getKrCode()->SValue();

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	dailyReturnRefCal = boost::shared_ptr<QuantLib::ReferenceCalculation>(
										new DailyReturnReferenceCal(fixingDateInfo,
																	code,
																	usingVariableInfoList));

	return dailyReturnRefCal;
}

}

