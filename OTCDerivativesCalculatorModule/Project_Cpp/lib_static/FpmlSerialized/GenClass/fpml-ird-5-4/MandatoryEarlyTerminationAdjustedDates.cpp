// MandatoryEarlyTerminationAdjustedDates.cpp 
#include "MandatoryEarlyTerminationAdjustedDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MandatoryEarlyTerminationAdjustedDates::MandatoryEarlyTerminationAdjustedDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustedEarlyTerminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChildElement("adjustedEarlyTerminationDate");

   if(adjustedEarlyTerminationDateNode){adjustedEarlyTerminationDateIsNull_ = false;}
   else{adjustedEarlyTerminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedEarlyTerminationDateNode , address : " << adjustedEarlyTerminationDateNode << std::endl;
   #endif
   if(adjustedEarlyTerminationDateNode)
   {
      if(adjustedEarlyTerminationDateNode->Attribute("href") || adjustedEarlyTerminationDateNode->Attribute("id"))
      {
          if(adjustedEarlyTerminationDateNode->Attribute("id"))
          {
             adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode->Attribute("id");
             adjustedEarlyTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedEarlyTerminationDateNode));
             adjustedEarlyTerminationDate_->setID(adjustedEarlyTerminationDateIDRef_);
             IDManager::instance().setID(adjustedEarlyTerminationDateIDRef_,adjustedEarlyTerminationDate_);
          }
          else if(adjustedEarlyTerminationDateNode->Attribute("href")) { adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedEarlyTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedEarlyTerminationDateNode));}
   }

   //adjustedCashSettlementValuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedCashSettlementValuationDateNode = xmlNode->FirstChildElement("adjustedCashSettlementValuationDate");

   if(adjustedCashSettlementValuationDateNode){adjustedCashSettlementValuationDateIsNull_ = false;}
   else{adjustedCashSettlementValuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedCashSettlementValuationDateNode , address : " << adjustedCashSettlementValuationDateNode << std::endl;
   #endif
   if(adjustedCashSettlementValuationDateNode)
   {
      if(adjustedCashSettlementValuationDateNode->Attribute("href") || adjustedCashSettlementValuationDateNode->Attribute("id"))
      {
          if(adjustedCashSettlementValuationDateNode->Attribute("id"))
          {
             adjustedCashSettlementValuationDateIDRef_ = adjustedCashSettlementValuationDateNode->Attribute("id");
             adjustedCashSettlementValuationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedCashSettlementValuationDateNode));
             adjustedCashSettlementValuationDate_->setID(adjustedCashSettlementValuationDateIDRef_);
             IDManager::instance().setID(adjustedCashSettlementValuationDateIDRef_,adjustedCashSettlementValuationDate_);
          }
          else if(adjustedCashSettlementValuationDateNode->Attribute("href")) { adjustedCashSettlementValuationDateIDRef_ = adjustedCashSettlementValuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedCashSettlementValuationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedCashSettlementValuationDateNode));}
   }

   //adjustedCashSettlementPaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedCashSettlementPaymentDateNode = xmlNode->FirstChildElement("adjustedCashSettlementPaymentDate");

   if(adjustedCashSettlementPaymentDateNode){adjustedCashSettlementPaymentDateIsNull_ = false;}
   else{adjustedCashSettlementPaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedCashSettlementPaymentDateNode , address : " << adjustedCashSettlementPaymentDateNode << std::endl;
   #endif
   if(adjustedCashSettlementPaymentDateNode)
   {
      if(adjustedCashSettlementPaymentDateNode->Attribute("href") || adjustedCashSettlementPaymentDateNode->Attribute("id"))
      {
          if(adjustedCashSettlementPaymentDateNode->Attribute("id"))
          {
             adjustedCashSettlementPaymentDateIDRef_ = adjustedCashSettlementPaymentDateNode->Attribute("id");
             adjustedCashSettlementPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedCashSettlementPaymentDateNode));
             adjustedCashSettlementPaymentDate_->setID(adjustedCashSettlementPaymentDateIDRef_);
             IDManager::instance().setID(adjustedCashSettlementPaymentDateIDRef_,adjustedCashSettlementPaymentDate_);
          }
          else if(adjustedCashSettlementPaymentDateNode->Attribute("href")) { adjustedCashSettlementPaymentDateIDRef_ = adjustedCashSettlementPaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedCashSettlementPaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedCashSettlementPaymentDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> MandatoryEarlyTerminationAdjustedDates::getAdjustedEarlyTerminationDate()
{
   if(!this->adjustedEarlyTerminationDateIsNull_){
        if(adjustedEarlyTerminationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedEarlyTerminationDateIDRef_));
        }else{
             return this->adjustedEarlyTerminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> MandatoryEarlyTerminationAdjustedDates::getAdjustedCashSettlementValuationDate()
{
   if(!this->adjustedCashSettlementValuationDateIsNull_){
        if(adjustedCashSettlementValuationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedCashSettlementValuationDateIDRef_));
        }else{
             return this->adjustedCashSettlementValuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> MandatoryEarlyTerminationAdjustedDates::getAdjustedCashSettlementPaymentDate()
{
   if(!this->adjustedCashSettlementPaymentDateIsNull_){
        if(adjustedCashSettlementPaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedCashSettlementPaymentDateIDRef_));
        }else{
             return this->adjustedCashSettlementPaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

