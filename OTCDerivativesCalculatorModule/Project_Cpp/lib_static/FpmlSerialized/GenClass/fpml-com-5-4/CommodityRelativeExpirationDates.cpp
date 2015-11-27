// CommodityRelativeExpirationDates.cpp 
#include "CommodityRelativeExpirationDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityRelativeExpirationDates::CommodityRelativeExpirationDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //expireRelativeToEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expireRelativeToEventNode = xmlNode->FirstChildElement("expireRelativeToEvent");

   if(expireRelativeToEventNode){expireRelativeToEventIsNull_ = false;}
   else{expireRelativeToEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expireRelativeToEventNode , address : " << expireRelativeToEventNode << std::endl;
   #endif
   if(expireRelativeToEventNode)
   {
      if(expireRelativeToEventNode->Attribute("href") || expireRelativeToEventNode->Attribute("id"))
      {
          if(expireRelativeToEventNode->Attribute("id"))
          {
             expireRelativeToEventIDRef_ = expireRelativeToEventNode->Attribute("id");
             expireRelativeToEvent_ = boost::shared_ptr<CommodityExpireRelativeToEvent>(new CommodityExpireRelativeToEvent(expireRelativeToEventNode));
             expireRelativeToEvent_->setID(expireRelativeToEventIDRef_);
             IDManager::instance().setID(expireRelativeToEventIDRef_,expireRelativeToEvent_);
          }
          else if(expireRelativeToEventNode->Attribute("href")) { expireRelativeToEventIDRef_ = expireRelativeToEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expireRelativeToEvent_ = boost::shared_ptr<CommodityExpireRelativeToEvent>(new CommodityExpireRelativeToEvent(expireRelativeToEventNode));}
   }

   //expirationDateOffsetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationDateOffsetNode = xmlNode->FirstChildElement("expirationDateOffset");

   if(expirationDateOffsetNode){expirationDateOffsetIsNull_ = false;}
   else{expirationDateOffsetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationDateOffsetNode , address : " << expirationDateOffsetNode << std::endl;
   #endif
   if(expirationDateOffsetNode)
   {
      if(expirationDateOffsetNode->Attribute("href") || expirationDateOffsetNode->Attribute("id"))
      {
          if(expirationDateOffsetNode->Attribute("id"))
          {
             expirationDateOffsetIDRef_ = expirationDateOffsetNode->Attribute("id");
             expirationDateOffset_ = boost::shared_ptr<DateOffset>(new DateOffset(expirationDateOffsetNode));
             expirationDateOffset_->setID(expirationDateOffsetIDRef_);
             IDManager::instance().setID(expirationDateOffsetIDRef_,expirationDateOffset_);
          }
          else if(expirationDateOffsetNode->Attribute("href")) { expirationDateOffsetIDRef_ = expirationDateOffsetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDateOffset_ = boost::shared_ptr<DateOffset>(new DateOffset(expirationDateOffsetNode));}
   }

   //businessCentersReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersReferenceNode = xmlNode->FirstChildElement("businessCentersReference");

   if(businessCentersReferenceNode){businessCentersReferenceIsNull_ = false;}
   else{businessCentersReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersReferenceNode , address : " << businessCentersReferenceNode << std::endl;
   #endif
   if(businessCentersReferenceNode)
   {
      if(businessCentersReferenceNode->Attribute("href") || businessCentersReferenceNode->Attribute("id"))
      {
          if(businessCentersReferenceNode->Attribute("id"))
          {
             businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("id");
             businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));
             businessCentersReference_->setID(businessCentersReferenceIDRef_);
             IDManager::instance().setID(businessCentersReferenceIDRef_,businessCentersReference_);
          }
          else if(businessCentersReferenceNode->Attribute("href")) { businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));}
   }

   //businessCentersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersNode = xmlNode->FirstChildElement("businessCenters");

   if(businessCentersNode){businessCentersIsNull_ = false;}
   else{businessCentersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersNode , address : " << businessCentersNode << std::endl;
   #endif
   if(businessCentersNode)
   {
      if(businessCentersNode->Attribute("href") || businessCentersNode->Attribute("id"))
      {
          if(businessCentersNode->Attribute("id"))
          {
             businessCentersIDRef_ = businessCentersNode->Attribute("id");
             businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));
             businessCenters_->setID(businessCentersIDRef_);
             IDManager::instance().setID(businessCentersIDRef_,businessCenters_);
          }
          else if(businessCentersNode->Attribute("href")) { businessCentersIDRef_ = businessCentersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CommodityExpireRelativeToEvent> CommodityRelativeExpirationDates::getExpireRelativeToEvent()
{
   if(!this->expireRelativeToEventIsNull_){
        if(expireRelativeToEventIDRef_ != ""){
             return boost::shared_static_cast<CommodityExpireRelativeToEvent>(IDManager::instance().getID(expireRelativeToEventIDRef_));
        }else{
             return this->expireRelativeToEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityExpireRelativeToEvent>();
   }
}
boost::shared_ptr<DateOffset> CommodityRelativeExpirationDates::getExpirationDateOffset()
{
   if(!this->expirationDateOffsetIsNull_){
        if(expirationDateOffsetIDRef_ != ""){
             return boost::shared_static_cast<DateOffset>(IDManager::instance().getID(expirationDateOffsetIDRef_));
        }else{
             return this->expirationDateOffset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateOffset>();
   }
}
boost::shared_ptr<BusinessCentersReference> CommodityRelativeExpirationDates::getBusinessCentersReference()
{
   if(!this->businessCentersReferenceIsNull_){
        if(businessCentersReferenceIDRef_ != ""){
             return boost::shared_static_cast<BusinessCentersReference>(IDManager::instance().getID(businessCentersReferenceIDRef_));
        }else{
             return this->businessCentersReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCentersReference>();
   }
}
boost::shared_ptr<BusinessCenters> CommodityRelativeExpirationDates::getBusinessCenters()
{
   if(!this->businessCentersIsNull_){
        if(businessCentersIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenters>(IDManager::instance().getID(businessCentersIDRef_));
        }else{
             return this->businessCenters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenters>();
   }
}
}

