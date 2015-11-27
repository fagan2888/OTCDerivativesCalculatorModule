// NotionalStepRule.cpp 
#include "NotionalStepRule.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NotionalStepRule::NotionalStepRule(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationPeriodDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChildElement("calculationPeriodDatesReference");

   if(calculationPeriodDatesReferenceNode){calculationPeriodDatesReferenceIsNull_ = false;}
   else{calculationPeriodDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesReferenceNode , address : " << calculationPeriodDatesReferenceNode << std::endl;
   #endif
   if(calculationPeriodDatesReferenceNode)
   {
      if(calculationPeriodDatesReferenceNode->Attribute("href") || calculationPeriodDatesReferenceNode->Attribute("id"))
      {
          if(calculationPeriodDatesReferenceNode->Attribute("id"))
          {
             calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("id");
             calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));
             calculationPeriodDatesReference_->setID(calculationPeriodDatesReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodDatesReferenceIDRef_,calculationPeriodDatesReference_);
          }
          else if(calculationPeriodDatesReferenceNode->Attribute("href")) { calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));}
   }

   //stepFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepFrequencyNode = xmlNode->FirstChildElement("stepFrequency");

   if(stepFrequencyNode){stepFrequencyIsNull_ = false;}
   else{stepFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepFrequencyNode , address : " << stepFrequencyNode << std::endl;
   #endif
   if(stepFrequencyNode)
   {
      if(stepFrequencyNode->Attribute("href") || stepFrequencyNode->Attribute("id"))
      {
          if(stepFrequencyNode->Attribute("id"))
          {
             stepFrequencyIDRef_ = stepFrequencyNode->Attribute("id");
             stepFrequency_ = boost::shared_ptr<Period>(new Period(stepFrequencyNode));
             stepFrequency_->setID(stepFrequencyIDRef_);
             IDManager::instance().setID(stepFrequencyIDRef_,stepFrequency_);
          }
          else if(stepFrequencyNode->Attribute("href")) { stepFrequencyIDRef_ = stepFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stepFrequency_ = boost::shared_ptr<Period>(new Period(stepFrequencyNode));}
   }

   //firstNotionalStepDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* firstNotionalStepDateNode = xmlNode->FirstChildElement("firstNotionalStepDate");

   if(firstNotionalStepDateNode){firstNotionalStepDateIsNull_ = false;}
   else{firstNotionalStepDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- firstNotionalStepDateNode , address : " << firstNotionalStepDateNode << std::endl;
   #endif
   if(firstNotionalStepDateNode)
   {
      if(firstNotionalStepDateNode->Attribute("href") || firstNotionalStepDateNode->Attribute("id"))
      {
          if(firstNotionalStepDateNode->Attribute("id"))
          {
             firstNotionalStepDateIDRef_ = firstNotionalStepDateNode->Attribute("id");
             firstNotionalStepDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstNotionalStepDateNode));
             firstNotionalStepDate_->setID(firstNotionalStepDateIDRef_);
             IDManager::instance().setID(firstNotionalStepDateIDRef_,firstNotionalStepDate_);
          }
          else if(firstNotionalStepDateNode->Attribute("href")) { firstNotionalStepDateIDRef_ = firstNotionalStepDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { firstNotionalStepDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(firstNotionalStepDateNode));}
   }

   //lastNotionalStepDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lastNotionalStepDateNode = xmlNode->FirstChildElement("lastNotionalStepDate");

   if(lastNotionalStepDateNode){lastNotionalStepDateIsNull_ = false;}
   else{lastNotionalStepDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lastNotionalStepDateNode , address : " << lastNotionalStepDateNode << std::endl;
   #endif
   if(lastNotionalStepDateNode)
   {
      if(lastNotionalStepDateNode->Attribute("href") || lastNotionalStepDateNode->Attribute("id"))
      {
          if(lastNotionalStepDateNode->Attribute("id"))
          {
             lastNotionalStepDateIDRef_ = lastNotionalStepDateNode->Attribute("id");
             lastNotionalStepDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastNotionalStepDateNode));
             lastNotionalStepDate_->setID(lastNotionalStepDateIDRef_);
             IDManager::instance().setID(lastNotionalStepDateIDRef_,lastNotionalStepDate_);
          }
          else if(lastNotionalStepDateNode->Attribute("href")) { lastNotionalStepDateIDRef_ = lastNotionalStepDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lastNotionalStepDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(lastNotionalStepDateNode));}
   }

   //notionalStepAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalStepAmountNode = xmlNode->FirstChildElement("notionalStepAmount");

   if(notionalStepAmountNode){notionalStepAmountIsNull_ = false;}
   else{notionalStepAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalStepAmountNode , address : " << notionalStepAmountNode << std::endl;
   #endif
   if(notionalStepAmountNode)
   {
      if(notionalStepAmountNode->Attribute("href") || notionalStepAmountNode->Attribute("id"))
      {
          if(notionalStepAmountNode->Attribute("id"))
          {
             notionalStepAmountIDRef_ = notionalStepAmountNode->Attribute("id");
             notionalStepAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalStepAmountNode));
             notionalStepAmount_->setID(notionalStepAmountIDRef_);
             IDManager::instance().setID(notionalStepAmountIDRef_,notionalStepAmount_);
          }
          else if(notionalStepAmountNode->Attribute("href")) { notionalStepAmountIDRef_ = notionalStepAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalStepAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalStepAmountNode));}
   }

   //notionalStepRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalStepRateNode = xmlNode->FirstChildElement("notionalStepRate");

   if(notionalStepRateNode){notionalStepRateIsNull_ = false;}
   else{notionalStepRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalStepRateNode , address : " << notionalStepRateNode << std::endl;
   #endif
   if(notionalStepRateNode)
   {
      if(notionalStepRateNode->Attribute("href") || notionalStepRateNode->Attribute("id"))
      {
          if(notionalStepRateNode->Attribute("id"))
          {
             notionalStepRateIDRef_ = notionalStepRateNode->Attribute("id");
             notionalStepRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalStepRateNode));
             notionalStepRate_->setID(notionalStepRateIDRef_);
             IDManager::instance().setID(notionalStepRateIDRef_,notionalStepRate_);
          }
          else if(notionalStepRateNode->Attribute("href")) { notionalStepRateIDRef_ = notionalStepRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalStepRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(notionalStepRateNode));}
   }

   //stepRelativeToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stepRelativeToNode = xmlNode->FirstChildElement("stepRelativeTo");

   if(stepRelativeToNode){stepRelativeToIsNull_ = false;}
   else{stepRelativeToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stepRelativeToNode , address : " << stepRelativeToNode << std::endl;
   #endif
   if(stepRelativeToNode)
   {
      if(stepRelativeToNode->Attribute("href") || stepRelativeToNode->Attribute("id"))
      {
          if(stepRelativeToNode->Attribute("id"))
          {
             stepRelativeToIDRef_ = stepRelativeToNode->Attribute("id");
             stepRelativeTo_ = boost::shared_ptr<StepRelativeToEnum>(new StepRelativeToEnum(stepRelativeToNode));
             stepRelativeTo_->setID(stepRelativeToIDRef_);
             IDManager::instance().setID(stepRelativeToIDRef_,stepRelativeTo_);
          }
          else if(stepRelativeToNode->Attribute("href")) { stepRelativeToIDRef_ = stepRelativeToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { stepRelativeTo_ = boost::shared_ptr<StepRelativeToEnum>(new StepRelativeToEnum(stepRelativeToNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CalculationPeriodDatesReference> NotionalStepRule::getCalculationPeriodDatesReference()
{
   if(!this->calculationPeriodDatesReferenceIsNull_){
        if(calculationPeriodDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodDatesReference>(IDManager::instance().getID(calculationPeriodDatesReferenceIDRef_));
        }else{
             return this->calculationPeriodDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodDatesReference>();
   }
}
boost::shared_ptr<Period> NotionalStepRule::getStepFrequency()
{
   if(!this->stepFrequencyIsNull_){
        if(stepFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(stepFrequencyIDRef_));
        }else{
             return this->stepFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<XsdTypeDate> NotionalStepRule::getFirstNotionalStepDate()
{
   if(!this->firstNotionalStepDateIsNull_){
        if(firstNotionalStepDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(firstNotionalStepDateIDRef_));
        }else{
             return this->firstNotionalStepDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> NotionalStepRule::getLastNotionalStepDate()
{
   if(!this->lastNotionalStepDateIsNull_){
        if(lastNotionalStepDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(lastNotionalStepDateIDRef_));
        }else{
             return this->lastNotionalStepDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> NotionalStepRule::getNotionalStepAmount()
{
   if(!this->notionalStepAmountIsNull_){
        if(notionalStepAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(notionalStepAmountIDRef_));
        }else{
             return this->notionalStepAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> NotionalStepRule::getNotionalStepRate()
{
   if(!this->notionalStepRateIsNull_){
        if(notionalStepRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(notionalStepRateIDRef_));
        }else{
             return this->notionalStepRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<StepRelativeToEnum> NotionalStepRule::getStepRelativeTo()
{
   if(!this->stepRelativeToIsNull_){
        if(stepRelativeToIDRef_ != ""){
             return boost::shared_static_cast<StepRelativeToEnum>(IDManager::instance().getID(stepRelativeToIDRef_));
        }else{
             return this->stepRelativeTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StepRelativeToEnum>();
   }
}
}

