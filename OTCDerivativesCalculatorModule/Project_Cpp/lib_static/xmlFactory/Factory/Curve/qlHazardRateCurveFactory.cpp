#include "qlHazardRateCurveFactory.hpp"
#include <util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <Factory\Etc\qlYieldTermStructureFactory.hpp>
#include <ql/time/all.hpp>
#include <ql/termstructures/credit/all.hpp>
#include <ql/termstructures/credit/copulahazardrate2.hpp>
#include <iostream>
#include <Factory\Etc\qlTimeUnitFactory.hpp>
#include <Factory\Etc\qlCalendarFactory.hpp>
#include <Factory\Etc\qlYieldTermStructureFactory.hpp>
#include <ql\experimental\credit\lossdistribution.hpp>

using namespace QuantLib;
using namespace ConvertFunction;

namespace XmlFactory {

qlHazardRateFactory::qlHazardRateFactory(const std::string& instInfoStr,
										   const std::string& paraInfoStr)
: instInfo_(instInfoStr) , paraInfo_(paraInfoStr)
{
}

boost::shared_ptr<HazardRateStructure> qlHazardRateFactory::hazardRateTS(TiXmlNode* node)
{
	boost::shared_ptr<HazardRateStructure> hazardCurve;
	
	Date referenceDate = Settings::instance().evaluationDate();

	std::vector<boost::shared_ptr<DefaultProbabilityHelper> > instruments;

	qlCalendarFactory calFactory = qlCalendarFactory();
	qlTimeUnitFactory timeUnitFactory = qlTimeUnitFactory();
	qlYieldTermStructureFactory tsFactory = qlYieldTermStructureFactory();

	Calendar calendar = calFactory.calendar(node->FirstChildElement("calendar")->GetText());
	Real recoveryRate = strToDouble(node->FirstChildElement("recoveryRate")->GetText());

	TiXmlElement* rateNode = node->FirstChildElement("rateData");

	std::vector<Period> periods;
	std::vector<Real> spreadRates;

	if(rateNode)
	{
		for(rateNode; rateNode; rateNode = rateNode->NextSiblingElement("rateData"))
		{
			periods.push_back(timeUnitFactory.timeUnit(rateNode));
			spreadRates.push_back(strToDouble(rateNode->FirstChildElement("data")->GetText()));
		}
	}

    for (Size i=0; i<periods.size(); i++) {
        instruments.push_back(boost::shared_ptr<DefaultProbabilityHelper>(
            new SpreadCdsHelper(
                            Handle<Quote>(boost::shared_ptr<Quote>(
                                        new SimpleQuote(spreadRates[i]))),
                            periods[i],
                            0,
                            calendar,
                            Quarterly,
                            Following,
                            DateGeneration::TwentiethIMM,
                            Actual365Fixed(),
                            recoveryRate,
                            tsCurve_)));
    }

    // Bootstrap hazard rates

	std::string curveType = "HazardRate";
	std::string interpolationType = "BackwardFlat";

    boost::shared_ptr<PiecewiseDefaultCurve<HazardRate, BackwardFlat> >
        hazardRateStructure(
            new PiecewiseDefaultCurve<HazardRate, BackwardFlat>(
                                                        referenceDate,
                                                        instruments,
                                                        Actual365Fixed()));

	return hazardCurve;
}



void qlHazardRateFactory::calculate()
{
	 try {

		TiXmlDocument document;
		document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
		TiXmlNode* rootNode = document.FirstChild("defaultCurveCalculation");

		Settings::instance().evaluationDate() = 
				strToDate(rootNode->FirstChildElement("evaluationTime")->GetText());

		DayCounter daycounter = Actual365Fixed();

		TiXmlElement* pricingParametorNode = rootNode->FirstChildElement("pricingParameter");
		TiXmlElement* referenceCurveNode = pricingParametorNode->FirstChildElement("referenceCurves");

		Calendar calendar = SouthKorea();

		Date refereceDate = Settings::instance().evaluationDate();
		
        // must be a business day
        refereceDate = calendar.adjust(refereceDate);
		
        // dummy curve
        boost::shared_ptr<Quote> flatRate(new SimpleQuote(0.01));

        //Handle<YieldTermStructure> tsCurve(
        //      boost::shared_ptr<FlatForward>(
        //              new FlatForward(todaysDate, Handle<Quote>(flatRate),
        //                              Actual365Fixed())));


		TiXmlNode* pricingParametorNode = document.FirstChild("pricingParameter");
		
		TiXmlElement* referenceCurveNode = pricingParametorNode->FirstChildElement("referenceCurves");

		std::vector<boost::shared_ptr<HazardRateStructure>> hazardRateCurves;

		TiXmlElement* tsNode = referenceCurveNode->FirstChildElement("termstructure");

		if(tsNode)
		{
			for(tsNode; tsNode; tsNode = tsNode->NextSiblingElement("termstructure"))
			{
				hazardRateCurves.push_back(this->hazardRateTS(tsNode));
			}
		}

		TiXmlNode* yieldNode = document.FirstChild("yieldNode");

		qlYieldTermStructureFactory yieldTsFactory = qlYieldTermStructureFactory();
		this->tsCurve_ = yieldTsFactory.yieldTSHandle(yieldNode);

	    // outputTenor Build
        std::vector<Period> outputTenors;
		Size outputNum = outputTenors.size();

		qlTimeUnitFactory tuFactory = qlTimeUnitFactory();
		TiXmlElement* outputTenorNode = pricingParametorNode->FirstChildElement("outputCurveTemplate");

		TiXmlElement* tenorNode = outputTenorNode->FirstChildElement("tenorList");

		if(tenorNode)
		{
			for(tenorNode; tenorNode; tenorNode = tenorNode->NextSiblingElement("tenor"))
			{
				outputTenors.push_back(tuFactory.timeUnit(tenorNode));
			}
		}
	 
		//compositeCalculation

		boost::shared_ptr<DefaultProbabilityTermStructure> copulaHazardTS = 
			boost::shared_ptr<DefaultProbabilityTermStructure>(new CopulaHazardRate<ProbabilityOfAtLeastNEvents,Linear>(
				dates,hazardRateCurves,0.9,1,50));



		//result


		for (Size i=0 ; i<outputNum ; ++i)
		{
			dates_.push_back(calendar.advance(refereceDate,outputTenors[i]));
			dateTimes_.push_back(daycounter.yearFraction(refereceDate,dates_[i]));
			data_.push_back(copulaHazardTS->defaultProbability(dateTimes_[i]));	

		}

		// makeXml

		this->buildResultXml();

		//this->buildResultXml(inst_->additionalResults());
	
	} catch (std::exception& e) {
        std::cerr << e.what() << std::endl;
    } catch (...) {
        std::cerr << "unknown error" << std::endl;
    }

	
}
void qlHazardRateFactory::buildResultXml()
{
	qlYieldTermStructureFactory tsFactory = qlYieldTermStructureFactory();
	this->result_ = tsFactory.buildTSXml("",outputTenors_,dates_,dateTimes_,data_);
}


}