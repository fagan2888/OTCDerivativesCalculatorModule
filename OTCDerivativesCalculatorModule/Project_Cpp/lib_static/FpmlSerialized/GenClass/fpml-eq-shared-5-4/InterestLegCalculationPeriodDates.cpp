// InterestLegCalculationPeriodDates.cpp 
#include "InterestLegCalculationPeriodDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestLegCalculationPeriodDates::InterestLegCalculationPeriodDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(effectiveDateNode));}
   }

   //terminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* terminationDateNode = xmlNode->FirstChildElement("terminationDate");

   if(terminationDateNode){terminationDateIsNull_ = false;}
   else{terminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- terminationDateNode , address : " << terminationDateNode << std::endl;
   #endif
   if(terminationDateNode)
   {
      if(terminationDateNode->Attribute("href") || terminationDateNode->Attribute("id"))
      {
          if(terminationDateNode->Attribute("id"))
          {
             terminationDateIDRef_ = terminationDateNode->Attribute("id");
             terminationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(terminationDateNode));
             terminationDate_->setID(terminationDateIDRef_);
             IDManager::instance().setID(terminationDateIDRef_,terminationDate_);
          }
          else if(terminationDateNode->Attribute("href")) { terminationDateIDRef_ = terminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { terminationDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(terminationDateNode));}
   }

   //interestLegResetDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestLegResetDatesNode = xmlNode->FirstChildElement("interestLegResetDates");

   if(interestLegResetDatesNode){interestLegResetDatesIsNull_ = false;}
   else{interestLegResetDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestLegResetDatesNode , address : " << interestLegResetDatesNode << std::endl;
   #endif
   if(interestLegResetDatesNode)
   {
      if(interestLegResetDatesNode->Attribute("href") || interestLegResetDatesNode->Attribute("id"))
      {
          if(interestLegResetDatesNode->Attribute("id"))
          {
             interestLegResetDatesIDRef_ = interestLegResetDatesNode->Attribute("id");
             interestLegResetDates_ = boost::shared_ptr<InterestLegResetDates>(new InterestLegResetDates(interestLegResetDatesNode));
             interestLegResetDates_->setID(interestLegResetDatesIDRef_);
             IDManager::instance().setID(interestLegResetDatesIDRef_,interestLegResetDates_);
          }
          else if(interestLegResetDatesNode->Attribute("href")) { interestLegResetDatesIDRef_ = interestLegResetDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestLegResetDates_ = boost::shared_ptr<InterestLegResetDates>(new InterestLegResetDates(interestLegResetDatesNode));}
   }

   //interestLegPaymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestLegPaymentDatesNode = xmlNode->FirstChildElement("interestLegPaymentDates");

   if(interestLegPaymentDatesNode){interestLegPaymentDatesIsNull_ = false;}
   else{interestLegPaymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestLegPaymentDatesNode , address : " << interestLegPaymentDatesNode << std::endl;
   #endif
   if(interestLegPaymentDatesNode)
   {
      if(interestLegPaymentDatesNode->Attribute("href") || interestLegPaymentDatesNode->Attribute("id"))
      {
          if(interestLegPaymentDatesNode->Attribute("id"))
          {
             interestLegPaymentDatesIDRef_ = interestLegPaymentDatesNode->Attribute("id");
             interestLegPaymentDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>(new AdjustableRelativeOrPeriodicDates2(interestLegPaymentDatesNode));
             interestLegPaymentDates_->setID(interestLegPaymentDatesIDRef_);
             IDManager::instance().setID(interestLegPaymentDatesIDRef_,interestLegPaymentDates_);
          }
          else if(interestLegPaymentDatesNode->Attribute("href")) { interestLegPaymentDatesIDRef_ = interestLegPaymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestLegPaymentDates_ = boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>(new AdjustableRelativeOrPeriodicDates2(interestLegPaymentDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableOrRelativeDate> InterestLegCalculationPeriodDates::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> InterestLegCalculationPeriodDates::getTerminationDate()
{
   if(!this->terminationDateIsNull_){
        if(terminationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(terminationDateIDRef_));
        }else{
             return this->terminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<InterestLegResetDates> InterestLegCalculationPeriodDates::getInterestLegResetDates()
{
   if(!this->interestLegResetDatesIsNull_){
        if(interestLegResetDatesIDRef_ != ""){
             return boost::shared_static_cast<InterestLegResetDates>(IDManager::instance().getID(interestLegResetDatesIDRef_));
        }else{
             return this->interestLegResetDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestLegResetDates>();
   }
}
boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> InterestLegCalculationPeriodDates::getInterestLegPaymentDates()
{
   if(!this->interestLegPaymentDatesIsNull_){
        if(interestLegPaymentDatesIDRef_ != ""){
             return boost::shared_static_cast<AdjustableRelativeOrPeriodicDates2>(IDManager::instance().getID(interestLegPaymentDatesIDRef_));
        }else{
             return this->interestLegPaymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableRelativeOrPeriodicDates2>();
   }
}
}

