// EndUserExceptionDeclaration.hpp 
#ifndef FpmlSerialized_EndUserExceptionDeclaration_hpp
#define FpmlSerialized_EndUserExceptionDeclaration_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/CreditDocument.hpp>
#include <fpml-doc-5-4/OrganizationCharacteristic.hpp>
#include <fpml-doc-5-4/TransactionCharacteristic.hpp>
#include <fpml-doc-5-4/SupervisorRegistration.hpp>

namespace FpmlSerialized {

class EndUserExceptionDeclaration : public ISerialized { 
   public: 
       EndUserExceptionDeclaration(TiXmlNode* xmlNode);

       bool isCreditDocument(){return this->creditDocumentIsNull_;}
       std::vector<boost::shared_ptr<CreditDocument>> getCreditDocument();
      std::string getCreditDocumentIDRef(){return creditDocumentIDRef_;}

       bool isOrganizationCharacteristic(){return this->organizationCharacteristicIsNull_;}
       std::vector<boost::shared_ptr<OrganizationCharacteristic>> getOrganizationCharacteristic();
      std::string getOrganizationCharacteristicIDRef(){return organizationCharacteristicIDRef_;}

       bool isTransactionCharacteristic(){return this->transactionCharacteristicIsNull_;}
       std::vector<boost::shared_ptr<TransactionCharacteristic>> getTransactionCharacteristic();
      std::string getTransactionCharacteristicIDRef(){return transactionCharacteristicIDRef_;}

       bool isSupervisorRegistration(){return this->supervisorRegistrationIsNull_;}
       std::vector<boost::shared_ptr<SupervisorRegistration>> getSupervisorRegistration();
      std::string getSupervisorRegistrationIDRef(){return supervisorRegistrationIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<CreditDocument>> creditDocument_;
       std::string creditDocumentIDRef_;
       bool creditDocumentIsNull_;
       std::vector<boost::shared_ptr<OrganizationCharacteristic>> organizationCharacteristic_;
       std::string organizationCharacteristicIDRef_;
       bool organizationCharacteristicIsNull_;
       std::vector<boost::shared_ptr<TransactionCharacteristic>> transactionCharacteristic_;
       std::string transactionCharacteristicIDRef_;
       bool transactionCharacteristicIsNull_;
       std::vector<boost::shared_ptr<SupervisorRegistration>> supervisorRegistration_;
       std::string supervisorRegistrationIDRef_;
       bool supervisorRegistrationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

