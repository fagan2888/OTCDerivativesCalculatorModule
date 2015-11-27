// InstrumentTradePricing.hpp 
#ifndef FpmlSerialized_InstrumentTradePricing_hpp
#define FpmlSerialized_InstrumentTradePricing_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/BasicQuotation.hpp>

namespace FpmlSerialized {

class InstrumentTradePricing : public ISerialized { 
   public: 
       InstrumentTradePricing(TiXmlNode* xmlNode);

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

