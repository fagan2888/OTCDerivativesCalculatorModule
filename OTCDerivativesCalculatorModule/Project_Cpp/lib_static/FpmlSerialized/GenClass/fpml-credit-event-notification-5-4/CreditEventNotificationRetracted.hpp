// CreditEventNotificationRetracted.hpp 
#ifndef FpmlSerialized_CreditEventNotificationRetracted_hpp
#define FpmlSerialized_CreditEventNotificationRetracted_hpp

#include <fpml-msg-5-4/NonCorrectableRequestMessage.hpp>
#include <fpml-credit-event-notification-5-4/CreditEventNoticeDocument.hpp>
#include <fpml-shared-5-4/Party.hpp>

namespace FpmlSerialized {

class CreditEventNotificationRetracted : public NonCorrectableRequestMessage { 
   public: 
       CreditEventNotificationRetracted(TiXmlNode* xmlNode);

       bool isCreditEventNotice(){return this->creditEventNoticeIsNull_;}
       boost::shared_ptr<CreditEventNoticeDocument> getCreditEventNotice();
      std::string getCreditEventNoticeIDRef(){return creditEventNoticeIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

   protected: 
       boost::shared_ptr<CreditEventNoticeDocument> creditEventNotice_;
       std::string creditEventNoticeIDRef_;
       bool creditEventNoticeIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

