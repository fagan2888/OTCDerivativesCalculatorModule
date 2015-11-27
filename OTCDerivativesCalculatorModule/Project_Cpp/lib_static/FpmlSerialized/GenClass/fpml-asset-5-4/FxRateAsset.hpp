// FxRateAsset.hpp 
#ifndef FpmlSerialized_FxRateAsset_hpp
#define FpmlSerialized_FxRateAsset_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <fpml-shared-5-4/FxSpotRateSource.hpp>

namespace FpmlSerialized {

class FxRateAsset : public UnderlyingAsset { 
   public: 
       FxRateAsset(TiXmlNode* xmlNode);

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

       bool isRateSource(){return this->rateSourceIsNull_;}
       boost::shared_ptr<FxSpotRateSource> getRateSource();
      std::string getRateSourceIDRef(){return rateSourceIDRef_;}

   protected: 
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;
       boost::shared_ptr<FxSpotRateSource> rateSource_;
       std::string rateSourceIDRef_;
       bool rateSourceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

