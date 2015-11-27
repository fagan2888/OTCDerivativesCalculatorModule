// FxCurve.hpp 
#ifndef FpmlSerialized_FxCurve_hpp
#define FpmlSerialized_FxCurve_hpp

#include <fpml-shared-5-4/PricingStructure.hpp>
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>

namespace FpmlSerialized {

class FxCurve : public PricingStructure { 
   public: 
       FxCurve(TiXmlNode* xmlNode);

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

   protected: 
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;

};

} //namespaceFpmlSerialized end
#endif

