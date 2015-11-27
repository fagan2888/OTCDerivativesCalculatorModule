// ExchangeTradedContract.cpp 
#include "ExchangeTradedContract.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExchangeTradedContract::ExchangeTradedContract(TiXmlNode* xmlNode)
: ExchangeTraded(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //multiplierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multiplierNode = xmlNode->FirstChildElement("multiplier");

   if(multiplierNode){multiplierIsNull_ = false;}
   else{multiplierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multiplierNode , address : " << multiplierNode << std::endl;
   #endif
   if(multiplierNode)
   {
      if(multiplierNode->Attribute("href") || multiplierNode->Attribute("id"))
      {
          if(multiplierNode->Attribute("id"))
          {
             multiplierIDRef_ = multiplierNode->Attribute("id");
             multiplier_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(multiplierNode));
             multiplier_->setID(multiplierIDRef_);
             IDManager::instance().setID(multiplierIDRef_,multiplier_);
          }
          else if(multiplierNode->Attribute("href")) { multiplierIDRef_ = multiplierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multiplier_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(multiplierNode));}
   }

   //contractReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contractReferenceNode = xmlNode->FirstChildElement("contractReference");

   if(contractReferenceNode){contractReferenceIsNull_ = false;}
   else{contractReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contractReferenceNode , address : " << contractReferenceNode << std::endl;
   #endif
   if(contractReferenceNode)
   {
      if(contractReferenceNode->Attribute("href") || contractReferenceNode->Attribute("id"))
      {
          if(contractReferenceNode->Attribute("id"))
          {
             contractReferenceIDRef_ = contractReferenceNode->Attribute("id");
             contractReference_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(contractReferenceNode));
             contractReference_->setID(contractReferenceIDRef_);
             IDManager::instance().setID(contractReferenceIDRef_,contractReference_);
          }
          else if(contractReferenceNode->Attribute("href")) { contractReferenceIDRef_ = contractReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { contractReference_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(contractReferenceNode));}
   }

   //expirationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationDateNode = xmlNode->FirstChildElement("expirationDate");

   if(expirationDateNode){expirationDateIsNull_ = false;}
   else{expirationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationDateNode , address : " << expirationDateNode << std::endl;
   #endif
   if(expirationDateNode)
   {
      if(expirationDateNode->Attribute("href") || expirationDateNode->Attribute("id"))
      {
          if(expirationDateNode->Attribute("id"))
          {
             expirationDateIDRef_ = expirationDateNode->Attribute("id");
             expirationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateNode));
             expirationDate_->setID(expirationDateIDRef_);
             IDManager::instance().setID(expirationDateIDRef_,expirationDate_);
          }
          else if(expirationDateNode->Attribute("href")) { expirationDateIDRef_ = expirationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expirationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(expirationDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypePositiveInteger> ExchangeTradedContract::getMultiplier()
{
   if(!this->multiplierIsNull_){
        if(multiplierIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(multiplierIDRef_));
        }else{
             return this->multiplier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
boost::shared_ptr<XsdTypeString> ExchangeTradedContract::getContractReference()
{
   if(!this->contractReferenceIsNull_){
        if(contractReferenceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(contractReferenceIDRef_));
        }else{
             return this->contractReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> ExchangeTradedContract::getExpirationDate()
{
   if(!this->expirationDateIsNull_){
        if(expirationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(expirationDateIDRef_));
        }else{
             return this->expirationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
}

