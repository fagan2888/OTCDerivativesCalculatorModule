// DeClear.hpp 
#ifndef FpmlSerialized_DeClear_hpp
#define FpmlSerialized_DeClear_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-business-events-5-4/DeclearReason.hpp>

namespace FpmlSerialized {

class DeClear : public ISerialized { 
   public: 
       DeClear(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

       bool isReason(){return this->reasonIsNull_;}
       boost::shared_ptr<DeclearReason> getReason();
      std::string getReasonIDRef(){return reasonIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> tradeIdentifier_;
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
       boost::shared_ptr<XsdTypeDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;
       boost::shared_ptr<DeclearReason> reason_;
       std::string reasonIDRef_;
       bool reasonIsNull_;

};

} //namespaceFpmlSerialized end
#endif

