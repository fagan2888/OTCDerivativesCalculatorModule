// Excel_jointProbabilityTrait.hpp 
#ifndef FpmlSerialized_Excel_jointProbabilityTrait_hpp
#define FpmlSerialized_Excel_jointProbabilityTrait_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_jointProbabilityTrait : public ISerialized { 
   public: 
       Excel_jointProbabilityTrait(TiXmlNode* xmlNode);

       bool isNth(){return this->nthIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNth();


   protected: 
       boost::shared_ptr<XsdTypeToken> nth_;
       
       bool nthIsNull_;

};

} //namespaceFpmlSerialized end
#endif

