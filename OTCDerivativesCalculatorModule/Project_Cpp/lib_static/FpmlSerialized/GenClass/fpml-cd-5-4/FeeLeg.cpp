// FeeLeg.cpp 
#include "FeeLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FeeLeg::FeeLeg(TiXmlNode* xmlNode)
: Leg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //initialPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialPaymentNode = xmlNode->FirstChildElement("initialPayment");

   if(initialPaymentNode){initialPaymentIsNull_ = false;}
   else{initialPaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialPaymentNode , address : " << initialPaymentNode << std::endl;
   #endif
   if(initialPaymentNode)
   {
      if(initialPaymentNode->Attribute("href") || initialPaymentNode->Attribute("id"))
      {
          if(initialPaymentNode->Attribute("id"))
          {
             initialPaymentIDRef_ = initialPaymentNode->Attribute("id");
             initialPayment_ = boost::shared_ptr<InitialPayment>(new InitialPayment(initialPaymentNode));
             initialPayment_->setID(initialPaymentIDRef_);
             IDManager::instance().setID(initialPaymentIDRef_,initialPayment_);
          }
          else if(initialPaymentNode->Attribute("href")) { initialPaymentIDRef_ = initialPaymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialPayment_ = boost::shared_ptr<InitialPayment>(new InitialPayment(initialPaymentNode));}
   }

   //singlePaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* singlePaymentNode = xmlNode->FirstChildElement("singlePayment");

   if(singlePaymentNode){singlePaymentIsNull_ = false;}
   else{singlePaymentIsNull_ = true;}

   if(singlePaymentNode)
   {
      for(singlePaymentNode; singlePaymentNode; singlePaymentNode = singlePaymentNode->NextSiblingElement("singlePayment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- singlePaymentNode , address : " << singlePaymentNode << std::endl;
          #endif
          if(singlePaymentNode->Attribute("href") || singlePaymentNode->Attribute("id"))
          {
              if(singlePaymentNode->Attribute("id"))
              {
                  singlePaymentIDRef_ = singlePaymentNode->Attribute("id");
                  singlePayment_.push_back(boost::shared_ptr<SinglePayment>(new SinglePayment(singlePaymentNode)));
                  singlePayment_.back()->setID(singlePaymentIDRef_);
                  IDManager::instance().setID(singlePaymentIDRef_, singlePayment_.back());
              }
              else if(singlePaymentNode->Attribute("href")) { singlePaymentIDRef_ = singlePaymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { singlePayment_.push_back(boost::shared_ptr<SinglePayment>(new SinglePayment(singlePaymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- singlePaymentNode , address : " << singlePaymentNode << std::endl;
       #endif
   }

   //periodicPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* periodicPaymentNode = xmlNode->FirstChildElement("periodicPayment");

   if(periodicPaymentNode){periodicPaymentIsNull_ = false;}
   else{periodicPaymentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- periodicPaymentNode , address : " << periodicPaymentNode << std::endl;
   #endif
   if(periodicPaymentNode)
   {
      if(periodicPaymentNode->Attribute("href") || periodicPaymentNode->Attribute("id"))
      {
          if(periodicPaymentNode->Attribute("id"))
          {
             periodicPaymentIDRef_ = periodicPaymentNode->Attribute("id");
             periodicPayment_ = boost::shared_ptr<PeriodicPayment>(new PeriodicPayment(periodicPaymentNode));
             periodicPayment_->setID(periodicPaymentIDRef_);
             IDManager::instance().setID(periodicPaymentIDRef_,periodicPayment_);
          }
          else if(periodicPaymentNode->Attribute("href")) { periodicPaymentIDRef_ = periodicPaymentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { periodicPayment_ = boost::shared_ptr<PeriodicPayment>(new PeriodicPayment(periodicPaymentNode));}
   }

   //marketFixedRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketFixedRateNode = xmlNode->FirstChildElement("marketFixedRate");

   if(marketFixedRateNode){marketFixedRateIsNull_ = false;}
   else{marketFixedRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketFixedRateNode , address : " << marketFixedRateNode << std::endl;
   #endif
   if(marketFixedRateNode)
   {
      if(marketFixedRateNode->Attribute("href") || marketFixedRateNode->Attribute("id"))
      {
          if(marketFixedRateNode->Attribute("id"))
          {
             marketFixedRateIDRef_ = marketFixedRateNode->Attribute("id");
             marketFixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(marketFixedRateNode));
             marketFixedRate_->setID(marketFixedRateIDRef_);
             IDManager::instance().setID(marketFixedRateIDRef_,marketFixedRate_);
          }
          else if(marketFixedRateNode->Attribute("href")) { marketFixedRateIDRef_ = marketFixedRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { marketFixedRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(marketFixedRateNode));}
   }

   //paymentDelayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDelayNode = xmlNode->FirstChildElement("paymentDelay");

   if(paymentDelayNode){paymentDelayIsNull_ = false;}
   else{paymentDelayIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDelayNode , address : " << paymentDelayNode << std::endl;
   #endif
   if(paymentDelayNode)
   {
      if(paymentDelayNode->Attribute("href") || paymentDelayNode->Attribute("id"))
      {
          if(paymentDelayNode->Attribute("id"))
          {
             paymentDelayIDRef_ = paymentDelayNode->Attribute("id");
             paymentDelay_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(paymentDelayNode));
             paymentDelay_->setID(paymentDelayIDRef_);
             IDManager::instance().setID(paymentDelayIDRef_,paymentDelay_);
          }
          else if(paymentDelayNode->Attribute("href")) { paymentDelayIDRef_ = paymentDelayNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDelay_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(paymentDelayNode));}
   }

   //initialPointsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialPointsNode = xmlNode->FirstChildElement("initialPoints");

   if(initialPointsNode){initialPointsIsNull_ = false;}
   else{initialPointsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialPointsNode , address : " << initialPointsNode << std::endl;
   #endif
   if(initialPointsNode)
   {
      if(initialPointsNode->Attribute("href") || initialPointsNode->Attribute("id"))
      {
          if(initialPointsNode->Attribute("id"))
          {
             initialPointsIDRef_ = initialPointsNode->Attribute("id");
             initialPoints_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialPointsNode));
             initialPoints_->setID(initialPointsIDRef_);
             IDManager::instance().setID(initialPointsIDRef_,initialPoints_);
          }
          else if(initialPointsNode->Attribute("href")) { initialPointsIDRef_ = initialPointsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialPoints_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(initialPointsNode));}
   }

   //quotationStyleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotationStyleNode = xmlNode->FirstChildElement("quotationStyle");

   if(quotationStyleNode){quotationStyleIsNull_ = false;}
   else{quotationStyleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationStyleNode , address : " << quotationStyleNode << std::endl;
   #endif
   if(quotationStyleNode)
   {
      if(quotationStyleNode->Attribute("href") || quotationStyleNode->Attribute("id"))
      {
          if(quotationStyleNode->Attribute("id"))
          {
             quotationStyleIDRef_ = quotationStyleNode->Attribute("id");
             quotationStyle_ = boost::shared_ptr<QuotationStyleEnum>(new QuotationStyleEnum(quotationStyleNode));
             quotationStyle_->setID(quotationStyleIDRef_);
             IDManager::instance().setID(quotationStyleIDRef_,quotationStyle_);
          }
          else if(quotationStyleNode->Attribute("href")) { quotationStyleIDRef_ = quotationStyleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotationStyle_ = boost::shared_ptr<QuotationStyleEnum>(new QuotationStyleEnum(quotationStyleNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InitialPayment> FeeLeg::getInitialPayment()
{
   if(!this->initialPaymentIsNull_){
        if(initialPaymentIDRef_ != ""){
             return boost::shared_static_cast<InitialPayment>(IDManager::instance().getID(initialPaymentIDRef_));
        }else{
             return this->initialPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InitialPayment>();
   }
}
std::vector<boost::shared_ptr<SinglePayment>> FeeLeg::getSinglePayment()
{
   if(!this->singlePaymentIsNull_){
        if(singlePaymentIDRef_ != ""){
             return this->singlePayment_;
        }else{
             return this->singlePayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SinglePayment>>();
   }
}
boost::shared_ptr<PeriodicPayment> FeeLeg::getPeriodicPayment()
{
   if(!this->periodicPaymentIsNull_){
        if(periodicPaymentIDRef_ != ""){
             return boost::shared_static_cast<PeriodicPayment>(IDManager::instance().getID(periodicPaymentIDRef_));
        }else{
             return this->periodicPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PeriodicPayment>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FeeLeg::getMarketFixedRate()
{
   if(!this->marketFixedRateIsNull_){
        if(marketFixedRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(marketFixedRateIDRef_));
        }else{
             return this->marketFixedRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> FeeLeg::getPaymentDelay()
{
   if(!this->paymentDelayIsNull_){
        if(paymentDelayIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(paymentDelayIDRef_));
        }else{
             return this->paymentDelay_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeDecimal> FeeLeg::getInitialPoints()
{
   if(!this->initialPointsIsNull_){
        if(initialPointsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(initialPointsIDRef_));
        }else{
             return this->initialPoints_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<QuotationStyleEnum> FeeLeg::getQuotationStyle()
{
   if(!this->quotationStyleIsNull_){
        if(quotationStyleIDRef_ != ""){
             return boost::shared_static_cast<QuotationStyleEnum>(IDManager::instance().getID(quotationStyleIDRef_));
        }else{
             return this->quotationStyle_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationStyleEnum>();
   }
}
}

