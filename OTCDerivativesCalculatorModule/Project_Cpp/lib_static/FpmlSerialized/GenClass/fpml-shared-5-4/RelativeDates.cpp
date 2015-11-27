// RelativeDates.cpp 
#include "RelativeDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RelativeDates::RelativeDates(TiXmlNode* xmlNode)
: RelativeDateOffset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //periodSkipNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* periodSkipNode = xmlNode->FirstChildElement("periodSkip");

   if(periodSkipNode){periodSkipIsNull_ = false;}
   else{periodSkipIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- periodSkipNode , address : " << periodSkipNode << std::endl;
   #endif
   if(periodSkipNode)
   {
      if(periodSkipNode->Attribute("href") || periodSkipNode->Attribute("id"))
      {
          if(periodSkipNode->Attribute("id"))
          {
             periodSkipIDRef_ = periodSkipNode->Attribute("id");
             periodSkip_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(periodSkipNode));
             periodSkip_->setID(periodSkipIDRef_);
             IDManager::instance().setID(periodSkipIDRef_,periodSkip_);
          }
          else if(periodSkipNode->Attribute("href")) { periodSkipIDRef_ = periodSkipNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { periodSkip_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(periodSkipNode));}
   }

   //scheduleBoundsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* scheduleBoundsNode = xmlNode->FirstChildElement("scheduleBounds");

   if(scheduleBoundsNode){scheduleBoundsIsNull_ = false;}
   else{scheduleBoundsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduleBoundsNode , address : " << scheduleBoundsNode << std::endl;
   #endif
   if(scheduleBoundsNode)
   {
      if(scheduleBoundsNode->Attribute("href") || scheduleBoundsNode->Attribute("id"))
      {
          if(scheduleBoundsNode->Attribute("id"))
          {
             scheduleBoundsIDRef_ = scheduleBoundsNode->Attribute("id");
             scheduleBounds_ = boost::shared_ptr<DateRange>(new DateRange(scheduleBoundsNode));
             scheduleBounds_->setID(scheduleBoundsIDRef_);
             IDManager::instance().setID(scheduleBoundsIDRef_,scheduleBounds_);
          }
          else if(scheduleBoundsNode->Attribute("href")) { scheduleBoundsIDRef_ = scheduleBoundsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { scheduleBounds_ = boost::shared_ptr<DateRange>(new DateRange(scheduleBoundsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypePositiveInteger> RelativeDates::getPeriodSkip()
{
   if(!this->periodSkipIsNull_){
        if(periodSkipIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(periodSkipIDRef_));
        }else{
             return this->periodSkip_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<DateRange> RelativeDates::getScheduleBounds()
{
   if(!this->scheduleBoundsIsNull_){
        if(scheduleBoundsIDRef_ != ""){
             return boost::shared_static_cast<DateRange>(IDManager::instance().getID(scheduleBoundsIDRef_));
        }else{
             return this->scheduleBounds_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateRange>();
   }
}
}

