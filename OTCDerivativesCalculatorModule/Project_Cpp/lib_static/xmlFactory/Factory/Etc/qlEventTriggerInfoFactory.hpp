#ifndef xmlFactory_qleventTriggerInfoFactory_hpp
#define xmlFactory_qleventTriggerInfoFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/all.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlEventTriggerInfoFactory {
		public:
			qlEventTriggerInfoFactory();

			/*boost::shared_ptr<EventTriggerInfo> autoTerminationETI(const boost::shared_ptr<FpmlSerialized::AutoTerminationTrigger>& xml_serial);*/

			boost::shared_ptr<EventTriggerInfo> schedule(const boost::shared_ptr<FpmlSerialized::Excel_schedule >& xml_schedule);
			boost::shared_ptr<EventTriggerInfo> couponSchedule(const boost::shared_ptr<FpmlSerialized::Excel_couponSchedule >& xml_couponSchedule);

			// ---------------------------------------- hifive ---------------------------------------------
			boost::shared_ptr<EventTriggerInfo> excel_simpleCalculation(const boost::shared_ptr<FpmlSerialized::Excel_simpleCalculation>& xml_simpleCal);
			boost::shared_ptr<EventTriggerInfo> excel_kiEventCalculation(const boost::shared_ptr<FpmlSerialized::Excel_kiEventCalculation>& xml_kiEventCalculation);

			// ---------------------------------------- compOption ---------------------------------------------
			boost::shared_ptr<EventTriggerInfo> compOptionSubType(const boost::shared_ptr<FpmlSerialized::Excel_compositeOption_subtype>& xml_compOptionSub);

			boost::shared_ptr<EventTriggerInfo> excel_vanillaCallPut(const boost::shared_ptr<FpmlSerialized::Excel_vanillaCallPut >& xml_v_callPut);
			boost::shared_ptr<EventTriggerInfo> excel_upInOutCall(const boost::shared_ptr<FpmlSerialized::Excel_upInOutCall>& e_u_inOutCall);
			boost::shared_ptr<EventTriggerInfo> excel_downInOutPut(const boost::shared_ptr<FpmlSerialized::Excel_downInOutPut>& e_d_inOutPut);
			boost::shared_ptr<EventTriggerInfo> excel_digitalCallPut(const boost::shared_ptr<FpmlSerialized::Excel_digitalCallPut>& e_ditgit_callPut);

			// ---------------------------------------- multiAsset compOption ---------------------------------------------
			boost::shared_ptr<EventTriggerInfo> multiAssetCompOptionSubType(const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_compositeOption_subtype>& xml_multiAssetCompOptionSub);

			boost::shared_ptr<EventTriggerInfo> excel_multiAsset_vanillaCallPut(const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_vanillaCallPut>& xml_multi_v_callPut);
			boost::shared_ptr<EventTriggerInfo> excel_multiAsset_upInOutCall(const boost::shared_ptr<FpmlSerialized::Excel_multiAsset_upInOutCall>& xml_multi_u_inOutCall);

			// ---------------------------------------- bond_coupon---------------------------------------------

			boost::shared_ptr<EventTriggerInfo> excel_fixedCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponSchedule>& xml_fcs);

			boost::shared_ptr<EventTriggerInfo> excel_vanillaFloatingCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_vanillaFloatingCouponSchedule>& xml_vfcs);

			// ---------------------------------------- multi_condi_coupon---------------------------------------------
			boost::shared_ptr<EventTriggerInfo> excel_multiCondi_structuredCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_structuredCouponSchedule>& xml_mc_scs);

			boost::shared_ptr<EventTriggerInfo> excel_multiCondi_structuredAccrualCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_structuredAccrualCouponSchedule>& xml_mc_sacs);

			boost::shared_ptr<EventTriggerInfo> excel_multiCondi_multiRng_structuredAccrualCouponSchedule(
				const boost::shared_ptr<FpmlSerialized::Excel_multiCondi_multiRng_structuredAccrualCouponSchedule>& xml_mc_mr_sacs);

			//boost::shared_ptr<EventTriggerInfo> excel_multiAsset_downInOutPut(const boost::shared_ptr<FpmlSerialized::Excel_downInOutPut>& e_d_inOutPut);
			//boost::shared_ptr<EventTriggerInfo> excel_multiAsset_digitalCallPut(const boost::shared_ptr<FpmlSerialized::Excel_digitalCallPut>& e_ditgit_callPut);

			//boost::shared_ptr<EventTriggerInfo> eventTriggerInfo(const boost::shared_ptr<FpmlSerialized::EventTrigger>& xml_eventTrigger);
			

			//boost::shared_ptr<EventTriggerInfo> kiEventInfoETI(const boost::shared_ptr<FpmlSerialized::KiEventInfo>& xml_serial);
			//boost::shared_ptr<EventTriggerInfo> nonkiEventInfoETI(const boost::shared_ptr<FpmlSerialized::NonKiEventInfo>& xml_serial);
			
			//boost::shared_ptr<EventTriggerInfo> autoCallConstReturnETI(const boost::shared_ptr<FpmlSerialized::AutoCallConstReturnTrigger>& xml_serial);
			//boost::shared_ptr<EventTriggerInfo> simpleRangeConstReturnETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeConstReturnTrigger>& xml_serial);


			

			//----------- rangeEvent -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> simpleRangeRateETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeRateTrigger>& xml_serial);
			//boost::shared_ptr<EventTriggerInfo> simpleRangeAccrualRateETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeAccrualRateTrigger>& xml_serial);

			//----------- barrierDateInfo -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> barrierDateInfoETI(const boost::shared_ptr<FpmlSerialized::BarrierDateInfo>& xml_serial);

			//boost::shared_ptr<EventTriggerInfo> DailyIntervalETI(const boost::shared_ptr<FpmlSerialized::DailyInterval>& xml_serial);

			//----------- compositeSumOption -----------------------------------------------------------------------------------------------------------------

			//boost::shared_ptr<EventTriggerInfo> compositeSumOptionETI(const boost::shared_ptr<FpmlSerialized::CompositeSumOptionPayoff>& xml_serial);

			//----------- standardOption -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> standardOptionETI(const boost::shared_ptr<FpmlSerialized::StandardOption>& xml_serial);

			//boost::shared_ptr<EventTriggerInfo> vanillaCallETI(const boost::shared_ptr<FpmlSerialized::VanillaCallOption>& xml_serial);
			//boost::shared_ptr<EventTriggerInfo> vanillaPutETI(const boost::shared_ptr<FpmlSerialized::VanillaPutOption>& xml_serial);

			//----------- notional -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> redemptionNotionalETI(const boost::shared_ptr<FpmlSerialized::RedemptionNotionalTrigger>& xml_serial);

			//----------- returnTrigger -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> simpleRangeReturnETI(const boost::shared_ptr<FpmlSerialized::SimpleRangeReturnTrigger>& xml_serial);

			//----------- noAutoCallInfo -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> noAutoCallReturnETI(const boost::shared_ptr<FpmlSerialized::NoAutoCallReturnTrigger>& xml_serial);

			//----------- rateTrigger -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> vanillaRateETI(const boost::shared_ptr<FpmlSerialized::VanillaRateTrigger>& xml_serial);
			//boost::shared_ptr<EventTriggerInfo> fixedRateETI(const boost::shared_ptr<FpmlSerialized::FixedRateTrigger>& xml_serial);

			//std::vector<boost::shared_ptr<EventTriggerInfo>> fixedRateETI_List(const boost::shared_ptr<FpmlSerialized::Excel_fixedCouponScheduleList>& xml_serial);

			////----------- coupon Trigger -----------------------------------------------------------------------------------------------------------------
			//boost::shared_ptr<EventTriggerInfo> simpleEventCouponETI(const boost::shared_ptr<FpmlSerialized::SimpleEventCouponTrigger>& xml_serial);
			//boost::shared_ptr<EventTriggerInfo> vanillaCouponETI(const boost::shared_ptr<FpmlSerialized::VanillaCouponTrigger>& xml_serial);

	};
}

#endif