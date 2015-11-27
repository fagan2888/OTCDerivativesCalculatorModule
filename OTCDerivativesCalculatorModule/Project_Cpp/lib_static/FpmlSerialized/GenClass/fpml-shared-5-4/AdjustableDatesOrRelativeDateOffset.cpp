// AdjustableDatesOrRelativeDateOffset.cpp 
#include "AdjustableDatesOrRelativeDateOffset.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustableDatesOrRelativeDateOffset::AdjustableDatesOrRelativeDateOffset(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustableDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustableDatesNode = xmlNode->FirstChildElement("adjustableDates");

   if(adjustableDatesNode){adjustableDatesIsNull_ = false;}
   else{adjustableDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustableDatesNode , address : " << adjustableDatesNode << std::endl;
   #endif
   if(adjustableDatesNode)
   {
      if(adjustableDatesNode->Attribute("href") || adjustableDatesNode->Attribute("id"))
      {
          if(adjustableDatesNode->Attribute("id"))
          {
             adjustableDatesIDRef_ = adjustableDatesNode->Attribute("id");
             adjustableDates_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(adjustableDatesNode));
             adjustableDates_->setID(adjustableDatesIDRef_);
             IDManager::instance().setID(adjustableDatesIDRef_,adjustableDates_);
          }
          else if(adjustableDatesNode->Attribute("href")) { adjustableDatesIDRef_ = adjustableDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustableDates_ = boost::shared_ptr<AdjustableDates>(new AdjustableDates(adjustableDatesNode));}
   }

   //relativeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDateNode = xmlNode->FirstChildElement("relativeDate");

   if(relativeDateNode){relativeDateIsNull_ = false;}
   else{relativeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDateNode , address : " << relativeDateNode << std::endl;
   #endif
   if(relativeDateNode)
   {
      if(relativeDateNode->Attribute("href") || relativeDateNode->Attribute("id"))
      {
          if(relativeDateNode->Attribute("id"))
          {
             relativeDateIDRef_ = relativeDateNode->Attribute("id");
             relativeDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeDateNode));
             relativeDate_->setID(relativeDateIDRef_);
             IDManager::instance().setID(relativeDateIDRef_,relativeDate_);
          }
          else if(relativeDateNode->Attribute("href")) { relativeDateIDRef_ = relativeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDate_ = boost::shared_ptr<RelativeDateOffset>(new RelativeDateOffset(relativeDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDates> AdjustableDatesOrRelativeDateOffset::getAdjustableDates()
{
   if(!this->adjustableDatesIsNull_){
        if(adjustableDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDates>(IDManager::instance().getID(adjustableDatesIDRef_));
        }else{
             return this->adjustableDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDates>();
   }
}
boost::shared_ptr<RelativeDateOffset> AdjustableDatesOrRelativeDateOffset::getRelativeDate()
{
   if(!this->relativeDateIsNull_){
        if(relativeDateIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateOffset>(IDManager::instance().getID(relativeDateIDRef_));
        }else{
             return this->relativeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateOffset>();
   }
}
}

