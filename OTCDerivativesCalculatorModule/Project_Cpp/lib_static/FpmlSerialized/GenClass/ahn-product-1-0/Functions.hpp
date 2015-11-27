// Functions.hpp 
#ifndef FpmlSerialized_Functions_hpp
#define FpmlSerialized_Functions_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/Function.hpp>

namespace FpmlSerialized {

class Functions : public ISerialized { 
   public: 
       Functions(TiXmlNode* xmlNode);

       bool isFunction(){return this->functionIsNull_;}
       std::vector<boost::shared_ptr<Function>> getFunction();
      std::string getFunctionIDRef(){return functionIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<Function>> function_;
       std::string functionIDRef_;
       bool functionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

