// NthDefaultTrait.hpp 
#ifndef FpmlSerialized_NthDefaultTrait_hpp
#define FpmlSerialized_NthDefaultTrait_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeInt.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class NthDefaultTrait : public ISerialized { 
   public: 
       NthDefaultTrait(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isNth(){return this->nthIsNull_;}
       boost::shared_ptr<XsdTypeInt> getNth();


       bool isCorrelation(){return this->correlationIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCorrelation();


   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeInt> nth_;
       
       bool nthIsNull_;
       boost::shared_ptr<XsdTypeDouble> correlation_;
       
       bool correlationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

