// Swap.cpp 
#include "Swap.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Swap::Swap(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //swapStreamNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapStreamNode = xmlNode->FirstChildElement("swapStream");

   if(swapStreamNode){swapStreamIsNull_ = false;}
   else{swapStreamIsNull_ = true;}

   if(swapStreamNode)
   {
      for(swapStreamNode; swapStreamNode; swapStreamNode = swapStreamNode->NextSiblingElement("swapStream")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapStreamNode , address : " << swapStreamNode << std::endl;
          #endif
          if(swapStreamNode->Attribute("href") || swapStreamNode->Attribute("id"))
          {
              if(swapStreamNode->Attribute("id"))
              {
                  swapStreamIDRef_ = swapStreamNode->Attribute("id");
                  swapStream_.push_back(boost::shared_ptr<InterestRateStream>(new InterestRateStream(swapStreamNode)));
                  swapStream_.back()->setID(swapStreamIDRef_);
                  IDManager::instance().setID(swapStreamIDRef_, swapStream_.back());
              }
              else if(swapStreamNode->Attribute("href")) { swapStreamIDRef_ = swapStreamNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { swapStream_.push_back(boost::shared_ptr<InterestRateStream>(new InterestRateStream(swapStreamNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapStreamNode , address : " << swapStreamNode << std::endl;
       #endif
   }

   //earlyTerminationProvisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* earlyTerminationProvisionNode = xmlNode->FirstChildElement("earlyTerminationProvision");

   if(earlyTerminationProvisionNode){earlyTerminationProvisionIsNull_ = false;}
   else{earlyTerminationProvisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earlyTerminationProvisionNode , address : " << earlyTerminationProvisionNode << std::endl;
   #endif
   if(earlyTerminationProvisionNode)
   {
      if(earlyTerminationProvisionNode->Attribute("href") || earlyTerminationProvisionNode->Attribute("id"))
      {
          if(earlyTerminationProvisionNode->Attribute("id"))
          {
             earlyTerminationProvisionIDRef_ = earlyTerminationProvisionNode->Attribute("id");
             earlyTerminationProvision_ = boost::shared_ptr<EarlyTerminationProvision>(new EarlyTerminationProvision(earlyTerminationProvisionNode));
             earlyTerminationProvision_->setID(earlyTerminationProvisionIDRef_);
             IDManager::instance().setID(earlyTerminationProvisionIDRef_,earlyTerminationProvision_);
          }
          else if(earlyTerminationProvisionNode->Attribute("href")) { earlyTerminationProvisionIDRef_ = earlyTerminationProvisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { earlyTerminationProvision_ = boost::shared_ptr<EarlyTerminationProvision>(new EarlyTerminationProvision(earlyTerminationProvisionNode));}
   }

   //cancelableProvisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cancelableProvisionNode = xmlNode->FirstChildElement("cancelableProvision");

   if(cancelableProvisionNode){cancelableProvisionIsNull_ = false;}
   else{cancelableProvisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cancelableProvisionNode , address : " << cancelableProvisionNode << std::endl;
   #endif
   if(cancelableProvisionNode)
   {
      if(cancelableProvisionNode->Attribute("href") || cancelableProvisionNode->Attribute("id"))
      {
          if(cancelableProvisionNode->Attribute("id"))
          {
             cancelableProvisionIDRef_ = cancelableProvisionNode->Attribute("id");
             cancelableProvision_ = boost::shared_ptr<CancelableProvision>(new CancelableProvision(cancelableProvisionNode));
             cancelableProvision_->setID(cancelableProvisionIDRef_);
             IDManager::instance().setID(cancelableProvisionIDRef_,cancelableProvision_);
          }
          else if(cancelableProvisionNode->Attribute("href")) { cancelableProvisionIDRef_ = cancelableProvisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cancelableProvision_ = boost::shared_ptr<CancelableProvision>(new CancelableProvision(cancelableProvisionNode));}
   }

   //extendibleProvisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extendibleProvisionNode = xmlNode->FirstChildElement("extendibleProvision");

   if(extendibleProvisionNode){extendibleProvisionIsNull_ = false;}
   else{extendibleProvisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extendibleProvisionNode , address : " << extendibleProvisionNode << std::endl;
   #endif
   if(extendibleProvisionNode)
   {
      if(extendibleProvisionNode->Attribute("href") || extendibleProvisionNode->Attribute("id"))
      {
          if(extendibleProvisionNode->Attribute("id"))
          {
             extendibleProvisionIDRef_ = extendibleProvisionNode->Attribute("id");
             extendibleProvision_ = boost::shared_ptr<ExtendibleProvision>(new ExtendibleProvision(extendibleProvisionNode));
             extendibleProvision_->setID(extendibleProvisionIDRef_);
             IDManager::instance().setID(extendibleProvisionIDRef_,extendibleProvision_);
          }
          else if(extendibleProvisionNode->Attribute("href")) { extendibleProvisionIDRef_ = extendibleProvisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { extendibleProvision_ = boost::shared_ptr<ExtendibleProvision>(new ExtendibleProvision(extendibleProvisionNode));}
   }

   //additionalPaymentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalPaymentNode = xmlNode->FirstChildElement("additionalPayment");

   if(additionalPaymentNode){additionalPaymentIsNull_ = false;}
   else{additionalPaymentIsNull_ = true;}

   if(additionalPaymentNode)
   {
      for(additionalPaymentNode; additionalPaymentNode; additionalPaymentNode = additionalPaymentNode->NextSiblingElement("additionalPayment")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalPaymentNode , address : " << additionalPaymentNode << std::endl;
          #endif
          if(additionalPaymentNode->Attribute("href") || additionalPaymentNode->Attribute("id"))
          {
              if(additionalPaymentNode->Attribute("id"))
              {
                  additionalPaymentIDRef_ = additionalPaymentNode->Attribute("id");
                  additionalPayment_.push_back(boost::shared_ptr<Payment>(new Payment(additionalPaymentNode)));
                  additionalPayment_.back()->setID(additionalPaymentIDRef_);
                  IDManager::instance().setID(additionalPaymentIDRef_, additionalPayment_.back());
              }
              else if(additionalPaymentNode->Attribute("href")) { additionalPaymentIDRef_ = additionalPaymentNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { additionalPayment_.push_back(boost::shared_ptr<Payment>(new Payment(additionalPaymentNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalPaymentNode , address : " << additionalPaymentNode << std::endl;
       #endif
   }

   //additionalTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalTermsNode = xmlNode->FirstChildElement("additionalTerms");

   if(additionalTermsNode){additionalTermsIsNull_ = false;}
   else{additionalTermsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalTermsNode , address : " << additionalTermsNode << std::endl;
   #endif
   if(additionalTermsNode)
   {
      if(additionalTermsNode->Attribute("href") || additionalTermsNode->Attribute("id"))
      {
          if(additionalTermsNode->Attribute("id"))
          {
             additionalTermsIDRef_ = additionalTermsNode->Attribute("id");
             additionalTerms_ = boost::shared_ptr<SwapAdditionalTerms>(new SwapAdditionalTerms(additionalTermsNode));
             additionalTerms_->setID(additionalTermsIDRef_);
             IDManager::instance().setID(additionalTermsIDRef_,additionalTerms_);
          }
          else if(additionalTermsNode->Attribute("href")) { additionalTermsIDRef_ = additionalTermsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalTerms_ = boost::shared_ptr<SwapAdditionalTerms>(new SwapAdditionalTerms(additionalTermsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<InterestRateStream>> Swap::getSwapStream()
{
   if(!this->swapStreamIsNull_){
        if(swapStreamIDRef_ != ""){
             return this->swapStream_;
        }else{
             return this->swapStream_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<InterestRateStream>>();
   }
}
boost::shared_ptr<EarlyTerminationProvision> Swap::getEarlyTerminationProvision()
{
   if(!this->earlyTerminationProvisionIsNull_){
        if(earlyTerminationProvisionIDRef_ != ""){
             return boost::shared_static_cast<EarlyTerminationProvision>(IDManager::instance().getID(earlyTerminationProvisionIDRef_));
        }else{
             return this->earlyTerminationProvision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EarlyTerminationProvision>();
   }
}
boost::shared_ptr<CancelableProvision> Swap::getCancelableProvision()
{
   if(!this->cancelableProvisionIsNull_){
        if(cancelableProvisionIDRef_ != ""){
             return boost::shared_static_cast<CancelableProvision>(IDManager::instance().getID(cancelableProvisionIDRef_));
        }else{
             return this->cancelableProvision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CancelableProvision>();
   }
}
boost::shared_ptr<ExtendibleProvision> Swap::getExtendibleProvision()
{
   if(!this->extendibleProvisionIsNull_){
        if(extendibleProvisionIDRef_ != ""){
             return boost::shared_static_cast<ExtendibleProvision>(IDManager::instance().getID(extendibleProvisionIDRef_));
        }else{
             return this->extendibleProvision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExtendibleProvision>();
   }
}
std::vector<boost::shared_ptr<Payment>> Swap::getAdditionalPayment()
{
   if(!this->additionalPaymentIsNull_){
        if(additionalPaymentIDRef_ != ""){
             return this->additionalPayment_;
        }else{
             return this->additionalPayment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Payment>>();
   }
}
boost::shared_ptr<SwapAdditionalTerms> Swap::getAdditionalTerms()
{
   if(!this->additionalTermsIsNull_){
        if(additionalTermsIDRef_ != ""){
             return boost::shared_static_cast<SwapAdditionalTerms>(IDManager::instance().getID(additionalTermsIDRef_));
        }else{
             return this->additionalTerms_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SwapAdditionalTerms>();
   }
}
}

