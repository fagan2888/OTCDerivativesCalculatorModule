// MaximumOper1D.hpp 
#ifndef FpmlSerialized_MaximumOper1D_hpp
#define FpmlSerialized_MaximumOper1D_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class MaximumOper1D : public ISerialized { 
   public: 
       MaximumOper1D(TiXmlNode* xmlNode);

       bool isConstValue(){return this->constValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getConstValue();


       bool isRefName(){return this->refNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefName();


   protected: 
       boost::shared_ptr<XsdTypeToken> constValue_;
       
       bool constValueIsNull_;
       boost::shared_ptr<XsdTypeToken> refName_;
       
       bool refNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

