// CreditOptionStrike.cpp 
#include "CreditOptionStrike.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditOptionStrike::CreditOptionStrike(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //spreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadNode = xmlNode->FirstChildElement("spread");

   if(spreadNode){spreadIsNull_ = false;}
   else{spreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadNode , address : " << spreadNode << std::endl;
   #endif
   if(spreadNode)
   {
      if(spreadNode->Attribute("href") || spreadNode->Attribute("id"))
      {
          if(spreadNode->Attribute("id"))
          {
             spreadIDRef_ = spreadNode->Attribute("id");
             spread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadNode));
             spread_->setID(spreadIDRef_);
             IDManager::instance().setID(spreadIDRef_,spread_);
          }
          else if(spreadNode->Attribute("href")) { spreadIDRef_ = spreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadNode));}
   }

   //priceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* priceNode = xmlNode->FirstChildElement("price");

   if(priceNode){priceIsNull_ = false;}
   else{priceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- priceNode , address : " << priceNode << std::endl;
   #endif
   if(priceNode)
   {
      if(priceNode->Attribute("href") || priceNode->Attribute("id"))
      {
          if(priceNode->Attribute("id"))
          {
             priceIDRef_ = priceNode->Attribute("id");
             price_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(priceNode));
             price_->setID(priceIDRef_);
             IDManager::instance().setID(priceIDRef_,price_);
          }
          else if(priceNode->Attribute("href")) { priceIDRef_ = priceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { price_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(priceNode));}
   }

   //strikeReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeReferenceNode = xmlNode->FirstChildElement("strikeReference");

   if(strikeReferenceNode){strikeReferenceIsNull_ = false;}
   else{strikeReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeReferenceNode , address : " << strikeReferenceNode << std::endl;
   #endif
   if(strikeReferenceNode)
   {
      if(strikeReferenceNode->Attribute("href") || strikeReferenceNode->Attribute("id"))
      {
          if(strikeReferenceNode->Attribute("id"))
          {
             strikeReferenceIDRef_ = strikeReferenceNode->Attribute("id");
             strikeReference_ = boost::shared_ptr<FixedRateReference>(new FixedRateReference(strikeReferenceNode));
             strikeReference_->setID(strikeReferenceIDRef_);
             IDManager::instance().setID(strikeReferenceIDRef_,strikeReference_);
          }
          else if(strikeReferenceNode->Attribute("href")) { strikeReferenceIDRef_ = strikeReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strikeReference_ = boost::shared_ptr<FixedRateReference>(new FixedRateReference(strikeReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> CreditOptionStrike::getSpread()
{
   if(!this->spreadIsNull_){
        if(spreadIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(spreadIDRef_));
        }else{
             return this->spread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CreditOptionStrike::getPrice()
{
   if(!this->priceIsNull_){
        if(priceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(priceIDRef_));
        }else{
             return this->price_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<FixedRateReference> CreditOptionStrike::getStrikeReference()
{
   if(!this->strikeReferenceIsNull_){
        if(strikeReferenceIDRef_ != ""){
             return boost::shared_static_cast<FixedRateReference>(IDManager::instance().getID(strikeReferenceIDRef_));
        }else{
             return this->strikeReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedRateReference>();
   }
}
}

