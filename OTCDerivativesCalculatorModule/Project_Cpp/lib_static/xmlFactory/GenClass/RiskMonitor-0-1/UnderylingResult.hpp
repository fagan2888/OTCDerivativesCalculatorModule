// UnderylingResult.hpp 
#ifndef FpmlSerialized_UnderylingResult_hpp
#define FpmlSerialized_UnderylingResult_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/GbmGreekInfoResult.hpp>
#include <RiskMonitor-0-1/HullWhiteGreekInfoResult.hpp>

namespace FpmlSerialized {

class UnderylingResult : public ISerialized { 
   public: 
       UnderylingResult(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isGbmGreekInfoResult(){return this->gbmGreekInfoResultIsNull_;}
       boost::shared_ptr<GbmGreekInfoResult> getGbmGreekInfoResult();


       bool isHullWhiteGreekInfoResult(){return this->hullWhiteGreekInfoResultIsNull_;}
       boost::shared_ptr<HullWhiteGreekInfoResult> getHullWhiteGreekInfoResult();


       std::string getChoiceStr_underylingGreekType(){
           std::string str;
           int count = 0;
           if(!gbmGreekInfoResultIsNull_){
                count += 1;
                str = "gbmGreekInfoResult" ;
           }
           if(!hullWhiteGreekInfoResultIsNull_){
                count += 1;
                str = "hullWhiteGreekInfoResult" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_underylingGreekType_ = str ;
           return choiceStr_underylingGreekType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<GbmGreekInfoResult> gbmGreekInfoResult_;     //choice
       
       bool gbmGreekInfoResultIsNull_;
         boost::shared_ptr<HullWhiteGreekInfoResult> hullWhiteGreekInfoResult_;     //choice
       
       bool hullWhiteGreekInfoResultIsNull_;

       //choiceStr 
       std::string choiceStr_underylingGreekType_;

};

} //namespaceFpmlSerialized end
#endif

