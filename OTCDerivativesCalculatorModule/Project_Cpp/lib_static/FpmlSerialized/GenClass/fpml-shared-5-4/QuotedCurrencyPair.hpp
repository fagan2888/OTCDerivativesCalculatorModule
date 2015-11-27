// QuotedCurrencyPair.hpp 
#ifndef FpmlSerialized_QuotedCurrencyPair_hpp
#define FpmlSerialized_QuotedCurrencyPair_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Currency.hpp>
#include <fpml-enum-5-4/QuoteBasisEnum.hpp>

namespace FpmlSerialized {

class QuotedCurrencyPair : public ISerialized { 
   public: 
       QuotedCurrencyPair(TiXmlNode* xmlNode);

       bool isCurrency1(){return this->currency1IsNull_;}
       boost::shared_ptr<Currency> getCurrency1();
      std::string getCurrency1IDRef(){return currency1IDRef_;}

       bool isCurrency2(){return this->currency2IsNull_;}
       boost::shared_ptr<Currency> getCurrency2();
      std::string getCurrency2IDRef(){return currency2IDRef_;}

       bool isQuoteBasis(){return this->quoteBasisIsNull_;}
       boost::shared_ptr<QuoteBasisEnum> getQuoteBasis();
      std::string getQuoteBasisIDRef(){return quoteBasisIDRef_;}

   protected: 
       boost::shared_ptr<Currency> currency1_;
       std::string currency1IDRef_;
       bool currency1IsNull_;
       boost::shared_ptr<Currency> currency2_;
       std::string currency2IDRef_;
       bool currency2IsNull_;
       boost::shared_ptr<QuoteBasisEnum> quoteBasis_;
       std::string quoteBasisIDRef_;
       bool quoteBasisIsNull_;

};

} //namespaceFpmlSerialized end
#endif

