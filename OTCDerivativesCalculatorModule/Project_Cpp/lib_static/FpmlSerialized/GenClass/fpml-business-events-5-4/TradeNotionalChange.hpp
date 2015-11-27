// TradeNotionalChange.hpp 
#ifndef FpmlSerialized_TradeNotionalChange_hpp
#define FpmlSerialized_TradeNotionalChange_hpp

#include <fpml-business-events-5-4/TradeChangeBase.hpp>
#include <fpml-shared-5-4/NonNegativeMoney.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class TradeNotionalChange : public TradeChangeBase { 
   public: 
       TradeNotionalChange(TiXmlNode* xmlNode);

       bool isChangeInNotionalAmount(){return this->changeInNotionalAmountIsNull_;}
       std::vector<boost::shared_ptr<NonNegativeMoney>> getChangeInNotionalAmount();
      std::string getChangeInNotionalAmountIDRef(){return changeInNotionalAmountIDRef_;}

       bool isOutstandingNotionalAmount(){return this->outstandingNotionalAmountIsNull_;}
       std::vector<boost::shared_ptr<NonNegativeMoney>> getOutstandingNotionalAmount();
      std::string getOutstandingNotionalAmountIDRef(){return outstandingNotionalAmountIDRef_;}

       bool isChangeInNumberOfOptions(){return this->changeInNumberOfOptionsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getChangeInNumberOfOptions();
      std::string getChangeInNumberOfOptionsIDRef(){return changeInNumberOfOptionsIDRef_;}

       bool isOutstandingNumberOfOptions(){return this->outstandingNumberOfOptionsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOutstandingNumberOfOptions();
      std::string getOutstandingNumberOfOptionsIDRef(){return outstandingNumberOfOptionsIDRef_;}

       bool isChangeInNumberOfUnits(){return this->changeInNumberOfUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getChangeInNumberOfUnits();
      std::string getChangeInNumberOfUnitsIDRef(){return changeInNumberOfUnitsIDRef_;}

       bool isOutstandingNumberOfUnits(){return this->outstandingNumberOfUnitsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getOutstandingNumberOfUnits();
      std::string getOutstandingNumberOfUnitsIDRef(){return outstandingNumberOfUnitsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!changeInNotionalAmountIsNull_){
                count += 1;
                str = "changeInNotionalAmount" ;
           }
           if(!outstandingNotionalAmountIsNull_){
                count += 1;
                str = "outstandingNotionalAmount" ;
           }
           if(!changeInNumberOfOptionsIsNull_){
                count += 1;
                str = "changeInNumberOfOptions" ;
           }
           if(!outstandingNumberOfOptionsIsNull_){
                count += 1;
                str = "outstandingNumberOfOptions" ;
           }
           if(!changeInNumberOfUnitsIsNull_){
                count += 1;
                str = "changeInNumberOfUnits" ;
           }
           if(!outstandingNumberOfUnitsIsNull_){
                count += 1;
                str = "outstandingNumberOfUnits" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         std::vector<boost::shared_ptr<NonNegativeMoney>> changeInNotionalAmount_;     //choice
       std::string changeInNotionalAmountIDRef_;
       bool changeInNotionalAmountIsNull_;
         std::vector<boost::shared_ptr<NonNegativeMoney>> outstandingNotionalAmount_;     //choice
       std::string outstandingNotionalAmountIDRef_;
       bool outstandingNotionalAmountIsNull_;
         boost::shared_ptr<XsdTypeDecimal> changeInNumberOfOptions_;     //choice
       std::string changeInNumberOfOptionsIDRef_;
       bool changeInNumberOfOptionsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> outstandingNumberOfOptions_;     //choice
       std::string outstandingNumberOfOptionsIDRef_;
       bool outstandingNumberOfOptionsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> changeInNumberOfUnits_;     //choice
       std::string changeInNumberOfUnitsIDRef_;
       bool changeInNumberOfUnitsIsNull_;
         boost::shared_ptr<XsdTypeDecimal> outstandingNumberOfUnits_;     //choice
       std::string outstandingNumberOfUnitsIDRef_;
       bool outstandingNumberOfUnitsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

