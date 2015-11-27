// EarlyTerminationEvent.cpp 
#include "EarlyTerminationEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EarlyTerminationEvent::EarlyTerminationEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustedExerciseDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChildElement("adjustedExerciseDate");

   if(adjustedExerciseDateNode){adjustedExerciseDateIsNull_ = false;}
   else{adjustedExerciseDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedExerciseDateNode , address : " << adjustedExerciseDateNode << std::endl;
   #endif
   if(adjustedExerciseDateNode)
   {
      if(adjustedExerciseDateNode->Attribute("href") || adjustedExerciseDateNode->Attribute("id"))
      {
          if(adjustedExerciseDateNode->Attribute("id"))
          {
             adjustedExerciseDateIDRef_ = adjustedExerciseDateNode->Attribute("id");
             adjustedExerciseDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExerciseDateNode));
             adjustedExerciseDate_->setID(adjustedExerciseDateIDRef_);
             IDManager::instance().setID(adjustedExerciseDateIDRef_,adjustedExerciseDate_);
          }
          else if(adjustedExerciseDateNode->Attribute("href")) { adjustedExerciseDateIDRef_ = adjustedExerciseDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedExerciseDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExerciseDateNode));}
   }

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

   //adjustedExerciseFeePaymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedExerciseFeePaymentDateNode = xmlNode->FirstChildElement("adjustedExerciseFeePaymentDate");

   if(adjustedExerciseFeePaymentDateNode){adjustedExerciseFeePaymentDateIsNull_ = false;}
   else{adjustedExerciseFeePaymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedExerciseFeePaymentDateNode , address : " << adjustedExerciseFeePaymentDateNode << std::endl;
   #endif
   if(adjustedExerciseFeePaymentDateNode)
   {
      if(adjustedExerciseFeePaymentDateNode->Attribute("href") || adjustedExerciseFeePaymentDateNode->Attribute("id"))
      {
          if(adjustedExerciseFeePaymentDateNode->Attribute("id"))
          {
             adjustedExerciseFeePaymentDateIDRef_ = adjustedExerciseFeePaymentDateNode->Attribute("id");
             adjustedExerciseFeePaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExerciseFeePaymentDateNode));
             adjustedExerciseFeePaymentDate_->setID(adjustedExerciseFeePaymentDateIDRef_);
             IDManager::instance().setID(adjustedExerciseFeePaymentDateIDRef_,adjustedExerciseFeePaymentDate_);
          }
          else if(adjustedExerciseFeePaymentDateNode->Attribute("href")) { adjustedExerciseFeePaymentDateIDRef_ = adjustedExerciseFeePaymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedExerciseFeePaymentDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExerciseFeePaymentDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> EarlyTerminationEvent::getAdjustedExerciseDate()
{
   if(!this->adjustedExerciseDateIsNull_){
        if(adjustedExerciseDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedExerciseDateIDRef_));
        }else{
             return this->adjustedExerciseDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> EarlyTerminationEvent::getAdjustedEarlyTerminationDate()
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
boost::shared_ptr<XsdTypeDate> EarlyTerminationEvent::getAdjustedCashSettlementValuationDate()
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
boost::shared_ptr<XsdTypeDate> EarlyTerminationEvent::getAdjustedCashSettlementPaymentDate()
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
boost::shared_ptr<XsdTypeDate> EarlyTerminationEvent::getAdjustedExerciseFeePaymentDate()
{
   if(!this->adjustedExerciseFeePaymentDateIsNull_){
        if(adjustedExerciseFeePaymentDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedExerciseFeePaymentDateIDRef_));
        }else{
             return this->adjustedExerciseFeePaymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

