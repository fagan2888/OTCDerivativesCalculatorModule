// ReferencePoolItem.cpp 
#include "ReferencePoolItem.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferencePoolItem::ReferencePoolItem(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //constituentWeightNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constituentWeightNode = xmlNode->FirstChildElement("constituentWeight");

   if(constituentWeightNode){constituentWeightIsNull_ = false;}
   else{constituentWeightIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constituentWeightNode , address : " << constituentWeightNode << std::endl;
   #endif
   if(constituentWeightNode)
   {
      if(constituentWeightNode->Attribute("href") || constituentWeightNode->Attribute("id"))
      {
          if(constituentWeightNode->Attribute("id"))
          {
             constituentWeightIDRef_ = constituentWeightNode->Attribute("id");
             constituentWeight_ = boost::shared_ptr<ConstituentWeight>(new ConstituentWeight(constituentWeightNode));
             constituentWeight_->setID(constituentWeightIDRef_);
             IDManager::instance().setID(constituentWeightIDRef_,constituentWeight_);
          }
          else if(constituentWeightNode->Attribute("href")) { constituentWeightIDRef_ = constituentWeightNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { constituentWeight_ = boost::shared_ptr<ConstituentWeight>(new ConstituentWeight(constituentWeightNode));}
   }

   //referencePairNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referencePairNode = xmlNode->FirstChildElement("referencePair");

   if(referencePairNode){referencePairIsNull_ = false;}
   else{referencePairIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referencePairNode , address : " << referencePairNode << std::endl;
   #endif
   if(referencePairNode)
   {
      if(referencePairNode->Attribute("href") || referencePairNode->Attribute("id"))
      {
          if(referencePairNode->Attribute("id"))
          {
             referencePairIDRef_ = referencePairNode->Attribute("id");
             referencePair_ = boost::shared_ptr<ReferencePair>(new ReferencePair(referencePairNode));
             referencePair_->setID(referencePairIDRef_);
             IDManager::instance().setID(referencePairIDRef_,referencePair_);
          }
          else if(referencePairNode->Attribute("href")) { referencePairIDRef_ = referencePairNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referencePair_ = boost::shared_ptr<ReferencePair>(new ReferencePair(referencePairNode));}
   }

   //protectionTermsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* protectionTermsReferenceNode = xmlNode->FirstChildElement("protectionTermsReference");

   if(protectionTermsReferenceNode){protectionTermsReferenceIsNull_ = false;}
   else{protectionTermsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- protectionTermsReferenceNode , address : " << protectionTermsReferenceNode << std::endl;
   #endif
   if(protectionTermsReferenceNode)
   {
      if(protectionTermsReferenceNode->Attribute("href") || protectionTermsReferenceNode->Attribute("id"))
      {
          if(protectionTermsReferenceNode->Attribute("id"))
          {
             protectionTermsReferenceIDRef_ = protectionTermsReferenceNode->Attribute("id");
             protectionTermsReference_ = boost::shared_ptr<ProtectionTermsReference>(new ProtectionTermsReference(protectionTermsReferenceNode));
             protectionTermsReference_->setID(protectionTermsReferenceIDRef_);
             IDManager::instance().setID(protectionTermsReferenceIDRef_,protectionTermsReference_);
          }
          else if(protectionTermsReferenceNode->Attribute("href")) { protectionTermsReferenceIDRef_ = protectionTermsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { protectionTermsReference_ = boost::shared_ptr<ProtectionTermsReference>(new ProtectionTermsReference(protectionTermsReferenceNode));}
   }

   //settlementTermsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementTermsReferenceNode = xmlNode->FirstChildElement("settlementTermsReference");

   if(settlementTermsReferenceNode){settlementTermsReferenceIsNull_ = false;}
   else{settlementTermsReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementTermsReferenceNode , address : " << settlementTermsReferenceNode << std::endl;
   #endif
   if(settlementTermsReferenceNode)
   {
      if(settlementTermsReferenceNode->Attribute("href") || settlementTermsReferenceNode->Attribute("id"))
      {
          if(settlementTermsReferenceNode->Attribute("id"))
          {
             settlementTermsReferenceIDRef_ = settlementTermsReferenceNode->Attribute("id");
             settlementTermsReference_ = boost::shared_ptr<SettlementTermsReference>(new SettlementTermsReference(settlementTermsReferenceNode));
             settlementTermsReference_->setID(settlementTermsReferenceIDRef_);
             IDManager::instance().setID(settlementTermsReferenceIDRef_,settlementTermsReference_);
          }
          else if(settlementTermsReferenceNode->Attribute("href")) { settlementTermsReferenceIDRef_ = settlementTermsReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementTermsReference_ = boost::shared_ptr<SettlementTermsReference>(new SettlementTermsReference(settlementTermsReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ConstituentWeight> ReferencePoolItem::getConstituentWeight()
{
   if(!this->constituentWeightIsNull_){
        if(constituentWeightIDRef_ != ""){
             return boost::shared_static_cast<ConstituentWeight>(IDManager::instance().getID(constituentWeightIDRef_));
        }else{
             return this->constituentWeight_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConstituentWeight>();
   }
}
boost::shared_ptr<ReferencePair> ReferencePoolItem::getReferencePair()
{
   if(!this->referencePairIsNull_){
        if(referencePairIDRef_ != ""){
             return boost::shared_static_cast<ReferencePair>(IDManager::instance().getID(referencePairIDRef_));
        }else{
             return this->referencePair_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferencePair>();
   }
}
boost::shared_ptr<ProtectionTermsReference> ReferencePoolItem::getProtectionTermsReference()
{
   if(!this->protectionTermsReferenceIsNull_){
        if(protectionTermsReferenceIDRef_ != ""){
             return boost::shared_static_cast<ProtectionTermsReference>(IDManager::instance().getID(protectionTermsReferenceIDRef_));
        }else{
             return this->protectionTermsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProtectionTermsReference>();
   }
}
boost::shared_ptr<SettlementTermsReference> ReferencePoolItem::getSettlementTermsReference()
{
   if(!this->settlementTermsReferenceIsNull_){
        if(settlementTermsReferenceIDRef_ != ""){
             return boost::shared_static_cast<SettlementTermsReference>(IDManager::instance().getID(settlementTermsReferenceIDRef_));
        }else{
             return this->settlementTermsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementTermsReference>();
   }
}
}

