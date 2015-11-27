// AssetValuation.hpp 
#ifndef FpmlSerialized_AssetValuation_hpp
#define FpmlSerialized_AssetValuation_hpp

#include <fpml-riskdef-5-4/Valuation.hpp>
#include <fpml-valuation-5-4/Quotation.hpp>
#include <fpml-shared-5-4/FxRate.hpp>

namespace FpmlSerialized {

class AssetValuation : public Valuation { 
   public: 
       AssetValuation(TiXmlNode* xmlNode);

       bool isQuote(){return this->quoteIsNull_;}
       std::vector<boost::shared_ptr<Quotation>> getQuote();
      std::string getQuoteIDRef(){return quoteIDRef_;}

       bool isFxRate(){return this->fxRateIsNull_;}
       std::vector<boost::shared_ptr<FxRate>> getFxRate();
      std::string getFxRateIDRef(){return fxRateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<Quotation>> quote_;
       std::string quoteIDRef_;
       bool quoteIsNull_;
       std::vector<boost::shared_ptr<FxRate>> fxRate_;
       std::string fxRateIDRef_;
       bool fxRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

