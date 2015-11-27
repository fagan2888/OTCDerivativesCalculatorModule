// ExchangeTradedContract.hpp 
#ifndef FpmlSerialized_ExchangeTradedContract_hpp
#define FpmlSerialized_ExchangeTradedContract_hpp

#include <fpml-asset-5-4/ExchangeTraded.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class ExchangeTradedContract : public ExchangeTraded { 
   public: 
       ExchangeTradedContract(TiXmlNode* xmlNode);

       bool isMultiplier(){return this->multiplierIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getMultiplier();
      std::string getMultiplierIDRef(){return multiplierIDRef_;}

       bool isContractReference(){return this->contractReferenceIsNull_;}
       boost::shared_ptr<XsdTypeString> getContractReference();
      std::string getContractReferenceIDRef(){return contractReferenceIDRef_;}

       bool isExpirationDate(){return this->expirationDateIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDate();
      std::string getExpirationDateIDRef(){return expirationDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> multiplier_;
       std::string multiplierIDRef_;
       bool multiplierIsNull_;
       boost::shared_ptr<XsdTypeString> contractReference_;
       std::string contractReferenceIDRef_;
       bool contractReferenceIsNull_;
       boost::shared_ptr<AdjustableOrRelativeDate> expirationDate_;
       std::string expirationDateIDRef_;
       bool expirationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

