// CashFlowInfoResult.hpp 
#ifndef FpmlSerialized_CashFlowInfoResult_hpp
#define FpmlSerialized_CashFlowInfoResult_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/SimpleCashFlowResult.hpp>

namespace FpmlSerialized {

class CashFlowInfoResult : public ISerialized { 
   public: 
       CashFlowInfoResult(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isSimpleCashFlowResult(){return this->simpleCashFlowResultIsNull_;}
       boost::shared_ptr<SimpleCashFlowResult> getSimpleCashFlowResult();


       std::string getChoiceStr_cashFlowType(){
           std::string str;
           int count = 0;
           if(!simpleCashFlowResultIsNull_){
                count += 1;
                str = "simpleCashFlowResult" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_cashFlowType_ = str ;
           return choiceStr_cashFlowType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<SimpleCashFlowResult> simpleCashFlowResult_;     //choice
       
       bool simpleCashFlowResultIsNull_;

       //choiceStr 
       std::string choiceStr_cashFlowType_;

};

} //namespaceFpmlSerialized end
#endif

