#ifndef xmlFactory_qlreferenceCalFactory_hpp
#define xmlFactory_qlreferenceCalFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlReferenceCalculationFactory {
		public:
			qlReferenceCalculationFactory();

			boost::shared_ptr<QuantLib::ReferenceCalculation> referenceCal(const boost::shared_ptr<FpmlSerialized::ReferenceCalculation>& xml_serial);
			boost::shared_ptr<QuantLib::ReferenceCalculationInfo> referenceCalInfo(const boost::shared_ptr<FpmlSerialized::ReferenceCalculationInfo>& xml_serial);

			boost::shared_ptr<QuantLib::ReferenceCalculation> underlyingCalc(const boost::shared_ptr<FpmlSerialized::Excel_underlyingCalcID>& xml_serial);

			boost::shared_ptr<QuantLib::ReferenceCalculation> e_choiceReferenceCal_singeCode(const std::string& code , Date fixingDate );
			boost::shared_ptr<QuantLib::ReferenceCalculation> e_identityReferenceCal_singeCode(const std::string& code , Date fixingDate );
			

		private:


			boost::shared_ptr<QuantLib::ReferenceCalculation> e_maximumReferenceCal(const boost::shared_ptr<FpmlSerialized::Excel_maximumUnderlyingCalcID>& xml_serial);
			boost::shared_ptr<QuantLib::ReferenceCalculation> e_minimumReferenceCal(const boost::shared_ptr<FpmlSerialized::Excel_minimumUnderlyingCalcID>& xml_serial);

			boost::shared_ptr<QuantLib::ReferenceCalculation> e_choiceReferenceCal(const boost::shared_ptr<FpmlSerialized::Excel_choiceUnderlyingCalcID>& xml_serial);
			




			boost::shared_ptr<QuantLib::ReferenceCalculation> identityReferenceCal(const boost::shared_ptr<FpmlSerialized::IdentityReferenceCal>& xml_serial);
			boost::shared_ptr<QuantLib::ReferenceCalculation> choiceReferenceCal(const boost::shared_ptr<FpmlSerialized::ChoiceReferenceCal>& xml_serial);
			boost::shared_ptr<QuantLib::ReferenceCalculation> maximumReferenceCal(const boost::shared_ptr<FpmlSerialized::MaximumReferenceCal>& xml_serial);
			boost::shared_ptr<QuantLib::ReferenceCalculation> minimumReferenceCal(const boost::shared_ptr<FpmlSerialized::MinimumReferenceCal>& xml_serial);

			boost::shared_ptr<QuantLib::ReferenceCalculation> refVariableReferenceCal(const boost::shared_ptr<FpmlSerialized::RefVariableReferenceCal>& xml_serial);
			boost::shared_ptr<QuantLib::ReferenceCalculation> dailyReturnReferenceCal(const boost::shared_ptr<FpmlSerialized::DailyReturnReferenceCal>& xml_serial);
	};
}

#endif