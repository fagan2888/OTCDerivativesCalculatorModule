// TimeDimension.cpp 
#include "TimeDimension.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TimeDimension::TimeDimension(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNode = xmlNode->FirstChildElement("tenor");

   if(tenorNode){tenorIsNull_ = false;}
   else{tenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
   #endif
   if(tenorNode)
   {
      if(tenorNode->Attribute("href") || tenorNode->Attribute("id"))
      {
          if(tenorNode->Attribute("id"))
          {
             tenorIDRef_ = tenorNode->Attribute("id");
             tenor_ = boost::shared_ptr<Period>(new Period(tenorNode));
             tenor_->setID(tenorIDRef_);
             IDManager::instance().setID(tenorIDRef_,tenor_);
          }
          else if(tenorNode->Attribute("href")) { tenorIDRef_ = tenorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tenor_ = boost::shared_ptr<Period>(new Period(tenorNode));}
   }

   //dateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateNode = xmlNode->FirstChildElement("date");

   if(dateNode){dateIsNull_ = false;}
   else{dateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
   #endif
   if(dateNode)
   {
      if(dateNode->Attribute("href") || dateNode->Attribute("id"))
      {
          if(dateNode->Attribute("id"))
          {
             dateIDRef_ = dateNode->Attribute("id");
             date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));
             date_->setID(dateIDRef_);
             IDManager::instance().setID(dateIDRef_,date_);
          }
          else if(dateNode->Attribute("href")) { dateIDRef_ = dateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Period> TimeDimension::getTenor()
{
   if(!this->tenorIsNull_){
        if(tenorIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(tenorIDRef_));
        }else{
             return this->tenor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<XsdTypeDate> TimeDimension::getDate()
{
   if(!this->dateIsNull_){
        if(dateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(dateIDRef_));
        }else{
             return this->date_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

