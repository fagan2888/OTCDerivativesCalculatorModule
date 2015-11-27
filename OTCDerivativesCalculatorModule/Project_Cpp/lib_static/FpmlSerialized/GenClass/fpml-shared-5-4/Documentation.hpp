// Documentation.hpp 
#ifndef FpmlSerialized_Documentation_hpp
#define FpmlSerialized_Documentation_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/MasterAgreement.hpp>
#include <fpml-shared-5-4/MasterConfirmation.hpp>
#include <fpml-shared-5-4/BrokerConfirmation.hpp>
#include <fpml-shared-5-4/ContractualDefinitions.hpp>
#include <fpml-shared-5-4/ContractualTermsSupplement.hpp>
#include <fpml-shared-5-4/ContractualMatrix.hpp>
#include <fpml-shared-5-4/CreditSupportAgreement.hpp>
#include <fpml-shared-5-4/Resource.hpp>

namespace FpmlSerialized {

class Documentation : public ISerialized { 
   public: 
       Documentation(TiXmlNode* xmlNode);

       bool isMasterAgreement(){return this->masterAgreementIsNull_;}
       boost::shared_ptr<MasterAgreement> getMasterAgreement();
      std::string getMasterAgreementIDRef(){return masterAgreementIDRef_;}

       bool isMasterConfirmation(){return this->masterConfirmationIsNull_;}
       boost::shared_ptr<MasterConfirmation> getMasterConfirmation();
      std::string getMasterConfirmationIDRef(){return masterConfirmationIDRef_;}

       bool isBrokerConfirmation(){return this->brokerConfirmationIsNull_;}
       boost::shared_ptr<BrokerConfirmation> getBrokerConfirmation();
      std::string getBrokerConfirmationIDRef(){return brokerConfirmationIDRef_;}

       bool isContractualDefinitions(){return this->contractualDefinitionsIsNull_;}
       std::vector<boost::shared_ptr<ContractualDefinitions>> getContractualDefinitions();
      std::string getContractualDefinitionsIDRef(){return contractualDefinitionsIDRef_;}

       bool isContractualTermsSupplement(){return this->contractualTermsSupplementIsNull_;}
       std::vector<boost::shared_ptr<ContractualTermsSupplement>> getContractualTermsSupplement();
      std::string getContractualTermsSupplementIDRef(){return contractualTermsSupplementIDRef_;}

       bool isContractualMatrix(){return this->contractualMatrixIsNull_;}
       std::vector<boost::shared_ptr<ContractualMatrix>> getContractualMatrix();
      std::string getContractualMatrixIDRef(){return contractualMatrixIDRef_;}

       bool isCreditSupportAgreement(){return this->creditSupportAgreementIsNull_;}
       boost::shared_ptr<CreditSupportAgreement> getCreditSupportAgreement();
      std::string getCreditSupportAgreementIDRef(){return creditSupportAgreementIDRef_;}

       bool isAttachment(){return this->attachmentIsNull_;}
       std::vector<boost::shared_ptr<Resource>> getAttachment();
      std::string getAttachmentIDRef(){return attachmentIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!masterConfirmationIsNull_){
                count += 1;
                str = "masterConfirmation" ;
           }
           if(!brokerConfirmationIsNull_){
                count += 1;
                str = "brokerConfirmation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<MasterAgreement> masterAgreement_;
       std::string masterAgreementIDRef_;
       bool masterAgreementIsNull_;
         boost::shared_ptr<MasterConfirmation> masterConfirmation_;     //choice
       std::string masterConfirmationIDRef_;
       bool masterConfirmationIsNull_;
         boost::shared_ptr<BrokerConfirmation> brokerConfirmation_;     //choice
       std::string brokerConfirmationIDRef_;
       bool brokerConfirmationIsNull_;
       std::vector<boost::shared_ptr<ContractualDefinitions>> contractualDefinitions_;
       std::string contractualDefinitionsIDRef_;
       bool contractualDefinitionsIsNull_;
       std::vector<boost::shared_ptr<ContractualTermsSupplement>> contractualTermsSupplement_;
       std::string contractualTermsSupplementIDRef_;
       bool contractualTermsSupplementIsNull_;
       std::vector<boost::shared_ptr<ContractualMatrix>> contractualMatrix_;
       std::string contractualMatrixIDRef_;
       bool contractualMatrixIsNull_;
       boost::shared_ptr<CreditSupportAgreement> creditSupportAgreement_;
       std::string creditSupportAgreementIDRef_;
       bool creditSupportAgreementIsNull_;
       std::vector<boost::shared_ptr<Resource>> attachment_;
       std::string attachmentIDRef_;
       bool attachmentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

