// EquitySwapTransactionSupplement.cpp 
#include "EquitySwapTransactionSupplement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquitySwapTransactionSupplement::EquitySwapTransactionSupplement(TiXmlNode* xmlNode)
: ReturnSwapBase(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //mutualEarlyTerminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mutualEarlyTerminationNode = xmlNode->FirstChildElement("mutualEarlyTermination");

   if(mutualEarlyTerminationNode){mutualEarlyTerminationIsNull_ = false;}
   else{mutualEarlyTerminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mutualEarlyTerminationNode , address : " << mutualEarlyTerminationNode << std::endl;
   #endif
   if(mutualEarlyTerminationNode)
   {
      if(mutualEarlyTerminationNode->Attribute("href") || mutualEarlyTerminationNode->Attribute("id"))
      {
          if(mutualEarlyTerminationNode->Attribute("id"))
          {
             mutualEarlyTerminationIDRef_ = mutualEarlyTerminationNode->Attribute("id");
             mutualEarlyTermination_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(mutualEarlyTerminationNode));
             mutualEarlyTermination_->setID(mutualEarlyTerminationIDRef_);
             IDManager::instance().setID(mutualEarlyTerminationIDRef_,mutualEarlyTermination_);
          }
          else if(mutualEarlyTerminationNode->Attribute("href")) { mutualEarlyTerminationIDRef_ = mutualEarlyTerminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mutualEarlyTermination_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(mutualEarlyTerminationNode));}
   }

   //optionalEarlyTerminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionalEarlyTerminationNode = xmlNode->FirstChildElement("optionalEarlyTermination");

   if(optionalEarlyTerminationNode){optionalEarlyTerminationIsNull_ = false;}
   else{optionalEarlyTerminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionalEarlyTerminationNode , address : " << optionalEarlyTerminationNode << std::endl;
   #endif
   if(optionalEarlyTerminationNode)
   {
      if(optionalEarlyTerminationNode->Attribute("href") || optionalEarlyTerminationNode->Attribute("id"))
      {
          if(optionalEarlyTerminationNode->Attribute("id"))
          {
             optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode->Attribute("id");
             optionalEarlyTermination_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionalEarlyTerminationNode));
             optionalEarlyTermination_->setID(optionalEarlyTerminationIDRef_);
             IDManager::instance().setID(optionalEarlyTerminationIDRef_,optionalEarlyTermination_);
          }
          else if(optionalEarlyTerminationNode->Attribute("href")) { optionalEarlyTerminationIDRef_ = optionalEarlyTerminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { optionalEarlyTermination_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(optionalEarlyTerminationNode));}
   }

   //breakFundingRecoveryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* breakFundingRecoveryNode = xmlNode->FirstChildElement("breakFundingRecovery");

   if(breakFundingRecoveryNode){breakFundingRecoveryIsNull_ = false;}
   else{breakFundingRecoveryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- breakFundingRecoveryNode , address : " << breakFundingRecoveryNode << std::endl;
   #endif
   if(breakFundingRecoveryNode)
   {
      if(breakFundingRecoveryNode->Attribute("href") || breakFundingRecoveryNode->Attribute("id"))
      {
          if(breakFundingRecoveryNode->Attribute("id"))
          {
             breakFundingRecoveryIDRef_ = breakFundingRecoveryNode->Attribute("id");
             breakFundingRecovery_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(breakFundingRecoveryNode));
             breakFundingRecovery_->setID(breakFundingRecoveryIDRef_);
             IDManager::instance().setID(breakFundingRecoveryIDRef_,breakFundingRecovery_);
          }
          else if(breakFundingRecoveryNode->Attribute("href")) { breakFundingRecoveryIDRef_ = breakFundingRecoveryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { breakFundingRecovery_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(breakFundingRecoveryNode));}
   }

   //breakFeeElectionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* breakFeeElectionNode = xmlNode->FirstChildElement("breakFeeElection");

   if(breakFeeElectionNode){breakFeeElectionIsNull_ = false;}
   else{breakFeeElectionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- breakFeeElectionNode , address : " << breakFeeElectionNode << std::endl;
   #endif
   if(breakFeeElectionNode)
   {
      if(breakFeeElectionNode->Attribute("href") || breakFeeElectionNode->Attribute("id"))
      {
          if(breakFeeElectionNode->Attribute("id"))
          {
             breakFeeElectionIDRef_ = breakFeeElectionNode->Attribute("id");
             breakFeeElection_ = boost::shared_ptr<FeeElectionEnum>(new FeeElectionEnum(breakFeeElectionNode));
             breakFeeElection_->setID(breakFeeElectionIDRef_);
             IDManager::instance().setID(breakFeeElectionIDRef_,breakFeeElection_);
          }
          else if(breakFeeElectionNode->Attribute("href")) { breakFeeElectionIDRef_ = breakFeeElectionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { breakFeeElection_ = boost::shared_ptr<FeeElectionEnum>(new FeeElectionEnum(breakFeeElectionNode));}
   }

   //breakFeeRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* breakFeeRateNode = xmlNode->FirstChildElement("breakFeeRate");

   if(breakFeeRateNode){breakFeeRateIsNull_ = false;}
   else{breakFeeRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- breakFeeRateNode , address : " << breakFeeRateNode << std::endl;
   #endif
   if(breakFeeRateNode)
   {
      if(breakFeeRateNode->Attribute("href") || breakFeeRateNode->Attribute("id"))
      {
          if(breakFeeRateNode->Attribute("id"))
          {
             breakFeeRateIDRef_ = breakFeeRateNode->Attribute("id");
             breakFeeRate_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(breakFeeRateNode));
             breakFeeRate_->setID(breakFeeRateIDRef_);
             IDManager::instance().setID(breakFeeRateIDRef_,breakFeeRate_);
          }
          else if(breakFeeRateNode->Attribute("href")) { breakFeeRateIDRef_ = breakFeeRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { breakFeeRate_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(breakFeeRateNode));}
   }

   //multipleExchangeIndexAnnexFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleExchangeIndexAnnexFallbackNode = xmlNode->FirstChildElement("multipleExchangeIndexAnnexFallback");

   if(multipleExchangeIndexAnnexFallbackNode){multipleExchangeIndexAnnexFallbackIsNull_ = false;}
   else{multipleExchangeIndexAnnexFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleExchangeIndexAnnexFallbackNode , address : " << multipleExchangeIndexAnnexFallbackNode << std::endl;
   #endif
   if(multipleExchangeIndexAnnexFallbackNode)
   {
      if(multipleExchangeIndexAnnexFallbackNode->Attribute("href") || multipleExchangeIndexAnnexFallbackNode->Attribute("id"))
      {
          if(multipleExchangeIndexAnnexFallbackNode->Attribute("id"))
          {
             multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode->Attribute("id");
             multipleExchangeIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode));
             multipleExchangeIndexAnnexFallback_->setID(multipleExchangeIndexAnnexFallbackIDRef_);
             IDManager::instance().setID(multipleExchangeIndexAnnexFallbackIDRef_,multipleExchangeIndexAnnexFallback_);
          }
          else if(multipleExchangeIndexAnnexFallbackNode->Attribute("href")) { multipleExchangeIndexAnnexFallbackIDRef_ = multipleExchangeIndexAnnexFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleExchangeIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleExchangeIndexAnnexFallbackNode));}
   }

   //componentSecurityIndexAnnexFallbackNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* componentSecurityIndexAnnexFallbackNode = xmlNode->FirstChildElement("componentSecurityIndexAnnexFallback");

   if(componentSecurityIndexAnnexFallbackNode){componentSecurityIndexAnnexFallbackIsNull_ = false;}
   else{componentSecurityIndexAnnexFallbackIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- componentSecurityIndexAnnexFallbackNode , address : " << componentSecurityIndexAnnexFallbackNode << std::endl;
   #endif
   if(componentSecurityIndexAnnexFallbackNode)
   {
      if(componentSecurityIndexAnnexFallbackNode->Attribute("href") || componentSecurityIndexAnnexFallbackNode->Attribute("id"))
      {
          if(componentSecurityIndexAnnexFallbackNode->Attribute("id"))
          {
             componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode->Attribute("id");
             componentSecurityIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode));
             componentSecurityIndexAnnexFallback_->setID(componentSecurityIndexAnnexFallbackIDRef_);
             IDManager::instance().setID(componentSecurityIndexAnnexFallbackIDRef_,componentSecurityIndexAnnexFallback_);
          }
          else if(componentSecurityIndexAnnexFallbackNode->Attribute("href")) { componentSecurityIndexAnnexFallbackIDRef_ = componentSecurityIndexAnnexFallbackNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { componentSecurityIndexAnnexFallback_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(componentSecurityIndexAnnexFallbackNode));}
   }

   //localJurisdictionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* localJurisdictionNode = xmlNode->FirstChildElement("localJurisdiction");

   if(localJurisdictionNode){localJurisdictionIsNull_ = false;}
   else{localJurisdictionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- localJurisdictionNode , address : " << localJurisdictionNode << std::endl;
   #endif
   if(localJurisdictionNode)
   {
      if(localJurisdictionNode->Attribute("href") || localJurisdictionNode->Attribute("id"))
      {
          if(localJurisdictionNode->Attribute("id"))
          {
             localJurisdictionIDRef_ = localJurisdictionNode->Attribute("id");
             localJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(localJurisdictionNode));
             localJurisdiction_->setID(localJurisdictionIDRef_);
             IDManager::instance().setID(localJurisdictionIDRef_,localJurisdiction_);
          }
          else if(localJurisdictionNode->Attribute("href")) { localJurisdictionIDRef_ = localJurisdictionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { localJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(localJurisdictionNode));}
   }

   //relevantJurisdictionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* relevantJurisdictionNode = xmlNode->FirstChildElement("relevantJurisdiction");

   if(relevantJurisdictionNode){relevantJurisdictionIsNull_ = false;}
   else{relevantJurisdictionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- relevantJurisdictionNode , address : " << relevantJurisdictionNode << std::endl;
   #endif
   if(relevantJurisdictionNode)
   {
      if(relevantJurisdictionNode->Attribute("href") || relevantJurisdictionNode->Attribute("id"))
      {
          if(relevantJurisdictionNode->Attribute("id"))
          {
             relevantJurisdictionIDRef_ = relevantJurisdictionNode->Attribute("id");
             relevantJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(relevantJurisdictionNode));
             relevantJurisdiction_->setID(relevantJurisdictionIDRef_);
             IDManager::instance().setID(relevantJurisdictionIDRef_,relevantJurisdiction_);
          }
          else if(relevantJurisdictionNode->Attribute("href")) { relevantJurisdictionIDRef_ = relevantJurisdictionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { relevantJurisdiction_ = boost::shared_ptr<CountryCode>(new CountryCode(relevantJurisdictionNode));}
   }

   //extraordinaryEventsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extraordinaryEventsNode = xmlNode->FirstChildElement("extraordinaryEvents");

   if(extraordinaryEventsNode){extraordinaryEventsIsNull_ = false;}
   else{extraordinaryEventsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extraordinaryEventsNode , address : " << extraordinaryEventsNode << std::endl;
   #endif
   if(extraordinaryEventsNode)
   {
      if(extraordinaryEventsNode->Attribute("href") || extraordinaryEventsNode->Attribute("id"))
      {
          if(extraordinaryEventsNode->Attribute("id"))
          {
             extraordinaryEventsIDRef_ = extraordinaryEventsNode->Attribute("id");
             extraordinaryEvents_ = boost::shared_ptr<ExtraordinaryEvents>(new ExtraordinaryEvents(extraordinaryEventsNode));
             extraordinaryEvents_->setID(extraordinaryEventsIDRef_);
             IDManager::instance().setID(extraordinaryEventsIDRef_,extraordinaryEvents_);
          }
          else if(extraordinaryEventsNode->Attribute("href")) { extraordinaryEventsIDRef_ = extraordinaryEventsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { extraordinaryEvents_ = boost::shared_ptr<ExtraordinaryEvents>(new ExtraordinaryEvents(extraordinaryEventsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> EquitySwapTransactionSupplement::getMutualEarlyTermination()
{
   if(!this->mutualEarlyTerminationIsNull_){
        if(mutualEarlyTerminationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(mutualEarlyTerminationIDRef_));
        }else{
             return this->mutualEarlyTermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquitySwapTransactionSupplement::getOptionalEarlyTermination()
{
   if(!this->optionalEarlyTerminationIsNull_){
        if(optionalEarlyTerminationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(optionalEarlyTerminationIDRef_));
        }else{
             return this->optionalEarlyTermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquitySwapTransactionSupplement::getBreakFundingRecovery()
{
   if(!this->breakFundingRecoveryIsNull_){
        if(breakFundingRecoveryIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(breakFundingRecoveryIDRef_));
        }else{
             return this->breakFundingRecovery_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<FeeElectionEnum> EquitySwapTransactionSupplement::getBreakFeeElection()
{
   if(!this->breakFeeElectionIsNull_){
        if(breakFeeElectionIDRef_ != ""){
             return boost::shared_static_cast<FeeElectionEnum>(IDManager::instance().getID(breakFeeElectionIDRef_));
        }else{
             return this->breakFeeElection_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FeeElectionEnum>();
   }
}
boost::shared_ptr<NonNegativeDecimal> EquitySwapTransactionSupplement::getBreakFeeRate()
{
   if(!this->breakFeeRateIsNull_){
        if(breakFeeRateIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(breakFeeRateIDRef_));
        }else{
             return this->breakFeeRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquitySwapTransactionSupplement::getMultipleExchangeIndexAnnexFallback()
{
   if(!this->multipleExchangeIndexAnnexFallbackIsNull_){
        if(multipleExchangeIndexAnnexFallbackIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(multipleExchangeIndexAnnexFallbackIDRef_));
        }else{
             return this->multipleExchangeIndexAnnexFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EquitySwapTransactionSupplement::getComponentSecurityIndexAnnexFallback()
{
   if(!this->componentSecurityIndexAnnexFallbackIsNull_){
        if(componentSecurityIndexAnnexFallbackIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(componentSecurityIndexAnnexFallbackIDRef_));
        }else{
             return this->componentSecurityIndexAnnexFallback_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<CountryCode> EquitySwapTransactionSupplement::getLocalJurisdiction()
{
   if(!this->localJurisdictionIsNull_){
        if(localJurisdictionIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(localJurisdictionIDRef_));
        }else{
             return this->localJurisdiction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
boost::shared_ptr<CountryCode> EquitySwapTransactionSupplement::getRelevantJurisdiction()
{
   if(!this->relevantJurisdictionIsNull_){
        if(relevantJurisdictionIDRef_ != ""){
             return boost::shared_static_cast<CountryCode>(IDManager::instance().getID(relevantJurisdictionIDRef_));
        }else{
             return this->relevantJurisdiction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CountryCode>();
   }
}
boost::shared_ptr<ExtraordinaryEvents> EquitySwapTransactionSupplement::getExtraordinaryEvents()
{
   if(!this->extraordinaryEventsIsNull_){
        if(extraordinaryEventsIDRef_ != ""){
             return boost::shared_static_cast<ExtraordinaryEvents>(IDManager::instance().getID(extraordinaryEventsIDRef_));
        }else{
             return this->extraordinaryEvents_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExtraordinaryEvents>();
   }
}
}

