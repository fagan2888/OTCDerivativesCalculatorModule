// DividendPayout.cpp 
#include "DividendPayout.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DividendPayout::DividendPayout(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dividendPayoutRatioNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPayoutRatioNode = xmlNode->FirstChildElement("dividendPayoutRatio");

   if(dividendPayoutRatioNode){dividendPayoutRatioIsNull_ = false;}
   else{dividendPayoutRatioIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPayoutRatioNode , address : " << dividendPayoutRatioNode << std::endl;
   #endif
   if(dividendPayoutRatioNode)
   {
      if(dividendPayoutRatioNode->Attribute("href") || dividendPayoutRatioNode->Attribute("id"))
      {
          if(dividendPayoutRatioNode->Attribute("id"))
          {
             dividendPayoutRatioIDRef_ = dividendPayoutRatioNode->Attribute("id");
             dividendPayoutRatio_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(dividendPayoutRatioNode));
             dividendPayoutRatio_->setID(dividendPayoutRatioIDRef_);
             IDManager::instance().setID(dividendPayoutRatioIDRef_,dividendPayoutRatio_);
          }
          else if(dividendPayoutRatioNode->Attribute("href")) { dividendPayoutRatioIDRef_ = dividendPayoutRatioNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendPayoutRatio_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(dividendPayoutRatioNode));}
   }

   //dividendPayoutConditionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPayoutConditionsNode = xmlNode->FirstChildElement("dividendPayoutConditions");

   if(dividendPayoutConditionsNode){dividendPayoutConditionsIsNull_ = false;}
   else{dividendPayoutConditionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPayoutConditionsNode , address : " << dividendPayoutConditionsNode << std::endl;
   #endif
   if(dividendPayoutConditionsNode)
   {
      if(dividendPayoutConditionsNode->Attribute("href") || dividendPayoutConditionsNode->Attribute("id"))
      {
          if(dividendPayoutConditionsNode->Attribute("id"))
          {
             dividendPayoutConditionsIDRef_ = dividendPayoutConditionsNode->Attribute("id");
             dividendPayoutConditions_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(dividendPayoutConditionsNode));
             dividendPayoutConditions_->setID(dividendPayoutConditionsIDRef_);
             IDManager::instance().setID(dividendPayoutConditionsIDRef_,dividendPayoutConditions_);
          }
          else if(dividendPayoutConditionsNode->Attribute("href")) { dividendPayoutConditionsIDRef_ = dividendPayoutConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendPayoutConditions_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(dividendPayoutConditionsNode));}
   }

   //dividendPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendPaymentNode = xmlNode->FirstChildElement("dividendPayment");

   if(dividendPaymentNode){dividendPaymentIsNull_ = false;}
   else{dividendPaymentIsNull_ = true;}

   if(dividendPaymentNode)
   {
      for(dividendPaymentNode; dividendPaymentNode; dividendPaymentNode = dividendPaymentNode->NextSiblingElement("dividendPayment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPaymentNode , address : " << dividendPaymentNode << std::endl;
          #endif
          if(dividendPaymentNode->Attribute("href") || dividendPaymentNode->Attribute("id"))
          {
              if(dividendPaymentNode->Attribute("id"))
              {
                  dividendPaymentIDRef_ = dividendPaymentNode->Attribute("id");
                  dividendPayment_.push_back(boost::shared_ptr<PendingPayment>(new PendingPayment(dividendPaymentNode)));
                  dividendPayment_.back()->setID(dividendPaymentIDRef_);
                  IDManager::instance().setID(dividendPaymentIDRef_, dividendPayment_.back());
              }
              else if(dividendPaymentNode->Attribute("href")) { dividendPaymentIDRef_ = dividendPaymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { dividendPayment_.push_back(boost::shared_ptr<PendingPayment>(new PendingPayment(dividendPaymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendPaymentNode , address : " << dividendPaymentNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> DividendPayout::getDividendPayoutRatio()
{
   if(!this->dividendPayoutRatioIsNull_){
        if(dividendPayoutRatioIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(dividendPayoutRatioIDRef_));
        }else{
             return this->dividendPayoutRatio_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeString> DividendPayout::getDividendPayoutConditions()
{
   if(!this->dividendPayoutConditionsIsNull_){
        if(dividendPayoutConditionsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(dividendPayoutConditionsIDRef_));
        }else{
             return this->dividendPayoutConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
std::vector<boost::shared_ptr<PendingPayment>> DividendPayout::getDividendPayment()
{
   if(!this->dividendPaymentIsNull_){
        if(dividendPaymentIDRef_ != ""){
             return this->dividendPayment_;
        }else{
             return this->dividendPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PendingPayment>>();
   }
}
}

