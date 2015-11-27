// CreditEventNotification.hpp 
#ifndef FpmlSerialized_CreditEventNotification_hpp
#define FpmlSerialized_CreditEventNotification_hpp

#include <fpml-msg-5-4/CorrectableRequestMessage.hpp>
#include <fpml-credit-event-notification-5-4/CreditEventNoticeDocument.hpp>
#include <fpml-shared-5-4/Party.hpp>

namespace FpmlSerialized {

class CreditEventNotification : public CorrectableRequestMessage { 
   public: 
       CreditEventNotification(TiXmlNode* xmlNode);

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

