// FloatingAmountEvents.cpp 
#include "FloatingAmountEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloatingAmountEvents::FloatingAmountEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //failureToPayPrincipalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToPayPrincipalNode = xmlNode->FirstChildElement("failureToPayPrincipal");

   if(failureToPayPrincipalNode){failureToPayPrincipalIsNull_ = false;}
   else{failureToPayPrincipalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToPayPrincipalNode , address : " << failureToPayPrincipalNode << std::endl;
   #endif
   if(failureToPayPrincipalNode)
   {
      if(failureToPayPrincipalNode->Attribute("href") || failureToPayPrincipalNode->Attribute("id"))
      {
          if(failureToPayPrincipalNode->Attribute("id"))
          {
             failureToPayPrincipalIDRef_ = failureToPayPrincipalNode->Attribute("id");
             failureToPayPrincipal_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToPayPrincipalNode));
             failureToPayPrincipal_->setID(failureToPayPrincipalIDRef_);
             IDManager::instance().setID(failureToPayPrincipalIDRef_,failureToPayPrincipal_);
          }
          else if(failureToPayPrincipalNode->Attribute("href")) { failureToPayPrincipalIDRef_ = failureToPayPrincipalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToPayPrincipal_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToPayPrincipalNode));}
   }

   //interestShortfallNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestShortfallNode = xmlNode->FirstChildElement("interestShortfall");

   if(interestShortfallNode){interestShortfallIsNull_ = false;}
   else{interestShortfallIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestShortfallNode , address : " << interestShortfallNode << std::endl;
   #endif
   if(interestShortfallNode)
   {
      if(interestShortfallNode->Attribute("href") || interestShortfallNode->Attribute("id"))
      {
          if(interestShortfallNode->Attribute("id"))
          {
             interestShortfallIDRef_ = interestShortfallNode->Attribute("id");
             interestShortfall_ = boost::shared_ptr<InterestShortFall>(new InterestShortFall(interestShortfallNode));
             interestShortfall_->setID(interestShortfallIDRef_);
             IDManager::instance().setID(interestShortfallIDRef_,interestShortfall_);
          }
          else if(interestShortfallNode->Attribute("href")) { interestShortfallIDRef_ = interestShortfallNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestShortfall_ = boost::shared_ptr<InterestShortFall>(new InterestShortFall(interestShortfallNode));}
   }

   //writedownNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* writedownNode = xmlNode->FirstChildElement("writedown");

   if(writedownNode){writedownIsNull_ = false;}
   else{writedownIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- writedownNode , address : " << writedownNode << std::endl;
   #endif
   if(writedownNode)
   {
      if(writedownNode->Attribute("href") || writedownNode->Attribute("id"))
      {
          if(writedownNode->Attribute("id"))
          {
             writedownIDRef_ = writedownNode->Attribute("id");
             writedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writedownNode));
             writedown_->setID(writedownIDRef_);
             IDManager::instance().setID(writedownIDRef_,writedown_);
          }
          else if(writedownNode->Attribute("href")) { writedownIDRef_ = writedownNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { writedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writedownNode));}
   }

   //impliedWritedownNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* impliedWritedownNode = xmlNode->FirstChildElement("impliedWritedown");

   if(impliedWritedownNode){impliedWritedownIsNull_ = false;}
   else{impliedWritedownIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- impliedWritedownNode , address : " << impliedWritedownNode << std::endl;
   #endif
   if(impliedWritedownNode)
   {
      if(impliedWritedownNode->Attribute("href") || impliedWritedownNode->Attribute("id"))
      {
          if(impliedWritedownNode->Attribute("id"))
          {
             impliedWritedownIDRef_ = impliedWritedownNode->Attribute("id");
             impliedWritedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(impliedWritedownNode));
             impliedWritedown_->setID(impliedWritedownIDRef_);
             IDManager::instance().setID(impliedWritedownIDRef_,impliedWritedown_);
          }
          else if(impliedWritedownNode->Attribute("href")) { impliedWritedownIDRef_ = impliedWritedownNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { impliedWritedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(impliedWritedownNode));}
   }

   //floatingAmountProvisionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingAmountProvisionsNode = xmlNode->FirstChildElement("floatingAmountProvisions");

   if(floatingAmountProvisionsNode){floatingAmountProvisionsIsNull_ = false;}
   else{floatingAmountProvisionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingAmountProvisionsNode , address : " << floatingAmountProvisionsNode << std::endl;
   #endif
   if(floatingAmountProvisionsNode)
   {
      if(floatingAmountProvisionsNode->Attribute("href") || floatingAmountProvisionsNode->Attribute("id"))
      {
          if(floatingAmountProvisionsNode->Attribute("id"))
          {
             floatingAmountProvisionsIDRef_ = floatingAmountProvisionsNode->Attribute("id");
             floatingAmountProvisions_ = boost::shared_ptr<FloatingAmountProvisions>(new FloatingAmountProvisions(floatingAmountProvisionsNode));
             floatingAmountProvisions_->setID(floatingAmountProvisionsIDRef_);
             IDManager::instance().setID(floatingAmountProvisionsIDRef_,floatingAmountProvisions_);
          }
          else if(floatingAmountProvisionsNode->Attribute("href")) { floatingAmountProvisionsIDRef_ = floatingAmountProvisionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingAmountProvisions_ = boost::shared_ptr<FloatingAmountProvisions>(new FloatingAmountProvisions(floatingAmountProvisionsNode));}
   }

   //additionalFixedPaymentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalFixedPaymentsNode = xmlNode->FirstChildElement("additionalFixedPayments");

   if(additionalFixedPaymentsNode){additionalFixedPaymentsIsNull_ = false;}
   else{additionalFixedPaymentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalFixedPaymentsNode , address : " << additionalFixedPaymentsNode << std::endl;
   #endif
   if(additionalFixedPaymentsNode)
   {
      if(additionalFixedPaymentsNode->Attribute("href") || additionalFixedPaymentsNode->Attribute("id"))
      {
          if(additionalFixedPaymentsNode->Attribute("id"))
          {
             additionalFixedPaymentsIDRef_ = additionalFixedPaymentsNode->Attribute("id");
             additionalFixedPayments_ = boost::shared_ptr<AdditionalFixedPayments>(new AdditionalFixedPayments(additionalFixedPaymentsNode));
             additionalFixedPayments_->setID(additionalFixedPaymentsIDRef_);
             IDManager::instance().setID(additionalFixedPaymentsIDRef_,additionalFixedPayments_);
          }
          else if(additionalFixedPaymentsNode->Attribute("href")) { additionalFixedPaymentsIDRef_ = additionalFixedPaymentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalFixedPayments_ = boost::shared_ptr<AdditionalFixedPayments>(new AdditionalFixedPayments(additionalFixedPaymentsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> FloatingAmountEvents::getFailureToPayPrincipal()
{
   if(!this->failureToPayPrincipalIsNull_){
        if(failureToPayPrincipalIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(failureToPayPrincipalIDRef_));
        }else{
             return this->failureToPayPrincipal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<InterestShortFall> FloatingAmountEvents::getInterestShortfall()
{
   if(!this->interestShortfallIsNull_){
        if(interestShortfallIDRef_ != ""){
             return boost::shared_static_cast<InterestShortFall>(IDManager::instance().getID(interestShortfallIDRef_));
        }else{
             return this->interestShortfall_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestShortFall>();
   }
}
boost::shared_ptr<XsdTypeBoolean> FloatingAmountEvents::getWritedown()
{
   if(!this->writedownIsNull_){
        if(writedownIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(writedownIDRef_));
        }else{
             return this->writedown_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> FloatingAmountEvents::getImpliedWritedown()
{
   if(!this->impliedWritedownIsNull_){
        if(impliedWritedownIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(impliedWritedownIDRef_));
        }else{
             return this->impliedWritedown_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<FloatingAmountProvisions> FloatingAmountEvents::getFloatingAmountProvisions()
{
   if(!this->floatingAmountProvisionsIsNull_){
        if(floatingAmountProvisionsIDRef_ != ""){
             return boost::shared_static_cast<FloatingAmountProvisions>(IDManager::instance().getID(floatingAmountProvisionsIDRef_));
        }else{
             return this->floatingAmountProvisions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingAmountProvisions>();
   }
}
boost::shared_ptr<AdditionalFixedPayments> FloatingAmountEvents::getAdditionalFixedPayments()
{
   if(!this->additionalFixedPaymentsIsNull_){
        if(additionalFixedPaymentsIDRef_ != ""){
             return boost::shared_static_cast<AdditionalFixedPayments>(IDManager::instance().getID(additionalFixedPaymentsIDRef_));
        }else{
             return this->additionalFixedPayments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionalFixedPayments>();
   }
}
}

