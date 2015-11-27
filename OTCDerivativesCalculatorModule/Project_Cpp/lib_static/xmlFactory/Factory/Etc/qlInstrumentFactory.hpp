#ifndef xmlFactory_qlInstrumentFactory_hpp
#define xmlFactory_qlInstrumentFactory_hpp

#include <util/xmlUtilHeader.hpp>
#include <GenClass\RiskMonitor-0-1\all.hpp>
#include <ql/instrument.hpp>

using namespace QuantLib;

namespace XmlFactory {

	class qlInstrumentFactory {
		public:
			qlInstrumentFactory();
			boost::shared_ptr<QuantLib::Instrument> instrument(const boost::shared_ptr<FpmlSerialized::IssueInformation> xml_issueInfo);

	/*		double notional_;
			std::vector<std::string> underListCode_;
			std::vector<Real> basePrices_;*/

		//----------- detail issueInfo -----------------------------------------------------------------------------------------------------------------
		private:

			boost::shared_ptr<QuantLib::Instrument> noteInstrument(const boost::shared_ptr<FpmlSerialized::NoteInfo> xml_serial);
			boost::shared_ptr<QuantLib::Instrument> swapInstrument(const boost::shared_ptr<FpmlSerialized::SwapInfo> xml_serial);
			boost::shared_ptr<QuantLib::Instrument> optionInstrument(const boost::shared_ptr<FpmlSerialized::OptionInfo> xml_serial);



	};
}

#endif