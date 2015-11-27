// FxFixing.hpp 
#ifndef FpmlSerialized_FxFixing_hpp
#define FpmlSerialized_FxFixing_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/FxSpotRateSource.hpp>

namespace FpmlSerialized {

class FxFixing : public ISerialized { 
   public: 
       FxFixing(TiXmlNode* xmlNode);

       bool isQuotedCurrencyPair(){return this->quotedCurrencyPairIsNull_;}
       boost::shared_ptr<QuotedCurrencyPair> getQuotedCurrencyPair();
      std::string getQuotedCurrencyPairIDRef(){return quotedCurrencyPairIDRef_;}

       bool isFixingDate(){return this->fixingDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getFixingDate();
      std::string getFixingDateIDRef(){return fixingDateIDRef_;}

       bool isFxSpotRateSource(){return this->fxSpotRateSourceIsNull_;}
       boost::shared_ptr<FxSpotRateSource> getFxSpotRateSource();
      std::string getFxSpotRateSourceIDRef(){return fxSpotRateSourceIDRef_;}

   protected: 
       boost::shared_ptr<QuotedCurrencyPair> quotedCurrencyPair_;
       std::string quotedCurrencyPairIDRef_;
       bool quotedCurrencyPairIsNull_;
       boost::shared_ptr<XsdTypeDate> fixingDate_;
       std::string fixingDateIDRef_;
       bool fixingDateIsNull_;
       boost::shared_ptr<FxSpotRateSource> fxSpotRateSource_;
       std::string fxSpotRateSourceIDRef_;
       bool fxSpotRateSourceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

