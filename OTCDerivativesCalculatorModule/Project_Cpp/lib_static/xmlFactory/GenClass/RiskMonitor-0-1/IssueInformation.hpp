// IssueInformation.hpp 
#ifndef FpmlSerialized_IssueInformation_hpp
#define FpmlSerialized_IssueInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/SwapInfo.hpp>
#include <RiskMonitor-0-1/NoteInfo.hpp>
#include <RiskMonitor-0-1/OptionInfo.hpp>
#include <RiskMonitor-0-1/SecuritiesInfo.hpp>

namespace FpmlSerialized {

class IssueInformation : public ISerialized { 
   public: 
       IssueInformation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isSwapInfo(){return this->swapInfoIsNull_;}
       boost::shared_ptr<SwapInfo> getSwapInfo();


       bool isNoteInfo(){return this->noteInfoIsNull_;}
       boost::shared_ptr<NoteInfo> getNoteInfo();


       bool isOptionInfo(){return this->optionInfoIsNull_;}
       boost::shared_ptr<OptionInfo> getOptionInfo();


       bool isSecuritiesInfo(){return this->securitiesInfoIsNull_;}
       boost::shared_ptr<SecuritiesInfo> getSecuritiesInfo();


       std::string getChoiceStr_issueType(){
           std::string str;
           int count = 0;
           if(!swapInfoIsNull_){
                count += 1;
                str = "swapInfo" ;
           }
           if(!noteInfoIsNull_){
                count += 1;
                str = "noteInfo" ;
           }
           if(!optionInfoIsNull_){
                count += 1;
                str = "optionInfo" ;
           }
           if(!securitiesInfoIsNull_){
                count += 1;
                str = "securitiesInfo" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_issueType_ = str ;
           return choiceStr_issueType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<SwapInfo> swapInfo_;     //choice
       
       bool swapInfoIsNull_;
         boost::shared_ptr<NoteInfo> noteInfo_;     //choice
       
       bool noteInfoIsNull_;
         boost::shared_ptr<OptionInfo> optionInfo_;     //choice
       
       bool optionInfoIsNull_;
         boost::shared_ptr<SecuritiesInfo> securitiesInfo_;     //choice
       
       bool securitiesInfoIsNull_;

       //choiceStr 
       std::string choiceStr_issueType_;

};

} //namespaceFpmlSerialized end
#endif

