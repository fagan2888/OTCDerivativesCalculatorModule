#ifndef xmlFactory_qlReturnCalculationFactory_hpp
#define xmlFactory_qlReturnCalculationFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/all.hpp>
#include <GenClass/RiskMonitor-0-1/all.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/returnCalculationInfo.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlReturnCalculationFactory {
		public:
			qlReturnCalculationFactory();

			boost::shared_ptr<QuantLib::PreCalculation> preCal(const boost::shared_ptr<FpmlSerialized::PreCalculation>& xml_serial);
			//boost::shared_ptr<QuantLib::PostCalculation> postCal(const boost::shared_ptr<FpmlSerialized::PostCalculation>& xml_serial);

			//boost::shared_ptr<QuantLib::ReturnCalculation> returnCal(const boost::shared_ptr<FpmlSerialized::ReturnCalculation>& xml_serial);
			//boost::shared_ptr<QuantLib::ReturnCalculationInfo> returnCalInfo(const boost::shared_ptr<FpmlSerialized::ReturnCalculationInfo>& xml_serial);

			boost::shared_ptr<QuantLib::ReturnCalculation> e_returnCal(const boost::shared_ptr<FpmlSerialized::Excel_returnCalcInfo>& xml_serial);
			boost::shared_ptr<QuantLib::ReturnCalculationInfo> e_returnCalcInfo(const boost::shared_ptr<FpmlSerialized::Excel_returnCalcInfo>& xml_serial);

			boost::shared_ptr<QuantLib::ReturnCalculation> e_vanillaReturnCal(const boost::shared_ptr<FpmlSerialized::Excel_vanillaReturnCal>& xml_serial);
			boost::shared_ptr<QuantLib::ReturnCalculation> e_constReturnCal(const boost::shared_ptr<FpmlSerialized::Excel_constReturnCal>& xml_serial);
			//boost::shared_ptr<QuantLib::ReturnCalculation> stopLossReturnCal(const boost::shared_ptr<FpmlSerialized::StopLossReturnCal>& xml_serial);
			//boost::shared_ptr<QuantLib::ReturnCalculation> callPutCompositeReturnCal(const boost::shared_ptr<FpmlSerialized::CallPutCompositeReturnCal>& xml_serial);

	};
}

#endif