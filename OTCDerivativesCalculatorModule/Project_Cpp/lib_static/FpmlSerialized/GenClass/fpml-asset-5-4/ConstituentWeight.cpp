// ConstituentWeight.cpp 
#include "ConstituentWeight.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ConstituentWeight::ConstituentWeight(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //openUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* openUnitsNode = xmlNode->FirstChildElement("openUnits");

   if(openUnitsNode){openUnitsIsNull_ = false;}
   else{openUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- openUnitsNode , address : " << openUnitsNode << std::endl;
   #endif
   if(openUnitsNode)
   {
      if(openUnitsNode->Attribute("href") || openUnitsNode->Attribute("id"))
      {
          if(openUnitsNode->Attribute("id"))
          {
             openUnitsIDRef_ = openUnitsNode->Attribute("id");
             openUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(openUnitsNode));
             openUnits_->setID(openUnitsIDRef_);
             IDManager::instance().setID(openUnitsIDRef_,openUnits_);
          }
          else if(openUnitsNode->Attribute("href")) { openUnitsIDRef_ = openUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { openUnits_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(openUnitsNode));}
   }

   //basketPercentageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketPercentageNode = xmlNode->FirstChildElement("basketPercentage");

   if(basketPercentageNode){basketPercentageIsNull_ = false;}
   else{basketPercentageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketPercentageNode , address : " << basketPercentageNode << std::endl;
   #endif
   if(basketPercentageNode)
   {
      if(basketPercentageNode->Attribute("href") || basketPercentageNode->Attribute("id"))
      {
          if(basketPercentageNode->Attribute("id"))
          {
             basketPercentageIDRef_ = basketPercentageNode->Attribute("id");
             basketPercentage_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(basketPercentageNode));
             basketPercentage_->setID(basketPercentageIDRef_);
             IDManager::instance().setID(basketPercentageIDRef_,basketPercentage_);
          }
          else if(basketPercentageNode->Attribute("href")) { basketPercentageIDRef_ = basketPercentageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketPercentage_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(basketPercentageNode));}
   }

   //basketAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketAmountNode = xmlNode->FirstChildElement("basketAmount");

   if(basketAmountNode){basketAmountIsNull_ = false;}
   else{basketAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketAmountNode , address : " << basketAmountNode << std::endl;
   #endif
   if(basketAmountNode)
   {
      if(basketAmountNode->Attribute("href") || basketAmountNode->Attribute("id"))
      {
          if(basketAmountNode->Attribute("id"))
          {
             basketAmountIDRef_ = basketAmountNode->Attribute("id");
             basketAmount_ = boost::shared_ptr<Money>(new Money(basketAmountNode));
             basketAmount_->setID(basketAmountIDRef_);
             IDManager::instance().setID(basketAmountIDRef_,basketAmount_);
          }
          else if(basketAmountNode->Attribute("href")) { basketAmountIDRef_ = basketAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketAmount_ = boost::shared_ptr<Money>(new Money(basketAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> ConstituentWeight::getOpenUnits()
{
   if(!this->openUnitsIsNull_){
        if(openUnitsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(openUnitsIDRef_));
        }else{
             return this->openUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<RestrictedPercentage> ConstituentWeight::getBasketPercentage()
{
   if(!this->basketPercentageIsNull_){
        if(basketPercentageIDRef_ != ""){
             return boost::shared_static_cast<RestrictedPercentage>(IDManager::instance().getID(basketPercentageIDRef_));
        }else{
             return this->basketPercentage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestrictedPercentage>();
   }
}
boost::shared_ptr<Money> ConstituentWeight::getBasketAmount()
{
   if(!this->basketAmountIsNull_){
        if(basketAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(basketAmountIDRef_));
        }else{
             return this->basketAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

