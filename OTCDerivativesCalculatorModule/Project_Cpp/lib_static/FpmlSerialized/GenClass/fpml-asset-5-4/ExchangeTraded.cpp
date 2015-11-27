// ExchangeTraded.cpp 
#include "ExchangeTraded.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExchangeTraded::ExchangeTraded(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //relatedExchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relatedExchangeIdNode = xmlNode->FirstChildElement("relatedExchangeId");

   if(relatedExchangeIdNode){relatedExchangeIdIsNull_ = false;}
   else{relatedExchangeIdIsNull_ = true;}

   if(relatedExchangeIdNode)
   {
      for(relatedExchangeIdNode; relatedExchangeIdNode; relatedExchangeIdNode = relatedExchangeIdNode->NextSiblingElement("relatedExchangeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedExchangeIdNode , address : " << relatedExchangeIdNode << std::endl;
          #endif
          if(relatedExchangeIdNode->Attribute("href") || relatedExchangeIdNode->Attribute("id"))
          {
              if(relatedExchangeIdNode->Attribute("id"))
              {
                  relatedExchangeIdIDRef_ = relatedExchangeIdNode->Attribute("id");
                  relatedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(relatedExchangeIdNode)));
                  relatedExchangeId_.back()->setID(relatedExchangeIdIDRef_);
                  IDManager::instance().setID(relatedExchangeIdIDRef_, relatedExchangeId_.back());
              }
              else if(relatedExchangeIdNode->Attribute("href")) { relatedExchangeIdIDRef_ = relatedExchangeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { relatedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(relatedExchangeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relatedExchangeIdNode , address : " << relatedExchangeIdNode << std::endl;
       #endif
   }

   //optionsExchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionsExchangeIdNode = xmlNode->FirstChildElement("optionsExchangeId");

   if(optionsExchangeIdNode){optionsExchangeIdIsNull_ = false;}
   else{optionsExchangeIdIsNull_ = true;}

   if(optionsExchangeIdNode)
   {
      for(optionsExchangeIdNode; optionsExchangeIdNode; optionsExchangeIdNode = optionsExchangeIdNode->NextSiblingElement("optionsExchangeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionsExchangeIdNode , address : " << optionsExchangeIdNode << std::endl;
          #endif
          if(optionsExchangeIdNode->Attribute("href") || optionsExchangeIdNode->Attribute("id"))
          {
              if(optionsExchangeIdNode->Attribute("id"))
              {
                  optionsExchangeIdIDRef_ = optionsExchangeIdNode->Attribute("id");
                  optionsExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(optionsExchangeIdNode)));
                  optionsExchangeId_.back()->setID(optionsExchangeIdIDRef_);
                  IDManager::instance().setID(optionsExchangeIdIDRef_, optionsExchangeId_.back());
              }
              else if(optionsExchangeIdNode->Attribute("href")) { optionsExchangeIdIDRef_ = optionsExchangeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { optionsExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(optionsExchangeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionsExchangeIdNode , address : " << optionsExchangeIdNode << std::endl;
       #endif
   }

   //specifiedExchangeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specifiedExchangeIdNode = xmlNode->FirstChildElement("specifiedExchangeId");

   if(specifiedExchangeIdNode){specifiedExchangeIdIsNull_ = false;}
   else{specifiedExchangeIdIsNull_ = true;}

   if(specifiedExchangeIdNode)
   {
      for(specifiedExchangeIdNode; specifiedExchangeIdNode; specifiedExchangeIdNode = specifiedExchangeIdNode->NextSiblingElement("specifiedExchangeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedExchangeIdNode , address : " << specifiedExchangeIdNode << std::endl;
          #endif
          if(specifiedExchangeIdNode->Attribute("href") || specifiedExchangeIdNode->Attribute("id"))
          {
              if(specifiedExchangeIdNode->Attribute("id"))
              {
                  specifiedExchangeIdIDRef_ = specifiedExchangeIdNode->Attribute("id");
                  specifiedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(specifiedExchangeIdNode)));
                  specifiedExchangeId_.back()->setID(specifiedExchangeIdIDRef_);
                  IDManager::instance().setID(specifiedExchangeIdIDRef_, specifiedExchangeId_.back());
              }
              else if(specifiedExchangeIdNode->Attribute("href")) { specifiedExchangeIdIDRef_ = specifiedExchangeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { specifiedExchangeId_.push_back(boost::shared_ptr<ExchangeId>(new ExchangeId(specifiedExchangeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedExchangeIdNode , address : " << specifiedExchangeIdNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ExchangeId>> ExchangeTraded::getRelatedExchangeId()
{
   if(!this->relatedExchangeIdIsNull_){
        if(relatedExchangeIdIDRef_ != ""){
             return this->relatedExchangeId_;
        }else{
             return this->relatedExchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExchangeId>>();
   }
}
std::vector<boost::shared_ptr<ExchangeId>> ExchangeTraded::getOptionsExchangeId()
{
   if(!this->optionsExchangeIdIsNull_){
        if(optionsExchangeIdIDRef_ != ""){
             return this->optionsExchangeId_;
        }else{
             return this->optionsExchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExchangeId>>();
   }
}
std::vector<boost::shared_ptr<ExchangeId>> ExchangeTraded::getSpecifiedExchangeId()
{
   if(!this->specifiedExchangeIdIsNull_){
        if(specifiedExchangeIdIDRef_ != ""){
             return this->specifiedExchangeId_;
        }else{
             return this->specifiedExchangeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExchangeId>>();
   }
}
}

