// Excel_cashFlowResult.cpp 
#include "Excel_cashFlowResult.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_cashFlowResult::Excel_cashFlowResult(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //seqNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* seqNode = xmlNode->FirstChildElement("seq");

   if(seqNode){seqIsNull_ = false;}
   else{seqIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- seqNode , address : " << seqNode << std::endl;
   #endif
   if(seqNode)
   {
       seq_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(seqNode));
   }

   //eventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateNode = xmlNode->FirstChildElement("eventDate");

   if(eventDateNode){eventDateIsNull_ = false;}
   else{eventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateNode , address : " << eventDateNode << std::endl;
   #endif
   if(eventDateNode)
   {
       eventDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(eventDateNode));
   }

   //payoffDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payoffDateNode = xmlNode->FirstChildElement("payoffDate");

   if(payoffDateNode){payoffDateIsNull_ = false;}
   else{payoffDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payoffDateNode , address : " << payoffDateNode << std::endl;
   #endif
   if(payoffDateNode)
   {
       payoffDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payoffDateNode));
   }

   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
       currency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currencyNode));
   }

   //cashFlowNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashFlowNode = xmlNode->FirstChildElement("cashFlow");

   if(cashFlowNode){cashFlowIsNull_ = false;}
   else{cashFlowIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashFlowNode , address : " << cashFlowNode << std::endl;
   #endif
   if(cashFlowNode)
   {
       cashFlow_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(cashFlowNode));
   }

   //yieldNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* yieldNode = xmlNode->FirstChildElement("yield");

   if(yieldNode){yieldIsNull_ = false;}
   else{yieldIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- yieldNode , address : " << yieldNode << std::endl;
   #endif
   if(yieldNode)
   {
       yield_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(yieldNode));
   }

   //discountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discountNode = xmlNode->FirstChildElement("discount");

   if(discountNode){discountIsNull_ = false;}
   else{discountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discountNode , address : " << discountNode << std::endl;
   #endif
   if(discountNode)
   {
       discount_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(discountNode));
   }

   //exProbNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exProbNode = xmlNode->FirstChildElement("exProb");

   if(exProbNode){exProbIsNull_ = false;}
   else{exProbIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exProbNode , address : " << exProbNode << std::endl;
   #endif
   if(exProbNode)
   {
       exProb_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(exProbNode));
   }

   //notionalPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalPaymentNode = xmlNode->FirstChildElement("notionalPayment");

   if(notionalPaymentNode){notionalPaymentIsNull_ = false;}
   else{notionalPaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalPaymentNode , address : " << notionalPaymentNode << std::endl;
   #endif
   if(notionalPaymentNode)
   {
       notionalPayment_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notionalPaymentNode));
   }

   //fxRate_forwardNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxRate_forwardNode = xmlNode->FirstChildElement("fxRate_forward");

   if(fxRate_forwardNode){fxRate_forwardIsNull_ = false;}
   else{fxRate_forwardIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxRate_forwardNode , address : " << fxRate_forwardNode << std::endl;
   #endif
   if(fxRate_forwardNode)
   {
       fxRate_forward_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(fxRate_forwardNode));
   }

   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
       value_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(valueNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getSeq()
{
   if(!this->seqIsNull_){
        return this->seq_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getPayoffDate()
{
   if(!this->payoffDateIsNull_){
        return this->payoffDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getCashFlow()
{
   if(!this->cashFlowIsNull_){
        return this->cashFlow_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getYield()
{
   if(!this->yieldIsNull_){
        return this->yield_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getDiscount()
{
   if(!this->discountIsNull_){
        return this->discount_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getExProb()
{
   if(!this->exProbIsNull_){
        return this->exProb_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getNotionalPayment()
{
   if(!this->notionalPaymentIsNull_){
        return this->notionalPayment_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getFxRate_forward()
{
   if(!this->fxRate_forwardIsNull_){
        return this->fxRate_forward_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_cashFlowResult::getValue()
{
   if(!this->valueIsNull_){
        return this->value_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

