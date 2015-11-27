// PayoffInfo.hpp 
#ifndef FpmlSerialized_PayoffInfo_hpp
#define FpmlSerialized_PayoffInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/PreDefinedVariableList.hpp>
#include <RiskMonitor-0-1/StopLossPayoff.hpp>
#include <RiskMonitor-0-1/VanillaPayoff.hpp>
#include <RiskMonitor-0-1/CompositeSumOptionPayoff.hpp>
#include <RiskMonitor-0-1/AutoCallablePayoff.hpp>

namespace FpmlSerialized {

class PayoffInfo : public ISerialized { 
   public: 
       PayoffInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isPreDefinedVariableList(){return this->preDefinedVariableListIsNull_;}
       boost::shared_ptr<PreDefinedVariableList> getPreDefinedVariableList();


       bool isStopLossPayoff(){return this->stopLossPayoffIsNull_;}
       boost::shared_ptr<StopLossPayoff> getStopLossPayoff();


       bool isVanillaPayoff(){return this->vanillaPayoffIsNull_;}
       boost::shared_ptr<VanillaPayoff> getVanillaPayoff();


       bool isCompositeSumOptionPayoff(){return this->compositeSumOptionPayoffIsNull_;}
       boost::shared_ptr<CompositeSumOptionPayoff> getCompositeSumOptionPayoff();


       bool isAutoCallablePayoff(){return this->autoCallablePayoffIsNull_;}
       boost::shared_ptr<AutoCallablePayoff> getAutoCallablePayoff();


       std::string getChoiceStr_payoffType(){
           std::string str;
           int count = 0;
           if(!stopLossPayoffIsNull_){
                count += 1;
                str = "stopLossPayoff" ;
           }
           if(!vanillaPayoffIsNull_){
                count += 1;
                str = "vanillaPayoff" ;
           }
           if(!compositeSumOptionPayoffIsNull_){
                count += 1;
                str = "compositeSumOptionPayoff" ;
           }
           if(!autoCallablePayoffIsNull_){
                count += 1;
                str = "autoCallablePayoff" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_payoffType_ = str ;
           return choiceStr_payoffType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<PreDefinedVariableList> preDefinedVariableList_;
       
       bool preDefinedVariableListIsNull_;
         boost::shared_ptr<StopLossPayoff> stopLossPayoff_;     //choice
       
       bool stopLossPayoffIsNull_;
         boost::shared_ptr<VanillaPayoff> vanillaPayoff_;     //choice
       
       bool vanillaPayoffIsNull_;
         boost::shared_ptr<CompositeSumOptionPayoff> compositeSumOptionPayoff_;     //choice
       
       bool compositeSumOptionPayoffIsNull_;
         boost::shared_ptr<AutoCallablePayoff> autoCallablePayoff_;     //choice
       
       bool autoCallablePayoffIsNull_;

       //choiceStr 
       std::string choiceStr_payoffType_;

};

} //namespaceFpmlSerialized end
#endif

