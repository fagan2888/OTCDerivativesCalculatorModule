// BestFitTrade.hpp 
#ifndef FpmlSerialized_BestFitTrade_hpp
#define FpmlSerialized_BestFitTrade_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/TradeIdentifier.hpp>
#include <fpml-doc-5-4/TradeDifference.hpp>

namespace FpmlSerialized {

class BestFitTrade : public ISerialized { 
   public: 
       BestFitTrade(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       boost::shared_ptr<TradeIdentifier> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isDifferences(){return this->differencesIsNull_;}
       std::vector<boost::shared_ptr<TradeDifference>> getDifferences();
      std::string getDifferencesIDRef(){return differencesIDRef_;}

   protected: 
       boost::shared_ptr<TradeIdentifier> tradeIdentifier_;
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
       std::vector<boost::shared_ptr<TradeDifference>> differences_;
       std::string differencesIDRef_;
       bool differencesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

