#include "qlYieldTermStructureFactory.hpp"
#include <xmlFactory\util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <boost/algorithm/string.hpp>
#include <boost/lexical_cast.hpp>
#include <Factory\Etc\qlTimeUnitFactory.hpp>

using namespace QuantLib;
using namespace ConvertFunction;

namespace XmlFactory {

 
std::string qlYieldTermStructureFactory::buildTSXml(std::string curveType,
													std::vector<Period> periods,
													std::vector<Date> dates,
												    std::vector<Time> dateTimes,
												    std::vector<Real> data)
{
	
	Size tenorNum = dates.size();
	TiXmlDocument doc;
	//TiXmlDeclaration * decl = new TiXmlDeclaration( "1.0", "", "" );
	//doc.LinkEndChild( decl );
	
	TiXmlElement * resultElement = new TiXmlElement( "pricingResult" );
	doc.LinkEndChild( resultElement );
	
	//TiXmlElement * curveElement = new TiXmlElement( "hazardRateCurve" );
	TiXmlElement * curveElement = new TiXmlElement(curveType.c_str());
	resultElement->LinkEndChild( curveElement );

	TiXmlElement * tsElement = new TiXmlElement("termstructure");
	curveElement->LinkEndChild( tsElement );

	for(Size i=0 ; i<tenorNum ; ++i)
	{
		tsElement->LinkEndChild(new TiXmlText(
				this->buildRateDataXml(periods[i],dates[i],data[i]).c_str() ));
	}
	
	return tiXmlToStr(resultElement);
}

std::string buildRateDataXml(Period period,Date tenorDate,Real data)
{

	qlTimeUnitFactory tufactory = qlTimeUnitFactory();

	TiXmlElement * rateElement = new TiXmlElement("rateData");
	
	TiXmlElement * tenorElement = new TiXmlElement("tenor");
	
		TiXmlElement * periodMultiElement = new TiXmlElement("periodMultiplier");
		const std::string& multiple = boost::lexical_cast<std::string>(period.length());

		periodMultiElement->LinkEndChild(new TiXmlText(multiple.c_str()));

		TiXmlElement * periodElement = new TiXmlElement("period");
		periodElement->LinkEndChild(new TiXmlText(tufactory.periodStr(period).c_str()));
	
	tenorElement->LinkEndChild(periodMultiElement);
	tenorElement->LinkEndChild(periodElement);

	TiXmlElement * tenorDateElement = new TiXmlElement("tenorDate");
	tenorDateElement->LinkEndChild(new TiXmlText(dateToStr(tenorDate).c_str()));

	TiXmlElement * dataElement = new TiXmlElement("data");
	dataElement->LinkEndChild( new TiXmlText(boost::lexical_cast<std::string>(data).c_str() ));

	rateElement->LinkEndChild(tenorElement);
	rateElement->LinkEndChild(tenorDateElement);
	rateElement->LinkEndChild(dataElement);

	return tiXmlToStr(rateElement);

}
			

Handle<YieldTermStructure> qlYieldTermStructureFactory::yieldTSHandle(TiXmlNode* node)
{
	Date referenceDate = Settings::instance().evaluationDate();
	DayCounter dayCounter = Actual365Fixed();
	Calendar calendar = SouthKorea();

	TiXmlElement* tsNode = node->FirstChildElement("termstructure");
	
	double forwardRate = strToDouble(tsNode->GetText());

	TiXmlElement* typeNode = tsNode->FirstChildElement("type");
	std::string convStr = typeNode->GetText();
	std::string traitsID_ = boost::to_upper_copy(convStr);

	TiXmlElement* interpolationNode = tsNode->FirstChildElement("interpolation");
	std::string convStr2 = interpolationNode->GetText();
	std::string interpolatorID_ = boost::to_upper_copy(convStr2);

	std::vector<Date> dates;
	std::vector<Real> data;

	boost::shared_ptr<YieldTermStructure> yieldCurvePtr;
	Handle<YieldTermStructure> yieldCurve;

    if (traitsID_=="DISCOUNT") {
        if (interpolatorID_=="BACKWARDFLAT") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::BackwardFlat>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="LINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Linear>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="LOGLINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogLinear>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="CUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, false,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="LOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, false,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, true,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICLOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, true,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="KRUGERCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="KRUGERLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="FRITSCHBUTLANDCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="FRITSCHBUTLANDLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="PARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="LOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="MONOTONICPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, true)));
        } else if (interpolatorID_=="MONOTONICLOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, true)));
        } else
            QL_FAIL("unknown interpolatorID: " << interpolatorID_);
        }
	else if (traitsID_=="ZEROYIELD") {
        if (interpolatorID_=="BACKWARDFLAT") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::BackwardFlat>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="LINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Linear>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="LOGLINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogLinear>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="CUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, false,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="LOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, false,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, true,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICLOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, true,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="KRUGERCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="KRUGERLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="FRITSCHBUTLANDCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="FRITSCHBUTLANDLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="PARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="LOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="MONOTONICPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, true)));
        } else if (interpolatorID_=="MONOTONICLOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, true)));
        } else
            QL_FAIL("unknown interpolatorID: " << interpolatorID_);
    } else if (traitsID_=="FORWARDRATE") {
        if (interpolatorID_=="BACKWARDFLAT") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::BackwardFlat>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="LINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Linear>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="LOGLINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogLinear>(
                    dates, data, dayCounter, calendar));
        } else if (interpolatorID_=="CUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, false,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="LOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, false,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, true,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICLOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, true,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="KRUGERCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="KRUGERLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="FRITSCHBUTLANDCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="FRITSCHBUTLANDLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="PARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic)));
        } else if (interpolatorID_=="LOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="MONOTONICPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, true)));
        } else if (interpolatorID_=="MONOTONICLOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    dates, data, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, true)));
        } 
		else
		{
            QL_FAIL("unknown interpolatorID: " << interpolatorID_);
		}

	}
	else
	{
        QL_FAIL("unknown traitsID: " << traitsID_);
	}
		
		yieldCurve = Handle<YieldTermStructure>(yieldCurvePtr);

		return yieldCurve;
	}

}

