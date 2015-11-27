// InterestRateIndex.hpp 
#ifndef FpmlSerialized_InterestRateIndex_hpp
#define FpmlSerialized_InterestRateIndex_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class InterestRateIndex : public ISerialized { 
   public: 
       InterestRateIndex(TiXmlNode* xmlNode);

       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTenor();


   protected: 
       boost::shared_ptr<XsdTypeToken> tenor_;
       
       bool tenorIsNull_;

};

} //namespaceFpmlSerialized end
#endif

