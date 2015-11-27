// AdjustableOrRelativeDate.cpp 
#include "AdjustableOrRelativeDate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustableOrRelativeDate::AdjustableOrRelativeDate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustableDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustableDateNode = xmlNode->FirstChildElement("adjustableDate");

   if(adjustableDateNode){adjustableDateIsNull_ = false;}
   else{adjustableDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustableDateNode , address : " << adjustableDateNode << std::endl;
   #endif
   if(adjustableDateNode)
   {
      if(adjustableDateNode->Attribute("href") || adjustableDateNode->Attribute("id"))
      {
          if(adjustableDateNode->Attribute("id"))
          {
             adjustableDateIDRef_ = adjustableDateNode->Attribute("id");
             adjustableDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(adjustableDateNode));
             adjustableDate_->setID(adjustableDateIDRef_);
             IDManager::instance().setID(adjustableDateIDRef_,adjustableDate_);
          }
          else if(adjustableDateNode->Attribute("href")) { adjustableDateIDRef_ = adjustableDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustableDate_ = boost::shared_ptr<AdjustableDate>(new AdjustableDate(adjustableDateNode));}
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
boost::shared_ptr<AdjustableDate> AdjustableOrRelativeDate::getAdjustableDate()
{
   if(!this->adjustableDateIsNull_){
        if(adjustableDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate>(IDManager::instance().getID(adjustableDateIDRef_));
        }else{
             return this->adjustableDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate>();
   }
}
boost::shared_ptr<RelativeDateOffset> AdjustableOrRelativeDate::getRelativeDate()
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

