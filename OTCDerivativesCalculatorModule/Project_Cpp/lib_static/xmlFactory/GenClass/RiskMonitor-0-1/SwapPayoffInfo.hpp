// SwapPayoffInfo.hpp 
#ifndef FpmlSerialized_SwapPayoffInfo_hpp
#define FpmlSerialized_SwapPayoffInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/VanillaSwapPayoff.hpp>
#include <RiskMonitor-0-1/AutoCallableSwapPayoff.hpp>

namespace FpmlSerialized {

class SwapPayoffInfo : public ISerialized { 
   public: 
       SwapPayoffInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isVanillaSwapPayoff(){return this->vanillaSwapPayoffIsNull_;}
       boost::shared_ptr<VanillaSwapPayoff> getVanillaSwapPayoff();


       bool isAutoCallableSwapPayoff(){return this->autoCallableSwapPayoffIsNull_;}
       boost::shared_ptr<AutoCallableSwapPayoff> getAutoCallableSwapPayoff();


       std::string getChoiceStr_swapPayoffType(){
           std::string str;
           int count = 0;
           if(!vanillaSwapPayoffIsNull_){
                count += 1;
                str = "vanillaSwapPayoff" ;
           }
           if(!autoCallableSwapPayoffIsNull_){
                count += 1;
                str = "autoCallableSwapPayoff" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_swapPayoffType_ = str ;
           return choiceStr_swapPayoffType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<VanillaSwapPayoff> vanillaSwapPayoff_;     //choice
       
       bool vanillaSwapPayoffIsNull_;
         boost::shared_ptr<AutoCallableSwapPayoff> autoCallableSwapPayoff_;     //choice
       
       bool autoCallableSwapPayoffIsNull_;

       //choiceStr 
       std::string choiceStr_swapPayoffType_;

};

} //namespaceFpmlSerialized end
#endif

