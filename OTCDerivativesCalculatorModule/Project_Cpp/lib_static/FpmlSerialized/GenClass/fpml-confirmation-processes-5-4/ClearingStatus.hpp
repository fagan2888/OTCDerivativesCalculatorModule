// ClearingStatus.hpp 
#ifndef FpmlSerialized_ClearingStatus_hpp
#define FpmlSerialized_ClearingStatus_hpp

#include <fpml-msg-5-4/NotificationMessage.hpp>
#include <fpml-business-events-5-4/ClearingStatusItem.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class ClearingStatus : public NotificationMessage { 
   public: 
       ClearingStatus(TiXmlNode* xmlNode);

       bool isClearingStatusItem(){return this->clearingStatusItemIsNull_;}
       boost::shared_ptr<ClearingStatusItem> getClearingStatusItem();
      std::string getClearingStatusItemIDRef(){return clearingStatusItemIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       boost::shared_ptr<ClearingStatusItem> clearingStatusItem_;
       std::string clearingStatusItemIDRef_;
       bool clearingStatusItemIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

