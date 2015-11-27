// FormulaComponent.hpp 
#ifndef FpmlSerialized_FormulaComponent_hpp
#define FpmlSerialized_FormulaComponent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/Formula.hpp>

namespace FpmlSerialized {

class Formula;

class FormulaComponent : public ISerialized { 
   public: 
       FormulaComponent(TiXmlNode* xmlNode);

       bool isComponentDescription(){return this->componentDescriptionIsNull_;}
       boost::shared_ptr<XsdTypeString> getComponentDescription();
      std::string getComponentDescriptionIDRef(){return componentDescriptionIDRef_;}

       bool isFormula(){return this->formulaIsNull_;}
       boost::shared_ptr<Formula> getFormula();
      std::string getFormulaIDRef(){return formulaIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> componentDescription_;
       std::string componentDescriptionIDRef_;
       bool componentDescriptionIsNull_;
       boost::shared_ptr<Formula> formula_;
       std::string formulaIDRef_;
       bool formulaIsNull_;

};

} //namespaceFpmlSerialized end
#endif

