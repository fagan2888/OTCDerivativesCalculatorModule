// VersionedContractId.hpp 
#ifndef FpmlSerialized_VersionedContractId_hpp
#define FpmlSerialized_VersionedContractId_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/ContractId.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>

namespace FpmlSerialized {

class VersionedContractId : public ISerialized { 
   public: 
       VersionedContractId(TiXmlNode* xmlNode);

       bool isContractId(){return this->contractIdIsNull_;}
       boost::shared_ptr<ContractId> getContractId();
      std::string getContractIdIDRef(){return contractIdIDRef_;}

       bool isVersion(){return this->versionIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getVersion();
      std::string getVersionIDRef(){return versionIDRef_;}

       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getEffectiveDate();
      std::string getEffectiveDateIDRef(){return effectiveDateIDRef_;}

   protected: 
       boost::shared_ptr<ContractId> contractId_;
       std::string contractIdIDRef_;
       bool contractIdIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> version_;
       std::string versionIDRef_;
       bool versionIsNull_;
       boost::shared_ptr<IdentifiedDate> effectiveDate_;
       std::string effectiveDateIDRef_;
       bool effectiveDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

