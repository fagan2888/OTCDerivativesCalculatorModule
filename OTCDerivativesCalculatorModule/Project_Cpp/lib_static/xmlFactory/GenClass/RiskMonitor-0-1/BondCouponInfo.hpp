// BondCouponInfo.hpp 
#ifndef FpmlSerialized_BondCouponInfo_hpp
#define FpmlSerialized_BondCouponInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixedRateType.hpp>

namespace FpmlSerialized {

class BondCouponInfo : public ISerialized { 
   public: 
       BondCouponInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isFixedRateType(){return this->fixedRateTypeIsNull_;}
       boost::shared_ptr<FixedRateType> getFixedRateType();


       std::string getChoiceStr_bondCouponType(){
           std::string str;
           int count = 0;
           if(!fixedRateTypeIsNull_){
                count += 1;
                str = "fixedRateType" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_bondCouponType_ = str ;
           return choiceStr_bondCouponType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<FixedRateType> fixedRateType_;     //choice
       
       bool fixedRateTypeIsNull_;

       //choiceStr 
       std::string choiceStr_bondCouponType_;

};

} //namespaceFpmlSerialized end
#endif

