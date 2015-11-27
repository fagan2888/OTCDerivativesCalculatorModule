// SettlementRateSource.cpp 
#include "SettlementRateSource.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementRateSource::SettlementRateSource(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //informationSourceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* informationSourceNode = xmlNode->FirstChildElement("informationSource");

   if(informationSourceNode){informationSourceIsNull_ = false;}
   else{informationSourceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- informationSourceNode , address : " << informationSourceNode << std::endl;
   #endif
   if(informationSourceNode)
   {
      if(informationSourceNode->Attribute("href") || informationSourceNode->Attribute("id"))
      {
          if(informationSourceNode->Attribute("id"))
          {
             informationSourceIDRef_ = informationSourceNode->Attribute("id");
             informationSource_ = boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode));
             informationSource_->setID(informationSourceIDRef_);
             IDManager::instance().setID(informationSourceIDRef_,informationSource_);
          }
          else if(informationSourceNode->Attribute("href")) { informationSourceIDRef_ = informationSourceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { informationSource_ = boost::shared_ptr<InformationSource>(new InformationSource(informationSourceNode));}
   }

   //cashSettlementReferenceBanksNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementReferenceBanksNode = xmlNode->FirstChildElement("cashSettlementReferenceBanks");

   if(cashSettlementReferenceBanksNode){cashSettlementReferenceBanksIsNull_ = false;}
   else{cashSettlementReferenceBanksIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementReferenceBanksNode , address : " << cashSettlementReferenceBanksNode << std::endl;
   #endif
   if(cashSettlementReferenceBanksNode)
   {
      if(cashSettlementReferenceBanksNode->Attribute("href") || cashSettlementReferenceBanksNode->Attribute("id"))
      {
          if(cashSettlementReferenceBanksNode->Attribute("id"))
          {
             cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode->Attribute("id");
             cashSettlementReferenceBanks_ = boost::shared_ptr<CashSettlementReferenceBanks>(new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));
             cashSettlementReferenceBanks_->setID(cashSettlementReferenceBanksIDRef_);
             IDManager::instance().setID(cashSettlementReferenceBanksIDRef_,cashSettlementReferenceBanks_);
          }
          else if(cashSettlementReferenceBanksNode->Attribute("href")) { cashSettlementReferenceBanksIDRef_ = cashSettlementReferenceBanksNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementReferenceBanks_ = boost::shared_ptr<CashSettlementReferenceBanks>(new CashSettlementReferenceBanks(cashSettlementReferenceBanksNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InformationSource> SettlementRateSource::getInformationSource()
{
   if(!this->informationSourceIsNull_){
        if(informationSourceIDRef_ != ""){
             return boost::shared_static_cast<InformationSource>(IDManager::instance().getID(informationSourceIDRef_));
        }else{
             return this->informationSource_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InformationSource>();
   }
}
boost::shared_ptr<CashSettlementReferenceBanks> SettlementRateSource::getCashSettlementReferenceBanks()
{
   if(!this->cashSettlementReferenceBanksIsNull_){
        if(cashSettlementReferenceBanksIDRef_ != ""){
             return boost::shared_static_cast<CashSettlementReferenceBanks>(IDManager::instance().getID(cashSettlementReferenceBanksIDRef_));
        }else{
             return this->cashSettlementReferenceBanks_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CashSettlementReferenceBanks>();
   }
}
}

