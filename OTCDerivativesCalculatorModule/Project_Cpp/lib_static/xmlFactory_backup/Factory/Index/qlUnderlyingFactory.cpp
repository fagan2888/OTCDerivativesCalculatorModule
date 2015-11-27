#include "qlUnderlyingFactory.hpp"
#include <calculationModule/src/engine/montecarlo/structuredproduct/symbolmanager/pathinformation.hpp>

namespace XmlFactory {

qlUnderlyingFactory::qlUnderlyingFactory(){}

void qlUnderlyingFactory::setSerialClass(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under)
{
	std::string choiceStr_indexType = serial_under->getChoiceStr_indexType();
	

	if( choiceStr_indexType == "stockIndex")	{ this->index_ = this->getStockIndex(serial_under);}
	else if( choiceStr_indexType == "interestRateIndex")	{ this->index_ = this->getInterestRateIndex(serial_under);}
	else if( choiceStr_indexType == "commodityIndex")	{ this->index_ = this->getCommodityIndex(serial_under);}
	else {QL_FAIL("unknown type index" << choiceStr_indexType);}
	
		
}

boost::shared_ptr<QuantLib::Index> qlUnderlyingFactory::getStockIndex(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under)
{
	boost::shared_ptr<QuantLib::UnderlyingIndex> ql_stockIndex;

	const boost::shared_ptr<FpmlSerialized::StockIndex>& serial_stock = serial_under->getStockIndex();

	qlCurrencyFactory ql_curf = qlCurrencyFactory();
	qlCalendarFactory ql_calf = qlCalendarFactory();
	qlBusinessDayConvention ql_bdc = qlBusinessDayConvention();
	qlDayCounterFactory ql_dcf = qlDayCounterFactory();

	const std::string& name = serial_stock->getName()->SValue();
		
	PathInformation::instance().addIndexName(name);

	//const std::string& currencyStr = serial_under->getCurrency()->
	const std::string& currencyStr = "KRW";
	const std::string& calendarStr = "KOR";
	const std::string& bdcStr = "FOLLOWING";
	const std::string& dcStr = "Act/360";


	const boost::shared_ptr<QuantLib::Currency>& currency = ql_curf.currency(currencyStr);
	QuantLib::Calendar calendar = ql_calf.calendar(calendarStr);
	BusinessDayConvention bdc = ql_bdc.businessDayConvention(bdcStr);
	const boost::shared_ptr<QuantLib::DayCounter>& dc = ql_dcf.dayCounter(dcStr);
		

	ql_stockIndex = boost::shared_ptr<QuantLib::UnderlyingIndex>(
									new QuantLib::UnderlyingIndex(name,
														*currency,
														calendar,
														bdc,
														false,
														*dc));

	return ql_stockIndex;

}

boost::shared_ptr<QuantLib::Index> qlUnderlyingFactory::getInterestRateIndex(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under)
{
	boost::shared_ptr<QuantLib::Index> ql_index;

	return ql_index;
}

boost::shared_ptr<QuantLib::Index> qlUnderlyingFactory::getCommodityIndex(const boost::shared_ptr<FpmlSerialized::UnderlyingIndex>& serial_under)
{
	boost::shared_ptr<QuantLib::Index> ql_index;

	return ql_index;
}
boost::shared_ptr<QuantLib::Index> qlUnderlyingFactory::getIndex(){
	return index_;
}

}