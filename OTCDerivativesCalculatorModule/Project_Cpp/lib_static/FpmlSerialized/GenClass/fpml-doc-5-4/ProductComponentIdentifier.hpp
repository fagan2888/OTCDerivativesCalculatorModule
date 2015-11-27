// ProductComponentIdentifier.hpp 
#ifndef FpmlSerialized_ProductComponentIdentifier_hpp
#define FpmlSerialized_ProductComponentIdentifier_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ProductReference.hpp>
#include <fpml-doc-5-4/IssuerId.hpp>
#include <fpml-doc-5-4/TradeId.hpp>

namespace FpmlSerialized {

class ProductComponentIdentifier : public ISerialized { 
   public: 
       ProductComponentIdentifier(TiXmlNode* xmlNode);

       bool isPremiumProductReference(){return this->premiumProductReferenceIsNull_;}
       boost::shared_ptr<ProductReference> getPremiumProductReference();
      std::string getPremiumProductReferenceIDRef(){return premiumProductReferenceIDRef_;}

       bool isIssuer(){return this->issuerIsNull_;}
       boost::shared_ptr<IssuerId> getIssuer();
      std::string getIssuerIDRef(){return issuerIDRef_;}

       bool isTradeId(){return this->tradeIdIsNull_;}
       boost::shared_ptr<TradeId> getTradeId();
      std::string getTradeIdIDRef(){return tradeIdIDRef_;}

   protected: 
       boost::shared_ptr<ProductReference> premiumProductReference_;
       std::string premiumProductReferenceIDRef_;
       bool premiumProductReferenceIsNull_;
       boost::shared_ptr<IssuerId> issuer_;
       std::string issuerIDRef_;
       bool issuerIsNull_;
       boost::shared_ptr<TradeId> tradeId_;
       std::string tradeIdIDRef_;
       bool tradeIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif

