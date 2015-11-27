//#include "qlCreditDefaultProductFactory.hpp"
//#include <util\convertFunction.hpp>
//#include <ql\time\calendars\all.hpp>
//#include <factory\Etc\all.hpp>
//#include <boost/lexical_cast.hpp>
//#include <ql/instruments/creditdefaultswap.hpp>
//#include <ql/pricingengines/credit/midpointcdsengine.hpp>
//#include <GenClass/RiskMonitor-0-1/all.hpp>
//#include <src/Engine/MonteCarlo/MonteEngine.hpp>
//#include <src/Engine/MonteCarlo/pricer/vanillaCreditEventPricer.hpp>
//
//using namespace QuantLib;
//using namespace ConvertFunction;
//
//namespace XmlFactory {
//
//qlCreditDefaultProductFactory::qlCreditDefaultProductFactory(const std::string& instInfoStr,
//															 const std::string& paraInfoStr)
//: InstrumentFactory()
//{
//	this->instInfo_ = instInfoStr;
//	this->paraInfo_ = paraInfoStr;
//}
//
//void qlCreditDefaultProductFactory::calculate(const std::string& instInfoStr,
//											  const std::string& paraInfoStr)
//{
//	boost::shared_ptr<PricingEngine> engine = this->engine();
//	
//	inst_->setPricingEngine(engine);
//
//	value_ = inst_->NPV();
//
//	std::cout << "price : " << value_<< std::endl;
//	//std::cout << value << std::endl;
//	//this->buildResultXml(inst_->additionalResults());
//	
//}
//
//void qlCreditDefaultProductFactory::buildqlProduct()
//{
//	TiXmlDocument document;
//	document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	TiXmlNode* instrumentNode = document.FirstChild("instrument");
//
//	FpmlSerialized::Excel_cds serial_e_cds = FpmlSerialized::Excel_cds(instrumentNode);
//
//	const boost::shared_ptr<FpmlSerialized::Excel_creditEventSwapLeg>& serial_e_creditLeg = serial_e_cds.getExcel_creditEventSwapLeg();
//	const boost::shared_ptr<FpmlSerialized::Excel_swapLeg>& serial_e_swapLeg = serial_e_cds.getExcel_swapLeg();
//
//	//----------------------------------------------
//	const boost::shared_ptr<FpmlSerialized::Excel_fixedRateSwapLeg>& serial_e_fixSwapLeg
//		= serial_e_swapLeg->getExcel_fixedRateSwapLeg();
//
//	const boost::shared_ptr<FpmlSerialized::Excel_fixedBond>& serial_e_fixBond
//		= serial_e_swapLeg->getExcel_fixedRateSwapLeg()->getExcel_fixedBond();
//
//	const boost::shared_ptr<Excel_fixedCouponScheduleList>& serial_e_fixCouponScheList
//		= serial_e_fixBond->getExcel_fixedCouponScheduleList();
//
//	//const boost::shared_ptr<QuantLib::Leg>& leg = qlcff.fixedLeg(serial_e_fixCouponScheList);
//	
//	// null exception
//	Real notional = serial_e_fixBond->getExcel_issueInfo()->getExcel_swapLegInfo()->getNotional()->DValue();
//	
//	Protection::Side side = Protection::Buyer;
//	BusinessDayConvention paymentConvention = BusinessDayConvention::Following;
//
//	//const DayCounter& dayCounter,
//	bool settlesAccrual = true;
//	bool paysAtDefaultTime = true;
//	//const Date& protectionStart = Date(),
//
//	qlDayCounterFactory qldcf = qlDayCounterFactory();
//
//	QuantLib::DayCounter dayCounter = qldcf.dayCounter(serial_e_fixCouponScheList->getDayCounter()->SValue());
//
//	qlEventTriggerInfoFactory qletif = qlEventTriggerInfoFactory();
//
//	const std::vector<boost::shared_ptr<EventTriggerInfo>>& fixedEtiList
//		= qletif.fixedRateETI_List(serial_e_fixCouponScheList);
//
//	this->pricer_ = boost::shared_ptr<QuantLib::VanillaCreditEventPricer>(
//						new QuantLib::VanillaCreditEventPricer(fixedEtiList,
//						this->defaultCurve_));
//
//	//inst_ = boost::shared_ptr<QuantLib::CreditDefaultSwap>(
//	//		new QuantLib::CreditDefaultSwap(side,
//	//						notional,
//	//						spread,
//	//						schedule,
//	//						paymentConvention,
//	//						dayCounter,
//	//						settlesAccrual,
//	//						paysAtDefaultTime));
//
//	
//	
//}
//
////Schedule qlCreditDefaultProductFactory::schedule(TiXmlNode* node)
////{
////
////	FpmlSerialized::SchduleGen paymentDates = FpmlSerialized::SchduleGen(node);
////
////	Date effectiveDate = paymentDates.getEffectiveDate()->dateValue();
////	Date terminationDate = paymentDates.getTerminationDate()->dateValue();
////	const boost::shared_ptr<FpmlSerialized::CalculationPeriodFrequency> cpf = 
////					paymentDates.getCalculationPeriodFrequency();
////
////	qlTimeUnitFactory qtuf = qlTimeUnitFactory();
////	qlCalendarFactory qcf = qlCalendarFactory();
////	qlBusinessDayConvention qbdc = qlBusinessDayConvention();
////
////	
////	QuantLib::Period period = qtuf.timeUnit(cpf->getNode());
////	QuantLib::Calendar calendar = qcf.calendar(paymentDates.getCalendar()->SValue());
////	QuantLib::BusinessDayConvention bdc = qbdc.businessDayConvention("FOLLOWING");
////	QuantLib::DateGeneration::Rule rule = QuantLib::DateGeneration::Rule::Backward;
////
////	Schedule schedule = Schedule(effectiveDate,
////		terminationDate,
////		period,
////		calendar,
////		bdc,
////		bdc,
////		rule,
////		false);
////
////	return schedule;
////
////}
//
//boost::shared_ptr<PricingEngine> qlCreditDefaultProductFactory::engine()
//{
//	TiXmlDocument document;
//	document.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	TiXmlNode* instrumentNode = document.FirstChild("pricing");
//
//	FpmlSerialized::Pricing serial_pricing = FpmlSerialized::Pricing(instrumentNode);
//	
//	Date referenceDate = serial_pricing.getEvaluationTime()->dateValue();
//	Settings::instance().evaluationDate() = referenceDate;
//
//	boost::shared_ptr<FpmlSerialized::PricingParameter> xml_pricingPara = serial_pricing.getPricingParameter();
//	boost::shared_ptr<FpmlSerialized::Method> xml_method = xml_pricingPara->getMethod();
//	boost::shared_ptr<FpmlSerialized::Monte> xml_monte = xml_method->getMonte();
//
//	boost::shared_ptr<FpmlSerialized::Standard_para> xml_standardPara = xml_pricingPara->getStandard_para();
//
//	qlYieldTermStructureFactory factory = qlYieldTermStructureFactory();
//
//	boost::shared_ptr<FpmlSerialized::DiscountCurve_para> xml_discount = xml_standardPara->getDiscountCurve_para();
//	boost::shared_ptr<YieldTermStructure> yieldTS = factory.yieldTSBoost(xml_discount->getYieldTermstructure());
//
//	qlProcessFactory qlpf = qlProcessFactory();
//
//	boost::shared_ptr<ProcessArrayWrapper> processArrWrapper = qlpf.getProcessArrWrapper();
//
//	this->buildqlProduct();
//
//	qlTermstructureFactory qltsf = qlTermstructureFactory();
//
//	this->defaultCurve_ = qltsf.jointDefaultTS();
//
//	boost::shared_ptr<PricingEngine> monteEngine(
//							new QuantLib::MonteEngine(this->pricer_,
//											processArrWrapper,
//											yieldTS,
//											1,//simulNum
//											1));
//
//	
//
//	//qlTermstructureFactory qtf = qlTermstructureFactory();
//	//this->de
//	//qlYieldTermStructureFactory qytf = qlYieldTermStructureFactory();
//
//	//Handle<DefaultProbabilityTermStructure> defaultCurve(qtf.jointDefaultTS(serial_rfc->getNode()));
//
//	//Real recoveryRate = serial_creditDefaultSwapPricing->getRecoveryRate()->DValue();
//	////FpmlSerialized::DiscountCurve<YieldTermStructure> serial_discountCurve = serial_creditDefaultSwapPricing->getDiscountCurve();
//
//	//boost::shared_ptr<FpmlSerialized::DiscountCurve> serial_discountCurve = serial_creditDefaultSwapPricing->getDiscountCurve();
//	//boost::shared_ptr<FpmlSerialized::YieldTermstructure> serial_curve = serial_discountCurve->getYieldTermstructure();
//	//const Handle<YieldTermStructure>& discountCurve = qytf.yieldTSHandle(serial_curve->getNode());
//
//	//std::cout << "No - PaymentDate - SuvivalProb - DefaultProb - DiscountFacot - CumDefProb " << std::endl;
//
//	//for(Size i =2 ;i<this->dates_.size(); ++i){
//	//	if(referenceDate < dates_[i] && i < dates_.size() )
//	//	{
//	//		std::cout << i << "  " << dates_[i] << "  " << defaultCurve->survivalProbability(this->dates_[i]) << 
//	//		"  " << defaultCurve->survivalProbability(this->dates_[i-1]) - defaultCurve->survivalProbability(this->dates_[i]) <<
//	//		"  " << discountCurve->discount(this->dates_[i]) << 
//	//		"  " << 1-defaultCurve->survivalProbability(this->dates_[i]) << 
//	//		std::endl;
//	//	}
//	//}
//
//	return monteEngine;
//}
//
//void qlCreditDefaultProductFactory::buildResultXml(std::map<std::string,boost::any> addedResult)
//{
//	std::vector<Date> _paymentDate = boost::any_cast<std::vector<Date>>(addedResult.find("SurvivalProb")->second);
//	std::vector<double> _survivalProb = boost::any_cast<std::vector<double>>(addedResult.find("SurvivalProb")->second);
//	std::vector<double> _defaultProb = boost::any_cast<std::vector<double>>(addedResult.find("DefaultProb")->second);
//	std::vector<double> _couponLeg = boost::any_cast<std::vector<double>>(addedResult.find("CouponLeg")->second);
//	std::vector<double> _defaultLeg = boost::any_cast<std::vector<double>>(addedResult.find("DefaultLeg")->second);
//	std::vector<double> _dicountFactor = boost::any_cast<std::vector<double>>(addedResult.find("DicountFactor")->second);
//
//	TiXmlDocument doc;  
// 
//	TiXmlElement * pricingResultNode = new TiXmlElement( "pricingResult" );  
//	doc.LinkEndChild( pricingResultNode );  
//
//	TiXmlElement * priceNode = new TiXmlElement( "price" );  
//	priceNode->LinkEndChild( new TiXmlText(  boost::lexical_cast<std::string>( static_cast<long>(notional_ * value_ / 10000) ) ) );  
//	pricingResultNode->LinkEndChild( priceNode );  
// 
//	TiXmlElement * unitPriceNode = new TiXmlElement( "unitPrice" );  
//	unitPriceNode->SetAttribute("unit", 10000 );
//	unitPriceNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr(value_) ));  
//	pricingResultNode->LinkEndChild( unitPriceNode ); 
//
//
//
//}
//
//
//}