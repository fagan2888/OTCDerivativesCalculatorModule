// StrategyComponentIdentification.hpp 
#ifndef FpmlSerialized_StrategyComponentIdentification_hpp
#define FpmlSerialized_StrategyComponentIdentification_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyTradeIdentifierReference.hpp>
#include <fpml-shared-5-4/ProductReference.hpp>

namespace FpmlSerialized {

class StrategyComponentIdentification : public ISerialized { 
   public: 
       StrategyComponentIdentification(TiXmlNode* xmlNode);

       bool isTradeIdentifierReference(){return this->tradeIdentifierReferenceIsNull_;}
       boost::shared_ptr<PartyTradeIdentifierReference> getTradeIdentifierReference();
      std::string getTradeIdentifierReferenceIDRef(){return tradeIdentifierReferenceIDRef_;}

       bool isComponentReference(){return this->componentReferenceIsNull_;}
       boost::shared_ptr<ProductReference> getComponentReference();
      std::string getComponentReferenceIDRef(){return componentReferenceIDRef_;}

   protected: 
       boost::shared_ptr<PartyTradeIdentifierReference> tradeIdentifierReference_;
       std::string tradeIdentifierReferenceIDRef_;
       bool tradeIdentifierReferenceIsNull_;
       boost::shared_ptr<ProductReference> componentReference_;
       std::string componentReferenceIDRef_;
       bool componentReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

