// VariableInfo.hpp 
#ifndef FpmlSerialized_VariableInfo_hpp
#define FpmlSerialized_VariableInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/NullVariableInfo.hpp>
#include <RiskMonitor-0-1/OverWriteVariableInfo.hpp>
#include <RiskMonitor-0-1/AdditionVariableInfo.hpp>
#include <RiskMonitor-0-1/PreDefinedVariableInfo.hpp>
#include <RiskMonitor-0-1/DefinedVariableInfo.hpp>

namespace FpmlSerialized {

class VariableInfo : public ISerialized { 
   public: 
       VariableInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isNullVariableInfo(){return this->nullVariableInfoIsNull_;}
       boost::shared_ptr<NullVariableInfo> getNullVariableInfo();


       bool isOverWriteVariableInfo(){return this->overWriteVariableInfoIsNull_;}
       boost::shared_ptr<OverWriteVariableInfo> getOverWriteVariableInfo();


       bool isAdditionVariableInfo(){return this->additionVariableInfoIsNull_;}
       boost::shared_ptr<AdditionVariableInfo> getAdditionVariableInfo();


       bool isPreDefinedVariableInfo(){return this->preDefinedVariableInfoIsNull_;}
       boost::shared_ptr<PreDefinedVariableInfo> getPreDefinedVariableInfo();


       bool isDefinedVariableInfo(){return this->definedVariableInfoIsNull_;}
       boost::shared_ptr<DefinedVariableInfo> getDefinedVariableInfo();


       std::string getChoiceStr_variableInfoType(){
           std::string str;
           int count = 0;
           if(!nullVariableInfoIsNull_){
                count += 1;
                str = "nullVariableInfo" ;
           }
           if(!overWriteVariableInfoIsNull_){
                count += 1;
                str = "overWriteVariableInfo" ;
           }
           if(!additionVariableInfoIsNull_){
                count += 1;
                str = "additionVariableInfo" ;
           }
           if(!preDefinedVariableInfoIsNull_){
                count += 1;
                str = "preDefinedVariableInfo" ;
           }
           if(!definedVariableInfoIsNull_){
                count += 1;
                str = "definedVariableInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_variableInfoType_ = str ;
           return choiceStr_variableInfoType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<NullVariableInfo> nullVariableInfo_;     //choice
       
       bool nullVariableInfoIsNull_;
         boost::shared_ptr<OverWriteVariableInfo> overWriteVariableInfo_;     //choice
       
       bool overWriteVariableInfoIsNull_;
         boost::shared_ptr<AdditionVariableInfo> additionVariableInfo_;     //choice
       
       bool additionVariableInfoIsNull_;
         boost::shared_ptr<PreDefinedVariableInfo> preDefinedVariableInfo_;     //choice
       
       bool preDefinedVariableInfoIsNull_;
         boost::shared_ptr<DefinedVariableInfo> definedVariableInfo_;     //choice
       
       bool definedVariableInfoIsNull_;

       //choiceStr 
       std::string choiceStr_variableInfoType_;

};

} //namespaceFpmlSerialized end
#endif

