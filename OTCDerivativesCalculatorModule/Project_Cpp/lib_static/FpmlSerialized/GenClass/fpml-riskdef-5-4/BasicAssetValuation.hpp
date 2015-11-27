// BasicAssetValuation.hpp 
#ifndef FpmlSerialized_BasicAssetValuation_hpp
#define FpmlSerialized_BasicAssetValuation_hpp

#include <fpml-riskdef-5-4/Valuation.hpp>
#include <fpml-asset-5-4/BasicQuotation.hpp>

namespace FpmlSerialized {

class BasicAssetValuation : public Valuation { 
   public: 
       BasicAssetValuation(TiXmlNode* xmlNode);

       bool isQuote(){return this->quoteIsNull_;}
       std::vector<boost::shared_ptr<BasicQuotation>> getQuote();
      std::string getQuoteIDRef(){return quoteIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<BasicQuotation>> quote_;
       std::string quoteIDRef_;
       bool quoteIsNull_;

};

} //namespaceFpmlSerialized end
#endif

