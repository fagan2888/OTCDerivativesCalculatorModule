// UnderlyingInformation.hpp 
#ifndef FpmlSerialized_UnderlyingInformation_hpp
#define FpmlSerialized_UnderlyingInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/IndexUnderInfo.hpp>

namespace FpmlSerialized {

class UnderlyingInformation : public ISerialized { 
   public: 
       UnderlyingInformation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isIndexUnderInfo(){return this->indexUnderInfoIsNull_;}
       boost::shared_ptr<IndexUnderInfo> getIndexUnderInfo();


       std::string getChoiceStr_underType(){
           std::string str;
           int count = 0;
           if(!indexUnderInfoIsNull_){
                count += 1;
                str = "indexUnderInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_underType_ = str ;
           return choiceStr_underType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<IndexUnderInfo> indexUnderInfo_;     //choice
       
       bool indexUnderInfoIsNull_;

       //choiceStr 
       std::string choiceStr_underType_;

};

} //namespaceFpmlSerialized end
#endif

