// Function.hpp 
#ifndef FpmlSerialized_Function_hpp
#define FpmlSerialized_Function_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class Function : public ISerialized { 
   public: 
       Function(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isTruefalse(){return this->truefalseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getTruefalse();
      std::string getTruefalseIDRef(){return truefalseIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeBoolean> truefalse_;
       std::string truefalseIDRef_;
       bool truefalseIsNull_;

};

} //namespaceFpmlSerialized end
#endif

