// Premium.cpp 
#include "Premium.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Premium::Premium(TiXmlNode* xmlNode)
: SimplePayment(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //premiumTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumTypeNode = xmlNode->FirstChildElement("premiumType");

   if(premiumTypeNode){premiumTypeIsNull_ = false;}
   else{premiumTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumTypeNode , address : " << premiumTypeNode << std::endl;
   #endif
   if(premiumTypeNode)
   {
      if(premiumTypeNode->Attribute("href") || premiumTypeNode->Attribute("id"))
      {
          if(premiumTypeNode->Attribute("id"))
          {
             premiumTypeIDRef_ = premiumTypeNode->Attribute("id");
             premiumType_ = boost::shared_ptr<PremiumTypeEnum>(new PremiumTypeEnum(premiumTypeNode));
             premiumType_->setID(premiumTypeIDRef_);
             IDManager::instance().setID(premiumTypeIDRef_,premiumType_);
          }
          else if(premiumTypeNode->Attribute("href")) { premiumTypeIDRef_ = premiumTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { premiumType_ = boost::shared_ptr<PremiumTypeEnum>(new PremiumTypeEnum(premiumTypeNode));}
   }

   //pricePerOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pricePerOptionNode = xmlNode->FirstChildElement("pricePerOption");

   if(pricePerOptionNode){pricePerOptionIsNull_ = false;}
   else{pricePerOptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pricePerOptionNode , address : " << pricePerOptionNode << std::endl;
   #endif
   if(pricePerOptionNode)
   {
      if(pricePerOptionNode->Attribute("href") || pricePerOptionNode->Attribute("id"))
      {
          if(pricePerOptionNode->Attribute("id"))
          {
             pricePerOptionIDRef_ = pricePerOptionNode->Attribute("id");
             pricePerOption_ = boost::shared_ptr<Money>(new Money(pricePerOptionNode));
             pricePerOption_->setID(pricePerOptionIDRef_);
             IDManager::instance().setID(pricePerOptionIDRef_,pricePerOption_);
          }
          else if(pricePerOptionNode->Attribute("href")) { pricePerOptionIDRef_ = pricePerOptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pricePerOption_ = boost::shared_ptr<Money>(new Money(pricePerOptionNode));}
   }

   //percentageOfNotionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* percentageOfNotionalNode = xmlNode->FirstChildElement("percentageOfNotional");

   if(percentageOfNotionalNode){percentageOfNotionalIsNull_ = false;}
   else{percentageOfNotionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- percentageOfNotionalNode , address : " << percentageOfNotionalNode << std::endl;
   #endif
   if(percentageOfNotionalNode)
   {
      if(percentageOfNotionalNode->Attribute("href") || percentageOfNotionalNode->Attribute("id"))
      {
          if(percentageOfNotionalNode->Attribute("id"))
          {
             percentageOfNotionalIDRef_ = percentageOfNotionalNode->Attribute("id");
             percentageOfNotional_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(percentageOfNotionalNode));
             percentageOfNotional_->setID(percentageOfNotionalIDRef_);
             IDManager::instance().setID(percentageOfNotionalIDRef_,percentageOfNotional_);
          }
          else if(percentageOfNotionalNode->Attribute("href")) { percentageOfNotionalIDRef_ = percentageOfNotionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { percentageOfNotional_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(percentageOfNotionalNode));}
   }

   //discountFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountFactorNode = xmlNode->FirstChildElement("discountFactor");

   if(discountFactorNode){discountFactorIsNull_ = false;}
   else{discountFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountFactorNode , address : " << discountFactorNode << std::endl;
   #endif
   if(discountFactorNode)
   {
      if(discountFactorNode->Attribute("href") || discountFactorNode->Attribute("id"))
      {
          if(discountFactorNode->Attribute("id"))
          {
             discountFactorIDRef_ = discountFactorNode->Attribute("id");
             discountFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountFactorNode));
             discountFactor_->setID(discountFactorIDRef_);
             IDManager::instance().setID(discountFactorIDRef_,discountFactor_);
          }
          else if(discountFactorNode->Attribute("href")) { discountFactorIDRef_ = discountFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discountFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(discountFactorNode));}
   }

   //presentValueAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* presentValueAmountNode = xmlNode->FirstChildElement("presentValueAmount");

   if(presentValueAmountNode){presentValueAmountIsNull_ = false;}
   else{presentValueAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- presentValueAmountNode , address : " << presentValueAmountNode << std::endl;
   #endif
   if(presentValueAmountNode)
   {
      if(presentValueAmountNode->Attribute("href") || presentValueAmountNode->Attribute("id"))
      {
          if(presentValueAmountNode->Attribute("id"))
          {
             presentValueAmountIDRef_ = presentValueAmountNode->Attribute("id");
             presentValueAmount_ = boost::shared_ptr<Money>(new Money(presentValueAmountNode));
             presentValueAmount_->setID(presentValueAmountIDRef_);
             IDManager::instance().setID(presentValueAmountIDRef_,presentValueAmount_);
          }
          else if(presentValueAmountNode->Attribute("href")) { presentValueAmountIDRef_ = presentValueAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { presentValueAmount_ = boost::shared_ptr<Money>(new Money(presentValueAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PremiumTypeEnum> Premium::getPremiumType()
{
   if(!this->premiumTypeIsNull_){
        if(premiumTypeIDRef_ != ""){
             return boost::shared_static_cast<PremiumTypeEnum>(IDManager::instance().getID(premiumTypeIDRef_));
        }else{
             return this->premiumType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PremiumTypeEnum>();
   }
}
boost::shared_ptr<Money> Premium::getPricePerOption()
{
   if(!this->pricePerOptionIsNull_){
        if(pricePerOptionIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(pricePerOptionIDRef_));
        }else{
             return this->pricePerOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Premium::getPercentageOfNotional()
{
   if(!this->percentageOfNotionalIsNull_){
        if(percentageOfNotionalIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(percentageOfNotionalIDRef_));
        }else{
             return this->percentageOfNotional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Premium::getDiscountFactor()
{
   if(!this->discountFactorIsNull_){
        if(discountFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(discountFactorIDRef_));
        }else{
             return this->discountFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Money> Premium::getPresentValueAmount()
{
   if(!this->presentValueAmountIsNull_){
        if(presentValueAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(presentValueAmountIDRef_));
        }else{
             return this->presentValueAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

