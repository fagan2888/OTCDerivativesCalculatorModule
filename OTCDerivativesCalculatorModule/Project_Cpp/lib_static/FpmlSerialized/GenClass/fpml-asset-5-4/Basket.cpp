// Basket.cpp 
#include "Basket.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Basket::Basket(TiXmlNode* xmlNode)
: Asset(xmlNode)
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

   //basketConstituentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketConstituentNode = xmlNode->FirstChildElement("basketConstituent");

   if(basketConstituentNode){basketConstituentIsNull_ = false;}
   else{basketConstituentIsNull_ = true;}

   if(basketConstituentNode)
   {
      for(basketConstituentNode; basketConstituentNode; basketConstituentNode = basketConstituentNode->NextSiblingElement("basketConstituent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketConstituentNode , address : " << basketConstituentNode << std::endl;
          #endif
          if(basketConstituentNode->Attribute("href") || basketConstituentNode->Attribute("id"))
          {
              if(basketConstituentNode->Attribute("id"))
              {
                  basketConstituentIDRef_ = basketConstituentNode->Attribute("id");
                  basketConstituent_.push_back(boost::shared_ptr<BasketConstituent>(new BasketConstituent(basketConstituentNode)));
                  basketConstituent_.back()->setID(basketConstituentIDRef_);
                  IDManager::instance().setID(basketConstituentIDRef_, basketConstituent_.back());
              }
              else if(basketConstituentNode->Attribute("href")) { basketConstituentIDRef_ = basketConstituentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { basketConstituent_.push_back(boost::shared_ptr<BasketConstituent>(new BasketConstituent(basketConstituentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketConstituentNode , address : " << basketConstituentNode << std::endl;
       #endif
   }

   //basketDivisorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketDivisorNode = xmlNode->FirstChildElement("basketDivisor");

   if(basketDivisorNode){basketDivisorIsNull_ = false;}
   else{basketDivisorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketDivisorNode , address : " << basketDivisorNode << std::endl;
   #endif
   if(basketDivisorNode)
   {
      if(basketDivisorNode->Attribute("href") || basketDivisorNode->Attribute("id"))
      {
          if(basketDivisorNode->Attribute("id"))
          {
             basketDivisorIDRef_ = basketDivisorNode->Attribute("id");
             basketDivisor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(basketDivisorNode));
             basketDivisor_->setID(basketDivisorIDRef_);
             IDManager::instance().setID(basketDivisorIDRef_,basketDivisor_);
          }
          else if(basketDivisorNode->Attribute("href")) { basketDivisorIDRef_ = basketDivisorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketDivisor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(basketDivisorNode));}
   }

   //basketNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketNameNode = xmlNode->FirstChildElement("basketName");

   if(basketNameNode){basketNameIsNull_ = false;}
   else{basketNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketNameNode , address : " << basketNameNode << std::endl;
   #endif
   if(basketNameNode)
   {
      if(basketNameNode->Attribute("href") || basketNameNode->Attribute("id"))
      {
          if(basketNameNode->Attribute("id"))
          {
             basketNameIDRef_ = basketNameNode->Attribute("id");
             basketName_ = boost::shared_ptr<BasketName>(new BasketName(basketNameNode));
             basketName_->setID(basketNameIDRef_);
             IDManager::instance().setID(basketNameIDRef_,basketName_);
          }
          else if(basketNameNode->Attribute("href")) { basketNameIDRef_ = basketNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketName_ = boost::shared_ptr<BasketName>(new BasketName(basketNameNode));}
   }

   //basketIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketIdNode = xmlNode->FirstChildElement("basketId");

   if(basketIdNode){basketIdIsNull_ = false;}
   else{basketIdIsNull_ = true;}

   if(basketIdNode)
   {
      for(basketIdNode; basketIdNode; basketIdNode = basketIdNode->NextSiblingElement("basketId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketIdNode , address : " << basketIdNode << std::endl;
          #endif
          if(basketIdNode->Attribute("href") || basketIdNode->Attribute("id"))
          {
              if(basketIdNode->Attribute("id"))
              {
                  basketIdIDRef_ = basketIdNode->Attribute("id");
                  basketId_.push_back(boost::shared_ptr<BasketId>(new BasketId(basketIdNode)));
                  basketId_.back()->setID(basketIdIDRef_);
                  IDManager::instance().setID(basketIdIDRef_, basketId_.back());
              }
              else if(basketIdNode->Attribute("href")) { basketIdIDRef_ = basketIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { basketId_.push_back(boost::shared_ptr<BasketId>(new BasketId(basketIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketIdNode , address : " << basketIdNode << std::endl;
       #endif
   }

   //basketCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketCurrencyNode = xmlNode->FirstChildElement("basketCurrency");

   if(basketCurrencyNode){basketCurrencyIsNull_ = false;}
   else{basketCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketCurrencyNode , address : " << basketCurrencyNode << std::endl;
   #endif
   if(basketCurrencyNode)
   {
      if(basketCurrencyNode->Attribute("href") || basketCurrencyNode->Attribute("id"))
      {
          if(basketCurrencyNode->Attribute("id"))
          {
             basketCurrencyIDRef_ = basketCurrencyNode->Attribute("id");
             basketCurrency_ = boost::shared_ptr<Currency>(new Currency(basketCurrencyNode));
             basketCurrency_->setID(basketCurrencyIDRef_);
             IDManager::instance().setID(basketCurrencyIDRef_,basketCurrency_);
          }
          else if(basketCurrencyNode->Attribute("href")) { basketCurrencyIDRef_ = basketCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketCurrency_ = boost::shared_ptr<Currency>(new Currency(basketCurrencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> Basket::getOpenUnits()
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
std::vector<boost::shared_ptr<BasketConstituent>> Basket::getBasketConstituent()
{
   if(!this->basketConstituentIsNull_){
        if(basketConstituentIDRef_ != ""){
             return this->basketConstituent_;
        }else{
             return this->basketConstituent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BasketConstituent>>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Basket::getBasketDivisor()
{
   if(!this->basketDivisorIsNull_){
        if(basketDivisorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(basketDivisorIDRef_));
        }else{
             return this->basketDivisor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<BasketName> Basket::getBasketName()
{
   if(!this->basketNameIsNull_){
        if(basketNameIDRef_ != ""){
             return boost::shared_static_cast<BasketName>(IDManager::instance().getID(basketNameIDRef_));
        }else{
             return this->basketName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BasketName>();
   }
}
std::vector<boost::shared_ptr<BasketId>> Basket::getBasketId()
{
   if(!this->basketIdIsNull_){
        if(basketIdIDRef_ != ""){
             return this->basketId_;
        }else{
             return this->basketId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BasketId>>();
   }
}
boost::shared_ptr<Currency> Basket::getBasketCurrency()
{
   if(!this->basketCurrencyIsNull_){
        if(basketCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(basketCurrencyIDRef_));
        }else{
             return this->basketCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
}

