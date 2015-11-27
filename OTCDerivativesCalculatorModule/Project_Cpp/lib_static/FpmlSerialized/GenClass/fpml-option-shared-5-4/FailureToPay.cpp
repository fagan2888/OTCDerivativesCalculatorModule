// FailureToPay.cpp 
#include "FailureToPay.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FailureToPay::FailureToPay(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //applicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* applicableNode = xmlNode->FirstChildElement("applicable");

   if(applicableNode){applicableIsNull_ = false;}
   else{applicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableNode , address : " << applicableNode << std::endl;
   #endif
   if(applicableNode)
   {
      if(applicableNode->Attribute("href") || applicableNode->Attribute("id"))
      {
          if(applicableNode->Attribute("id"))
          {
             applicableIDRef_ = applicableNode->Attribute("id");
             applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));
             applicable_->setID(applicableIDRef_);
             IDManager::instance().setID(applicableIDRef_,applicable_);
          }
          else if(applicableNode->Attribute("href")) { applicableIDRef_ = applicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));}
   }

   //gracePeriodExtensionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gracePeriodExtensionNode = xmlNode->FirstChildElement("gracePeriodExtension");

   if(gracePeriodExtensionNode){gracePeriodExtensionIsNull_ = false;}
   else{gracePeriodExtensionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gracePeriodExtensionNode , address : " << gracePeriodExtensionNode << std::endl;
   #endif
   if(gracePeriodExtensionNode)
   {
      if(gracePeriodExtensionNode->Attribute("href") || gracePeriodExtensionNode->Attribute("id"))
      {
          if(gracePeriodExtensionNode->Attribute("id"))
          {
             gracePeriodExtensionIDRef_ = gracePeriodExtensionNode->Attribute("id");
             gracePeriodExtension_ = boost::shared_ptr<GracePeriodExtension>(new GracePeriodExtension(gracePeriodExtensionNode));
             gracePeriodExtension_->setID(gracePeriodExtensionIDRef_);
             IDManager::instance().setID(gracePeriodExtensionIDRef_,gracePeriodExtension_);
          }
          else if(gracePeriodExtensionNode->Attribute("href")) { gracePeriodExtensionIDRef_ = gracePeriodExtensionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { gracePeriodExtension_ = boost::shared_ptr<GracePeriodExtension>(new GracePeriodExtension(gracePeriodExtensionNode));}
   }

   //paymentRequirementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentRequirementNode = xmlNode->FirstChildElement("paymentRequirement");

   if(paymentRequirementNode){paymentRequirementIsNull_ = false;}
   else{paymentRequirementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentRequirementNode , address : " << paymentRequirementNode << std::endl;
   #endif
   if(paymentRequirementNode)
   {
      if(paymentRequirementNode->Attribute("href") || paymentRequirementNode->Attribute("id"))
      {
          if(paymentRequirementNode->Attribute("id"))
          {
             paymentRequirementIDRef_ = paymentRequirementNode->Attribute("id");
             paymentRequirement_ = boost::shared_ptr<Money>(new Money(paymentRequirementNode));
             paymentRequirement_->setID(paymentRequirementIDRef_);
             IDManager::instance().setID(paymentRequirementIDRef_,paymentRequirement_);
          }
          else if(paymentRequirementNode->Attribute("href")) { paymentRequirementIDRef_ = paymentRequirementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentRequirement_ = boost::shared_ptr<Money>(new Money(paymentRequirementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> FailureToPay::getApplicable()
{
   if(!this->applicableIsNull_){
        if(applicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(applicableIDRef_));
        }else{
             return this->applicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<GracePeriodExtension> FailureToPay::getGracePeriodExtension()
{
   if(!this->gracePeriodExtensionIsNull_){
        if(gracePeriodExtensionIDRef_ != ""){
             return boost::shared_static_cast<GracePeriodExtension>(IDManager::instance().getID(gracePeriodExtensionIDRef_));
        }else{
             return this->gracePeriodExtension_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GracePeriodExtension>();
   }
}
boost::shared_ptr<Money> FailureToPay::getPaymentRequirement()
{
   if(!this->paymentRequirementIsNull_){
        if(paymentRequirementIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(paymentRequirementIDRef_));
        }else{
             return this->paymentRequirement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

