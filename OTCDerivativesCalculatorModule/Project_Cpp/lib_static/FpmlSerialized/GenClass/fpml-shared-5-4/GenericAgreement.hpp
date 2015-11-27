// GenericAgreement.hpp 
#ifndef FpmlSerialized_GenericAgreement_hpp
#define FpmlSerialized_GenericAgreement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AgreementType.hpp>
#include <fpml-shared-5-4/AgreementVersion.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <fpml-shared-5-4/GoverningLaw.hpp>

namespace FpmlSerialized {

class GenericAgreement : public ISerialized { 
   public: 
       GenericAgreement(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<AgreementType> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isVersion(){return this->versionIsNull_;}
       boost::shared_ptr<AgreementVersion> getVersion();
      std::string getVersionIDRef(){return versionIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       bool isAmendmentDate(){return this->amendmentDateIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDate>> getAmendmentDate();
      std::string getAmendmentDateIDRef(){return amendmentDateIDRef_;}

       bool isGoverningLaw(){return this->governingLawIsNull_;}
       boost::shared_ptr<GoverningLaw> getGoverningLaw();
      std::string getGoverningLawIDRef(){return governingLawIDRef_;}

   protected: 
       boost::shared_ptr<AgreementType> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<AgreementVersion> version_;
       std::string versionIDRef_;
       bool versionIsNull_;
       boost::shared_ptr<XsdTypeDate> date_;
       std::string dateIDRef_;
       bool dateIsNull_;
       std::vector<boost::shared_ptr<XsdTypeDate>> amendmentDate_;
       std::string amendmentDateIDRef_;
       bool amendmentDateIsNull_;
       boost::shared_ptr<GoverningLaw> governingLaw_;
       std::string governingLawIDRef_;
       bool governingLawIsNull_;

};

} //namespaceFpmlSerialized end
#endif

