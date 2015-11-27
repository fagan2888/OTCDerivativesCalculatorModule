// PrincipalExchange.cpp 
#include "PrincipalExchange.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PrincipalExchange::PrincipalExchange(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //unadjustedPrincipalExchangeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* unadjustedPrincipalExchangeDateNode = xmlNode->FirstChildElement("unadjustedPrincipalExchangeDate");

   if(unadjustedPrincipalExchangeDateNode){unadjustedPrincipalExchangeDateIsNull_ = false;}
   else{unadjustedPrincipalExchangeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- unadjustedPrincipalExchangeDateNode , address : " << unadjustedPrincipalExchangeDateNode << std::endl;
   #endif
   if(unadjustedPrincipalExchangeDateNode)
   {
      if(unadjustedPrincipalExchangeDateNode->Attribute("href") || unadjustedPrincipalExchangeDateNode->Attribute("id"))
      {
          if(unadjustedPrincipalExchangeDateNode->Attribute("id"))
          {
             unadjustedPrincipalExchangeDateIDRef_ = unadjustedPrincipalExchangeDateNode->Attribute("id");
             unadjustedPrincipalExchangeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedPrincipalExchangeDateNode));
             unadjustedPrincipalExchangeDate_->setID(unadjustedPrincipalExchangeDateIDRef_);
             IDManager::instance().setID(unadjustedPrincipalExchangeDateIDRef_,unadjustedPrincipalExchangeDate_);
          }
          else if(unadjustedPrincipalExchangeDateNode->Attribute("href")) { unadjustedPrincipalExchangeDateIDRef_ = unadjustedPrincipalExchangeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { unadjustedPrincipalExchangeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(unadjustedPrincipalExchangeDateNode));}
   }

   //adjustedPrincipalExchangeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedPrincipalExchangeDateNode = xmlNode->FirstChildElement("adjustedPrincipalExchangeDate");

   if(adjustedPrincipalExchangeDateNode){adjustedPrincipalExchangeDateIsNull_ = false;}
   else{adjustedPrincipalExchangeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedPrincipalExchangeDateNode , address : " << adjustedPrincipalExchangeDateNode << std::endl;
   #endif
   if(adjustedPrincipalExchangeDateNode)
   {
      if(adjustedPrincipalExchangeDateNode->Attribute("href") || adjustedPrincipalExchangeDateNode->Attribute("id"))
      {
          if(adjustedPrincipalExchangeDateNode->Attribute("id"))
          {
             adjustedPrincipalExchangeDateIDRef_ = adjustedPrincipalExchangeDateNode->Attribute("id");
             adjustedPrincipalExchangeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPrincipalExchangeDateNode));
             adjustedPrincipalExchangeDate_->setID(adjustedPrincipalExchangeDateIDRef_);
             IDManager::instance().setID(adjustedPrincipalExchangeDateIDRef_,adjustedPrincipalExchangeDate_);
          }
          else if(adjustedPrincipalExchangeDateNode->Attribute("href")) { adjustedPrincipalExchangeDateIDRef_ = adjustedPrincipalExchangeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedPrincipalExchangeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedPrincipalExchangeDateNode));}
   }

   //principalExchangeAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalExchangeAmountNode = xmlNode->FirstChildElement("principalExchangeAmount");

   if(principalExchangeAmountNode){principalExchangeAmountIsNull_ = false;}
   else{principalExchangeAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangeAmountNode , address : " << principalExchangeAmountNode << std::endl;
   #endif
   if(principalExchangeAmountNode)
   {
      if(principalExchangeAmountNode->Attribute("href") || principalExchangeAmountNode->Attribute("id"))
      {
          if(principalExchangeAmountNode->Attribute("id"))
          {
             principalExchangeAmountIDRef_ = principalExchangeAmountNode->Attribute("id");
             principalExchangeAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(principalExchangeAmountNode));
             principalExchangeAmount_->setID(principalExchangeAmountIDRef_);
             IDManager::instance().setID(principalExchangeAmountIDRef_,principalExchangeAmount_);
          }
          else if(principalExchangeAmountNode->Attribute("href")) { principalExchangeAmountIDRef_ = principalExchangeAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principalExchangeAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(principalExchangeAmountNode));}
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

   //presentValuePrincipalExchangeAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* presentValuePrincipalExchangeAmountNode = xmlNode->FirstChildElement("presentValuePrincipalExchangeAmount");

   if(presentValuePrincipalExchangeAmountNode){presentValuePrincipalExchangeAmountIsNull_ = false;}
   else{presentValuePrincipalExchangeAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- presentValuePrincipalExchangeAmountNode , address : " << presentValuePrincipalExchangeAmountNode << std::endl;
   #endif
   if(presentValuePrincipalExchangeAmountNode)
   {
      if(presentValuePrincipalExchangeAmountNode->Attribute("href") || presentValuePrincipalExchangeAmountNode->Attribute("id"))
      {
          if(presentValuePrincipalExchangeAmountNode->Attribute("id"))
          {
             presentValuePrincipalExchangeAmountIDRef_ = presentValuePrincipalExchangeAmountNode->Attribute("id");
             presentValuePrincipalExchangeAmount_ = boost::shared_ptr<Money>(new Money(presentValuePrincipalExchangeAmountNode));
             presentValuePrincipalExchangeAmount_->setID(presentValuePrincipalExchangeAmountIDRef_);
             IDManager::instance().setID(presentValuePrincipalExchangeAmountIDRef_,presentValuePrincipalExchangeAmount_);
          }
          else if(presentValuePrincipalExchangeAmountNode->Attribute("href")) { presentValuePrincipalExchangeAmountIDRef_ = presentValuePrincipalExchangeAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { presentValuePrincipalExchangeAmount_ = boost::shared_ptr<Money>(new Money(presentValuePrincipalExchangeAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> PrincipalExchange::getUnadjustedPrincipalExchangeDate()
{
   if(!this->unadjustedPrincipalExchangeDateIsNull_){
        if(unadjustedPrincipalExchangeDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(unadjustedPrincipalExchangeDateIDRef_));
        }else{
             return this->unadjustedPrincipalExchangeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> PrincipalExchange::getAdjustedPrincipalExchangeDate()
{
   if(!this->adjustedPrincipalExchangeDateIsNull_){
        if(adjustedPrincipalExchangeDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedPrincipalExchangeDateIDRef_));
        }else{
             return this->adjustedPrincipalExchangeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> PrincipalExchange::getPrincipalExchangeAmount()
{
   if(!this->principalExchangeAmountIsNull_){
        if(principalExchangeAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(principalExchangeAmountIDRef_));
        }else{
             return this->principalExchangeAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> PrincipalExchange::getDiscountFactor()
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
boost::shared_ptr<Money> PrincipalExchange::getPresentValuePrincipalExchangeAmount()
{
   if(!this->presentValuePrincipalExchangeAmountIsNull_){
        if(presentValuePrincipalExchangeAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(presentValuePrincipalExchangeAmountIDRef_));
        }else{
             return this->presentValuePrincipalExchangeAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

