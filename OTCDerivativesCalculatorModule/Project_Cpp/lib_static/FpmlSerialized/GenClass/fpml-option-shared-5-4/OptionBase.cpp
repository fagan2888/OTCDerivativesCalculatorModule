// OptionBase.cpp 
#include "OptionBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionBase::OptionBase(TiXmlNode* xmlNode)
: Option(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //optionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionTypeNode = xmlNode->FirstChildElement("optionType");

   if(optionTypeNode){optionTypeIsNull_ = false;}
   else{optionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionTypeNode , address : " << optionTypeNode << std::endl;
   #endif
   if(optionTypeNode)
   {
      if(optionTypeNode->Attribute("href") || optionTypeNode->Attribute("id"))
      {
          if(optionTypeNode->Attribute("id"))
          {
             optionTypeIDRef_ = optionTypeNode->Attribute("id");
             optionType_ = boost::shared_ptr<OptionTypeEnum>(new OptionTypeEnum(optionTypeNode));
             optionType_->setID(optionTypeIDRef_);
             IDManager::instance().setID(optionTypeIDRef_,optionType_);
          }
          else if(optionTypeNode->Attribute("href")) { optionTypeIDRef_ = optionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionType_ = boost::shared_ptr<OptionTypeEnum>(new OptionTypeEnum(optionTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<OptionTypeEnum> OptionBase::getOptionType()
{
   if(!this->optionTypeIsNull_){
        if(optionTypeIDRef_ != ""){
             return boost::shared_static_cast<OptionTypeEnum>(IDManager::instance().getID(optionTypeIDRef_));
        }else{
             return this->optionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionTypeEnum>();
   }
}
}

