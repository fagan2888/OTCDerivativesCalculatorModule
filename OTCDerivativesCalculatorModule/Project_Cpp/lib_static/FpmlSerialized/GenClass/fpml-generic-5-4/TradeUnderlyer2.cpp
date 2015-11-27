// TradeUnderlyer2.cpp 
#include "TradeUnderlyer2.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeUnderlyer2::TradeUnderlyer2(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //floatingRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateNode = xmlNode->FirstChildElement("floatingRate");

   if(floatingRateNode){floatingRateIsNull_ = false;}
   else{floatingRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateNode , address : " << floatingRateNode << std::endl;
   #endif
   if(floatingRateNode)
   {
      if(floatingRateNode->Attribute("href") || floatingRateNode->Attribute("id"))
      {
          if(floatingRateNode->Attribute("id"))
          {
             floatingRateIDRef_ = floatingRateNode->Attribute("id");
             floatingRate_ = boost::shared_ptr<FloatingRate>(new FloatingRate(floatingRateNode));
             floatingRate_->setID(floatingRateIDRef_);
             IDManager::instance().setID(floatingRateIDRef_,floatingRate_);
          }
          else if(floatingRateNode->Attribute("href")) { floatingRateIDRef_ = floatingRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRate_ = boost::shared_ptr<FloatingRate>(new FloatingRate(floatingRateNode));}
   }

   //fixedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateNode = xmlNode->FirstChildElement("fixedRate");

   if(fixedRateNode){fixedRateIsNull_ = false;}
   else{fixedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateNode , address : " << fixedRateNode << std::endl;
   #endif
   if(fixedRateNode)
   {
      if(fixedRateNode->Attribute("href") || fixedRateNode->Attribute("id"))
      {
          if(fixedRateNode->Attribute("id"))
          {
             fixedRateIDRef_ = fixedRateNode->Attribute("id");
             fixedRate_ = boost::shared_ptr<Schedule>(new Schedule(fixedRateNode));
             fixedRate_->setID(fixedRateIDRef_);
             IDManager::instance().setID(fixedRateIDRef_,fixedRate_);
          }
          else if(fixedRateNode->Attribute("href")) { fixedRateIDRef_ = fixedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fixedRate_ = boost::shared_ptr<Schedule>(new Schedule(fixedRateNode));}
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

   //quotedCurrencyPairNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotedCurrencyPairNode = xmlNode->FirstChildElement("quotedCurrencyPair");

   if(quotedCurrencyPairNode){quotedCurrencyPairIsNull_ = false;}
   else{quotedCurrencyPairIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotedCurrencyPairNode , address : " << quotedCurrencyPairNode << std::endl;
   #endif
   if(quotedCurrencyPairNode)
   {
      if(quotedCurrencyPairNode->Attribute("href") || quotedCurrencyPairNode->Attribute("id"))
      {
          if(quotedCurrencyPairNode->Attribute("id"))
          {
             quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("id");
             quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));
             quotedCurrencyPair_->setID(quotedCurrencyPairIDRef_);
             IDManager::instance().setID(quotedCurrencyPairIDRef_,quotedCurrencyPair_);
          }
          else if(quotedCurrencyPairNode->Attribute("href")) { quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));}
   }

   //referenceEntityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceEntityNode = xmlNode->FirstChildElement("referenceEntity");

   if(referenceEntityNode){referenceEntityIsNull_ = false;}
   else{referenceEntityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceEntityNode , address : " << referenceEntityNode << std::endl;
   #endif
   if(referenceEntityNode)
   {
      if(referenceEntityNode->Attribute("href") || referenceEntityNode->Attribute("id"))
      {
          if(referenceEntityNode->Attribute("id"))
          {
             referenceEntityIDRef_ = referenceEntityNode->Attribute("id");
             referenceEntity_ = boost::shared_ptr<LegalEntity>(new LegalEntity(referenceEntityNode));
             referenceEntity_->setID(referenceEntityIDRef_);
             IDManager::instance().setID(referenceEntityIDRef_,referenceEntity_);
          }
          else if(referenceEntityNode->Attribute("href")) { referenceEntityIDRef_ = referenceEntityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceEntity_ = boost::shared_ptr<LegalEntity>(new LegalEntity(referenceEntityNode));}
   }

   //payerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payerPartyReferenceNode = xmlNode->FirstChildElement("payerPartyReference");

   if(payerPartyReferenceNode){payerPartyReferenceIsNull_ = false;}
   else{payerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payerPartyReferenceNode , address : " << payerPartyReferenceNode << std::endl;
   #endif
   if(payerPartyReferenceNode)
   {
      if(payerPartyReferenceNode->Attribute("href") || payerPartyReferenceNode->Attribute("id"))
      {
          if(payerPartyReferenceNode->Attribute("id"))
          {
             payerPartyReferenceIDRef_ = payerPartyReferenceNode->Attribute("id");
             payerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(payerPartyReferenceNode));
             payerPartyReference_->setID(payerPartyReferenceIDRef_);
             IDManager::instance().setID(payerPartyReferenceIDRef_,payerPartyReference_);
          }
          else if(payerPartyReferenceNode->Attribute("href")) { payerPartyReferenceIDRef_ = payerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(payerPartyReferenceNode));}
   }

   //payerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payerAccountReferenceNode = xmlNode->FirstChildElement("payerAccountReference");

   if(payerAccountReferenceNode){payerAccountReferenceIsNull_ = false;}
   else{payerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payerAccountReferenceNode , address : " << payerAccountReferenceNode << std::endl;
   #endif
   if(payerAccountReferenceNode)
   {
      if(payerAccountReferenceNode->Attribute("href") || payerAccountReferenceNode->Attribute("id"))
      {
          if(payerAccountReferenceNode->Attribute("id"))
          {
             payerAccountReferenceIDRef_ = payerAccountReferenceNode->Attribute("id");
             payerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(payerAccountReferenceNode));
             payerAccountReference_->setID(payerAccountReferenceIDRef_);
             IDManager::instance().setID(payerAccountReferenceIDRef_,payerAccountReference_);
          }
          else if(payerAccountReferenceNode->Attribute("href")) { payerAccountReferenceIDRef_ = payerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { payerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(payerAccountReferenceNode));}
   }

   //receiverPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* receiverPartyReferenceNode = xmlNode->FirstChildElement("receiverPartyReference");

   if(receiverPartyReferenceNode){receiverPartyReferenceIsNull_ = false;}
   else{receiverPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- receiverPartyReferenceNode , address : " << receiverPartyReferenceNode << std::endl;
   #endif
   if(receiverPartyReferenceNode)
   {
      if(receiverPartyReferenceNode->Attribute("href") || receiverPartyReferenceNode->Attribute("id"))
      {
          if(receiverPartyReferenceNode->Attribute("id"))
          {
             receiverPartyReferenceIDRef_ = receiverPartyReferenceNode->Attribute("id");
             receiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(receiverPartyReferenceNode));
             receiverPartyReference_->setID(receiverPartyReferenceIDRef_);
             IDManager::instance().setID(receiverPartyReferenceIDRef_,receiverPartyReference_);
          }
          else if(receiverPartyReferenceNode->Attribute("href")) { receiverPartyReferenceIDRef_ = receiverPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { receiverPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(receiverPartyReferenceNode));}
   }

   //receiverAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* receiverAccountReferenceNode = xmlNode->FirstChildElement("receiverAccountReference");

   if(receiverAccountReferenceNode){receiverAccountReferenceIsNull_ = false;}
   else{receiverAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- receiverAccountReferenceNode , address : " << receiverAccountReferenceNode << std::endl;
   #endif
   if(receiverAccountReferenceNode)
   {
      if(receiverAccountReferenceNode->Attribute("href") || receiverAccountReferenceNode->Attribute("id"))
      {
          if(receiverAccountReferenceNode->Attribute("id"))
          {
             receiverAccountReferenceIDRef_ = receiverAccountReferenceNode->Attribute("id");
             receiverAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(receiverAccountReferenceNode));
             receiverAccountReference_->setID(receiverAccountReferenceIDRef_);
             IDManager::instance().setID(receiverAccountReferenceIDRef_,receiverAccountReference_);
          }
          else if(receiverAccountReferenceNode->Attribute("href")) { receiverAccountReferenceIDRef_ = receiverAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { receiverAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(receiverAccountReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FloatingRate> TradeUnderlyer2::getFloatingRate()
{
   if(!this->floatingRateIsNull_){
        if(floatingRateIDRef_ != ""){
             return boost::shared_static_cast<FloatingRate>(IDManager::instance().getID(floatingRateIDRef_));
        }else{
             return this->floatingRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRate>();
   }
}
boost::shared_ptr<Schedule> TradeUnderlyer2::getFixedRate()
{
   if(!this->fixedRateIsNull_){
        if(fixedRateIDRef_ != ""){
             return boost::shared_static_cast<Schedule>(IDManager::instance().getID(fixedRateIDRef_));
        }else{
             return this->fixedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Schedule>();
   }
}
boost::shared_ptr<Asset> TradeUnderlyer2::getUnderlyingAsset()
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
boost::shared_ptr<Basket> TradeUnderlyer2::getBasket()
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
boost::shared_ptr<Bond> TradeUnderlyer2::getBond()
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
boost::shared_ptr<Cash> TradeUnderlyer2::getCash()
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
boost::shared_ptr<Commodity> TradeUnderlyer2::getCommodity()
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
boost::shared_ptr<ConvertibleBond> TradeUnderlyer2::getConvertibleBond()
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
boost::shared_ptr<EquityAsset> TradeUnderlyer2::getEquity()
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
boost::shared_ptr<ExchangeTradedFund> TradeUnderlyer2::getExchangeTradedFund()
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
boost::shared_ptr<Future> TradeUnderlyer2::getFuture()
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
boost::shared_ptr<Index> TradeUnderlyer2::getIndex()
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
boost::shared_ptr<Loan> TradeUnderlyer2::getLoan()
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
boost::shared_ptr<Mortgage> TradeUnderlyer2::getMortgage()
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
boost::shared_ptr<MutualFund> TradeUnderlyer2::getMutualFund()
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
boost::shared_ptr<QuotedCurrencyPair> TradeUnderlyer2::getQuotedCurrencyPair()
{
   if(!this->quotedCurrencyPairIsNull_){
        if(quotedCurrencyPairIDRef_ != ""){
             return boost::shared_static_cast<QuotedCurrencyPair>(IDManager::instance().getID(quotedCurrencyPairIDRef_));
        }else{
             return this->quotedCurrencyPair_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedCurrencyPair>();
   }
}
boost::shared_ptr<LegalEntity> TradeUnderlyer2::getReferenceEntity()
{
   if(!this->referenceEntityIsNull_){
        if(referenceEntityIDRef_ != ""){
             return boost::shared_static_cast<LegalEntity>(IDManager::instance().getID(referenceEntityIDRef_));
        }else{
             return this->referenceEntity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntity>();
   }
}
boost::shared_ptr<PartyReference> TradeUnderlyer2::getPayerPartyReference()
{
   if(!this->payerPartyReferenceIsNull_){
        if(payerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(payerPartyReferenceIDRef_));
        }else{
             return this->payerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> TradeUnderlyer2::getPayerAccountReference()
{
   if(!this->payerAccountReferenceIsNull_){
        if(payerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(payerAccountReferenceIDRef_));
        }else{
             return this->payerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> TradeUnderlyer2::getReceiverPartyReference()
{
   if(!this->receiverPartyReferenceIsNull_){
        if(receiverPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(receiverPartyReferenceIDRef_));
        }else{
             return this->receiverPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> TradeUnderlyer2::getReceiverAccountReference()
{
   if(!this->receiverAccountReferenceIsNull_){
        if(receiverAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(receiverAccountReferenceIDRef_));
        }else{
             return this->receiverAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
}

