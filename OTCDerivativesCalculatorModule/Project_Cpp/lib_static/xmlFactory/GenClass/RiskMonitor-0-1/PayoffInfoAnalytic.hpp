// PayoffInfoAnalytic.hpp 
#ifndef FpmlSerialized_PayoffInfoAnalytic_hpp
#define FpmlSerialized_PayoffInfoAnalytic_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/StandardPayoff_A.hpp>

namespace FpmlSerialized {

class PayoffInfoAnalytic : public ISerialized { 
   public: 
       PayoffInfoAnalytic(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isStandardPayoff_A(){return this->standardPayoff_AIsNull_;}
       boost::shared_ptr<StandardPayoff_A> getStandardPayoff_A();


       std::string getChoiceStr_payoffType_A(){
           std::string str;
           int count = 0;
           if(!standardPayoff_AIsNull_){
                count += 1;
                str = "standardPayoff_A" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_payoffType_A_ = str ;
           return choiceStr_payoffType_A_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<StandardPayoff_A> standardPayoff_A_;     //choice
       
       bool standardPayoff_AIsNull_;

       //choiceStr 
       std::string choiceStr_payoffType_A_;

};

} //namespaceFpmlSerialized end
#endif

