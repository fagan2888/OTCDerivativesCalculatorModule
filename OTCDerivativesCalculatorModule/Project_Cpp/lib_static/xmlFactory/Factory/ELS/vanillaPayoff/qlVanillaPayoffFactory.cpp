//#include "qlVanillaPayoffFactory.hpp"
//#include <src/Engine/MonteCarlo/pricer/vanillaPricer.hpp>
//
//#include <src/Engine/MonteCarlo/pricer/event/simpleOption/all.hpp>
//#include <src/Engine/MonteCarlo/pricer/event/compositeSumOptionETI.hpp>
//#include <src/Engine/MonteCarlo/referenceCalculation/maximumReturnCal.hpp>
//
//using namespace QuantLib;
//
//namespace XmlFactory {
//
//qlVanillaPayoffFactory::qlVanillaPayoffFactory()
//{
//
//}
//
//void qlVanillaPayoffFactory::calculate(const std::string& instInfoStr,
//				const std::string& paraInfoStr)
//{
//	this->instInfo_ = instInfoStr;
//	this->paraInfo_ = paraInfoStr;
//
//	this->factoryVanilla();
//
//	value_ = inst_->NPV();
//
//}
//
//boost::shared_ptr<PricingEngine> qlVanillaPayoffFactory::engine(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoff)
//{
//	TiXmlDocument document;
//	document.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	TiXmlNode* pricingNode = document.FirstChildElement("pricing");
//	FpmlSerialized::Pricing xml_pricing = FpmlSerialized::Pricing(pricingNode);
//
//	Date referenceDate = xml_pricing.getEvaluationTime()->dateValue();
//	Settings::instance().evaluationDate() = referenceDate ;
//
//	boost::shared_ptr<FpmlSerialized::PricingParameter> xml_pricingPara = xml_pricing.getPricingParameter();
//	boost::shared_ptr<FpmlSerialized::Method> xml_method = xml_pricingPara->getMethod();
//	boost::shared_ptr<FpmlSerialized::Monte> xml_monte = xml_method->getMonte();
//
//	boost::shared_ptr<FpmlSerialized::Standard_para> xml_standardPara = xml_pricingPara->getStandard_para();
//
//	Size simulNum = xml_monte->getSimulationNum()->IValue();
//
//	boost::shared_ptr<FpmlSerialized::UnderlyingInfo_para> xml_underyingInfopara = xml_standardPara->getUnderlyingInfo_para();
//
//	qlProcessFactory process_factory = qlProcessFactory();
//	process_factory.setProcessCode(this->underListCode_);
//	process_factory.makeProcess(xml_underyingInfopara);
//
//	boost::shared_ptr<StochasticProcessArray> gbmProcess 
//		= process_factory.getProcessArr();
//
//	qlYieldTermStructureFactory factory = qlYieldTermStructureFactory();
//
//	//Handle<YieldTermStructure> yieldCurve = factory.yieldTSHandle(pricingParameterNode);
//	//boost::shared_ptr<YieldTermStructure> yieldTS = boost::shared_ptr<YieldTermStructure>(
//	//				new FlatForward(referenceDate,discount,Actual365Fixed()));
//	boost::shared_ptr<FpmlSerialized::DiscountCurve_para> xml_discount = xml_standardPara->getDiscountCurve_para();
//
//	boost::shared_ptr<YieldTermStructure> yieldTS = factory.yieldTSBoost(xml_discount->getYieldTermstructure());
//	
//	this->discountCurve_ = yieldTS;
//
//	Handle<YieldTermStructure> yieldCurve = Handle<YieldTermStructure>(yieldTS);
//		
//	this->pricer(xml_payoff);
//
//	boost::shared_ptr<PricingEngine> monteEngine(
//								new MonteEngine(pricer_,
//												gbmProcess,
//												yieldTS,
//												simulNum,//simulNum
//												1));
//
//
//	return monteEngine;
//}
//
//void qlVanillaPayoffFactory::pricer(boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoffInfo)
//{
//	boost::shared_ptr<FpmlSerialized::VanillaPayoff> xml_vanillaPayoff = xml_payoffInfo->getVanillaPayoff();
//
//	boost::shared_ptr<FpmlSerialized::CompositeSumOption> xml_compositeSumOption = xml_vanillaPayoff->getCompositeSumOption();
//
//	Date fixingDate = xml_compositeSumOption->getFixingDate()->dateValue();
//	Date payoffDate = xml_compositeSumOption->getPayoffDate()->dateValue();
//
//	std::vector<boost::shared_ptr<EventTriggerInfo>> standOptionList;
//	
//	std::vector< boost::shared_ptr<FpmlSerialized::StandardOption> > xml_standOptionList = xml_compositeSumOption->getStandardOption();
//
//	for ( Size i=0 ; i< xml_standOptionList.size() ; i++ )
//	{
//		 standOptionList.push_back( this->standardOption(xml_standOptionList[i]) );
//	}
//
//	//boost::shared_ptr<FpmlSerialized::ReferenceCalculation> xml_referenceCal = xml_vanillaPayoff->getReferenceCal();
//
//	//boost::shared_ptr<ReferenceCalculation> referenceCal = this->getReferenceCal(
//
//	boost::shared_ptr<QuantLib::ReferenceCalculation> referenceCal =
//		boost::shared_ptr<QuantLib::ReferenceCalculation>( new QuantLib::MaximumReturnCal(fixingDate) );
//
//	boost::shared_ptr<EventTriggerInfo> compositeSumOption = 
//			boost::shared_ptr<EventTriggerInfo>( new CompositeSumOptionETI(fixingDate,
//																		   payoffDate,
//																		   referenceCal,
//																		   standOptionList) );
//
//	this->pricer_ = boost::shared_ptr<VanillaPricer>(
//			new VanillaPricer(compositeSumOption,this->discountCurve_ ));
//
//}
//
//void qlVanillaPayoffFactory::factoryVanilla()
//{
//	TiXmlDocument document;
//	document.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
//
//	TiXmlNode* instNode = document.FirstChild("instrument");
//
//	FpmlSerialized::Instrument xml_instrument = FpmlSerialized::Instrument(instNode);
//	//boost::shared_ptr<FpmlSerialized::InstPositionInfo> xml_positionInfo = xml_instrument.getInstPositionInfo();
//	//this->krCode_ = xml_positionInfo->getKrCode()->SValue();
//
//	boost::shared_ptr<FpmlSerialized::InstrumentInfo> xml_instrumentInfo = xml_instrument.getInstrumentInfo();
//
//	boost::shared_ptr<FpmlSerialized::StandardInstrument> xml_standardInst = xml_instrumentInfo->getStandardInstrument();
//
//	DayCounter daycounter = Actual365Fixed();
//	Calendar calendar = SouthKorea(); // ?
//
//	boost::shared_ptr<FpmlSerialized::IssueInformation> xml_issueInfo = xml_standardInst->getIssueInformation();
//	boost::shared_ptr<FpmlSerialized::NoteInfo> xml_noteInfo = xml_issueInfo->getNoteInfo();
//	//boost::shared_ptr<FpmlSerialized::OptionInfo> xml_noteInfo = xml_issueInfo->getop NoteInfo();
//
//	//Date tradeDate = xml_noteInfo->getTradeDate()->dateValue();
//	Date effectiveDate = xml_noteInfo->getEffectiveDate()->dateValue();
//	Date maturityDate = xml_noteInfo->getMaturityDate()->dateValue();
//	notional_ = xml_noteInfo->getNotional()->DValue();
//
//	//Size premium = strToSize(infoNode->FirstChildElement("premium")->GetText());
//
//	boost::shared_ptr<FpmlSerialized::UnderlyingInformation> xml_underlyingInfo = xml_standardInst->getUnderlyingInformation();
//
//	boost::shared_ptr<FpmlSerialized::IndexUnderInfo> xml_indexUnderInfo =  xml_underlyingInfo->getIndexUnderInfo();
//
//	std::vector<boost::shared_ptr<FpmlSerialized::Index>> xml_indexList = xml_indexUnderInfo->getIndex();
//
//	for(Size i=0 ; i < xml_indexList.size() ; ++i)
//	{
//		double value = 0.0;
//		value = xml_indexList[i]->getStockIndex()->getBasePrice()->DValue();
//		underListCode_.push_back(xml_indexList[i]->getStockIndex()->getKrCode()->SValue());
//		basePrices_.push_back(value);
//	}
//
//	inst_ = boost::shared_ptr<NoteInst>( new NoteInst(10000.0,
//													effectiveDate,
//													maturityDate,
//													daycounter,
//													calendar));
//
//	
//	// --------------------------------- Payoff ---------------------------------------------
//
//	boost::shared_ptr<FpmlSerialized::PayoffInfo> xml_payoff = xml_standardInst->getPayoffInfo();
//
//	boost::shared_ptr<PricingEngine> elsEngine = engine(xml_payoff);
//
//
//
//	//std::cout << "Start" << std::endl;
//	inst_->setPricingEngine(elsEngine);
//	//std::cout << "Eu price                    : " << els100.NPV() << std::endl;
//
//	//std::cout << "Calculation End" << std::endl;
//}
//
//void qlVanillaPayoffFactory::buildResultXml(std::map<std::string,boost::any> addedResult)
//{
//
//}
//
//boost::shared_ptr<EventTriggerInfo> qlVanillaPayoffFactory::standardOption(const boost::shared_ptr<FpmlSerialized::StandardOption>& xml_standardOption)
//{
//	boost::shared_ptr<EventTriggerInfo> option;
//
//	std::string standOptionType = xml_standardOption->getType()->SValue();;
//	double unit = xml_standardOption->getUnit()->DValue();
//
//	Date fixingDate = Date(24,Apr,2015);
//	Date payoffDate = Date(24,Apr,2015);
//
//	if ( standOptionType == "singleBarrierOption" )
//	{
//		//const boost::shared_ptr<SingleBarrierOption> xml_vanillaCall = xml_standardOption->getVanillaCall();
//
//		////option = boost::shared_ptr<EventTriggerInfo>( new BarrierETI() );
//
//		//double rebate = 
//
//		//const boost::shared_ptr<VanillaCall> xml_vanillaCall = xml_standardOption->getVanillaCall();
//
//		//double unit = 1.0;
//		double value = 0.01;
//
//		option = boost::shared_ptr<EventTriggerInfo>( 
//				new ConstantPayoffETI(unit,
//								      payoffDate,
//								      value) );
//
//	}
//	else if ( standOptionType == "vanillaCall" )
//	{
//		const boost::shared_ptr<VanillaCall> xml_vanillaCall = xml_standardOption->getVanillaCall();
//
//		double strike = xml_vanillaCall->getStrike()->DValue();
//		
//		option = boost::shared_ptr<EventTriggerInfo>( 
//				new VanillaCallETI(unit,
//								fixingDate,
//								payoffDate,
//								strike) );
//	}
//	else if ( standOptionType == "vanillaPut" )
//	{
//		const boost::shared_ptr<VanillaPut> xml_vanillaPut = xml_standardOption->getVanillaPut();
//
//		double strike = xml_vanillaPut->getStrike()->DValue();
//
//		option = boost::shared_ptr<EventTriggerInfo>( 
//				new VanillaPutETI(unit,
//								fixingDate,
//								payoffDate,
//								strike) );
//	}
//	else
//	{
//
//	}
//
//	return option;
//}
//
//}
//
