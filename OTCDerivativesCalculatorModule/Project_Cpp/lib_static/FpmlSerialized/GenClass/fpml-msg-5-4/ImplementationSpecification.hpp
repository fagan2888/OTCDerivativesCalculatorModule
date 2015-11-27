// ImplementationSpecification.hpp 
#ifndef FpmlSerialized_ImplementationSpecification_hpp
#define FpmlSerialized_ImplementationSpecification_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <fpml-msg-5-4/ImplementationSpecificationVersion.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class ImplementationSpecification : public ISerialized { 
   public: 
       ImplementationSpecification(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isVersion(){return this->versionIsNull_;}
       boost::shared_ptr<ImplementationSpecificationVersion> getVersion();
      std::string getVersionIDRef(){return versionIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeNormalizedString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<ImplementationSpecificationVersion> version_;
       std::string versionIDRef_;
       bool versionIsNull_;
       boost::shared_ptr<XsdTypeDate> date_;
       std::string dateIDRef_;
       bool dateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

