// DateInterval.cpp 
#include "DateInterval.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateInterval::DateInterval(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //firstDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstDateNode = xmlNode->FirstChildElement("firstDate");

   if(firstDateNode){firstDateIsNull_ = false;}
   else{firstDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstDateNode , address : " << firstDateNode << std::endl;
   #endif
   if(firstDateNode)
   {
      if(firstDateNode->Attribute("href") || firstDateNode->Attribute("id"))
      {
          if(firstDateNode->Attribute("id"))
          {
             firstDateIDRef_ = firstDateNode->Attribute("id");
             firstDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstDateNode));
             firstDate_->setID(firstDateIDRef_);
             IDManager::instance().setID(firstDateIDRef_,firstDate_);
          }
          else if(firstDateNode->Attribute("href")) { firstDateIDRef_ = firstDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstDateNode));}
   }

   //lastDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lastDateNode = xmlNode->FirstChildElement("lastDate");

   if(lastDateNode){lastDateIsNull_ = false;}
   else{lastDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lastDateNode , address : " << lastDateNode << std::endl;
   #endif
   if(lastDateNode)
   {
      if(lastDateNode->Attribute("href") || lastDateNode->Attribute("id"))
      {
          if(lastDateNode->Attribute("id"))
          {
             lastDateIDRef_ = lastDateNode->Attribute("id");
             lastDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastDateNode));
             lastDate_->setID(lastDateIDRef_);
             IDManager::instance().setID(lastDateIDRef_,lastDate_);
          }
          else if(lastDateNode->Attribute("href")) { lastDateIDRef_ = lastDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lastDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastDateNode));}
   }

   //dateForMonthlyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateForMonthlyNode = xmlNode->FirstChildElement("dateForMonthly");

   if(dateForMonthlyNode){dateForMonthlyIsNull_ = false;}
   else{dateForMonthlyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateForMonthlyNode , address : " << dateForMonthlyNode << std::endl;
   #endif
   if(dateForMonthlyNode)
   {
      if(dateForMonthlyNode->Attribute("href") || dateForMonthlyNode->Attribute("id"))
      {
          if(dateForMonthlyNode->Attribute("id"))
          {
             dateForMonthlyIDRef_ = dateForMonthlyNode->Attribute("id");
             dateForMonthly_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateForMonthlyNode));
             dateForMonthly_->setID(dateForMonthlyIDRef_);
             IDManager::instance().setID(dateForMonthlyIDRef_,dateForMonthly_);
          }
          else if(dateForMonthlyNode->Attribute("href")) { dateForMonthlyIDRef_ = dateForMonthlyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateForMonthly_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateForMonthlyNode));}
   }

   //dayOfWeekForWeeklyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayOfWeekForWeeklyNode = xmlNode->FirstChildElement("dayOfWeekForWeekly");

   if(dayOfWeekForWeeklyNode){dayOfWeekForWeeklyIsNull_ = false;}
   else{dayOfWeekForWeeklyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayOfWeekForWeeklyNode , address : " << dayOfWeekForWeeklyNode << std::endl;
   #endif
   if(dayOfWeekForWeeklyNode)
   {
      if(dayOfWeekForWeeklyNode->Attribute("href") || dayOfWeekForWeeklyNode->Attribute("id"))
      {
          if(dayOfWeekForWeeklyNode->Attribute("id"))
          {
             dayOfWeekForWeeklyIDRef_ = dayOfWeekForWeeklyNode->Attribute("id");
             dayOfWeekForWeekly_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dayOfWeekForWeeklyNode));
             dayOfWeekForWeekly_->setID(dayOfWeekForWeeklyIDRef_);
             IDManager::instance().setID(dayOfWeekForWeeklyIDRef_,dayOfWeekForWeekly_);
          }
          else if(dayOfWeekForWeeklyNode->Attribute("href")) { dayOfWeekForWeeklyIDRef_ = dayOfWeekForWeeklyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayOfWeekForWeekly_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dayOfWeekForWeeklyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> DateInterval::getFirstDate()
{
   if(!this->firstDateIsNull_){
        if(firstDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(firstDateIDRef_));
        }else{
             return this->firstDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> DateInterval::getLastDate()
{
   if(!this->lastDateIsNull_){
        if(lastDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(lastDateIDRef_));
        }else{
             return this->lastDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> DateInterval::getDateForMonthly()
{
   if(!this->dateForMonthlyIsNull_){
        if(dateForMonthlyIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(dateForMonthlyIDRef_));
        }else{
             return this->dateForMonthly_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeToken> DateInterval::getDayOfWeekForWeekly()
{
   if(!this->dayOfWeekForWeeklyIsNull_){
        if(dayOfWeekForWeeklyIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(dayOfWeekForWeeklyIDRef_));
        }else{
             return this->dayOfWeekForWeekly_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

