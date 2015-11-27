// ReturnSwapBase.cpp 
#include "ReturnSwapBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwapBase::ReturnSwapBase(TiXmlNode* xmlNode)
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

   //returnSwapLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnSwapLegNode = xmlNode->FirstChildElement("returnSwapLeg");

   if(returnSwapLegNode){returnSwapLegIsNull_ = false;}
   else{returnSwapLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnSwapLegNode , address : " << returnSwapLegNode << std::endl;
   #endif
   if(returnSwapLegNode)
   {
      if(returnSwapLegNode->Attribute("href") || returnSwapLegNode->Attribute("id"))
      {
          if(returnSwapLegNode->Attribute("id"))
          {
             returnSwapLegIDRef_ = returnSwapLegNode->Attribute("id");
             returnSwapLeg_ = boost::shared_ptr<DirectionalLeg>(new DirectionalLeg(returnSwapLegNode));
             returnSwapLeg_->setID(returnSwapLegIDRef_);
             IDManager::instance().setID(returnSwapLegIDRef_,returnSwapLeg_);
          }
          else if(returnSwapLegNode->Attribute("href")) { returnSwapLegIDRef_ = returnSwapLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { returnSwapLeg_ = boost::shared_ptr<DirectionalLeg>(new DirectionalLeg(returnSwapLegNode));}
   }

   //interestLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestLegNode = xmlNode->FirstChildElement("interestLeg");

   if(interestLegNode){interestLegIsNull_ = false;}
   else{interestLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestLegNode , address : " << interestLegNode << std::endl;
   #endif
   if(interestLegNode)
   {
      if(interestLegNode->Attribute("href") || interestLegNode->Attribute("id"))
      {
          if(interestLegNode->Attribute("id"))
          {
             interestLegIDRef_ = interestLegNode->Attribute("id");
             interestLeg_ = boost::shared_ptr<InterestLeg>(new InterestLeg(interestLegNode));
             interestLeg_->setID(interestLegIDRef_);
             IDManager::instance().setID(interestLegIDRef_,interestLeg_);
          }
          else if(interestLegNode->Attribute("href")) { interestLegIDRef_ = interestLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestLeg_ = boost::shared_ptr<InterestLeg>(new InterestLeg(interestLegNode));}
   }

   //returnLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnLegNode = xmlNode->FirstChildElement("returnLeg");

   if(returnLegNode){returnLegIsNull_ = false;}
   else{returnLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnLegNode , address : " << returnLegNode << std::endl;
   #endif
   if(returnLegNode)
   {
      if(returnLegNode->Attribute("href") || returnLegNode->Attribute("id"))
      {
          if(returnLegNode->Attribute("id"))
          {
             returnLegIDRef_ = returnLegNode->Attribute("id");
             returnLeg_ = boost::shared_ptr<ReturnLeg>(new ReturnLeg(returnLegNode));
             returnLeg_->setID(returnLegIDRef_);
             IDManager::instance().setID(returnLegIDRef_,returnLeg_);
          }
          else if(returnLegNode->Attribute("href")) { returnLegIDRef_ = returnLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { returnLeg_ = boost::shared_ptr<ReturnLeg>(new ReturnLeg(returnLegNode));}
   }

   //principalExchangeFeaturesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalExchangeFeaturesNode = xmlNode->FirstChildElement("principalExchangeFeatures");

   if(principalExchangeFeaturesNode){principalExchangeFeaturesIsNull_ = false;}
   else{principalExchangeFeaturesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangeFeaturesNode , address : " << principalExchangeFeaturesNode << std::endl;
   #endif
   if(principalExchangeFeaturesNode)
   {
      if(principalExchangeFeaturesNode->Attribute("href") || principalExchangeFeaturesNode->Attribute("id"))
      {
          if(principalExchangeFeaturesNode->Attribute("id"))
          {
             principalExchangeFeaturesIDRef_ = principalExchangeFeaturesNode->Attribute("id");
             principalExchangeFeatures_ = boost::shared_ptr<PrincipalExchangeFeatures>(new PrincipalExchangeFeatures(principalExchangeFeaturesNode));
             principalExchangeFeatures_->setID(principalExchangeFeaturesIDRef_);
             IDManager::instance().setID(principalExchangeFeaturesIDRef_,principalExchangeFeatures_);
          }
          else if(principalExchangeFeaturesNode->Attribute("href")) { principalExchangeFeaturesIDRef_ = principalExchangeFeaturesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principalExchangeFeatures_ = boost::shared_ptr<PrincipalExchangeFeatures>(new PrincipalExchangeFeatures(principalExchangeFeaturesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ReturnSwapBase::getBuyerPartyReference()
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
boost::shared_ptr<AccountReference> ReturnSwapBase::getBuyerAccountReference()
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
boost::shared_ptr<PartyReference> ReturnSwapBase::getSellerPartyReference()
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
boost::shared_ptr<AccountReference> ReturnSwapBase::getSellerAccountReference()
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
boost::shared_ptr<DirectionalLeg> ReturnSwapBase::getReturnSwapLeg()
{
   if(!this->returnSwapLegIsNull_){
        if(returnSwapLegIDRef_ != ""){
             return boost::shared_static_cast<DirectionalLeg>(IDManager::instance().getID(returnSwapLegIDRef_));
        }else{
             return this->returnSwapLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DirectionalLeg>();
   }
}
boost::shared_ptr<InterestLeg> ReturnSwapBase::getInterestLeg()
{
   if(!this->interestLegIsNull_){
        if(interestLegIDRef_ != ""){
             return boost::shared_static_cast<InterestLeg>(IDManager::instance().getID(interestLegIDRef_));
        }else{
             return this->interestLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestLeg>();
   }
}
boost::shared_ptr<ReturnLeg> ReturnSwapBase::getReturnLeg()
{
   if(!this->returnLegIsNull_){
        if(returnLegIDRef_ != ""){
             return boost::shared_static_cast<ReturnLeg>(IDManager::instance().getID(returnLegIDRef_));
        }else{
             return this->returnLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnLeg>();
   }
}
boost::shared_ptr<PrincipalExchangeFeatures> ReturnSwapBase::getPrincipalExchangeFeatures()
{
   if(!this->principalExchangeFeaturesIsNull_){
        if(principalExchangeFeaturesIDRef_ != ""){
             return boost::shared_static_cast<PrincipalExchangeFeatures>(IDManager::instance().getID(principalExchangeFeaturesIDRef_));
        }else{
             return this->principalExchangeFeatures_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrincipalExchangeFeatures>();
   }
}
}

