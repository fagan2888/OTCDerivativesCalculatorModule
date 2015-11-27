// ReturnLeg.cpp 
#include "ReturnLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnLeg::ReturnLeg(TiXmlNode* xmlNode)
: ReturnSwapLegUnderlyer(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rateOfReturnNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateOfReturnNode = xmlNode->FirstChildElement("rateOfReturn");

   if(rateOfReturnNode){rateOfReturnIsNull_ = false;}
   else{rateOfReturnIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateOfReturnNode , address : " << rateOfReturnNode << std::endl;
   #endif
   if(rateOfReturnNode)
   {
      if(rateOfReturnNode->Attribute("href") || rateOfReturnNode->Attribute("id"))
      {
          if(rateOfReturnNode->Attribute("id"))
          {
             rateOfReturnIDRef_ = rateOfReturnNode->Attribute("id");
             rateOfReturn_ = boost::shared_ptr<ReturnLegValuation>(new ReturnLegValuation(rateOfReturnNode));
             rateOfReturn_->setID(rateOfReturnIDRef_);
             IDManager::instance().setID(rateOfReturnIDRef_,rateOfReturn_);
          }
          else if(rateOfReturnNode->Attribute("href")) { rateOfReturnIDRef_ = rateOfReturnNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rateOfReturn_ = boost::shared_ptr<ReturnLegValuation>(new ReturnLegValuation(rateOfReturnNode));}
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

   //amountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountNode = xmlNode->FirstChildElement("amount");

   if(amountNode){amountIsNull_ = false;}
   else{amountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountNode , address : " << amountNode << std::endl;
   #endif
   if(amountNode)
   {
      if(amountNode->Attribute("href") || amountNode->Attribute("id"))
      {
          if(amountNode->Attribute("id"))
          {
             amountIDRef_ = amountNode->Attribute("id");
             amount_ = boost::shared_ptr<ReturnSwapAmount>(new ReturnSwapAmount(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<ReturnSwapAmount>(new ReturnSwapAmount(amountNode));}
   }

   //returnNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnNode = xmlNode->FirstChildElement("return");

   if(returnNode){returnIsNull_ = false;}
   else{returnIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnNode , address : " << returnNode << std::endl;
   #endif
   if(returnNode)
   {
      if(returnNode->Attribute("href") || returnNode->Attribute("id"))
      {
          if(returnNode->Attribute("id"))
          {
             returnIDRef_ = returnNode->Attribute("id");
             return_ = boost::shared_ptr<Return>(new Return(returnNode));
             return_->setID(returnIDRef_);
             IDManager::instance().setID(returnIDRef_,return_);
          }
          else if(returnNode->Attribute("href")) { returnIDRef_ = returnNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { return_ = boost::shared_ptr<Return>(new Return(returnNode));}
   }

   //notionalAdjustmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAdjustmentsNode = xmlNode->FirstChildElement("notionalAdjustments");

   if(notionalAdjustmentsNode){notionalAdjustmentsIsNull_ = false;}
   else{notionalAdjustmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAdjustmentsNode , address : " << notionalAdjustmentsNode << std::endl;
   #endif
   if(notionalAdjustmentsNode)
   {
      if(notionalAdjustmentsNode->Attribute("href") || notionalAdjustmentsNode->Attribute("id"))
      {
          if(notionalAdjustmentsNode->Attribute("id"))
          {
             notionalAdjustmentsIDRef_ = notionalAdjustmentsNode->Attribute("id");
             notionalAdjustments_ = boost::shared_ptr<NotionalAdjustmentEnum>(new NotionalAdjustmentEnum(notionalAdjustmentsNode));
             notionalAdjustments_->setID(notionalAdjustmentsIDRef_);
             IDManager::instance().setID(notionalAdjustmentsIDRef_,notionalAdjustments_);
          }
          else if(notionalAdjustmentsNode->Attribute("href")) { notionalAdjustmentsIDRef_ = notionalAdjustmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAdjustments_ = boost::shared_ptr<NotionalAdjustmentEnum>(new NotionalAdjustmentEnum(notionalAdjustmentsNode));}
   }

   //fxFeatureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxFeatureNode = xmlNode->FirstChildElement("fxFeature");

   if(fxFeatureNode){fxFeatureIsNull_ = false;}
   else{fxFeatureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxFeatureNode , address : " << fxFeatureNode << std::endl;
   #endif
   if(fxFeatureNode)
   {
      if(fxFeatureNode->Attribute("href") || fxFeatureNode->Attribute("id"))
      {
          if(fxFeatureNode->Attribute("id"))
          {
             fxFeatureIDRef_ = fxFeatureNode->Attribute("id");
             fxFeature_ = boost::shared_ptr<FxFeature>(new FxFeature(fxFeatureNode));
             fxFeature_->setID(fxFeatureIDRef_);
             IDManager::instance().setID(fxFeatureIDRef_,fxFeature_);
          }
          else if(fxFeatureNode->Attribute("href")) { fxFeatureIDRef_ = fxFeatureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxFeature_ = boost::shared_ptr<FxFeature>(new FxFeature(fxFeatureNode));}
   }

   //averagingDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* averagingDatesNode = xmlNode->FirstChildElement("averagingDates");

   if(averagingDatesNode){averagingDatesIsNull_ = false;}
   else{averagingDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- averagingDatesNode , address : " << averagingDatesNode << std::endl;
   #endif
   if(averagingDatesNode)
   {
      if(averagingDatesNode->Attribute("href") || averagingDatesNode->Attribute("id"))
      {
          if(averagingDatesNode->Attribute("id"))
          {
             averagingDatesIDRef_ = averagingDatesNode->Attribute("id");
             averagingDates_ = boost::shared_ptr<AveragingPeriod>(new AveragingPeriod(averagingDatesNode));
             averagingDates_->setID(averagingDatesIDRef_);
             IDManager::instance().setID(averagingDatesIDRef_,averagingDates_);
          }
          else if(averagingDatesNode->Attribute("href")) { averagingDatesIDRef_ = averagingDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { averagingDates_ = boost::shared_ptr<AveragingPeriod>(new AveragingPeriod(averagingDatesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReturnLegValuation> ReturnLeg::getRateOfReturn()
{
   if(!this->rateOfReturnIsNull_){
        if(rateOfReturnIDRef_ != ""){
             return boost::shared_static_cast<ReturnLegValuation>(IDManager::instance().getID(rateOfReturnIDRef_));
        }else{
             return this->rateOfReturn_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnLegValuation>();
   }
}
boost::shared_ptr<ReturnSwapNotional> ReturnLeg::getNotional()
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
boost::shared_ptr<ReturnSwapAmount> ReturnLeg::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<ReturnSwapAmount>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnSwapAmount>();
   }
}
boost::shared_ptr<Return> ReturnLeg::getReturn()
{
   if(!this->returnIsNull_){
        if(returnIDRef_ != ""){
             return boost::shared_static_cast<Return>(IDManager::instance().getID(returnIDRef_));
        }else{
             return this->return_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Return>();
   }
}
boost::shared_ptr<NotionalAdjustmentEnum> ReturnLeg::getNotionalAdjustments()
{
   if(!this->notionalAdjustmentsIsNull_){
        if(notionalAdjustmentsIDRef_ != ""){
             return boost::shared_static_cast<NotionalAdjustmentEnum>(IDManager::instance().getID(notionalAdjustmentsIDRef_));
        }else{
             return this->notionalAdjustments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotionalAdjustmentEnum>();
   }
}
boost::shared_ptr<FxFeature> ReturnLeg::getFxFeature()
{
   if(!this->fxFeatureIsNull_){
        if(fxFeatureIDRef_ != ""){
             return boost::shared_static_cast<FxFeature>(IDManager::instance().getID(fxFeatureIDRef_));
        }else{
             return this->fxFeature_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxFeature>();
   }
}
boost::shared_ptr<AveragingPeriod> ReturnLeg::getAveragingDates()
{
   if(!this->averagingDatesIsNull_){
        if(averagingDatesIDRef_ != ""){
             return boost::shared_static_cast<AveragingPeriod>(IDManager::instance().getID(averagingDatesIDRef_));
        }else{
             return this->averagingDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AveragingPeriod>();
   }
}
}

