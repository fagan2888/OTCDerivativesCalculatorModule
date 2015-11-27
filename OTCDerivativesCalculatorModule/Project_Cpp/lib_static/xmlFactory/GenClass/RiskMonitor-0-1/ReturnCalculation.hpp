// ReturnCalculation.hpp 
#ifndef FpmlSerialized_ReturnCalculation_hpp
#define FpmlSerialized_ReturnCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/PreCalculation.hpp>
#include <RiskMonitor-0-1/StopLossReturnCal.hpp>
#include <RiskMonitor-0-1/ConstReturnCal.hpp>
#include <RiskMonitor-0-1/VanillaReturnCal.hpp>
#include <RiskMonitor-0-1/Complex1DReturnCal.hpp>
#include <RiskMonitor-0-1/ComplexNDReturnCal.hpp>
#include <RiskMonitor-0-1/ZeroReturnCal.hpp>
#include <RiskMonitor-0-1/CallPutCompositeReturnCal.hpp>
#include <RiskMonitor-0-1/PostCalculation.hpp>
#include <RiskMonitor-0-1/RefVariable_returnValue.hpp>
#include <RiskMonitor-0-1/ResetVariableInfo.hpp>

namespace FpmlSerialized {

class ReturnCalculation : public ISerialized { 
   public: 
       ReturnCalculation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isPreCalculation(){return this->preCalculationIsNull_;}
       boost::shared_ptr<PreCalculation> getPreCalculation();


       bool isStopLossReturnCal(){return this->stopLossReturnCalIsNull_;}
       boost::shared_ptr<StopLossReturnCal> getStopLossReturnCal();


       bool isConstReturnCal(){return this->constReturnCalIsNull_;}
       boost::shared_ptr<ConstReturnCal> getConstReturnCal();


       bool isVanillaReturnCal(){return this->vanillaReturnCalIsNull_;}
       boost::shared_ptr<VanillaReturnCal> getVanillaReturnCal();


       bool isComplex1DReturnCal(){return this->complex1DReturnCalIsNull_;}
       boost::shared_ptr<Complex1DReturnCal> getComplex1DReturnCal();


       bool isComplexNDReturnCal(){return this->complexNDReturnCalIsNull_;}
       boost::shared_ptr<ComplexNDReturnCal> getComplexNDReturnCal();


       bool isZeroReturnCal(){return this->zeroReturnCalIsNull_;}
       boost::shared_ptr<ZeroReturnCal> getZeroReturnCal();


       bool isCallPutCompositeReturnCal(){return this->callPutCompositeReturnCalIsNull_;}
       boost::shared_ptr<CallPutCompositeReturnCal> getCallPutCompositeReturnCal();


       bool isPostCalculation(){return this->postCalculationIsNull_;}
       boost::shared_ptr<PostCalculation> getPostCalculation();


       bool isRefVariable_returnValue(){return this->refVariable_returnValueIsNull_;}
       boost::shared_ptr<RefVariable_returnValue> getRefVariable_returnValue();


       bool isResetVariableInfo(){return this->resetVariableInfoIsNull_;}
       boost::shared_ptr<ResetVariableInfo> getResetVariableInfo();


       std::string getChoiceStr_returnCalType(){
           std::string str;
           int count = 0;
           if(!stopLossReturnCalIsNull_){
                count += 1;
                str = "stopLossReturnCal" ;
           }
           if(!constReturnCalIsNull_){
                count += 1;
                str = "constReturnCal" ;
           }
           if(!vanillaReturnCalIsNull_){
                count += 1;
                str = "vanillaReturnCal" ;
           }
           if(!complex1DReturnCalIsNull_){
                count += 1;
                str = "complex1DReturnCal" ;
           }
           if(!complexNDReturnCalIsNull_){
                count += 1;
                str = "complexNDReturnCal" ;
           }
           if(!zeroReturnCalIsNull_){
                count += 1;
                str = "zeroReturnCal" ;
           }
           if(!callPutCompositeReturnCalIsNull_){
                count += 1;
                str = "callPutCompositeReturnCal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_returnCalType_ = str ;
           return choiceStr_returnCalType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<PreCalculation> preCalculation_;
       
       bool preCalculationIsNull_;
         boost::shared_ptr<StopLossReturnCal> stopLossReturnCal_;     //choice
       
       bool stopLossReturnCalIsNull_;
         boost::shared_ptr<ConstReturnCal> constReturnCal_;     //choice
       
       bool constReturnCalIsNull_;
         boost::shared_ptr<VanillaReturnCal> vanillaReturnCal_;     //choice
       
       bool vanillaReturnCalIsNull_;
         boost::shared_ptr<Complex1DReturnCal> complex1DReturnCal_;     //choice
       
       bool complex1DReturnCalIsNull_;
         boost::shared_ptr<ComplexNDReturnCal> complexNDReturnCal_;     //choice
       
       bool complexNDReturnCalIsNull_;
         boost::shared_ptr<ZeroReturnCal> zeroReturnCal_;     //choice
       
       bool zeroReturnCalIsNull_;
         boost::shared_ptr<CallPutCompositeReturnCal> callPutCompositeReturnCal_;     //choice
       
       bool callPutCompositeReturnCalIsNull_;
       boost::shared_ptr<PostCalculation> postCalculation_;
       
       bool postCalculationIsNull_;
       boost::shared_ptr<RefVariable_returnValue> refVariable_returnValue_;
       
       bool refVariable_returnValueIsNull_;
       boost::shared_ptr<ResetVariableInfo> resetVariableInfo_;
       
       bool resetVariableInfoIsNull_;

       //choiceStr 
       std::string choiceStr_returnCalType_;

};

} //namespaceFpmlSerialized end
#endif

