// BarrierInfo.hpp 
#ifndef FpmlSerialized_BarrierInfo_hpp
#define FpmlSerialized_BarrierInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/ConstDualBarrierInfo.hpp>
#include <RiskMonitor-0-1/ConstLowerBarrierInfo.hpp>
#include <RiskMonitor-0-1/ConstUpperBarrierInfo.hpp>

namespace FpmlSerialized {

class BarrierInfo : public ISerialized { 
   public: 
       BarrierInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isConstDualBarrierInfo(){return this->constDualBarrierInfoIsNull_;}
       boost::shared_ptr<ConstDualBarrierInfo> getConstDualBarrierInfo();


       bool isConstLowerBarrierInfo(){return this->constLowerBarrierInfoIsNull_;}
       boost::shared_ptr<ConstLowerBarrierInfo> getConstLowerBarrierInfo();


       bool isConstUpperBarrierInfo(){return this->constUpperBarrierInfoIsNull_;}
       boost::shared_ptr<ConstUpperBarrierInfo> getConstUpperBarrierInfo();


       std::string getChoiceStr_barrierType(){
           std::string str;
           int count = 0;
           if(!constDualBarrierInfoIsNull_){
                count += 1;
                str = "constDualBarrierInfo" ;
           }
           if(!constLowerBarrierInfoIsNull_){
                count += 1;
                str = "constLowerBarrierInfo" ;
           }
           if(!constUpperBarrierInfoIsNull_){
                count += 1;
                str = "constUpperBarrierInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_barrierType_ = str ;
           return choiceStr_barrierType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<ConstDualBarrierInfo> constDualBarrierInfo_;     //choice
       
       bool constDualBarrierInfoIsNull_;
         boost::shared_ptr<ConstLowerBarrierInfo> constLowerBarrierInfo_;     //choice
       
       bool constLowerBarrierInfoIsNull_;
         boost::shared_ptr<ConstUpperBarrierInfo> constUpperBarrierInfo_;     //choice
       
       bool constUpperBarrierInfoIsNull_;

       //choiceStr 
       std::string choiceStr_barrierType_;

};

} //namespaceFpmlSerialized end
#endif

