#ifndef xmlFactory_qldateInformationFactory_hpp
#define xmlFactory_qldateInformationFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlDateInformationFactory {
		public:
			qlDateInformationFactory();
			boost::shared_ptr<QuantLib::DateInformation> dateInfo(const boost::shared_ptr<FpmlSerialized::DateInformation>& xml_serial);

		private:
			

			double notional_;
			std::vector<std::string> underListCode_;
			std::vector<Real> basePrices_;


		//----------- detail pricer -----------------------------------------------------------------------------------------------------------------
		private:

			boost::shared_ptr<QuantLib::DateInformation> dailyInterval(const boost::shared_ptr<FpmlSerialized::DailyInterval>& xml_serial);
			boost::shared_ptr<QuantLib::DateInformation> dateList(const boost::shared_ptr<FpmlSerialized::DateList>& xml_serial);

	};
}

#endif