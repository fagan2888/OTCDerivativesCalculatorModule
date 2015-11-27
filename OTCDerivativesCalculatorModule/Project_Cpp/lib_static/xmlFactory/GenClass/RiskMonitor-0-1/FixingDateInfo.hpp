// FixingDateInfo.hpp 
#ifndef FpmlSerialized_FixingDateInfo_hpp
#define FpmlSerialized_FixingDateInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixedFixingDateInfo.hpp>
#include <RiskMonitor-0-1/RefVariableFixingDateInfo.hpp>
#include <RiskMonitor-0-1/NullFixingDateInfo.hpp>

namespace FpmlSerialized {

class FixingDateInfo : public ISerialized { 
   public: 
       FixingDateInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isFixedFixingDateInfo(){return this->fixedFixingDateInfoIsNull_;}
       boost::shared_ptr<FixedFixingDateInfo> getFixedFixingDateInfo();


       bool isRefVariableFixingDateInfo(){return this->refVariableFixingDateInfoIsNull_;}
       boost::shared_ptr<RefVariableFixingDateInfo> getRefVariableFixingDateInfo();


       bool isNullFixingDateInfo(){return this->nullFixingDateInfoIsNull_;}
       boost::shared_ptr<NullFixingDateInfo> getNullFixingDateInfo();


       std::string getChoiceStr_fixingDateType(){
           std::string str;
           int count = 0;
           if(!fixedFixingDateInfoIsNull_){
                count += 1;
                str = "fixedFixingDateInfo" ;
           }
           if(!refVariableFixingDateInfoIsNull_){
                count += 1;
                str = "refVariableFixingDateInfo" ;
           }
           if(!nullFixingDateInfoIsNull_){
                count += 1;
                str = "nullFixingDateInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_fixingDateType_ = str ;
           return choiceStr_fixingDateType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<FixedFixingDateInfo> fixedFixingDateInfo_;     //choice
       
       bool fixedFixingDateInfoIsNull_;
         boost::shared_ptr<RefVariableFixingDateInfo> refVariableFixingDateInfo_;     //choice
       
       bool refVariableFixingDateInfoIsNull_;
         boost::shared_ptr<NullFixingDateInfo> nullFixingDateInfo_;     //choice
       
       bool nullFixingDateInfoIsNull_;

       //choiceStr 
       std::string choiceStr_fixingDateType_;

};

} //namespaceFpmlSerialized end
#endif

