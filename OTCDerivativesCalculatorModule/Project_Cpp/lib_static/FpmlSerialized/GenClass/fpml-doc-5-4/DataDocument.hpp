// DataDocument.hpp 
#ifndef FpmlSerialized_DataDocument_hpp
#define FpmlSerialized_DataDocument_hpp

#include <fpml-doc-5-4/Document.hpp>
#include <fpml-doc-5-4/Validation.hpp>
#include <fpml-shared-5-4/OnBehalfOf.hpp>
#include <fpml-shared-5-4/OriginatingEvent.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <fpml-doc-5-4/Portfolio.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class DataDocument : public Document { 
   public: 
       DataDocument(TiXmlNode* xmlNode);

       bool isValidation(){return this->validationIsNull_;}
       std::vector<boost::shared_ptr<Validation>> getValidation();
      std::string getValidationIDRef(){return validationIDRef_;}

       bool isOnBehalfOf(){return this->onBehalfOfIsNull_;}
       boost::shared_ptr<OnBehalfOf> getOnBehalfOf();
      std::string getOnBehalfOfIDRef(){return onBehalfOfIDRef_;}

       bool isOriginatingEvent(){return this->originatingEventIsNull_;}
       boost::shared_ptr<OriginatingEvent> getOriginatingEvent();
      std::string getOriginatingEventIDRef(){return originatingEventIDRef_;}

       bool isTrade(){return this->tradeIsNull_;}
       std::vector<boost::shared_ptr<Trade>> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isPortfolio(){return this->portfolioIsNull_;}
       std::vector<boost::shared_ptr<Portfolio>> getPortfolio();
      std::string getPortfolioIDRef(){return portfolioIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<Validation>> validation_;
       std::string validationIDRef_;
       bool validationIsNull_;
       boost::shared_ptr<OnBehalfOf> onBehalfOf_;
       std::string onBehalfOfIDRef_;
       bool onBehalfOfIsNull_;
       boost::shared_ptr<OriginatingEvent> originatingEvent_;
       std::string originatingEventIDRef_;
       bool originatingEventIsNull_;
       std::vector<boost::shared_ptr<Trade>> trade_;
       std::string tradeIDRef_;
       bool tradeIsNull_;
       std::vector<boost::shared_ptr<Portfolio>> portfolio_;
       std::string portfolioIDRef_;
       bool portfolioIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

