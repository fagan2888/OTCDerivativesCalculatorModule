// ReturnSwapAmount.cpp 
#include "ReturnSwapAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwapAmount::ReturnSwapAmount(TiXmlNode* xmlNode)
: LegAmount(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //cashSettlementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementNode = xmlNode->FirstChildElement("cashSettlement");

   if(cashSettlementNode){cashSettlementIsNull_ = false;}
   else{cashSettlementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementNode , address : " << cashSettlementNode << std::endl;
   #endif
   if(cashSettlementNode)
   {
      if(cashSettlementNode->Attribute("href") || cashSettlementNode->Attribute("id"))
      {
          if(cashSettlementNode->Attribute("id"))
          {
             cashSettlementIDRef_ = cashSettlementNode->Attribute("id");
             cashSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(cashSettlementNode));
             cashSettlement_->setID(cashSettlementIDRef_);
             IDManager::instance().setID(cashSettlementIDRef_,cashSettlement_);
          }
          else if(cashSettlementNode->Attribute("href")) { cashSettlementIDRef_ = cashSettlementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(cashSettlementNode));}
   }

   //optionsExchangeDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionsExchangeDividendsNode = xmlNode->FirstChildElement("optionsExchangeDividends");

   if(optionsExchangeDividendsNode){optionsExchangeDividendsIsNull_ = false;}
   else{optionsExchangeDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionsExchangeDividendsNode , address : " << optionsExchangeDividendsNode << std::endl;
   #endif
   if(optionsExchangeDividendsNode)
   {
      if(optionsExchangeDividendsNode->Attribute("href") || optionsExchangeDividendsNode->Attribute("id"))
      {
          if(optionsExchangeDividendsNode->Attribute("id"))
          {
             optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode->Attribute("id");
             optionsExchangeDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionsExchangeDividendsNode));
             optionsExchangeDividends_->setID(optionsExchangeDividendsIDRef_);
             IDManager::instance().setID(optionsExchangeDividendsIDRef_,optionsExchangeDividends_);
          }
          else if(optionsExchangeDividendsNode->Attribute("href")) { optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionsExchangeDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionsExchangeDividendsNode));}
   }

   //additionalDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalDividendsNode = xmlNode->FirstChildElement("additionalDividends");

   if(additionalDividendsNode){additionalDividendsIsNull_ = false;}
   else{additionalDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalDividendsNode , address : " << additionalDividendsNode << std::endl;
   #endif
   if(additionalDividendsNode)
   {
      if(additionalDividendsNode->Attribute("href") || additionalDividendsNode->Attribute("id"))
      {
          if(additionalDividendsNode->Attribute("id"))
          {
             additionalDividendsIDRef_ = additionalDividendsNode->Attribute("id");
             additionalDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(additionalDividendsNode));
             additionalDividends_->setID(additionalDividendsIDRef_);
             IDManager::instance().setID(additionalDividendsIDRef_,additionalDividends_);
          }
          else if(additionalDividendsNode->Attribute("href")) { additionalDividendsIDRef_ = additionalDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(additionalDividendsNode));}
   }

   //allDividendsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allDividendsNode = xmlNode->FirstChildElement("allDividends");

   if(allDividendsNode){allDividendsIsNull_ = false;}
   else{allDividendsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allDividendsNode , address : " << allDividendsNode << std::endl;
   #endif
   if(allDividendsNode)
   {
      if(allDividendsNode->Attribute("href") || allDividendsNode->Attribute("id"))
      {
          if(allDividendsNode->Attribute("id"))
          {
             allDividendsIDRef_ = allDividendsNode->Attribute("id");
             allDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(allDividendsNode));
             allDividends_->setID(allDividendsIDRef_);
             IDManager::instance().setID(allDividendsIDRef_,allDividends_);
          }
          else if(allDividendsNode->Attribute("href")) { allDividendsIDRef_ = allDividendsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { allDividends_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(allDividendsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> ReturnSwapAmount::getCashSettlement()
{
   if(!this->cashSettlementIsNull_){
        if(cashSettlementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(cashSettlementIDRef_));
        }else{
             return this->cashSettlement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReturnSwapAmount::getOptionsExchangeDividends()
{
   if(!this->optionsExchangeDividendsIsNull_){
        if(optionsExchangeDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(optionsExchangeDividendsIDRef_));
        }else{
             return this->optionsExchangeDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReturnSwapAmount::getAdditionalDividends()
{
   if(!this->additionalDividendsIsNull_){
        if(additionalDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(additionalDividendsIDRef_));
        }else{
             return this->additionalDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReturnSwapAmount::getAllDividends()
{
   if(!this->allDividendsIsNull_){
        if(allDividendsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(allDividendsIDRef_));
        }else{
             return this->allDividends_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

