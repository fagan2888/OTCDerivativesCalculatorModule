// Discounting.cpp 
#include "Discounting.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Discounting::Discounting(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //discountingTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountingTypeNode = xmlNode->FirstChildElement("discountingType");

   if(discountingTypeNode){discountingTypeIsNull_ = false;}
   else{discountingTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountingTypeNode , address : " << discountingTypeNode << std::endl;
   #endif
   if(discountingTypeNode)
   {
      if(discountingTypeNode->Attribute("href") || discountingTypeNode->Attribute("id"))
      {
          if(discountingTypeNode->Attribute("id"))
          {
             discountingTypeIDRef_ = discountingTypeNode->Attribute("id");
             discountingType_ = boost::shared_ptr<DiscountingTypeEnum>(new DiscountingTypeEnum(discountingTypeNode));
             discountingType_->setID(discountingTypeIDRef_);
             IDManager::instance().setID(discountingTypeIDRef_,discountingType_);
          }
          else if(discountingTypeNode->Attribute("href")) { discountingTypeIDRef_ = discountingTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discountingType_ = boost::shared_ptr<DiscountingTypeEnum>(new DiscountingTypeEnum(discountingTypeNode));}
   }

   //discountRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountRateNode = xmlNode->FirstChildElement("discountRate");

   if(discountRateNode){discountRateIsNull_ = false;}
   else{discountRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountRateNode , address : " << discountRateNode << std::endl;
   #endif
   if(discountRateNode)
   {
      if(discountRateNode->Attribute("href") || discountRateNode->Attribute("id"))
      {
          if(discountRateNode->Attribute("id"))
          {
             discountRateIDRef_ = discountRateNode->Attribute("id");
             discountRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountRateNode));
             discountRate_->setID(discountRateIDRef_);
             IDManager::instance().setID(discountRateIDRef_,discountRate_);
          }
          else if(discountRateNode->Attribute("href")) { discountRateIDRef_ = discountRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discountRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountRateNode));}
   }

   //discountRateDayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountRateDayCountFractionNode = xmlNode->FirstChildElement("discountRateDayCountFraction");

   if(discountRateDayCountFractionNode){discountRateDayCountFractionIsNull_ = false;}
   else{discountRateDayCountFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountRateDayCountFractionNode , address : " << discountRateDayCountFractionNode << std::endl;
   #endif
   if(discountRateDayCountFractionNode)
   {
      if(discountRateDayCountFractionNode->Attribute("href") || discountRateDayCountFractionNode->Attribute("id"))
      {
          if(discountRateDayCountFractionNode->Attribute("id"))
          {
             discountRateDayCountFractionIDRef_ = discountRateDayCountFractionNode->Attribute("id");
             discountRateDayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(discountRateDayCountFractionNode));
             discountRateDayCountFraction_->setID(discountRateDayCountFractionIDRef_);
             IDManager::instance().setID(discountRateDayCountFractionIDRef_,discountRateDayCountFraction_);
          }
          else if(discountRateDayCountFractionNode->Attribute("href")) { discountRateDayCountFractionIDRef_ = discountRateDayCountFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discountRateDayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(discountRateDayCountFractionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DiscountingTypeEnum> Discounting::getDiscountingType()
{
   if(!this->discountingTypeIsNull_){
        if(discountingTypeIDRef_ != ""){
             return boost::shared_static_cast<DiscountingTypeEnum>(IDManager::instance().getID(discountingTypeIDRef_));
        }else{
             return this->discountingType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DiscountingTypeEnum>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Discounting::getDiscountRate()
{
   if(!this->discountRateIsNull_){
        if(discountRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(discountRateIDRef_));
        }else{
             return this->discountRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<DayCountFraction> Discounting::getDiscountRateDayCountFraction()
{
   if(!this->discountRateDayCountFractionIsNull_){
        if(discountRateDayCountFractionIDRef_ != ""){
             return boost::shared_static_cast<DayCountFraction>(IDManager::instance().getID(discountRateDayCountFractionIDRef_));
        }else{
             return this->discountRateDayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayCountFraction>();
   }
}
}

