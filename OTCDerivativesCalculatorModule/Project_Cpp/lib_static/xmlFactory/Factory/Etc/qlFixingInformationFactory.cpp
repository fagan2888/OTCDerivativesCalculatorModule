#include "qlFixingInformationFactory.hpp"

namespace XmlFactory {

qlFixingInformationFactory::qlFixingInformationFactory()
{

}

boost::shared_ptr<QuantLib::FixingInformation> qlFixingInformationFactory::fixingInfo(const boost::shared_ptr<FpmlSerialized::FixingInformation>& xml_serial)
{
	boost::shared_ptr<QuantLib::FixingInformation> ql_fixingInfo;

	std::vector<boost::shared_ptr<FpmlSerialized::Fixing>> xml_fixings;

	if ( !xml_serial->isFixing() )
	{
		xml_fixings = xml_serial->getFixing();
	}

	std::vector<QuantLib::Date> fixingDates;
	std::vector<QuantLib::Real> fixingValues;

	Real initialValue = xml_serial->getInitialValue()->DValue();

	for ( Size i=0 ; i < xml_fixings.size() ; i++)
	{
		fixingDates.push_back(xml_fixings[i]->getDate()->dateValue());
		fixingValues.push_back(xml_fixings[i]->getValue()->DValue());
	}

	QL_REQUIRE(fixingDates.size() == fixingValues.size() , "fixingDate size must same fixingValue size");

	ql_fixingInfo = boost::shared_ptr<QuantLib::FixingInformation>(
		new QuantLib::FixingInformation(initialValue,
										fixingDates,
										fixingValues));

	return ql_fixingInfo;
}

}

