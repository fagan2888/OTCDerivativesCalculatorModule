// VersionedTradeId.hpp 
#ifndef FpmlSerialized_VersionedTradeId_hpp
#define FpmlSerialized_VersionedTradeId_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/TradeId.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>

namespace FpmlSerialized {

class VersionedTradeId : public ISerialized { 
   public: 
       VersionedTradeId(TiXmlNode* xmlNode);

       bool isTradeId(){return this->tradeIdIsNull_;}
       boost::shared_ptr<TradeId> getTradeId();
      std::string getTradeIdIDRef(){return tradeIdIDRef_;}

       bool isVersion(){return this->versionIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getVersion();
      std::string getVersionIDRef(){return versionIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

   protected: 
       boost::shared_ptr<TradeId> tradeId_;
       std::string tradeIdIDRef_;
       bool tradeIdIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> version_;
       std::string versionIDRef_;
       bool versionIsNull_;
       boost::shared_ptr<IdentifiedDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

