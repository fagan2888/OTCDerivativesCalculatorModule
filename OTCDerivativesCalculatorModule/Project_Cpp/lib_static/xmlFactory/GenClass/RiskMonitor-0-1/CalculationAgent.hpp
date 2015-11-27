// CalculationAgent.hpp 
#ifndef FpmlSerialized_CalculationAgent_hpp
#define FpmlSerialized_CalculationAgent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CalculationAgent : public ISerialized { 
   public: 
       CalculationAgent(TiXmlNode* xmlNode);

       bool isCalculationAgentParty(){return this->calculationAgentPartyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationAgentParty();


   protected: 
       boost::shared_ptr<XsdTypeToken> calculationAgentParty_;
       
       bool calculationAgentPartyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

