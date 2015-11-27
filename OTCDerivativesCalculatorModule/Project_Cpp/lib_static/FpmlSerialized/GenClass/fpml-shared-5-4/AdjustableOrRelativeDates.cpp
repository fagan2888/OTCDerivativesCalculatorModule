// AdjustableOrRelativeDates.cpp 
#include "AdjustableOrRelativeDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustableOrRelativeDates::AdjustableOrRelativeDates(TiXmlNode* xmlNode)
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

   //relativeDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDatesNode = xmlNode->FirstChildElement("relativeDates");

   if(relativeDatesNode){relativeDatesIsNull_ = false;}
   else{relativeDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDatesNode , address : " << relativeDatesNode << std::endl;
   #endif
   if(relativeDatesNode)
   {
      if(relativeDatesNode->Attribute("href") || relativeDatesNode->Attribute("id"))
      {
          if(relativeDatesNode->Attribute("id"))
          {
             relativeDatesIDRef_ = relativeDatesNode->Attribute("id");
             relativeDates_ = boost::shared_ptr<RelativeDates>(new RelativeDates(relativeDatesNode));
             relativeDates_->setID(relativeDatesIDRef_);
             IDManager::instance().setID(relativeDatesIDRef_,relativeDates_);
          }
          else if(relativeDatesNode->Attribute("href")) { relativeDatesIDRef_ = relativeDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDates_ = boost::shared_ptr<RelativeDates>(new RelativeDates(relativeDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDates> AdjustableOrRelativeDates::getAdjustableDates()
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
boost::shared_ptr<RelativeDates> AdjustableOrRelativeDates::getRelativeDates()
{
   if(!this->relativeDatesIsNull_){
        if(relativeDatesIDRef_ != ""){
             return boost::shared_static_cast<RelativeDates>(IDManager::instance().getID(relativeDatesIDRef_));
        }else{
             return this->relativeDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDates>();
   }
}
}

