// Correlation.cpp 
#include "Correlation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Correlation::Correlation(TiXmlNode* xmlNode)
: CalculationFromObservation(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //notionalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notionalAmountNode = xmlNode->FirstChildElement("notionalAmount");

   if(notionalAmountNode){notionalAmountIsNull_ = false;}
   else{notionalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notionalAmountNode , address : " << notionalAmountNode << std::endl;
   #endif
   if(notionalAmountNode)
   {
      if(notionalAmountNode->Attribute("href") || notionalAmountNode->Attribute("id"))
      {
          if(notionalAmountNode->Attribute("id"))
          {
             notionalAmountIDRef_ = notionalAmountNode->Attribute("id");
             notionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(notionalAmountNode));
             notionalAmount_->setID(notionalAmountIDRef_);
             IDManager::instance().setID(notionalAmountIDRef_,notionalAmount_);
          }
          else if(notionalAmountNode->Attribute("href")) { notionalAmountIDRef_ = notionalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notionalAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(notionalAmountNode));}
   }

   //correlationStrikePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationStrikePriceNode = xmlNode->FirstChildElement("correlationStrikePrice");

   if(correlationStrikePriceNode){correlationStrikePriceIsNull_ = false;}
   else{correlationStrikePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationStrikePriceNode , address : " << correlationStrikePriceNode << std::endl;
   #endif
   if(correlationStrikePriceNode)
   {
      if(correlationStrikePriceNode->Attribute("href") || correlationStrikePriceNode->Attribute("id"))
      {
          if(correlationStrikePriceNode->Attribute("id"))
          {
             correlationStrikePriceIDRef_ = correlationStrikePriceNode->Attribute("id");
             correlationStrikePrice_ = boost::shared_ptr<CorrelationValue>(new CorrelationValue(correlationStrikePriceNode));
             correlationStrikePrice_->setID(correlationStrikePriceIDRef_);
             IDManager::instance().setID(correlationStrikePriceIDRef_,correlationStrikePrice_);
          }
          else if(correlationStrikePriceNode->Attribute("href")) { correlationStrikePriceIDRef_ = correlationStrikePriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { correlationStrikePrice_ = boost::shared_ptr<CorrelationValue>(new CorrelationValue(correlationStrikePriceNode));}
   }

   //boundedCorrelationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* boundedCorrelationNode = xmlNode->FirstChildElement("boundedCorrelation");

   if(boundedCorrelationNode){boundedCorrelationIsNull_ = false;}
   else{boundedCorrelationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- boundedCorrelationNode , address : " << boundedCorrelationNode << std::endl;
   #endif
   if(boundedCorrelationNode)
   {
      if(boundedCorrelationNode->Attribute("href") || boundedCorrelationNode->Attribute("id"))
      {
          if(boundedCorrelationNode->Attribute("id"))
          {
             boundedCorrelationIDRef_ = boundedCorrelationNode->Attribute("id");
             boundedCorrelation_ = boost::shared_ptr<BoundedCorrelation>(new BoundedCorrelation(boundedCorrelationNode));
             boundedCorrelation_->setID(boundedCorrelationIDRef_);
             IDManager::instance().setID(boundedCorrelationIDRef_,boundedCorrelation_);
          }
          else if(boundedCorrelationNode->Attribute("href")) { boundedCorrelationIDRef_ = boundedCorrelationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { boundedCorrelation_ = boost::shared_ptr<BoundedCorrelation>(new BoundedCorrelation(boundedCorrelationNode));}
   }

   //numberOfDataSeriesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberOfDataSeriesNode = xmlNode->FirstChildElement("numberOfDataSeries");

   if(numberOfDataSeriesNode){numberOfDataSeriesIsNull_ = false;}
   else{numberOfDataSeriesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberOfDataSeriesNode , address : " << numberOfDataSeriesNode << std::endl;
   #endif
   if(numberOfDataSeriesNode)
   {
      if(numberOfDataSeriesNode->Attribute("href") || numberOfDataSeriesNode->Attribute("id"))
      {
          if(numberOfDataSeriesNode->Attribute("id"))
          {
             numberOfDataSeriesIDRef_ = numberOfDataSeriesNode->Attribute("id");
             numberOfDataSeries_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(numberOfDataSeriesNode));
             numberOfDataSeries_->setID(numberOfDataSeriesIDRef_);
             IDManager::instance().setID(numberOfDataSeriesIDRef_,numberOfDataSeries_);
          }
          else if(numberOfDataSeriesNode->Attribute("href")) { numberOfDataSeriesIDRef_ = numberOfDataSeriesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberOfDataSeries_ = boost::shared_ptr<XsdTypePositiveInteger>(new XsdTypePositiveInteger(numberOfDataSeriesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> Correlation::getNotionalAmount()
{
   if(!this->notionalAmountIsNull_){
        if(notionalAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(notionalAmountIDRef_));
        }else{
             return this->notionalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<CorrelationValue> Correlation::getCorrelationStrikePrice()
{
   if(!this->correlationStrikePriceIsNull_){
        if(correlationStrikePriceIDRef_ != ""){
             return boost::shared_static_cast<CorrelationValue>(IDManager::instance().getID(correlationStrikePriceIDRef_));
        }else{
             return this->correlationStrikePrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CorrelationValue>();
   }
}
boost::shared_ptr<BoundedCorrelation> Correlation::getBoundedCorrelation()
{
   if(!this->boundedCorrelationIsNull_){
        if(boundedCorrelationIDRef_ != ""){
             return boost::shared_static_cast<BoundedCorrelation>(IDManager::instance().getID(boundedCorrelationIDRef_));
        }else{
             return this->boundedCorrelation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BoundedCorrelation>();
   }
}
boost::shared_ptr<XsdTypePositiveInteger> Correlation::getNumberOfDataSeries()
{
   if(!this->numberOfDataSeriesIsNull_){
        if(numberOfDataSeriesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypePositiveInteger>(IDManager::instance().getID(numberOfDataSeriesIDRef_));
        }else{
             return this->numberOfDataSeries_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypePositiveInteger>();
   }
}
}

