// FloatingAmountProvisions.cpp 
#include "FloatingAmountProvisions.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FloatingAmountProvisions::FloatingAmountProvisions(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //WACCapInterestProvisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* WACCapInterestProvisionNode = xmlNode->FirstChildElement("WACCapInterestProvision");

   if(WACCapInterestProvisionNode){WACCapInterestProvisionIsNull_ = false;}
   else{WACCapInterestProvisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- WACCapInterestProvisionNode , address : " << WACCapInterestProvisionNode << std::endl;
   #endif
   if(WACCapInterestProvisionNode)
   {
      if(WACCapInterestProvisionNode->Attribute("href") || WACCapInterestProvisionNode->Attribute("id"))
      {
          if(WACCapInterestProvisionNode->Attribute("id"))
          {
             WACCapInterestProvisionIDRef_ = WACCapInterestProvisionNode->Attribute("id");
             WACCapInterestProvision_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(WACCapInterestProvisionNode));
             WACCapInterestProvision_->setID(WACCapInterestProvisionIDRef_);
             IDManager::instance().setID(WACCapInterestProvisionIDRef_,WACCapInterestProvision_);
          }
          else if(WACCapInterestProvisionNode->Attribute("href")) { WACCapInterestProvisionIDRef_ = WACCapInterestProvisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { WACCapInterestProvision_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(WACCapInterestProvisionNode));}
   }

   //stepUpProvisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepUpProvisionNode = xmlNode->FirstChildElement("stepUpProvision");

   if(stepUpProvisionNode){stepUpProvisionIsNull_ = false;}
   else{stepUpProvisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepUpProvisionNode , address : " << stepUpProvisionNode << std::endl;
   #endif
   if(stepUpProvisionNode)
   {
      if(stepUpProvisionNode->Attribute("href") || stepUpProvisionNode->Attribute("id"))
      {
          if(stepUpProvisionNode->Attribute("id"))
          {
             stepUpProvisionIDRef_ = stepUpProvisionNode->Attribute("id");
             stepUpProvision_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(stepUpProvisionNode));
             stepUpProvision_->setID(stepUpProvisionIDRef_);
             IDManager::instance().setID(stepUpProvisionIDRef_,stepUpProvision_);
          }
          else if(stepUpProvisionNode->Attribute("href")) { stepUpProvisionIDRef_ = stepUpProvisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stepUpProvision_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(stepUpProvisionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> FloatingAmountProvisions::getWACCapInterestProvision()
{
   if(!this->WACCapInterestProvisionIsNull_){
        if(WACCapInterestProvisionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(WACCapInterestProvisionIDRef_));
        }else{
             return this->WACCapInterestProvision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> FloatingAmountProvisions::getStepUpProvision()
{
   if(!this->stepUpProvisionIsNull_){
        if(stepUpProvisionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(stepUpProvisionIDRef_));
        }else{
             return this->stepUpProvision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

