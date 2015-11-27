// Tranche.cpp 
#include "Tranche.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Tranche::Tranche(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //attachmentPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* attachmentPointNode = xmlNode->FirstChildElement("attachmentPoint");

   if(attachmentPointNode){attachmentPointIsNull_ = false;}
   else{attachmentPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- attachmentPointNode , address : " << attachmentPointNode << std::endl;
   #endif
   if(attachmentPointNode)
   {
      if(attachmentPointNode->Attribute("href") || attachmentPointNode->Attribute("id"))
      {
          if(attachmentPointNode->Attribute("id"))
          {
             attachmentPointIDRef_ = attachmentPointNode->Attribute("id");
             attachmentPoint_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(attachmentPointNode));
             attachmentPoint_->setID(attachmentPointIDRef_);
             IDManager::instance().setID(attachmentPointIDRef_,attachmentPoint_);
          }
          else if(attachmentPointNode->Attribute("href")) { attachmentPointIDRef_ = attachmentPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { attachmentPoint_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(attachmentPointNode));}
   }

   //exhaustionPointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exhaustionPointNode = xmlNode->FirstChildElement("exhaustionPoint");

   if(exhaustionPointNode){exhaustionPointIsNull_ = false;}
   else{exhaustionPointIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exhaustionPointNode , address : " << exhaustionPointNode << std::endl;
   #endif
   if(exhaustionPointNode)
   {
      if(exhaustionPointNode->Attribute("href") || exhaustionPointNode->Attribute("id"))
      {
          if(exhaustionPointNode->Attribute("id"))
          {
             exhaustionPointIDRef_ = exhaustionPointNode->Attribute("id");
             exhaustionPoint_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(exhaustionPointNode));
             exhaustionPoint_->setID(exhaustionPointIDRef_);
             IDManager::instance().setID(exhaustionPointIDRef_,exhaustionPoint_);
          }
          else if(exhaustionPointNode->Attribute("href")) { exhaustionPointIDRef_ = exhaustionPointNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exhaustionPoint_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(exhaustionPointNode));}
   }

   //incurredRecoveryApplicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* incurredRecoveryApplicableNode = xmlNode->FirstChildElement("incurredRecoveryApplicable");

   if(incurredRecoveryApplicableNode){incurredRecoveryApplicableIsNull_ = false;}
   else{incurredRecoveryApplicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- incurredRecoveryApplicableNode , address : " << incurredRecoveryApplicableNode << std::endl;
   #endif
   if(incurredRecoveryApplicableNode)
   {
      if(incurredRecoveryApplicableNode->Attribute("href") || incurredRecoveryApplicableNode->Attribute("id"))
      {
          if(incurredRecoveryApplicableNode->Attribute("id"))
          {
             incurredRecoveryApplicableIDRef_ = incurredRecoveryApplicableNode->Attribute("id");
             incurredRecoveryApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(incurredRecoveryApplicableNode));
             incurredRecoveryApplicable_->setID(incurredRecoveryApplicableIDRef_);
             IDManager::instance().setID(incurredRecoveryApplicableIDRef_,incurredRecoveryApplicable_);
          }
          else if(incurredRecoveryApplicableNode->Attribute("href")) { incurredRecoveryApplicableIDRef_ = incurredRecoveryApplicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { incurredRecoveryApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(incurredRecoveryApplicableNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> Tranche::getAttachmentPoint()
{
   if(!this->attachmentPointIsNull_){
        if(attachmentPointIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(attachmentPointIDRef_));
        }else{
             return this->attachmentPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Tranche::getExhaustionPoint()
{
   if(!this->exhaustionPointIsNull_){
        if(exhaustionPointIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(exhaustionPointIDRef_));
        }else{
             return this->exhaustionPoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Tranche::getIncurredRecoveryApplicable()
{
   if(!this->incurredRecoveryApplicableIsNull_){
        if(incurredRecoveryApplicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(incurredRecoveryApplicableIDRef_));
        }else{
             return this->incurredRecoveryApplicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

