// TermDepositFeatures.hpp 
#ifndef FpmlSerialized_TermDepositFeatures_hpp
#define FpmlSerialized_TermDepositFeatures_hpp

#include <ISerialized.hpp>
#include <fpml-fx-5-4/DualCurrencyFeature.hpp>

namespace FpmlSerialized {

class TermDepositFeatures : public ISerialized { 
   public: 
       TermDepositFeatures(TiXmlNode* xmlNode);

       bool isDualCurrency(){return this->dualCurrencyIsNull_;}
       boost::shared_ptr<DualCurrencyFeature> getDualCurrency();
      std::string getDualCurrencyIDRef(){return dualCurrencyIDRef_;}

   protected: 
       boost::shared_ptr<DualCurrencyFeature> dualCurrency_;
       std::string dualCurrencyIDRef_;
       bool dualCurrencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

