// Representations.cpp 
#include "Representations.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Representations::Representations(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nonRelianceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nonRelianceNode = xmlNode->FirstChildElement("nonReliance");

   if(nonRelianceNode){nonRelianceIsNull_ = false;}
   else{nonRelianceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nonRelianceNode , address : " << nonRelianceNode << std::endl;
   #endif
   if(nonRelianceNode)
   {
      if(nonRelianceNode->Attribute("href") || nonRelianceNode->Attribute("id"))
      {
          if(nonRelianceNode->Attribute("id"))
          {
             nonRelianceIDRef_ = nonRelianceNode->Attribute("id");
             nonReliance_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(nonRelianceNode));
             nonReliance_->setID(nonRelianceIDRef_);
             IDManager::instance().setID(nonRelianceIDRef_,nonReliance_);
          }
          else if(nonRelianceNode->Attribute("href")) { nonRelianceIDRef_ = nonRelianceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { nonReliance_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(nonRelianceNode));}
   }

   //agreementsRegardingHedgingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* agreementsRegardingHedgingNode = xmlNode->FirstChildElement("agreementsRegardingHedging");

   if(agreementsRegardingHedgingNode){agreementsRegardingHedgingIsNull_ = false;}
   else{agreementsRegardingHedgingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- agreementsRegardingHedgingNode , address : " << agreementsRegardingHedgingNode << std::endl;
   #endif
   if(agreementsRegardingHedgingNode)
   {
      if(agreementsRegardingHedgingNode->Attribute("href") || agreementsRegardingHedgingNode->Attribute("id"))
      {
          if(agreementsRegardingHedgingNode->Attribute("id"))
          {
             agreementsRegardingHedgingIDRef_ = agreementsRegardingHedgingNode->Attribute("id");
             agreementsRegardingHedging_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(agreementsRegardingHedgingNode));
             agreementsRegardingHedging_->setID(agreementsRegardingHedgingIDRef_);
             IDManager::instance().setID(agreementsRegardingHedgingIDRef_,agreementsRegardingHedging_);
          }
          else if(agreementsRegardingHedgingNode->Attribute("href")) { agreementsRegardingHedgingIDRef_ = agreementsRegardingHedgingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { agreementsRegardingHedging_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(agreementsRegardingHedgingNode));}
   }

   //indexDisclaimerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexDisclaimerNode = xmlNode->FirstChildElement("indexDisclaimer");

   if(indexDisclaimerNode){indexDisclaimerIsNull_ = false;}
   else{indexDisclaimerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexDisclaimerNode , address : " << indexDisclaimerNode << std::endl;
   #endif
   if(indexDisclaimerNode)
   {
      if(indexDisclaimerNode->Attribute("href") || indexDisclaimerNode->Attribute("id"))
      {
          if(indexDisclaimerNode->Attribute("id"))
          {
             indexDisclaimerIDRef_ = indexDisclaimerNode->Attribute("id");
             indexDisclaimer_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(indexDisclaimerNode));
             indexDisclaimer_->setID(indexDisclaimerIDRef_);
             IDManager::instance().setID(indexDisclaimerIDRef_,indexDisclaimer_);
          }
          else if(indexDisclaimerNode->Attribute("href")) { indexDisclaimerIDRef_ = indexDisclaimerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexDisclaimer_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(indexDisclaimerNode));}
   }

   //additionalAcknowledgementsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalAcknowledgementsNode = xmlNode->FirstChildElement("additionalAcknowledgements");

   if(additionalAcknowledgementsNode){additionalAcknowledgementsIsNull_ = false;}
   else{additionalAcknowledgementsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalAcknowledgementsNode , address : " << additionalAcknowledgementsNode << std::endl;
   #endif
   if(additionalAcknowledgementsNode)
   {
      if(additionalAcknowledgementsNode->Attribute("href") || additionalAcknowledgementsNode->Attribute("id"))
      {
          if(additionalAcknowledgementsNode->Attribute("id"))
          {
             additionalAcknowledgementsIDRef_ = additionalAcknowledgementsNode->Attribute("id");
             additionalAcknowledgements_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(additionalAcknowledgementsNode));
             additionalAcknowledgements_->setID(additionalAcknowledgementsIDRef_);
             IDManager::instance().setID(additionalAcknowledgementsIDRef_,additionalAcknowledgements_);
          }
          else if(additionalAcknowledgementsNode->Attribute("href")) { additionalAcknowledgementsIDRef_ = additionalAcknowledgementsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { additionalAcknowledgements_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(additionalAcknowledgementsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> Representations::getNonReliance()
{
   if(!this->nonRelianceIsNull_){
        if(nonRelianceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(nonRelianceIDRef_));
        }else{
             return this->nonReliance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Representations::getAgreementsRegardingHedging()
{
   if(!this->agreementsRegardingHedgingIsNull_){
        if(agreementsRegardingHedgingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(agreementsRegardingHedgingIDRef_));
        }else{
             return this->agreementsRegardingHedging_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Representations::getIndexDisclaimer()
{
   if(!this->indexDisclaimerIsNull_){
        if(indexDisclaimerIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(indexDisclaimerIDRef_));
        }else{
             return this->indexDisclaimer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Representations::getAdditionalAcknowledgements()
{
   if(!this->additionalAcknowledgementsIsNull_){
        if(additionalAcknowledgementsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(additionalAcknowledgementsIDRef_));
        }else{
             return this->additionalAcknowledgements_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

