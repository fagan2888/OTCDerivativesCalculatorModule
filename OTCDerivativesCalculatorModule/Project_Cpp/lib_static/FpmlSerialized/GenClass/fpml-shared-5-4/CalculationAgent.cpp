// CalculationAgent.cpp 
#include "CalculationAgent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationAgent::CalculationAgent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationAgentPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentPartyReferenceNode = xmlNode->FirstChildElement("calculationAgentPartyReference");

   if(calculationAgentPartyReferenceNode){calculationAgentPartyReferenceIsNull_ = false;}
   else{calculationAgentPartyReferenceIsNull_ = true;}

   if(calculationAgentPartyReferenceNode)
   {
      for(calculationAgentPartyReferenceNode; calculationAgentPartyReferenceNode; calculationAgentPartyReferenceNode = calculationAgentPartyReferenceNode->NextSiblingElement("calculationAgentPartyReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentPartyReferenceNode , address : " << calculationAgentPartyReferenceNode << std::endl;
          #endif
          if(calculationAgentPartyReferenceNode->Attribute("href") || calculationAgentPartyReferenceNode->Attribute("id"))
          {
              if(calculationAgentPartyReferenceNode->Attribute("id"))
              {
                  calculationAgentPartyReferenceIDRef_ = calculationAgentPartyReferenceNode->Attribute("id");
                  calculationAgentPartyReference_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(calculationAgentPartyReferenceNode)));
                  calculationAgentPartyReference_.back()->setID(calculationAgentPartyReferenceIDRef_);
                  IDManager::instance().setID(calculationAgentPartyReferenceIDRef_, calculationAgentPartyReference_.back());
              }
              else if(calculationAgentPartyReferenceNode->Attribute("href")) { calculationAgentPartyReferenceIDRef_ = calculationAgentPartyReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { calculationAgentPartyReference_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(calculationAgentPartyReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentPartyReferenceNode , address : " << calculationAgentPartyReferenceNode << std::endl;
       #endif
   }

   //calculationAgentPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentPartyNode = xmlNode->FirstChildElement("calculationAgentParty");

   if(calculationAgentPartyNode){calculationAgentPartyIsNull_ = false;}
   else{calculationAgentPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentPartyNode , address : " << calculationAgentPartyNode << std::endl;
   #endif
   if(calculationAgentPartyNode)
   {
      if(calculationAgentPartyNode->Attribute("href") || calculationAgentPartyNode->Attribute("id"))
      {
          if(calculationAgentPartyNode->Attribute("id"))
          {
             calculationAgentPartyIDRef_ = calculationAgentPartyNode->Attribute("id");
             calculationAgentParty_ = boost::shared_ptr<CalculationAgentPartyEnum>(new CalculationAgentPartyEnum(calculationAgentPartyNode));
             calculationAgentParty_->setID(calculationAgentPartyIDRef_);
             IDManager::instance().setID(calculationAgentPartyIDRef_,calculationAgentParty_);
          }
          else if(calculationAgentPartyNode->Attribute("href")) { calculationAgentPartyIDRef_ = calculationAgentPartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationAgentParty_ = boost::shared_ptr<CalculationAgentPartyEnum>(new CalculationAgentPartyEnum(calculationAgentPartyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyReference>> CalculationAgent::getCalculationAgentPartyReference()
{
   if(!this->calculationAgentPartyReferenceIsNull_){
        if(calculationAgentPartyReferenceIDRef_ != ""){
             return this->calculationAgentPartyReference_;
        }else{
             return this->calculationAgentPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyReference>>();
   }
}
boost::shared_ptr<CalculationAgentPartyEnum> CalculationAgent::getCalculationAgentParty()
{
   if(!this->calculationAgentPartyIsNull_){
        if(calculationAgentPartyIDRef_ != ""){
             return boost::shared_static_cast<CalculationAgentPartyEnum>(IDManager::instance().getID(calculationAgentPartyIDRef_));
        }else{
             return this->calculationAgentParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationAgentPartyEnum>();
   }
}
}

