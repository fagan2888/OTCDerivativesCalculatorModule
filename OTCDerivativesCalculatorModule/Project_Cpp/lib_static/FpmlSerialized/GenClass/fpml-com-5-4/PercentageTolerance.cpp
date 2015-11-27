// PercentageTolerance.cpp 
#include "PercentageTolerance.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PercentageTolerance::PercentageTolerance(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //postitiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* postitiveNode = xmlNode->FirstChildElement("postitive");

   if(postitiveNode){postitiveIsNull_ = false;}
   else{postitiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- postitiveNode , address : " << postitiveNode << std::endl;
   #endif
   if(postitiveNode)
   {
      if(postitiveNode->Attribute("href") || postitiveNode->Attribute("id"))
      {
          if(postitiveNode->Attribute("id"))
          {
             postitiveIDRef_ = postitiveNode->Attribute("id");
             postitive_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(postitiveNode));
             postitive_->setID(postitiveIDRef_);
             IDManager::instance().setID(postitiveIDRef_,postitive_);
          }
          else if(postitiveNode->Attribute("href")) { postitiveIDRef_ = postitiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { postitive_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(postitiveNode));}
   }

   //negativeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* negativeNode = xmlNode->FirstChildElement("negative");

   if(negativeNode){negativeIsNull_ = false;}
   else{negativeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- negativeNode , address : " << negativeNode << std::endl;
   #endif
   if(negativeNode)
   {
      if(negativeNode->Attribute("href") || negativeNode->Attribute("id"))
      {
          if(negativeNode->Attribute("id"))
          {
             negativeIDRef_ = negativeNode->Attribute("id");
             negative_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(negativeNode));
             negative_->setID(negativeIDRef_);
             IDManager::instance().setID(negativeIDRef_,negative_);
          }
          else if(negativeNode->Attribute("href")) { negativeIDRef_ = negativeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { negative_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(negativeNode));}
   }

   //optionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionNode = xmlNode->FirstChildElement("option");

   if(optionNode){optionIsNull_ = false;}
   else{optionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionNode , address : " << optionNode << std::endl;
   #endif
   if(optionNode)
   {
      if(optionNode->Attribute("href") || optionNode->Attribute("id"))
      {
          if(optionNode->Attribute("id"))
          {
             optionIDRef_ = optionNode->Attribute("id");
             option_ = boost::shared_ptr<PartyReference>(new PartyReference(optionNode));
             option_->setID(optionIDRef_);
             IDManager::instance().setID(optionIDRef_,option_);
          }
          else if(optionNode->Attribute("href")) { optionIDRef_ = optionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { option_ = boost::shared_ptr<PartyReference>(new PartyReference(optionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RestrictedPercentage> PercentageTolerance::getPostitive()
{
   if(!this->postitiveIsNull_){
        if(postitiveIDRef_ != ""){
             return boost::shared_static_cast<RestrictedPercentage>(IDManager::instance().getID(postitiveIDRef_));
        }else{
             return this->postitive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestrictedPercentage>();
   }
}
boost::shared_ptr<RestrictedPercentage> PercentageTolerance::getNegative()
{
   if(!this->negativeIsNull_){
        if(negativeIDRef_ != ""){
             return boost::shared_static_cast<RestrictedPercentage>(IDManager::instance().getID(negativeIDRef_));
        }else{
             return this->negative_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestrictedPercentage>();
   }
}
boost::shared_ptr<PartyReference> PercentageTolerance::getOption()
{
   if(!this->optionIsNull_){
        if(optionIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(optionIDRef_));
        }else{
             return this->option_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
}

