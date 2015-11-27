// TradeHeader.hpp 
#ifndef FpmlSerialized_TradeHeader_hpp
#define FpmlSerialized_TradeHeader_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <fpml-doc-5-4/PartyTradeInformation.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>

namespace FpmlSerialized {

class TradeHeader : public ISerialized { 
   public: 
       TradeHeader(TiXmlNode* xmlNode);

       bool isPartyTradeIdentifier(){return this->partyTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getPartyTradeIdentifier();
      std::string getPartyTradeIdentifierIDRef(){return partyTradeIdentifierIDRef_;}

       bool isPartyTradeInformation(){return this->partyTradeInformationIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeInformation>> getPartyTradeInformation();
      std::string getPartyTradeInformationIDRef(){return partyTradeInformationIDRef_;}

       bool isTradeDate(){return this->tradeDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getTradeDate();
      std::string getTradeDateIDRef(){return tradeDateIDRef_;}

       bool isClearedDate(){return this->clearedDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getClearedDate();
      std::string getClearedDateIDRef(){return clearedDateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> partyTradeIdentifier_;
       std::string partyTradeIdentifierIDRef_;
       bool partyTradeIdentifierIsNull_;
       std::vector<boost::shared_ptr<PartyTradeInformation>> partyTradeInformation_;
       std::string partyTradeInformationIDRef_;
       bool partyTradeInformationIsNull_;
       boost::shared_ptr<IdentifiedDate> tradeDate_;
       std::string tradeDateIDRef_;
       bool tradeDateIsNull_;
       boost::shared_ptr<IdentifiedDate> clearedDate_;
       std::string clearedDateIDRef_;
       bool clearedDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

