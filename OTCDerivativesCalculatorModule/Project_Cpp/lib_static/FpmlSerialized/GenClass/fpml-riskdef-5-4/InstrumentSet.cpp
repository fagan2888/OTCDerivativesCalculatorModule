// InstrumentSet.cpp 
#include "InstrumentSet.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentSet::InstrumentSet(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //curveInstrumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* curveInstrumentNode = xmlNode->FirstChildElement("curveInstrument");

   if(curveInstrumentNode){curveInstrumentIsNull_ = false;}
   else{curveInstrumentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- curveInstrumentNode , address : " << curveInstrumentNode << std::endl;
   #endif
   if(curveInstrumentNode)
   {
      if(curveInstrumentNode->Attribute("href") || curveInstrumentNode->Attribute("id"))
      {
          if(curveInstrumentNode->Attribute("id"))
          {
             curveInstrumentIDRef_ = curveInstrumentNode->Attribute("id");
             curveInstrument_ = boost::shared_ptr<Asset>(new Asset(curveInstrumentNode));
             curveInstrument_->setID(curveInstrumentIDRef_);
             IDManager::instance().setID(curveInstrumentIDRef_,curveInstrument_);
          }
          else if(curveInstrumentNode->Attribute("href")) { curveInstrumentIDRef_ = curveInstrumentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { curveInstrument_ = boost::shared_ptr<Asset>(new Asset(curveInstrumentNode));}
   }

   //depositNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* depositNode = xmlNode->FirstChildElement("deposit");

   if(depositNode){depositIsNull_ = false;}
   else{depositIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- depositNode , address : " << depositNode << std::endl;
   #endif
   if(depositNode)
   {
      if(depositNode->Attribute("href") || depositNode->Attribute("id"))
      {
          if(depositNode->Attribute("id"))
          {
             depositIDRef_ = depositNode->Attribute("id");
             deposit_ = boost::shared_ptr<Deposit>(new Deposit(depositNode));
             deposit_->setID(depositIDRef_);
             IDManager::instance().setID(depositIDRef_,deposit_);
          }
          else if(depositNode->Attribute("href")) { depositIDRef_ = depositNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deposit_ = boost::shared_ptr<Deposit>(new Deposit(depositNode));}
   }

   //fxNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxNode = xmlNode->FirstChildElement("fx");

   if(fxNode){fxIsNull_ = false;}
   else{fxIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxNode , address : " << fxNode << std::endl;
   #endif
   if(fxNode)
   {
      if(fxNode->Attribute("href") || fxNode->Attribute("id"))
      {
          if(fxNode->Attribute("id"))
          {
             fxIDRef_ = fxNode->Attribute("id");
             fx_ = boost::shared_ptr<FxRateAsset>(new FxRateAsset(fxNode));
             fx_->setID(fxIDRef_);
             IDManager::instance().setID(fxIDRef_,fx_);
          }
          else if(fxNode->Attribute("href")) { fxIDRef_ = fxNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fx_ = boost::shared_ptr<FxRateAsset>(new FxRateAsset(fxNode));}
   }

   //rateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateIndexNode = xmlNode->FirstChildElement("rateIndex");

   if(rateIndexNode){rateIndexIsNull_ = false;}
   else{rateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateIndexNode , address : " << rateIndexNode << std::endl;
   #endif
   if(rateIndexNode)
   {
      if(rateIndexNode->Attribute("href") || rateIndexNode->Attribute("id"))
      {
          if(rateIndexNode->Attribute("id"))
          {
             rateIndexIDRef_ = rateIndexNode->Attribute("id");
             rateIndex_ = boost::shared_ptr<RateIndex>(new RateIndex(rateIndexNode));
             rateIndex_->setID(rateIndexIDRef_);
             IDManager::instance().setID(rateIndexIDRef_,rateIndex_);
          }
          else if(rateIndexNode->Attribute("href")) { rateIndexIDRef_ = rateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateIndex_ = boost::shared_ptr<RateIndex>(new RateIndex(rateIndexNode));}
   }

   //simpleCreditDefaultSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleCreditDefaultSwapNode = xmlNode->FirstChildElement("simpleCreditDefaultSwap");

   if(simpleCreditDefaultSwapNode){simpleCreditDefaultSwapIsNull_ = false;}
   else{simpleCreditDefaultSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleCreditDefaultSwapNode , address : " << simpleCreditDefaultSwapNode << std::endl;
   #endif
   if(simpleCreditDefaultSwapNode)
   {
      if(simpleCreditDefaultSwapNode->Attribute("href") || simpleCreditDefaultSwapNode->Attribute("id"))
      {
          if(simpleCreditDefaultSwapNode->Attribute("id"))
          {
             simpleCreditDefaultSwapIDRef_ = simpleCreditDefaultSwapNode->Attribute("id");
             simpleCreditDefaultSwap_ = boost::shared_ptr<SimpleCreditDefaultSwap>(new SimpleCreditDefaultSwap(simpleCreditDefaultSwapNode));
             simpleCreditDefaultSwap_->setID(simpleCreditDefaultSwapIDRef_);
             IDManager::instance().setID(simpleCreditDefaultSwapIDRef_,simpleCreditDefaultSwap_);
          }
          else if(simpleCreditDefaultSwapNode->Attribute("href")) { simpleCreditDefaultSwapIDRef_ = simpleCreditDefaultSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { simpleCreditDefaultSwap_ = boost::shared_ptr<SimpleCreditDefaultSwap>(new SimpleCreditDefaultSwap(simpleCreditDefaultSwapNode));}
   }

   //simpleFraNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleFraNode = xmlNode->FirstChildElement("simpleFra");

   if(simpleFraNode){simpleFraIsNull_ = false;}
   else{simpleFraIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleFraNode , address : " << simpleFraNode << std::endl;
   #endif
   if(simpleFraNode)
   {
      if(simpleFraNode->Attribute("href") || simpleFraNode->Attribute("id"))
      {
          if(simpleFraNode->Attribute("id"))
          {
             simpleFraIDRef_ = simpleFraNode->Attribute("id");
             simpleFra_ = boost::shared_ptr<SimpleFra>(new SimpleFra(simpleFraNode));
             simpleFra_->setID(simpleFraIDRef_);
             IDManager::instance().setID(simpleFraIDRef_,simpleFra_);
          }
          else if(simpleFraNode->Attribute("href")) { simpleFraIDRef_ = simpleFraNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { simpleFra_ = boost::shared_ptr<SimpleFra>(new SimpleFra(simpleFraNode));}
   }

   //simpleIrSwapNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleIrSwapNode = xmlNode->FirstChildElement("simpleIrSwap");

   if(simpleIrSwapNode){simpleIrSwapIsNull_ = false;}
   else{simpleIrSwapIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleIrSwapNode , address : " << simpleIrSwapNode << std::endl;
   #endif
   if(simpleIrSwapNode)
   {
      if(simpleIrSwapNode->Attribute("href") || simpleIrSwapNode->Attribute("id"))
      {
          if(simpleIrSwapNode->Attribute("id"))
          {
             simpleIrSwapIDRef_ = simpleIrSwapNode->Attribute("id");
             simpleIrSwap_ = boost::shared_ptr<SimpleIRSwap>(new SimpleIRSwap(simpleIrSwapNode));
             simpleIrSwap_->setID(simpleIrSwapIDRef_);
             IDManager::instance().setID(simpleIrSwapIDRef_,simpleIrSwap_);
          }
          else if(simpleIrSwapNode->Attribute("href")) { simpleIrSwapIDRef_ = simpleIrSwapNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { simpleIrSwap_ = boost::shared_ptr<SimpleIRSwap>(new SimpleIRSwap(simpleIrSwapNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Asset> InstrumentSet::getUnderlyingAsset()
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
boost::shared_ptr<Basket> InstrumentSet::getBasket()
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
boost::shared_ptr<Bond> InstrumentSet::getBond()
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
boost::shared_ptr<Cash> InstrumentSet::getCash()
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
boost::shared_ptr<Commodity> InstrumentSet::getCommodity()
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
boost::shared_ptr<ConvertibleBond> InstrumentSet::getConvertibleBond()
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
boost::shared_ptr<EquityAsset> InstrumentSet::getEquity()
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
boost::shared_ptr<ExchangeTradedFund> InstrumentSet::getExchangeTradedFund()
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
boost::shared_ptr<Future> InstrumentSet::getFuture()
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
boost::shared_ptr<Index> InstrumentSet::getIndex()
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
boost::shared_ptr<Loan> InstrumentSet::getLoan()
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
boost::shared_ptr<Mortgage> InstrumentSet::getMortgage()
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
boost::shared_ptr<MutualFund> InstrumentSet::getMutualFund()
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
boost::shared_ptr<Asset> InstrumentSet::getCurveInstrument()
{
   if(!this->curveInstrumentIsNull_){
        if(curveInstrumentIDRef_ != ""){
             return boost::shared_static_cast<Asset>(IDManager::instance().getID(curveInstrumentIDRef_));
        }else{
             return this->curveInstrument_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Asset>();
   }
}
boost::shared_ptr<Deposit> InstrumentSet::getDeposit()
{
   if(!this->depositIsNull_){
        if(depositIDRef_ != ""){
             return boost::shared_static_cast<Deposit>(IDManager::instance().getID(depositIDRef_));
        }else{
             return this->deposit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Deposit>();
   }
}
boost::shared_ptr<FxRateAsset> InstrumentSet::getFx()
{
   if(!this->fxIsNull_){
        if(fxIDRef_ != ""){
             return boost::shared_static_cast<FxRateAsset>(IDManager::instance().getID(fxIDRef_));
        }else{
             return this->fx_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxRateAsset>();
   }
}
boost::shared_ptr<RateIndex> InstrumentSet::getRateIndex()
{
   if(!this->rateIndexIsNull_){
        if(rateIndexIDRef_ != ""){
             return boost::shared_static_cast<RateIndex>(IDManager::instance().getID(rateIndexIDRef_));
        }else{
             return this->rateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RateIndex>();
   }
}
boost::shared_ptr<SimpleCreditDefaultSwap> InstrumentSet::getSimpleCreditDefaultSwap()
{
   if(!this->simpleCreditDefaultSwapIsNull_){
        if(simpleCreditDefaultSwapIDRef_ != ""){
             return boost::shared_static_cast<SimpleCreditDefaultSwap>(IDManager::instance().getID(simpleCreditDefaultSwapIDRef_));
        }else{
             return this->simpleCreditDefaultSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleCreditDefaultSwap>();
   }
}
boost::shared_ptr<SimpleFra> InstrumentSet::getSimpleFra()
{
   if(!this->simpleFraIsNull_){
        if(simpleFraIDRef_ != ""){
             return boost::shared_static_cast<SimpleFra>(IDManager::instance().getID(simpleFraIDRef_));
        }else{
             return this->simpleFra_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleFra>();
   }
}
boost::shared_ptr<SimpleIRSwap> InstrumentSet::getSimpleIrSwap()
{
   if(!this->simpleIrSwapIsNull_){
        if(simpleIrSwapIDRef_ != ""){
             return boost::shared_static_cast<SimpleIRSwap>(IDManager::instance().getID(simpleIrSwapIDRef_));
        }else{
             return this->simpleIrSwap_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleIRSwap>();
   }
}
}

