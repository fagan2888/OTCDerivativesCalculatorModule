// CreditDefaultSwap.cpp 
#include "CreditDefaultSwap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditDefaultSwap::CreditDefaultSwap(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //generalTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generalTermsNode = xmlNode->FirstChildElement("generalTerms");

   if(generalTermsNode){generalTermsIsNull_ = false;}
   else{generalTermsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalTermsNode , address : " << generalTermsNode << std::endl;
   #endif
   if(generalTermsNode)
   {
      if(generalTermsNode->Attribute("href") || generalTermsNode->Attribute("id"))
      {
          if(generalTermsNode->Attribute("id"))
          {
             generalTermsIDRef_ = generalTermsNode->Attribute("id");
             generalTerms_ = boost::shared_ptr<GeneralTerms>(new GeneralTerms(generalTermsNode));
             generalTerms_->setID(generalTermsIDRef_);
             IDManager::instance().setID(generalTermsIDRef_,generalTerms_);
          }
          else if(generalTermsNode->Attribute("href")) { generalTermsIDRef_ = generalTermsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { generalTerms_ = boost::shared_ptr<GeneralTerms>(new GeneralTerms(generalTermsNode));}
   }

   //feeLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* feeLegNode = xmlNode->FirstChildElement("feeLeg");

   if(feeLegNode){feeLegIsNull_ = false;}
   else{feeLegIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- feeLegNode , address : " << feeLegNode << std::endl;
   #endif
   if(feeLegNode)
   {
      if(feeLegNode->Attribute("href") || feeLegNode->Attribute("id"))
      {
          if(feeLegNode->Attribute("id"))
          {
             feeLegIDRef_ = feeLegNode->Attribute("id");
             feeLeg_ = boost::shared_ptr<FeeLeg>(new FeeLeg(feeLegNode));
             feeLeg_->setID(feeLegIDRef_);
             IDManager::instance().setID(feeLegIDRef_,feeLeg_);
          }
          else if(feeLegNode->Attribute("href")) { feeLegIDRef_ = feeLegNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { feeLeg_ = boost::shared_ptr<FeeLeg>(new FeeLeg(feeLegNode));}
   }

   //protectionTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* protectionTermsNode = xmlNode->FirstChildElement("protectionTerms");

   if(protectionTermsNode){protectionTermsIsNull_ = false;}
   else{protectionTermsIsNull_ = true;}

   if(protectionTermsNode)
   {
      for(protectionTermsNode; protectionTermsNode; protectionTermsNode = protectionTermsNode->NextSiblingElement("protectionTerms")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- protectionTermsNode , address : " << protectionTermsNode << std::endl;
          #endif
          if(protectionTermsNode->Attribute("href") || protectionTermsNode->Attribute("id"))
          {
              if(protectionTermsNode->Attribute("id"))
              {
                  protectionTermsIDRef_ = protectionTermsNode->Attribute("id");
                  protectionTerms_.push_back(boost::shared_ptr<ProtectionTerms>(new ProtectionTerms(protectionTermsNode)));
                  protectionTerms_.back()->setID(protectionTermsIDRef_);
                  IDManager::instance().setID(protectionTermsIDRef_, protectionTerms_.back());
              }
              else if(protectionTermsNode->Attribute("href")) { protectionTermsIDRef_ = protectionTermsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { protectionTerms_.push_back(boost::shared_ptr<ProtectionTerms>(new ProtectionTerms(protectionTermsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- protectionTermsNode , address : " << protectionTermsNode << std::endl;
       #endif
   }

   //cashSettlementTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementTermsNode = xmlNode->FirstChildElement("cashSettlementTerms");

   if(cashSettlementTermsNode){cashSettlementTermsIsNull_ = false;}
   else{cashSettlementTermsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementTermsNode , address : " << cashSettlementTermsNode << std::endl;
   #endif
   if(cashSettlementTermsNode)
   {
      if(cashSettlementTermsNode->Attribute("href") || cashSettlementTermsNode->Attribute("id"))
      {
          if(cashSettlementTermsNode->Attribute("id"))
          {
             cashSettlementTermsIDRef_ = cashSettlementTermsNode->Attribute("id");
             cashSettlementTerms_ = boost::shared_ptr<CashSettlementTerms>(new CashSettlementTerms(cashSettlementTermsNode));
             cashSettlementTerms_->setID(cashSettlementTermsIDRef_);
             IDManager::instance().setID(cashSettlementTermsIDRef_,cashSettlementTerms_);
          }
          else if(cashSettlementTermsNode->Attribute("href")) { cashSettlementTermsIDRef_ = cashSettlementTermsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementTerms_ = boost::shared_ptr<CashSettlementTerms>(new CashSettlementTerms(cashSettlementTermsNode));}
   }

   //physicalSettlementTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* physicalSettlementTermsNode = xmlNode->FirstChildElement("physicalSettlementTerms");

   if(physicalSettlementTermsNode){physicalSettlementTermsIsNull_ = false;}
   else{physicalSettlementTermsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- physicalSettlementTermsNode , address : " << physicalSettlementTermsNode << std::endl;
   #endif
   if(physicalSettlementTermsNode)
   {
      if(physicalSettlementTermsNode->Attribute("href") || physicalSettlementTermsNode->Attribute("id"))
      {
          if(physicalSettlementTermsNode->Attribute("id"))
          {
             physicalSettlementTermsIDRef_ = physicalSettlementTermsNode->Attribute("id");
             physicalSettlementTerms_ = boost::shared_ptr<PhysicalSettlementTerms>(new PhysicalSettlementTerms(physicalSettlementTermsNode));
             physicalSettlementTerms_->setID(physicalSettlementTermsIDRef_);
             IDManager::instance().setID(physicalSettlementTermsIDRef_,physicalSettlementTerms_);
          }
          else if(physicalSettlementTermsNode->Attribute("href")) { physicalSettlementTermsIDRef_ = physicalSettlementTermsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { physicalSettlementTerms_ = boost::shared_ptr<PhysicalSettlementTerms>(new PhysicalSettlementTerms(physicalSettlementTermsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<GeneralTerms> CreditDefaultSwap::getGeneralTerms()
{
   if(!this->generalTermsIsNull_){
        if(generalTermsIDRef_ != ""){
             return boost::shared_static_cast<GeneralTerms>(IDManager::instance().getID(generalTermsIDRef_));
        }else{
             return this->generalTerms_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GeneralTerms>();
   }
}
boost::shared_ptr<FeeLeg> CreditDefaultSwap::getFeeLeg()
{
   if(!this->feeLegIsNull_){
        if(feeLegIDRef_ != ""){
             return boost::shared_static_cast<FeeLeg>(IDManager::instance().getID(feeLegIDRef_));
        }else{
             return this->feeLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FeeLeg>();
   }
}
std::vector<boost::shared_ptr<ProtectionTerms>> CreditDefaultSwap::getProtectionTerms()
{
   if(!this->protectionTermsIsNull_){
        if(protectionTermsIDRef_ != ""){
             return this->protectionTerms_;
        }else{
             return this->protectionTerms_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ProtectionTerms>>();
   }
}
boost::shared_ptr<CashSettlementTerms> CreditDefaultSwap::getCashSettlementTerms()
{
   if(!this->cashSettlementTermsIsNull_){
        if(cashSettlementTermsIDRef_ != ""){
             return boost::shared_static_cast<CashSettlementTerms>(IDManager::instance().getID(cashSettlementTermsIDRef_));
        }else{
             return this->cashSettlementTerms_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashSettlementTerms>();
   }
}
boost::shared_ptr<PhysicalSettlementTerms> CreditDefaultSwap::getPhysicalSettlementTerms()
{
   if(!this->physicalSettlementTermsIsNull_){
        if(physicalSettlementTermsIDRef_ != ""){
             return boost::shared_static_cast<PhysicalSettlementTerms>(IDManager::instance().getID(physicalSettlementTermsIDRef_));
        }else{
             return this->physicalSettlementTerms_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PhysicalSettlementTerms>();
   }
}
}

