// StandardProduct.hpp 
#ifndef FpmlSerialized_StandardProduct_hpp
#define FpmlSerialized_StandardProduct_hpp

#include <fpml-shared-5-4/Product.hpp>
#include <fpml-shared-5-4/CashflowNotional.hpp>
#include <fpml-asset-5-4/BasicQuotation.hpp>

namespace FpmlSerialized {

class StandardProduct : public Product { 
   public: 
       StandardProduct(TiXmlNode* xmlNode);

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<CashflowNotional> getNotional();
      std::string getNotionalIDRef(){return notionalIDRef_;}

       bool isQuote(){return this->quoteIsNull_;}
       std::vector<boost::shared_ptr<BasicQuotation>> getQuote();
      std::string getQuoteIDRef(){return quoteIDRef_;}

   protected: 
       boost::shared_ptr<CashflowNotional> notional_;
       std::string notionalIDRef_;
       bool notionalIsNull_;
       std::vector<boost::shared_ptr<BasicQuotation>> quote_;
       std::string quoteIDRef_;
       bool quoteIsNull_;

};

} //namespaceFpmlSerialized end
#endif

