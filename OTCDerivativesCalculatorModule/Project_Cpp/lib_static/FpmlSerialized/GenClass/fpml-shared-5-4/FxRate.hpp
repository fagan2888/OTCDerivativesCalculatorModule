// FxRate.hpp 
#ifndef FpmlSerialized_FxRate_hpp
#define FpmlSerialized_FxRate_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class FxRate : public ISerialized { 
   public: 
       FxRate(TiXmlNode* xmlNode);

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

       bool isRate(){return this->rateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getRate();
      std::string getRateIDRef(){return rateIDRef_;}

   protected: 
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;
       boost::shared_ptr<XsdTypeDecimal> rate_;
       std::string rateIDRef_;
       bool rateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

