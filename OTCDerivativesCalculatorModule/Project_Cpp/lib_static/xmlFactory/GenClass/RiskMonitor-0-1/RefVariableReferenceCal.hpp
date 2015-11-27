// RefVariableReferenceCal.hpp 
#ifndef FpmlSerialized_RefVariableReferenceCal_hpp
#define FpmlSerialized_RefVariableReferenceCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class RefVariableReferenceCal : public ISerialized { 
   public: 
       RefVariableReferenceCal(TiXmlNode* xmlNode);

       bool isRefName(){return this->refNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefName();


   protected: 
       boost::shared_ptr<XsdTypeToken> refName_;
       
       bool refNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

