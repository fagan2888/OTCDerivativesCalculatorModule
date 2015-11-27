// RequestRetransmission.hpp 
#ifndef FpmlSerialized_RequestRetransmission_hpp
#define FpmlSerialized_RequestRetransmission_hpp

#include <fpml-msg-5-4/NonCorrectableRequestMessage.hpp>
#include <fpml-msg-5-4/PortfolioConstituentReference.hpp>
#include <fpml-msg-5-4/ReportSectionIdentification.hpp>
#include <fpml-shared-5-4/Party.hpp>
#include <fpml-shared-5-4/Account.hpp>

namespace FpmlSerialized {

class RequestRetransmission : public NonCorrectableRequestMessage { 
   public: 
       RequestRetransmission(TiXmlNode* xmlNode);

       bool isPortfolioReference(){return this->portfolioReferenceIsNull_;}
       boost::shared_ptr<PortfolioConstituentReference> getPortfolioReference();
      std::string getPortfolioReferenceIDRef(){return portfolioReferenceIDRef_;}

       bool isReportIdentification(){return this->reportIdentificationIsNull_;}
       boost::shared_ptr<ReportSectionIdentification> getReportIdentification();
      std::string getReportIdentificationIDRef(){return reportIdentificationIDRef_;}

       bool isParty(){return this->partyIsNull_;}
       std::vector<boost::shared_ptr<Party>> getParty();
      std::string getPartyIDRef(){return partyIDRef_;}

       bool isAccount(){return this->accountIsNull_;}
       std::vector<boost::shared_ptr<Account>> getAccount();
      std::string getAccountIDRef(){return accountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!portfolioReferenceIsNull_){
                count += 1;
                str = "portfolioReference" ;
           }
           if(!reportIdentificationIsNull_){
                count += 1;
                str = "reportIdentification" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<PortfolioConstituentReference> portfolioReference_;     //choice
       std::string portfolioReferenceIDRef_;
       bool portfolioReferenceIsNull_;
         boost::shared_ptr<ReportSectionIdentification> reportIdentification_;     //choice
       std::string reportIdentificationIDRef_;
       bool reportIdentificationIsNull_;
       std::vector<boost::shared_ptr<Party>> party_;
       std::string partyIDRef_;
       bool partyIsNull_;
       std::vector<boost::shared_ptr<Account>> account_;
       std::string accountIDRef_;
       bool accountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

