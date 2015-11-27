// SettlementInformation.hpp 
#ifndef FpmlSerialized_SettlementInformation_hpp
#define FpmlSerialized_SettlementInformation_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/StandardSettlementStyleEnum.hpp>
#include <fpml-shared-5-4/SettlementInstruction.hpp>

namespace FpmlSerialized {

class SettlementInformation : public ISerialized { 
   public: 
       SettlementInformation(TiXmlNode* xmlNode);

       bool isStandardSettlementStyle(){return this->standardSettlementStyleIsNull_;}
       boost::shared_ptr<StandardSettlementStyleEnum> getStandardSettlementStyle();
      std::string getStandardSettlementStyleIDRef(){return standardSettlementStyleIDRef_;}

       bool isSettlementInstruction(){return this->settlementInstructionIsNull_;}
       boost::shared_ptr<SettlementInstruction> getSettlementInstruction();
      std::string getSettlementInstructionIDRef(){return settlementInstructionIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!standardSettlementStyleIsNull_){
                count += 1;
                str = "standardSettlementStyle" ;
           }
           if(!settlementInstructionIsNull_){
                count += 1;
                str = "settlementInstruction" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<StandardSettlementStyleEnum> standardSettlementStyle_;     //choice
       std::string standardSettlementStyleIDRef_;
       bool standardSettlementStyleIsNull_;
         boost::shared_ptr<SettlementInstruction> settlementInstruction_;     //choice
       std::string settlementInstructionIDRef_;
       bool settlementInstructionIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

