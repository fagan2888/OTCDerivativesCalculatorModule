// EventStatusResponse.hpp 
#ifndef FpmlSerialized_EventStatusResponse_hpp
#define FpmlSerialized_EventStatusResponse_hpp

#include <fpml-msg-5-4/ResponseMessage.hpp>
#include <fpml-msg-5-4/EventStatusItem.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class EventStatusResponse : public ResponseMessage { 
   public: 
       EventStatusResponse(TiXmlNode* xmlNode);

       bool isStatusItem(){return this->statusItemIsNull_;}
       std::vector<boost::shared_ptr<EventStatusItem>> getStatusItem();
      std::string getStatusItemIDRef(){return statusItemIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<EventStatusItem>> statusItem_;
       std::string statusItemIDRef_;
       bool statusItemIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

