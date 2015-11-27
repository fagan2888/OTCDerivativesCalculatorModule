// ReturnLegValuation.cpp 
#include "ReturnLegValuation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnLegValuation::ReturnLegValuation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialPriceNode = xmlNode->FirstChildElement("initialPrice");

   if(initialPriceNode){initialPriceIsNull_ = false;}
   else{initialPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialPriceNode , address : " << initialPriceNode << std::endl;
   #endif
   if(initialPriceNode)
   {
      if(initialPriceNode->Attribute("href") || initialPriceNode->Attribute("id"))
      {
          if(initialPriceNode->Attribute("id"))
          {
             initialPriceIDRef_ = initialPriceNode->Attribute("id");
             initialPrice_ = boost::shared_ptr<ReturnLegValuationPrice>(new ReturnLegValuationPrice(initialPriceNode));
             initialPrice_->setID(initialPriceIDRef_);
             IDManager::instance().setID(initialPriceIDRef_,initialPrice_);
          }
          else if(initialPriceNode->Attribute("href")) { initialPriceIDRef_ = initialPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialPrice_ = boost::shared_ptr<ReturnLegValuationPrice>(new ReturnLegValuationPrice(initialPriceNode));}
   }

   //notionalResetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalResetNode = xmlNode->FirstChildElement("notionalReset");

   if(notionalResetNode){notionalResetIsNull_ = false;}
   else{notionalResetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalResetNode , address : " << notionalResetNode << std::endl;
   #endif
   if(notionalResetNode)
   {
      if(notionalResetNode->Attribute("href") || notionalResetNode->Attribute("id"))
      {
          if(notionalResetNode->Attribute("id"))
          {
             notionalResetIDRef_ = notionalResetNode->Attribute("id");
             notionalReset_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notionalResetNode));
             notionalReset_->setID(notionalResetIDRef_);
             IDManager::instance().setID(notionalResetIDRef_,notionalReset_);
          }
          else if(notionalResetNode->Attribute("href")) { notionalResetIDRef_ = notionalResetNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalReset_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notionalResetNode));}
   }

   //valuationPriceInterimNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationPriceInterimNode = xmlNode->FirstChildElement("valuationPriceInterim");

   if(valuationPriceInterimNode){valuationPriceInterimIsNull_ = false;}
   else{valuationPriceInterimIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationPriceInterimNode , address : " << valuationPriceInterimNode << std::endl;
   #endif
   if(valuationPriceInterimNode)
   {
      if(valuationPriceInterimNode->Attribute("href") || valuationPriceInterimNode->Attribute("id"))
      {
          if(valuationPriceInterimNode->Attribute("id"))
          {
             valuationPriceInterimIDRef_ = valuationPriceInterimNode->Attribute("id");
             valuationPriceInterim_ = boost::shared_ptr<ReturnLegValuationPrice>(new ReturnLegValuationPrice(valuationPriceInterimNode));
             valuationPriceInterim_->setID(valuationPriceInterimIDRef_);
             IDManager::instance().setID(valuationPriceInterimIDRef_,valuationPriceInterim_);
          }
          else if(valuationPriceInterimNode->Attribute("href")) { valuationPriceInterimIDRef_ = valuationPriceInterimNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationPriceInterim_ = boost::shared_ptr<ReturnLegValuationPrice>(new ReturnLegValuationPrice(valuationPriceInterimNode));}
   }

   //valuationPriceFinalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationPriceFinalNode = xmlNode->FirstChildElement("valuationPriceFinal");

   if(valuationPriceFinalNode){valuationPriceFinalIsNull_ = false;}
   else{valuationPriceFinalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationPriceFinalNode , address : " << valuationPriceFinalNode << std::endl;
   #endif
   if(valuationPriceFinalNode)
   {
      if(valuationPriceFinalNode->Attribute("href") || valuationPriceFinalNode->Attribute("id"))
      {
          if(valuationPriceFinalNode->Attribute("id"))
          {
             valuationPriceFinalIDRef_ = valuationPriceFinalNode->Attribute("id");
             valuationPriceFinal_ = boost::shared_ptr<ReturnLegValuationPrice>(new ReturnLegValuationPrice(valuationPriceFinalNode));
             valuationPriceFinal_->setID(valuationPriceFinalIDRef_);
             IDManager::instance().setID(valuationPriceFinalIDRef_,valuationPriceFinal_);
          }
          else if(valuationPriceFinalNode->Attribute("href")) { valuationPriceFinalIDRef_ = valuationPriceFinalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationPriceFinal_ = boost::shared_ptr<ReturnLegValuationPrice>(new ReturnLegValuationPrice(valuationPriceFinalNode));}
   }

   //paymentDatesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDatesNode = xmlNode->FirstChildElement("paymentDates");

   if(paymentDatesNode){paymentDatesIsNull_ = false;}
   else{paymentDatesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDatesNode , address : " << paymentDatesNode << std::endl;
   #endif
   if(paymentDatesNode)
   {
      if(paymentDatesNode->Attribute("href") || paymentDatesNode->Attribute("id"))
      {
          if(paymentDatesNode->Attribute("id"))
          {
             paymentDatesIDRef_ = paymentDatesNode->Attribute("id");
             paymentDates_ = boost::shared_ptr<ReturnSwapPaymentDates>(new ReturnSwapPaymentDates(paymentDatesNode));
             paymentDates_->setID(paymentDatesIDRef_);
             IDManager::instance().setID(paymentDatesIDRef_,paymentDates_);
          }
          else if(paymentDatesNode->Attribute("href")) { paymentDatesIDRef_ = paymentDatesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDates_ = boost::shared_ptr<ReturnSwapPaymentDates>(new ReturnSwapPaymentDates(paymentDatesNode));}
   }

   //exchangeTradedContractNearestNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exchangeTradedContractNearestNode = xmlNode->FirstChildElement("exchangeTradedContractNearest");

   if(exchangeTradedContractNearestNode){exchangeTradedContractNearestIsNull_ = false;}
   else{exchangeTradedContractNearestIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exchangeTradedContractNearestNode , address : " << exchangeTradedContractNearestNode << std::endl;
   #endif
   if(exchangeTradedContractNearestNode)
   {
      if(exchangeTradedContractNearestNode->Attribute("href") || exchangeTradedContractNearestNode->Attribute("id"))
      {
          if(exchangeTradedContractNearestNode->Attribute("id"))
          {
             exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode->Attribute("id");
             exchangeTradedContractNearest_ = boost::shared_ptr<ExchangeTradedContract>(new ExchangeTradedContract(exchangeTradedContractNearestNode));
             exchangeTradedContractNearest_->setID(exchangeTradedContractNearestIDRef_);
             IDManager::instance().setID(exchangeTradedContractNearestIDRef_,exchangeTradedContractNearest_);
          }
          else if(exchangeTradedContractNearestNode->Attribute("href")) { exchangeTradedContractNearestIDRef_ = exchangeTradedContractNearestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exchangeTradedContractNearest_ = boost::shared_ptr<ExchangeTradedContract>(new ExchangeTradedContract(exchangeTradedContractNearestNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReturnLegValuationPrice> ReturnLegValuation::getInitialPrice()
{
   if(!this->initialPriceIsNull_){
        if(initialPriceIDRef_ != ""){
             return boost::shared_static_cast<ReturnLegValuationPrice>(IDManager::instance().getID(initialPriceIDRef_));
        }else{
             return this->initialPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnLegValuationPrice>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ReturnLegValuation::getNotionalReset()
{
   if(!this->notionalResetIsNull_){
        if(notionalResetIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notionalResetIDRef_));
        }else{
             return this->notionalReset_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<ReturnLegValuationPrice> ReturnLegValuation::getValuationPriceInterim()
{
   if(!this->valuationPriceInterimIsNull_){
        if(valuationPriceInterimIDRef_ != ""){
             return boost::shared_static_cast<ReturnLegValuationPrice>(IDManager::instance().getID(valuationPriceInterimIDRef_));
        }else{
             return this->valuationPriceInterim_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnLegValuationPrice>();
   }
}
boost::shared_ptr<ReturnLegValuationPrice> ReturnLegValuation::getValuationPriceFinal()
{
   if(!this->valuationPriceFinalIsNull_){
        if(valuationPriceFinalIDRef_ != ""){
             return boost::shared_static_cast<ReturnLegValuationPrice>(IDManager::instance().getID(valuationPriceFinalIDRef_));
        }else{
             return this->valuationPriceFinal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnLegValuationPrice>();
   }
}
boost::shared_ptr<ReturnSwapPaymentDates> ReturnLegValuation::getPaymentDates()
{
   if(!this->paymentDatesIsNull_){
        if(paymentDatesIDRef_ != ""){
             return boost::shared_static_cast<ReturnSwapPaymentDates>(IDManager::instance().getID(paymentDatesIDRef_));
        }else{
             return this->paymentDates_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnSwapPaymentDates>();
   }
}
boost::shared_ptr<ExchangeTradedContract> ReturnLegValuation::getExchangeTradedContractNearest()
{
   if(!this->exchangeTradedContractNearestIsNull_){
        if(exchangeTradedContractNearestIDRef_ != ""){
             return boost::shared_static_cast<ExchangeTradedContract>(IDManager::instance().getID(exchangeTradedContractNearestIDRef_));
        }else{
             return this->exchangeTradedContractNearest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExchangeTradedContract>();
   }
}
}

