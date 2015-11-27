// FixedPrice.cpp 
#include "FixedPrice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FixedPrice::FixedPrice(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //priceCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* priceCurrencyNode = xmlNode->FirstChildElement("priceCurrency");

   if(priceCurrencyNode){priceCurrencyIsNull_ = false;}
   else{priceCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- priceCurrencyNode , address : " << priceCurrencyNode << std::endl;
   #endif
   if(priceCurrencyNode)
   {
      if(priceCurrencyNode->Attribute("href") || priceCurrencyNode->Attribute("id"))
      {
          if(priceCurrencyNode->Attribute("id"))
          {
             priceCurrencyIDRef_ = priceCurrencyNode->Attribute("id");
             priceCurrency_ = boost::shared_ptr<Currency>(new Currency(priceCurrencyNode));
             priceCurrency_->setID(priceCurrencyIDRef_);
             IDManager::instance().setID(priceCurrencyIDRef_,priceCurrency_);
          }
          else if(priceCurrencyNode->Attribute("href")) { priceCurrencyIDRef_ = priceCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { priceCurrency_ = boost::shared_ptr<Currency>(new Currency(priceCurrencyNode));}
   }

   //priceUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* priceUnitNode = xmlNode->FirstChildElement("priceUnit");

   if(priceUnitNode){priceUnitIsNull_ = false;}
   else{priceUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- priceUnitNode , address : " << priceUnitNode << std::endl;
   #endif
   if(priceUnitNode)
   {
      if(priceUnitNode->Attribute("href") || priceUnitNode->Attribute("id"))
      {
          if(priceUnitNode->Attribute("id"))
          {
             priceUnitIDRef_ = priceUnitNode->Attribute("id");
             priceUnit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(priceUnitNode));
             priceUnit_->setID(priceUnitIDRef_);
             IDManager::instance().setID(priceUnitIDRef_,priceUnit_);
          }
          else if(priceUnitNode->Attribute("href")) { priceUnitIDRef_ = priceUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { priceUnit_ = boost::shared_ptr<QuantityUnit>(new QuantityUnit(priceUnitNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> FixedPrice::getPrice()
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
boost::shared_ptr<Currency> FixedPrice::getPriceCurrency()
{
   if(!this->priceCurrencyIsNull_){
        if(priceCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(priceCurrencyIDRef_));
        }else{
             return this->priceCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<QuantityUnit> FixedPrice::getPriceUnit()
{
   if(!this->priceUnitIsNull_){
        if(priceUnitIDRef_ != ""){
             return boost::shared_static_cast<QuantityUnit>(IDManager::instance().getID(priceUnitIDRef_));
        }else{
             return this->priceUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuantityUnit>();
   }
}
}

