// RateIndex.cpp 
#include "RateIndex.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RateIndex::RateIndex(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //floatingRateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* floatingRateIndexNode = xmlNode->FirstChildElement("floatingRateIndex");

   if(floatingRateIndexNode){floatingRateIndexIsNull_ = false;}
   else{floatingRateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- floatingRateIndexNode , address : " << floatingRateIndexNode << std::endl;
   #endif
   if(floatingRateIndexNode)
   {
      if(floatingRateIndexNode->Attribute("href") || floatingRateIndexNode->Attribute("id"))
      {
          if(floatingRateIndexNode->Attribute("id"))
          {
             floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("id");
             floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));
             floatingRateIndex_->setID(floatingRateIndexIDRef_);
             IDManager::instance().setID(floatingRateIndexIDRef_,floatingRateIndex_);
          }
          else if(floatingRateIndexNode->Attribute("href")) { floatingRateIndexIDRef_ = floatingRateIndexNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { floatingRateIndex_ = boost::shared_ptr<FloatingRateIndex>(new FloatingRateIndex(floatingRateIndexNode));}
   }

   //termNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* termNode = xmlNode->FirstChildElement("term");

   if(termNode){termIsNull_ = false;}
   else{termIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- termNode , address : " << termNode << std::endl;
   #endif
   if(termNode)
   {
      if(termNode->Attribute("href") || termNode->Attribute("id"))
      {
          if(termNode->Attribute("id"))
          {
             termIDRef_ = termNode->Attribute("id");
             term_ = boost::shared_ptr<Period>(new Period(termNode));
             term_->setID(termIDRef_);
             IDManager::instance().setID(termIDRef_,term_);
          }
          else if(termNode->Attribute("href")) { termIDRef_ = termNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { term_ = boost::shared_ptr<Period>(new Period(termNode));}
   }

   //paymentFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentFrequencyNode = xmlNode->FirstChildElement("paymentFrequency");

   if(paymentFrequencyNode){paymentFrequencyIsNull_ = false;}
   else{paymentFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentFrequencyNode , address : " << paymentFrequencyNode << std::endl;
   #endif
   if(paymentFrequencyNode)
   {
      if(paymentFrequencyNode->Attribute("href") || paymentFrequencyNode->Attribute("id"))
      {
          if(paymentFrequencyNode->Attribute("id"))
          {
             paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("id");
             paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));
             paymentFrequency_->setID(paymentFrequencyIDRef_);
             IDManager::instance().setID(paymentFrequencyIDRef_,paymentFrequency_);
          }
          else if(paymentFrequencyNode->Attribute("href")) { paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));}
   }

   //dayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountFractionNode = xmlNode->FirstChildElement("dayCountFraction");

   if(dayCountFractionNode){dayCountFractionIsNull_ = false;}
   else{dayCountFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
   #endif
   if(dayCountFractionNode)
   {
      if(dayCountFractionNode->Attribute("href") || dayCountFractionNode->Attribute("id"))
      {
          if(dayCountFractionNode->Attribute("id"))
          {
             dayCountFractionIDRef_ = dayCountFractionNode->Attribute("id");
             dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));
             dayCountFraction_->setID(dayCountFractionIDRef_);
             IDManager::instance().setID(dayCountFractionIDRef_,dayCountFraction_);
          }
          else if(dayCountFractionNode->Attribute("href")) { dayCountFractionIDRef_ = dayCountFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FloatingRateIndex> RateIndex::getFloatingRateIndex()
{
   if(!this->floatingRateIndexIsNull_){
        if(floatingRateIndexIDRef_ != ""){
             return boost::shared_static_cast<FloatingRateIndex>(IDManager::instance().getID(floatingRateIndexIDRef_));
        }else{
             return this->floatingRateIndex_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FloatingRateIndex>();
   }
}
boost::shared_ptr<Period> RateIndex::getTerm()
{
   if(!this->termIsNull_){
        if(termIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(termIDRef_));
        }else{
             return this->term_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<Period> RateIndex::getPaymentFrequency()
{
   if(!this->paymentFrequencyIsNull_){
        if(paymentFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(paymentFrequencyIDRef_));
        }else{
             return this->paymentFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<DayCountFraction> RateIndex::getDayCountFraction()
{
   if(!this->dayCountFractionIsNull_){
        if(dayCountFractionIDRef_ != ""){
             return boost::shared_static_cast<DayCountFraction>(IDManager::instance().getID(dayCountFractionIDRef_));
        }else{
             return this->dayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayCountFraction>();
   }
}
}

