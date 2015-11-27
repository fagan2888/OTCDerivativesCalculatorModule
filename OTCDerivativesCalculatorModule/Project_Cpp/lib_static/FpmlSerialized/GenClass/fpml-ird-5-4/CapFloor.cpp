// CapFloor.cpp 
#include "CapFloor.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CapFloor::CapFloor(TiXmlNode* xmlNode)
: Product(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //capFloorStreamNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* capFloorStreamNode = xmlNode->FirstChildElement("capFloorStream");

   if(capFloorStreamNode){capFloorStreamIsNull_ = false;}
   else{capFloorStreamIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- capFloorStreamNode , address : " << capFloorStreamNode << std::endl;
   #endif
   if(capFloorStreamNode)
   {
      if(capFloorStreamNode->Attribute("href") || capFloorStreamNode->Attribute("id"))
      {
          if(capFloorStreamNode->Attribute("id"))
          {
             capFloorStreamIDRef_ = capFloorStreamNode->Attribute("id");
             capFloorStream_ = boost::shared_ptr<InterestRateStream>(new InterestRateStream(capFloorStreamNode));
             capFloorStream_->setID(capFloorStreamIDRef_);
             IDManager::instance().setID(capFloorStreamIDRef_,capFloorStream_);
          }
          else if(capFloorStreamNode->Attribute("href")) { capFloorStreamIDRef_ = capFloorStreamNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { capFloorStream_ = boost::shared_ptr<InterestRateStream>(new InterestRateStream(capFloorStreamNode));}
   }

   //premiumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* premiumNode = xmlNode->FirstChildElement("premium");

   if(premiumNode){premiumIsNull_ = false;}
   else{premiumIsNull_ = true;}

   if(premiumNode)
   {
      for(premiumNode; premiumNode; premiumNode = premiumNode->NextSiblingElement("premium")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
          #endif
          if(premiumNode->Attribute("href") || premiumNode->Attribute("id"))
          {
              if(premiumNode->Attribute("id"))
              {
                  premiumIDRef_ = premiumNode->Attribute("id");
                  premium_.push_back(boost::shared_ptr<Payment>(new Payment(premiumNode)));
                  premium_.back()->setID(premiumIDRef_);
                  IDManager::instance().setID(premiumIDRef_, premium_.back());
              }
              else if(premiumNode->Attribute("href")) { premiumIDRef_ = premiumNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { premium_.push_back(boost::shared_ptr<Payment>(new Payment(premiumNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- premiumNode , address : " << premiumNode << std::endl;
       #endif
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<InterestRateStream> CapFloor::getCapFloorStream()
{
   if(!this->capFloorStreamIsNull_){
        if(capFloorStreamIDRef_ != ""){
             return boost::shared_static_cast<InterestRateStream>(IDManager::instance().getID(capFloorStreamIDRef_));
        }else{
             return this->capFloorStream_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestRateStream>();
   }
}
std::vector<boost::shared_ptr<Payment>> CapFloor::getPremium()
{
   if(!this->premiumIsNull_){
        if(premiumIDRef_ != ""){
             return this->premium_;
        }else{
             return this->premium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Payment>>();
   }
}
std::vector<boost::shared_ptr<Payment>> CapFloor::getAdditionalPayment()
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
boost::shared_ptr<EarlyTerminationProvision> CapFloor::getEarlyTerminationProvision()
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
}

