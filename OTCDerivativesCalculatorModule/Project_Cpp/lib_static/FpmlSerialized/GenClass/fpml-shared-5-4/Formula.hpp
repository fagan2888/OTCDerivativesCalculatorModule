// Formula.hpp 
#ifndef FpmlSerialized_Formula_hpp
#define FpmlSerialized_Formula_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/Math.hpp>
#include <fpml-shared-5-4/FormulaComponent.hpp>

namespace FpmlSerialized {

class Formula : public ISerialized { 
   public: 
       Formula(TiXmlNode* xmlNode);

       bool isFormulaDescription(){return this->formulaDescriptionIsNull_;}
       boost::shared_ptr<XsdTypeString> getFormulaDescription();
      std::string getFormulaDescriptionIDRef(){return formulaDescriptionIDRef_;}

       bool isMath(){return this->mathIsNull_;}
       boost::shared_ptr<Math> getMath();
      std::string getMathIDRef(){return mathIDRef_;}

       bool isFormulaComponent(){return this->formulaComponentIsNull_;}
       std::vector<boost::shared_ptr<FormulaComponent>> getFormulaComponent();
      std::string getFormulaComponentIDRef(){return formulaComponentIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> formulaDescription_;
       std::string formulaDescriptionIDRef_;
       bool formulaDescriptionIsNull_;
       boost::shared_ptr<Math> math_;
       std::string mathIDRef_;
       bool mathIsNull_;
       std::vector<boost::shared_ptr<FormulaComponent>> formulaComponent_;
       std::string formulaComponentIDRef_;
       bool formulaComponentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

