// Bond.hpp 
#ifndef FpmlSerialized_Bond_hpp
#define FpmlSerialized_Bond_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class Bond : public ISerialized { 
   public: 
       Bond(TiXmlNode* xmlNode);

       bool isInstrumentId(){return this->instrumentIdIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInstrumentId();


       bool isCouponRate(){return this->couponRateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCouponRate();


       bool isMaturity(){return this->maturityIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMaturity();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


   protected: 
       boost::shared_ptr<XsdTypeToken> instrumentId_;
       
       bool instrumentIdIsNull_;
       boost::shared_ptr<XsdTypeDouble> couponRate_;
       
       bool couponRateIsNull_;
       boost::shared_ptr<XsdTypeDate> maturity_;
       
       bool maturityIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

