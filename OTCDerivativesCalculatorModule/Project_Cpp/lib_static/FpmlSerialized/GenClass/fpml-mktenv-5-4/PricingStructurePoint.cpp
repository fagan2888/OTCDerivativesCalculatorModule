// PricingStructurePoint.cpp 
#include "PricingStructurePoint.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingStructurePoint::PricingStructurePoint(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //coordinateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coordinateNode = xmlNode->FirstChildElement("coordinate");

   if(coordinateNode){coordinateIsNull_ = false;}
   else{coordinateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coordinateNode , address : " << coordinateNode << std::endl;
   #endif
   if(coordinateNode)
   {
      if(coordinateNode->Attribute("href") || coordinateNode->Attribute("id"))
      {
          if(coordinateNode->Attribute("id"))
          {
             coordinateIDRef_ = coordinateNode->Attribute("id");
             coordinate_ = boost::shared_ptr<PricingDataPointCoordinate>(new PricingDataPointCoordinate(coordinateNode));
             coordinate_->setID(coordinateIDRef_);
             IDManager::instance().setID(coordinateIDRef_,coordinate_);
          }
          else if(coordinateNode->Attribute("href")) { coordinateIDRef_ = coordinateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coordinate_ = boost::shared_ptr<PricingDataPointCoordinate>(new PricingDataPointCoordinate(coordinateNode));}
   }

   //coordinateReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* coordinateReferenceNode = xmlNode->FirstChildElement("coordinateReference");

   if(coordinateReferenceNode){coordinateReferenceIsNull_ = false;}
   else{coordinateReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- coordinateReferenceNode , address : " << coordinateReferenceNode << std::endl;
   #endif
   if(coordinateReferenceNode)
   {
      if(coordinateReferenceNode->Attribute("href") || coordinateReferenceNode->Attribute("id"))
      {
          if(coordinateReferenceNode->Attribute("id"))
          {
             coordinateReferenceIDRef_ = coordinateReferenceNode->Attribute("id");
             coordinateReference_ = boost::shared_ptr<PricingDataPointCoordinateReference>(new PricingDataPointCoordinateReference(coordinateReferenceNode));
             coordinateReference_->setID(coordinateReferenceIDRef_);
             IDManager::instance().setID(coordinateReferenceIDRef_,coordinateReference_);
          }
          else if(coordinateReferenceNode->Attribute("href")) { coordinateReferenceIDRef_ = coordinateReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { coordinateReference_ = boost::shared_ptr<PricingDataPointCoordinateReference>(new PricingDataPointCoordinateReference(coordinateReferenceNode));}
   }

   //underlyingAssetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingAssetNode = xmlNode->FirstChildElement("underlyingAsset");

   if(underlyingAssetNode){underlyingAssetIsNull_ = false;}
   else{underlyingAssetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingAssetNode , address : " << underlyingAssetNode << std::endl;
   #endif
   if(underlyingAssetNode)
   {
      if(underlyingAssetNode->Attribute("href") || underlyingAssetNode->Attribute("id"))
      {
          if(underlyingAssetNode->Attribute("id"))
          {
             underlyingAssetIDRef_ = underlyingAssetNode->Attribute("id");
             underlyingAsset_ = boost::shared_ptr<Asset>(new Asset(underlyingAssetNode));
             underlyingAsset_->setID(underlyingAssetIDRef_);
             IDManager::instance().setID(underlyingAssetIDRef_,underlyingAsset_);
          }
          else if(underlyingAssetNode->Attribute("href")) { underlyingAssetIDRef_ = underlyingAssetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyingAsset_ = boost::shared_ptr<Asset>(new Asset(underlyingAssetNode));}
   }

   //basketNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketNode = xmlNode->FirstChildElement("basket");

   if(basketNode){basketIsNull_ = false;}
   else{basketIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketNode , address : " << basketNode << std::endl;
   #endif
   if(basketNode)
   {
      if(basketNode->Attribute("href") || basketNode->Attribute("id"))
      {
          if(basketNode->Attribute("id"))
          {
             basketIDRef_ = basketNode->Attribute("id");
             basket_ = boost::shared_ptr<Basket>(new Basket(basketNode));
             basket_->setID(basketIDRef_);
             IDManager::instance().setID(basketIDRef_,basket_);
          }
          else if(basketNode->Attribute("href")) { basketIDRef_ = basketNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basket_ = boost::shared_ptr<Basket>(new Basket(basketNode));}
   }

   //bondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bondNode = xmlNode->FirstChildElement("bond");

   if(bondNode){bondIsNull_ = false;}
   else{bondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bondNode , address : " << bondNode << std::endl;
   #endif
   if(bondNode)
   {
      if(bondNode->Attribute("href") || bondNode->Attribute("id"))
      {
          if(bondNode->Attribute("id"))
          {
             bondIDRef_ = bondNode->Attribute("id");
             bond_ = boost::shared_ptr<Bond>(new Bond(bondNode));
             bond_->setID(bondIDRef_);
             IDManager::instance().setID(bondIDRef_,bond_);
          }
          else if(bondNode->Attribute("href")) { bondIDRef_ = bondNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bond_ = boost::shared_ptr<Bond>(new Bond(bondNode));}
   }

   //cashNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashNode = xmlNode->FirstChildElement("cash");

   if(cashNode){cashIsNull_ = false;}
   else{cashIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashNode , address : " << cashNode << std::endl;
   #endif
   if(cashNode)
   {
      if(cashNode->Attribute("href") || cashNode->Attribute("id"))
      {
          if(cashNode->Attribute("id"))
          {
             cashIDRef_ = cashNode->Attribute("id");
             cash_ = boost::shared_ptr<Cash>(new Cash(cashNode));
             cash_->setID(cashIDRef_);
             IDManager::instance().setID(cashIDRef_,cash_);
          }
          else if(cashNode->Attribute("href")) { cashIDRef_ = cashNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cash_ = boost::shared_ptr<Cash>(new Cash(cashNode));}
   }

   //commodityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityNode = xmlNode->FirstChildElement("commodity");

   if(commodityNode){commodityIsNull_ = false;}
   else{commodityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityNode , address : " << commodityNode << std::endl;
   #endif
   if(commodityNode)
   {
      if(commodityNode->Attribute("href") || commodityNode->Attribute("id"))
      {
          if(commodityNode->Attribute("id"))
          {
             commodityIDRef_ = commodityNode->Attribute("id");
             commodity_ = boost::shared_ptr<Commodity>(new Commodity(commodityNode));
             commodity_->setID(commodityIDRef_);
             IDManager::instance().setID(commodityIDRef_,commodity_);
          }
          else if(commodityNode->Attribute("href")) { commodityIDRef_ = commodityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodity_ = boost::shared_ptr<Commodity>(new Commodity(commodityNode));}
   }

   //convertibleBondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* convertibleBondNode = xmlNode->FirstChildElement("convertibleBond");

   if(convertibleBondNode){convertibleBondIsNull_ = false;}
   else{convertibleBondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- convertibleBondNode , address : " << convertibleBondNode << std::endl;
   #endif
   if(convertibleBondNode)
   {
      if(convertibleBondNode->Attribute("href") || convertibleBondNode->Attribute("id"))
      {
          if(convertibleBondNode->Attribute("id"))
          {
             convertibleBondIDRef_ = convertibleBondNode->Attribute("id");
             convertibleBond_ = boost::shared_ptr<ConvertibleBond>(new ConvertibleBond(convertibleBondNode));
             convertibleBond_->setID(convertibleBondIDRef_);
             IDManager::instance().setID(convertibleBondIDRef_,convertibleBond_);
          }
          else if(convertibleBondNode->Attribute("href")) { convertibleBondIDRef_ = convertibleBondNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { convertibleBond_ = boost::shared_ptr<ConvertibleBond>(new ConvertibleBond(convertibleBondNode));}
   }

   //equityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityNode = xmlNode->FirstChildElement("equity");

   if(equityNode){equityIsNull_ = false;}
   else{equityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityNode , address : " << equityNode << std::endl;
   #endif
   if(equityNode)
   {
      if(equityNode->Attribute("href") || equityNode->Attribute("id"))
      {
          if(equityNode->Attribute("id"))
          {
             equityIDRef_ = equityNode->Attribute("id");
             equity_ = boost::shared_ptr<EquityAsset>(new EquityAsset(equityNode));
             equity_->setID(equityIDRef_);
             IDManager::instance().setID(equityIDRef_,equity_);
          }
          else if(equityNode->Attribute("href")) { equityIDRef_ = equityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equity_ = boost::shared_ptr<EquityAsset>(new EquityAsset(equityNode));}
   }

   //exchangeTradedFundNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeTradedFundNode = xmlNode->FirstChildElement("exchangeTradedFund");

   if(exchangeTradedFundNode){exchangeTradedFundIsNull_ = false;}
   else{exchangeTradedFundIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeTradedFundNode , address : " << exchangeTradedFundNode << std::endl;
   #endif
   if(exchangeTradedFundNode)
   {
      if(exchangeTradedFundNode->Attribute("href") || exchangeTradedFundNode->Attribute("id"))
      {
          if(exchangeTradedFundNode->Attribute("id"))
          {
             exchangeTradedFundIDRef_ = exchangeTradedFundNode->Attribute("id");
             exchangeTradedFund_ = boost::shared_ptr<ExchangeTradedFund>(new ExchangeTradedFund(exchangeTradedFundNode));
             exchangeTradedFund_->setID(exchangeTradedFundIDRef_);
             IDManager::instance().setID(exchangeTradedFundIDRef_,exchangeTradedFund_);
          }
          else if(exchangeTradedFundNode->Attribute("href")) { exchangeTradedFundIDRef_ = exchangeTradedFundNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeTradedFund_ = boost::shared_ptr<ExchangeTradedFund>(new ExchangeTradedFund(exchangeTradedFundNode));}
   }

   //futureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* futureNode = xmlNode->FirstChildElement("future");

   if(futureNode){futureIsNull_ = false;}
   else{futureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- futureNode , address : " << futureNode << std::endl;
   #endif
   if(futureNode)
   {
      if(futureNode->Attribute("href") || futureNode->Attribute("id"))
      {
          if(futureNode->Attribute("id"))
          {
             futureIDRef_ = futureNode->Attribute("id");
             future_ = boost::shared_ptr<Future>(new Future(futureNode));
             future_->setID(futureIDRef_);
             IDManager::instance().setID(futureIDRef_,future_);
          }
          else if(futureNode->Attribute("href")) { futureIDRef_ = futureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { future_ = boost::shared_ptr<Future>(new Future(futureNode));}
   }

   //indexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexNode = xmlNode->FirstChildElement("index");

   if(indexNode){indexIsNull_ = false;}
   else{indexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexNode , address : " << indexNode << std::endl;
   #endif
   if(indexNode)
   {
      if(indexNode->Attribute("href") || indexNode->Attribute("id"))
      {
          if(indexNode->Attribute("id"))
          {
             indexIDRef_ = indexNode->Attribute("id");
             index_ = boost::shared_ptr<Index>(new Index(indexNode));
             index_->setID(indexIDRef_);
             IDManager::instance().setID(indexIDRef_,index_);
          }
          else if(indexNode->Attribute("href")) { indexIDRef_ = indexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { index_ = boost::shared_ptr<Index>(new Index(indexNode));}
   }

   //loanNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* loanNode = xmlNode->FirstChildElement("loan");

   if(loanNode){loanIsNull_ = false;}
   else{loanIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- loanNode , address : " << loanNode << std::endl;
   #endif
   if(loanNode)
   {
      if(loanNode->Attribute("href") || loanNode->Attribute("id"))
      {
          if(loanNode->Attribute("id"))
          {
             loanIDRef_ = loanNode->Attribute("id");
             loan_ = boost::shared_ptr<Loan>(new Loan(loanNode));
             loan_->setID(loanIDRef_);
             IDManager::instance().setID(loanIDRef_,loan_);
          }
          else if(loanNode->Attribute("href")) { loanIDRef_ = loanNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { loan_ = boost::shared_ptr<Loan>(new Loan(loanNode));}
   }

   //mortgageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mortgageNode = xmlNode->FirstChildElement("mortgage");

   if(mortgageNode){mortgageIsNull_ = false;}
   else{mortgageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mortgageNode , address : " << mortgageNode << std::endl;
   #endif
   if(mortgageNode)
   {
      if(mortgageNode->Attribute("href") || mortgageNode->Attribute("id"))
      {
          if(mortgageNode->Attribute("id"))
          {
             mortgageIDRef_ = mortgageNode->Attribute("id");
             mortgage_ = boost::shared_ptr<Mortgage>(new Mortgage(mortgageNode));
             mortgage_->setID(mortgageIDRef_);
             IDManager::instance().setID(mortgageIDRef_,mortgage_);
          }
          else if(mortgageNode->Attribute("href")) { mortgageIDRef_ = mortgageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mortgage_ = boost::shared_ptr<Mortgage>(new Mortgage(mortgageNode));}
   }

   //mutualFundNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mutualFundNode = xmlNode->FirstChildElement("mutualFund");

   if(mutualFundNode){mutualFundIsNull_ = false;}
   else{mutualFundIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mutualFundNode , address : " << mutualFundNode << std::endl;
   #endif
   if(mutualFundNode)
   {
      if(mutualFundNode->Attribute("href") || mutualFundNode->Attribute("id"))
      {
          if(mutualFundNode->Attribute("id"))
          {
             mutualFundIDRef_ = mutualFundNode->Attribute("id");
             mutualFund_ = boost::shared_ptr<MutualFund>(new MutualFund(mutualFundNode));
             mutualFund_->setID(mutualFundIDRef_);
             IDManager::instance().setID(mutualFundIDRef_,mutualFund_);
          }
          else if(mutualFundNode->Attribute("href")) { mutualFundIDRef_ = mutualFundNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mutualFund_ = boost::shared_ptr<MutualFund>(new MutualFund(mutualFundNode));}
   }

   //underlyingAssetReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underlyingAssetReferenceNode = xmlNode->FirstChildElement("underlyingAssetReference");

   if(underlyingAssetReferenceNode){underlyingAssetReferenceIsNull_ = false;}
   else{underlyingAssetReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underlyingAssetReferenceNode , address : " << underlyingAssetReferenceNode << std::endl;
   #endif
   if(underlyingAssetReferenceNode)
   {
      if(underlyingAssetReferenceNode->Attribute("href") || underlyingAssetReferenceNode->Attribute("id"))
      {
          if(underlyingAssetReferenceNode->Attribute("id"))
          {
             underlyingAssetReferenceIDRef_ = underlyingAssetReferenceNode->Attribute("id");
             underlyingAssetReference_ = boost::shared_ptr<AssetReference>(new AssetReference(underlyingAssetReferenceNode));
             underlyingAssetReference_->setID(underlyingAssetReferenceIDRef_);
             IDManager::instance().setID(underlyingAssetReferenceIDRef_,underlyingAssetReference_);
          }
          else if(underlyingAssetReferenceNode->Attribute("href")) { underlyingAssetReferenceIDRef_ = underlyingAssetReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { underlyingAssetReference_ = boost::shared_ptr<AssetReference>(new AssetReference(underlyingAssetReferenceNode));}
   }

   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
      if(valueNode->Attribute("href") || valueNode->Attribute("id"))
      {
          if(valueNode->Attribute("id"))
          {
             valueIDRef_ = valueNode->Attribute("id");
             value_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(valueNode));
             value_->setID(valueIDRef_);
             IDManager::instance().setID(valueIDRef_,value_);
          }
          else if(valueNode->Attribute("href")) { valueIDRef_ = valueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { value_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(valueNode));}
   }

   //measureTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* measureTypeNode = xmlNode->FirstChildElement("measureType");

   if(measureTypeNode){measureTypeIsNull_ = false;}
   else{measureTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- measureTypeNode , address : " << measureTypeNode << std::endl;
   #endif
   if(measureTypeNode)
   {
      if(measureTypeNode->Attribute("href") || measureTypeNode->Attribute("id"))
      {
          if(measureTypeNode->Attribute("id"))
          {
             measureTypeIDRef_ = measureTypeNode->Attribute("id");
             measureType_ = boost::shared_ptr<AssetMeasureType>(new AssetMeasureType(measureTypeNode));
             measureType_->setID(measureTypeIDRef_);
             IDManager::instance().setID(measureTypeIDRef_,measureType_);
          }
          else if(measureTypeNode->Attribute("href")) { measureTypeIDRef_ = measureTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { measureType_ = boost::shared_ptr<AssetMeasureType>(new AssetMeasureType(measureTypeNode));}
   }

   //quoteUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quoteUnitsNode = xmlNode->FirstChildElement("quoteUnits");

   if(quoteUnitsNode){quoteUnitsIsNull_ = false;}
   else{quoteUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quoteUnitsNode , address : " << quoteUnitsNode << std::endl;
   #endif
   if(quoteUnitsNode)
   {
      if(quoteUnitsNode->Attribute("href") || quoteUnitsNode->Attribute("id"))
      {
          if(quoteUnitsNode->Attribute("id"))
          {
             quoteUnitsIDRef_ = quoteUnitsNode->Attribute("id");
             quoteUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(quoteUnitsNode));
             quoteUnits_->setID(quoteUnitsIDRef_);
             IDManager::instance().setID(quoteUnitsIDRef_,quoteUnits_);
          }
          else if(quoteUnitsNode->Attribute("href")) { quoteUnitsIDRef_ = quoteUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quoteUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(quoteUnitsNode));}
   }

   //sideNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sideNode = xmlNode->FirstChildElement("side");

   if(sideNode){sideIsNull_ = false;}
   else{sideIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sideNode , address : " << sideNode << std::endl;
   #endif
   if(sideNode)
   {
      if(sideNode->Attribute("href") || sideNode->Attribute("id"))
      {
          if(sideNode->Attribute("id"))
          {
             sideIDRef_ = sideNode->Attribute("id");
             side_ = boost::shared_ptr<QuotationSideEnum>(new QuotationSideEnum(sideNode));
             side_->setID(sideIDRef_);
             IDManager::instance().setID(sideIDRef_,side_);
          }
          else if(sideNode->Attribute("href")) { sideIDRef_ = sideNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { side_ = boost::shared_ptr<QuotationSideEnum>(new QuotationSideEnum(sideNode));}
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
      if(currencyNode->Attribute("href") || currencyNode->Attribute("id"))
      {
          if(currencyNode->Attribute("id"))
          {
             currencyIDRef_ = currencyNode->Attribute("id");
             currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));}
   }

   //currencyTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyTypeNode = xmlNode->FirstChildElement("currencyType");

   if(currencyTypeNode){currencyTypeIsNull_ = false;}
   else{currencyTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyTypeNode , address : " << currencyTypeNode << std::endl;
   #endif
   if(currencyTypeNode)
   {
      if(currencyTypeNode->Attribute("href") || currencyTypeNode->Attribute("id"))
      {
          if(currencyTypeNode->Attribute("id"))
          {
             currencyTypeIDRef_ = currencyTypeNode->Attribute("id");
             currencyType_ = boost::shared_ptr<ReportingCurrencyType>(new ReportingCurrencyType(currencyTypeNode));
             currencyType_->setID(currencyTypeIDRef_);
             IDManager::instance().setID(currencyTypeIDRef_,currencyType_);
          }
          else if(currencyTypeNode->Attribute("href")) { currencyTypeIDRef_ = currencyTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currencyType_ = boost::shared_ptr<ReportingCurrencyType>(new ReportingCurrencyType(currencyTypeNode));}
   }

   //timingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timingNode = xmlNode->FirstChildElement("timing");

   if(timingNode){timingIsNull_ = false;}
   else{timingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timingNode , address : " << timingNode << std::endl;
   #endif
   if(timingNode)
   {
      if(timingNode->Attribute("href") || timingNode->Attribute("id"))
      {
          if(timingNode->Attribute("id"))
          {
             timingIDRef_ = timingNode->Attribute("id");
             timing_ = boost::shared_ptr<QuoteTiming>(new QuoteTiming(timingNode));
             timing_->setID(timingIDRef_);
             IDManager::instance().setID(timingIDRef_,timing_);
          }
          else if(timingNode->Attribute("href")) { timingIDRef_ = timingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { timing_ = boost::shared_ptr<QuoteTiming>(new QuoteTiming(timingNode));}
   }

   //businessCenterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCenterNode = xmlNode->FirstChildElement("businessCenter");

   if(businessCenterNode){businessCenterIsNull_ = false;}
   else{businessCenterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCenterNode , address : " << businessCenterNode << std::endl;
   #endif
   if(businessCenterNode)
   {
      if(businessCenterNode->Attribute("href") || businessCenterNode->Attribute("id"))
      {
          if(businessCenterNode->Attribute("id"))
          {
             businessCenterIDRef_ = businessCenterNode->Attribute("id");
             businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));
             businessCenter_->setID(businessCenterIDRef_);
             IDManager::instance().setID(businessCenterIDRef_,businessCenter_);
          }
          else if(businessCenterNode->Attribute("href")) { businessCenterIDRef_ = businessCenterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));}
   }

   //exchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeIdNode = xmlNode->FirstChildElement("exchangeId");

   if(exchangeIdNode){exchangeIdIsNull_ = false;}
   else{exchangeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeIdNode , address : " << exchangeIdNode << std::endl;
   #endif
   if(exchangeIdNode)
   {
      if(exchangeIdNode->Attribute("href") || exchangeIdNode->Attribute("id"))
      {
          if(exchangeIdNode->Attribute("id"))
          {
             exchangeIdIDRef_ = exchangeIdNode->Attribute("id");
             exchangeId_ = boost::shared_ptr<ExchangeId>(new ExchangeId(exchangeIdNode));
             exchangeId_->setID(exchangeIdIDRef_);
             IDManager::instance().setID(exchangeIdIDRef_,exchangeId_);
          }
          else if(exchangeIdNode->Attribute("href")) { exchangeIdIDRef_ = exchangeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeId_ = boost::shared_ptr<ExchangeId>(new ExchangeId(exchangeIdNode));}
   }

   //informationSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* informationSourceNode = xmlNode->FirstChildElement("informationSource");

   if(informationSourceNode){informationSourceIsNull_ = false;}
   else{informationSourceIsNull_ = true;}

   if(informationSourceNode)
   {
      for(informationSourceNode; informationSourceNode; informationSourceNode = informationSourceNode->NextSiblingElement("informationSource")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
          #endif
          if(informationSourceNode->Attribute("href") || informationSourceNode->Attribute("id"))
          {
              if(informationSourceNode->Attribute("id"))
              {
                  informationSourceIDRef_ = informationSourceNode->Attribute("id");
                  informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));
                  informationSource_.back()->setID(informationSourceIDRef_);
                  IDManager::instance().setID(informationSourceIDRef_, informationSource_.back());
              }
              else if(informationSourceNode->Attribute("href")) { informationSourceIDRef_ = informationSourceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { informationSource_.push_back(boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
       #endif
   }

   //pricingModelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingModelNode = xmlNode->FirstChildElement("pricingModel");

   if(pricingModelNode){pricingModelIsNull_ = false;}
   else{pricingModelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingModelNode , address : " << pricingModelNode << std::endl;
   #endif
   if(pricingModelNode)
   {
      if(pricingModelNode->Attribute("href") || pricingModelNode->Attribute("id"))
      {
          if(pricingModelNode->Attribute("id"))
          {
             pricingModelIDRef_ = pricingModelNode->Attribute("id");
             pricingModel_ = boost::shared_ptr<PricingModel>(new PricingModel(pricingModelNode));
             pricingModel_->setID(pricingModelIDRef_);
             IDManager::instance().setID(pricingModelIDRef_,pricingModel_);
          }
          else if(pricingModelNode->Attribute("href")) { pricingModelIDRef_ = pricingModelNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricingModel_ = boost::shared_ptr<PricingModel>(new PricingModel(pricingModelNode));}
   }

   //timeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timeNode = xmlNode->FirstChildElement("time");

   if(timeNode){timeIsNull_ = false;}
   else{timeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timeNode , address : " << timeNode << std::endl;
   #endif
   if(timeNode)
   {
      if(timeNode->Attribute("href") || timeNode->Attribute("id"))
      {
          if(timeNode->Attribute("id"))
          {
             timeIDRef_ = timeNode->Attribute("id");
             time_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(timeNode));
             time_->setID(timeIDRef_);
             IDManager::instance().setID(timeIDRef_,time_);
          }
          else if(timeNode->Attribute("href")) { timeIDRef_ = timeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { time_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(timeNode));}
   }

   //valuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationDateNode = xmlNode->FirstChildElement("valuationDate");

   if(valuationDateNode){valuationDateIsNull_ = false;}
   else{valuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationDateNode , address : " << valuationDateNode << std::endl;
   #endif
   if(valuationDateNode)
   {
      if(valuationDateNode->Attribute("href") || valuationDateNode->Attribute("id"))
      {
          if(valuationDateNode->Attribute("id"))
          {
             valuationDateIDRef_ = valuationDateNode->Attribute("id");
             valuationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valuationDateNode));
             valuationDate_->setID(valuationDateIDRef_);
             IDManager::instance().setID(valuationDateIDRef_,valuationDate_);
          }
          else if(valuationDateNode->Attribute("href")) { valuationDateIDRef_ = valuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(valuationDateNode));}
   }

   //expiryTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expiryTimeNode = xmlNode->FirstChildElement("expiryTime");

   if(expiryTimeNode){expiryTimeIsNull_ = false;}
   else{expiryTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expiryTimeNode , address : " << expiryTimeNode << std::endl;
   #endif
   if(expiryTimeNode)
   {
      if(expiryTimeNode->Attribute("href") || expiryTimeNode->Attribute("id"))
      {
          if(expiryTimeNode->Attribute("id"))
          {
             expiryTimeIDRef_ = expiryTimeNode->Attribute("id");
             expiryTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(expiryTimeNode));
             expiryTime_->setID(expiryTimeIDRef_);
             IDManager::instance().setID(expiryTimeIDRef_,expiryTime_);
          }
          else if(expiryTimeNode->Attribute("href")) { expiryTimeIDRef_ = expiryTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiryTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(expiryTimeNode));}
   }

   //cashflowTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashflowTypeNode = xmlNode->FirstChildElement("cashflowType");

   if(cashflowTypeNode){cashflowTypeIsNull_ = false;}
   else{cashflowTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashflowTypeNode , address : " << cashflowTypeNode << std::endl;
   #endif
   if(cashflowTypeNode)
   {
      if(cashflowTypeNode->Attribute("href") || cashflowTypeNode->Attribute("id"))
      {
          if(cashflowTypeNode->Attribute("id"))
          {
             cashflowTypeIDRef_ = cashflowTypeNode->Attribute("id");
             cashflowType_ = boost::shared_ptr<CashflowType>(new CashflowType(cashflowTypeNode));
             cashflowType_->setID(cashflowTypeIDRef_);
             IDManager::instance().setID(cashflowTypeIDRef_,cashflowType_);
          }
          else if(cashflowTypeNode->Attribute("href")) { cashflowTypeIDRef_ = cashflowTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashflowType_ = boost::shared_ptr<CashflowType>(new CashflowType(cashflowTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PricingDataPointCoordinate> PricingStructurePoint::getCoordinate()
{
   if(!this->coordinateIsNull_){
        if(coordinateIDRef_ != ""){
             return boost::shared_static_cast<PricingDataPointCoordinate>(IDManager::instance().getID(coordinateIDRef_));
        }else{
             return this->coordinate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingDataPointCoordinate>();
   }
}
boost::shared_ptr<PricingDataPointCoordinateReference> PricingStructurePoint::getCoordinateReference()
{
   if(!this->coordinateReferenceIsNull_){
        if(coordinateReferenceIDRef_ != ""){
             return boost::shared_static_cast<PricingDataPointCoordinateReference>(IDManager::instance().getID(coordinateReferenceIDRef_));
        }else{
             return this->coordinateReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingDataPointCoordinateReference>();
   }
}
boost::shared_ptr<Asset> PricingStructurePoint::getUnderlyingAsset()
{
   if(!this->underlyingAssetIsNull_){
        if(underlyingAssetIDRef_ != ""){
             return boost::shared_static_cast<Asset>(IDManager::instance().getID(underlyingAssetIDRef_));
        }else{
             return this->underlyingAsset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Asset>();
   }
}
boost::shared_ptr<Basket> PricingStructurePoint::getBasket()
{
   if(!this->basketIsNull_){
        if(basketIDRef_ != ""){
             return boost::shared_static_cast<Basket>(IDManager::instance().getID(basketIDRef_));
        }else{
             return this->basket_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Basket>();
   }
}
boost::shared_ptr<Bond> PricingStructurePoint::getBond()
{
   if(!this->bondIsNull_){
        if(bondIDRef_ != ""){
             return boost::shared_static_cast<Bond>(IDManager::instance().getID(bondIDRef_));
        }else{
             return this->bond_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Bond>();
   }
}
boost::shared_ptr<Cash> PricingStructurePoint::getCash()
{
   if(!this->cashIsNull_){
        if(cashIDRef_ != ""){
             return boost::shared_static_cast<Cash>(IDManager::instance().getID(cashIDRef_));
        }else{
             return this->cash_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Cash>();
   }
}
boost::shared_ptr<Commodity> PricingStructurePoint::getCommodity()
{
   if(!this->commodityIsNull_){
        if(commodityIDRef_ != ""){
             return boost::shared_static_cast<Commodity>(IDManager::instance().getID(commodityIDRef_));
        }else{
             return this->commodity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Commodity>();
   }
}
boost::shared_ptr<ConvertibleBond> PricingStructurePoint::getConvertibleBond()
{
   if(!this->convertibleBondIsNull_){
        if(convertibleBondIDRef_ != ""){
             return boost::shared_static_cast<ConvertibleBond>(IDManager::instance().getID(convertibleBondIDRef_));
        }else{
             return this->convertibleBond_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConvertibleBond>();
   }
}
boost::shared_ptr<EquityAsset> PricingStructurePoint::getEquity()
{
   if(!this->equityIsNull_){
        if(equityIDRef_ != ""){
             return boost::shared_static_cast<EquityAsset>(IDManager::instance().getID(equityIDRef_));
        }else{
             return this->equity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityAsset>();
   }
}
boost::shared_ptr<ExchangeTradedFund> PricingStructurePoint::getExchangeTradedFund()
{
   if(!this->exchangeTradedFundIsNull_){
        if(exchangeTradedFundIDRef_ != ""){
             return boost::shared_static_cast<ExchangeTradedFund>(IDManager::instance().getID(exchangeTradedFundIDRef_));
        }else{
             return this->exchangeTradedFund_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExchangeTradedFund>();
   }
}
boost::shared_ptr<Future> PricingStructurePoint::getFuture()
{
   if(!this->futureIsNull_){
        if(futureIDRef_ != ""){
             return boost::shared_static_cast<Future>(IDManager::instance().getID(futureIDRef_));
        }else{
             return this->future_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Future>();
   }
}
boost::shared_ptr<Index> PricingStructurePoint::getIndex()
{
   if(!this->indexIsNull_){
        if(indexIDRef_ != ""){
             return boost::shared_static_cast<Index>(IDManager::instance().getID(indexIDRef_));
        }else{
             return this->index_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Index>();
   }
}
boost::shared_ptr<Loan> PricingStructurePoint::getLoan()
{
   if(!this->loanIsNull_){
        if(loanIDRef_ != ""){
             return boost::shared_static_cast<Loan>(IDManager::instance().getID(loanIDRef_));
        }else{
             return this->loan_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Loan>();
   }
}
boost::shared_ptr<Mortgage> PricingStructurePoint::getMortgage()
{
   if(!this->mortgageIsNull_){
        if(mortgageIDRef_ != ""){
             return boost::shared_static_cast<Mortgage>(IDManager::instance().getID(mortgageIDRef_));
        }else{
             return this->mortgage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Mortgage>();
   }
}
boost::shared_ptr<MutualFund> PricingStructurePoint::getMutualFund()
{
   if(!this->mutualFundIsNull_){
        if(mutualFundIDRef_ != ""){
             return boost::shared_static_cast<MutualFund>(IDManager::instance().getID(mutualFundIDRef_));
        }else{
             return this->mutualFund_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MutualFund>();
   }
}
boost::shared_ptr<AssetReference> PricingStructurePoint::getUnderlyingAssetReference()
{
   if(!this->underlyingAssetReferenceIsNull_){
        if(underlyingAssetReferenceIDRef_ != ""){
             return boost::shared_static_cast<AssetReference>(IDManager::instance().getID(underlyingAssetReferenceIDRef_));
        }else{
             return this->underlyingAssetReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> PricingStructurePoint::getValue()
{
   if(!this->valueIsNull_){
        if(valueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(valueIDRef_));
        }else{
             return this->value_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<AssetMeasureType> PricingStructurePoint::getMeasureType()
{
   if(!this->measureTypeIsNull_){
        if(measureTypeIDRef_ != ""){
             return boost::shared_static_cast<AssetMeasureType>(IDManager::instance().getID(measureTypeIDRef_));
        }else{
             return this->measureType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetMeasureType>();
   }
}
boost::shared_ptr<PriceQuoteUnits> PricingStructurePoint::getQuoteUnits()
{
   if(!this->quoteUnitsIsNull_){
        if(quoteUnitsIDRef_ != ""){
             return boost::shared_static_cast<PriceQuoteUnits>(IDManager::instance().getID(quoteUnitsIDRef_));
        }else{
             return this->quoteUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PriceQuoteUnits>();
   }
}
boost::shared_ptr<QuotationSideEnum> PricingStructurePoint::getSide()
{
   if(!this->sideIsNull_){
        if(sideIDRef_ != ""){
             return boost::shared_static_cast<QuotationSideEnum>(IDManager::instance().getID(sideIDRef_));
        }else{
             return this->side_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationSideEnum>();
   }
}
boost::shared_ptr<Currency> PricingStructurePoint::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<ReportingCurrencyType> PricingStructurePoint::getCurrencyType()
{
   if(!this->currencyTypeIsNull_){
        if(currencyTypeIDRef_ != ""){
             return boost::shared_static_cast<ReportingCurrencyType>(IDManager::instance().getID(currencyTypeIDRef_));
        }else{
             return this->currencyType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportingCurrencyType>();
   }
}
boost::shared_ptr<QuoteTiming> PricingStructurePoint::getTiming()
{
   if(!this->timingIsNull_){
        if(timingIDRef_ != ""){
             return boost::shared_static_cast<QuoteTiming>(IDManager::instance().getID(timingIDRef_));
        }else{
             return this->timing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuoteTiming>();
   }
}
boost::shared_ptr<BusinessCenter> PricingStructurePoint::getBusinessCenter()
{
   if(!this->businessCenterIsNull_){
        if(businessCenterIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(businessCenterIDRef_));
        }else{
             return this->businessCenter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
boost::shared_ptr<ExchangeId> PricingStructurePoint::getExchangeId()
{
   if(!this->exchangeIdIsNull_){
        if(exchangeIdIDRef_ != ""){
             return boost::shared_static_cast<ExchangeId>(IDManager::instance().getID(exchangeIdIDRef_));
        }else{
             return this->exchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExchangeId>();
   }
}
std::vector<boost::shared_ptr<InformationSource>> PricingStructurePoint::getInformationSource()
{
   if(!this->informationSourceIsNull_){
        if(informationSourceIDRef_ != ""){
             return this->informationSource_;
        }else{
             return this->informationSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InformationSource>>();
   }
}
boost::shared_ptr<PricingModel> PricingStructurePoint::getPricingModel()
{
   if(!this->pricingModelIsNull_){
        if(pricingModelIDRef_ != ""){
             return boost::shared_static_cast<PricingModel>(IDManager::instance().getID(pricingModelIDRef_));
        }else{
             return this->pricingModel_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PricingModel>();
   }
}
boost::shared_ptr<XsdTypeDateTime> PricingStructurePoint::getTime()
{
   if(!this->timeIsNull_){
        if(timeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(timeIDRef_));
        }else{
             return this->time_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<XsdTypeDate> PricingStructurePoint::getValuationDate()
{
   if(!this->valuationDateIsNull_){
        if(valuationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(valuationDateIDRef_));
        }else{
             return this->valuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDateTime> PricingStructurePoint::getExpiryTime()
{
   if(!this->expiryTimeIsNull_){
        if(expiryTimeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(expiryTimeIDRef_));
        }else{
             return this->expiryTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
boost::shared_ptr<CashflowType> PricingStructurePoint::getCashflowType()
{
   if(!this->cashflowTypeIsNull_){
        if(cashflowTypeIDRef_ != ""){
             return boost::shared_static_cast<CashflowType>(IDManager::instance().getID(cashflowTypeIDRef_));
        }else{
             return this->cashflowType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashflowType>();
   }
}
}

