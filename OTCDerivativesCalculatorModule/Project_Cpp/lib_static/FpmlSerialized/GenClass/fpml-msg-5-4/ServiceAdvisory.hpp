// ServiceAdvisory.hpp 
#ifndef FpmlSerialized_ServiceAdvisory_hpp
#define FpmlSerialized_ServiceAdvisory_hpp

#include <ISerialized.hpp>
#include <fpml-msg-5-4/ServiceAdvisoryCategory.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>

namespace FpmlSerialized {

class ServiceAdvisory : public ISerialized { 
   public: 
       ServiceAdvisory(TiXmlNode* xmlNode);

       bool isCategory(){return this->categoryIsNull_;}
       boost::shared_ptr<ServiceAdvisoryCategory> getCategory();
      std::string getCategoryIDRef(){return categoryIDRef_;}

       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeString> getDescription();
      std::string getDescriptionIDRef(){return descriptionIDRef_;}

       bool isEffectiveFrom(){return this->effectiveFromIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getEffectiveFrom();
      std::string getEffectiveFromIDRef(){return effectiveFromIDRef_;}

       bool isEffectiveTo(){return this->effectiveToIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getEffectiveTo();
      std::string getEffectiveToIDRef(){return effectiveToIDRef_;}

   protected: 
       boost::shared_ptr<ServiceAdvisoryCategory> category_;
       std::string categoryIDRef_;
       bool categoryIsNull_;
       boost::shared_ptr<XsdTypeString> description_;
       std::string descriptionIDRef_;
       bool descriptionIsNull_;
       boost::shared_ptr<XsdTypeDateTime> effectiveFrom_;
       std::string effectiveFromIDRef_;
       bool effectiveFromIsNull_;
       boost::shared_ptr<XsdTypeDateTime> effectiveTo_;
       std::string effectiveToIDRef_;
       bool effectiveToIsNull_;

};

} //namespaceFpmlSerialized end
#endif

