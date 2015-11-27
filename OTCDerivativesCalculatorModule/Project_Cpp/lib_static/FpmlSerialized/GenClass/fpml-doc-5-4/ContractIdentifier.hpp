// ContractIdentifier.hpp 
#ifndef FpmlSerialized_ContractIdentifier_hpp
#define FpmlSerialized_ContractIdentifier_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-doc-5-4/ContractId.hpp>
#include <fpml-doc-5-4/VersionedContractId.hpp>

namespace FpmlSerialized {

class ContractIdentifier : public ISerialized { 
   public: 
       ContractIdentifier(TiXmlNode* xmlNode);

       bool isPartyReference(){return this->partyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getPartyReference();
      std::string getPartyReferenceIDRef(){return partyReferenceIDRef_;}

       bool isContractId(){return this->contractIdIsNull_;}
       std::vector<boost::shared_ptr<ContractId>> getContractId();
      std::string getContractIdIDRef(){return contractIdIDRef_;}

       bool isVersionedContractId(){return this->versionedContractIdIsNull_;}
       std::vector<boost::shared_ptr<VersionedContractId>> getVersionedContractId();
      std::string getVersionedContractIdIDRef(){return versionedContractIdIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!contractIdIsNull_){
                count += 1;
                str = "contractId" ;
           }
           if(!versionedContractIdIsNull_){
                count += 1;
                str = "versionedContractId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<PartyReference> partyReference_;
       std::string partyReferenceIDRef_;
       bool partyReferenceIsNull_;
         std::vector<boost::shared_ptr<ContractId>> contractId_;     //choice
       std::string contractIdIDRef_;
       bool contractIdIsNull_;
         std::vector<boost::shared_ptr<VersionedContractId>> versionedContractId_;     //choice
       std::string versionedContractIdIDRef_;
       bool versionedContractIdIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

