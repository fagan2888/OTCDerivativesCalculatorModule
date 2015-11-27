// Cash.cpp 
#include "Cash.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Cash::Cash(TiXmlNode* xmlNode)
: Asset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //instrumentIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentIdNode = xmlNode->FirstChildElement("instrumentId");

   if(instrumentIdNode){instrumentIdIsNull_ = false;}
   else{instrumentIdIsNull_ = true;}

   if(instrumentIdNode)
   {
      for(instrumentIdNode; instrumentIdNode; instrumentIdNode = instrumentIdNode->NextSiblingElement("instrumentId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentIdNode , address : " << instrumentIdNode << std::endl;
          #endif
          if(instrumentIdNode->Attribute("href") || instrumentIdNode->Attribute("id"))
          {
              if(instrumentIdNode->Attribute("id"))
              {
                  instrumentIdIDRef_ = instrumentIdNode->Attribute("id");
                  instrumentId_.push_back(boost::shared_ptr<InstrumentId>(new InstrumentId(instrumentIdNode)));
                  instrumentId_.back()->setID(instrumentIdIDRef_);
                  IDManager::instance().setID(instrumentIdIDRef_, instrumentId_.back());
              }
              else if(instrumentIdNode->Attribute("href")) { instrumentIdIDRef_ = instrumentIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { instrumentId_.push_back(boost::shared_ptr<InstrumentId>(new InstrumentId(instrumentIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentIdNode , address : " << instrumentIdNode << std::endl;
       #endif
   }

   //descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* descriptionNode = xmlNode->FirstChildElement("description");

   if(descriptionNode){descriptionIsNull_ = false;}
   else{descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- descriptionNode , address : " << descriptionNode << std::endl;
   #endif
   if(descriptionNode)
   {
      if(descriptionNode->Attribute("href") || descriptionNode->Attribute("id"))
      {
          if(descriptionNode->Attribute("id"))
          {
             descriptionIDRef_ = descriptionNode->Attribute("id");
             description_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(descriptionNode));
             description_->setID(descriptionIDRef_);
             IDManager::instance().setID(descriptionIDRef_,description_);
          }
          else if(descriptionNode->Attribute("href")) { descriptionIDRef_ = descriptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { description_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(descriptionNode));}
   }

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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<InstrumentId>> Cash::getInstrumentId()
{
   if(!this->instrumentIdIsNull_){
        if(instrumentIdIDRef_ != ""){
             return this->instrumentId_;
        }else{
             return this->instrumentId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InstrumentId>>();
   }
}
boost::shared_ptr<XsdTypeString> Cash::getDescription()
{
   if(!this->descriptionIsNull_){
        if(descriptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(descriptionIDRef_));
        }else{
             return this->description_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<Currency> Cash::getCurrency()
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
}

