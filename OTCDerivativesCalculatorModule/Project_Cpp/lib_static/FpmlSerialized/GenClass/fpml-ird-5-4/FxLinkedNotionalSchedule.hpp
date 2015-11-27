// FxLinkedNotionalSchedule.hpp 
#ifndef FpmlSerialized_FxLinkedNotionalSchedule_hpp
#define FpmlSerialized_FxLinkedNotionalSchedule_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/NotionalReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-shared-5-4/RelativeDateOffset.hpp>
#include <fpml-shared-5-4/FxSpotRateSource.hpp>

namespace FpmlSerialized {

class FxLinkedNotionalSchedule : public ISerialized { 
   public: 
       FxLinkedNotionalSchedule(TiXmlNode* xmlNode);

       bool isConstantNotionalScheduleReference(){return this->constantNotionalScheduleReferenceIsNull_;}
       boost::shared_ptr<NotionalReference> getConstantNotionalScheduleReference();
      std::string getConstantNotionalScheduleReferenceIDRef(){return constantNotionalScheduleReferenceIDRef_;}

       bool isInitialValue(){return this->initialValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getInitialValue();
      std::string getInitialValueIDRef(){return initialValueIDRef_;}

       bool isVaryingNotionalCurrency(){return this->varyingNotionalCurrencyIsNull_;}
       boost::shared_ptr<Currency> getVaryingNotionalCurrency();
      std::string getVaryingNotionalCurrencyIDRef(){return varyingNotionalCurrencyIDRef_;}

       bool isVaryingNotionalFixingDates(){return this->varyingNotionalFixingDatesIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getVaryingNotionalFixingDates();
      std::string getVaryingNotionalFixingDatesIDRef(){return varyingNotionalFixingDatesIDRef_;}

       bool isFxSpotRateSource(){return this->fxSpotRateSourceIsNull_;}
       boost::shared_ptr<FxSpotRateSource> getFxSpotRateSource();
      std::string getFxSpotRateSourceIDRef(){return fxSpotRateSourceIDRef_;}

       bool isVaryingNotionalInterimExchangePaymentDates(){return this->varyingNotionalInterimExchangePaymentDatesIsNull_;}
       boost::shared_ptr<RelativeDateOffset> getVaryingNotionalInterimExchangePaymentDates();
      std::string getVaryingNotionalInterimExchangePaymentDatesIDRef(){return varyingNotionalInterimExchangePaymentDatesIDRef_;}

   protected: 
       boost::shared_ptr<NotionalReference> constantNotionalScheduleReference_;
       std::string constantNotionalScheduleReferenceIDRef_;
       bool constantNotionalScheduleReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> initialValue_;
       std::string initialValueIDRef_;
       bool initialValueIsNull_;
       boost::shared_ptr<Currency> varyingNotionalCurrency_;
       std::string varyingNotionalCurrencyIDRef_;
       bool varyingNotionalCurrencyIsNull_;
       boost::shared_ptr<RelativeDateOffset> varyingNotionalFixingDates_;
       std::string varyingNotionalFixingDatesIDRef_;
       bool varyingNotionalFixingDatesIsNull_;
       boost::shared_ptr<FxSpotRateSource> fxSpotRateSource_;
       std::string fxSpotRateSourceIDRef_;
       bool fxSpotRateSourceIsNull_;
       boost::shared_ptr<RelativeDateOffset> varyingNotionalInterimExchangePaymentDates_;
       std::string varyingNotionalInterimExchangePaymentDatesIDRef_;
       bool varyingNotionalInterimExchangePaymentDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

