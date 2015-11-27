// Excel_multiAsset_digitalCallPut.hpp 
#ifndef FpmlSerialized_Excel_multiAsset_digitalCallPut_hpp
#define FpmlSerialized_Excel_multiAsset_digitalCallPut_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcID.hpp>

namespace FpmlSerialized {

class Excel_multiAsset_digitalCallPut : public ISerialized { 
   public: 
       Excel_multiAsset_digitalCallPut(TiXmlNode* xmlNode);

       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isExerciseDate(){return this->exerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExerciseDate();


       bool isCallPut(){return this->callPutIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCallPut();


       bool isBaseUnderlyingValue(){return this->baseUnderlyingValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseUnderlyingValue();


       bool isBaseCoupon(){return this->baseCouponIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseCoupon();


       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getStrike();


       bool isStrikeValue(){return this->strikeValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getStrikeValue();


       bool isCoupon(){return this->couponIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCoupon();


       bool isCouponValue(){return this->couponValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCouponValue();


       bool isExcel_underlyingCalcID(){return this->excel_underlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcID> getExcel_underlyingCalcID();


   protected: 
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> exerciseDate_;
       
       bool exerciseDateIsNull_;
       boost::shared_ptr<XsdTypeToken> callPut_;
       
       bool callPutIsNull_;
       boost::shared_ptr<XsdTypeToken> baseUnderlyingValue_;
       
       bool baseUnderlyingValueIsNull_;
       boost::shared_ptr<XsdTypeToken> baseCoupon_;
       
       bool baseCouponIsNull_;
       boost::shared_ptr<XsdTypeToken> strike_;
       
       bool strikeIsNull_;
       boost::shared_ptr<XsdTypeToken> strikeValue_;
       
       bool strikeValueIsNull_;
       boost::shared_ptr<XsdTypeToken> coupon_;
       
       bool couponIsNull_;
       boost::shared_ptr<XsdTypeToken> couponValue_;
       
       bool couponValueIsNull_;
       boost::shared_ptr<Excel_underlyingCalcID> excel_underlyingCalcID_;
       
       bool excel_underlyingCalcIDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

