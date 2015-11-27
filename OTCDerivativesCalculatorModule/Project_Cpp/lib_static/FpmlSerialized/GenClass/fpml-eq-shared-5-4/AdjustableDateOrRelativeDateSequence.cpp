// AdjustableDateOrRelativeDateSequence.cpp 
#include "AdjustableDateOrRelativeDateSequence.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdjustableDateOrRelativeDateSequence::AdjustableDateOrRelativeDateSequence(TiXmlNode* xmlNode)
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

   //relativeDateSequenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relativeDateSequenceNode = xmlNode->FirstChildElement("relativeDateSequence");

   if(relativeDateSequenceNode){relativeDateSequenceIsNull_ = false;}
   else{relativeDateSequenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relativeDateSequenceNode , address : " << relativeDateSequenceNode << std::endl;
   #endif
   if(relativeDateSequenceNode)
   {
      if(relativeDateSequenceNode->Attribute("href") || relativeDateSequenceNode->Attribute("id"))
      {
          if(relativeDateSequenceNode->Attribute("id"))
          {
             relativeDateSequenceIDRef_ = relativeDateSequenceNode->Attribute("id");
             relativeDateSequence_ = boost::shared_ptr<RelativeDateSequence>(new RelativeDateSequence(relativeDateSequenceNode));
             relativeDateSequence_->setID(relativeDateSequenceIDRef_);
             IDManager::instance().setID(relativeDateSequenceIDRef_,relativeDateSequence_);
          }
          else if(relativeDateSequenceNode->Attribute("href")) { relativeDateSequenceIDRef_ = relativeDateSequenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relativeDateSequence_ = boost::shared_ptr<RelativeDateSequence>(new RelativeDateSequence(relativeDateSequenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDate> AdjustableDateOrRelativeDateSequence::getAdjustableDate()
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
boost::shared_ptr<RelativeDateSequence> AdjustableDateOrRelativeDateSequence::getRelativeDateSequence()
{
   if(!this->relativeDateSequenceIsNull_){
        if(relativeDateSequenceIDRef_ != ""){
             return boost::shared_static_cast<RelativeDateSequence>(IDManager::instance().getID(relativeDateSequenceIDRef_));
        }else{
             return this->relativeDateSequence_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RelativeDateSequence>();
   }
}
}

