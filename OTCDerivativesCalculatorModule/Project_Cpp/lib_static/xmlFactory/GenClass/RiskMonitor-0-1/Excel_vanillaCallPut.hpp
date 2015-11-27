// Excel_vanillaCallPut.hpp 
#ifndef FpmlSerialized_Excel_vanillaCallPut_hpp
#define FpmlSerialized_Excel_vanillaCallPut_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_vanillaCallPut : public ISerialized { 
   public: 
       Excel_vanillaCallPut(TiXmlNode* xmlNode);

       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isExerciseDate(){return this->exerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExerciseDate();


       bool isUnderlyingCode(){return this->underlyingCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderlyingCode();


       bool isBaseUnderlyingValue(){return this->baseUnderlyingValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseUnderlyingValue();


       bool isCallPut(){return this->callPutIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCallPut();


       bool isBaseCoupon(){return this->baseCouponIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBaseCoupon();


       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getStrike();


       bool isStrikeValue(){return this->strikeValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getStrikeValue();


       bool isPartiRate(){return this->partiRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPartiRate();


   protected: 
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> exerciseDate_;
       
       bool exerciseDateIsNull_;
       boost::shared_ptr<XsdTypeToken> underlyingCode_;
       
       bool underlyingCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> baseUnderlyingValue_;
       
       bool baseUnderlyingValueIsNull_;
       boost::shared_ptr<XsdTypeToken> callPut_;
       
       bool callPutIsNull_;
       boost::shared_ptr<XsdTypeToken> baseCoupon_;
       
       bool baseCouponIsNull_;
       boost::shared_ptr<XsdTypeToken> strike_;
       
       bool strikeIsNull_;
       boost::shared_ptr<XsdTypeToken> strikeValue_;
       
       bool strikeValueIsNull_;
       boost::shared_ptr<XsdTypeToken> partiRate_;
       
       bool partiRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

