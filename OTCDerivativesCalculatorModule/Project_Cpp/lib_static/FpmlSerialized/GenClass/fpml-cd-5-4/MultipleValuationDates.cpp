// MultipleValuationDates.cpp 
#include "MultipleValuationDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MultipleValuationDates::MultipleValuationDates(TiXmlNode* xmlNode)
: SingleValuationDate(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessDaysThereafterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDaysThereafterNode = xmlNode->FirstChildElement("businessDaysThereafter");

   if(businessDaysThereafterNode){businessDaysThereafterIsNull_ = false;}
   else{businessDaysThereafterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDaysThereafterNode , address : " << businessDaysThereafterNode << std::endl;
   #endif
   if(businessDaysThereafterNode)
   {
      if(businessDaysThereafterNode->Attribute("href") || businessDaysThereafterNode->Attribute("id"))
      {
          if(businessDaysThereafterNode->Attribute("id"))
          {
             businessDaysThereafterIDRef_ = businessDaysThereafterNode->Attribute("id");
             businessDaysThereafter_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(businessDaysThereafterNode));
             businessDaysThereafter_->setID(businessDaysThereafterIDRef_);
             IDManager::instance().setID(businessDaysThereafterIDRef_,businessDaysThereafter_);
          }
          else if(businessDaysThereafterNode->Attribute("href")) { businessDaysThereafterIDRef_ = businessDaysThereafterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDaysThereafter_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(businessDaysThereafterNode));}
   }

   //numberValuationDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberValuationDatesNode = xmlNode->FirstChildElement("numberValuationDates");

   if(numberValuationDatesNode){numberValuationDatesIsNull_ = false;}
   else{numberValuationDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberValuationDatesNode , address : " << numberValuationDatesNode << std::endl;
   #endif
   if(numberValuationDatesNode)
   {
      if(numberValuationDatesNode->Attribute("href") || numberValuationDatesNode->Attribute("id"))
      {
          if(numberValuationDatesNode->Attribute("id"))
          {
             numberValuationDatesIDRef_ = numberValuationDatesNode->Attribute("id");
             numberValuationDates_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(numberValuationDatesNode));
             numberValuationDates_->setID(numberValuationDatesIDRef_);
             IDManager::instance().setID(numberValuationDatesIDRef_,numberValuationDates_);
          }
          else if(numberValuationDatesNode->Attribute("href")) { numberValuationDatesIDRef_ = numberValuationDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberValuationDates_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(numberValuationDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypePositiveInteger> MultipleValuationDates::getBusinessDaysThereafter()
{
   if(!this->businessDaysThereafterIsNull_){
        if(businessDaysThereafterIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(businessDaysThereafterIDRef_));
        }else{
             return this->businessDaysThereafter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> MultipleValuationDates::getNumberValuationDates()
{
   if(!this->numberValuationDatesIsNull_){
        if(numberValuationDatesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(numberValuationDatesIDRef_));
        }else{
             return this->numberValuationDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

