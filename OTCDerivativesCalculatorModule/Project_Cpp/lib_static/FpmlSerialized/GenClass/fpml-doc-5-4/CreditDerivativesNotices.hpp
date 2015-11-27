// CreditDerivativesNotices.hpp 
#ifndef FpmlSerialized_CreditDerivativesNotices_hpp
#define FpmlSerialized_CreditDerivativesNotices_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class CreditDerivativesNotices : public ISerialized { 
   public: 
       CreditDerivativesNotices(TiXmlNode* xmlNode);

       bool isCreditEvent(){return this->creditEventIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getCreditEvent();
      std::string getCreditEventIDRef(){return creditEventIDRef_;}

       bool isPubliclyAvailableInformation(){return this->publiclyAvailableInformationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPubliclyAvailableInformation();
      std::string getPubliclyAvailableInformationIDRef(){return publiclyAvailableInformationIDRef_;}

       bool isPhysicalSettlement(){return this->physicalSettlementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPhysicalSettlement();
      std::string getPhysicalSettlementIDRef(){return physicalSettlementIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> creditEvent_;
       std::string creditEventIDRef_;
       bool creditEventIsNull_;
       boost::shared_ptr<XsdTypeBoolean> publiclyAvailableInformation_;
       std::string publiclyAvailableInformationIDRef_;
       bool publiclyAvailableInformationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> physicalSettlement_;
       std::string physicalSettlementIDRef_;
       bool physicalSettlementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

