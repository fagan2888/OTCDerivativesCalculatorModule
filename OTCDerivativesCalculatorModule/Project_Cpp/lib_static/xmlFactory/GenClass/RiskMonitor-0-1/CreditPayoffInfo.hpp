// CreditPayoffInfo.hpp 
#ifndef FpmlSerialized_CreditPayoffInfo_hpp
#define FpmlSerialized_CreditPayoffInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/CreditDefaultSwap.hpp>

namespace FpmlSerialized {

class CreditPayoffInfo : public ISerialized { 
   public: 
       CreditPayoffInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isCreditDefaultSwap(){return this->creditDefaultSwapIsNull_;}
       boost::shared_ptr<CreditDefaultSwap> getCreditDefaultSwap();


       std::string getChoiceStr_creditPayoffType(){
           std::string str;
           int count = 0;
           if(!creditDefaultSwapIsNull_){
                count += 1;
                str = "creditDefaultSwap" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_creditPayoffType_ = str ;
           return choiceStr_creditPayoffType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<CreditDefaultSwap> creditDefaultSwap_;     //choice
       
       bool creditDefaultSwapIsNull_;

       //choiceStr 
       std::string choiceStr_creditPayoffType_;

};

} //namespaceFpmlSerialized end
#endif

