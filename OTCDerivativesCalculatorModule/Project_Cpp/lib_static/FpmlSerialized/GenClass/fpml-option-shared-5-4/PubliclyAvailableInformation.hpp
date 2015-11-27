// PubliclyAvailableInformation.hpp 
#ifndef FpmlSerialized_PubliclyAvailableInformation_hpp
#define FpmlSerialized_PubliclyAvailableInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class PubliclyAvailableInformation : public ISerialized { 
   public: 
       PubliclyAvailableInformation(TiXmlNode* xmlNode);

       bool isStandardPublicSources(){return this->standardPublicSourcesIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getStandardPublicSources();
      std::string getStandardPublicSourcesIDRef(){return standardPublicSourcesIDRef_;}

       bool isPublicSource(){return this->publicSourceIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeString>> getPublicSource();
      std::string getPublicSourceIDRef(){return publicSourceIDRef_;}

       bool isSpecifiedNumber(){return this->specifiedNumberIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getSpecifiedNumber();
      std::string getSpecifiedNumberIDRef(){return specifiedNumberIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> standardPublicSources_;
       std::string standardPublicSourcesIDRef_;
       bool standardPublicSourcesIsNull_;
       std::vector<boost::shared_ptr<XsdTypeString>> publicSource_;
       std::string publicSourceIDRef_;
       bool publicSourceIsNull_;
       boost::shared_ptr<XsdTypePositiveInteger> specifiedNumber_;
       std::string specifiedNumberIDRef_;
       bool specifiedNumberIsNull_;

};

} //namespaceFpmlSerialized end
#endif

