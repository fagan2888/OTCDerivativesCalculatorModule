// FallbackReferencePrice.cpp 
#include "FallbackReferencePrice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FallbackReferencePrice::FallbackReferencePrice(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //valuationPostponementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationPostponementNode = xmlNode->FirstChildElement("valuationPostponement");

   if(valuationPostponementNode){valuationPostponementIsNull_ = false;}
   else{valuationPostponementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationPostponementNode , address : " << valuationPostponementNode << std::endl;
   #endif
   if(valuationPostponementNode)
   {
      if(valuationPostponementNode->Attribute("href") || valuationPostponementNode->Attribute("id"))
      {
          if(valuationPostponementNode->Attribute("id"))
          {
             valuationPostponementIDRef_ = valuationPostponementNode->Attribute("id");
             valuationPostponement_ = boost::shared_ptr<ValuationPostponement>(new ValuationPostponement(valuationPostponementNode));
             valuationPostponement_->setID(valuationPostponementIDRef_);
             IDManager::instance().setID(valuationPostponementIDRef_,valuationPostponement_);
          }
          else if(valuationPostponementNode->Attribute("href")) { valuationPostponementIDRef_ = valuationPostponementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationPostponement_ = boost::shared_ptr<ValuationPostponement>(new ValuationPostponement(valuationPostponementNode));}
   }

   //fallbackSettlementRateOptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fallbackSettlementRateOptionNode = xmlNode->FirstChildElement("fallbackSettlementRateOption");

   if(fallbackSettlementRateOptionNode){fallbackSettlementRateOptionIsNull_ = false;}
   else{fallbackSettlementRateOptionIsNull_ = true;}

   if(fallbackSettlementRateOptionNode)
   {
      for(fallbackSettlementRateOptionNode; fallbackSettlementRateOptionNode; fallbackSettlementRateOptionNode = fallbackSettlementRateOptionNode->NextSiblingElement("fallbackSettlementRateOption")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackSettlementRateOptionNode , address : " << fallbackSettlementRateOptionNode << std::endl;
          #endif
          if(fallbackSettlementRateOptionNode->Attribute("href") || fallbackSettlementRateOptionNode->Attribute("id"))
          {
              if(fallbackSettlementRateOptionNode->Attribute("id"))
              {
                  fallbackSettlementRateOptionIDRef_ = fallbackSettlementRateOptionNode->Attribute("id");
                  fallbackSettlementRateOption_.push_back(boost::shared_ptr<SettlementRateOption>(new SettlementRateOption(fallbackSettlementRateOptionNode)));
                  fallbackSettlementRateOption_.back()->setID(fallbackSettlementRateOptionIDRef_);
                  IDManager::instance().setID(fallbackSettlementRateOptionIDRef_, fallbackSettlementRateOption_.back());
              }
              else if(fallbackSettlementRateOptionNode->Attribute("href")) { fallbackSettlementRateOptionIDRef_ = fallbackSettlementRateOptionNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { fallbackSettlementRateOption_.push_back(boost::shared_ptr<SettlementRateOption>(new SettlementRateOption(fallbackSettlementRateOptionNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackSettlementRateOptionNode , address : " << fallbackSettlementRateOptionNode << std::endl;
       #endif
   }

   //fallbackSurveyValuationPostponenmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fallbackSurveyValuationPostponenmentNode = xmlNode->FirstChildElement("fallbackSurveyValuationPostponenment");

   if(fallbackSurveyValuationPostponenmentNode){fallbackSurveyValuationPostponenmentIsNull_ = false;}
   else{fallbackSurveyValuationPostponenmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackSurveyValuationPostponenmentNode , address : " << fallbackSurveyValuationPostponenmentNode << std::endl;
   #endif
   if(fallbackSurveyValuationPostponenmentNode)
   {
      if(fallbackSurveyValuationPostponenmentNode->Attribute("href") || fallbackSurveyValuationPostponenmentNode->Attribute("id"))
      {
          if(fallbackSurveyValuationPostponenmentNode->Attribute("id"))
          {
             fallbackSurveyValuationPostponenmentIDRef_ = fallbackSurveyValuationPostponenmentNode->Attribute("id");
             fallbackSurveyValuationPostponenment_ = boost::shared_ptr<Empty>(new Empty(fallbackSurveyValuationPostponenmentNode));
             fallbackSurveyValuationPostponenment_->setID(fallbackSurveyValuationPostponenmentIDRef_);
             IDManager::instance().setID(fallbackSurveyValuationPostponenmentIDRef_,fallbackSurveyValuationPostponenment_);
          }
          else if(fallbackSurveyValuationPostponenmentNode->Attribute("href")) { fallbackSurveyValuationPostponenmentIDRef_ = fallbackSurveyValuationPostponenmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fallbackSurveyValuationPostponenment_ = boost::shared_ptr<Empty>(new Empty(fallbackSurveyValuationPostponenmentNode));}
   }

   //calculationAgentDeterminationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentDeterminationNode = xmlNode->FirstChildElement("calculationAgentDetermination");

   if(calculationAgentDeterminationNode){calculationAgentDeterminationIsNull_ = false;}
   else{calculationAgentDeterminationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentDeterminationNode , address : " << calculationAgentDeterminationNode << std::endl;
   #endif
   if(calculationAgentDeterminationNode)
   {
      if(calculationAgentDeterminationNode->Attribute("href") || calculationAgentDeterminationNode->Attribute("id"))
      {
          if(calculationAgentDeterminationNode->Attribute("id"))
          {
             calculationAgentDeterminationIDRef_ = calculationAgentDeterminationNode->Attribute("id");
             calculationAgentDetermination_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentDeterminationNode));
             calculationAgentDetermination_->setID(calculationAgentDeterminationIDRef_);
             IDManager::instance().setID(calculationAgentDeterminationIDRef_,calculationAgentDetermination_);
          }
          else if(calculationAgentDeterminationNode->Attribute("href")) { calculationAgentDeterminationIDRef_ = calculationAgentDeterminationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAgentDetermination_ = boost::shared_ptr<CalculationAgent>(new CalculationAgent(calculationAgentDeterminationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ValuationPostponement> FallbackReferencePrice::getValuationPostponement()
{
   if(!this->valuationPostponementIsNull_){
        if(valuationPostponementIDRef_ != ""){
             return boost::shared_static_cast<ValuationPostponement>(IDManager::instance().getID(valuationPostponementIDRef_));
        }else{
             return this->valuationPostponement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationPostponement>();
   }
}
std::vector<boost::shared_ptr<SettlementRateOption>> FallbackReferencePrice::getFallbackSettlementRateOption()
{
   if(!this->fallbackSettlementRateOptionIsNull_){
        if(fallbackSettlementRateOptionIDRef_ != ""){
             return this->fallbackSettlementRateOption_;
        }else{
             return this->fallbackSettlementRateOption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementRateOption>>();
   }
}
boost::shared_ptr<Empty> FallbackReferencePrice::getFallbackSurveyValuationPostponenment()
{
   if(!this->fallbackSurveyValuationPostponenmentIsNull_){
        if(fallbackSurveyValuationPostponenmentIDRef_ != ""){
             return boost::shared_static_cast<Empty>(IDManager::instance().getID(fallbackSurveyValuationPostponenmentIDRef_));
        }else{
             return this->fallbackSurveyValuationPostponenment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Empty>();
   }
}
boost::shared_ptr<CalculationAgent> FallbackReferencePrice::getCalculationAgentDetermination()
{
   if(!this->calculationAgentDeterminationIsNull_){
        if(calculationAgentDeterminationIDRef_ != ""){
             return boost::shared_static_cast<CalculationAgent>(IDManager::instance().getID(calculationAgentDeterminationIDRef_));
        }else{
             return this->calculationAgentDetermination_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAgent>();
   }
}
}

