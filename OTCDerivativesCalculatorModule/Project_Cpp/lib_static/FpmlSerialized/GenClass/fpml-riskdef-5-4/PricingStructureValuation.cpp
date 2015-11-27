// PricingStructureValuation.cpp 
#include "PricingStructureValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingStructureValuation::PricingStructureValuation(TiXmlNode* xmlNode)
: Valuation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //baseDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseDateNode = xmlNode->FirstChildElement("baseDate");

   if(baseDateNode){baseDateIsNull_ = false;}
   else{baseDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseDateNode , address : " << baseDateNode << std::endl;
   #endif
   if(baseDateNode)
   {
      if(baseDateNode->Attribute("href") || baseDateNode->Attribute("id"))
      {
          if(baseDateNode->Attribute("id"))
          {
             baseDateIDRef_ = baseDateNode->Attribute("id");
             baseDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(baseDateNode));
             baseDate_->setID(baseDateIDRef_);
             IDManager::instance().setID(baseDateIDRef_,baseDate_);
          }
          else if(baseDateNode->Attribute("href")) { baseDateIDRef_ = baseDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(baseDateNode));}
   }

   //spotDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spotDateNode = xmlNode->FirstChildElement("spotDate");

   if(spotDateNode){spotDateIsNull_ = false;}
   else{spotDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spotDateNode , address : " << spotDateNode << std::endl;
   #endif
   if(spotDateNode)
   {
      if(spotDateNode->Attribute("href") || spotDateNode->Attribute("id"))
      {
          if(spotDateNode->Attribute("id"))
          {
             spotDateIDRef_ = spotDateNode->Attribute("id");
             spotDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(spotDateNode));
             spotDate_->setID(spotDateIDRef_);
             IDManager::instance().setID(spotDateIDRef_,spotDate_);
          }
          else if(spotDateNode->Attribute("href")) { spotDateIDRef_ = spotDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spotDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(spotDateNode));}
   }

   //inputDataDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inputDataDateNode = xmlNode->FirstChildElement("inputDataDate");

   if(inputDataDateNode){inputDataDateIsNull_ = false;}
   else{inputDataDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inputDataDateNode , address : " << inputDataDateNode << std::endl;
   #endif
   if(inputDataDateNode)
   {
      if(inputDataDateNode->Attribute("href") || inputDataDateNode->Attribute("id"))
      {
          if(inputDataDateNode->Attribute("id"))
          {
             inputDataDateIDRef_ = inputDataDateNode->Attribute("id");
             inputDataDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(inputDataDateNode));
             inputDataDate_->setID(inputDataDateIDRef_);
             IDManager::instance().setID(inputDataDateIDRef_,inputDataDate_);
          }
          else if(inputDataDateNode->Attribute("href")) { inputDataDateIDRef_ = inputDataDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { inputDataDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(inputDataDateNode));}
   }

   //endDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endDateNode = xmlNode->FirstChildElement("endDate");

   if(endDateNode){endDateIsNull_ = false;}
   else{endDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endDateNode , address : " << endDateNode << std::endl;
   #endif
   if(endDateNode)
   {
      if(endDateNode->Attribute("href") || endDateNode->Attribute("id"))
      {
          if(endDateNode->Attribute("id"))
          {
             endDateIDRef_ = endDateNode->Attribute("id");
             endDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(endDateNode));
             endDate_->setID(endDateIDRef_);
             IDManager::instance().setID(endDateIDRef_,endDate_);
          }
          else if(endDateNode->Attribute("href")) { endDateIDRef_ = endDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(endDateNode));}
   }

   //buildDateTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buildDateTimeNode = xmlNode->FirstChildElement("buildDateTime");

   if(buildDateTimeNode){buildDateTimeIsNull_ = false;}
   else{buildDateTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buildDateTimeNode , address : " << buildDateTimeNode << std::endl;
   #endif
   if(buildDateTimeNode)
   {
      if(buildDateTimeNode->Attribute("href") || buildDateTimeNode->Attribute("id"))
      {
          if(buildDateTimeNode->Attribute("id"))
          {
             buildDateTimeIDRef_ = buildDateTimeNode->Attribute("id");
             buildDateTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(buildDateTimeNode));
             buildDateTime_->setID(buildDateTimeIDRef_);
             IDManager::instance().setID(buildDateTimeIDRef_,buildDateTime_);
          }
          else if(buildDateTimeNode->Attribute("href")) { buildDateTimeIDRef_ = buildDateTimeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buildDateTime_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(buildDateTimeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IdentifiedDate> PricingStructureValuation::getBaseDate()
{
   if(!this->baseDateIsNull_){
        if(baseDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(baseDateIDRef_));
        }else{
             return this->baseDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<IdentifiedDate> PricingStructureValuation::getSpotDate()
{
   if(!this->spotDateIsNull_){
        if(spotDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(spotDateIDRef_));
        }else{
             return this->spotDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<IdentifiedDate> PricingStructureValuation::getInputDataDate()
{
   if(!this->inputDataDateIsNull_){
        if(inputDataDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(inputDataDateIDRef_));
        }else{
             return this->inputDataDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<IdentifiedDate> PricingStructureValuation::getEndDate()
{
   if(!this->endDateIsNull_){
        if(endDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(endDateIDRef_));
        }else{
             return this->endDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<XsdTypeDateTime> PricingStructureValuation::getBuildDateTime()
{
   if(!this->buildDateTimeIsNull_){
        if(buildDateTimeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(buildDateTimeIDRef_));
        }else{
             return this->buildDateTime_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
}

