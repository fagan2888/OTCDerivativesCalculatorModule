// StrikeSpread.cpp 
#include "StrikeSpread.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StrikeSpread::StrikeSpread(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //upperStrikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperStrikeNode = xmlNode->FirstChildElement("upperStrike");

   if(upperStrikeNode){upperStrikeIsNull_ = false;}
   else{upperStrikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperStrikeNode , address : " << upperStrikeNode << std::endl;
   #endif
   if(upperStrikeNode)
   {
      if(upperStrikeNode->Attribute("href") || upperStrikeNode->Attribute("id"))
      {
          if(upperStrikeNode->Attribute("id"))
          {
             upperStrikeIDRef_ = upperStrikeNode->Attribute("id");
             upperStrike_ = boost::shared_ptr<OptionStrike>(new OptionStrike(upperStrikeNode));
             upperStrike_->setID(upperStrikeIDRef_);
             IDManager::instance().setID(upperStrikeIDRef_,upperStrike_);
          }
          else if(upperStrikeNode->Attribute("href")) { upperStrikeIDRef_ = upperStrikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { upperStrike_ = boost::shared_ptr<OptionStrike>(new OptionStrike(upperStrikeNode));}
   }

   //upperStrikeNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperStrikeNumberOfOptionsNode = xmlNode->FirstChildElement("upperStrikeNumberOfOptions");

   if(upperStrikeNumberOfOptionsNode){upperStrikeNumberOfOptionsIsNull_ = false;}
   else{upperStrikeNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperStrikeNumberOfOptionsNode , address : " << upperStrikeNumberOfOptionsNode << std::endl;
   #endif
   if(upperStrikeNumberOfOptionsNode)
   {
      if(upperStrikeNumberOfOptionsNode->Attribute("href") || upperStrikeNumberOfOptionsNode->Attribute("id"))
      {
          if(upperStrikeNumberOfOptionsNode->Attribute("id"))
          {
             upperStrikeNumberOfOptionsIDRef_ = upperStrikeNumberOfOptionsNode->Attribute("id");
             upperStrikeNumberOfOptions_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(upperStrikeNumberOfOptionsNode));
             upperStrikeNumberOfOptions_->setID(upperStrikeNumberOfOptionsIDRef_);
             IDManager::instance().setID(upperStrikeNumberOfOptionsIDRef_,upperStrikeNumberOfOptions_);
          }
          else if(upperStrikeNumberOfOptionsNode->Attribute("href")) { upperStrikeNumberOfOptionsIDRef_ = upperStrikeNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { upperStrikeNumberOfOptions_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(upperStrikeNumberOfOptionsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<OptionStrike> StrikeSpread::getUpperStrike()
{
   if(!this->upperStrikeIsNull_){
        if(upperStrikeIDRef_ != ""){
             return boost::shared_static_cast<OptionStrike>(IDManager::instance().getID(upperStrikeIDRef_));
        }else{
             return this->upperStrike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionStrike>();
   }
}
boost::shared_ptr<PositiveDecimal> StrikeSpread::getUpperStrikeNumberOfOptions()
{
   if(!this->upperStrikeNumberOfOptionsIsNull_){
        if(upperStrikeNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(upperStrikeNumberOfOptionsIDRef_));
        }else{
             return this->upperStrikeNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
}

