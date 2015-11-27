// PartyTradeIdentifiers.hpp 
#ifndef FpmlSerialized_PartyTradeIdentifiers_hpp
#define FpmlSerialized_PartyTradeIdentifiers_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>

namespace FpmlSerialized {

class PartyTradeIdentifiers : public ISerialized { 
   public: 
       PartyTradeIdentifiers(TiXmlNode* xmlNode);

       bool isPartyTradeIdentifier(){return this->partyTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getPartyTradeIdentifier();
      std::string getPartyTradeIdentifierIDRef(){return partyTradeIdentifierIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> partyTradeIdentifier_;
       std::string partyTradeIdentifierIDRef_;
       bool partyTradeIdentifierIsNull_;

};

} //namespaceFpmlSerialized end
#endif

