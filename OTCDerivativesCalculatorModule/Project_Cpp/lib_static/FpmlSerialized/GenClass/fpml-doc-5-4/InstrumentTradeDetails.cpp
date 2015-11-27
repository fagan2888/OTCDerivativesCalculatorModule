// InstrumentTradeDetails.cpp 
#include "InstrumentTradeDetails.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentTradeDetails::InstrumentTradeDetails(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //buyerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerPartyReferenceNode = xmlNode->FirstChildElement("buyerPartyReference");

   if(buyerPartyReferenceNode){buyerPartyReferenceIsNull_ = false;}
   else{buyerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerPartyReferenceNode , address : " << buyerPartyReferenceNode << std::endl;
   #endif
   if(buyerPartyReferenceNode)
   {
      if(buyerPartyReferenceNode->Attribute("href") || buyerPartyReferenceNode->Attribute("id"))
      {
          if(buyerPartyReferenceNode->Attribute("id"))
          {
             buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("id");
             buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));
             buyerPartyReference_->setID(buyerPartyReferenceIDRef_);
             IDManager::instance().setID(buyerPartyReferenceIDRef_,buyerPartyReference_);
          }
          else if(buyerPartyReferenceNode->Attribute("href")) { buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));}
   }

   //buyerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerAccountReferenceNode = xmlNode->FirstChildElement("buyerAccountReference");

   if(buyerAccountReferenceNode){buyerAccountReferenceIsNull_ = false;}
   else{buyerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerAccountReferenceNode , address : " << buyerAccountReferenceNode << std::endl;
   #endif
   if(buyerAccountReferenceNode)
   {
      if(buyerAccountReferenceNode->Attribute("href") || buyerAccountReferenceNode->Attribute("id"))
      {
          if(buyerAccountReferenceNode->Attribute("id"))
          {
             buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("id");
             buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));
             buyerAccountReference_->setID(buyerAccountReferenceIDRef_);
             IDManager::instance().setID(buyerAccountReferenceIDRef_,buyerAccountReference_);
          }
          else if(buyerAccountReferenceNode->Attribute("href")) { buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));}
   }

   //sellerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerPartyReferenceNode = xmlNode->FirstChildElement("sellerPartyReference");

   if(sellerPartyReferenceNode){sellerPartyReferenceIsNull_ = false;}
   else{sellerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerPartyReferenceNode , address : " << sellerPartyReferenceNode << std::endl;
   #endif
   if(sellerPartyReferenceNode)
   {
      if(sellerPartyReferenceNode->Attribute("href") || sellerPartyReferenceNode->Attribute("id"))
      {
          if(sellerPartyReferenceNode->Attribute("id"))
          {
             sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("id");
             sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));
             sellerPartyReference_->setID(sellerPartyReferenceIDRef_);
             IDManager::instance().setID(sellerPartyReferenceIDRef_,sellerPartyReference_);
          }
          else if(sellerPartyReferenceNode->Attribute("href")) { sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));}
   }

   //sellerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerAccountReferenceNode = xmlNode->FirstChildElement("sellerAccountReference");

   if(sellerAccountReferenceNode){sellerAccountReferenceIsNull_ = false;}
   else{sellerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerAccountReferenceNode , address : " << sellerAccountReferenceNode << std::endl;
   #endif
   if(sellerAccountReferenceNode)
   {
      if(sellerAccountReferenceNode->Attribute("href") || sellerAccountReferenceNode->Attribute("id"))
      {
          if(sellerAccountReferenceNode->Attribute("id"))
          {
             sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("id");
             sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));
             sellerAccountReference_->setID(sellerAccountReferenceIDRef_);
             IDManager::instance().setID(sellerAccountReferenceIDRef_,sellerAccountReference_);
          }
          else if(sellerAccountReferenceNode->Attribute("href")) { sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));}
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

   //quantityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quantityNode = xmlNode->FirstChildElement("quantity");

   if(quantityNode){quantityIsNull_ = false;}
   else{quantityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quantityNode , address : " << quantityNode << std::endl;
   #endif
   if(quantityNode)
   {
      if(quantityNode->Attribute("href") || quantityNode->Attribute("id"))
      {
          if(quantityNode->Attribute("id"))
          {
             quantityIDRef_ = quantityNode->Attribute("id");
             quantity_ = boost::shared_ptr<InstrumentTradeQuantity>(new InstrumentTradeQuantity(quantityNode));
             quantity_->setID(quantityIDRef_);
             IDManager::instance().setID(quantityIDRef_,quantity_);
          }
          else if(quantityNode->Attribute("href")) { quantityIDRef_ = quantityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quantity_ = boost::shared_ptr<InstrumentTradeQuantity>(new InstrumentTradeQuantity(quantityNode));}
   }

   //pricingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricingNode = xmlNode->FirstChildElement("pricing");

   if(pricingNode){pricingIsNull_ = false;}
   else{pricingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricingNode , address : " << pricingNode << std::endl;
   #endif
   if(pricingNode)
   {
      if(pricingNode->Attribute("href") || pricingNode->Attribute("id"))
      {
          if(pricingNode->Attribute("id"))
          {
             pricingIDRef_ = pricingNode->Attribute("id");
             pricing_ = boost::shared_ptr<InstrumentTradePricing>(new InstrumentTradePricing(pricingNode));
             pricing_->setID(pricingIDRef_);
             IDManager::instance().setID(pricingIDRef_,pricing_);
          }
          else if(pricingNode->Attribute("href")) { pricingIDRef_ = pricingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricing_ = boost::shared_ptr<InstrumentTradePricing>(new InstrumentTradePricing(pricingNode));}
   }

   //principalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalNode = xmlNode->FirstChildElement("principal");

   if(principalNode){principalIsNull_ = false;}
   else{principalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalNode , address : " << principalNode << std::endl;
   #endif
   if(principalNode)
   {
      if(principalNode->Attribute("href") || principalNode->Attribute("id"))
      {
          if(principalNode->Attribute("id"))
          {
             principalIDRef_ = principalNode->Attribute("id");
             principal_ = boost::shared_ptr<InstrumentTradePrincipal>(new InstrumentTradePrincipal(principalNode));
             principal_->setID(principalIDRef_);
             IDManager::instance().setID(principalIDRef_,principal_);
          }
          else if(principalNode->Attribute("href")) { principalIDRef_ = principalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principal_ = boost::shared_ptr<InstrumentTradePrincipal>(new InstrumentTradePrincipal(principalNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> InstrumentTradeDetails::getBuyerPartyReference()
{
   if(!this->buyerPartyReferenceIsNull_){
        if(buyerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(buyerPartyReferenceIDRef_));
        }else{
             return this->buyerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> InstrumentTradeDetails::getBuyerAccountReference()
{
   if(!this->buyerAccountReferenceIsNull_){
        if(buyerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(buyerAccountReferenceIDRef_));
        }else{
             return this->buyerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> InstrumentTradeDetails::getSellerPartyReference()
{
   if(!this->sellerPartyReferenceIsNull_){
        if(sellerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(sellerPartyReferenceIDRef_));
        }else{
             return this->sellerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> InstrumentTradeDetails::getSellerAccountReference()
{
   if(!this->sellerAccountReferenceIsNull_){
        if(sellerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(sellerAccountReferenceIDRef_));
        }else{
             return this->sellerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<Asset> InstrumentTradeDetails::getUnderlyingAsset()
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
boost::shared_ptr<Basket> InstrumentTradeDetails::getBasket()
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
boost::shared_ptr<Bond> InstrumentTradeDetails::getBond()
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
boost::shared_ptr<Cash> InstrumentTradeDetails::getCash()
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
boost::shared_ptr<Commodity> InstrumentTradeDetails::getCommodity()
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
boost::shared_ptr<ConvertibleBond> InstrumentTradeDetails::getConvertibleBond()
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
boost::shared_ptr<EquityAsset> InstrumentTradeDetails::getEquity()
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
boost::shared_ptr<ExchangeTradedFund> InstrumentTradeDetails::getExchangeTradedFund()
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
boost::shared_ptr<Future> InstrumentTradeDetails::getFuture()
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
boost::shared_ptr<Index> InstrumentTradeDetails::getIndex()
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
boost::shared_ptr<Loan> InstrumentTradeDetails::getLoan()
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
boost::shared_ptr<Mortgage> InstrumentTradeDetails::getMortgage()
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
boost::shared_ptr<MutualFund> InstrumentTradeDetails::getMutualFund()
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
boost::shared_ptr<InstrumentTradeQuantity> InstrumentTradeDetails::getQuantity()
{
   if(!this->quantityIsNull_){
        if(quantityIDRef_ != ""){
             return boost::shared_static_cast<InstrumentTradeQuantity>(IDManager::instance().getID(quantityIDRef_));
        }else{
             return this->quantity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InstrumentTradeQuantity>();
   }
}
boost::shared_ptr<InstrumentTradePricing> InstrumentTradeDetails::getPricing()
{
   if(!this->pricingIsNull_){
        if(pricingIDRef_ != ""){
             return boost::shared_static_cast<InstrumentTradePricing>(IDManager::instance().getID(pricingIDRef_));
        }else{
             return this->pricing_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InstrumentTradePricing>();
   }
}
boost::shared_ptr<InstrumentTradePrincipal> InstrumentTradeDetails::getPrincipal()
{
   if(!this->principalIsNull_){
        if(principalIDRef_ != ""){
             return boost::shared_static_cast<InstrumentTradePrincipal>(IDManager::instance().getID(principalIDRef_));
        }else{
             return this->principal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InstrumentTradePrincipal>();
   }
}
}

