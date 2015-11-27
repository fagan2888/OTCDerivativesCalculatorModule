// MasterAgreement.hpp 
#ifndef FpmlSerialized_MasterAgreement_hpp
#define FpmlSerialized_MasterAgreement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/MasterAgreementType.hpp>
#include <fpml-shared-5-4/MasterAgreementVersion.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class MasterAgreement : public ISerialized { 
   public: 
       MasterAgreement(TiXmlNode* xmlNode);

       bool isMasterAgreementType(){return this->masterAgreementTypeIsNull_;}
       boost::shared_ptr<MasterAgreementType> getMasterAgreementType();
      std::string getMasterAgreementTypeIDRef(){return masterAgreementTypeIDRef_;}

       bool isMasterAgreementVersion(){return this->masterAgreementVersionIsNull_;}
       boost::shared_ptr<MasterAgreementVersion> getMasterAgreementVersion();
      std::string getMasterAgreementVersionIDRef(){return masterAgreementVersionIDRef_;}

       bool isMasterAgreementDate(){return this->masterAgreementDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMasterAgreementDate();
      std::string getMasterAgreementDateIDRef(){return masterAgreementDateIDRef_;}

   protected: 
       boost::shared_ptr<MasterAgreementType> masterAgreementType_;
       std::string masterAgreementTypeIDRef_;
       bool masterAgreementTypeIsNull_;
       boost::shared_ptr<MasterAgreementVersion> masterAgreementVersion_;
       std::string masterAgreementVersionIDRef_;
       bool masterAgreementVersionIsNull_;
       boost::shared_ptr<XsdTypeDate> masterAgreementDate_;
       std::string masterAgreementDateIDRef_;
       bool masterAgreementDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

