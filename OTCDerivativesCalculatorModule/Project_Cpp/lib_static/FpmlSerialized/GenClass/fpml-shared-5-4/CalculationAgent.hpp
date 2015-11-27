// CalculationAgent.hpp 
#ifndef FpmlSerialized_CalculationAgent_hpp
#define FpmlSerialized_CalculationAgent_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-enum-5-4/CalculationAgentPartyEnum.hpp>

namespace FpmlSerialized {

class CalculationAgent : public ISerialized { 
   public: 
       CalculationAgent(TiXmlNode* xmlNode);

       bool isCalculationAgentPartyReference(){return this->calculationAgentPartyReferenceIsNull_;}
       std::vector<boost::shared_ptr<PartyReference>> getCalculationAgentPartyReference();
      std::string getCalculationAgentPartyReferenceIDRef(){return calculationAgentPartyReferenceIDRef_;}

       bool isCalculationAgentParty(){return this->calculationAgentPartyIsNull_;}
       boost::shared_ptr<CalculationAgentPartyEnum> getCalculationAgentParty();
      std::string getCalculationAgentPartyIDRef(){return calculationAgentPartyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!calculationAgentPartyReferenceIsNull_){
                count += 1;
                str = "calculationAgentPartyReference" ;
           }
           if(!calculationAgentPartyIsNull_){
                count += 1;
                str = "calculationAgentParty" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         std::vector<boost::shared_ptr<PartyReference>> calculationAgentPartyReference_;     //choice
       std::string calculationAgentPartyReferenceIDRef_;
       bool calculationAgentPartyReferenceIsNull_;
         boost::shared_ptr<CalculationAgentPartyEnum> calculationAgentParty_;     //choice
       std::string calculationAgentPartyIDRef_;
       bool calculationAgentPartyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

