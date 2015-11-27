// Excel_upInOutCall.hpp 
#ifndef FpmlSerialized_Excel_upInOutCall_hpp
#define FpmlSerialized_Excel_upInOutCall_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_upInOutCall : public ISerialized { 
   public: 
       Excel_upInOutCall(TiXmlNode* xmlNode);

       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isExerciseDate(){return this->exerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExerciseDate();


       bool isInOut(){return this->inOutIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInOut();


       bool isUnderlyingCode(){return this->underlyingCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderlyingCode();


       bool isBaseUnderlyingValue(){return this->baseUnderlyingValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseUnderlyingValue();


       bool isBaseCoupon(){return this->baseCouponIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseCoupon();


       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getStrike();


       bool isStrikeValue(){return this->strikeValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getStrikeValue();


       bool isPartiRate(){return this->partiRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPartiRate();


       bool isBarrier(){return this->barrierIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBarrier();


       bool isBarrierValue(){return this->barrierValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBarrierValue();


       bool isRebateCoupon(){return this->rebateCouponIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRebateCoupon();


       bool isRebateCouponValue(){return this->rebateCouponValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRebateCouponValue();


       bool isObservationStartDate(){return this->observationStartDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getObservationStartDate();


       bool isObservationEndDate(){return this->observationEndDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getObservationEndDate();


   protected: 
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> exerciseDate_;
       
       bool exerciseDateIsNull_;
       boost::shared_ptr<XsdTypeToken> inOut_;
       
       bool inOutIsNull_;
       boost::shared_ptr<XsdTypeToken> underlyingCode_;
       
       bool underlyingCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> baseUnderlyingValue_;
       
       bool baseUnderlyingValueIsNull_;
       boost::shared_ptr<XsdTypeToken> baseCoupon_;
       
       bool baseCouponIsNull_;
       boost::shared_ptr<XsdTypeToken> strike_;
       
       bool strikeIsNull_;
       boost::shared_ptr<XsdTypeToken> strikeValue_;
       
       bool strikeValueIsNull_;
       boost::shared_ptr<XsdTypeToken> partiRate_;
       
       bool partiRateIsNull_;
       boost::shared_ptr<XsdTypeToken> barrier_;
       
       bool barrierIsNull_;
       boost::shared_ptr<XsdTypeToken> barrierValue_;
       
       bool barrierValueIsNull_;
       boost::shared_ptr<XsdTypeToken> rebateCoupon_;
       
       bool rebateCouponIsNull_;
       boost::shared_ptr<XsdTypeToken> rebateCouponValue_;
       
       bool rebateCouponValueIsNull_;
       boost::shared_ptr<XsdTypeToken> observationStartDate_;
       
       bool observationStartDateIsNull_;
       boost::shared_ptr<XsdTypeToken> observationEndDate_;
       
       bool observationEndDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

