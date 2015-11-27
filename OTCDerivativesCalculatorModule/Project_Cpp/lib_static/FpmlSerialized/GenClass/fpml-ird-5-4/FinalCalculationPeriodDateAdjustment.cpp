// FinalCalculationPeriodDateAdjustment.cpp 
#include "FinalCalculationPeriodDateAdjustment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FinalCalculationPeriodDateAdjustment::FinalCalculationPeriodDateAdjustment(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //relevantUnderlyingDateReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relevantUnderlyingDateReferenceNode = xmlNode->FirstChildElement("relevantUnderlyingDateReference");

   if(relevantUnderlyingDateReferenceNode){relevantUnderlyingDateReferenceIsNull_ = false;}
   else{relevantUnderlyingDateReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relevantUnderlyingDateReferenceNode , address : " << relevantUnderlyingDateReferenceNode << std::endl;
   #endif
   if(relevantUnderlyingDateReferenceNode)
   {
      if(relevantUnderlyingDateReferenceNode->Attribute("href") || relevantUnderlyingDateReferenceNode->Attribute("id"))
      {
          if(relevantUnderlyingDateReferenceNode->Attribute("id"))
          {
             relevantUnderlyingDateReferenceIDRef_ = relevantUnderlyingDateReferenceNode->Attribute("id");
             relevantUnderlyingDateReference_ = boost::shared_ptr<RelevantUnderlyingDateReference>(new RelevantUnderlyingDateReference(relevantUnderlyingDateReferenceNode));
             relevantUnderlyingDateReference_->setID(relevantUnderlyingDateReferenceIDRef_);
             IDManager::instance().setID(relevantUnderlyingDateReferenceIDRef_,relevantUnderlyingDateReference_);
          }
          else if(relevantUnderlyingDateReferenceNode->Attribute("href")) { relevantUnderlyingDateReferenceIDRef_ = relevantUnderlyingDateReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relevantUnderlyingDateReference_ = boost::shared_ptr<RelevantUnderlyingDateReference>(new RelevantUnderlyingDateReference(relevantUnderlyingDateReferenceNode));}
   }

   //swapStreamReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapStreamReferenceNode = xmlNode->FirstChildElement("swapStreamReference");

   if(swapStreamReferenceNode){swapStreamReferenceIsNull_ = false;}
   else{swapStreamReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapStreamReferenceNode , address : " << swapStreamReferenceNode << std::endl;
   #endif
   if(swapStreamReferenceNode)
   {
      if(swapStreamReferenceNode->Attribute("href") || swapStreamReferenceNode->Attribute("id"))
      {
          if(swapStreamReferenceNode->Attribute("id"))
          {
             swapStreamReferenceIDRef_ = swapStreamReferenceNode->Attribute("id");
             swapStreamReference_ = boost::shared_ptr<InterestRateStreamReference>(new InterestRateStreamReference(swapStreamReferenceNode));
             swapStreamReference_->setID(swapStreamReferenceIDRef_);
             IDManager::instance().setID(swapStreamReferenceIDRef_,swapStreamReference_);
          }
          else if(swapStreamReferenceNode->Attribute("href")) { swapStreamReferenceIDRef_ = swapStreamReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { swapStreamReference_ = boost::shared_ptr<InterestRateStreamReference>(new InterestRateStreamReference(swapStreamReferenceNode));}
   }

   //businessDayConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConventionNode = xmlNode->FirstChildElement("businessDayConvention");

   if(businessDayConventionNode){businessDayConventionIsNull_ = false;}
   else{businessDayConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConventionNode , address : " << businessDayConventionNode << std::endl;
   #endif
   if(businessDayConventionNode)
   {
      if(businessDayConventionNode->Attribute("href") || businessDayConventionNode->Attribute("id"))
      {
          if(businessDayConventionNode->Attribute("id"))
          {
             businessDayConventionIDRef_ = businessDayConventionNode->Attribute("id");
             businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));
             businessDayConvention_->setID(businessDayConventionIDRef_);
             IDManager::instance().setID(businessDayConventionIDRef_,businessDayConvention_);
          }
          else if(businessDayConventionNode->Attribute("href")) { businessDayConventionIDRef_ = businessDayConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RelevantUnderlyingDateReference> FinalCalculationPeriodDateAdjustment::getRelevantUnderlyingDateReference()
{
   if(!this->relevantUnderlyingDateReferenceIsNull_){
        if(relevantUnderlyingDateReferenceIDRef_ != ""){
             return boost::shared_static_cast<RelevantUnderlyingDateReference>(IDManager::instance().getID(relevantUnderlyingDateReferenceIDRef_));
        }else{
             return this->relevantUnderlyingDateReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelevantUnderlyingDateReference>();
   }
}
boost::shared_ptr<InterestRateStreamReference> FinalCalculationPeriodDateAdjustment::getSwapStreamReference()
{
   if(!this->swapStreamReferenceIsNull_){
        if(swapStreamReferenceIDRef_ != ""){
             return boost::shared_static_cast<InterestRateStreamReference>(IDManager::instance().getID(swapStreamReferenceIDRef_));
        }else{
             return this->swapStreamReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestRateStreamReference>();
   }
}
boost::shared_ptr<BusinessDayConventionEnum> FinalCalculationPeriodDateAdjustment::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        if(businessDayConventionIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayConventionEnum>(IDManager::instance().getID(businessDayConventionIDRef_));
        }else{
             return this->businessDayConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayConventionEnum>();
   }
}
}

