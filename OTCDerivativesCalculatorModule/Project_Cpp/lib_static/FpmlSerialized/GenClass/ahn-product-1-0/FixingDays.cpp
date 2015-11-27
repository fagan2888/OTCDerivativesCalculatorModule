// FixingDays.cpp 
#include "FixingDays.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixingDays::FixingDays(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //daysNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* daysNode = xmlNode->FirstChildElement("days");

   if(daysNode){daysIsNull_ = false;}
   else{daysIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- daysNode , address : " << daysNode << std::endl;
   #endif
   if(daysNode)
   {
      if(daysNode->Attribute("href") || daysNode->Attribute("id"))
      {
          if(daysNode->Attribute("id"))
          {
             daysIDRef_ = daysNode->Attribute("id");
             days_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(daysNode));
             days_->setID(daysIDRef_);
             IDManager::instance().setID(daysIDRef_,days_);
          }
          else if(daysNode->Attribute("href")) { daysIDRef_ = daysNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { days_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(daysNode));}
   }

   //monthsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* monthsNode = xmlNode->FirstChildElement("months");

   if(monthsNode){monthsIsNull_ = false;}
   else{monthsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- monthsNode , address : " << monthsNode << std::endl;
   #endif
   if(monthsNode)
   {
      if(monthsNode->Attribute("href") || monthsNode->Attribute("id"))
      {
          if(monthsNode->Attribute("id"))
          {
             monthsIDRef_ = monthsNode->Attribute("id");
             months_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(monthsNode));
             months_->setID(monthsIDRef_);
             IDManager::instance().setID(monthsIDRef_,months_);
          }
          else if(monthsNode->Attribute("href")) { monthsIDRef_ = monthsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { months_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(monthsNode));}
   }

   //yearsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* yearsNode = xmlNode->FirstChildElement("years");

   if(yearsNode){yearsIsNull_ = false;}
   else{yearsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- yearsNode , address : " << yearsNode << std::endl;
   #endif
   if(yearsNode)
   {
      if(yearsNode->Attribute("href") || yearsNode->Attribute("id"))
      {
          if(yearsNode->Attribute("id"))
          {
             yearsIDRef_ = yearsNode->Attribute("id");
             years_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(yearsNode));
             years_->setID(yearsIDRef_);
             IDManager::instance().setID(yearsIDRef_,years_);
          }
          else if(yearsNode->Attribute("href")) { yearsIDRef_ = yearsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { years_ = boost::shared_ptr<XsdTypeInteger>(new XsdTypeInteger(yearsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeInteger> FixingDays::getDays()
{
   if(!this->daysIsNull_){
        if(daysIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeInteger>(IDManager::instance().getID(daysIDRef_));
        }else{
             return this->days_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<XsdTypeInteger> FixingDays::getMonths()
{
   if(!this->monthsIsNull_){
        if(monthsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeInteger>(IDManager::instance().getID(monthsIDRef_));
        }else{
             return this->months_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
boost::shared_ptr<XsdTypeInteger> FixingDays::getYears()
{
   if(!this->yearsIsNull_){
        if(yearsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeInteger>(IDManager::instance().getID(yearsIDRef_));
        }else{
             return this->years_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInteger>();
   }
}
}

