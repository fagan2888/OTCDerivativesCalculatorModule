// Excel_interestRate.hpp 
#ifndef FpmlSerialized_Excel_interestRate_hpp
#define FpmlSerialized_Excel_interestRate_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_interestRate : public ISerialized { 
   public: 
       Excel_interestRate(TiXmlNode* xmlNode);

       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isRateType(){return this->rateTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRateType();


       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTenor();


       bool isLegTenor(){return this->legTenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLegTenor();


       bool isLinkedCurve(){return this->linkedCurveIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLinkedCurve();


       bool isBasePrice(){return this->basePriceIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBasePrice();


   protected: 
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> rateType_;
       
       bool rateTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<XsdTypeToken> legTenor_;
       
       bool legTenorIsNull_;
       boost::shared_ptr<XsdTypeToken> linkedCurve_;
       
       bool linkedCurveIsNull_;
       boost::shared_ptr<XsdTypeToken> basePrice_;
       
       bool basePriceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

