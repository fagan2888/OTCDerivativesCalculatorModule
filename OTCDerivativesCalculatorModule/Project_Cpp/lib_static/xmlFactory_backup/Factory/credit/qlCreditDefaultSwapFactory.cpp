#include "qlCreditDefaultSwapFactory.hpp"
#include <util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <Factory\Etc\qlYieldTermStructureFactory.hpp>
#include <ql/experimental/credit/lossdistribution.hpp>
#include <ql/experimental/credit/riskybond.hpp>
#include <ql/instruments/creditdefaultswap.hpp>

using namespace QuantLib;
using namespace ConvertFunction;

namespace XmlFactory {

qlCreditDefaultSwapFactory::qlCreditDefaultSwapFactory(const std::string& instInfoStr,
												 const std::string& paraInfoStr)
: instInfo_(instInfoStr) , paraInfo_(paraInfoStr)
{
}

void qlCreditDefaultSwapFactory::calculate()
{
	

	std::string name = "";
    Real recoveryRate = 0.4;

	std::vector<boost::shared_ptr<DefaultProbabilityTermStructure>> defaultRates;
	DayCounter dayCounter = Actual365Fixed();
	BusinessDayConvention paymentConvention = ModifiedFollowing;

	std::vector<Real> notionals;

	Real rate = 0.04;
	Size referenceNum = 5;

	TiXmlNode* node;

	for ( Size i=0 ; i< referenceNum ; ++i)
	{
		defaultRates.push_back(this->defaultTs(node));
	}

    Handle<DefaultProbabilityTermStructure> defaultTS;// = this->jointDefaultTs(

	//ir Ω∫ƒ…¡Ÿ?

	std::vector<Date> dates;

	TiXmlElement* dateNode = node->FirstChildElement("date");

	if(dateNode)
	{
		for(dateNode; dateNode; dateNode = dateNode->NextSiblingElement("date"))
		{
			dates.push_back(strToDate(dateNode->GetText()));
		}
	}

    Schedule schedule;

    //boost::shared_ptr<IborIndex> index
    Integer fixingDays = 0;
    Real spread = 0.0;
    //std::vector<Real> notionals
    Handle<YieldTermStructure> yieldTS;

	boost::shared_ptr<Instrument> inst = boost::shared_ptr<RiskyFixedBond>(
										new RiskyFixedBond(name,
														ccy,
														recoveryRate,
													    defaultTS,
													    schedule,
													    rate,
													    dayCounter,
													    paymentConvention,
													    notionals,
													    yieldTS);

	boost::shared_ptr<Instrument> inst = boost::shared_ptr<CreditDefaultSwap>(
										new CreditDefaultSwap(side,
															  notional,
															  upfront,
															  spread,
															  schedule,
															  paymentConvention,
															  dayCounter,
															  settlesAccrual,
															  paysAtDefaultTime,
															  protectionStart,
															  upfrontDate));
                          


}

boost::shared_ptr<DefaultProbabilityTermStructure> 
			jointDefaultTs(const std::vector<boost::shared_ptr<HazardRateStructure>>& hazardRates,
							Real corr,
							Size n = 1 ,
							Real maximum = 5.0, 
							Size integrationsSteps = 50)
{
	std::vector<Date> dates;
	Handle<Quote> correlation = Handle<Quote>(new SimpleQuote(corr));

	boost::shared_ptr<DefaultProbabilityTermStructure> ts 
				= boost::shared_ptr<DefaultProbabilityTermStructure>(
							new CopulaHazardRate<ProbabilityOfAtLeastNEvents,Linear>(dates,
																					 hazardRates,
																					 correlation));
	 return ts;
}

boost::shared_ptr<DefaultProbabilityTermStructure> defaultTs(TiXmlNode* node)
{
	std::string tsType = "default";

	boost::shared_ptr<DefaultProbabilityTermStructure> ts;

	return ts;
}

boost::shared_ptr<YieldTermStructure> yieldTs(TiXmlNode* node)
{
	std::string tsType = "yield";

    std::vector<QuantLib::Date> dates;
    std::vector<QuantLib::Real> data;
    QuantLib::Calendar calendar;
    QuantLib::DayCounter dayCounter;
    std::string traitsID;
    std::string interpolatorID;

	boost::shared_ptr<YieldTermStructure> ts;

	return ts;
}


}