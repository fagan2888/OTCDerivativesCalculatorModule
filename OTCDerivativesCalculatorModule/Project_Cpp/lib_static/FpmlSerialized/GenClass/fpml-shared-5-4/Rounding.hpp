// Rounding.hpp 
#ifndef FpmlSerialized_Rounding_hpp
#define FpmlSerialized_Rounding_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/RoundingDirectionEnum.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>

namespace FpmlSerialized {

class Rounding : public ISerialized { 
   public: 
       Rounding(TiXmlNode* xmlNode);

       bool isRoundingDirection(){return this->roundingDirectionIsNull_;}
       boost::shared_ptr<RoundingDirectionEnum> getRoundingDirection();
      std::string getRoundingDirectionIDRef(){return roundingDirectionIDRef_;}

       bool isPrecision(){return this->precisionIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getPrecision();
      std::string getPrecisionIDRef(){return precisionIDRef_;}

   protected: 
       boost::shared_ptr<RoundingDirectionEnum> roundingDirection_;
       std::string roundingDirectionIDRef_;
       bool roundingDirectionIsNull_;
       boost::shared_ptr<XsdTypeNonNegativeInteger> precision_;
       std::string precisionIDRef_;
       bool precisionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

