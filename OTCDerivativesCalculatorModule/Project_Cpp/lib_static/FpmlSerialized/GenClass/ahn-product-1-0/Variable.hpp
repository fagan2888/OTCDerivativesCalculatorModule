// Variable.hpp 
#ifndef FpmlSerialized_Variable_hpp
#define FpmlSerialized_Variable_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Variable : public ISerialized { 
   public: 
       Variable(TiXmlNode* xmlNode);

       bool isSymbolName(){return this->symbolNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSymbolName();
      std::string getSymbolNameIDRef(){return symbolNameIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> symbolName_;
       std::string symbolNameIDRef_;
       bool symbolNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

