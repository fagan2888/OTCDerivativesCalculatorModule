// MinimumTran.hpp 
#ifndef FpmlSerialized_MinimumTran_hpp
#define FpmlSerialized_MinimumTran_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <ahn-product-1-0/VariableValue.hpp>

namespace FpmlSerialized {

class MinimumTran : public ISerialized { 
   public: 
       MinimumTran(TiXmlNode* xmlNode);

       bool isSymbolName(){return this->symbolNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSymbolName();
      std::string getSymbolNameIDRef(){return symbolNameIDRef_;}

       bool isVariable(){return this->variableIsNull_;}
       std::vector<boost::shared_ptr<VariableValue>> getVariable();
      std::string getVariableIDRef(){return variableIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> symbolName_;
       std::string symbolNameIDRef_;
       bool symbolNameIsNull_;
       std::vector<boost::shared_ptr<VariableValue>> variable_;
       std::string variableIDRef_;
       bool variableIsNull_;

};

} //namespaceFpmlSerialized end
#endif

