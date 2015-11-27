// Account.hpp 
#ifndef FpmlSerialized_Account_hpp
#define FpmlSerialized_Account_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AccountId.hpp>
#include <fpml-shared-5-4/AccountName.hpp>
#include <fpml-shared-5-4/AccountType.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class Account : public ISerialized { 
   public: 
       Account(TiXmlNode* xmlNode);

       bool isAccountId(){return this->accountIdIsNull_;}
       std::vector<boost::shared_ptr<AccountId>> getAccountId();
      std::string getAccountIdIDRef(){return accountIdIDRef_;}

       bool isAccountName(){return this->accountNameIsNull_;}
       boost::shared_ptr<AccountName> getAccountName();
      std::string getAccountNameIDRef(){return accountNameIDRef_;}

       bool isAccountType(){return this->accountTypeIsNull_;}
       boost::shared_ptr<AccountType> getAccountType();
      std::string getAccountTypeIDRef(){return accountTypeIDRef_;}

       bool isAccountBeneficiary(){return this->accountBeneficiaryIsNull_;}
       boost::shared_ptr<PartyReference> getAccountBeneficiary();
      std::string getAccountBeneficiaryIDRef(){return accountBeneficiaryIDRef_;}

       bool isServicingParty(){return this->servicingPartyIsNull_;}
       boost::shared_ptr<PartyReference> getServicingParty();
      std::string getServicingPartyIDRef(){return servicingPartyIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!accountBeneficiaryIsNull_){
                count += 1;
                str = "accountBeneficiary" ;
           }
           if(!servicingPartyIsNull_){
                count += 1;
                str = "servicingParty" ;
           }
           if(!servicingPartyIsNull_){
                count += 1;
                str = "servicingParty" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       std::vector<boost::shared_ptr<AccountId>> accountId_;
       std::string accountIdIDRef_;
       bool accountIdIsNull_;
       boost::shared_ptr<AccountName> accountName_;
       std::string accountNameIDRef_;
       bool accountNameIsNull_;
       boost::shared_ptr<AccountType> accountType_;
       std::string accountTypeIDRef_;
       bool accountTypeIsNull_;
         boost::shared_ptr<PartyReference> accountBeneficiary_;     //choice
       std::string accountBeneficiaryIDRef_;
       bool accountBeneficiaryIsNull_;
         boost::shared_ptr<PartyReference> servicingParty_;     //choice
       std::string servicingPartyIDRef_;
       bool servicingPartyIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

