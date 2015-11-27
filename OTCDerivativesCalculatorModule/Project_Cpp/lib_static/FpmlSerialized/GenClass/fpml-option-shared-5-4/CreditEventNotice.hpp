// CreditEventNotice.hpp 
#ifndef FpmlSerialized_CreditEventNotice_hpp
#define FpmlSerialized_CreditEventNotice_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/NotifyingParty.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>
#include <fpml-option-shared-5-4/PubliclyAvailableInformation.hpp>

namespace FpmlSerialized {

class CreditEventNotice : public ISerialized { 
   public: 
       CreditEventNotice(TiXmlNode* xmlNode);

       bool isNotifyingParty(){return this->notifyingPartyIsNull_;}
       boost::shared_ptr<NotifyingParty> getNotifyingParty();
      std::string getNotifyingPartyIDRef(){return notifyingPartyIDRef_;}

       bool isBusinessCenter(){return this->businessCenterIsNull_;}
       boost::shared_ptr<BusinessCenter> getBusinessCenter();
      std::string getBusinessCenterIDRef(){return businessCenterIDRef_;}

       bool isPubliclyAvailableInformation(){return this->publiclyAvailableInformationIsNull_;}
       boost::shared_ptr<PubliclyAvailableInformation> getPubliclyAvailableInformation();
      std::string getPubliclyAvailableInformationIDRef(){return publiclyAvailableInformationIDRef_;}

   protected: 
       boost::shared_ptr<NotifyingParty> notifyingParty_;
       std::string notifyingPartyIDRef_;
       bool notifyingPartyIsNull_;
       boost::shared_ptr<BusinessCenter> businessCenter_;
       std::string businessCenterIDRef_;
       bool businessCenterIsNull_;
       boost::shared_ptr<PubliclyAvailableInformation> publiclyAvailableInformation_;
       std::string publiclyAvailableInformationIDRef_;
       bool publiclyAvailableInformationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

