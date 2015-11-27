// Calculation.hpp 
#ifndef factory_termstructureFactory_hpp
#define factory_termstructureFactory_hpp

#include <ql/time/period.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/calendar.hpp>
#include <ql/math/array.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/termstructures/defaulttermstructure.hpp>
#include <xmlFactory/Factory/Etc/all.hpp>
#include <ql/termstructures/credit/defaultprobabilityhelpers.hpp>
#include <ql/termstructures/all.hpp>
#include <ql/termstructures/credit/all.hpp>
#include <ql/termstructures/credit/copulasurvivalratestructure.hpp>
#include <ql/experimental/credit/lossdistribution.hpp>
#include <GenClass/all.hpp>

using namespace QuantLib;
using namespace FpmlSerialized;

namespace XmlFactory {

	class qlTermstructureFactory {

		public:

			qlTermstructureFactory()
			{
			}

			qlTermstructureFactory(std::vector<QuantLib::Period> tenor,
								   const DayCounter& dayCounter,
								   const Calendar& calendar)
			: tenor_(tenor), dayCounter_(dayCounter), calendar_(calendar)
			{
				tenorNum_ = tenor_.size();
			}

			boost::shared_ptr<DefaultProbabilityTermStructure> jointDefaultTS()
			{
				boost::shared_ptr<DefaultProbabilityTermStructure> jointProbCurve;

				return jointProbCurve;
			}

			boost::shared_ptr<DefaultProbabilityTermStructure> jointDefaultTS(TiXmlNode* node)
			{
				FpmlSerialized::ReferenceEntityInfo_para serial_referEntityInfo = FpmlSerialized::ReferenceEntityInfo_para(node);
				std::vector<boost::shared_ptr<FpmlSerialized::ReferenceCurve> > serial_curves = serial_referEntityInfo.getReferenceCurveList()->getReferenceCurve();

				Size curvesNum = serial_curves.size();

				std::vector<boost::shared_ptr<DefaultProbabilityTermStructure> > defaultTSList;

				for ( Size i=0 ; i<curvesNum ; ++i)
				{
					defaultTSList.push_back(this->defaultTS(serial_curves[i]->getNode()));
				}

				//DayCounter dayCounter = Actual365Fixed();
				//Calendar calendar = SouthKorea();

				//boost::shared_ptr<QuantLib::YieldTermStructure> ts
				//	= boost::shared_ptr<QuantLib::YieldTermStructure>(new
    //                InterpolatedDiscountCurve<QuantLib::BackwardFlat>(
    //                    dates, data, dayCounter, calendar));

				//CopulaHazardRate<ProbabilityOfAtLeastNEvents,BackwardFlat> testTs
				//	=CopulaHazardRate<ProbabilityOfAtLeastNEvents,BackwardFlat>(
				//		dates,defaultTSList,corrQuote,nth,5,100);

				//boost::shared_ptr<DefaultProbabilityTermStructure>
				//	jointProbCurve(new CopulaSurvivalProb<ProbabilityOfAtLeastNEvents,BackwardFlat>(
				//		defaultTSList,corrQuote,nth,5,100));

				//boost::shared_ptr<DefaultProbabilityTermStructure>
				//	jointProbCurve(new CopulaSurvivalProbStructure<ProbabilityOfAtLeastNEvents>(
				//		defaultTSList,corrQuote,nth,5,100));

				/*boost::shared_ptr<DefaultProbabilityTermStructure>
					jointProbCurve = boost::shared_ptr<DefaultProbabilityTermStructure>(new CopulaHazardRate<ProbabilityOfAtLeastNEvents,BackwardFlat>(
						dates,defaultTSList,corrQuote,nth,5,100));*/
				//boost::shared_ptr<DefaultProbabilityTermStructure> jointProbCurve;

				boost::shared_ptr<DefaultProbabilityTermStructure> jointProbCurve;

				if ( curvesNum == 1)
				{
					jointProbCurve = defaultTSList[0];
				}
				else if ( curvesNum > 1 )
				{
					boost::shared_ptr<FpmlSerialized::JointProbabilityTrait> serial_jointProbTrait 
							= serial_referEntityInfo.getJointProbabilityTrait();

					double corr = serial_jointProbTrait->getNthDefaultTrait()->getCorrelation()->DValue();
				    Size nth = serial_jointProbTrait->getNthDefaultTrait()->getNth()->IValue();
					Handle<Quote> corrQuote(new SimpleQuote(corr));

					jointProbCurve = boost::shared_ptr<DefaultProbabilityTermStructure>(
						new CopulaSurvivalProbStructure<ProbabilityOfAtLeastNEvents>(defaultTSList,corrQuote,nth,8,1000));
				}else
				{
					QL_FAIL("cds curve must exist");
				}

				return jointProbCurve;

			}

			boost::shared_ptr<DefaultProbabilityTermStructure> defaultTS(TiXmlNode* node)
			{
				//여기서 cuve 구분
				FpmlSerialized::ReferenceCurve serial_curve = FpmlSerialized::ReferenceCurve(node);
				const std::string& curveType = serial_curve.getChoiceStr_tsType();
				
				//if(curveType == "")
				//{
				//}else if(curveType == "")
				//{
				//}else
				//{
				//	// exception
				//}

				Date evaluationDate = Settings::instance().evaluationDate();

				//if
				boost::shared_ptr<FpmlSerialized::CdsSpreadTermstructure> serial_cdsSpreadTS = serial_curve.getCdsSpreadTermstructure();

				const std::string& interpolationTrait = serial_cdsSpreadTS->getInterpolation()->SValue();
				const std::string& dayCounterStr = serial_cdsSpreadTS->getDaycounter()->SValue();
				const std::string& calendarStr = serial_cdsSpreadTS->getCalendar()->SValue();
				const std::string& businessDayConvStr = serial_cdsSpreadTS->getBusinessDayConvention()->SValue();
				const std::string& dateGenerationStr = serial_cdsSpreadTS->getDateGeneration()->SValue();

				qlDayCounterFactory qdcf = qlDayCounterFactory();
				DayCounter dayCounter = qdcf.dayCounter(dayCounterStr);

				qlCalendarFactory qcf = qlCalendarFactory();
				Calendar calendar = qcf.calendar(calendarStr);

				qlBusinessDayConvention qbdc = qlBusinessDayConvention();
				BusinessDayConvention conv = qbdc.businessDayConvention(businessDayConvStr);

				qlDateGenerationFactory qdgf = qlDateGenerationFactory();
				DateGeneration::Rule rule =  qdgf.dateGeneration(dateGenerationStr);

				Real recovery_rate = serial_cdsSpreadTS->getRecoveryRate()->DValue();;

				std::vector<boost::shared_ptr<FpmlSerialized::RateData>> rateList = serial_cdsSpreadTS->getRateData();

				std::vector<Period> tenors;
				std::vector<Date> maturities;
				std::vector<double> spreadRates;

				Size tenorNum = rateList.size();
				qlTimeUnitFactory qtuf = qlTimeUnitFactory();

				for (Size i=0; i < tenorNum ; i++) 
				{
					tenors.push_back(qtuf.timeUnit(rateList[i]->getNode())); 
					maturities.push_back(calendar.adjust(evaluationDate + tenors[i],conv));
					spreadRates.push_back(rateList[i]->getData()->DValue());
				}

				//dummy curve
				boost::shared_ptr<Quote> flatRate(new SimpleQuote(0.01));
				Handle<YieldTermStructure> tsCurve(
							boost::shared_ptr<FlatForward>(
												new FlatForward(evaluationDate, 
																Handle<Quote>(flatRate),
																dayCounter)));


				//boost::shared_ptr<DefaultProbabilityTermStructure> defaultTs;

				std::vector<boost::shared_ptr<DefaultProbabilityHelper> > instruments;

				for ( Size i = 0 ; i < tenorNum ; i++ ) 
				{
					instruments.push_back(boost::shared_ptr<DefaultProbabilityHelper>(
						new SpreadCdsHelper(
									  Handle<Quote>(boost::shared_ptr<Quote>(new SimpleQuote(spreadRates[i]))),
									  tenors[i],
									  0,
									  calendar,
									  Quarterly,
									  conv,
									  rule,
									  dayCounter,//Actual365Fixed(),
									  recovery_rate,
									  tsCurve)));
				}

				// Bootstrap hazard rates
				boost::shared_ptr<PiecewiseDefaultCurve<HazardRate, BackwardFlat> >
				   hazardRateStructure(
					   new PiecewiseDefaultCurve<HazardRate, BackwardFlat>(
																   evaluationDate,
																   instruments,
																   dayCounter));

				std::vector<std::pair<Date, Real> > hr_curve_data = hazardRateStructure->nodes();

				std::cout << "Calibrated hazard rate values: " << std::endl ;
				for (Size i=0; i<hr_curve_data.size(); i++) {
					std::cout << "hazard rate on " << hr_curve_data[i].first << " is "
						 << hr_curve_data[i].second << " survivalRate :" << hazardRateStructure->survivalProbability(hr_curve_data[i].first) << std::endl;
				}
				std::cout << std::endl;

				return hazardRateStructure;
			
			}

			boost::shared_ptr<YieldTermStructure> yieldTs(const std::vector<Real>& data)
			{
				QL_REQUIRE(tenor_.size() == data.size(), "not equal data Num");
				boost::shared_ptr<YieldTermStructure> yts;
				return yts;
			}

			boost::shared_ptr<YieldTermStructure> yieldTs(const Array& data)
			{
				QL_REQUIRE(tenor_.size() == data.size(), "not equal data Num");
				boost::shared_ptr<YieldTermStructure> yts;
				return yts;
			}

			boost::shared_ptr<YieldTermStructure> yieldTs(TiXmlNode* node)
			{
				boost::shared_ptr<YieldTermStructure> yieldTS;

				return yieldTS;
			}

		private:
			Size tenorNum_;
			std::vector<QuantLib::Period> tenor_;
			DayCounter dayCounter_;
			Calendar calendar_;

	};
}
#endif