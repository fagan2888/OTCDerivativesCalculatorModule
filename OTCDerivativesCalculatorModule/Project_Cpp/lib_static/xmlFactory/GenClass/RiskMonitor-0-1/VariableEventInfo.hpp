// VariableEventInfo.hpp 
#ifndef FpmlSerialized_VariableEventInfo_hpp
#define FpmlSerialized_VariableEventInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/NullVariableEventInfo.hpp>
#include <RiskMonitor-0-1/OverWriteVariableEventInfo.hpp>

namespace FpmlSerialized {

class VariableEventInfo : public ISerialized { 
   public: 
       VariableEventInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isNullVariableEventInfo(){return this->nullVariableEventInfoIsNull_;}
       boost::shared_ptr<NullVariableEventInfo> getNullVariableEventInfo();


       bool isOverWriteVariableEventInfo(){return this->overWriteVariableEventInfoIsNull_;}
       boost::shared_ptr<OverWriteVariableEventInfo> getOverWriteVariableEventInfo();


       std::string getChoiceStr_variableEventInfoType(){
           std::string str;
           int count = 0;
           if(!nullVariableEventInfoIsNull_){
                count += 1;
                str = "nullVariableEventInfo" ;
           }
           if(!overWriteVariableEventInfoIsNull_){
                count += 1;
                str = "overWriteVariableEventInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_variableEventInfoType_ = str ;
           return choiceStr_variableEventInfoType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<NullVariableEventInfo> nullVariableEventInfo_;     //choice
       
       bool nullVariableEventInfoIsNull_;
         boost::shared_ptr<OverWriteVariableEventInfo> overWriteVariableEventInfo_;     //choice
       
       bool overWriteVariableEventInfoIsNull_;

       //choiceStr 
       std::string choiceStr_variableEventInfoType_;

};

} //namespaceFpmlSerialized end
#endif

