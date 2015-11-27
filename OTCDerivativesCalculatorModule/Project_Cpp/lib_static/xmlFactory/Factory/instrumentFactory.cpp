#include "instrumentFactory.hpp"
#include <util\convertFunction.hpp>
#include <ql/indexes/indexmanager.hpp>
#include <Factory/Etc/all.hpp>

using namespace QuantLib;

namespace XmlFactory {

const std::string& InstrumentFactory::getKRCode()
{ 
	return this->krCode_;
}

const double InstrumentFactory::getPrice()
{ 
	return this->price_;
}

const double InstrumentFactory::getValue()
{ 
	return this->value_;
}

int InstrumentFactory::loadDocument()
{
	instDocument_.Parse(instInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
	paraDocument_.Parse(paraInfo_.c_str(), 0, TIXML_ENCODING_UTF8);
	historyDocument_.Parse(historyInfo_.c_str(), 0, TIXML_ENCODING_UTF8);

	return 0;

}

void InstrumentFactory::setInstrument(const boost::shared_ptr<FpmlSerialized::ProductInnerXml>& xml_productInnerXml)
{
	this->xml_productInnerXml_ = xml_productInnerXml;

	this->xml_instrument_ = this->xml_productInnerXml_->getInstrument();
	this->xml_pricing_ = this->xml_productInnerXml_->getPricing();
	this->xml_history_ = this->xml_productInnerXml_->getHisoryData();

	//boost::shared_ptr<FpmlSerialized::HisoryData> xml_historyData 
	//	= xml_productInnerXml_->getHisoryData();

	//Date referenceDate = xml_pricing.getEvaluationTime()->dateValue();

	//Settings::instance().evaluationDate() = referenceDate;

	// historyData -----------------------------------------------------------------------------------------

}

void InstrumentFactory::historyDataLoad()
{
	if ( !this->xml_history_->isMarketData() )
	{
		const std::vector<boost::shared_ptr<FpmlSerialized::MarketData>>& xml_marketData
			= this->xml_history_->getMarketData();

		for ( Size i=0 ; i<xml_marketData.size() ; i++)
		{
			const boost::shared_ptr<FpmlSerialized::DataValueInfo>& xml_dataValueInfo
				= xml_marketData[i]->getDataValueInfo();
			const std::string& krcode = xml_marketData[i]->getKrcode()->SValue();
			const std::vector<boost::shared_ptr<DataValue>>& xml_dataValue
				= xml_dataValueInfo->getDataValue();
		
			std::vector<Date> dates;
			std::vector<Real> values;

			for ( Size j=0 ;j<xml_dataValue.size(); j++)
			{
				dates.push_back(xml_dataValue[j]->getDate()->dateValue());
				values.push_back(xml_dataValue[j]->getValue()->DValue());
			}

			TimeSeries<Real> timeSeries = TimeSeries<Real>(dates.begin(),dates.end(),values.begin());

			IndexManager::instance().setHistory(krcode,timeSeries);
			IndexManager::instance().setPastDates(dates);
		}

	}
}

void InstrumentFactory::setInstrument(const std::string& instInfoStr,
								const std::string& paraInfoStr,
								const std::string& historyInfoStr)
{
	this->instInfo_ = instInfoStr;
	this->paraInfo_ = paraInfoStr;
	this->historyInfo_ = historyInfoStr;

	//document load
	this->loadDocument();

	TiXmlNode* instNode = this->instDocument_.FirstChildElement("instrument");
	this->xml_instrument_ = boost::shared_ptr<FpmlSerialized::Instrument>(
								new FpmlSerialized::Instrument(instNode));

	TiXmlNode* pricingNode = this->paraDocument_.FirstChildElement("pricing");
	this->xml_pricing_ = boost::shared_ptr<FpmlSerialized::Pricing>(
								new FpmlSerialized::Pricing(pricingNode));

	TiXmlNode* historyNode = this->historyDocument_.FirstChildElement("hisoryData");
	this->xml_history_ = boost::shared_ptr<FpmlSerialized::HisoryData>(
								new FpmlSerialized::HisoryData(historyNode));

	this->historyDataLoad();



	////TiXmlNode* instNode = instDocument_.FirstChild("instrument");
	////FpmlSerialized::Instrument xml_instrument = FpmlSerialized::Instrument(instNode);

	////TiXmlNode* paraNode = paraDocument_.FirstChild("pricing");
	////FpmlSerialized::Pricing xml_pricing = FpmlSerialized::Pricing(paraNode);

	//TiXmlNode* hisoryDataNode = historyDocument_.FirstChild("hisoryData");
	//FpmlSerialized::HisoryData xml_historyData = FpmlSerialized::HisoryData(hisoryDataNode);

	////Date referenceDate = xml_pricing.getEvaluationTime()->dateValue();

	////Settings::instance().evaluationDate() = referenceDate;

	//// historyData -----------------------------------------------------------------------------------------
	//if ( !xml_historyData.isMarketData() )
	//{
	//	const std::vector<boost::shared_ptr<FpmlSerialized::MarketData>>& xml_marketData
	//		= xml_historyData.getMarketData();

	//	for ( Size i=0 ; i<xml_marketData.size() ; i++)
	//	{
	//		const boost::shared_ptr<FpmlSerialized::DataValueInfo>& xml_dataValueInfo
	//			= xml_marketData[i]->getDataValueInfo();
	//		const std::string& krcode = xml_marketData[i]->getKrcode()->SValue();
	//		const std::vector<boost::shared_ptr<DataValue>>& xml_dataValue
	//			= xml_dataValueInfo->getDataValue();
	//	
	//		std::vector<Date> dates;
	//		std::vector<Real> values;

	//		for ( Size j=0 ;j<xml_dataValue.size(); j++)
	//		{
	//			dates.push_back(xml_dataValue[j]->getDate()->dateValue());
	//			values.push_back(xml_dataValue[j]->getValue()->DValue());
	//		}

	//		TimeSeries<Real> timeSeries = TimeSeries<Real>(dates.begin(),dates.end(),values.begin());

	//		IndexManager::instance().setHistory(krcode,timeSeries);
	//		IndexManager::instance().setPastDates(dates);
	//	}

	//}
	//const boost::shared_ptr<FpmlSerialized::Excel_interface>& xml_inst = xml_instrument.getExcel_interface();
	//const boost::shared_ptr<FpmlSerialized::Excel_parameter> xml_para = xml_pricing.getExcel_parameter();

	//qlInstrumentInfoFactory qlIIF = qlInstrumentInfoFactory();

	//this->InstFactory_ = qlIIF.instFactory(xml_inst,xml_para);

	// Insrument -------------------------------------------------------------------------------------------
	
	// calculation ------------------------------------------------------------------------------------------

	//this->value_ = this->instWithEnginePtr_->NPV();
	
}

void InstrumentFactory::buildResultXml()
{
	boost::shared_ptr<MyResultCalculator> resultCalc = this->engine_->resultCalc();
	Real simulNum = resultCalc->simulNum_;

	this->value_ = resultCalc->value();

	std::vector<std::string> _underlyingName = resultCalc->underlyingName_;
	std::vector<double> _underlyingValue = resultCalc->underlyingValue_;
	std::vector<double> _basePrice = resultCalc->basePrice_;
	std::vector<double> _volatility = resultCalc->volatility_;
	std::vector<double> _pertubation_h = resultCalc->S_h_;

	std::vector<double> _delta = resultCalc->delta();
	std::vector<double> _gamma = resultCalc->gamma();
	std::vector<double> _vega = resultCalc->vega();

	const std::vector<CashFlowResult>& _cf_results = resultCalc->cashFlowResults_;

	//std::vector<double> _step_h = boost::any_cast<std::vector<double>>(addedResult.find("step_h")->second);

	//std::vector<double> _underlyingValue = boost::any_cast<std::vector<double>>(addedResult.find("underlyingValue")->second);
	//
	//std::vector<double> _initialValues = boost::any_cast<std::vector<double>>(addedResult.find("initialValues")->second);
	//std::vector<double> _expectedRedem = boost::any_cast<std::vector<double>>(addedResult.find("expectedRedem")->second);

	TiXmlDocument doc;  
	//TiXmlElement* msg;
 //	TiXmlDeclaration* decl = new TiXmlDeclaration( "1.0", "", "" );  
	//doc.LinkEndChild( decl );  
 
	TiXmlElement * pricingResultNode = new TiXmlElement( "pricingResult" );  
	doc.LinkEndChild( pricingResultNode );  

		TiXmlElement * priceNode = new TiXmlElement( "price" );  
///		priceNode->LinkEndChild( new TiXmlText(  boost::lexical_cast<std::string>( static_cast<long>(value_) ) ) );  
		//this->price_ = static_cast<long>(value_ );
			priceNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr(value_) ));  
		pricingResultNode->LinkEndChild( priceNode );  
 
		TiXmlElement * calculationDateNode = new TiXmlElement( "calculationDate" );  
			calculationDateNode->LinkEndChild( new TiXmlText( ConvertFunction::dateToStr( Settings::instance().evaluationDate() ) ));  
		pricingResultNode->LinkEndChild( calculationDateNode );  

		TiXmlElement * calcValueNode = new TiXmlElement( "excel_valueResult" );  

		for ( Size i=0 ; i < resultCalc->valueResults_.size() ; ++i )
		{
			TiXmlElement * valueSideNode = new TiXmlElement("excel_valueSideResult");

				TiXmlElement * valueTypeNode = new TiXmlElement("type");
					valueTypeNode->LinkEndChild( new TiXmlText( resultCalc->valueResults_[i].resultSide_ ) );
				valueSideNode->LinkEndChild(valueTypeNode);

				TiXmlElement * valueCurrencyNode = new TiXmlElement("currency");
					valueCurrencyNode->LinkEndChild( new TiXmlText( resultCalc->valueResults_[i].currency_ ) );
				valueSideNode->LinkEndChild(valueCurrencyNode);

				TiXmlElement * valueDirtyNode = new TiXmlElement("dirty");
					valueDirtyNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( resultCalc->valueResults_[i].dirty() ) ) );
				valueSideNode->LinkEndChild(valueDirtyNode);

				TiXmlElement * valueCleanNode = new TiXmlElement("clean");
					valueCleanNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( resultCalc->valueResults_[i].clean() ) ) );
				valueSideNode->LinkEndChild(valueCleanNode);

				TiXmlElement * valueAccrualAmtNode = new TiXmlElement("accrualAmt");
					valueAccrualAmtNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( resultCalc->valueResults_[i].accrualAmt() ) ) );
				valueSideNode->LinkEndChild(valueAccrualAmtNode);

				TiXmlElement * valueOptionNode = new TiXmlElement("option");
					valueOptionNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( resultCalc->valueResults_[i].option() ) ) );
				valueSideNode->LinkEndChild(valueOptionNode);

			calcValueNode->LinkEndChild( valueSideNode );
				
		}
		
		pricingResultNode->LinkEndChild( calcValueNode );
 
		TiXmlElement * greekNode = new TiXmlElement( "excel_greekResult" );  

			for ( Size i=0 ;i < resultCalc->numAssets_ ;++i)
			{
				TiXmlElement * underNode = new TiXmlElement("excel_greekUnderlying");

					TiXmlElement * underNameNode = new TiXmlElement("underlyingName");
						underNameNode->LinkEndChild( new TiXmlText( _underlyingName[i] ) );
					underNode->LinkEndChild(underNameNode);

					TiXmlElement * underValueNode = new TiXmlElement("underlyingValue");
						underValueNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _underlyingValue[i]) ) );
					underNode->LinkEndChild(underValueNode);

					TiXmlElement * basePriceNode = new TiXmlElement("basePrice");
						basePriceNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _basePrice[i]) ) );
					underNode->LinkEndChild(basePriceNode);

					TiXmlElement * volatilityNode = new TiXmlElement("volatility");
						volatilityNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _volatility[i]) ) );
					underNode->LinkEndChild(volatilityNode);

					TiXmlElement * pertubation_hNode = new TiXmlElement("pertubation_h");
						pertubation_hNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _pertubation_h[i]) ) );
					underNode->LinkEndChild(pertubation_hNode);

					TiXmlElement * deltaNode = new TiXmlElement("delta");
						deltaNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _delta[i]) ) );
					underNode->LinkEndChild(deltaNode);

					TiXmlElement * gammaNode = new TiXmlElement("gamma");
						gammaNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _gamma[i]) ) );
					underNode->LinkEndChild(gammaNode);

					TiXmlElement * vegaNode = new TiXmlElement("vega");
						vegaNode->LinkEndChild( new TiXmlText(  ConvertFunction::doubleToStr( _vega[i]) ) );
					underNode->LinkEndChild(vegaNode);

				greekNode->LinkEndChild(underNode);
			}

			TiXmlElement * thetaNode = new TiXmlElement("theta");
				thetaNode->LinkEndChild( new TiXmlText( "100" ) );
			greekNode->LinkEndChild(thetaNode);

		pricingResultNode->LinkEndChild( greekNode );

		TiXmlElement * cashFlowsNode = new TiXmlElement( "excel_cashFlowsResult" );
		
		Size cashFlowNum = _cf_results.size();

		for ( Size i = 0 ; i < cashFlowNum ; i++ )
		{
			TiXmlElement * cashFlowNode = new TiXmlElement( "excel_cashFlowResult" );

				TiXmlElement * seqNode = new TiXmlElement("seq");
					seqNode->LinkEndChild( new TiXmlText( ConvertFunction::to_string2(_cf_results[i].seq_)  ) ) ;
				cashFlowNode->LinkEndChild(seqNode);
				
				TiXmlElement * eventDateNode = new TiXmlElement("eventDate");
					eventDateNode->LinkEndChild( new TiXmlText( ConvertFunction::dateToStr( _cf_results[i].eventDate_ ) ) ) ;
				cashFlowNode->LinkEndChild(eventDateNode);

				TiXmlElement * payoffDateNode = new TiXmlElement("payoffDate");
					payoffDateNode->LinkEndChild( new TiXmlText( ConvertFunction::dateToStr( _cf_results[i].payoffDate_ ) ) ) ;
				cashFlowNode->LinkEndChild(payoffDateNode);

				TiXmlElement * typeNode = new TiXmlElement("type");
					typeNode->LinkEndChild( new TiXmlText( _cf_results[i].type_ ) ) ;
				cashFlowNode->LinkEndChild(typeNode);

				TiXmlElement * currencyNode = new TiXmlElement("currency");
					currencyNode->LinkEndChild( new TiXmlText( _cf_results[i].currency_ ) ) ;
				cashFlowNode->LinkEndChild(currencyNode);

				TiXmlElement * cashFlowAmontNode = new TiXmlElement("cashFlow");
					cashFlowAmontNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _cf_results[i].cashFlow() ) ) ) ;
				cashFlowNode->LinkEndChild(cashFlowAmontNode);

				TiXmlElement * yieldNode = new TiXmlElement("yield");
					yieldNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _cf_results[i].yield() ) ) ) ;
				cashFlowNode->LinkEndChild(yieldNode);

				TiXmlElement * discountNode = new TiXmlElement("discount");
					discountNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _cf_results[i].discount() ) ) ) ;
				cashFlowNode->LinkEndChild(discountNode);

				TiXmlElement * exProbeNode = new TiXmlElement("exProb");
					exProbeNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _cf_results[i].exProb() ) ) ) ;
				cashFlowNode->LinkEndChild(exProbeNode);

				TiXmlElement * notionalPaymentNode = new TiXmlElement("notionalPayment");
					notionalPaymentNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _cf_results[i].notionalPayment() ) ) ) ;
				cashFlowNode->LinkEndChild(notionalPaymentNode);

				TiXmlElement * valueNode = new TiXmlElement("value");
					valueNode->LinkEndChild( new TiXmlText( ConvertFunction::doubleToStr( _cf_results[i].value() ) ) ) ;
				cashFlowNode->LinkEndChild(valueNode);

			cashFlowsNode->LinkEndChild( cashFlowNode );
		}

		pricingResultNode->LinkEndChild( cashFlowsNode );
	
		this->result_ = operator<<( this->result_ , *pricingResultNode);
 
	//std::cout << "_delta" << " : " << "_gamma" << " : " << "_vega" << std::endl;
	//

	//for(Size i=0;i<_delta.size();++i){
	//	std::cout << _delta[i] << " : " << _gamma[i] << " : " << _vega[i] << std::endl;
	//}

	//std::cout << "_sup" << " : " << "_sdown" << " : " << "_step_h" << std::endl;

	//for(Size i=0;i<_delta.size();++i){
	//	std::cout << _sup[i] << " : " << _sdown[i] << " : " << _step_h[i] << std::endl;
	//}

	//std::cout << "_volup" << " : " << "_voldown" << std::endl;

	//for(Size i=0;i<_delta.size();++i){
	//	std::cout << _volup[i] << " : " << _voldown[i] << std::endl;
	//}
	 
	//result ¾²±â
}
}
