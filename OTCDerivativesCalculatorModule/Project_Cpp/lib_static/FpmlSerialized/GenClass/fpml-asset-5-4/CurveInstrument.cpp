// CurveInstrument.cpp 
#include "CurveInstrument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CurveInstrument::CurveInstrument(TiXmlNode* xmlNode)
: IdentifiedAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
      if(currencyNode->Attribute("href") || currencyNode->Attribute("id"))
      {
          if(currencyNode->Attribute("id"))
          {
             currencyIDRef_ = currencyNode->Attribute("id");
             currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));
             currency_->setID(currencyIDRef_);
             IDManager::instance().setID(currencyIDRef_,currency_);
          }
          else if(currencyNode->Attribute("href")) { currencyIDRef_ = currencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { currency_ = boost::shared_ptr<Currency>(new Currency(currencyNode));}
   }

   //exchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeIdNode = xmlNode->FirstChildElement("exchangeId");

   if(exchangeIdNode){exchangeIdIsNull_ = false;}
   else{exchangeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeIdNode , address : " << exchangeIdNode << std::endl;
   #endif
   if(exchangeIdNode)
   {
      if(exchangeIdNode->Attribute("href") || exchangeIdNode->Attribute("id"))
      {
          if(exchangeIdNode->Attribute("id"))
          {
             exchangeIdIDRef_ = exchangeIdNode->Attribute("id");
             exchangeId_ = boost::shared_ptr<ExchangeId>(new ExchangeId(exchangeIdNode));
             exchangeId_->setID(exchangeIdIDRef_);
             IDManager::instance().setID(exchangeIdIDRef_,exchangeId_);
          }
          else if(exchangeIdNode->Attribute("href")) { exchangeIdIDRef_ = exchangeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeId_ = boost::shared_ptr<ExchangeId>(new ExchangeId(exchangeIdNode));}
   }

   //clearanceSystemNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* clearanceSystemNode = xmlNode->FirstChildElement("clearanceSystem");

   if(clearanceSystemNode){clearanceSystemIsNull_ = false;}
   else{clearanceSystemIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- clearanceSystemNode , address : " << clearanceSystemNode << std::endl;
   #endif
   if(clearanceSystemNode)
   {
      if(clearanceSystemNode->Attribute("href") || clearanceSystemNode->Attribute("id"))
      {
          if(clearanceSystemNode->Attribute("id"))
          {
             clearanceSystemIDRef_ = clearanceSystemNode->Attribute("id");
             clearanceSystem_ = boost::shared_ptr<ClearanceSystem>(new ClearanceSystem(clearanceSystemNode));
             clearanceSystem_->setID(clearanceSystemIDRef_);
             IDManager::instance().setID(clearanceSystemIDRef_,clearanceSystem_);
          }
          else if(clearanceSystemNode->Attribute("href")) { clearanceSystemIDRef_ = clearanceSystemNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { clearanceSystem_ = boost::shared_ptr<ClearanceSystem>(new ClearanceSystem(clearanceSystemNode));}
   }

   //definitionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* definitionNode = xmlNode->FirstChildElement("definition");

   if(definitionNode){definitionIsNull_ = false;}
   else{definitionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- definitionNode , address : " << definitionNode << std::endl;
   #endif
   if(definitionNode)
   {
      if(definitionNode->Attribute("href") || definitionNode->Attribute("id"))
      {
          if(definitionNode->Attribute("id"))
          {
             definitionIDRef_ = definitionNode->Attribute("id");
             definition_ = boost::shared_ptr<ProductReference>(new ProductReference(definitionNode));
             definition_->setID(definitionIDRef_);
             IDManager::instance().setID(definitionIDRef_,definition_);
          }
          else if(definitionNode->Attribute("href")) { definitionIDRef_ = definitionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { definition_ = boost::shared_ptr<ProductReference>(new ProductReference(definitionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Currency> CurveInstrument::getCurrency()
{
   if(!this->currencyIsNull_){
        if(currencyIDRef_ != ""){
             return boost::shared_static_cast<Currency>(IDManager::instance().getID(currencyIDRef_));
        }else{
             return this->currency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Currency>();
   }
}
boost::shared_ptr<ExchangeId> CurveInstrument::getExchangeId()
{
   if(!this->exchangeIdIsNull_){
        if(exchangeIdIDRef_ != ""){
             return boost::shared_static_cast<ExchangeId>(IDManager::instance().getID(exchangeIdIDRef_));
        }else{
             return this->exchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExchangeId>();
   }
}
boost::shared_ptr<ClearanceSystem> CurveInstrument::getClearanceSystem()
{
   if(!this->clearanceSystemIsNull_){
        if(clearanceSystemIDRef_ != ""){
             return boost::shared_static_cast<ClearanceSystem>(IDManager::instance().getID(clearanceSystemIDRef_));
        }else{
             return this->clearanceSystem_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ClearanceSystem>();
   }
}
boost::shared_ptr<ProductReference> CurveInstrument::getDefinition()
{
   if(!this->definitionIsNull_){
        if(definitionIDRef_ != ""){
             return boost::shared_static_cast<ProductReference>(IDManager::instance().getID(definitionIDRef_));
        }else{
             return this->definition_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProductReference>();
   }
}
}

