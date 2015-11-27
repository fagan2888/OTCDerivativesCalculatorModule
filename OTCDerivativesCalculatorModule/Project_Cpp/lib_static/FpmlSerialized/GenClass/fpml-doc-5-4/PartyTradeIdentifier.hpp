// PartyTradeIdentifier.hpp 
#ifndef FpmlSerialized_PartyTradeIdentifier_hpp
#define FpmlSerialized_PartyTradeIdentifier_hpp

#include <fpml-doc-5-4/TradeIdentifier.hpp>
#include <fpml-doc-5-4/LinkId.hpp>
#include <fpml-doc-5-4/TradeIdentifier.hpp>
#include <fpml-doc-5-4/ProductComponentIdentifier.hpp>

namespace FpmlSerialized {

class PartyTradeIdentifier : public TradeIdentifier { 
   public: 
       PartyTradeIdentifier(TiXmlNode* xmlNode);

       bool isLinkId(){return this->linkIdIsNull_;}
       std::vector<boost::shared_ptr<LinkId>> getLinkId();
      std::string getLinkIdIDRef(){return linkIdIDRef_;}

       bool isAllocationTradeId(){return this->allocationTradeIdIsNull_;}
       std::vector<boost::shared_ptr<TradeIdentifier>> getAllocationTradeId();
      std::string getAllocationTradeIdIDRef(){return allocationTradeIdIDRef_;}

       bool isBlockTradeId(){return this->blockTradeIdIsNull_;}
       boost::shared_ptr<TradeIdentifier> getBlockTradeId();
      std::string getBlockTradeIdIDRef(){return blockTradeIdIDRef_;}

       bool isOriginatingTradeId(){return this->originatingTradeIdIsNull_;}
       std::vector<boost::shared_ptr<TradeIdentifier>> getOriginatingTradeId();
      std::string getOriginatingTradeIdIDRef(){return originatingTradeIdIDRef_;}

       bool isProductComponentIdentifier(){return this->productComponentIdentifierIsNull_;}
       std::vector<boost::shared_ptr<ProductComponentIdentifier>> getProductComponentIdentifier();
      std::string getProductComponentIdentifierIDRef(){return productComponentIdentifierIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<LinkId>> linkId_;
       std::string linkIdIDRef_;
       bool linkIdIsNull_;
       std::vector<boost::shared_ptr<TradeIdentifier>> allocationTradeId_;
       std::string allocationTradeIdIDRef_;
       bool allocationTradeIdIsNull_;
       boost::shared_ptr<TradeIdentifier> blockTradeId_;
       std::string blockTradeIdIDRef_;
       bool blockTradeIdIsNull_;
       std::vector<boost::shared_ptr<TradeIdentifier>> originatingTradeId_;
       std::string originatingTradeIdIDRef_;
       bool originatingTradeIdIsNull_;
       std::vector<boost::shared_ptr<ProductComponentIdentifier>> productComponentIdentifier_;
       std::string productComponentIdentifierIDRef_;
       bool productComponentIdentifierIsNull_;

};

} //namespaceFpmlSerialized end
#endif

