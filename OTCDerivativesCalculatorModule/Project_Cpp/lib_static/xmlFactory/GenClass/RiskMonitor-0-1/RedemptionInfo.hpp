// RedemptionInfo.hpp 
#ifndef FpmlSerialized_RedemptionInfo_hpp
#define FpmlSerialized_RedemptionInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/AutoCallRedem.hpp>
#include <RiskMonitor-0-1/MonthlyAutoCallRedem.hpp>

namespace FpmlSerialized {

class RedemptionInfo : public ISerialized { 
   public: 
       RedemptionInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isAutoCallRedem(){return this->autoCallRedemIsNull_;}
       boost::shared_ptr<AutoCallRedem> getAutoCallRedem();


       bool isMonthlyAutoCallRedem(){return this->monthlyAutoCallRedemIsNull_;}
       boost::shared_ptr<MonthlyAutoCallRedem> getMonthlyAutoCallRedem();


       std::string getChoiceStr_redemptionType(){
           std::string str;
           int count = 0;
           if(!autoCallRedemIsNull_){
                count += 1;
                str = "autoCallRedem" ;
           }
           if(!monthlyAutoCallRedemIsNull_){
                count += 1;
                str = "monthlyAutoCallRedem" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_redemptionType_ = str ;
           return choiceStr_redemptionType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<AutoCallRedem> autoCallRedem_;     //choice
       
       bool autoCallRedemIsNull_;
         boost::shared_ptr<MonthlyAutoCallRedem> monthlyAutoCallRedem_;     //choice
       
       bool monthlyAutoCallRedemIsNull_;

       //choiceStr 
       std::string choiceStr_redemptionType_;

};

} //namespaceFpmlSerialized end
#endif

