#include "qlEventTriggerInfoFactory.hpp"
#include <src/Engine/MonteCarlo/pricer/event/all.hpp>
#include <src/Engine/MonteCarlo/pricer/event/simpleOption/all.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/all.hpp>
#include <src/Engine/MonteCarlo/IRProduct/couponCalculation/all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/all.hpp>
#include <src/Engine/MonteCarlo/autoTerminationETI.hpp>
#include <src/Engine/MonteCarlo/preEventCalculation/preEventCalculation.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/all.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/all.hpp>
#include <Factory/Etc/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlEventTriggerInfoFactory::qlEventTriggerInfoFactory()
{

}

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::autoTerminationETI(const boost::shared_ptr<FpmlSerialized::AutoTerminationTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> eventTriggerInfo;
//	
//	qlEventCalculationFactory qlECF = qlEventCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::EventCalculationInfo>& xml_eventCalInfo = xml_serial->getEventCalculationInfo();
//	const boost::shared_ptr<QuantLib::EventCalculationInfo>& ql_eventCalInfo = qlECF.eventCalInfo(xml_eventCalInfo);
//
//	qlReturnCalculationFactory qlRCF = qlReturnCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::ReturnCalculationInfo>& xml_returnCalInfo = xml_serial->getReturnCalculationInfo();
//	const boost::shared_ptr<QuantLib::ReturnCalculationInfo>& ql_returnCalInfo = qlRCF.returnCalInfo(xml_returnCalInfo);
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	eventTriggerInfo = boost::shared_ptr<EventTriggerInfo>(
//				new AutoTerminationETI(ql_eventCalInfo,
//										ql_returnCalInfo,
//										payoffDateInfo,
//										usingVariableInfoList));
//
//	return eventTriggerInfo;
//
//}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::schedule(const boost::shared_ptr<FpmlSerialized::Excel_schedule >& xml_schedule)
{
	boost::shared_ptr<EventTriggerInfo> eventTriggerInfo;

	const std::string& eventTriggerType = xml_schedule->getExcel_type()->SValue();

	if ( eventTriggerType == "excel_simpleCalculation" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_simpleCalculation>& e_sc
						= xml_schedule->getExcel_simpleCalculation();

		eventTriggerInfo = this->excel_simpleCalculation(e_sc);
	}

	// additional option 
	qlAdditionalOptionFactory ql_aofactory = qlAdditionalOptionFactory();

	const boost::shared_ptr<Excel_additionalOption>& serial_additionalCoupon
		= xml_schedule->getExcel_additionalOption();

	const boost::shared_ptr<QuantLib::AdditionalOption> ql_additionalOption
		= ql_aofactory.additionalOption(serial_additionalCoupon);

	eventTriggerInfo->setAdditionalOption(ql_additionalOption);


	return eventTriggerInfo;
}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::couponSchedule(
	const boost::shared_ptr<FpmlSerialized::Excel_couponSchedule >& xml_couponSchedule)
{
	boost::shared_ptr<EventTriggerInfo> eventTriggerInfo;
	
	// type set


	const std::string& eventTriggerType = xml_couponSchedule->getExcel_type()->SValue();

	if ( eventTriggerType == "excel_multiCondi_structuredCouponSchedule" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_structuredCouponSchedule>& e_mc_scs
						= xml_couponSchedule->getExcel_multiCondi_structuredCouponSchedule();

		eventTriggerInfo = this->excel_multiCondi_structuredCouponSchedule(e_mc_scs);
	}

	else if ( eventTriggerType == "excel_fixedCouponSchedule" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponSchedule>& e_fcs
						= xml_couponSchedule->getExcel_fixedCouponSchedule();

		eventTriggerInfo = this->excel_fixedCouponSchedule(e_fcs);
	}
	else if ( eventTriggerType == "excel_vanillaFloatingCouponSchedule" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_vanillaFloatingCouponSchedule>& e_vfcs
						= xml_couponSchedule->getExcel_vanillaFloatingCouponSchedule();

		eventTriggerInfo = this->excel_vanillaFloatingCouponSchedule(e_vfcs);
	}
	else if ( eventTriggerType == "excel_multiCondi_structuredCouponSchedule" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_structuredCouponSchedule>& e_mc_scs
						= xml_couponSchedule->getExcel_multiCondi_structuredCouponSchedule();

		eventTriggerInfo = this->excel_multiCondi_structuredCouponSchedule(e_mc_scs);
	}
	else if ( eventTriggerType == "excel_multiCondi_structuredAccrualCouponSchedule" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_structuredAccrualCouponSchedule>& e_mc_sacs
						= xml_couponSchedule->getExcel_multiCondi_structuredAccrualCouponSchedule();

		eventTriggerInfo = this->excel_multiCondi_structuredAccrualCouponSchedule(e_mc_sacs);
	}
	else if ( eventTriggerType == "excel_multiCondi_multiRng_structuredAccrualCouponSchedule" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_multiRng_structuredAccrualCouponSchedule>& e_mc_mr_sacs
						= xml_couponSchedule->getExcel_multiCondi_multiRng_structuredAccrualCouponSchedule();

		eventTriggerInfo = this->excel_multiCondi_multiRng_structuredAccrualCouponSchedule(e_mc_mr_sacs);
	}
	else
	{
		QL_FAIL("unknown eventTrigger Type");
	}
	
	// additional option 
	qlAdditionalOptionFactory ql_aofactory = qlAdditionalOptionFactory();

	const boost::shared_ptr<Excel_additionalOption>& serial_additionalCoupon
		= xml_couponSchedule->getExcel_additionalOption();

	const boost::shared_ptr<QuantLib::AdditionalOption> ql_additionalOption
		= ql_aofactory.additionalOption(serial_additionalCoupon);

	eventTriggerInfo->setAdditionalOption(ql_additionalOption);

	return eventTriggerInfo;
}
// private member

// ---------------------------------------- hifive ---------------------------------------------
boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_simpleCalculation(const boost::shared_ptr<FpmlSerialized::Excel_simpleCalculation>& xml_simpleCal)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date payoffDate = xml_simpleCal->getPayoffDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);

	const boost::shared_ptr<Excel_eventCalcInfo>& e_ec = xml_simpleCal->getExcel_eventCalcInfo();
	const boost::shared_ptr<Excel_returnCalcInfo>& e_rc = xml_simpleCal->getExcel_returnCalcInfo();
	const boost::shared_ptr<Excel_complementReturnCalc>& e_crc = xml_simpleCal->getExcel_complementReturnCalc();

	const boost::shared_ptr<Excel_eventCalcInfo_Call>& e_ecc = xml_simpleCal->getExcel_eventCalcInfo_Call();
	const boost::shared_ptr<Excel_returnCalcInfo_Call>& e_rcc = xml_simpleCal->getExcel_returnCalcInfo_Call();
	

	const boost::shared_ptr<QuantLib::EventCalculation>& ql_ec 
		= ql_ec_factory.e_eventCal(e_ec);

	const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_rc
		= ql_rc_factory.e_returnCal(e_rc);

	const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_comp_rc
		= ql_rc_factory.e_returnCal(e_crc->getExcel_returnCalcInfo());

	// auto call setting
	const boost::shared_ptr<QuantLib::EventCalculation>& ql_ec_call
		= ql_ec_factory.e_eventCal(e_ecc->getExcel_eventCalcInfo());

	const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_rc_call
		= ql_rc_factory.e_returnCal(e_rcc->getExcel_returnCalcInfo());

	const boost::shared_ptr<QuantLib::AutoTerminationETI>& ql_autoEti 
		= boost::shared_ptr<QuantLib::AutoTerminationETI>(
					new QuantLib::AutoTerminationETI(ql_ec_call,
													ql_rc_call,
													ql_fdi));

	boost::shared_ptr<QuantLib::SimpleEventCouponETI> ql_scEti = 
		boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
			new QuantLib::SimpleEventCouponETI(ql_ec,
											   ql_rc,
											   ql_comp_rc,
											   ql_fdi,
											   false));

	// eventDate
	QuantLib::Date eventDate = xml_simpleCal->getEventDate()->dateValue();
	ql_scEti->setEventDate(eventDate);

	ql_scEti->setAutoTerminationETI(ql_autoEti);

	

	return ql_scEti;
}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_kiEventCalculation(const boost::shared_ptr<FpmlSerialized::Excel_kiEventCalculation>& xml_kiEventCalculation)
{
	boost::shared_ptr<EventTriggerInfo> ql_kiEti;

	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();
	
	std::string type = xml_kiEventCalculation->getExcel_type()->SValue();



	if ( type == "excel_simpleKiEventCalc")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_simpleKiEventCalc>& xml_serial
			= xml_kiEventCalculation->getExcel_simpleKiEventCalc();

		const boost::shared_ptr<Excel_eventCalcInfo>& e_ec = xml_serial->getExcel_eventCalcInfo();
		const boost::shared_ptr<Excel_returnCalcInfo>& e_occ_rc = xml_serial->getExcel_occReturnCalcInfo()->getExcel_returnCalcInfo();
		const boost::shared_ptr<Excel_returnCalcInfo>& e_noOcc_rc = xml_serial->getExcel_noOccReturnCalcInfo()->getExcel_returnCalcInfo();

		const boost::shared_ptr<QuantLib::EventCalculation>& ql_ec
			= ql_ec_factory.e_eventCal(e_ec);

		const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_rc
			= ql_rc_factory.e_returnCal(e_occ_rc);

		const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_comp_rc
			= ql_rc_factory.e_returnCal(e_noOcc_rc);

		QuantLib::Date payoffDate = xml_serial->getPayoffDate()->dateValue();

		const boost::shared_ptr<QuantLib::FixingDateInfo>& ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);

		ql_kiEti = boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
							new QuantLib::SimpleEventCouponETI(ql_ec,
															   ql_rc,
															   ql_comp_rc,
															   ql_fdi,
															   false));

		// eventDate
		QuantLib::Date eventDate = xml_serial->getEventDate()->dateValue();
		ql_kiEti->setEventDate(eventDate);


	}
	else if ( type == "")
	{
		const boost::shared_ptr<FpmlSerialized::Excel_dualKiEventCalc>& xml_serial
			= xml_kiEventCalculation->getExcel_dualKiEventCalc();
	
	}
	else if ( type == "")
	{
		xml_kiEventCalculation->getExcel_targetKiEventCalc();
	}
	else
	{
	
	}
	
	// eventDate

	return ql_kiEti;
	// not implemented
}

// ---------------------------------------- compOption ---------------------------------------------
boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::compOptionSubType(const boost::shared_ptr<FpmlSerialized::Excel_compositeOption_subtype >& xml_compOptionSub)
{
	boost::shared_ptr<EventTriggerInfo> eventTriggerInfo;

	const std::string& eventTriggerType = xml_compOptionSub->getExcel_type()->SValue();

	if ( eventTriggerType == "excel_vanillaCallPut" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_vanillaCallPut>& e_v_callPut
						= xml_compOptionSub->getExcel_vanillaCallPut();

		eventTriggerInfo = this->excel_vanillaCallPut(e_v_callPut);
	}
	else if ( eventTriggerType == "excel_upInOutCall" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_upInOutCall>& e_u_inOutCall
						= xml_compOptionSub->getExcel_upInOutCall();

		eventTriggerInfo = this->excel_upInOutCall(e_u_inOutCall);
	}else
	{
		
	}

	return eventTriggerInfo;

}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_vanillaCallPut(const boost::shared_ptr<FpmlSerialized::Excel_vanillaCallPut>& xml_v_callPut)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date payoffDate = xml_v_callPut->getPayoffDate()->dateValue();
	QuantLib::Date exerciseDate = xml_v_callPut->getExerciseDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);

	std::string underCode = xml_v_callPut->getUnderlyingCode()->SValue();

	std::string callPut = xml_v_callPut->getCallPut()->SValue();
	bool callPutFlag = true;

	if ( callPut == "Call")
	{
		callPutFlag = true;
	}
	else if ( callPut == "Put")
	{
		callPutFlag = false;
	}
	else
	{
		QL_FAIL("unknown CallPut Type : " << callPut);
	}

	Real partiRate = xml_v_callPut->getPartiRate()->DValue();
	Real strike = xml_v_callPut->getStrike()->DValue();
	Real spread = xml_v_callPut->getBaseCoupon()->DValue();

	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_rc 
		= ql_refCal_factory.e_choiceReferenceCal_singeCode(underCode , exerciseDate);

	boost::shared_ptr<QuantLib::VanillaCallPutCouponETI> ql_vcpcEti = 
					boost::shared_ptr<QuantLib::VanillaCallPutCouponETI>(
						new QuantLib::VanillaCallPutCouponETI(callPutFlag,
														partiRate,
														strike,
														spread,
														ql_rc,
														ql_fdi,
														false));

	// eventDate
	ql_vcpcEti->setEventDate(exerciseDate);

	return ql_vcpcEti;
}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_upInOutCall(const boost::shared_ptr<FpmlSerialized::Excel_upInOutCall>& e_u_inOutCall)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date payoffDate = e_u_inOutCall->getPayoffDate()->dateValue();
	QuantLib::Date exerciseDate = e_u_inOutCall->getExerciseDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);

	std::string underCode = e_u_inOutCall->getUnderlyingCode()->SValue();

	std::string inOut = e_u_inOutCall->getInOut()->SValue();

	Real partiRate = e_u_inOutCall->getPartiRate()->DValue();
	Real strike = e_u_inOutCall->getStrike()->DValue();
	Real baseCoupon = e_u_inOutCall->getBaseCoupon()->DValue();
	//Real barrier = e_u_inOutCall->getBarrierValue()->DValue();
	Real barrier = e_u_inOutCall->getBarrier()->DValue();

	// return ReferenceCal ( single Asset )
	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_rc 
		= ql_refCal_factory.e_choiceReferenceCal_singeCode(underCode , exerciseDate);

	Date startDate = e_u_inOutCall->getObservationStartDate()->dateValue();
	Date endDate = e_u_inOutCall->getObservationEndDate()->dateValue();

	// barrierEventCal

	std::vector<boost::shared_ptr<QuantLib::DateInformation>> dateInfoList;
	boost::shared_ptr<QuantLib::DateInformation> barrierInterval
		= boost::shared_ptr<QuantLib::DailyInterval>(
		new QuantLib::DailyInterval(startDate,endDate));

	dateInfoList.push_back(barrierInterval);

	std::vector<Real> upperTrrigerList;
	upperTrrigerList.push_back(barrier);

	// identityRefCal
	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_barrer_refCal 
		= ql_refCal_factory.e_identityReferenceCal_singeCode(underCode , exerciseDate);

	const boost::shared_ptr<QuantLib::EventCalculation>& e_barrier_ec = 
		boost::shared_ptr<QuantLib::UpperBarrierEventCal>(
						new QuantLib::UpperBarrierEventCal(dateInfoList,
														upperTrrigerList,
														ql_barrer_refCal));

	// rebate ReturnCall

	Real spread = 0.0;

	boost::shared_ptr<QuantLib::CallPutReturnCal> ql_callPut_returnCal = 
					boost::shared_ptr<QuantLib::CallPutReturnCal>(
						new QuantLib::CallPutReturnCal(true,
														partiRate,
														strike,
														spread,
														ql_barrer_refCal));

	// call ReturnCal

	boost::shared_ptr<QuantLib::ReturnCalculation> ql_constReturnCal;

	double constReturn = baseCoupon;

	ql_constReturnCal = boost::shared_ptr<QuantLib::ConstReturnCal>(
						new QuantLib::ConstReturnCal(constReturn));


	boost::shared_ptr<QuantLib::SimpleEventCouponETI> ql_scEti = 
		boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
			new QuantLib::SimpleEventCouponETI(e_barrier_ec,
											   ql_callPut_returnCal,
											   ql_constReturnCal,
											   ql_fdi,
											   false));

	// eventDate
	ql_scEti->setEventDate(exerciseDate);

	return ql_scEti;
}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_downInOutPut(const boost::shared_ptr<FpmlSerialized::Excel_downInOutPut>& e_d_inOutPut)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date payoffDate = e_d_inOutPut->getPayoffDate()->dateValue();
	QuantLib::Date exerciseDate = e_d_inOutPut->getExerciseDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);

	std::string underCode = e_d_inOutPut->getUnderlyingCode()->SValue();

	std::string inOut = e_d_inOutPut->getInOut()->SValue();

	Real partiRate = e_d_inOutPut->getPartiRate()->DValue();
	Real strike = e_d_inOutPut->getStrike()->DValue();
	Real baseCoupon = e_d_inOutPut->getBaseCoupon()->DValue();
	//Real barrier = e_d_inOutPut->getBarrierValue()->DValue();
	Real barrier = e_d_inOutPut->getBarrier()->DValue();

	// return ReferenceCal ( single Asset )
	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_rc 
		= ql_refCal_factory.e_choiceReferenceCal_singeCode(underCode , exerciseDate);

	Date startDate = e_d_inOutPut->getObservationStartDate()->dateValue();
	Date endDate = e_d_inOutPut->getObservationEndDate()->dateValue();

	// barrierEventCal

	std::vector<boost::shared_ptr<QuantLib::DateInformation>> dateInfoList;
	boost::shared_ptr<QuantLib::DateInformation> barrierInterval
		= boost::shared_ptr<QuantLib::DailyInterval>(
		new QuantLib::DailyInterval(startDate,endDate));

	dateInfoList.push_back(barrierInterval);

	std::vector<Real> upperTrrigerList;
	upperTrrigerList.push_back(barrier);

	// identityRefCal
	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_barrer_refCal 
		= ql_refCal_factory.e_identityReferenceCal_singeCode(underCode , exerciseDate);

	// lower barrier
	const boost::shared_ptr<QuantLib::EventCalculation>& e_barrier_ec = 
		boost::shared_ptr<QuantLib::LowerBarrierEventCal>(
						new QuantLib::LowerBarrierEventCal(dateInfoList,
														upperTrrigerList,
														ql_barrer_refCal));

	
	// call ReturnCal

	Real spread = 0.0;

	boost::shared_ptr<QuantLib::CallPutReturnCal> ql_callPut_returnCal = 
					boost::shared_ptr<QuantLib::CallPutReturnCal>(
						new QuantLib::CallPutReturnCal(false,
														partiRate,
														strike,
														spread,
														ql_barrer_refCal));
	
	// rebate ReturnCall

	boost::shared_ptr<QuantLib::ReturnCalculation> ql_constReturnCal;

	double constReturn = baseCoupon;

	ql_constReturnCal = boost::shared_ptr<QuantLib::ConstReturnCal>(
						new QuantLib::ConstReturnCal(constReturn));


	boost::shared_ptr<QuantLib::SimpleEventCouponETI> ql_scEti = 
		boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
			new QuantLib::SimpleEventCouponETI(e_barrier_ec,
											   ql_callPut_returnCal,
											   ql_constReturnCal,
											   ql_fdi,
											   false));

	// eventDate
	ql_scEti->setEventDate(exerciseDate);

	return ql_scEti;
}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_digitalCallPut(const boost::shared_ptr<FpmlSerialized::Excel_digitalCallPut>& e_ditgit_callPut)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date payoffDate = e_ditgit_callPut->getPayoffDate()->dateValue();
	QuantLib::Date exerciseDate = e_ditgit_callPut->getExerciseDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);

	std::string underCode = e_ditgit_callPut->getUnderlyingCode()->SValue();

	std::string callPut = e_ditgit_callPut->getCallPut()->SValue();

	Real digitalCoupon = e_ditgit_callPut->getCoupon()->DValue();
	Real strike = e_ditgit_callPut->getStrike()->DValue();
	Real baseCoupon = e_ditgit_callPut->getBaseCoupon()->DValue();
	//Real barrier = e_d_inOutPut->getBarrierValue()->DValue();

	// return ReferenceCal ( single Asset )
	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_rc 
		= ql_refCal_factory.e_choiceReferenceCal_singeCode(underCode , exerciseDate);

	// rangeEventCal
	Real upperRange = 999;
	Real downRange = strike;

	const boost::shared_ptr<QuantLib::Range1D>& range1D 
		= boost::shared_ptr<QuantLib::Range1D>(new QuantLib::Range1D(upperRange,true,downRange,true));

	const boost::shared_ptr<QuantLib::EventCalculation>& e_barrier_ec = 
		boost::shared_ptr<QuantLib::SimpleRangeEventCal>(
						new QuantLib::SimpleRangeEventCal(range1D,
														ql_rc));

	// inRange ReturnCal

	Real spread = 0.0;

	boost::shared_ptr<QuantLib::ConstReturnCal> ql_inRange_returnCal = 
					boost::shared_ptr<QuantLib::ConstReturnCal>(
						new QuantLib::ConstReturnCal(baseCoupon + digitalCoupon));
	
	// out ReturnCall

	boost::shared_ptr<QuantLib::ReturnCalculation> ql_outRange_ReturnCal;

	ql_outRange_ReturnCal = boost::shared_ptr<QuantLib::ConstReturnCal>(
						new QuantLib::ConstReturnCal(baseCoupon));

	boost::shared_ptr<QuantLib::SimpleEventCouponETI> ql_scEti = 
		boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
			new QuantLib::SimpleEventCouponETI(e_barrier_ec,
											   ql_inRange_returnCal,
											   ql_outRange_ReturnCal,
											   ql_fdi,
											   false));

	// eventDate
	ql_scEti->setEventDate(exerciseDate);

	return ql_scEti;
}



// ---------------------------------------- multi Asset compOption ---------------------------------------------
boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::multiAssetCompOptionSubType(const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_compositeOption_subtype>& xml_multiAssetCompOptionSub)
{
	boost::shared_ptr<EventTriggerInfo> eventTriggerInfo;

	const std::string& eventTriggerType = xml_multiAssetCompOptionSub->getExcel_type()->SValue();

	if ( eventTriggerType == "excel_multiAsset_vanillaCallPut" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_vanillaCallPut>& e_multi_v_callPut
						= xml_multiAssetCompOptionSub->getExcel_multiAsset_vanillaCallPut();

		eventTriggerInfo = this->excel_multiAsset_vanillaCallPut(e_multi_v_callPut);
	}
	else if ( eventTriggerType == "excel_multiAsset_upInOutCall" )
	{
		const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_upInOutCall>& e_multi_u_inOutCall
						= xml_multiAssetCompOptionSub->getExcel_multiAsset_upInOutCall();

		eventTriggerInfo = this->excel_multiAsset_upInOutCall(e_multi_u_inOutCall);
	}else
	{
		
	}

	return eventTriggerInfo;

}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_multiAsset_vanillaCallPut(const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_vanillaCallPut>& xml_multi_v_callPut)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date payoffDate = xml_multi_v_callPut->getPayoffDate()->dateValue();
	QuantLib::Date exerciseDate = xml_multi_v_callPut->getExerciseDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);

	const boost::shared_ptr<Excel_underlyingCalcID>& xml_e_ucid = xml_multi_v_callPut->getExcel_underlyingCalcID();

	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_refCal 
		= ql_refCal_factory.underlyingCalc(xml_e_ucid);

	std::string callPut = xml_multi_v_callPut->getCallPut()->SValue();

	bool callPutFlag = true;

	if ( callPut == "Call")
	{
		callPutFlag = true;
	}
	else if ( callPut == "Put")
	{
		callPutFlag = false;
	}
	else
	{
		QL_FAIL("unknown CallPut Type : " << callPut);
	}

	Real partiRate = xml_multi_v_callPut->getPartiRate()->DValue();
	Real strike = xml_multi_v_callPut->getStrike()->DValue();
	Real spread = xml_multi_v_callPut->getBaseCoupon()->DValue();

	boost::shared_ptr<QuantLib::VanillaCallPutCouponETI> ql_vcpcEti = 
					boost::shared_ptr<QuantLib::VanillaCallPutCouponETI>(
						new QuantLib::VanillaCallPutCouponETI(callPutFlag,
														partiRate,
														strike,
														spread,
														ql_refCal,
														ql_fdi,
														false));

	// eventDate
	ql_vcpcEti->setEventDate(exerciseDate);

	return ql_vcpcEti;
}

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_multiAsset_upInOutCall(const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_upInOutCall>& xml_multi_u_inOutCall)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date payoffDate = xml_multi_u_inOutCall->getPayoffDate()->dateValue();
	QuantLib::Date exerciseDate = xml_multi_u_inOutCall->getExerciseDate()->dateValue();

	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);

	std::string inOut = xml_multi_u_inOutCall->getInOut()->SValue();

	Real partiRate = xml_multi_u_inOutCall->getPartiRate()->DValue();
	Real strike = xml_multi_u_inOutCall->getStrike()->DValue();
	Real baseCoupon = xml_multi_u_inOutCall->getBaseCoupon()->DValue();
	//Real barrier = e_u_inOutCall->getBarrierValue()->DValue();
	Real barrier = xml_multi_u_inOutCall->getBarrier()->DValue();

	Date startDate = xml_multi_u_inOutCall->getObservationStartDate()->dateValue();
	Date endDate = xml_multi_u_inOutCall->getObservationEndDate()->dateValue();

	// barrierEventCal

	std::vector<boost::shared_ptr<QuantLib::DateInformation>> dateInfoList;
	boost::shared_ptr<QuantLib::DateInformation> barrierInterval
						= boost::shared_ptr<QuantLib::DailyInterval>(
							new QuantLib::DailyInterval(startDate,endDate));

	dateInfoList.push_back(barrierInterval);

	std::vector<Real> upperTrrigerList;
	upperTrrigerList.push_back(barrier);

	// barrier RefCal
	const boost::shared_ptr<Excel_underlyingCalcID>& xml_e_barrier_ucid = xml_multi_u_inOutCall->getExcel_underlyingCalcID()[0];

	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_barrier_refCal 
		= ql_refCal_factory.underlyingCalc(xml_e_barrier_ucid);

	const boost::shared_ptr<QuantLib::EventCalculation>& e_barrier_ec = 
		boost::shared_ptr<QuantLib::UpperBarrierEventCal>(
						new QuantLib::UpperBarrierEventCal(dateInfoList,
														upperTrrigerList,
														ql_barrier_refCal));

	// call / put ReturnCall

	const boost::shared_ptr<Excel_underlyingCalcID>& xml_e_returnRef_ucid = xml_multi_u_inOutCall->getExcel_underlyingCalcID()[0];

		const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_return_refCal 
		= ql_refCal_factory.underlyingCalc(xml_e_returnRef_ucid);

	Real spread = 0.0;

	boost::shared_ptr<QuantLib::CallPutReturnCal> ql_callPut_returnCal = 
					boost::shared_ptr<QuantLib::CallPutReturnCal>(
						new QuantLib::CallPutReturnCal(true,
														partiRate,
														strike,
														spread,
														ql_return_refCal));

	// rebate ReturnCal

	boost::shared_ptr<QuantLib::ReturnCalculation> ql_constReturnCal;

	double constReturn = baseCoupon;

	ql_constReturnCal = boost::shared_ptr<QuantLib::ConstReturnCal>(
						new QuantLib::ConstReturnCal(constReturn));


	boost::shared_ptr<QuantLib::SimpleEventCouponETI> ql_scEti = 
		boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
			new QuantLib::SimpleEventCouponETI(e_barrier_ec,
											   ql_callPut_returnCal,
											   ql_constReturnCal,
											   ql_fdi,
											   false));

	// eventDate
	ql_scEti->setEventDate(exerciseDate);

	return ql_scEti;
}



// ---------------------------------------- bond  coupon -------------------------------------------------------

// excel_fixedCouponSchedule

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_fixedCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponSchedule>& xml_fcs)
{
	qlDayCounterFactory ql_dc_factory = qlDayCounterFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();

	QuantLib::Date calStartDate = xml_fcs->getCalculationStartDate()->dateValue();
	QuantLib::Date calEndDate = xml_fcs->getCalculationEndDate()->dateValue();

	std::string dcStr = "";//xml_fcs->getDayCounter()->SValue();

	QuantLib::DayCounter ql_dc = ql_dc_factory.dayCounter(dcStr);
	QuantLib::Date payoffDate = xml_fcs->getPayoffDate()->dateValue();
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);

	Real fixedRate = xml_fcs->getFixedRate()->DValue();

	boost::shared_ptr<QuantLib::FixedRateETI> ql_frEti = 
		boost::shared_ptr<QuantLib::FixedRateETI>(
			new QuantLib::FixedRateETI(ql_dc,
										fixedRate,
										calStartDate,
										calEndDate,
										ql_fdi,
										false));

	// eventDate
	QuantLib::Date eventDate = xml_fcs->getEventDate()->dateValue();
	ql_frEti->setEventDate(eventDate);

	//ql_mccrEti->setAutoTerminationETI(ql_autoEti);

	return ql_frEti;

}

// excel_vanillaFloatingCouponSchedule

boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_vanillaFloatingCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_vanillaFloatingCouponSchedule>& xml_vfcs)
{
	qlReferenceCalculationFactory ql_ref_factory = qlReferenceCalculationFactory();
	qlDayCounterFactory ql_dc_factory = qlDayCounterFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();
	
	QuantLib::Date calStartDate = xml_vfcs->getCalculationStartDate()->dateValue();
	QuantLib::Date calEndDate = xml_vfcs->getCalculationEndDate()->dateValue();

	std::string dcStr = "";//xml_fcs->getDayCounter()->SValue();

	QuantLib::DayCounter ql_dc = ql_dc_factory.dayCounter(dcStr);
	QuantLib::Date payoffDate = xml_vfcs->getPayoffDate()->dateValue();
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);

	// gearing spread calc info

	Real gearing = xml_vfcs->getGearing()->DValue();
	Real spread = xml_vfcs->getSpread()->DValue();
	Real outGearing = xml_vfcs->getOutGearing()->DValue();
	Real outSpread = xml_vfcs->getOutSpread()->DValue();
	Real cap = xml_vfcs->getCap()->DValue();
	Real floor = xml_vfcs->getFloor()->DValue();

	// refCalculation
	const boost::shared_ptr<Excel_underlyingCalcID>& e_underCalcID
		= xml_vfcs->getExcel_underlyingCalcID();

	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_refCal
		= ql_ref_factory.underlyingCalc(e_underCalcID);
		
	boost::shared_ptr<QuantLib::VanillaRateETI> ql_vrEti = 
		boost::shared_ptr<QuantLib::VanillaRateETI>(
			new QuantLib::VanillaRateETI(ql_dc,
										calStartDate,
										calEndDate,
										ql_fdi,
										ql_refCal,
										gearing,spread,
										outGearing,outSpread,
										cap,floor
										));

	// eventDate
	QuantLib::Date eventDate = xml_vfcs->getEventDate()->dateValue();
	ql_vrEti->setEventDate(eventDate);

	//ql_mccrEti->setAutoTerminationETI(ql_autoEti);

	return ql_vrEti;

}
// excel_multiCondi_structuredCouponSchedule
boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_multiCondi_structuredCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_structuredCouponSchedule>& xml_mc_scs)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();
	qlDayCounterFactory ql_dc_factory = qlDayCounterFactory();
	
	QuantLib::Date calStartDate = xml_mc_scs->getCalculationStartDate()->dateValue();
	QuantLib::Date calEndDate = xml_mc_scs->getCalculationEndDate()->dateValue();

	std::string dcStr = xml_mc_scs->getDayCounter()->SValue();

	QuantLib::DayCounter ql_dc = ql_dc_factory.dayCounter(dcStr);

	QuantLib::Date payoffDate = xml_mc_scs->getPayoffDate()->dateValue();
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);


	// eventCalculation
	std::vector<boost::shared_ptr<Excel_eventCalcInfo>>& e_ecList 
		= xml_mc_scs->getExcel_eventCalcInfo();

	std::vector<boost::shared_ptr<QuantLib::EventCalculation>> ql_ecList;

	for ( Size i=0 ; i<e_ecList.size() ; i++ )
	{
		ql_ecList.push_back(ql_ec_factory.e_eventCal(e_ecList[i]));
	}

	// returnCalculation
	std::vector<boost::shared_ptr<Excel_returnCalcInfo>>& e_rcList
		= xml_mc_scs->getExcel_returnCalcInfo();

	std::vector<boost::shared_ptr<QuantLib::ReturnCalculation>> ql_rcList;

	for ( Size i=0 ; i<e_rcList.size() ; i++ )
	{
		ql_rcList.push_back(ql_rc_factory.e_returnCal(e_rcList[i]));
	}

	//// auto call setting
	//const boost::shared_ptr<QuantLib::EventCalculation>& ql_ec_call
	//	= ql_ec_factory.e_eventCal(e_ecc->getExcel_eventCalcInfo());

	//const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_rc_call
	//	= ql_rc_factory.e_returnCal(e_rcc->getExcel_returnCalcInfo());

	//const boost::shared_ptr<QuantLib::AutoTerminationETI>& ql_autoEti 
	//	= boost::shared_ptr<QuantLib::AutoTerminationETI>(
	//				new QuantLib::AutoTerminationETI(ql_ec_call,
	//												ql_rc_call,
	//												ql_fdi));

	boost::shared_ptr<QuantLib::MultiConditionCouponRateETI> ql_mccrEti = 
		boost::shared_ptr<QuantLib::MultiConditionCouponRateETI>(
			new QuantLib::MultiConditionCouponRateETI(ql_ecList,
													   ql_rcList,
													   ql_dc,
													   calStartDate,
													   calEndDate,
													   ql_fdi,
													   false));

	// eventDate
	QuantLib::Date eventDate = xml_mc_scs->getEventDate()->dateValue();
	ql_mccrEti->setEventDate(eventDate);

	//ql_mccrEti->setAutoTerminationETI(ql_autoEti);

	return ql_mccrEti;
}

// excel_multiCondi_structuredAccrualCouponSchedule
boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_multiCondi_structuredAccrualCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_structuredAccrualCouponSchedule>& xml_mc_sacs)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReferenceCalculationFactory ql_ref_factory = qlReferenceCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();
	qlDayCounterFactory ql_dc_factory = qlDayCounterFactory();

	std::string dcStr = xml_mc_sacs->getDayCounter()->SValue();

	QuantLib::DayCounter ql_dc = ql_dc_factory.dayCounter(dcStr);
	
	Real accrualDateNum = 30.0;

	QuantLib::Date payoffDate = xml_mc_sacs->getPayoffDate()->dateValue();
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);

	// eventCalculation
	std::vector<boost::shared_ptr<FpmlSerialized::Range1D>>& e_rngList 
		= xml_mc_sacs->getRange1D();

	std::vector<boost::shared_ptr<QuantLib::Range1D>> ql_rngList;

	for ( Size i=0 ; i<e_rngList.size() ; i++ )
	{
		Real upperBound = e_rngList[i]->getUpperBound()->DValue();
		bool upperBoundEqulity = true;
		Real lowerBound = e_rngList[i]->getLowerBound()->DValue();
		bool lowerBoundEqulity = true;

		boost::shared_ptr<QuantLib::Range1D> rng1D
			= boost::shared_ptr<QuantLib::Range1D>(
					new QuantLib::Range1D(upperBound,upperBoundEqulity,
										  lowerBound,lowerBoundEqulity));

		ql_rngList.push_back(rng1D);
	}

	// refCalculation
	std::vector<boost::shared_ptr<Excel_underlyingCalcID>>& e_underCalcIDList
		= xml_mc_sacs->getExcel_underlyingCalcID();

	std::vector<boost::shared_ptr<QuantLib::ReferenceCalculation>> ql_refCalList;
		
	for ( Size i=0 ; i<e_underCalcIDList.size() ; i++ )
	{
		ql_refCalList.push_back(ql_ref_factory.underlyingCalc(e_underCalcIDList[i]));

	}

	// returnCalculation
	std::vector<boost::shared_ptr<Excel_returnCalcInfo>>& e_rcList
		= xml_mc_sacs->getExcel_returnCalcInfo();

	std::vector<boost::shared_ptr<QuantLib::ReturnCalculation>> ql_rcList;

	for ( Size i=0 ; i<e_rcList.size() ; i++ )
	{
		ql_rcList.push_back(ql_rc_factory.e_returnCal(e_rcList[i]));
	}

	QuantLib::Date calStartDate = xml_mc_sacs->getCalculationStartDate()->dateValue();
	QuantLib::Date calEndDate = xml_mc_sacs->getCalculationEndDate()->dateValue();

	boost::shared_ptr<QuantLib::DateInformation> dateInfo
		= boost::shared_ptr<QuantLib::DailyInterval>(
		new QuantLib::DailyInterval(calStartDate,calEndDate));

	//// auto call setting
	//const boost::shared_ptr<QuantLib::EventCalculation>& ql_ec_call
	//	= ql_ec_factory.e_eventCal(e_ecc->getExcel_eventCalcInfo());

	//const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_rc_call
	//	= ql_rc_factory.e_returnCal(e_rcc->getExcel_returnCalcInfo());

	//const boost::shared_ptr<QuantLib::AutoTerminationETI>& ql_autoEti 
	//	= boost::shared_ptr<QuantLib::AutoTerminationETI>(
	//				new QuantLib::AutoTerminationETI(ql_ec_call,
	//												ql_rc_call,
	//												ql_fdi));

	boost::shared_ptr<QuantLib::MultiConditionAccrualCouponRateETI> ql_mcacrEti = 
		boost::shared_ptr<QuantLib::MultiConditionAccrualCouponRateETI>(
			new QuantLib::MultiConditionAccrualCouponRateETI(ql_dc,
														ql_rngList,
														ql_refCalList,
													   ql_rcList,
													   accrualDateNum,
													   dateInfo,
													   ql_fdi,
													   false));

	// eventDate
	QuantLib::Date eventDate = xml_mc_sacs->getEventDate()->dateValue();
	ql_mcacrEti->setEventDate(eventDate);

	//ql_mccrEti->setAutoTerminationETI(ql_autoEti);

	return ql_mcacrEti;
}

// excel_multiCondi_multiRng_structuredAccrualCouponSchedule
boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_multiCondi_multiRng_structuredAccrualCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_multiRng_structuredAccrualCouponSchedule>& xml_mc_mr_sacs)
{
	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
	qlReferenceCalculationFactory ql_ref_factory = qlReferenceCalculationFactory();
	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();
	qlDayCounterFactory ql_dc_factory = qlDayCounterFactory();

	std::string dcStr = xml_mc_mr_sacs->getDayCounter()->SValue();

	QuantLib::DayCounter ql_dc = ql_dc_factory.dayCounter(dcStr);
	
	Real accrualDateNum = 30.0;

	QuantLib::Date payoffDate = xml_mc_mr_sacs->getPayoffDate()->dateValue();
	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);

	// rangeND

	qlRangeEventFactory ql_rng_factory = qlRangeEventFactory();

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_multi_rangeND>>& e_rngNDList 
		= xml_mc_mr_sacs->getExcel_multi_rangeND();

	std::vector<boost::shared_ptr<QuantLib::RangeND>> ql_rngNDList;

	for ( Size i=0 ; i<e_rngNDList.size() ; i++ )
	{
		ql_rngNDList.push_back(ql_rng_factory.rangeND(e_rngNDList[i]));
	}
	

	// returnCalculation
	std::vector<boost::shared_ptr<Excel_returnCalcInfo>>& e_rcList
		= xml_mc_mr_sacs->getExcel_returnCalcInfo();

	std::vector<boost::shared_ptr<QuantLib::ReturnCalculation>> ql_rcList;

	for ( Size i=0 ; i<e_rcList.size() ; i++ )
	{
		ql_rcList.push_back(ql_rc_factory.e_returnCal(e_rcList[i]));
	}

	QuantLib::Date calStartDate = xml_mc_mr_sacs->getCalculationStartDate()->dateValue();
	QuantLib::Date calEndDate = xml_mc_mr_sacs->getCalculationEndDate()->dateValue();

	boost::shared_ptr<QuantLib::DateInformation> dateInfo
		= boost::shared_ptr<QuantLib::DailyInterval>(
		new QuantLib::DailyInterval(calStartDate,calEndDate));

	//// auto call setting
	//const boost::shared_ptr<QuantLib::EventCalculation>& ql_ec_call
	//	= ql_ec_factory.e_eventCal(e_ecc->getExcel_eventCalcInfo());

	//const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_rc_call
	//	= ql_rc_factory.e_returnCal(e_rcc->getExcel_returnCalcInfo());

	//const boost::shared_ptr<QuantLib::AutoTerminationETI>& ql_autoEti 
	//	= boost::shared_ptr<QuantLib::AutoTerminationETI>(
	//				new QuantLib::AutoTerminationETI(ql_ec_call,
	//												ql_rc_call,
	//												ql_fdi));

	boost::shared_ptr<QuantLib::MultiConditionMultiRngAccrualCouponRateETI> ql_mc_mr_acrEti = 
		boost::shared_ptr<QuantLib::MultiConditionMultiRngAccrualCouponRateETI>(
			new QuantLib::MultiConditionMultiRngAccrualCouponRateETI(ql_dc,
														ql_rngNDList,
													   ql_rcList,
													   accrualDateNum,
													   dateInfo,
													   ql_fdi,
													   false));

	// eventDate
	QuantLib::Date eventDate = xml_mc_mr_sacs->getEventDate()->dateValue();
	ql_mc_mr_acrEti->setEventDate(eventDate);

	//ql_mccrEti->setAutoTerminationETI(ql_autoEti);

	return ql_mc_mr_acrEti;
}



//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_multiAsset_downInOutPut(const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_downInOutPut>& xml_multi_d_inOutPut)
//{
//	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
//	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
//	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
//	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();
//
//	QuantLib::Date payoffDate = e_d_inOutPut->getPayoffDate()->dateValue();
//	QuantLib::Date exerciseDate = e_d_inOutPut->getExerciseDate()->dateValue();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
//	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);
//
//	std::string underCode = e_d_inOutPut->getUnderlyingCode()->SValue();
//
//	std::string inOut = e_d_inOutPut->getInOut()->SValue();
//
//	Real partiRate = e_d_inOutPut->getPartiRate()->DValue();
//	Real strike = e_d_inOutPut->getStrike()->DValue();
//	Real baseCoupon = e_d_inOutPut->getBaseCoupon()->DValue();
//	//Real barrier = e_d_inOutPut->getBarrierValue()->DValue();
//	Real barrier = e_d_inOutPut->getBarrier()->DValue();
//
//	// return ReferenceCal ( single Asset )
//	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_rc 
//		= ql_refCal_factory.e_choiceReferenceCal_singeCode(underCode , exerciseDate);
//
//	Date startDate = e_d_inOutPut->getObservationStartDate()->dateValue();
//	Date endDate = e_d_inOutPut->getObservationEndDate()->dateValue();
//
//	// barrierEventCal
//
//	std::vector<boost::shared_ptr<QuantLib::DateInformation>> dateInfoList;
//	boost::shared_ptr<QuantLib::DateInformation> barrierInterval
//		= boost::shared_ptr<QuantLib::DailyInterval>(
//		new QuantLib::DailyInterval(startDate,endDate));
//
//	dateInfoList.push_back(barrierInterval);
//
//	std::vector<Real> upperTrrigerList;
//	upperTrrigerList.push_back(barrier);
//
//	// identityRefCal
//	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_barrer_refCal 
//		= ql_refCal_factory.e_identityReferenceCal_singeCode(underCode , exerciseDate);
//
//	// lower barrier
//	const boost::shared_ptr<QuantLib::EventCalculation>& e_barrier_ec = 
//		boost::shared_ptr<QuantLib::LowerBarrierEventCal>(
//						new QuantLib::LowerBarrierEventCal(dateInfoList,
//														upperTrrigerList,
//														ql_barrer_refCal));
//
//	
//	// call ReturnCal
//
//	Real spread = 0.0;
//
//	boost::shared_ptr<QuantLib::CallPutReturnCal> ql_callPut_returnCal = 
//					boost::shared_ptr<QuantLib::CallPutReturnCal>(
//						new QuantLib::CallPutReturnCal(false,
//														partiRate,
//														strike,
//														spread,
//														ql_barrer_refCal));
//	
//	// rebate ReturnCall
//
//	boost::shared_ptr<QuantLib::ReturnCalculation> ql_constReturnCal;
//
//	double constReturn = baseCoupon;
//
//	ql_constReturnCal = boost::shared_ptr<QuantLib::ConstReturnCal>(
//						new QuantLib::ConstReturnCal(constReturn));
//
//
//	boost::shared_ptr<QuantLib::SimpleEventCouponETI> ql_scEti = 
//		boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
//			new QuantLib::SimpleEventCouponETI(e_barrier_ec,
//											   ql_callPut_returnCal,
//											   ql_constReturnCal,
//											   ql_fdi,
//											   false));
//
//	// eventDate
//	ql_scEti->setEventDate(exerciseDate);
//
//	return ql_scEti;
//}
//
//
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::excel_multiAsset_digitalCallPut(const boost::shared_ptr<FpmlSerialized::Excel_digitalCallPut>& xml_multi_ditgit_callPut)
//{
//	qlEventCalculationFactory ql_ec_factory = qlEventCalculationFactory();
//	qlReturnCalculationFactory ql_rc_factory = qlReturnCalculationFactory();
//	qlReferenceCalculationFactory ql_refCal_factory = qlReferenceCalculationFactory();
//	qlFixingDateInfoFactory ql_fd_factory = qlFixingDateInfoFactory();
//
//	QuantLib::Date payoffDate = e_ditgit_callPut->getPayoffDate()->dateValue();
//	QuantLib::Date exerciseDate = e_ditgit_callPut->getExerciseDate()->dateValue();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> ql_fdi = ql_fd_factory.fixingDateInfo(payoffDate);
//	//boost::shared_ptr<QuantLib::FixingDateInfo> ql_fixingDate = ql_fd_factory.fixingDateInfo(exerciseDate);
//
//	std::string underCode = e_ditgit_callPut->getUnderlyingCode()->SValue();
//
//	std::string callPut = e_ditgit_callPut->getCallPut()->SValue();
//
//	Real digitalCoupon = e_ditgit_callPut->getCoupon()->DValue();
//	Real strike = e_ditgit_callPut->getStrike()->DValue();
//	Real baseCoupon = e_ditgit_callPut->getBaseCoupon()->DValue();
//	//Real barrier = e_d_inOutPut->getBarrierValue()->DValue();
//
//	// return ReferenceCal ( single Asset )
//	const boost::shared_ptr<QuantLib::ReferenceCalculation>& ql_rc 
//		= ql_refCal_factory.e_choiceReferenceCal_singeCode(underCode , exerciseDate);
//
//	// rangeEventCal
//	Real upperRange = 999;
//	Real downRange = strike;
//
//	const boost::shared_ptr<QuantLib::Range1D>& range1D 
//		= boost::shared_ptr<QuantLib::Range1D>(new QuantLib::Range1D(upperRange,true,downRange,true));
//
//	const boost::shared_ptr<QuantLib::EventCalculation>& e_barrier_ec = 
//		boost::shared_ptr<QuantLib::SimpleRangeEventCal>(
//						new QuantLib::SimpleRangeEventCal(range1D,
//														ql_rc));
//
//	// inRange ReturnCal
//
//	Real spread = 0.0;
//
//	boost::shared_ptr<QuantLib::ConstReturnCal> ql_inRange_returnCal = 
//					boost::shared_ptr<QuantLib::ConstReturnCal>(
//						new QuantLib::ConstReturnCal(baseCoupon + digitalCoupon));
//	
//	// out ReturnCall
//
//	boost::shared_ptr<QuantLib::ReturnCalculation> ql_outRange_ReturnCal;
//
//	ql_outRange_ReturnCal = boost::shared_ptr<QuantLib::ConstReturnCal>(
//						new QuantLib::ConstReturnCal(baseCoupon));
//
//	boost::shared_ptr<QuantLib::SimpleEventCouponETI> ql_scEti = 
//		boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
//			new QuantLib::SimpleEventCouponETI(e_barrier_ec,
//											   ql_inRange_returnCal,
//											   ql_outRange_ReturnCal,
//											   ql_fdi,
//											   false));
//
//	// eventDate
//	ql_scEti->setEventDate(exerciseDate);
//
//	return ql_scEti;
//}




//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::eventTriggerInfo(const boost::shared_ptr<FpmlSerialized::EventTrigger>& xml_eventTrigger)
//{
//	boost::shared_ptr<EventTriggerInfo> eventTriggerInfo;
//
//	const std::string& eventTriggerType = xml_eventTrigger->getType()->SValue();
//
//	//if ( eventTriggerType == "autoCallConstReturnTrigger" )
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::AutoCallConstReturnTrigger>& xml_eti
//	//						= xml_eventTrigger->getAutoCallConstReturnTrigger();
//
//	//	eventTriggerInfo = this->autoCallConstReturnETI(xml_eti);
//	//}
//	//else if ( eventTriggerType == "simpleRangeRateTrigger" )
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::SimpleRangeRateTrigger>& xml_simpleRangeRateTrigger
//	//						= xml_eventTrigger->getSimpleRangeRateTrigger();
//
//	//	eventTriggerInfo = this->simpleRangeRateETI(xml_simpleRangeRateTrigger);
//	//}
//	//if ( eventTriggerType == "redemptionNotionalTrigger" )
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::RedemptionNotionalTrigger>& xml_eti
//	//						= xml_eventTrigger->getRedemptionNotionalTrigger();
//
//	//	eventTriggerInfo = this->redemptionNotionalETI(xml_eti);
//	//}
//	//else if ( eventTriggerType == "simpleRangeReturnTrigger" )
//	//{
//	//	const boost::shared_ptr<FpmlSerialized::SimpleRangeReturnTrigger>& xml_simpleRangeReturnTrigger
//	//						= xml_eventTrigger->getSimpleRangeReturnTrigger();
//
//	//	eventTriggerInfo = this->simpleRangeReturnETI(xml_simpleRangeReturnTrigger);
//	//}
//	if ( eventTriggerType == "fixedRateTrigger" )
//	{
//		const boost::shared_ptr<FpmlSerialized::FixedRateTrigger>& xml_eti
//							= xml_eventTrigger->getFixedRateTrigger();
//
//		eventTriggerInfo = this->fixedRateETI(xml_eti);
//	}
//	else if ( eventTriggerType == "simpleEventCouponTrigger" )
//	{
//		const boost::shared_ptr<FpmlSerialized::SimpleEventCouponTrigger>& xml_eti
//							= xml_eventTrigger->getSimpleEventCouponTrigger();
//
//		eventTriggerInfo = this->simpleEventCouponETI(xml_eti);
//	}
//	else if ( eventTriggerType == "vanillaCouponTrigger" )
//	{
//		const boost::shared_ptr<FpmlSerialized::VanillaCouponTrigger>& xml_eti
//							= xml_eventTrigger->getVanillaCouponTrigger();
//
//		eventTriggerInfo = this->vanillaCouponETI(xml_eti);
//	}
//	else if ( eventTriggerType == "vanillaRateTrigger" )
//	{
//		const boost::shared_ptr<FpmlSerialized::VanillaRateTrigger>& xml_eti
//							= xml_eventTrigger->getVanillaRateTrigger();
//
//		eventTriggerInfo = this->vanillaRateETI(xml_eti);
//	}
//	else
//	{
//		QL_FAIL("unknown eventTriggerType : " << eventTriggerType);
//	}
//
//	// common interface -------------------------------------------------
//
//	// eventDate
//	Date eventDate = xml_eventTrigger->getEventDate()->dateValue();
//	eventTriggerInfo->setEventDate(eventDate);
//
//	// preEventCal
//	
//
//	if ( !xml_eventTrigger->isPreEventCalculation() )
//	{
//		qlPreEventCalculationFactory qlECF = qlPreEventCalculationFactory();
//		const boost::shared_ptr<FpmlSerialized::PreEventCalculation>& xml_preEventCal
//			= xml_eventTrigger->getPreEventCalculation();
//		eventTriggerInfo->setPreEventCalcaultion( qlECF.preEventCal(xml_preEventCal) );
//	}
//
//	// preConditionEvent
//	if ( !xml_eventTrigger->isPreConditionEvent() )
//	{
//		qlPreConditionEventFactory qlPCEF = qlPreConditionEventFactory();
//		const boost::shared_ptr<FpmlSerialized::PreConditionEvent>& preCondiEvent
//			= xml_eventTrigger->getPreConditionEvent();
//		eventTriggerInfo->setPreConditionEvent( qlPCEF.preCondiEvent(preCondiEvent) );
//	}
//
//	// isAutoTerminationTrigger
//	if ( !xml_eventTrigger->isAutoTerminationTrigger() )
//	{
//		const boost::shared_ptr<FpmlSerialized::AutoTerminationTrigger>& xml_autoTerminationTrigger = xml_eventTrigger->getAutoTerminationTrigger();
//		const boost::shared_ptr<QuantLib::EventTriggerInfo>& ql_autoTerminationETI = this->autoTerminationETI(xml_autoTerminationTrigger);
//
//		//parent와 같은 eventDate를 가짐
//		ql_autoTerminationETI->setEventDate(eventDate);
//
//		eventTriggerInfo->setAutoTerminationETI(ql_autoTerminationETI);
//	}
//
//	return eventTriggerInfo;
//}

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::vanillaRateETI(const boost::shared_ptr<FpmlSerialized::VanillaRateTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> ql_vanillaRateETI;
//
//	//DayCounter
//	qlDayCounterFactory qlDCF = qlDayCounterFactory();
//	const std::string& dayCounterStr = xml_serial->getDayCounter()->SValue();
//	DayCounter ql_dc = qlDCF.dayCounter(dayCounterStr);
//
//	//Calculation StartDate, EndDate
//	Date& calculationStartDate = xml_serial->getCalculationStartDate()->dateValue();
//	Date& calculationEndDate = xml_serial->getCalculationEndDate()->dateValue();
//
//	//FixingDateInfo
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	const boost::shared_ptr<FpmlSerialized::FixingDateInfo>& xml_fixingDateInfo = 
//		xml_serial->getPayoffDateInfo()->getFixingDateInfo();
//
//	const boost::shared_ptr<QuantLib::FixingDateInfo>& ql_fixingDateInfo 
//				= qlFDF.fixingDateInfo(xml_fixingDateInfo);
//
//	//ReferenceCalculation
//	qlReferenceCalculationFactory qlRCF = qlReferenceCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::ReferenceCalculationInfo>& xml_refCalInfo
//		= xml_serial->getReferenceCalculationInfo();
//
//	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_refCalInfo
//		= qlRCF.referenceCalInfo(xml_refCalInfo);
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	ql_vanillaRateETI = boost::shared_ptr<QuantLib::EventTriggerInfo>( 
//				new QuantLib::VanillaRateETI(ql_dc,
//				calculationStartDate,
//				calculationEndDate,
//				ql_fixingDateInfo,
//				ql_refCalInfo,
//				usingVariableInfoList));
//					
//	return ql_vanillaRateETI;
//}

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::kiEventInfo(const boost::shared_ptr<FpmlSerialized::KiEventInfo>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> kiEventTriggerInfo;
//
//	boost::shared_ptr<FpmlSerialized::EventTrigger> xml_et = xml_serial->getEventTrigger();
//
//	this->eventTriggerInfo(xml_et);
//
//	kiEventTriggerInfo = boost::shared_ptr<EventTriggerInfo>(
//		 new ConstKiMinLossPayoffTriggerETI(referenceCal,
//										    barrierDateInfo,
//											payoffDateInfo,
//											//basePrices_,
//											kiTriggers, 
//											pastKI,
//											usingVariableInfoList));
//
//
//	return kiEventTriggerInfo;
//}
//
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::
//	normalKiEventInfo(const boost::shared_ptr<FpmlSerialized::NormalKiEventInfo>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> kiEventTriggerInfo;
//
//	kiEventTriggerInfo = boost::shared_ptr<EventTriggerInfo>(
//		 new NormalBarrierETI(referenceCal,
//						barrierDateInfo,
//						payoffDateInfo,
//						//basePrices_,
//						kiTriggers, 
//						pastKI,
//						usingVariableInfoList));
//
//	return kiEventTriggerInfo;
//}
//
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::nonkiEventInfoETI(const boost::shared_ptr<FpmlSerialized::NonKiEventInfo>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> nonkiEventTriggerInfo;
//	
//	double constReturn = xml_serial->getConstNonKiTrigger()->getReturn()->DValue();
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	nonkiEventTriggerInfo = boost::shared_ptr<EventTriggerInfo>(
//		new ConstPayoffEventTriggerInfo(payoffDateInfo,
//										constReturn,
//										usingVariableInfoList));
//
//	return nonkiEventTriggerInfo;
//}

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::autoCallConstReturnETI(const boost::shared_ptr<FpmlSerialized::AutoCallConstReturnTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> autoCallConstReturn;
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> fixingDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getFixingDateInfo());
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	Real trigger = xml_serial->getTrigger()->DValue();
//	Real constReturn = xml_serial->getReturn()->DValue();
//	bool isExpired = xml_serial->getIsExpired()->BValue();
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	autoCallConstReturn = boost::shared_ptr<EventTriggerInfo>(
//			new AutoCallConstReturnEventTriggerInfo(fixingDateInfo,
//													payoffDateInfo,
//													constReturn,
//													//this->basePrices_,
//													trigger,
//													isExpired,
//													usingVariableInfoList));
//
//
//	return autoCallConstReturn;
//}

//----------- rangeEvent -------------------------------------------------------------------------------------------------------------------------------------------------------
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::simpleRangeConstReturnETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeConstReturnTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> autoCallConstReturn;
//
//	//this->simpleRangeETI
//
//	
//	const boost::shared_ptr<EventTriggerInfo>& rangeEvent
//		= this->simpleRangeETI(xml_serial->getSimpleRangeEvent());
//	Date payoffDate = xml_serial->getPayoffDate()->dateValue();
//	Real constReturn = xml_serial->getConstReturn()->DValue();
//	//bool isExpired = xml_serial->getIsExpired()->BValue();
//	bool isExpired = false;
//	autoCallConstReturn = boost::shared_ptr<EventTriggerInfo>(
//						new SimpleRangeConstReturnETI(rangeEvent,
//													payoffDate,
//													constReturn,
//													isExpired));
//
//
//	return autoCallConstReturn;
//}

//----------- rangeEvent -----------------------------------------------------------------------------------------------------------------

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::simpleRangeRateETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeRateTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> simRangeRateETI;
//
//	DayCounter dayCounter = Actual365Fixed();
//	//qlReferenceCalculationFactory qlRefCalFactory = qlReferenceCalculationFactory();
//	
//	//const boost::shared_ptr<ReferenceCalculation>& xml_refCal 
//	//	= qlRefCalFactory.referenceCal(xml_serial->getReferenceCalculation());
//
//	Date calculationStartDate = xml_serial->getCalculationStartDate()->dateValue();
//	Date calculationEndDate = xml_serial->getCalculationEndDate()->dateValue();
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	const std::vector<boost::shared_ptr<FpmlSerialized::SimpleRangeEventCal>>& xml_simpleRangeEventCal
//		= xml_serial->getSimpleRangeEventList()->getSimpleRangeEventCal();
//
//	std::vector<boost::shared_ptr<QuantLib::SimpleRangeEventCal>> ql_simpleRangeEventCal;
//		
//	for ( Size i=0 ; i< xml_simpleRangeEventCal.size() ; i++ )
//	{
//		ql_simpleRangeEventCal.push_back(this->simpleRangeEventCal(xml_simpleRangeEventCal[i]));
//	}
//
//	Size denumerDateNum = 0;
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	simRangeRateETI = boost::shared_ptr<SimpleRangeRateETI>(
//							new SimpleRangeRateETI( dayCounter,
//													calculationStartDate,
//													calculationEndDate,
//													payoffDateInfo,
//													//xml_refCal,
//													ql_simpleRangeEventCal,
//													denumerDateNum,
//													usingVariableInfoList));
//
//	return simRangeRateETI;
//}

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::simpleRangeAccrualRateETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeAccrualRateTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> simpleRangeAccRateETI;
//
//	DayCounter dayCounter = Actual365Fixed();
//
//	qlReferenceCalculationFactory qlRefCalFactory = qlReferenceCalculationFactory();
//	
//	const boost::shared_ptr<ReferenceCalculation>& ql_refCal 
//		= qlRefCalFactory.referenceCal(xml_serial->getReferenceCalculation());
//
//	Date calculationStartDate = xml_serial->getCalculationStartDate()->dateValue();
//	Date calculationEndDate = xml_serial->getCalculationEndDate()->dateValue();
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	const std::vector<boost::shared_ptr<FpmlSerialized::SimpleRangeEvent>>& xml_simpleRangeEvent
//		= xml_serial->getSimpleRangeEventList()->getSimpleRangeEvent();
//
//	std::vector<boost::shared_ptr<QuantLib::SimpleRangeEvent>> ql_simpleRangeEvent;
//		
//	for ( Size i=0 ; ; i++ )
//	{
//		ql_simpleRangeEvent.push_back(this->simpleRangeEvent(xml_simpleRangeEvent[i]));
//	}
//
//	Size DenumerDateNum = xml_serial->getDenumerDateNum()->IValue();
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	simpleRangeAccRateETI = boost::shared_ptr<SimpleRangeAccrualRateETI>(
//							new SimpleRangeAccrualRateETI(dayCounter,
//													calculationStartDate,
//													calculationEndDate,
//													payoffDateInfo,
//													ql_refCal,
//													ql_simpleRangeEvent,
//													DenumerDateNum,
//													usingVariableInfoList));
//
//	return simpleRangeAccRateETI;
//}



//----------- compositeSumOption -----------------------------------------------------------------------------------------------------------------

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::compositeSumOptionETI(const boost::shared_ptr<FpmlSerialized::CompositeSumOptionPayoff>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> compSumOptionETI;
//
//	return compSumOptionETI;
//}

//----------- standardOption -----------------------------------------------------------------------------------------------------------------

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::standardOptionETI(const boost::shared_ptr<FpmlSerialized::StandardOption>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> standOptionETI;
//
//	std::string standardOptionType = xml_serial->getType()->SValue();
//
//	if ( standardOptionType == "barrierWithConstRebateCallOption")
//	{
//		const boost::shared_ptr<FpmlSerialized::BarrierWithConstRebateCallOption>& xml_barrierConstCall
//							= xml_serial->getBarrierWithConstRebateCallOption();
//
//		standOptionETI = this->barrierWithConstRebateCallOptionETI(xml_barrierConstCall);
//	}
//	else if ( standardOptionType == "barrierWithConstRebatePutOption")
//	{
//		const boost::shared_ptr<FpmlSerialized::BarrierWithConstRebatePutOption>& xml_barrierConstPut
//							= xml_serial->getBarrierWithConstRebatePutOption();
//
//		standOptionETI = this->barrierWithConstRebatePutOptionETI(xml_barrierConstPut);
//	}
//	/*else if ( xml_issueInfo->getType()->SValue() == "swapInfo" )
//	{
//		const boost::shared_ptr<FpmlSerialized::SwapInfo> xml_swapInfo = xml_issueInfo->getSwapInfo();
//
//		ql_inst = this->swapInstrument(xml_swapInfo);	
//	}
//	else if ( xml_issueInfo->getType()->SValue() == "optionInfo" )
//	{
//		const boost::shared_ptr<FpmlSerialized::OptionInfo> xml_optionInfo = xml_issueInfo->getOptionInfo();
//
//		ql_inst = this->optionInstrument(xml_optionInfo);	
//	}*/
//	else 
//	{
//		
//	}
//
//	return standOptionETI;
//}

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::vanillaCallETI(const boost::shared_ptr<FpmlSerialized::VanillaCallOption>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> callOptionETI;
//
//	qlReferenceCalculationFactory qlReferenceCalFactory = qlReferenceCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::ReferenceCalculationInfo>& xml_referenceCalInfo 
//					= xml_serial->getReferenceCalculationInfo();
//
//	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_referenceCalInfo
//					= qlReferenceCalFactory.referenceCalInfo(xml_referenceCalInfo);
//	
//	double partiRate = xml_serial->getParticipateRate()->DValue();
//	Real strike = xml_serial->getStrike()->DValue();
//	
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	double lowerBound = xml_serial->getLowerBound()->DValue();
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	callOptionETI = boost::shared_ptr<EventTriggerInfo>(
//		new VanillaCallETI(partiRate,
//						   payoffDateInfo,
//						   ql_referenceCalInfo,
//						   strike,
//						   lowerBound,
//						   usingVariableInfoList));
//
//
//	return callOptionETI;
//
//}
//
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::vanillaPutETI(const boost::shared_ptr<FpmlSerialized::VanillaPutOption>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> putOptionETI;
//
//	qlReferenceCalculationFactory qlReferenceCalFactory = qlReferenceCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::ReferenceCalculationInfo>& xml_referenceCalInfo 
//					= xml_serial->getReferenceCalculationInfo();
//
//	const boost::shared_ptr<QuantLib::ReferenceCalculationInfo>& ql_referenceCalInfo
//					= qlReferenceCalFactory.referenceCalInfo(xml_referenceCalInfo);
//	
//	double partiRate = xml_serial->getParticipateRate()->DValue();
//	Real strike = xml_serial->getStrike()->DValue();
//	
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	double lowerBound = xml_serial->getLowerBound()->DValue();
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	putOptionETI = boost::shared_ptr<EventTriggerInfo>(
//		new VanillaPutETI(partiRate,
//						   payoffDateInfo,
//						   ql_referenceCalInfo,
//						   strike,
//						   lowerBound,
//						   usingVariableInfoList));
//
//	return putOptionETI;
//}
//
////----------- notional ------------------------------------------------------------------------------------------------------------------------------------------------------
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::redemptionNotionalETI(const boost::shared_ptr<FpmlSerialized::RedemptionNotionalTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> redemNotionalETI;
//
//	double redemptionAmount = xml_serial->getRedemptionAmount()->DValue();
//	
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	redemNotionalETI = boost::shared_ptr<QuantLib::RedemptionNotionalETI>(
//							new RedemptionNotionalETI(redemptionAmount,
//													  payoffDateInfo,
//													  usingVariableInfoList));
//
//	return redemNotionalETI;
//}

//----------- returnTrigger -----------------------------------------------------------------------------------------------------------------------------------------------
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::simpleRangeReturnETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeReturnTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> simRangeReturnETI;
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	bool autoCallFlag = xml_serial->getAutoCallFlag()->BValue();
//	bool expired = xml_serial->getExpired()->BValue();
//
//	const boost::shared_ptr<FpmlSerialized::SimpleRangeEvent>& xml_simpleRangeEvent
//		= xml_serial->getSimpleRangeEvent();
//
//	const boost::shared_ptr<QuantLib::SimpleRangeEvent>& ql_simpleRangeEvent
//		=  this->simpleRangeEvent(xml_simpleRangeEvent);
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	simRangeReturnETI = boost::shared_ptr<SimpleRangeReturnETI>(
//							new SimpleRangeReturnETI(ql_simpleRangeEvent, 
//													payoffDateInfo,
//													autoCallFlag,
//													expired,
//													usingVariableInfoList));
//
//	return simRangeReturnETI;
//}

//----------- noAutoCallInfo -----------------------------------------------------------------------------------------------------------------

//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::noAutoCallReturnETI(const boost::shared_ptr<FpmlSerialized::NoAutoCallReturnTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> noAutoCallETI;
//
//	const boost::shared_ptr<FpmlSerialized::ReturnCalculation>& xml_returnCal
//		= xml_serial->getReturnCalculation();
//
//	qlReturnCalculationFactory qlRCF = qlReturnCalculationFactory();
//	const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_returnCal
//		= qlRCF.returnCal(xml_returnCal);
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	noAutoCallETI = boost::shared_ptr<QuantLib::NoAutoCallReturnETI>(
//		new NoAutoCallReturnETI(ql_returnCal,
//								payoffDateInfo,
//								usingVariableInfoList));
//
//	return noAutoCallETI;
//}

//----------- rateTrigger -----------------------------------------------------------------------------------------------------------------
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::fixedRateETI(const boost::shared_ptr<FpmlSerialized::FixedRateTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> fixedRateEti;
//
//	DayCounter dayCounter = Actual365Fixed();
//
//	Real fixedRate = xml_serial->getFixedRate()->DValue();
//
//	Date calStartDate = xml_serial->getCalculationStartDate()->dateValue();
//	Date calEndDate = xml_serial->getCalculationEndDate()->dateValue();
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> payoffDateInfo 
//				= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	bool isExpired = xml_serial->getIsExpired()->BValue();
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	fixedRateEti = boost::shared_ptr<QuantLib::FixedRateETI>(
//											new FixedRateETI(dayCounter,
//															fixedRate,
//															calStartDate,
//															calEndDate,
//															payoffDateInfo,
//															isExpired,
//															usingVariableInfoList));
//
//	return fixedRateEti;
//
//}

//----------- coupon Trigger -----------------------------------------------------------------------------------------------------------------
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::simpleEventCouponETI(const boost::shared_ptr<FpmlSerialized::SimpleEventCouponTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> ql_returnEti;
//
//	qlEventCalculationFactory qlECF = qlEventCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::EventCalculationInfo>& xml_eventCalInfo = xml_serial->getEventCalculationInfo();
//	const boost::shared_ptr<QuantLib::EventCalculationInfo>& ql_eventCalInfo = qlECF.eventCalInfo(xml_eventCalInfo);
//
//	qlReturnCalculationFactory qlRCF = qlReturnCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::ReturnCalculationInfo>& xml_returnCalInfo = xml_serial->getReturnCalculationInfo();
//	const boost::shared_ptr<QuantLib::ReturnCalculationInfo>& ql_returnCalInfo = qlRCF.returnCalInfo(xml_returnCalInfo);
//
//	const boost::shared_ptr<FpmlSerialized::ComplementReturnCalculation>& xml_complementReturnCal = xml_serial->getComplementReturnCalculation();
//	const boost::shared_ptr<QuantLib::ReturnCalculationInfo>& ql_complementReturnCalInfo = qlRCF.returnCalInfo(xml_complementReturnCal->getReturnCalculationInfo());
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> ql_payoffDateInfo 
//		= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	bool isExpired = xml_serial->getIsExpired()->BValue();
//
//	ql_returnEti = boost::shared_ptr<QuantLib::SimpleEventCouponETI>(
//									new QuantLib::SimpleEventCouponETI(ql_eventCalInfo,
//																	 ql_returnCalInfo,
//																	 ql_complementReturnCalInfo,
//																	 ql_payoffDateInfo,
//																	 isExpired,
//																	 usingVariableInfoList));
//
//													
//
//	return ql_returnEti;
//}
//
//boost::shared_ptr<EventTriggerInfo> qlEventTriggerInfoFactory::vanillaCouponETI(const boost::shared_ptr<FpmlSerialized::VanillaCouponTrigger>& xml_serial)
//{
//	boost::shared_ptr<EventTriggerInfo> ql_returnEti;
//
//	Real gearing = xml_serial->getGearing()->DValue();
//	Real spread = xml_serial->getSpread()->DValue();
//
//	qlReturnCalculationFactory qlRCF = qlReturnCalculationFactory();
//
//	const boost::shared_ptr<FpmlSerialized::ReturnCalculation>& xml_returnCal = xml_serial->getReturnCalculation();
//	const boost::shared_ptr<QuantLib::ReturnCalculation>& ql_returnCal = qlRCF.returnCal(xml_returnCal);
//
//	qlFixingDateInfoFactory qlFDF = qlFixingDateInfoFactory();
//
//	boost::shared_ptr<QuantLib::FixingDateInfo> ql_payoffDateInfo 
//		= qlFDF.fixingDateInfo(xml_serial->getPayoffDateInfo()->getFixingDateInfo());
//
//	std::vector<boost::shared_ptr<QuantLib::VariableInfo>> usingVariableInfoList;
//
//	bool isExpired = xml_serial->getIsExpired()->BValue();
//
//	ql_returnEti = boost::shared_ptr<QuantLib::VanillaCouponETI>(
//									new QuantLib::VanillaCouponETI(gearing,
//																   spread,
//																 ql_returnCal,
//																 ql_payoffDateInfo,
//																 isExpired,
//																 usingVariableInfoList));
//
//													
//
//	return ql_returnEti;
//}

}

