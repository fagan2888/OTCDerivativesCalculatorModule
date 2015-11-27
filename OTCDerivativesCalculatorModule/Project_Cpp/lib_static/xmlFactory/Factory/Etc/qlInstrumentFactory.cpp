#include "qlInstrumentFactory.hpp"
#include <src/Engine/MonteCarlo/instrument/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

qlInstrumentFactory::qlInstrumentFactory()
{

}

boost::shared_ptr<QuantLib::Instrument> qlInstrumentFactory::instrument(const boost::shared_ptr<FpmlSerialized::IssueInformation> xml_issueInfo)
{
	boost::shared_ptr<QuantLib::Instrument> ql_inst;

	if ( xml_issueInfo->getType()->SValue() == "noteInfo")
	{
		const boost::shared_ptr<FpmlSerialized::NoteInfo> xml_noteInfo = xml_issueInfo->getNoteInfo();

		ql_inst = this->noteInstrument(xml_noteInfo);
	}
	else if ( xml_issueInfo->getType()->SValue() == "swapInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::SwapInfo> xml_swapInfo = xml_issueInfo->getSwapInfo();

		ql_inst = this->swapInstrument(xml_swapInfo);	
	}
	else if ( xml_issueInfo->getType()->SValue() == "optionInfo" )
	{
		const boost::shared_ptr<FpmlSerialized::OptionInfo> xml_optionInfo = xml_issueInfo->getOptionInfo();

		ql_inst = this->optionInstrument(xml_optionInfo);	
	}
	else 
	{
		
	}

	return ql_inst;
}

boost::shared_ptr<QuantLib::Instrument> qlInstrumentFactory::noteInstrument(const boost::shared_ptr<FpmlSerialized::NoteInfo> xml_serial)
{
	Date tradeDate = xml_serial->getTradeDate()->dateValue();
	Date effectiveDate = xml_serial->getEffectiveDate()->dateValue();
	Date maturityDate = xml_serial->getMaturityDate()->dateValue();

	double notional = xml_serial->getNotional()->DValue();

	DayCounter daycounter = DayCounter();
	Calendar calendar = Calendar();

	boost::shared_ptr<QuantLib::NoteInst> noteinst 
					= boost::shared_ptr<QuantLib::NoteInst>(
												new NoteInst("test",notional,
															 effectiveDate,
															 maturityDate,
															 daycounter,
															 calendar));

	return noteinst;
}

boost::shared_ptr<QuantLib::Instrument> qlInstrumentFactory::swapInstrument(const boost::shared_ptr<FpmlSerialized::SwapInfo> xml_serial)
{
	boost::shared_ptr<QuantLib::Instrument> ql_inst;



	return ql_inst;
}

boost::shared_ptr<QuantLib::Instrument> qlInstrumentFactory::optionInstrument(const boost::shared_ptr<FpmlSerialized::OptionInfo> xml_serial)
{
	boost::shared_ptr<QuantLib::Instrument> ql_inst;



	return ql_inst;
}

}

