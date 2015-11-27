// SensitivitySet.hpp 
#ifndef FpmlSerialized_SensitivitySet_hpp
#define FpmlSerialized_SensitivitySet_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-riskdef-5-4/SensitivitySetDefinitionReference.hpp>
#include <fpml-valuation-5-4/Sensitivity.hpp>

namespace FpmlSerialized {

class SensitivitySet : public ISerialized { 
   public: 
       SensitivitySet(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isDefinitionReference(){return this->definitionReferenceIsNull_;}
       boost::shared_ptr<SensitivitySetDefinitionReference> getDefinitionReference();
      std::string getDefinitionReferenceIDRef(){return definitionReferenceIDRef_;}

       bool isSensitivity(){return this->sensitivityIsNull_;}
       std::vector<boost::shared_ptr<Sensitivity>> getSensitivity();
      std::string getSensitivityIDRef(){return sensitivityIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<SensitivitySetDefinitionReference> definitionReference_;
       std::string definitionReferenceIDRef_;
       bool definitionReferenceIsNull_;
       std::vector<boost::shared_ptr<Sensitivity>> sensitivity_;
       std::string sensitivityIDRef_;
       bool sensitivityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

