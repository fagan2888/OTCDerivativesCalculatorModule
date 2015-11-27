// Reason.cpp 
#include "Reason.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Reason::Reason(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //reasonCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reasonCodeNode = xmlNode->FirstChildElement("reasonCode");

   if(reasonCodeNode){reasonCodeIsNull_ = false;}
   else{reasonCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reasonCodeNode , address : " << reasonCodeNode << std::endl;
   #endif
   if(reasonCodeNode)
   {
      if(reasonCodeNode->Attribute("href") || reasonCodeNode->Attribute("id"))
      {
          if(reasonCodeNode->Attribute("id"))
          {
             reasonCodeIDRef_ = reasonCodeNode->Attribute("id");
             reasonCode_ = boost::shared_ptr<ReasonCode>(new ReasonCode(reasonCodeNode));
             reasonCode_->setID(reasonCodeIDRef_);
             IDManager::instance().setID(reasonCodeIDRef_,reasonCode_);
          }
          else if(reasonCodeNode->Attribute("href")) { reasonCodeIDRef_ = reasonCodeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { reasonCode_ = boost::shared_ptr<ReasonCode>(new ReasonCode(reasonCodeNode));}
   }

   //locationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* locationNode = xmlNode->FirstChildElement("location");

   if(locationNode){locationIsNull_ = false;}
   else{locationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- locationNode , address : " << locationNode << std::endl;
   #endif
   if(locationNode)
   {
      if(locationNode->Attribute("href") || locationNode->Attribute("id"))
      {
          if(locationNode->Attribute("id"))
          {
             locationIDRef_ = locationNode->Attribute("id");
             location_ = boost::shared_ptr<ProblemLocation>(new ProblemLocation(locationNode));
             location_->setID(locationIDRef_);
             IDManager::instance().setID(locationIDRef_,location_);
          }
          else if(locationNode->Attribute("href")) { locationIDRef_ = locationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { location_ = boost::shared_ptr<ProblemLocation>(new ProblemLocation(locationNode));}
   }

   //descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* descriptionNode = xmlNode->FirstChildElement("description");

   if(descriptionNode){descriptionIsNull_ = false;}
   else{descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- descriptionNode , address : " << descriptionNode << std::endl;
   #endif
   if(descriptionNode)
   {
      if(descriptionNode->Attribute("href") || descriptionNode->Attribute("id"))
      {
          if(descriptionNode->Attribute("id"))
          {
             descriptionIDRef_ = descriptionNode->Attribute("id");
             description_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(descriptionNode));
             description_->setID(descriptionIDRef_);
             IDManager::instance().setID(descriptionIDRef_,description_);
          }
          else if(descriptionNode->Attribute("href")) { descriptionIDRef_ = descriptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { description_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(descriptionNode));}
   }

   //validationRuleIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* validationRuleIdNode = xmlNode->FirstChildElement("validationRuleId");

   if(validationRuleIdNode){validationRuleIdIsNull_ = false;}
   else{validationRuleIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- validationRuleIdNode , address : " << validationRuleIdNode << std::endl;
   #endif
   if(validationRuleIdNode)
   {
      if(validationRuleIdNode->Attribute("href") || validationRuleIdNode->Attribute("id"))
      {
          if(validationRuleIdNode->Attribute("id"))
          {
             validationRuleIdIDRef_ = validationRuleIdNode->Attribute("id");
             validationRuleId_ = boost::shared_ptr<Validation>(new Validation(validationRuleIdNode));
             validationRuleId_->setID(validationRuleIdIDRef_);
             IDManager::instance().setID(validationRuleIdIDRef_,validationRuleId_);
          }
          else if(validationRuleIdNode->Attribute("href")) { validationRuleIdIDRef_ = validationRuleIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { validationRuleId_ = boost::shared_ptr<Validation>(new Validation(validationRuleIdNode));}
   }

   //additionalDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalDataNode = xmlNode->FirstChildElement("additionalData");

   if(additionalDataNode){additionalDataIsNull_ = false;}
   else{additionalDataIsNull_ = true;}

   if(additionalDataNode)
   {
      for(additionalDataNode; additionalDataNode; additionalDataNode = additionalDataNode->NextSiblingElement("additionalData")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalDataNode , address : " << additionalDataNode << std::endl;
          #endif
          if(additionalDataNode->Attribute("href") || additionalDataNode->Attribute("id"))
          {
              if(additionalDataNode->Attribute("id"))
              {
                  additionalDataIDRef_ = additionalDataNode->Attribute("id");
                  additionalData_.push_back(boost::shared_ptr<AdditionalData>(new AdditionalData(additionalDataNode)));
                  additionalData_.back()->setID(additionalDataIDRef_);
                  IDManager::instance().setID(additionalDataIDRef_, additionalData_.back());
              }
              else if(additionalDataNode->Attribute("href")) { additionalDataIDRef_ = additionalDataNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { additionalData_.push_back(boost::shared_ptr<AdditionalData>(new AdditionalData(additionalDataNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalDataNode , address : " << additionalDataNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReasonCode> Reason::getReasonCode()
{
   if(!this->reasonCodeIsNull_){
        if(reasonCodeIDRef_ != ""){
             return boost::shared_static_cast<ReasonCode>(IDManager::instance().getID(reasonCodeIDRef_));
        }else{
             return this->reasonCode_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReasonCode>();
   }
}
boost::shared_ptr<ProblemLocation> Reason::getLocation()
{
   if(!this->locationIsNull_){
        if(locationIDRef_ != ""){
             return boost::shared_static_cast<ProblemLocation>(IDManager::instance().getID(locationIDRef_));
        }else{
             return this->location_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProblemLocation>();
   }
}
boost::shared_ptr<XsdTypeString> Reason::getDescription()
{
   if(!this->descriptionIsNull_){
        if(descriptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(descriptionIDRef_));
        }else{
             return this->description_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<Validation> Reason::getValidationRuleId()
{
   if(!this->validationRuleIdIsNull_){
        if(validationRuleIdIDRef_ != ""){
             return boost::shared_static_cast<Validation>(IDManager::instance().getID(validationRuleIdIDRef_));
        }else{
             return this->validationRuleId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Validation>();
   }
}
std::vector<boost::shared_ptr<AdditionalData>> Reason::getAdditionalData()
{
   if(!this->additionalDataIsNull_){
        if(additionalDataIDRef_ != ""){
             return this->additionalData_;
        }else{
             return this->additionalData_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AdditionalData>>();
   }
}
}

