// SwapPayoffInfoAnalytic.hpp 
#ifndef FpmlSerialized_SwapPayoffInfoAnalytic_hpp
#define FpmlSerialized_SwapPayoffInfoAnalytic_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/InterestRateSwapPayoff_A.hpp>

namespace FpmlSerialized {

class SwapPayoffInfoAnalytic : public ISerialized { 
   public: 
       SwapPayoffInfoAnalytic(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isInterestRateSwapPayoff_A(){return this->interestRateSwapPayoff_AIsNull_;}
       boost::shared_ptr<InterestRateSwapPayoff_A> getInterestRateSwapPayoff_A();


       std::string getChoiceStr_swapPayoffType_A(){
           std::string str;
           int count = 0;
           if(!interestRateSwapPayoff_AIsNull_){
                count += 1;
                str = "interestRateSwapPayoff_A" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_swapPayoffType_A_ = str ;
           return choiceStr_swapPayoffType_A_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<InterestRateSwapPayoff_A> interestRateSwapPayoff_A_;     //choice
       
       bool interestRateSwapPayoff_AIsNull_;

       //choiceStr 
       std::string choiceStr_swapPayoffType_A_;

};

} //namespaceFpmlSerialized end
#endif

