// ExchangeTradedFund.hpp 
#ifndef FpmlSerialized_ExchangeTradedFund_hpp
#define FpmlSerialized_ExchangeTradedFund_hpp

#include <fpml-asset-5-4/ExchangeTradedCalculatedPrice.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class ExchangeTradedFund : public ExchangeTradedCalculatedPrice { 
   public: 
       ExchangeTradedFund(TiXmlNode* xmlNode);

       bool isFundManager(){return this->fundManagerIsNull_;}
       boost::shared_ptr<XsdTypeString> getFundManager();
      std::string getFundManagerIDRef(){return fundManagerIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> fundManager_;
       std::string fundManagerIDRef_;
       bool fundManagerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

