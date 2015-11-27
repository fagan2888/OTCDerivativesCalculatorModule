// VarianceSwapTransactionSupplement.cpp 
#include "VarianceSwapTransactionSupplement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VarianceSwapTransactionSupplement::VarianceSwapTransactionSupplement(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //varianceLegNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* varianceLegNode = xmlNode->FirstChildElement("varianceLeg");

   if(varianceLegNode){varianceLegIsNull_ = false;}
   else{varianceLegIsNull_ = true;}

   if(varianceLegNode)
   {
      for(varianceLegNode; varianceLegNode; varianceLegNode = varianceLegNode->NextSiblingElement("varianceLeg")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceLegNode , address : " << varianceLegNode << std::endl;
          #endif
          if(varianceLegNode->Attribute("href") || varianceLegNode->Attribute("id"))
          {
              if(varianceLegNode->Attribute("id"))
              {
                  varianceLegIDRef_ = varianceLegNode->Attribute("id");
                  varianceLeg_.push_back(boost::shared_ptr<VarianceLeg>(new VarianceLeg(varianceLegNode)));
                  varianceLeg_.back()->setID(varianceLegIDRef_);
                  IDManager::instance().setID(varianceLegIDRef_, varianceLeg_.back());
              }
              else if(varianceLegNode->Attribute("href")) { varianceLegIDRef_ = varianceLegNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { varianceLeg_.push_back(boost::shared_ptr<VarianceLeg>(new VarianceLeg(varianceLegNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- varianceLegNode , address : " << varianceLegNode << std::endl;
       #endif
   }

   //multipleExchangeIndexAnnexFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleExchangeIndexAnnexFallbackNode = xmlNode->FirstChildElement("multipleExchangeIndexAnnexFallback");

   if(multipleExchangeIndexAnnexFallbackNode){multipleExchangeIndexAnnexFallbackIsNull_ = false;}
   else{multipleExchangeIndexAnnexFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleExchangeIndexAnnexFallbackNode , address : " << multipleExchangeIndexAnnexFallbackNode << std::endl;
   #endif
   if(multipleExchangeIndexAnnexFallbackNode)
   {
      if(multipleExchangeIndexAnnexFallbackNode->Attribute("href") || multipleExchangeIndexAnnexFallbackNode->Attribute("id"))
      {
          if(multipleExchangeIndexAnnexFallbackNode->Attribute("id"))
          {
             multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode->Attribute("id");
             multipleExchangeIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode));
             multipleExchangeIndexAnnexFallback_->setID(multipleExchangeIndexAnnexFallbackIDRef_);
             IDManager::instance().setID(multipleExchangeIndexAnnexFallbackIDRef_,multipleExchangeIndexAnnexFallback_);
          }
          else if(multipleExchangeIndexAnnexFallbackNode->Attribute("href")) { multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleExchangeIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode));}
   }

   //componentSecurityIndexAnnexFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* componentSecurityIndexAnnexFallbackNode = xmlNode->FirstChildElement("componentSecurityIndexAnnexFallback");

   if(componentSecurityIndexAnnexFallbackNode){componentSecurityIndexAnnexFallbackIsNull_ = false;}
   else{componentSecurityIndexAnnexFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- componentSecurityIndexAnnexFallbackNode , address : " << componentSecurityIndexAnnexFallbackNode << std::endl;
   #endif
   if(componentSecurityIndexAnnexFallbackNode)
   {
      if(componentSecurityIndexAnnexFallbackNode->Attribute("href") || componentSecurityIndexAnnexFallbackNode->Attribute("id"))
      {
          if(componentSecurityIndexAnnexFallbackNode->Attribute("id"))
          {
             componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode->Attribute("id");
             componentSecurityIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode));
             componentSecurityIndexAnnexFallback_->setID(componentSecurityIndexAnnexFallbackIDRef_);
             IDManager::instance().setID(componentSecurityIndexAnnexFallbackIDRef_,componentSecurityIndexAnnexFallback_);
          }
          else if(componentSecurityIndexAnnexFallbackNode->Attribute("href")) { componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { componentSecurityIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode));}
   }

   //localJurisdictionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* localJurisdictionNode = xmlNode->FirstChildElement("localJurisdiction");

   if(localJurisdictionNode){localJurisdictionIsNull_ = false;}
   else{localJurisdictionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- localJurisdictionNode , address : " << localJurisdictionNode << std::endl;
   #endif
   if(localJurisdictionNode)
   {
      if(localJurisdictionNode->Attribute("href") || localJurisdictionNode->Attribute("id"))
      {
          if(localJurisdictionNode->Attribute("id"))
          {
             localJurisdictionIDRef_ = localJurisdictionNode->Attribute("id");
             localJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(localJurisdictionNode));
             localJurisdiction_->setID(localJurisdictionIDRef_);
             IDManager::instance().setID(localJurisdictionIDRef_,localJurisdiction_);
          }
          else if(localJurisdictionNode->Attribute("href")) { localJurisdictionIDRef_ = localJurisdictionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { localJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(localJurisdictionNode));}
   }

   //relevantJurisdictionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relevantJurisdictionNode = xmlNode->FirstChildElement("relevantJurisdiction");

   if(relevantJurisdictionNode){relevantJurisdictionIsNull_ = false;}
   else{relevantJurisdictionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relevantJurisdictionNode , address : " << relevantJurisdictionNode << std::endl;
   #endif
   if(relevantJurisdictionNode)
   {
      if(relevantJurisdictionNode->Attribute("href") || relevantJurisdictionNode->Attribute("id"))
      {
          if(relevantJurisdictionNode->Attribute("id"))
          {
             relevantJurisdictionIDRef_ = relevantJurisdictionNode->Attribute("id");
             relevantJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(relevantJurisdictionNode));
             relevantJurisdiction_->setID(relevantJurisdictionIDRef_);
             IDManager::instance().setID(relevantJurisdictionIDRef_,relevantJurisdiction_);
          }
          else if(relevantJurisdictionNode->Attribute("href")) { relevantJurisdictionIDRef_ = relevantJurisdictionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relevantJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(relevantJurisdictionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<VarianceLeg>> VarianceSwapTransactionSupplement::getVarianceLeg()
{
   if(!this->varianceLegIsNull_){
        if(varianceLegIDRef_ != ""){
             return this->varianceLeg_;
        }else{
             return this->varianceLeg_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<VarianceLeg>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> VarianceSwapTransactionSupplement::getMultipleExchangeIndexAnnexFallback()
{
   if(!this->multipleExchangeIndexAnnexFallbackIsNull_){
        if(multipleExchangeIndexAnnexFallbackIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(multipleExchangeIndexAnnexFallbackIDRef_));
        }else{
             return this->multipleExchangeIndexAnnexFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> VarianceSwapTransactionSupplement::getComponentSecurityIndexAnnexFallback()
{
   if(!this->componentSecurityIndexAnnexFallbackIsNull_){
        if(componentSecurityIndexAnnexFallbackIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(componentSecurityIndexAnnexFallbackIDRef_));
        }else{
             return this->componentSecurityIndexAnnexFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CountryCode> VarianceSwapTransactionSupplement::getLocalJurisdiction()
{
   if(!this->localJurisdictionIsNull_){
        if(localJurisdictionIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(localJurisdictionIDRef_));
        }else{
             return this->localJurisdiction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
boost::shared_ptr<CountryCode> VarianceSwapTransactionSupplement::getRelevantJurisdiction()
{
   if(!this->relevantJurisdictionIsNull_){
        if(relevantJurisdictionIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(relevantJurisdictionIDRef_));
        }else{
             return this->relevantJurisdiction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
}

