// TradeMaturity.hpp 
#ifndef FpmlSerialized_TradeMaturity_hpp
#define FpmlSerialized_TradeMaturity_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class TradeMaturity : public ISerialized { 
   public: 
       TradeMaturity(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> tradeIdentifier_;
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
       boost::shared_ptr<XsdTypeDate> date_;
       std::string dateIDRef_;
       bool dateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

