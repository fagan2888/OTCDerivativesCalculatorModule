#ifndef factory_yieldtermstructureFactory_hpp
#define factory_yieldtermstructureFactory_hpp

#include "qlYieldTermStructureFactory.hpp"
#include <xmlFactory\util\convertFunction.hpp>
#include <ql\time\calendars\all.hpp>
#include <boost/algorithm/string.hpp>
#include <boost/lexical_cast.hpp>
#include <GenClass/all.hpp>
#include <Factory\Etc\all.hpp>

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

std::string qlYieldTermStructureFactory::buildRateDataXml(Period period,Date tenorDate,Real data)
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

//Handle<YieldTermStructure> qlYieldTermStructureFactory::yieldTSHandle(boost::shared_ptr<FpmlSerialized::YieldTermstructure> xml_yieldTS)
//{
//	Handle<YieldTermStructure> yieldCurve = Handle<YieldTermStructure>(this->e_yieldTSBoost(xml_yieldTS));
//
//	return yieldCurve;
//}

boost::shared_ptr<YieldTermStructure> qlYieldTermStructureFactory::e_yieldTSBoost(const boost::shared_ptr<FpmlSerialized::Excel_yieldCurve>& xml_yieldTS)
{
	Date evaluationDate = Settings::instance().evaluationDate();

	const boost::shared_ptr<FpmlSerialized::Excel_interpolation>& xml_inter
		= xml_yieldTS->getExcel_interpolation();

	const std::string& dayCounterStr = xml_inter->getDaycounter()->SValue();
	const std::string& calendarStr = xml_inter->getCalendar()->SValue();
	const std::string& businessDayConvStr = xml_inter->getBusinessDayConvention()->SValue();

	qlDayCounterFactory qdcf = qlDayCounterFactory();
	DayCounter dayCounter = qdcf.dayCounter(dayCounterStr);

	qlCalendarFactory qcf = qlCalendarFactory();
	Calendar calendar = qcf.calendar(calendarStr);

	qlBusinessDayConvention qbdc = qlBusinessDayConvention();
	BusinessDayConvention conv = qbdc.businessDayConvention(businessDayConvStr);

	//const std::string& traitsID_ = boost::to_upper_copy( xml_yieldTS->getCurveType()->SValue());
	const std::string& traitsID_ = "ZEROYIELD";
	const std::string& interpolatorID_ = boost::to_upper_copy(xml_inter->getInterpolation()->SValue());

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_rateData>> rateList = xml_yieldTS->getExcel_rateData();

	std::vector<Period> tenors;
	std::vector<Date> maturities;
	std::vector<double> rates;

	Size tenorNum = rateList.size();
	qlTimeUnitFactory qtuf = qlTimeUnitFactory();

	for (Size i=0; i < tenorNum ; i++) 
	{
		tenors.push_back(qtuf.timeUnit(rateList[i]->getTenor()->SValue())); 
		maturities.push_back(calendar.adjust(evaluationDate + tenors[i],conv));
		rates.push_back(rateList[i]->getValue()->DValue());
	}

	// 마지막을 연결함.
	tenors.push_back(qtuf.timeUnit("50Y")); 
	maturities.push_back(calendar.adjust(evaluationDate + tenors[tenorNum],conv));
	rates.push_back( rates[tenorNum-1] );


	boost::shared_ptr<YieldTermStructure> yieldCurvePtr;

    if (traitsID_=="DISCOUNT") {
        if (interpolatorID_=="BACKWARDFLAT") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::BackwardFlat>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="LINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Linear>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="LOGLINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogLinear>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="CUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, false,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="LOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, false,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, true,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICLOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, true,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="KRUGERCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="KRUGERLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="FRITSCHBUTLANDCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="FRITSCHBUTLANDLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="PARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="LOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="MONOTONICPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, true)));
        } else if (interpolatorID_=="MONOTONICLOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedDiscountCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, true)));
        } else
            QL_FAIL("unknown interpolatorID: " << interpolatorID_);
        }
	else if (traitsID_=="ZEROYIELD") {
        if (interpolatorID_=="BACKWARDFLAT") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::BackwardFlat>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="LINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Linear>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="LOGLINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogLinear>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="CUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, false,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="LOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, false,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, true,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICLOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, true,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="KRUGERCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="KRUGERLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="FRITSCHBUTLANDCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="FRITSCHBUTLANDLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="PARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="LOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="MONOTONICPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, true)));
        } else if (interpolatorID_=="MONOTONICLOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedZeroCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, true)));
        } else
            QL_FAIL("unknown interpolatorID: " << interpolatorID_);
    } else if (traitsID_=="FORWARDRATE") {
        if (interpolatorID_=="BACKWARDFLAT") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::BackwardFlat>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="LINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Linear>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="LOGLINEAR") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogLinear>(
                    maturities, rates, dayCounter, calendar));
        } else if (interpolatorID_=="CUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, false,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="LOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, false,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Spline, true,
                                    CubicInterpolation::SecondDerivative, 0.0,
                                    CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="MONOTONICLOGCUBICNATURALSPLINE") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Spline, true,
                                        CubicInterpolation::SecondDerivative, 0.0,
                                        CubicInterpolation::SecondDerivative, 0.0)));
        } else if (interpolatorID_=="KRUGERCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="KRUGERLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Kruger)));
        } else if (interpolatorID_=="FRITSCHBUTLANDCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="FRITSCHBUTLANDLOGCUBIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::FritschButland)));
        } else if (interpolatorID_=="PARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic)));
        } else if (interpolatorID_=="LOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::LogCubic(CubicInterpolation::Parabolic, false)));
        } else if (interpolatorID_=="MONOTONICPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::Cubic>(
                    maturities, rates, dayCounter, calendar,
                    QuantLib::Cubic(CubicInterpolation::Parabolic, true)));
        } else if (interpolatorID_=="MONOTONICLOGPARABOLIC") {
            yieldCurvePtr = boost::shared_ptr<YieldTermStructure>(new
                InterpolatedForwardCurve<QuantLib::LogCubic>(
                    maturities, rates, dayCounter, calendar,
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
		
		

		return yieldCurvePtr;
	}

std::vector<boost::shared_ptr<YieldTermStructure>> qlYieldTermStructureFactory::e_yieldTermStructureList(const boost::shared_ptr<FpmlSerialized::Excel_discountCurve_para>& xml_discountCurve_para)
{
	std::vector<boost::shared_ptr<YieldTermStructure>> ytsList;

	std::vector<boost::shared_ptr<FpmlSerialized::Excel_yieldCurve>> e_yieldCurve
		= xml_discountCurve_para->getExcel_yieldCurve();

	for ( Size i=0 ;i < e_yieldCurve.size() ;++i)
	{
		ytsList.push_back(this->e_yieldTSBoost(e_yieldCurve[i]));
	}
	
	return ytsList;
}

}

#endif
