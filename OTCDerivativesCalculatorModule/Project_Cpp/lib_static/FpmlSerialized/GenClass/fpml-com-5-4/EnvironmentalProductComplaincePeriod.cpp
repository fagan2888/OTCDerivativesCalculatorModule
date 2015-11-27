// EnvironmentalProductComplaincePeriod.cpp 
#include "EnvironmentalProductComplaincePeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EnvironmentalProductComplaincePeriod::EnvironmentalProductComplaincePeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //startYearNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* startYearNode = xmlNode->FirstChildElement("startYear");

   if(startYearNode){startYearIsNull_ = false;}
   else{startYearIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- startYearNode , address : " << startYearNode << std::endl;
   #endif
   if(startYearNode)
   {
      if(startYearNode->Attribute("href") || startYearNode->Attribute("id"))
      {
          if(startYearNode->Attribute("id"))
          {
             startYearIDRef_ = startYearNode->Attribute("id");
             startYear_ = boost::shared_ptr<XsdTypeGYear>(new XsdTypeGYear(startYearNode));
             startYear_->setID(startYearIDRef_);
             IDManager::instance().setID(startYearIDRef_,startYear_);
          }
          else if(startYearNode->Attribute("href")) { startYearIDRef_ = startYearNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { startYear_ = boost::shared_ptr<XsdTypeGYear>(new XsdTypeGYear(startYearNode));}
   }

   //endYearNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endYearNode = xmlNode->FirstChildElement("endYear");

   if(endYearNode){endYearIsNull_ = false;}
   else{endYearIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endYearNode , address : " << endYearNode << std::endl;
   #endif
   if(endYearNode)
   {
      if(endYearNode->Attribute("href") || endYearNode->Attribute("id"))
      {
          if(endYearNode->Attribute("id"))
          {
             endYearIDRef_ = endYearNode->Attribute("id");
             endYear_ = boost::shared_ptr<XsdTypeGYear>(new XsdTypeGYear(endYearNode));
             endYear_->setID(endYearIDRef_);
             IDManager::instance().setID(endYearIDRef_,endYear_);
          }
          else if(endYearNode->Attribute("href")) { endYearIDRef_ = endYearNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endYear_ = boost::shared_ptr<XsdTypeGYear>(new XsdTypeGYear(endYearNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeGYear> EnvironmentalProductComplaincePeriod::getStartYear()
{
   if(!this->startYearIsNull_){
        if(startYearIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeGYear>(IDManager::instance().getID(startYearIDRef_));
        }else{
             return this->startYear_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeGYear>();
   }
}
boost::shared_ptr<XsdTypeGYear> EnvironmentalProductComplaincePeriod::getEndYear()
{
   if(!this->endYearIsNull_){
        if(endYearIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeGYear>(IDManager::instance().getID(endYearIDRef_));
        }else{
             return this->endYear_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeGYear>();
   }
}
}

