// InterestLeg.cpp 
#include "InterestLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InterestLeg::InterestLeg(TiXmlNode* xmlNode)
: DirectionalLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //interestLegCalculationPeriodDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestLegCalculationPeriodDatesNode = xmlNode->FirstChildElement("interestLegCalculationPeriodDates");

   if(interestLegCalculationPeriodDatesNode){interestLegCalculationPeriodDatesIsNull_ = false;}
   else{interestLegCalculationPeriodDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestLegCalculationPeriodDatesNode , address : " << interestLegCalculationPeriodDatesNode << std::endl;
   #endif
   if(interestLegCalculationPeriodDatesNode)
   {
      if(interestLegCalculationPeriodDatesNode->Attribute("href") || interestLegCalculationPeriodDatesNode->Attribute("id"))
      {
          if(interestLegCalculationPeriodDatesNode->Attribute("id"))
          {
             interestLegCalculationPeriodDatesIDRef_ = interestLegCalculationPeriodDatesNode->Attribute("id");
             interestLegCalculationPeriodDates_ = boost::shared_ptr<InterestLegCalculationPeriodDates>(new InterestLegCalculationPeriodDates(interestLegCalculationPeriodDatesNode));
             interestLegCalculationPeriodDates_->setID(interestLegCalculationPeriodDatesIDRef_);
             IDManager::instance().setID(interestLegCalculationPeriodDatesIDRef_,interestLegCalculationPeriodDates_);
          }
          else if(interestLegCalculationPeriodDatesNode->Attribute("href")) { interestLegCalculationPeriodDatesIDRef_ = interestLegCalculationPeriodDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestLegCalculationPeriodDates_ = boost::shared_ptr<InterestLegCalculationPeriodDates>(new InterestLegCalculationPeriodDates(interestLegCalculationPeriodDatesNode));}
   }

   //notionalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalNode = xmlNode->FirstChildElement("notional");

   if(notionalNode){notionalIsNull_ = false;}
   else{notionalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalNode , address : " << notionalNode << std::endl;
   #endif
   if(notionalNode)
   {
      if(notionalNode->Attribute("href") || notionalNode->Attribute("id"))
      {
          if(notionalNode->Attribute("id"))
          {
             notionalIDRef_ = notionalNode->Attribute("id");
             notional_ = boost::shared_ptr<ReturnSwapNotional>(new ReturnSwapNotional(notionalNode));
             notional_->setID(notionalIDRef_);
             IDManager::instance().setID(notionalIDRef_,notional_);
          }
          else if(notionalNode->Attribute("href")) { notionalIDRef_ = notionalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notional_ = boost::shared_ptr<ReturnSwapNotional>(new ReturnSwapNotional(notionalNode));}
   }

   //interestAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestAmountNode = xmlNode->FirstChildElement("interestAmount");

   if(interestAmountNode){interestAmountIsNull_ = false;}
   else{interestAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestAmountNode , address : " << interestAmountNode << std::endl;
   #endif
   if(interestAmountNode)
   {
      if(interestAmountNode->Attribute("href") || interestAmountNode->Attribute("id"))
      {
          if(interestAmountNode->Attribute("id"))
          {
             interestAmountIDRef_ = interestAmountNode->Attribute("id");
             interestAmount_ = boost::shared_ptr<LegAmount>(new LegAmount(interestAmountNode));
             interestAmount_->setID(interestAmountIDRef_);
             IDManager::instance().setID(interestAmountIDRef_,interestAmount_);
          }
          else if(interestAmountNode->Attribute("href")) { interestAmountIDRef_ = interestAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestAmount_ = boost::shared_ptr<LegAmount>(new LegAmount(interestAmountNode));}
   }

   //interestCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestCalculationNode = xmlNode->FirstChildElement("interestCalculation");

   if(interestCalculationNode){interestCalculationIsNull_ = false;}
   else{interestCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestCalculationNode , address : " << interestCalculationNode << std::endl;
   #endif
   if(interestCalculationNode)
   {
      if(interestCalculationNode->Attribute("href") || interestCalculationNode->Attribute("id"))
      {
          if(interestCalculationNode->Attribute("id"))
          {
             interestCalculationIDRef_ = interestCalculationNode->Attribute("id");
             interestCalculation_ = boost::shared_ptr<InterestCalculation>(new InterestCalculation(interestCalculationNode));
             interestCalculation_->setID(interestCalculationIDRef_);
             IDManager::instance().setID(interestCalculationIDRef_,interestCalculation_);
          }
          else if(interestCalculationNode->Attribute("href")) { interestCalculationIDRef_ = interestCalculationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestCalculation_ = boost::shared_ptr<InterestCalculation>(new InterestCalculation(interestCalculationNode));}
   }

   //stubCalculationPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stubCalculationPeriodNode = xmlNode->FirstChildElement("stubCalculationPeriod");

   if(stubCalculationPeriodNode){stubCalculationPeriodIsNull_ = false;}
   else{stubCalculationPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stubCalculationPeriodNode , address : " << stubCalculationPeriodNode << std::endl;
   #endif
   if(stubCalculationPeriodNode)
   {
      if(stubCalculationPeriodNode->Attribute("href") || stubCalculationPeriodNode->Attribute("id"))
      {
          if(stubCalculationPeriodNode->Attribute("id"))
          {
             stubCalculationPeriodIDRef_ = stubCalculationPeriodNode->Attribute("id");
             stubCalculationPeriod_ = boost::shared_ptr<StubCalculationPeriod>(new StubCalculationPeriod(stubCalculationPeriodNode));
             stubCalculationPeriod_->setID(stubCalculationPeriodIDRef_);
             IDManager::instance().setID(stubCalculationPeriodIDRef_,stubCalculationPeriod_);
          }
          else if(stubCalculationPeriodNode->Attribute("href")) { stubCalculationPeriodIDRef_ = stubCalculationPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stubCalculationPeriod_ = boost::shared_ptr<StubCalculationPeriod>(new StubCalculationPeriod(stubCalculationPeriodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InterestLegCalculationPeriodDates> InterestLeg::getInterestLegCalculationPeriodDates()
{
   if(!this->interestLegCalculationPeriodDatesIsNull_){
        if(interestLegCalculationPeriodDatesIDRef_ != ""){
             return boost::shared_static_cast<InterestLegCalculationPeriodDates>(IDManager::instance().getID(interestLegCalculationPeriodDatesIDRef_));
        }else{
             return this->interestLegCalculationPeriodDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestLegCalculationPeriodDates>();
   }
}
boost::shared_ptr<ReturnSwapNotional> InterestLeg::getNotional()
{
   if(!this->notionalIsNull_){
        if(notionalIDRef_ != ""){
             return boost::shared_static_cast<ReturnSwapNotional>(IDManager::instance().getID(notionalIDRef_));
        }else{
             return this->notional_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnSwapNotional>();
   }
}
boost::shared_ptr<LegAmount> InterestLeg::getInterestAmount()
{
   if(!this->interestAmountIsNull_){
        if(interestAmountIDRef_ != ""){
             return boost::shared_static_cast<LegAmount>(IDManager::instance().getID(interestAmountIDRef_));
        }else{
             return this->interestAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegAmount>();
   }
}
boost::shared_ptr<InterestCalculation> InterestLeg::getInterestCalculation()
{
   if(!this->interestCalculationIsNull_){
        if(interestCalculationIDRef_ != ""){
             return boost::shared_static_cast<InterestCalculation>(IDManager::instance().getID(interestCalculationIDRef_));
        }else{
             return this->interestCalculation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestCalculation>();
   }
}
boost::shared_ptr<StubCalculationPeriod> InterestLeg::getStubCalculationPeriod()
{
   if(!this->stubCalculationPeriodIsNull_){
        if(stubCalculationPeriodIDRef_ != ""){
             return boost::shared_static_cast<StubCalculationPeriod>(IDManager::instance().getID(stubCalculationPeriodIDRef_));
        }else{
             return this->stubCalculationPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StubCalculationPeriod>();
   }
}
}

