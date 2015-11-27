// JointProbabilityTrait.hpp 
#ifndef FpmlSerialized_JointProbabilityTrait_hpp
#define FpmlSerialized_JointProbabilityTrait_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/NthDefaultTrait.hpp>

namespace FpmlSerialized {

class JointProbabilityTrait : public ISerialized { 
   public: 
       JointProbabilityTrait(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isNthDefaultTrait(){return this->nthDefaultTraitIsNull_;}
       boost::shared_ptr<NthDefaultTrait> getNthDefaultTrait();


       std::string getChoiceStr_jointType(){
           std::string str;
           int count = 0;
           if(!nthDefaultTraitIsNull_){
                count += 1;
                str = "nthDefaultTrait" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_jointType_ = str ;
           return choiceStr_jointType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<NthDefaultTrait> nthDefaultTrait_;     //choice
       
       bool nthDefaultTraitIsNull_;

       //choiceStr 
       std::string choiceStr_jointType_;

};

} //namespaceFpmlSerialized end
#endif

