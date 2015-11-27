// ExchangeTradedCalculatedPrice.hpp 
#ifndef FpmlSerialized_ExchangeTradedCalculatedPrice_hpp
#define FpmlSerialized_ExchangeTradedCalculatedPrice_hpp

#include <fpml-asset-5-4/ExchangeTraded.hpp>
#include <fpml-shared-5-4/ExchangeId.hpp>

namespace FpmlSerialized {

class ExchangeTradedCalculatedPrice : public ExchangeTraded { 
   public: 
       ExchangeTradedCalculatedPrice(TiXmlNode* xmlNode);

       bool isConstituentExchangeId(){return this->constituentExchangeIdIsNull_;}
       std::vector<boost::shared_ptr<ExchangeId>> getConstituentExchangeId();
      std::string getConstituentExchangeIdIDRef(){return constituentExchangeIdIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ExchangeId>> constituentExchangeId_;
       std::string constituentExchangeIdIDRef_;
       bool constituentExchangeIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif

