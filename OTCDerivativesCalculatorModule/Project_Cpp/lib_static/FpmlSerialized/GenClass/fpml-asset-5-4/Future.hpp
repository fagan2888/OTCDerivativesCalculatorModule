// Future.hpp 
#ifndef FpmlSerialized_Future_hpp
#define FpmlSerialized_Future_hpp

#include <fpml-asset-5-4/ExchangeTraded.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class Future : public ExchangeTraded { 
   public: 
       Future(TiXmlNode* xmlNode);

       bool isMultiplier(){return this->multiplierIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getMultiplier();
      std::string getMultiplierIDRef(){return multiplierIDRef_;}

       bool isFutureContractReference(){return this->futureContractReferenceIsNull_;}
       boost::shared_ptr<XsdTypeString> getFutureContractReference();
      std::string getFutureContractReferenceIDRef(){return futureContractReferenceIDRef_;}

       bool isMaturity(){return this->maturityIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMaturity();
      std::string getMaturityIDRef(){return maturityIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> multiplier_;
       std::string multiplierIDRef_;
       bool multiplierIsNull_;
       boost::shared_ptr<XsdTypeString> futureContractReference_;
       std::string futureContractReferenceIDRef_;
       bool futureContractReferenceIsNull_;
       boost::shared_ptr<XsdTypeDate> maturity_;
       std::string maturityIDRef_;
       bool maturityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

