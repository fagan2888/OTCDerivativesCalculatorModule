// FixedRateType.hpp 
#ifndef FpmlSerialized_FixedRateType_hpp
#define FpmlSerialized_FixedRateType_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class FixedRateType : public ISerialized { 
   public: 
       FixedRateType(TiXmlNode* xmlNode);

       bool isFixedRate(){return this->fixedRateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFixedRate();


   protected: 
       boost::shared_ptr<XsdTypeToken> fixedRate_;
       
       bool fixedRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

