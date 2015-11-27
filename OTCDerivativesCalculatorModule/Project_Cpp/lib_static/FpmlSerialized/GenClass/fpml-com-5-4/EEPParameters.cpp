// EEPParameters.cpp 
#include "EEPParameters.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EEPParameters::EEPParameters(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eEPApplicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eEPApplicableNode = xmlNode->FirstChildElement("eEPApplicable");

   if(eEPApplicableNode){eEPApplicableIsNull_ = false;}
   else{eEPApplicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eEPApplicableNode , address : " << eEPApplicableNode << std::endl;
   #endif
   if(eEPApplicableNode)
   {
      if(eEPApplicableNode->Attribute("href") || eEPApplicableNode->Attribute("id"))
      {
          if(eEPApplicableNode->Attribute("id"))
          {
             eEPApplicableIDRef_ = eEPApplicableNode->Attribute("id");
             eEPApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(eEPApplicableNode));
             eEPApplicable_->setID(eEPApplicableIDRef_);
             IDManager::instance().setID(eEPApplicableIDRef_,eEPApplicable_);
          }
          else if(eEPApplicableNode->Attribute("href")) { eEPApplicableIDRef_ = eEPApplicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eEPApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(eEPApplicableNode));}
   }

   //riskPeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* riskPeriodNode = xmlNode->FirstChildElement("riskPeriod");

   if(riskPeriodNode){riskPeriodIsNull_ = false;}
   else{riskPeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- riskPeriodNode , address : " << riskPeriodNode << std::endl;
   #endif
   if(riskPeriodNode)
   {
      if(riskPeriodNode->Attribute("href") || riskPeriodNode->Attribute("id"))
      {
          if(riskPeriodNode->Attribute("id"))
          {
             riskPeriodIDRef_ = riskPeriodNode->Attribute("id");
             riskPeriod_ = boost::shared_ptr<EEPRiskPeriod>(new EEPRiskPeriod(riskPeriodNode));
             riskPeriod_->setID(riskPeriodIDRef_);
             IDManager::instance().setID(riskPeriodIDRef_,riskPeriod_);
          }
          else if(riskPeriodNode->Attribute("href")) { riskPeriodIDRef_ = riskPeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { riskPeriod_ = boost::shared_ptr<EEPRiskPeriod>(new EEPRiskPeriod(riskPeriodNode));}
   }

   //equivalentApplicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equivalentApplicableNode = xmlNode->FirstChildElement("equivalentApplicable");

   if(equivalentApplicableNode){equivalentApplicableIsNull_ = false;}
   else{equivalentApplicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equivalentApplicableNode , address : " << equivalentApplicableNode << std::endl;
   #endif
   if(equivalentApplicableNode)
   {
      if(equivalentApplicableNode->Attribute("href") || equivalentApplicableNode->Attribute("id"))
      {
          if(equivalentApplicableNode->Attribute("id"))
          {
             equivalentApplicableIDRef_ = equivalentApplicableNode->Attribute("id");
             equivalentApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(equivalentApplicableNode));
             equivalentApplicable_->setID(equivalentApplicableIDRef_);
             IDManager::instance().setID(equivalentApplicableIDRef_,equivalentApplicable_);
          }
          else if(equivalentApplicableNode->Attribute("href")) { equivalentApplicableIDRef_ = equivalentApplicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equivalentApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(equivalentApplicableNode));}
   }

   //penaltyApplicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* penaltyApplicableNode = xmlNode->FirstChildElement("penaltyApplicable");

   if(penaltyApplicableNode){penaltyApplicableIsNull_ = false;}
   else{penaltyApplicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- penaltyApplicableNode , address : " << penaltyApplicableNode << std::endl;
   #endif
   if(penaltyApplicableNode)
   {
      if(penaltyApplicableNode->Attribute("href") || penaltyApplicableNode->Attribute("id"))
      {
          if(penaltyApplicableNode->Attribute("id"))
          {
             penaltyApplicableIDRef_ = penaltyApplicableNode->Attribute("id");
             penaltyApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(penaltyApplicableNode));
             penaltyApplicable_->setID(penaltyApplicableIDRef_);
             IDManager::instance().setID(penaltyApplicableIDRef_,penaltyApplicable_);
          }
          else if(penaltyApplicableNode->Attribute("href")) { penaltyApplicableIDRef_ = penaltyApplicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { penaltyApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(penaltyApplicableNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> EEPParameters::getEEPApplicable()
{
   if(!this->eEPApplicableIsNull_){
        if(eEPApplicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(eEPApplicableIDRef_));
        }else{
             return this->eEPApplicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<EEPRiskPeriod> EEPParameters::getRiskPeriod()
{
   if(!this->riskPeriodIsNull_){
        if(riskPeriodIDRef_ != ""){
             return boost::shared_static_cast<EEPRiskPeriod>(IDManager::instance().getID(riskPeriodIDRef_));
        }else{
             return this->riskPeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EEPRiskPeriod>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EEPParameters::getEquivalentApplicable()
{
   if(!this->equivalentApplicableIsNull_){
        if(equivalentApplicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(equivalentApplicableIDRef_));
        }else{
             return this->equivalentApplicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EEPParameters::getPenaltyApplicable()
{
   if(!this->penaltyApplicableIsNull_){
        if(penaltyApplicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(penaltyApplicableIDRef_));
        }else{
             return this->penaltyApplicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

