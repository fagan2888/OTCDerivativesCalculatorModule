// Excel_greekUnderlying.hpp 
#ifndef FpmlSerialized_Excel_greekUnderlying_hpp
#define FpmlSerialized_Excel_greekUnderlying_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_greekUnderlying : public ISerialized { 
   public: 
       Excel_greekUnderlying(TiXmlNode* xmlNode);

       bool isUnderlyingName(){return this->underlyingNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderlyingName();


       bool isUnderlyingValue(){return this->underlyingValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderlyingValue();


       bool isBasePrice(){return this->basePriceIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBasePrice();


       bool isVolatility(){return this->volatilityIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVolatility();


       bool isPertubation_h(){return this->pertubation_hIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPertubation_h();


       bool isDelta(){return this->deltaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDelta();


       bool isGamma(){return this->gammaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGamma();


       bool isVega(){return this->vegaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getVega();


   protected: 
       boost::shared_ptr<XsdTypeToken> underlyingName_;
       
       bool underlyingNameIsNull_;
       boost::shared_ptr<XsdTypeToken> underlyingValue_;
       
       bool underlyingValueIsNull_;
       boost::shared_ptr<XsdTypeToken> basePrice_;
       
       bool basePriceIsNull_;
       boost::shared_ptr<XsdTypeToken> volatility_;
       
       bool volatilityIsNull_;
       boost::shared_ptr<XsdTypeToken> pertubation_h_;
       
       bool pertubation_hIsNull_;
       boost::shared_ptr<XsdTypeToken> delta_;
       
       bool deltaIsNull_;
       boost::shared_ptr<XsdTypeToken> gamma_;
       
       bool gammaIsNull_;
       boost::shared_ptr<XsdTypeToken> vega_;
       
       bool vegaIsNull_;

};

} //namespaceFpmlSerialized end
#endif

