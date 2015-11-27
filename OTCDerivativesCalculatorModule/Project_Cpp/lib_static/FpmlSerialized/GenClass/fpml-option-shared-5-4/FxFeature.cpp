// FxFeature.cpp 
#include "FxFeature.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxFeature::FxFeature(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceCurrencyNode = xmlNode->FirstChildElement("referenceCurrency");

   if(referenceCurrencyNode){referenceCurrencyIsNull_ = false;}
   else{referenceCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceCurrencyNode , address : " << referenceCurrencyNode << std::endl;
   #endif
   if(referenceCurrencyNode)
   {
      if(referenceCurrencyNode->Attribute("href") || referenceCurrencyNode->Attribute("id"))
      {
          if(referenceCurrencyNode->Attribute("id"))
          {
             referenceCurrencyIDRef_ = referenceCurrencyNode->Attribute("id");
             referenceCurrency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(referenceCurrencyNode));
             referenceCurrency_->setID(referenceCurrencyIDRef_);
             IDManager::instance().setID(referenceCurrencyIDRef_,referenceCurrency_);
          }
          else if(referenceCurrencyNode->Attribute("href")) { referenceCurrencyIDRef_ = referenceCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceCurrency_ = boost::shared_ptr<IdentifiedCurrency>(new IdentifiedCurrency(referenceCurrencyNode));}
   }

   //compositeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compositeNode = xmlNode->FirstChildElement("composite");

   if(compositeNode){compositeIsNull_ = false;}
   else{compositeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compositeNode , address : " << compositeNode << std::endl;
   #endif
   if(compositeNode)
   {
      if(compositeNode->Attribute("href") || compositeNode->Attribute("id"))
      {
          if(compositeNode->Attribute("id"))
          {
             compositeIDRef_ = compositeNode->Attribute("id");
             composite_ = boost::shared_ptr<Composite>(new Composite(compositeNode));
             composite_->setID(compositeIDRef_);
             IDManager::instance().setID(compositeIDRef_,composite_);
          }
          else if(compositeNode->Attribute("href")) { compositeIDRef_ = compositeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { composite_ = boost::shared_ptr<Composite>(new Composite(compositeNode));}
   }

   //quantoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quantoNode = xmlNode->FirstChildElement("quanto");

   if(quantoNode){quantoIsNull_ = false;}
   else{quantoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quantoNode , address : " << quantoNode << std::endl;
   #endif
   if(quantoNode)
   {
      if(quantoNode->Attribute("href") || quantoNode->Attribute("id"))
      {
          if(quantoNode->Attribute("id"))
          {
             quantoIDRef_ = quantoNode->Attribute("id");
             quanto_ = boost::shared_ptr<Quanto>(new Quanto(quantoNode));
             quanto_->setID(quantoIDRef_);
             IDManager::instance().setID(quantoIDRef_,quanto_);
          }
          else if(quantoNode->Attribute("href")) { quantoIDRef_ = quantoNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quanto_ = boost::shared_ptr<Quanto>(new Quanto(quantoNode));}
   }

   //crossCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* crossCurrencyNode = xmlNode->FirstChildElement("crossCurrency");

   if(crossCurrencyNode){crossCurrencyIsNull_ = false;}
   else{crossCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- crossCurrencyNode , address : " << crossCurrencyNode << std::endl;
   #endif
   if(crossCurrencyNode)
   {
      if(crossCurrencyNode->Attribute("href") || crossCurrencyNode->Attribute("id"))
      {
          if(crossCurrencyNode->Attribute("id"))
          {
             crossCurrencyIDRef_ = crossCurrencyNode->Attribute("id");
             crossCurrency_ = boost::shared_ptr<Composite>(new Composite(crossCurrencyNode));
             crossCurrency_->setID(crossCurrencyIDRef_);
             IDManager::instance().setID(crossCurrencyIDRef_,crossCurrency_);
          }
          else if(crossCurrencyNode->Attribute("href")) { crossCurrencyIDRef_ = crossCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { crossCurrency_ = boost::shared_ptr<Composite>(new Composite(crossCurrencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IdentifiedCurrency> FxFeature::getReferenceCurrency()
{
   if(!this->referenceCurrencyIsNull_){
        if(referenceCurrencyIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedCurrency>(IDManager::instance().getID(referenceCurrencyIDRef_));
        }else{
             return this->referenceCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedCurrency>();
   }
}
boost::shared_ptr<Composite> FxFeature::getComposite()
{
   if(!this->compositeIsNull_){
        if(compositeIDRef_ != ""){
             return boost::shared_static_cast<Composite>(IDManager::instance().getID(compositeIDRef_));
        }else{
             return this->composite_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Composite>();
   }
}
boost::shared_ptr<Quanto> FxFeature::getQuanto()
{
   if(!this->quantoIsNull_){
        if(quantoIDRef_ != ""){
             return boost::shared_static_cast<Quanto>(IDManager::instance().getID(quantoIDRef_));
        }else{
             return this->quanto_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Quanto>();
   }
}
boost::shared_ptr<Composite> FxFeature::getCrossCurrency()
{
   if(!this->crossCurrencyIsNull_){
        if(crossCurrencyIDRef_ != ""){
             return boost::shared_static_cast<Composite>(IDManager::instance().getID(crossCurrencyIDRef_));
        }else{
             return this->crossCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Composite>();
   }
}
}

