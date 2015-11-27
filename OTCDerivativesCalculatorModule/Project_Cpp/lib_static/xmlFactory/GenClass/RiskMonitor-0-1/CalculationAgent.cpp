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
   //calculationAgentPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationAgentPartyNode = xmlNode->FirstChildElement("calculationAgentParty");

   if(calculationAgentPartyNode){calculationAgentPartyIsNull_ = false;}
   else{calculationAgentPartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationAgentPartyNode , address : " << calculationAgentPartyNode << std::endl;
   #endif
   if(calculationAgentPartyNode)
   {
       calculationAgentParty_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(calculationAgentPartyNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CalculationAgent::getCalculationAgentParty()
{
   if(!this->calculationAgentPartyIsNull_){
        return this->calculationAgentParty_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

