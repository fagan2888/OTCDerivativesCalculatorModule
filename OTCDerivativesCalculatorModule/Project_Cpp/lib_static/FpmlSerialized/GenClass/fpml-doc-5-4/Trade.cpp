// Trade.cpp 
#include "Trade.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Trade::Trade(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeHeaderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeHeaderNode = xmlNode->FirstChildElement("tradeHeader");

   if(tradeHeaderNode){tradeHeaderIsNull_ = false;}
   else{tradeHeaderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeHeaderNode , address : " << tradeHeaderNode << std::endl;
   #endif
   if(tradeHeaderNode)
   {
      if(tradeHeaderNode->Attribute("href") || tradeHeaderNode->Attribute("id"))
      {
          if(tradeHeaderNode->Attribute("id"))
          {
             tradeHeaderIDRef_ = tradeHeaderNode->Attribute("id");
             tradeHeader_ = boost::shared_ptr<TradeHeader>(new TradeHeader(tradeHeaderNode));
             tradeHeader_->setID(tradeHeaderIDRef_);
             IDManager::instance().setID(tradeHeaderIDRef_,tradeHeader_);
          }
          else if(tradeHeaderNode->Attribute("href")) { tradeHeaderIDRef_ = tradeHeaderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tradeHeader_ = boost::shared_ptr<TradeHeader>(new TradeHeader(tradeHeaderNode));}
   }

   //productNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* productNode = xmlNode->FirstChildElement("product");

   if(productNode){productIsNull_ = false;}
   else{productIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- productNode , address : " << productNode << std::endl;
   #endif
   if(productNode)
   {
      if(productNode->Attribute("href") || productNode->Attribute("id"))
      {
          if(productNode->Attribute("id"))
          {
             productIDRef_ = productNode->Attribute("id");
             product_ = boost::shared_ptr<Product>(new Product(productNode));
             product_->setID(productIDRef_);
             IDManager::instance().setID(productIDRef_,product_);
          }
          else if(productNode->Attribute("href")) { productIDRef_ = productNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { product_ = boost::shared_ptr<Product>(new Product(productNode));}
   }

   //forwardNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardNode = xmlNode->FirstChildElement("forward");

   if(forwardNode){forwardIsNull_ = false;}
   else{forwardIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardNode , address : " << forwardNode << std::endl;
   #endif
   if(forwardNode)
   {
      if(forwardNode->Attribute("href") || forwardNode->Attribute("id"))
      {
          if(forwardNode->Attribute("id"))
          {
             forwardIDRef_ = forwardNode->Attribute("id");
             forward_ = boost::shared_ptr<ForwardSale>(new ForwardSale(forwardNode));
             forward_->setID(forwardIDRef_);
             IDManager::instance().setID(forwardIDRef_,forward_);
          }
          else if(forwardNode->Attribute("href")) { forwardIDRef_ = forwardNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forward_ = boost::shared_ptr<ForwardSale>(new ForwardSale(forwardNode));}
   }

   //bondOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bondOptionNode = xmlNode->FirstChildElement("bondOption");

   if(bondOptionNode){bondOptionIsNull_ = false;}
   else{bondOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bondOptionNode , address : " << bondOptionNode << std::endl;
   #endif
   if(bondOptionNode)
   {
      if(bondOptionNode->Attribute("href") || bondOptionNode->Attribute("id"))
      {
          if(bondOptionNode->Attribute("id"))
          {
             bondOptionIDRef_ = bondOptionNode->Attribute("id");
             bondOption_ = boost::shared_ptr<BondOption>(new BondOption(bondOptionNode));
             bondOption_->setID(bondOptionIDRef_);
             IDManager::instance().setID(bondOptionIDRef_,bondOption_);
          }
          else if(bondOptionNode->Attribute("href")) { bondOptionIDRef_ = bondOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bondOption_ = boost::shared_ptr<BondOption>(new BondOption(bondOptionNode));}
   }

   //creditDefaultSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditDefaultSwapNode = xmlNode->FirstChildElement("creditDefaultSwap");

   if(creditDefaultSwapNode){creditDefaultSwapIsNull_ = false;}
   else{creditDefaultSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDefaultSwapNode , address : " << creditDefaultSwapNode << std::endl;
   #endif
   if(creditDefaultSwapNode)
   {
      if(creditDefaultSwapNode->Attribute("href") || creditDefaultSwapNode->Attribute("id"))
      {
          if(creditDefaultSwapNode->Attribute("id"))
          {
             creditDefaultSwapIDRef_ = creditDefaultSwapNode->Attribute("id");
             creditDefaultSwap_ = boost::shared_ptr<CreditDefaultSwap>(new CreditDefaultSwap(creditDefaultSwapNode));
             creditDefaultSwap_->setID(creditDefaultSwapIDRef_);
             IDManager::instance().setID(creditDefaultSwapIDRef_,creditDefaultSwap_);
          }
          else if(creditDefaultSwapNode->Attribute("href")) { creditDefaultSwapIDRef_ = creditDefaultSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditDefaultSwap_ = boost::shared_ptr<CreditDefaultSwap>(new CreditDefaultSwap(creditDefaultSwapNode));}
   }

   //creditDefaultSwapOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditDefaultSwapOptionNode = xmlNode->FirstChildElement("creditDefaultSwapOption");

   if(creditDefaultSwapOptionNode){creditDefaultSwapOptionIsNull_ = false;}
   else{creditDefaultSwapOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditDefaultSwapOptionNode , address : " << creditDefaultSwapOptionNode << std::endl;
   #endif
   if(creditDefaultSwapOptionNode)
   {
      if(creditDefaultSwapOptionNode->Attribute("href") || creditDefaultSwapOptionNode->Attribute("id"))
      {
          if(creditDefaultSwapOptionNode->Attribute("id"))
          {
             creditDefaultSwapOptionIDRef_ = creditDefaultSwapOptionNode->Attribute("id");
             creditDefaultSwapOption_ = boost::shared_ptr<CreditDefaultSwapOption>(new CreditDefaultSwapOption(creditDefaultSwapOptionNode));
             creditDefaultSwapOption_->setID(creditDefaultSwapOptionIDRef_);
             IDManager::instance().setID(creditDefaultSwapOptionIDRef_,creditDefaultSwapOption_);
          }
          else if(creditDefaultSwapOptionNode->Attribute("href")) { creditDefaultSwapOptionIDRef_ = creditDefaultSwapOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditDefaultSwapOption_ = boost::shared_ptr<CreditDefaultSwapOption>(new CreditDefaultSwapOption(creditDefaultSwapOptionNode));}
   }

   //commodityForwardNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityForwardNode = xmlNode->FirstChildElement("commodityForward");

   if(commodityForwardNode){commodityForwardIsNull_ = false;}
   else{commodityForwardIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityForwardNode , address : " << commodityForwardNode << std::endl;
   #endif
   if(commodityForwardNode)
   {
      if(commodityForwardNode->Attribute("href") || commodityForwardNode->Attribute("id"))
      {
          if(commodityForwardNode->Attribute("id"))
          {
             commodityForwardIDRef_ = commodityForwardNode->Attribute("id");
             commodityForward_ = boost::shared_ptr<CommodityForward>(new CommodityForward(commodityForwardNode));
             commodityForward_->setID(commodityForwardIDRef_);
             IDManager::instance().setID(commodityForwardIDRef_,commodityForward_);
          }
          else if(commodityForwardNode->Attribute("href")) { commodityForwardIDRef_ = commodityForwardNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodityForward_ = boost::shared_ptr<CommodityForward>(new CommodityForward(commodityForwardNode));}
   }

   //commodityOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commodityOptionNode = xmlNode->FirstChildElement("commodityOption");

   if(commodityOptionNode){commodityOptionIsNull_ = false;}
   else{commodityOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commodityOptionNode , address : " << commodityOptionNode << std::endl;
   #endif
   if(commodityOptionNode)
   {
      if(commodityOptionNode->Attribute("href") || commodityOptionNode->Attribute("id"))
      {
          if(commodityOptionNode->Attribute("id"))
          {
             commodityOptionIDRef_ = commodityOptionNode->Attribute("id");
             commodityOption_ = boost::shared_ptr<CommodityOption>(new CommodityOption(commodityOptionNode));
             commodityOption_->setID(commodityOptionIDRef_);
             IDManager::instance().setID(commodityOptionIDRef_,commodityOption_);
          }
          else if(commodityOptionNode->Attribute("href")) { commodityOptionIDRef_ = commodityOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commodityOption_ = boost::shared_ptr<CommodityOption>(new CommodityOption(commodityOptionNode));}
   }

   //commoditySwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commoditySwapNode = xmlNode->FirstChildElement("commoditySwap");

   if(commoditySwapNode){commoditySwapIsNull_ = false;}
   else{commoditySwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commoditySwapNode , address : " << commoditySwapNode << std::endl;
   #endif
   if(commoditySwapNode)
   {
      if(commoditySwapNode->Attribute("href") || commoditySwapNode->Attribute("id"))
      {
          if(commoditySwapNode->Attribute("id"))
          {
             commoditySwapIDRef_ = commoditySwapNode->Attribute("id");
             commoditySwap_ = boost::shared_ptr<CommoditySwap>(new CommoditySwap(commoditySwapNode));
             commoditySwap_->setID(commoditySwapIDRef_);
             IDManager::instance().setID(commoditySwapIDRef_,commoditySwap_);
          }
          else if(commoditySwapNode->Attribute("href")) { commoditySwapIDRef_ = commoditySwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commoditySwap_ = boost::shared_ptr<CommoditySwap>(new CommoditySwap(commoditySwapNode));}
   }

   //commoditySwaptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commoditySwaptionNode = xmlNode->FirstChildElement("commoditySwaption");

   if(commoditySwaptionNode){commoditySwaptionIsNull_ = false;}
   else{commoditySwaptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commoditySwaptionNode , address : " << commoditySwaptionNode << std::endl;
   #endif
   if(commoditySwaptionNode)
   {
      if(commoditySwaptionNode->Attribute("href") || commoditySwaptionNode->Attribute("id"))
      {
          if(commoditySwaptionNode->Attribute("id"))
          {
             commoditySwaptionIDRef_ = commoditySwaptionNode->Attribute("id");
             commoditySwaption_ = boost::shared_ptr<CommoditySwaption>(new CommoditySwaption(commoditySwaptionNode));
             commoditySwaption_->setID(commoditySwaptionIDRef_);
             IDManager::instance().setID(commoditySwaptionIDRef_,commoditySwaption_);
          }
          else if(commoditySwaptionNode->Attribute("href")) { commoditySwaptionIDRef_ = commoditySwaptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commoditySwaption_ = boost::shared_ptr<CommoditySwaption>(new CommoditySwaption(commoditySwaptionNode));}
   }

   //correlationSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationSwapNode = xmlNode->FirstChildElement("correlationSwap");

   if(correlationSwapNode){correlationSwapIsNull_ = false;}
   else{correlationSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationSwapNode , address : " << correlationSwapNode << std::endl;
   #endif
   if(correlationSwapNode)
   {
      if(correlationSwapNode->Attribute("href") || correlationSwapNode->Attribute("id"))
      {
          if(correlationSwapNode->Attribute("id"))
          {
             correlationSwapIDRef_ = correlationSwapNode->Attribute("id");
             correlationSwap_ = boost::shared_ptr<CorrelationSwap>(new CorrelationSwap(correlationSwapNode));
             correlationSwap_->setID(correlationSwapIDRef_);
             IDManager::instance().setID(correlationSwapIDRef_,correlationSwap_);
          }
          else if(correlationSwapNode->Attribute("href")) { correlationSwapIDRef_ = correlationSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correlationSwap_ = boost::shared_ptr<CorrelationSwap>(new CorrelationSwap(correlationSwapNode));}
   }

   //dividendSwapOptionTransactionSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendSwapOptionTransactionSupplementNode = xmlNode->FirstChildElement("dividendSwapOptionTransactionSupplement");

   if(dividendSwapOptionTransactionSupplementNode){dividendSwapOptionTransactionSupplementIsNull_ = false;}
   else{dividendSwapOptionTransactionSupplementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendSwapOptionTransactionSupplementNode , address : " << dividendSwapOptionTransactionSupplementNode << std::endl;
   #endif
   if(dividendSwapOptionTransactionSupplementNode)
   {
      if(dividendSwapOptionTransactionSupplementNode->Attribute("href") || dividendSwapOptionTransactionSupplementNode->Attribute("id"))
      {
          if(dividendSwapOptionTransactionSupplementNode->Attribute("id"))
          {
             dividendSwapOptionTransactionSupplementIDRef_ = dividendSwapOptionTransactionSupplementNode->Attribute("id");
             dividendSwapOptionTransactionSupplement_ = boost::shared_ptr<DividendSwapOptionTransactionSupplement>(new DividendSwapOptionTransactionSupplement(dividendSwapOptionTransactionSupplementNode));
             dividendSwapOptionTransactionSupplement_->setID(dividendSwapOptionTransactionSupplementIDRef_);
             IDManager::instance().setID(dividendSwapOptionTransactionSupplementIDRef_,dividendSwapOptionTransactionSupplement_);
          }
          else if(dividendSwapOptionTransactionSupplementNode->Attribute("href")) { dividendSwapOptionTransactionSupplementIDRef_ = dividendSwapOptionTransactionSupplementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendSwapOptionTransactionSupplement_ = boost::shared_ptr<DividendSwapOptionTransactionSupplement>(new DividendSwapOptionTransactionSupplement(dividendSwapOptionTransactionSupplementNode));}
   }

   //dividendSwapTransactionSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendSwapTransactionSupplementNode = xmlNode->FirstChildElement("dividendSwapTransactionSupplement");

   if(dividendSwapTransactionSupplementNode){dividendSwapTransactionSupplementIsNull_ = false;}
   else{dividendSwapTransactionSupplementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendSwapTransactionSupplementNode , address : " << dividendSwapTransactionSupplementNode << std::endl;
   #endif
   if(dividendSwapTransactionSupplementNode)
   {
      if(dividendSwapTransactionSupplementNode->Attribute("href") || dividendSwapTransactionSupplementNode->Attribute("id"))
      {
          if(dividendSwapTransactionSupplementNode->Attribute("id"))
          {
             dividendSwapTransactionSupplementIDRef_ = dividendSwapTransactionSupplementNode->Attribute("id");
             dividendSwapTransactionSupplement_ = boost::shared_ptr<DividendSwapTransactionSupplement>(new DividendSwapTransactionSupplement(dividendSwapTransactionSupplementNode));
             dividendSwapTransactionSupplement_->setID(dividendSwapTransactionSupplementIDRef_);
             IDManager::instance().setID(dividendSwapTransactionSupplementIDRef_,dividendSwapTransactionSupplement_);
          }
          else if(dividendSwapTransactionSupplementNode->Attribute("href")) { dividendSwapTransactionSupplementIDRef_ = dividendSwapTransactionSupplementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendSwapTransactionSupplement_ = boost::shared_ptr<DividendSwapTransactionSupplement>(new DividendSwapTransactionSupplement(dividendSwapTransactionSupplementNode));}
   }

   //instrumentTradeDetailsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentTradeDetailsNode = xmlNode->FirstChildElement("instrumentTradeDetails");

   if(instrumentTradeDetailsNode){instrumentTradeDetailsIsNull_ = false;}
   else{instrumentTradeDetailsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentTradeDetailsNode , address : " << instrumentTradeDetailsNode << std::endl;
   #endif
   if(instrumentTradeDetailsNode)
   {
      if(instrumentTradeDetailsNode->Attribute("href") || instrumentTradeDetailsNode->Attribute("id"))
      {
          if(instrumentTradeDetailsNode->Attribute("id"))
          {
             instrumentTradeDetailsIDRef_ = instrumentTradeDetailsNode->Attribute("id");
             instrumentTradeDetails_ = boost::shared_ptr<InstrumentTradeDetails>(new InstrumentTradeDetails(instrumentTradeDetailsNode));
             instrumentTradeDetails_->setID(instrumentTradeDetailsIDRef_);
             IDManager::instance().setID(instrumentTradeDetailsIDRef_,instrumentTradeDetails_);
          }
          else if(instrumentTradeDetailsNode->Attribute("href")) { instrumentTradeDetailsIDRef_ = instrumentTradeDetailsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { instrumentTradeDetails_ = boost::shared_ptr<InstrumentTradeDetails>(new InstrumentTradeDetails(instrumentTradeDetailsNode));}
   }

   //strategyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strategyNode = xmlNode->FirstChildElement("strategy");

   if(strategyNode){strategyIsNull_ = false;}
   else{strategyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strategyNode , address : " << strategyNode << std::endl;
   #endif
   if(strategyNode)
   {
      if(strategyNode->Attribute("href") || strategyNode->Attribute("id"))
      {
          if(strategyNode->Attribute("id"))
          {
             strategyIDRef_ = strategyNode->Attribute("id");
             strategy_ = boost::shared_ptr<Strategy>(new Strategy(strategyNode));
             strategy_->setID(strategyIDRef_);
             IDManager::instance().setID(strategyIDRef_,strategy_);
          }
          else if(strategyNode->Attribute("href")) { strategyIDRef_ = strategyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strategy_ = boost::shared_ptr<Strategy>(new Strategy(strategyNode));}
   }

   //returnSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnSwapNode = xmlNode->FirstChildElement("returnSwap");

   if(returnSwapNode){returnSwapIsNull_ = false;}
   else{returnSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnSwapNode , address : " << returnSwapNode << std::endl;
   #endif
   if(returnSwapNode)
   {
      if(returnSwapNode->Attribute("href") || returnSwapNode->Attribute("id"))
      {
          if(returnSwapNode->Attribute("id"))
          {
             returnSwapIDRef_ = returnSwapNode->Attribute("id");
             returnSwap_ = boost::shared_ptr<ReturnSwap>(new ReturnSwap(returnSwapNode));
             returnSwap_->setID(returnSwapIDRef_);
             IDManager::instance().setID(returnSwapIDRef_,returnSwap_);
          }
          else if(returnSwapNode->Attribute("href")) { returnSwapIDRef_ = returnSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { returnSwap_ = boost::shared_ptr<ReturnSwap>(new ReturnSwap(returnSwapNode));}
   }

   //brokerEquityOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brokerEquityOptionNode = xmlNode->FirstChildElement("brokerEquityOption");

   if(brokerEquityOptionNode){brokerEquityOptionIsNull_ = false;}
   else{brokerEquityOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brokerEquityOptionNode , address : " << brokerEquityOptionNode << std::endl;
   #endif
   if(brokerEquityOptionNode)
   {
      if(brokerEquityOptionNode->Attribute("href") || brokerEquityOptionNode->Attribute("id"))
      {
          if(brokerEquityOptionNode->Attribute("id"))
          {
             brokerEquityOptionIDRef_ = brokerEquityOptionNode->Attribute("id");
             brokerEquityOption_ = boost::shared_ptr<BrokerEquityOption>(new BrokerEquityOption(brokerEquityOptionNode));
             brokerEquityOption_->setID(brokerEquityOptionIDRef_);
             IDManager::instance().setID(brokerEquityOptionIDRef_,brokerEquityOption_);
          }
          else if(brokerEquityOptionNode->Attribute("href")) { brokerEquityOptionIDRef_ = brokerEquityOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { brokerEquityOption_ = boost::shared_ptr<BrokerEquityOption>(new BrokerEquityOption(brokerEquityOptionNode));}
   }

   //equityForwardNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityForwardNode = xmlNode->FirstChildElement("equityForward");

   if(equityForwardNode){equityForwardIsNull_ = false;}
   else{equityForwardIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityForwardNode , address : " << equityForwardNode << std::endl;
   #endif
   if(equityForwardNode)
   {
      if(equityForwardNode->Attribute("href") || equityForwardNode->Attribute("id"))
      {
          if(equityForwardNode->Attribute("id"))
          {
             equityForwardIDRef_ = equityForwardNode->Attribute("id");
             equityForward_ = boost::shared_ptr<EquityForward>(new EquityForward(equityForwardNode));
             equityForward_->setID(equityForwardIDRef_);
             IDManager::instance().setID(equityForwardIDRef_,equityForward_);
          }
          else if(equityForwardNode->Attribute("href")) { equityForwardIDRef_ = equityForwardNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityForward_ = boost::shared_ptr<EquityForward>(new EquityForward(equityForwardNode));}
   }

   //equityOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityOptionNode = xmlNode->FirstChildElement("equityOption");

   if(equityOptionNode){equityOptionIsNull_ = false;}
   else{equityOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityOptionNode , address : " << equityOptionNode << std::endl;
   #endif
   if(equityOptionNode)
   {
      if(equityOptionNode->Attribute("href") || equityOptionNode->Attribute("id"))
      {
          if(equityOptionNode->Attribute("id"))
          {
             equityOptionIDRef_ = equityOptionNode->Attribute("id");
             equityOption_ = boost::shared_ptr<EquityOption>(new EquityOption(equityOptionNode));
             equityOption_->setID(equityOptionIDRef_);
             IDManager::instance().setID(equityOptionIDRef_,equityOption_);
          }
          else if(equityOptionNode->Attribute("href")) { equityOptionIDRef_ = equityOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityOption_ = boost::shared_ptr<EquityOption>(new EquityOption(equityOptionNode));}
   }

   //equityOptionTransactionSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equityOptionTransactionSupplementNode = xmlNode->FirstChildElement("equityOptionTransactionSupplement");

   if(equityOptionTransactionSupplementNode){equityOptionTransactionSupplementIsNull_ = false;}
   else{equityOptionTransactionSupplementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equityOptionTransactionSupplementNode , address : " << equityOptionTransactionSupplementNode << std::endl;
   #endif
   if(equityOptionTransactionSupplementNode)
   {
      if(equityOptionTransactionSupplementNode->Attribute("href") || equityOptionTransactionSupplementNode->Attribute("id"))
      {
          if(equityOptionTransactionSupplementNode->Attribute("id"))
          {
             equityOptionTransactionSupplementIDRef_ = equityOptionTransactionSupplementNode->Attribute("id");
             equityOptionTransactionSupplement_ = boost::shared_ptr<EquityOptionTransactionSupplement>(new EquityOptionTransactionSupplement(equityOptionTransactionSupplementNode));
             equityOptionTransactionSupplement_->setID(equityOptionTransactionSupplementIDRef_);
             IDManager::instance().setID(equityOptionTransactionSupplementIDRef_,equityOptionTransactionSupplement_);
          }
          else if(equityOptionTransactionSupplementNode->Attribute("href")) { equityOptionTransactionSupplementIDRef_ = equityOptionTransactionSupplementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equityOptionTransactionSupplement_ = boost::shared_ptr<EquityOptionTransactionSupplement>(new EquityOptionTransactionSupplement(equityOptionTransactionSupplementNode));}
   }

   //fxSingleLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxSingleLegNode = xmlNode->FirstChildElement("fxSingleLeg");

   if(fxSingleLegNode){fxSingleLegIsNull_ = false;}
   else{fxSingleLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxSingleLegNode , address : " << fxSingleLegNode << std::endl;
   #endif
   if(fxSingleLegNode)
   {
      if(fxSingleLegNode->Attribute("href") || fxSingleLegNode->Attribute("id"))
      {
          if(fxSingleLegNode->Attribute("id"))
          {
             fxSingleLegIDRef_ = fxSingleLegNode->Attribute("id");
             fxSingleLeg_ = boost::shared_ptr<FxSingleLeg>(new FxSingleLeg(fxSingleLegNode));
             fxSingleLeg_->setID(fxSingleLegIDRef_);
             IDManager::instance().setID(fxSingleLegIDRef_,fxSingleLeg_);
          }
          else if(fxSingleLegNode->Attribute("href")) { fxSingleLegIDRef_ = fxSingleLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxSingleLeg_ = boost::shared_ptr<FxSingleLeg>(new FxSingleLeg(fxSingleLegNode));}
   }

   //fxSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxSwapNode = xmlNode->FirstChildElement("fxSwap");

   if(fxSwapNode){fxSwapIsNull_ = false;}
   else{fxSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxSwapNode , address : " << fxSwapNode << std::endl;
   #endif
   if(fxSwapNode)
   {
      if(fxSwapNode->Attribute("href") || fxSwapNode->Attribute("id"))
      {
          if(fxSwapNode->Attribute("id"))
          {
             fxSwapIDRef_ = fxSwapNode->Attribute("id");
             fxSwap_ = boost::shared_ptr<FxSwap>(new FxSwap(fxSwapNode));
             fxSwap_->setID(fxSwapIDRef_);
             IDManager::instance().setID(fxSwapIDRef_,fxSwap_);
          }
          else if(fxSwapNode->Attribute("href")) { fxSwapIDRef_ = fxSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxSwap_ = boost::shared_ptr<FxSwap>(new FxSwap(fxSwapNode));}
   }

   //fxOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxOptionNode = xmlNode->FirstChildElement("fxOption");

   if(fxOptionNode){fxOptionIsNull_ = false;}
   else{fxOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxOptionNode , address : " << fxOptionNode << std::endl;
   #endif
   if(fxOptionNode)
   {
      if(fxOptionNode->Attribute("href") || fxOptionNode->Attribute("id"))
      {
          if(fxOptionNode->Attribute("id"))
          {
             fxOptionIDRef_ = fxOptionNode->Attribute("id");
             fxOption_ = boost::shared_ptr<FxOption>(new FxOption(fxOptionNode));
             fxOption_->setID(fxOptionIDRef_);
             IDManager::instance().setID(fxOptionIDRef_,fxOption_);
          }
          else if(fxOptionNode->Attribute("href")) { fxOptionIDRef_ = fxOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxOption_ = boost::shared_ptr<FxOption>(new FxOption(fxOptionNode));}
   }

   //fxDigitalOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxDigitalOptionNode = xmlNode->FirstChildElement("fxDigitalOption");

   if(fxDigitalOptionNode){fxDigitalOptionIsNull_ = false;}
   else{fxDigitalOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxDigitalOptionNode , address : " << fxDigitalOptionNode << std::endl;
   #endif
   if(fxDigitalOptionNode)
   {
      if(fxDigitalOptionNode->Attribute("href") || fxDigitalOptionNode->Attribute("id"))
      {
          if(fxDigitalOptionNode->Attribute("id"))
          {
             fxDigitalOptionIDRef_ = fxDigitalOptionNode->Attribute("id");
             fxDigitalOption_ = boost::shared_ptr<FxDigitalOption>(new FxDigitalOption(fxDigitalOptionNode));
             fxDigitalOption_->setID(fxDigitalOptionIDRef_);
             IDManager::instance().setID(fxDigitalOptionIDRef_,fxDigitalOption_);
          }
          else if(fxDigitalOptionNode->Attribute("href")) { fxDigitalOptionIDRef_ = fxDigitalOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxDigitalOption_ = boost::shared_ptr<FxDigitalOption>(new FxDigitalOption(fxDigitalOptionNode));}
   }

   //termDepositNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* termDepositNode = xmlNode->FirstChildElement("termDeposit");

   if(termDepositNode){termDepositIsNull_ = false;}
   else{termDepositIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- termDepositNode , address : " << termDepositNode << std::endl;
   #endif
   if(termDepositNode)
   {
      if(termDepositNode->Attribute("href") || termDepositNode->Attribute("id"))
      {
          if(termDepositNode->Attribute("id"))
          {
             termDepositIDRef_ = termDepositNode->Attribute("id");
             termDeposit_ = boost::shared_ptr<TermDeposit>(new TermDeposit(termDepositNode));
             termDeposit_->setID(termDepositIDRef_);
             IDManager::instance().setID(termDepositIDRef_,termDeposit_);
          }
          else if(termDepositNode->Attribute("href")) { termDepositIDRef_ = termDepositNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { termDeposit_ = boost::shared_ptr<TermDeposit>(new TermDeposit(termDepositNode));}
   }

   //genericProductNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* genericProductNode = xmlNode->FirstChildElement("genericProduct");

   if(genericProductNode){genericProductIsNull_ = false;}
   else{genericProductIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- genericProductNode , address : " << genericProductNode << std::endl;
   #endif
   if(genericProductNode)
   {
      if(genericProductNode->Attribute("href") || genericProductNode->Attribute("id"))
      {
          if(genericProductNode->Attribute("id"))
          {
             genericProductIDRef_ = genericProductNode->Attribute("id");
             genericProduct_ = boost::shared_ptr<GenericProduct>(new GenericProduct(genericProductNode));
             genericProduct_->setID(genericProductIDRef_);
             IDManager::instance().setID(genericProductIDRef_,genericProduct_);
          }
          else if(genericProductNode->Attribute("href")) { genericProductIDRef_ = genericProductNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { genericProduct_ = boost::shared_ptr<GenericProduct>(new GenericProduct(genericProductNode));}
   }

   //nonSchemaProductNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonSchemaProductNode = xmlNode->FirstChildElement("nonSchemaProduct");

   if(nonSchemaProductNode){nonSchemaProductIsNull_ = false;}
   else{nonSchemaProductIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonSchemaProductNode , address : " << nonSchemaProductNode << std::endl;
   #endif
   if(nonSchemaProductNode)
   {
      if(nonSchemaProductNode->Attribute("href") || nonSchemaProductNode->Attribute("id"))
      {
          if(nonSchemaProductNode->Attribute("id"))
          {
             nonSchemaProductIDRef_ = nonSchemaProductNode->Attribute("id");
             nonSchemaProduct_ = boost::shared_ptr<GenericProduct>(new GenericProduct(nonSchemaProductNode));
             nonSchemaProduct_->setID(nonSchemaProductIDRef_);
             IDManager::instance().setID(nonSchemaProductIDRef_,nonSchemaProduct_);
          }
          else if(nonSchemaProductNode->Attribute("href")) { nonSchemaProductIDRef_ = nonSchemaProductNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonSchemaProduct_ = boost::shared_ptr<GenericProduct>(new GenericProduct(nonSchemaProductNode));}
   }

   //bulletPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bulletPaymentNode = xmlNode->FirstChildElement("bulletPayment");

   if(bulletPaymentNode){bulletPaymentIsNull_ = false;}
   else{bulletPaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bulletPaymentNode , address : " << bulletPaymentNode << std::endl;
   #endif
   if(bulletPaymentNode)
   {
      if(bulletPaymentNode->Attribute("href") || bulletPaymentNode->Attribute("id"))
      {
          if(bulletPaymentNode->Attribute("id"))
          {
             bulletPaymentIDRef_ = bulletPaymentNode->Attribute("id");
             bulletPayment_ = boost::shared_ptr<BulletPayment>(new BulletPayment(bulletPaymentNode));
             bulletPayment_->setID(bulletPaymentIDRef_);
             IDManager::instance().setID(bulletPaymentIDRef_,bulletPayment_);
          }
          else if(bulletPaymentNode->Attribute("href")) { bulletPaymentIDRef_ = bulletPaymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bulletPayment_ = boost::shared_ptr<BulletPayment>(new BulletPayment(bulletPaymentNode));}
   }

   //capFloorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* capFloorNode = xmlNode->FirstChildElement("capFloor");

   if(capFloorNode){capFloorIsNull_ = false;}
   else{capFloorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capFloorNode , address : " << capFloorNode << std::endl;
   #endif
   if(capFloorNode)
   {
      if(capFloorNode->Attribute("href") || capFloorNode->Attribute("id"))
      {
          if(capFloorNode->Attribute("id"))
          {
             capFloorIDRef_ = capFloorNode->Attribute("id");
             capFloor_ = boost::shared_ptr<CapFloor>(new CapFloor(capFloorNode));
             capFloor_->setID(capFloorIDRef_);
             IDManager::instance().setID(capFloorIDRef_,capFloor_);
          }
          else if(capFloorNode->Attribute("href")) { capFloorIDRef_ = capFloorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { capFloor_ = boost::shared_ptr<CapFloor>(new CapFloor(capFloorNode));}
   }

   //fraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fraNode = xmlNode->FirstChildElement("fra");

   if(fraNode){fraIsNull_ = false;}
   else{fraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fraNode , address : " << fraNode << std::endl;
   #endif
   if(fraNode)
   {
      if(fraNode->Attribute("href") || fraNode->Attribute("id"))
      {
          if(fraNode->Attribute("id"))
          {
             fraIDRef_ = fraNode->Attribute("id");
             fra_ = boost::shared_ptr<Fra>(new Fra(fraNode));
             fra_->setID(fraIDRef_);
             IDManager::instance().setID(fraIDRef_,fra_);
          }
          else if(fraNode->Attribute("href")) { fraIDRef_ = fraNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fra_ = boost::shared_ptr<Fra>(new Fra(fraNode));}
   }

   //swapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapNode = xmlNode->FirstChildElement("swap");

   if(swapNode){swapIsNull_ = false;}
   else{swapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapNode , address : " << swapNode << std::endl;
   #endif
   if(swapNode)
   {
      if(swapNode->Attribute("href") || swapNode->Attribute("id"))
      {
          if(swapNode->Attribute("id"))
          {
             swapIDRef_ = swapNode->Attribute("id");
             swap_ = boost::shared_ptr<Swap>(new Swap(swapNode));
             swap_->setID(swapIDRef_);
             IDManager::instance().setID(swapIDRef_,swap_);
          }
          else if(swapNode->Attribute("href")) { swapIDRef_ = swapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swap_ = boost::shared_ptr<Swap>(new Swap(swapNode));}
   }

   //swaptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swaptionNode = xmlNode->FirstChildElement("swaption");

   if(swaptionNode){swaptionIsNull_ = false;}
   else{swaptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swaptionNode , address : " << swaptionNode << std::endl;
   #endif
   if(swaptionNode)
   {
      if(swaptionNode->Attribute("href") || swaptionNode->Attribute("id"))
      {
          if(swaptionNode->Attribute("id"))
          {
             swaptionIDRef_ = swaptionNode->Attribute("id");
             swaption_ = boost::shared_ptr<Swaption>(new Swaption(swaptionNode));
             swaption_->setID(swaptionIDRef_);
             IDManager::instance().setID(swaptionIDRef_,swaption_);
          }
          else if(swaptionNode->Attribute("href")) { swaptionIDRef_ = swaptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swaption_ = boost::shared_ptr<Swaption>(new Swaption(swaptionNode));}
   }

   //equitySwapTransactionSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equitySwapTransactionSupplementNode = xmlNode->FirstChildElement("equitySwapTransactionSupplement");

   if(equitySwapTransactionSupplementNode){equitySwapTransactionSupplementIsNull_ = false;}
   else{equitySwapTransactionSupplementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equitySwapTransactionSupplementNode , address : " << equitySwapTransactionSupplementNode << std::endl;
   #endif
   if(equitySwapTransactionSupplementNode)
   {
      if(equitySwapTransactionSupplementNode->Attribute("href") || equitySwapTransactionSupplementNode->Attribute("id"))
      {
          if(equitySwapTransactionSupplementNode->Attribute("id"))
          {
             equitySwapTransactionSupplementIDRef_ = equitySwapTransactionSupplementNode->Attribute("id");
             equitySwapTransactionSupplement_ = boost::shared_ptr<EquitySwapTransactionSupplement>(new EquitySwapTransactionSupplement(equitySwapTransactionSupplementNode));
             equitySwapTransactionSupplement_->setID(equitySwapTransactionSupplementIDRef_);
             IDManager::instance().setID(equitySwapTransactionSupplementIDRef_,equitySwapTransactionSupplement_);
          }
          else if(equitySwapTransactionSupplementNode->Attribute("href")) { equitySwapTransactionSupplementIDRef_ = equitySwapTransactionSupplementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equitySwapTransactionSupplement_ = boost::shared_ptr<EquitySwapTransactionSupplement>(new EquitySwapTransactionSupplement(equitySwapTransactionSupplementNode));}
   }

   //standardProductNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardProductNode = xmlNode->FirstChildElement("standardProduct");

   if(standardProductNode){standardProductIsNull_ = false;}
   else{standardProductIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardProductNode , address : " << standardProductNode << std::endl;
   #endif
   if(standardProductNode)
   {
      if(standardProductNode->Attribute("href") || standardProductNode->Attribute("id"))
      {
          if(standardProductNode->Attribute("id"))
          {
             standardProductIDRef_ = standardProductNode->Attribute("id");
             standardProduct_ = boost::shared_ptr<StandardProduct>(new StandardProduct(standardProductNode));
             standardProduct_->setID(standardProductIDRef_);
             IDManager::instance().setID(standardProductIDRef_,standardProduct_);
          }
          else if(standardProductNode->Attribute("href")) { standardProductIDRef_ = standardProductNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { standardProduct_ = boost::shared_ptr<StandardProduct>(new StandardProduct(standardProductNode));}
   }

   //varianceOptionTransactionSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceOptionTransactionSupplementNode = xmlNode->FirstChildElement("varianceOptionTransactionSupplement");

   if(varianceOptionTransactionSupplementNode){varianceOptionTransactionSupplementIsNull_ = false;}
   else{varianceOptionTransactionSupplementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceOptionTransactionSupplementNode , address : " << varianceOptionTransactionSupplementNode << std::endl;
   #endif
   if(varianceOptionTransactionSupplementNode)
   {
      if(varianceOptionTransactionSupplementNode->Attribute("href") || varianceOptionTransactionSupplementNode->Attribute("id"))
      {
          if(varianceOptionTransactionSupplementNode->Attribute("id"))
          {
             varianceOptionTransactionSupplementIDRef_ = varianceOptionTransactionSupplementNode->Attribute("id");
             varianceOptionTransactionSupplement_ = boost::shared_ptr<VarianceOptionTransactionSupplement>(new VarianceOptionTransactionSupplement(varianceOptionTransactionSupplementNode));
             varianceOptionTransactionSupplement_->setID(varianceOptionTransactionSupplementIDRef_);
             IDManager::instance().setID(varianceOptionTransactionSupplementIDRef_,varianceOptionTransactionSupplement_);
          }
          else if(varianceOptionTransactionSupplementNode->Attribute("href")) { varianceOptionTransactionSupplementIDRef_ = varianceOptionTransactionSupplementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varianceOptionTransactionSupplement_ = boost::shared_ptr<VarianceOptionTransactionSupplement>(new VarianceOptionTransactionSupplement(varianceOptionTransactionSupplementNode));}
   }

   //varianceSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceSwapNode = xmlNode->FirstChildElement("varianceSwap");

   if(varianceSwapNode){varianceSwapIsNull_ = false;}
   else{varianceSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceSwapNode , address : " << varianceSwapNode << std::endl;
   #endif
   if(varianceSwapNode)
   {
      if(varianceSwapNode->Attribute("href") || varianceSwapNode->Attribute("id"))
      {
          if(varianceSwapNode->Attribute("id"))
          {
             varianceSwapIDRef_ = varianceSwapNode->Attribute("id");
             varianceSwap_ = boost::shared_ptr<VarianceSwap>(new VarianceSwap(varianceSwapNode));
             varianceSwap_->setID(varianceSwapIDRef_);
             IDManager::instance().setID(varianceSwapIDRef_,varianceSwap_);
          }
          else if(varianceSwapNode->Attribute("href")) { varianceSwapIDRef_ = varianceSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varianceSwap_ = boost::shared_ptr<VarianceSwap>(new VarianceSwap(varianceSwapNode));}
   }

   //varianceSwapTransactionSupplementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceSwapTransactionSupplementNode = xmlNode->FirstChildElement("varianceSwapTransactionSupplement");

   if(varianceSwapTransactionSupplementNode){varianceSwapTransactionSupplementIsNull_ = false;}
   else{varianceSwapTransactionSupplementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceSwapTransactionSupplementNode , address : " << varianceSwapTransactionSupplementNode << std::endl;
   #endif
   if(varianceSwapTransactionSupplementNode)
   {
      if(varianceSwapTransactionSupplementNode->Attribute("href") || varianceSwapTransactionSupplementNode->Attribute("id"))
      {
          if(varianceSwapTransactionSupplementNode->Attribute("id"))
          {
             varianceSwapTransactionSupplementIDRef_ = varianceSwapTransactionSupplementNode->Attribute("id");
             varianceSwapTransactionSupplement_ = boost::shared_ptr<VarianceSwapTransactionSupplement>(new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode));
             varianceSwapTransactionSupplement_->setID(varianceSwapTransactionSupplementIDRef_);
             IDManager::instance().setID(varianceSwapTransactionSupplementIDRef_,varianceSwapTransactionSupplement_);
          }
          else if(varianceSwapTransactionSupplementNode->Attribute("href")) { varianceSwapTransactionSupplementIDRef_ = varianceSwapTransactionSupplementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { varianceSwapTransactionSupplement_ = boost::shared_ptr<VarianceSwapTransactionSupplement>(new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode));}
   }

   //otherPartyPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* otherPartyPaymentNode = xmlNode->FirstChildElement("otherPartyPayment");

   if(otherPartyPaymentNode){otherPartyPaymentIsNull_ = false;}
   else{otherPartyPaymentIsNull_ = true;}

   if(otherPartyPaymentNode)
   {
      for(otherPartyPaymentNode; otherPartyPaymentNode; otherPartyPaymentNode = otherPartyPaymentNode->NextSiblingElement("otherPartyPayment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherPartyPaymentNode , address : " << otherPartyPaymentNode << std::endl;
          #endif
          if(otherPartyPaymentNode->Attribute("href") || otherPartyPaymentNode->Attribute("id"))
          {
              if(otherPartyPaymentNode->Attribute("id"))
              {
                  otherPartyPaymentIDRef_ = otherPartyPaymentNode->Attribute("id");
                  otherPartyPayment_.push_back(boost::shared_ptr<Payment>(new Payment(otherPartyPaymentNode)));
                  otherPartyPayment_.back()->setID(otherPartyPaymentIDRef_);
                  IDManager::instance().setID(otherPartyPaymentIDRef_, otherPartyPayment_.back());
              }
              else if(otherPartyPaymentNode->Attribute("href")) { otherPartyPaymentIDRef_ = otherPartyPaymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { otherPartyPayment_.push_back(boost::shared_ptr<Payment>(new Payment(otherPartyPaymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherPartyPaymentNode , address : " << otherPartyPaymentNode << std::endl;
       #endif
   }

   //brokerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brokerPartyReferenceNode = xmlNode->FirstChildElement("brokerPartyReference");

   if(brokerPartyReferenceNode){brokerPartyReferenceIsNull_ = false;}
   else{brokerPartyReferenceIsNull_ = true;}

   if(brokerPartyReferenceNode)
   {
      for(brokerPartyReferenceNode; brokerPartyReferenceNode; brokerPartyReferenceNode = brokerPartyReferenceNode->NextSiblingElement("brokerPartyReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brokerPartyReferenceNode , address : " << brokerPartyReferenceNode << std::endl;
          #endif
          if(brokerPartyReferenceNode->Attribute("href") || brokerPartyReferenceNode->Attribute("id"))
          {
              if(brokerPartyReferenceNode->Attribute("id"))
              {
                  brokerPartyReferenceIDRef_ = brokerPartyReferenceNode->Attribute("id");
                  brokerPartyReference_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(brokerPartyReferenceNode)));
                  brokerPartyReference_.back()->setID(brokerPartyReferenceIDRef_);
                  IDManager::instance().setID(brokerPartyReferenceIDRef_, brokerPartyReference_.back());
              }
              else if(brokerPartyReferenceNode->Attribute("href")) { brokerPartyReferenceIDRef_ = brokerPartyReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { brokerPartyReference_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(brokerPartyReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brokerPartyReferenceNode , address : " << brokerPartyReferenceNode << std::endl;
       #endif
   }

   //calculationAgentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentNode = xmlNode->FirstChildElement("calculationAgent");

   if(calculationAgentNode){calculationAgentIsNull_ = false;}
   else{calculationAgentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentNode , address : " << calculationAgentNode << std::endl;
   #endif
   if(calculationAgentNode)
   {
      if(calculationAgentNode->Attribute("href") || calculationAgentNode->Attribute("id"))
      {
          if(calculationAgentNode->Attribute("id"))
          {
             calculationAgentIDRef_ = calculationAgentNode->Attribute("id");
             calculationAgent_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentNode));
             calculationAgent_->setID(calculationAgentIDRef_);
             IDManager::instance().setID(calculationAgentIDRef_,calculationAgent_);
          }
          else if(calculationAgentNode->Attribute("href")) { calculationAgentIDRef_ = calculationAgentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAgent_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentNode));}
   }

   //calculationAgentBusinessCenterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentBusinessCenterNode = xmlNode->FirstChildElement("calculationAgentBusinessCenter");

   if(calculationAgentBusinessCenterNode){calculationAgentBusinessCenterIsNull_ = false;}
   else{calculationAgentBusinessCenterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentBusinessCenterNode , address : " << calculationAgentBusinessCenterNode << std::endl;
   #endif
   if(calculationAgentBusinessCenterNode)
   {
      if(calculationAgentBusinessCenterNode->Attribute("href") || calculationAgentBusinessCenterNode->Attribute("id"))
      {
          if(calculationAgentBusinessCenterNode->Attribute("id"))
          {
             calculationAgentBusinessCenterIDRef_ = calculationAgentBusinessCenterNode->Attribute("id");
             calculationAgentBusinessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(calculationAgentBusinessCenterNode));
             calculationAgentBusinessCenter_->setID(calculationAgentBusinessCenterIDRef_);
             IDManager::instance().setID(calculationAgentBusinessCenterIDRef_,calculationAgentBusinessCenter_);
          }
          else if(calculationAgentBusinessCenterNode->Attribute("href")) { calculationAgentBusinessCenterIDRef_ = calculationAgentBusinessCenterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAgentBusinessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(calculationAgentBusinessCenterNode));}
   }

   //determiningPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determiningPartyNode = xmlNode->FirstChildElement("determiningParty");

   if(determiningPartyNode){determiningPartyIsNull_ = false;}
   else{determiningPartyIsNull_ = true;}

   if(determiningPartyNode)
   {
      for(determiningPartyNode; determiningPartyNode; determiningPartyNode = determiningPartyNode->NextSiblingElement("determiningParty")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determiningPartyNode , address : " << determiningPartyNode << std::endl;
          #endif
          if(determiningPartyNode->Attribute("href") || determiningPartyNode->Attribute("id"))
          {
              if(determiningPartyNode->Attribute("id"))
              {
                  determiningPartyIDRef_ = determiningPartyNode->Attribute("id");
                  determiningParty_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(determiningPartyNode)));
                  determiningParty_.back()->setID(determiningPartyIDRef_);
                  IDManager::instance().setID(determiningPartyIDRef_, determiningParty_.back());
              }
              else if(determiningPartyNode->Attribute("href")) { determiningPartyIDRef_ = determiningPartyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { determiningParty_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(determiningPartyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determiningPartyNode , address : " << determiningPartyNode << std::endl;
       #endif
   }

   //hedgingPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hedgingPartyNode = xmlNode->FirstChildElement("hedgingParty");

   if(hedgingPartyNode){hedgingPartyIsNull_ = false;}
   else{hedgingPartyIsNull_ = true;}

   if(hedgingPartyNode)
   {
      for(hedgingPartyNode; hedgingPartyNode; hedgingPartyNode = hedgingPartyNode->NextSiblingElement("hedgingParty")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hedgingPartyNode , address : " << hedgingPartyNode << std::endl;
          #endif
          if(hedgingPartyNode->Attribute("href") || hedgingPartyNode->Attribute("id"))
          {
              if(hedgingPartyNode->Attribute("id"))
              {
                  hedgingPartyIDRef_ = hedgingPartyNode->Attribute("id");
                  hedgingParty_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(hedgingPartyNode)));
                  hedgingParty_.back()->setID(hedgingPartyIDRef_);
                  IDManager::instance().setID(hedgingPartyIDRef_, hedgingParty_.back());
              }
              else if(hedgingPartyNode->Attribute("href")) { hedgingPartyIDRef_ = hedgingPartyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { hedgingParty_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(hedgingPartyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hedgingPartyNode , address : " << hedgingPartyNode << std::endl;
       #endif
   }

   //collateralNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* collateralNode = xmlNode->FirstChildElement("collateral");

   if(collateralNode){collateralIsNull_ = false;}
   else{collateralIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- collateralNode , address : " << collateralNode << std::endl;
   #endif
   if(collateralNode)
   {
      if(collateralNode->Attribute("href") || collateralNode->Attribute("id"))
      {
          if(collateralNode->Attribute("id"))
          {
             collateralIDRef_ = collateralNode->Attribute("id");
             collateral_ = boost::shared_ptr<Collateral>(new Collateral(collateralNode));
             collateral_->setID(collateralIDRef_);
             IDManager::instance().setID(collateralIDRef_,collateral_);
          }
          else if(collateralNode->Attribute("href")) { collateralIDRef_ = collateralNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { collateral_ = boost::shared_ptr<Collateral>(new Collateral(collateralNode));}
   }

   //documentationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* documentationNode = xmlNode->FirstChildElement("documentation");

   if(documentationNode){documentationIsNull_ = false;}
   else{documentationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- documentationNode , address : " << documentationNode << std::endl;
   #endif
   if(documentationNode)
   {
      if(documentationNode->Attribute("href") || documentationNode->Attribute("id"))
      {
          if(documentationNode->Attribute("id"))
          {
             documentationIDRef_ = documentationNode->Attribute("id");
             documentation_ = boost::shared_ptr<Documentation>(new Documentation(documentationNode));
             documentation_->setID(documentationIDRef_);
             IDManager::instance().setID(documentationIDRef_,documentation_);
          }
          else if(documentationNode->Attribute("href")) { documentationIDRef_ = documentationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { documentation_ = boost::shared_ptr<Documentation>(new Documentation(documentationNode));}
   }

   //governingLawNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* governingLawNode = xmlNode->FirstChildElement("governingLaw");

   if(governingLawNode){governingLawIsNull_ = false;}
   else{governingLawIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- governingLawNode , address : " << governingLawNode << std::endl;
   #endif
   if(governingLawNode)
   {
      if(governingLawNode->Attribute("href") || governingLawNode->Attribute("id"))
      {
          if(governingLawNode->Attribute("id"))
          {
             governingLawIDRef_ = governingLawNode->Attribute("id");
             governingLaw_ = boost::shared_ptr<GoverningLaw>(new GoverningLaw(governingLawNode));
             governingLaw_->setID(governingLawIDRef_);
             IDManager::instance().setID(governingLawIDRef_,governingLaw_);
          }
          else if(governingLawNode->Attribute("href")) { governingLawIDRef_ = governingLawNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { governingLaw_ = boost::shared_ptr<GoverningLaw>(new GoverningLaw(governingLawNode));}
   }

   //allocationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationsNode = xmlNode->FirstChildElement("allocations");

   if(allocationsNode){allocationsIsNull_ = false;}
   else{allocationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationsNode , address : " << allocationsNode << std::endl;
   #endif
   if(allocationsNode)
   {
      if(allocationsNode->Attribute("href") || allocationsNode->Attribute("id"))
      {
          if(allocationsNode->Attribute("id"))
          {
             allocationsIDRef_ = allocationsNode->Attribute("id");
             allocations_ = boost::shared_ptr<Allocations>(new Allocations(allocationsNode));
             allocations_->setID(allocationsIDRef_);
             IDManager::instance().setID(allocationsIDRef_,allocations_);
          }
          else if(allocationsNode->Attribute("href")) { allocationsIDRef_ = allocationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allocations_ = boost::shared_ptr<Allocations>(new Allocations(allocationsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TradeHeader> Trade::getTradeHeader()
{
   if(!this->tradeHeaderIsNull_){
        if(tradeHeaderIDRef_ != ""){
             return boost::shared_static_cast<TradeHeader>(IDManager::instance().getID(tradeHeaderIDRef_));
        }else{
             return this->tradeHeader_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeHeader>();
   }
}
boost::shared_ptr<Product> Trade::getProduct()
{
   if(!this->productIsNull_){
        if(productIDRef_ != ""){
             return boost::shared_static_cast<Product>(IDManager::instance().getID(productIDRef_));
        }else{
             return this->product_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Product>();
   }
}
boost::shared_ptr<ForwardSale> Trade::getForward()
{
   if(!this->forwardIsNull_){
        if(forwardIDRef_ != ""){
             return boost::shared_static_cast<ForwardSale>(IDManager::instance().getID(forwardIDRef_));
        }else{
             return this->forward_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ForwardSale>();
   }
}
boost::shared_ptr<BondOption> Trade::getBondOption()
{
   if(!this->bondOptionIsNull_){
        if(bondOptionIDRef_ != ""){
             return boost::shared_static_cast<BondOption>(IDManager::instance().getID(bondOptionIDRef_));
        }else{
             return this->bondOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BondOption>();
   }
}
boost::shared_ptr<CreditDefaultSwap> Trade::getCreditDefaultSwap()
{
   if(!this->creditDefaultSwapIsNull_){
        if(creditDefaultSwapIDRef_ != ""){
             return boost::shared_static_cast<CreditDefaultSwap>(IDManager::instance().getID(creditDefaultSwapIDRef_));
        }else{
             return this->creditDefaultSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditDefaultSwap>();
   }
}
boost::shared_ptr<CreditDefaultSwapOption> Trade::getCreditDefaultSwapOption()
{
   if(!this->creditDefaultSwapOptionIsNull_){
        if(creditDefaultSwapOptionIDRef_ != ""){
             return boost::shared_static_cast<CreditDefaultSwapOption>(IDManager::instance().getID(creditDefaultSwapOptionIDRef_));
        }else{
             return this->creditDefaultSwapOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditDefaultSwapOption>();
   }
}
boost::shared_ptr<CommodityForward> Trade::getCommodityForward()
{
   if(!this->commodityForwardIsNull_){
        if(commodityForwardIDRef_ != ""){
             return boost::shared_static_cast<CommodityForward>(IDManager::instance().getID(commodityForwardIDRef_));
        }else{
             return this->commodityForward_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityForward>();
   }
}
boost::shared_ptr<CommodityOption> Trade::getCommodityOption()
{
   if(!this->commodityOptionIsNull_){
        if(commodityOptionIDRef_ != ""){
             return boost::shared_static_cast<CommodityOption>(IDManager::instance().getID(commodityOptionIDRef_));
        }else{
             return this->commodityOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityOption>();
   }
}
boost::shared_ptr<CommoditySwap> Trade::getCommoditySwap()
{
   if(!this->commoditySwapIsNull_){
        if(commoditySwapIDRef_ != ""){
             return boost::shared_static_cast<CommoditySwap>(IDManager::instance().getID(commoditySwapIDRef_));
        }else{
             return this->commoditySwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommoditySwap>();
   }
}
boost::shared_ptr<CommoditySwaption> Trade::getCommoditySwaption()
{
   if(!this->commoditySwaptionIsNull_){
        if(commoditySwaptionIDRef_ != ""){
             return boost::shared_static_cast<CommoditySwaption>(IDManager::instance().getID(commoditySwaptionIDRef_));
        }else{
             return this->commoditySwaption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommoditySwaption>();
   }
}
boost::shared_ptr<CorrelationSwap> Trade::getCorrelationSwap()
{
   if(!this->correlationSwapIsNull_){
        if(correlationSwapIDRef_ != ""){
             return boost::shared_static_cast<CorrelationSwap>(IDManager::instance().getID(correlationSwapIDRef_));
        }else{
             return this->correlationSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationSwap>();
   }
}
boost::shared_ptr<DividendSwapOptionTransactionSupplement> Trade::getDividendSwapOptionTransactionSupplement()
{
   if(!this->dividendSwapOptionTransactionSupplementIsNull_){
        if(dividendSwapOptionTransactionSupplementIDRef_ != ""){
             return boost::shared_static_cast<DividendSwapOptionTransactionSupplement>(IDManager::instance().getID(dividendSwapOptionTransactionSupplementIDRef_));
        }else{
             return this->dividendSwapOptionTransactionSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendSwapOptionTransactionSupplement>();
   }
}
boost::shared_ptr<DividendSwapTransactionSupplement> Trade::getDividendSwapTransactionSupplement()
{
   if(!this->dividendSwapTransactionSupplementIsNull_){
        if(dividendSwapTransactionSupplementIDRef_ != ""){
             return boost::shared_static_cast<DividendSwapTransactionSupplement>(IDManager::instance().getID(dividendSwapTransactionSupplementIDRef_));
        }else{
             return this->dividendSwapTransactionSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendSwapTransactionSupplement>();
   }
}
boost::shared_ptr<InstrumentTradeDetails> Trade::getInstrumentTradeDetails()
{
   if(!this->instrumentTradeDetailsIsNull_){
        if(instrumentTradeDetailsIDRef_ != ""){
             return boost::shared_static_cast<InstrumentTradeDetails>(IDManager::instance().getID(instrumentTradeDetailsIDRef_));
        }else{
             return this->instrumentTradeDetails_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InstrumentTradeDetails>();
   }
}
boost::shared_ptr<Strategy> Trade::getStrategy()
{
   if(!this->strategyIsNull_){
        if(strategyIDRef_ != ""){
             return boost::shared_static_cast<Strategy>(IDManager::instance().getID(strategyIDRef_));
        }else{
             return this->strategy_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Strategy>();
   }
}
boost::shared_ptr<ReturnSwap> Trade::getReturnSwap()
{
   if(!this->returnSwapIsNull_){
        if(returnSwapIDRef_ != ""){
             return boost::shared_static_cast<ReturnSwap>(IDManager::instance().getID(returnSwapIDRef_));
        }else{
             return this->returnSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnSwap>();
   }
}
boost::shared_ptr<BrokerEquityOption> Trade::getBrokerEquityOption()
{
   if(!this->brokerEquityOptionIsNull_){
        if(brokerEquityOptionIDRef_ != ""){
             return boost::shared_static_cast<BrokerEquityOption>(IDManager::instance().getID(brokerEquityOptionIDRef_));
        }else{
             return this->brokerEquityOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BrokerEquityOption>();
   }
}
boost::shared_ptr<EquityForward> Trade::getEquityForward()
{
   if(!this->equityForwardIsNull_){
        if(equityForwardIDRef_ != ""){
             return boost::shared_static_cast<EquityForward>(IDManager::instance().getID(equityForwardIDRef_));
        }else{
             return this->equityForward_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityForward>();
   }
}
boost::shared_ptr<EquityOption> Trade::getEquityOption()
{
   if(!this->equityOptionIsNull_){
        if(equityOptionIDRef_ != ""){
             return boost::shared_static_cast<EquityOption>(IDManager::instance().getID(equityOptionIDRef_));
        }else{
             return this->equityOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityOption>();
   }
}
boost::shared_ptr<EquityOptionTransactionSupplement> Trade::getEquityOptionTransactionSupplement()
{
   if(!this->equityOptionTransactionSupplementIsNull_){
        if(equityOptionTransactionSupplementIDRef_ != ""){
             return boost::shared_static_cast<EquityOptionTransactionSupplement>(IDManager::instance().getID(equityOptionTransactionSupplementIDRef_));
        }else{
             return this->equityOptionTransactionSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquityOptionTransactionSupplement>();
   }
}
boost::shared_ptr<FxSingleLeg> Trade::getFxSingleLeg()
{
   if(!this->fxSingleLegIsNull_){
        if(fxSingleLegIDRef_ != ""){
             return boost::shared_static_cast<FxSingleLeg>(IDManager::instance().getID(fxSingleLegIDRef_));
        }else{
             return this->fxSingleLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSingleLeg>();
   }
}
boost::shared_ptr<FxSwap> Trade::getFxSwap()
{
   if(!this->fxSwapIsNull_){
        if(fxSwapIDRef_ != ""){
             return boost::shared_static_cast<FxSwap>(IDManager::instance().getID(fxSwapIDRef_));
        }else{
             return this->fxSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxSwap>();
   }
}
boost::shared_ptr<FxOption> Trade::getFxOption()
{
   if(!this->fxOptionIsNull_){
        if(fxOptionIDRef_ != ""){
             return boost::shared_static_cast<FxOption>(IDManager::instance().getID(fxOptionIDRef_));
        }else{
             return this->fxOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxOption>();
   }
}
boost::shared_ptr<FxDigitalOption> Trade::getFxDigitalOption()
{
   if(!this->fxDigitalOptionIsNull_){
        if(fxDigitalOptionIDRef_ != ""){
             return boost::shared_static_cast<FxDigitalOption>(IDManager::instance().getID(fxDigitalOptionIDRef_));
        }else{
             return this->fxDigitalOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxDigitalOption>();
   }
}
boost::shared_ptr<TermDeposit> Trade::getTermDeposit()
{
   if(!this->termDepositIsNull_){
        if(termDepositIDRef_ != ""){
             return boost::shared_static_cast<TermDeposit>(IDManager::instance().getID(termDepositIDRef_));
        }else{
             return this->termDeposit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TermDeposit>();
   }
}
boost::shared_ptr<GenericProduct> Trade::getGenericProduct()
{
   if(!this->genericProductIsNull_){
        if(genericProductIDRef_ != ""){
             return boost::shared_static_cast<GenericProduct>(IDManager::instance().getID(genericProductIDRef_));
        }else{
             return this->genericProduct_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GenericProduct>();
   }
}
boost::shared_ptr<GenericProduct> Trade::getNonSchemaProduct()
{
   if(!this->nonSchemaProductIsNull_){
        if(nonSchemaProductIDRef_ != ""){
             return boost::shared_static_cast<GenericProduct>(IDManager::instance().getID(nonSchemaProductIDRef_));
        }else{
             return this->nonSchemaProduct_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GenericProduct>();
   }
}
boost::shared_ptr<BulletPayment> Trade::getBulletPayment()
{
   if(!this->bulletPaymentIsNull_){
        if(bulletPaymentIDRef_ != ""){
             return boost::shared_static_cast<BulletPayment>(IDManager::instance().getID(bulletPaymentIDRef_));
        }else{
             return this->bulletPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BulletPayment>();
   }
}
boost::shared_ptr<CapFloor> Trade::getCapFloor()
{
   if(!this->capFloorIsNull_){
        if(capFloorIDRef_ != ""){
             return boost::shared_static_cast<CapFloor>(IDManager::instance().getID(capFloorIDRef_));
        }else{
             return this->capFloor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CapFloor>();
   }
}
boost::shared_ptr<Fra> Trade::getFra()
{
   if(!this->fraIsNull_){
        if(fraIDRef_ != ""){
             return boost::shared_static_cast<Fra>(IDManager::instance().getID(fraIDRef_));
        }else{
             return this->fra_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Fra>();
   }
}
boost::shared_ptr<Swap> Trade::getSwap()
{
   if(!this->swapIsNull_){
        if(swapIDRef_ != ""){
             return boost::shared_static_cast<Swap>(IDManager::instance().getID(swapIDRef_));
        }else{
             return this->swap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Swap>();
   }
}
boost::shared_ptr<Swaption> Trade::getSwaption()
{
   if(!this->swaptionIsNull_){
        if(swaptionIDRef_ != ""){
             return boost::shared_static_cast<Swaption>(IDManager::instance().getID(swaptionIDRef_));
        }else{
             return this->swaption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Swaption>();
   }
}
boost::shared_ptr<EquitySwapTransactionSupplement> Trade::getEquitySwapTransactionSupplement()
{
   if(!this->equitySwapTransactionSupplementIsNull_){
        if(equitySwapTransactionSupplementIDRef_ != ""){
             return boost::shared_static_cast<EquitySwapTransactionSupplement>(IDManager::instance().getID(equitySwapTransactionSupplementIDRef_));
        }else{
             return this->equitySwapTransactionSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EquitySwapTransactionSupplement>();
   }
}
boost::shared_ptr<StandardProduct> Trade::getStandardProduct()
{
   if(!this->standardProductIsNull_){
        if(standardProductIDRef_ != ""){
             return boost::shared_static_cast<StandardProduct>(IDManager::instance().getID(standardProductIDRef_));
        }else{
             return this->standardProduct_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StandardProduct>();
   }
}
boost::shared_ptr<VarianceOptionTransactionSupplement> Trade::getVarianceOptionTransactionSupplement()
{
   if(!this->varianceOptionTransactionSupplementIsNull_){
        if(varianceOptionTransactionSupplementIDRef_ != ""){
             return boost::shared_static_cast<VarianceOptionTransactionSupplement>(IDManager::instance().getID(varianceOptionTransactionSupplementIDRef_));
        }else{
             return this->varianceOptionTransactionSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VarianceOptionTransactionSupplement>();
   }
}
boost::shared_ptr<VarianceSwap> Trade::getVarianceSwap()
{
   if(!this->varianceSwapIsNull_){
        if(varianceSwapIDRef_ != ""){
             return boost::shared_static_cast<VarianceSwap>(IDManager::instance().getID(varianceSwapIDRef_));
        }else{
             return this->varianceSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VarianceSwap>();
   }
}
boost::shared_ptr<VarianceSwapTransactionSupplement> Trade::getVarianceSwapTransactionSupplement()
{
   if(!this->varianceSwapTransactionSupplementIsNull_){
        if(varianceSwapTransactionSupplementIDRef_ != ""){
             return boost::shared_static_cast<VarianceSwapTransactionSupplement>(IDManager::instance().getID(varianceSwapTransactionSupplementIDRef_));
        }else{
             return this->varianceSwapTransactionSupplement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VarianceSwapTransactionSupplement>();
   }
}
std::vector<boost::shared_ptr<Payment>> Trade::getOtherPartyPayment()
{
   if(!this->otherPartyPaymentIsNull_){
        if(otherPartyPaymentIDRef_ != ""){
             return this->otherPartyPayment_;
        }else{
             return this->otherPartyPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Payment>>();
   }
}
std::vector<boost::shared_ptr<PartyReference>> Trade::getBrokerPartyReference()
{
   if(!this->brokerPartyReferenceIsNull_){
        if(brokerPartyReferenceIDRef_ != ""){
             return this->brokerPartyReference_;
        }else{
             return this->brokerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyReference>>();
   }
}
boost::shared_ptr<CalculationAgent> Trade::getCalculationAgent()
{
   if(!this->calculationAgentIsNull_){
        if(calculationAgentIDRef_ != ""){
             return boost::shared_static_cast<CalculationAgent>(IDManager::instance().getID(calculationAgentIDRef_));
        }else{
             return this->calculationAgent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAgent>();
   }
}
boost::shared_ptr<BusinessCenter> Trade::getCalculationAgentBusinessCenter()
{
   if(!this->calculationAgentBusinessCenterIsNull_){
        if(calculationAgentBusinessCenterIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(calculationAgentBusinessCenterIDRef_));
        }else{
             return this->calculationAgentBusinessCenter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
std::vector<boost::shared_ptr<PartyReference>> Trade::getDeterminingParty()
{
   if(!this->determiningPartyIsNull_){
        if(determiningPartyIDRef_ != ""){
             return this->determiningParty_;
        }else{
             return this->determiningParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyReference>>();
   }
}
std::vector<boost::shared_ptr<PartyReference>> Trade::getHedgingParty()
{
   if(!this->hedgingPartyIsNull_){
        if(hedgingPartyIDRef_ != ""){
             return this->hedgingParty_;
        }else{
             return this->hedgingParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyReference>>();
   }
}
boost::shared_ptr<Collateral> Trade::getCollateral()
{
   if(!this->collateralIsNull_){
        if(collateralIDRef_ != ""){
             return boost::shared_static_cast<Collateral>(IDManager::instance().getID(collateralIDRef_));
        }else{
             return this->collateral_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Collateral>();
   }
}
boost::shared_ptr<Documentation> Trade::getDocumentation()
{
   if(!this->documentationIsNull_){
        if(documentationIDRef_ != ""){
             return boost::shared_static_cast<Documentation>(IDManager::instance().getID(documentationIDRef_));
        }else{
             return this->documentation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Documentation>();
   }
}
boost::shared_ptr<GoverningLaw> Trade::getGoverningLaw()
{
   if(!this->governingLawIsNull_){
        if(governingLawIDRef_ != ""){
             return boost::shared_static_cast<GoverningLaw>(IDManager::instance().getID(governingLawIDRef_));
        }else{
             return this->governingLaw_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GoverningLaw>();
   }
}
boost::shared_ptr<Allocations> Trade::getAllocations()
{
   if(!this->allocationsIsNull_){
        if(allocationsIDRef_ != ""){
             return boost::shared_static_cast<Allocations>(IDManager::instance().getID(allocationsIDRef_));
        }else{
             return this->allocations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Allocations>();
   }
}
}

