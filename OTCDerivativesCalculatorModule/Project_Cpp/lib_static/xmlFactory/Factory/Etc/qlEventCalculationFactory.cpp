#include "qlEventCalculationFactory.hpp"
#include <Factory/Etc/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlEventCalculationFactory::qlEventCalculationFactory()
{
}


boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
	eventCal(const boost::shared_ptr<FpmlSerialized::EventCalculation>& xml_serial)
{
	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;

	std::string eventType = xml_serial->getType()->SValue();

	if ( eventType == "upperBarrierEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::UpperBarrierEventCal>& xml_eventCal
			= xml_serial->getUpperBarrierEventCal();

		qlEventCal = this->upperBarrierEventCal(xml_eventCal);
	}

	else if ( eventType == "lowerBarrierEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::LowerBarrierEventCal>& xml_eventCal
			= xml_serial->getLowerBarrierEventCal();

		qlEventCal = this->lowerBarrierEventCal(xml_eventCal);
	}
	//else if ( eventType == "lowerBarrierEventCal" )
	//{
	//	const boost::shared_ptr<FpmlSerialized::LowerBarrierEventCal>& xml_eventCal
	//		= xml_serial->getLowerBarrierEventCal();

	//	qlEventCal = this->lowerBarrierEventCal(xml_eventCal);
	//}
	//else if ( eventType == "dualBarrierEventCal" )
	//{
	//	const boost::shared_ptr<FpmlSerialized::DualBarrierEventCal>& xml_eventCal
	//		= xml_serial->getDualBarrierEventCal();

	//	qlEventCal = this->dualBarrierEventCal(xml_eventCal);
	//}
	//else if ( eventType == "simpleBarrierEventCal" )
	//{
	//	const boost::shared_ptr<FpmlSerialized::SimpleBarrierEventCal>& xml_eventCal
	//		= xml_serial->getSimpleBarrierEventCal();

	//	qlEventCal = this->simpleBarrierEventCal(xml_eventCal);
	//}
	else if ( eventType == "simpleRangeEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::SimpleRangeEventCal>& xml_eventCal
			= xml_serial->getSimpleRangeEventCal();

		qlEventCal = this->simpleRangeEventCal(xml_eventCal);
	}
	else if ( eventType == "referenceEventCal" )
	{
		const boost::shared_ptr<FpmlSerialized::ReferenceEventCal>& xml_eventCal
			= xml_serial->getReferenceEventCal();

		qlEventCal = this->referenceEventCal(xml_eventCal);
	}
	/*else if ( eventType == "constReturnCal" )
	{
		const boost::shared_ptr<FpmlSerialized::ConstReturnCal>& xml_constCal
			= xml_serial->getConstReturnCal();

		qlEventCal = this->constReturnCal(xml_constCal);
	
	}
	else if ( eventType == "stopLossReturnCal" )
	{
		const boost::shared_ptr<FpmlSerialized::StopLossReturnCal>& xml_stopLossReturnCal
			= xml_serial->getStopLossReturnCal();

		qlEventCal = this->stopLossReturnCal(xml_stopLossReturnCal);
	
	}*/
	else
	{
		QL_FAIL("unknown returnType : " << eventType );
	}

	qlVariableEventInfoFactory qlVEIF = qlVariableEventInfoFactory ();

	if ( !xml_serial->isRefVariable_eventOcc() )
	{
		const boost::shared_ptr<FpmlSerialized::VariableEventInfo>& xml_varEventinfo
			= xml_serial->getRefVariable_eventOcc()->getVariableEventInfo();

		qlEventCal->setRefVariableEventOcc(qlVEIF.variableEventInfo(xml_varEventinfo));
	}else
	{
		qlEventCal->setRefVariableEventOcc(qlVEIF.nullVariableEventInfo());
	}

	if ( !xml_serial->isPastEventOcc() )
	{
		bool pastEventOcc = xml_serial->getPastEventOcc()->BValue();
		qlEventCal->setPastEventOcc(pastEventOcc);
	}
	

	//qlEventCal->setEventRefOcc(refName);

	return qlEventCal;
}


boost::shared_ptr<QuantLib::EventCalculationInfo> qlEventCalculationFactory::eventCalInfo(const boost::shared_ptr<FpmlSerialized::EventCalculationInfo>& xml_serial)
{
	boost::shared_ptr<QuantLib::EventCalculationInfo> qlEventCalInfo;

	const std::vector<boost::shared_ptr<FpmlSerialized::EventCalculation>>& xml_eventList
		= xml_serial->getEventCalculation();

	qlJointSimpleCalculationFactory qljscf = qlJointSimpleCalculationFactory();

	std::vector<boost::shared_ptr<QuantLib::EventCalculation>> ql_eventList;

	for ( Size i=0 ; i<xml_eventList.size() ; i++)
	{
		ql_eventList.push_back(this->eventCal(xml_eventList[i]));
	}

	boost::shared_ptr<QuantLib::JointSimpleCalculation> ql_jointSimpleCal
		= boost::shared_ptr<QuantLib::JointSimpleCalculation>(
				new QuantLib::IdentitySimpleCal());

	if ( !xml_serial->isJointSimpleCalculation() && xml_eventList.size() > 1)
	{
		const boost::shared_ptr<FpmlSerialized::JointSimpleCalculation>& xml_jointSimpleCal
			= xml_serial->getJointSimpleCalculation();

		ql_jointSimpleCal = qljscf.jointSimpleCal(xml_jointSimpleCal);
	}

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	qlEventCalInfo = boost::shared_ptr<QuantLib::EventCalculationInfo>(
		new QuantLib::EventCalculationInfo(ql_eventList,
										  ql_jointSimpleCal,
										  usingVariableInfoList));

	// info에도 이게 있어야함
	qlVariableEventInfoFactory qlVEIF = qlVariableEventInfoFactory ();

	if ( !xml_serial->isRefVariable_eventOcc() )
	{
		const boost::shared_ptr<FpmlSerialized::VariableEventInfo>& xml_varEventinfo
			= xml_serial->getRefVariable_eventOcc()->getVariableEventInfo();

		qlEventCalInfo->setRefVariableEventOcc(qlVEIF.variableEventInfo(xml_varEventinfo));
	}else
	{
		qlEventCalInfo->setRefVariableEventOcc(qlVEIF.nullVariableEventInfo());
	}

	if ( !xml_serial->isPastEventOcc() )
	{
		bool pastEventOcc = xml_serial->getPastEventOcc()->BValue();
		qlEventCalInfo->setPastEventOcc(pastEventOcc);
	}

	return qlEventCalInfo;

}

boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::e_eventCal(const boost::shared_ptr<FpmlSerialized::Excel_eventCalcInfo>& xml_serial)
{
	std::string type = xml_serial->getExcel_type()->SValue();
	
	boost::shared_ptr<QuantLib::EventCalculation> qlEventCall;

	qlReferenceCalculationFactory ql_rc_factory = qlReferenceCalculationFactory();

	if ( type == "excel_singleBarrierEventCal")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_singleBarrierEventCal>& e_sbec = xml_serial->getExcel_singleBarrierEventCal();

		// date
		QuantLib::Date obStartDate =  e_sbec->getObservationStartDate()->dateValue();
		QuantLib::Date obEndDate = e_sbec->getObservationEndDate()->dateValue();

		boost::shared_ptr<QuantLib::DailyInterval> ql_interval
				= boost::shared_ptr<QuantLib::DailyInterval>(
						new QuantLib::DailyInterval(obStartDate,obEndDate));

		//boost::shared_ptr<QuantLib::DateInformation> dateInfo;
			//= boost::shared_ptr<QuantLib::DateInformation>(new QuantLib::DateInformation());

		//dateInfoList.push_back(dateInfo);
		
		std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

		// trigger
		Real trigger = e_sbec->getLowerTrigger()->DValue();

		//refCal
		const boost::shared_ptr<QuantLib::ReferenceCalculation> ql_refCal
			= ql_rc_factory.underlyingCalc(e_sbec->getExcel_underlyingCalcID());

		qlEventCall = boost::shared_ptr<QuantLib::LowerBarrierEventCal>(
			new QuantLib::LowerBarrierEventCal(ql_interval,trigger,ql_refCal,usingVariableInfoList));
	}
	else if ( type == "excel_singleRangeEventCal")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_singleRangeEventCal>& e_srec = xml_serial->getExcel_singleRangeEventCal();
		// date
		boost::shared_ptr<QuantLib::DateList> ql_dateList;

		std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

		// trigger
		Real lowerRng = e_srec->getLowerRng()->DValue();
		Real upperRng = e_srec->getUpperRng()->DValue();

		const boost::shared_ptr<QuantLib::Range1D>& ql_range1D 
				= boost::shared_ptr<QuantLib::Range1D>(
					new QuantLib::Range1D(upperRng,false,lowerRng,false));
		//refCal
		const boost::shared_ptr<QuantLib::ReferenceCalculation> ql_refCal
			= ql_rc_factory.underlyingCalc(e_srec->getExcel_underlyingCalcID());

		qlEventCall = boost::shared_ptr<QuantLib::SimpleRangeEventCal>(
			new QuantLib::SimpleRangeEventCal(ql_range1D,ql_refCal,usingVariableInfoList));
	}

	
	return qlEventCall;
}

boost::shared_ptr<QuantLib::EventCalculationInfo> qlEventCalculationFactory::e_eventCalcInfo(const boost::shared_ptr<FpmlSerialized::Excel_eventCalcInfo>& xml_serial)
{
	std::string type = xml_serial->getExcel_type()->SValue();
	
	boost::shared_ptr<QuantLib::EventCalculationInfo> qlEventCalInfo;

	qlReferenceCalculationFactory ql_rc_factory = qlReferenceCalculationFactory();

	if ( type == "excel_singleBarrierEventCal")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_singleBarrierEventCal>& e_sbec = xml_serial->getExcel_singleBarrierEventCal();
		// date
		boost::shared_ptr<QuantLib::DateList> ql_dateList;

		//boost::shared_ptr<QuantLib::DateInformation> dateInfo;
			//= boost::shared_ptr<QuantLib::DateInformation>(new QuantLib::DateInformation());

		//dateInfoList.push_back(dateInfo);
		
		std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

		// trigger
		Real trigger = e_sbec->getLowerTrigger()->DValue();

		//refCal
		const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_refCal
			= ql_rc_factory.underlyingCalc(e_sbec->getExcel_underlyingCalcID());

		//qlEventCalInfo = boost::shared_ptr<QuantLib::LowerBarrierEventCal>(
		//	new QuantLib::LowerBarrierEventCal(ql_dateList,trigger,ql_refCal,usingVariableInfoList));
	}else if ( type == "excel_singleRangeEventCal")
	{
	
	}
	
	return qlEventCalInfo;
}


//boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
//	simpleBarrierEventCal(const boost::shared_ptr<FpmlSerialized::SimpleBarrierEventCal>& xml_serial)
//{
//	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;
//
//	const boost::shared_ptr<FpmlSerialized::BarrierInfo>& xml_barrierInfo = xml_serial->getBarrierInfo();
//
//	qlEventTriggerInfoFactory qlETIF = qlEventTriggerInfoFactory();
//
//	boost::shared_ptr<QuantLib::EventTriggerInfo> ql_barrierETI
//		= qlETIF.barrierInfoETI(xml_barrierInfo);
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
//					new QuantLib::SimpleBarrierEventCal(ql_barrierETI,usingVariableInfoList));
//
//	return qlEventCal;
//}

//boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
//	simpleBarrierEventCal(const boost::shared_ptr<FpmlSerialized::SimpleBarrierEventCal>& xml_serial)
//{
//	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;
//
//	const boost::shared_ptr<FpmlSerialized::BarrierInfo>& xml_barrierInfo = xml_serial->getBarrierInfo();
//
//	qlEventTriggerInfoFactory qlETIF = qlEventTriggerInfoFactory();
//
//	boost::shared_ptr<QuantLib::EventTriggerInfo> ql_barrierETI
//		= qlETIF.barrierInfoETI(xml_barrierInfo);
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
//					new QuantLib::SimpleBarrierEventCal(ql_barrierETI,usingVariableInfoList));
//
//	return qlEventCal;
//}

//boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
//	simpleBarrierEventCal(const boost::shared_ptr<FpmlSerialized::SimpleBarrierEventCal>& xml_serial)
//{
//	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;
//
//	const boost::shared_ptr<FpmlSerialized::BarrierInfo>& xml_barrierInfo = xml_serial->getBarrierInfo();
//
//	qlEventTriggerInfoFactory qlETIF = qlEventTriggerInfoFactory();
//
//	boost::shared_ptr<QuantLib::EventTriggerInfo> ql_barrierETI
//		= qlETIF.barrierInfoETI(xml_barrierInfo);
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
//					new QuantLib::SimpleBarrierEventCal(ql_barrierETI,usingVariableInfoList));
//
//	return qlEventCal;
//}

boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
	upperBarrierEventCal(const boost::shared_ptr<FpmlSerialized::UpperBarrierEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;

	qlDateInformationFactory qlDIF = qlDateInformationFactory();

	const std::vector<boost::shared_ptr<FpmlSerialized::DateInformation>>& xml_dateInfoList
		= xml_serial->getDateInformation();
	
	const std::vector<boost::shared_ptr<FpmlSerialized::XsdTypeDouble>>& xml_upperTrigger
		= xml_serial->getUpperTrigger();

	std::vector<boost::shared_ptr<QuantLib::DateInformation>> ql_dateInfoList;
	std::vector<Real> ql_upperTrrigerList;

	for ( Size i=0 ; i < xml_dateInfoList.size() ; i++ )
	{
		ql_dateInfoList.push_back(qlDIF.dateInfo(xml_dateInfoList[i]));
		ql_upperTrrigerList.push_back(xml_upperTrigger[i]->DValue());
	}

	qlReferenceCalculationFactory qlRCF = qlReferenceCalculationFactory();

	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_refCalInfo =
		qlRCF.referenceCalInfo(xml_serial->getReferenceCalculationInfo());

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
					new QuantLib::UpperBarrierEventCal(ql_dateInfoList,
														ql_upperTrrigerList,
														ql_refCalInfo,
														usingVariableInfoList));

	return qlEventCal;
}

boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
	lowerBarrierEventCal(const boost::shared_ptr<FpmlSerialized::LowerBarrierEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;

	qlDateInformationFactory qlDIF = qlDateInformationFactory();

	const std::vector<boost::shared_ptr<FpmlSerialized::DateInformation>>& xml_dateInfoList
		= xml_serial->getDateInformation();
	
	const std::vector<boost::shared_ptr<FpmlSerialized::XsdTypeDouble>>& xml_lowerTrigger
		= xml_serial->getLowerTrigger();

	std::vector<boost::shared_ptr<QuantLib::DateInformation>> ql_dateInfoList;
	std::vector<Real> ql_lowerTrrigerList;

	for ( Size i=0 ; i < xml_dateInfoList.size() ; i++ )
	{
		ql_dateInfoList.push_back(qlDIF.dateInfo(xml_dateInfoList[i]));
		ql_lowerTrrigerList.push_back(xml_lowerTrigger[i]->DValue());
	}

	qlReferenceCalculationFactory qlRCF = qlReferenceCalculationFactory();

	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_refCalInfo =
		qlRCF.referenceCalInfo(xml_serial->getReferenceCalculationInfo());

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
					new QuantLib::LowerBarrierEventCal(ql_dateInfoList,
														ql_lowerTrrigerList,
														ql_refCalInfo,
														usingVariableInfoList));

	return qlEventCal;
}

boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
	simpleRangeEventCal(const boost::shared_ptr<FpmlSerialized::SimpleRangeEventCal>& xml_serial)
{

	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;

	qlReferenceCalculationFactory qlRefCalFactory = qlReferenceCalculationFactory();

	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_refCalInfo 
		= qlRefCalFactory.referenceCalInfo(xml_serial->getReferenceCalculationInfo());

	qlRangeEventFactory qlREF = qlRangeEventFactory();

	const boost::shared_ptr<FpmlSerialized::Range1D>& xml_range1D = xml_serial->getRange1D();
	const boost::shared_ptr<QuantLib::Range1D>& ql_range1D = qlREF.range1D(xml_range1D);

	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	if ( !xml_serial->isDateInformation() == true )
	{
		qlDateInformationFactory qlDIF =qlDateInformationFactory();
		
		const boost::shared_ptr<FpmlSerialized::DateInformation>& xml_dateInfo
			= xml_serial->getDateInformation();
		const boost::shared_ptr<QuantLib::DateInformation>& ql_dateInfo
			= qlDIF.dateInfo(xml_dateInfo);

		qlJointSimpleCalculationFactory qlJSCF = qlJointSimpleCalculationFactory();

		const boost::shared_ptr<FpmlSerialized::JointSimpleCalculation>& xml_jointSimpleCal
			= xml_serial->getJointSimpleCalculation();
		const boost::shared_ptr<QuantLib::JointSimpleCalculation>& ql_jointSimpleCal
			= qlJSCF.jointSimpleCal(xml_jointSimpleCal);

		qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
						new QuantLib::SimpleRangeEventTimeCal(ql_range1D,
														ql_refCalInfo,
														ql_dateInfo,
														ql_jointSimpleCal,
														usingVariableInfoList));	
	}else
	{
		qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
						new QuantLib::SimpleRangeEventCal(ql_range1D,
														ql_refCalInfo,
														usingVariableInfoList));	
	}


	

	return qlEventCal;
}

boost::shared_ptr<QuantLib::EventCalculation> qlEventCalculationFactory::
	referenceEventCal(const boost::shared_ptr<FpmlSerialized::ReferenceEventCal>& xml_serial)
{
	boost::shared_ptr<QuantLib::EventCalculation> qlEventCal;

	const std::string& refEventName = xml_serial->getRefName()->SValue();
	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;

	qlEventCal = boost::shared_ptr<QuantLib::EventCalculation>(
					new QuantLib::ReferenceEventCal(refEventName,
													usingVariableInfoList));

	return qlEventCal;
}


}

