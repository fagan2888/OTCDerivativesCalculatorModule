// EquityCorporateEvents.cpp 
#include "EquityCorporateEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityCorporateEvents::EquityCorporateEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //shareForShareNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* shareForShareNode = xmlNode->FirstChildElement("shareForShare");

   if(shareForShareNode){shareForShareIsNull_ = false;}
   else{shareForShareIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shareForShareNode , address : " << shareForShareNode << std::endl;
   #endif
   if(shareForShareNode)
   {
      if(shareForShareNode->Attribute("href") || shareForShareNode->Attribute("id"))
      {
          if(shareForShareNode->Attribute("id"))
          {
             shareForShareIDRef_ = shareForShareNode->Attribute("id");
             shareForShare_ = boost::shared_ptr<ShareExtraordinaryEventEnum>(new ShareExtraordinaryEventEnum(shareForShareNode));
             shareForShare_->setID(shareForShareIDRef_);
             IDManager::instance().setID(shareForShareIDRef_,shareForShare_);
          }
          else if(shareForShareNode->Attribute("href")) { shareForShareIDRef_ = shareForShareNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { shareForShare_ = boost::shared_ptr<ShareExtraordinaryEventEnum>(new ShareExtraordinaryEventEnum(shareForShareNode));}
   }

   //shareForOtherNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* shareForOtherNode = xmlNode->FirstChildElement("shareForOther");

   if(shareForOtherNode){shareForOtherIsNull_ = false;}
   else{shareForOtherIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shareForOtherNode , address : " << shareForOtherNode << std::endl;
   #endif
   if(shareForOtherNode)
   {
      if(shareForOtherNode->Attribute("href") || shareForOtherNode->Attribute("id"))
      {
          if(shareForOtherNode->Attribute("id"))
          {
             shareForOtherIDRef_ = shareForOtherNode->Attribute("id");
             shareForOther_ = boost::shared_ptr<ShareExtraordinaryEventEnum>(new ShareExtraordinaryEventEnum(shareForOtherNode));
             shareForOther_->setID(shareForOtherIDRef_);
             IDManager::instance().setID(shareForOtherIDRef_,shareForOther_);
          }
          else if(shareForOtherNode->Attribute("href")) { shareForOtherIDRef_ = shareForOtherNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { shareForOther_ = boost::shared_ptr<ShareExtraordinaryEventEnum>(new ShareExtraordinaryEventEnum(shareForOtherNode));}
   }

   //shareForCombinedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* shareForCombinedNode = xmlNode->FirstChildElement("shareForCombined");

   if(shareForCombinedNode){shareForCombinedIsNull_ = false;}
   else{shareForCombinedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shareForCombinedNode , address : " << shareForCombinedNode << std::endl;
   #endif
   if(shareForCombinedNode)
   {
      if(shareForCombinedNode->Attribute("href") || shareForCombinedNode->Attribute("id"))
      {
          if(shareForCombinedNode->Attribute("id"))
          {
             shareForCombinedIDRef_ = shareForCombinedNode->Attribute("id");
             shareForCombined_ = boost::shared_ptr<ShareExtraordinaryEventEnum>(new ShareExtraordinaryEventEnum(shareForCombinedNode));
             shareForCombined_->setID(shareForCombinedIDRef_);
             IDManager::instance().setID(shareForCombinedIDRef_,shareForCombined_);
          }
          else if(shareForCombinedNode->Attribute("href")) { shareForCombinedIDRef_ = shareForCombinedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { shareForCombined_ = boost::shared_ptr<ShareExtraordinaryEventEnum>(new ShareExtraordinaryEventEnum(shareForCombinedNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ShareExtraordinaryEventEnum> EquityCorporateEvents::getShareForShare()
{
   if(!this->shareForShareIsNull_){
        if(shareForShareIDRef_ != ""){
             return boost::shared_static_cast<ShareExtraordinaryEventEnum>(IDManager::instance().getID(shareForShareIDRef_));
        }else{
             return this->shareForShare_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ShareExtraordinaryEventEnum>();
   }
}
boost::shared_ptr<ShareExtraordinaryEventEnum> EquityCorporateEvents::getShareForOther()
{
   if(!this->shareForOtherIsNull_){
        if(shareForOtherIDRef_ != ""){
             return boost::shared_static_cast<ShareExtraordinaryEventEnum>(IDManager::instance().getID(shareForOtherIDRef_));
        }else{
             return this->shareForOther_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ShareExtraordinaryEventEnum>();
   }
}
boost::shared_ptr<ShareExtraordinaryEventEnum> EquityCorporateEvents::getShareForCombined()
{
   if(!this->shareForCombinedIsNull_){
        if(shareForCombinedIDRef_ != ""){
             return boost::shared_static_cast<ShareExtraordinaryEventEnum>(IDManager::instance().getID(shareForCombinedIDRef_));
        }else{
             return this->shareForCombined_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ShareExtraordinaryEventEnum>();
   }
}
}

