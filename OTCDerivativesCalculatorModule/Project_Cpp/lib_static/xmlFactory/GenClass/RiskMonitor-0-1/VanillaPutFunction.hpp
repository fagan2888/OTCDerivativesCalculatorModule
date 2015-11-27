// VanillaPutFunction.hpp 
#ifndef FpmlSerialized_VanillaPutFunction_hpp
#define FpmlSerialized_VanillaPutFunction_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class VanillaPutFunction : public ISerialized { 
   public: 
       VanillaPutFunction(TiXmlNode* xmlNode);

       bool isPartiRate(){return this->partiRateIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getPartiRate();


       bool isStrike(){return this->strikeIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getStrike();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getSpread();


   protected: 
       boost::shared_ptr<XsdTypeDouble> partiRate_;
       
       bool partiRateIsNull_;
       boost::shared_ptr<XsdTypeDouble> strike_;
       
       bool strikeIsNull_;
       boost::shared_ptr<XsdTypeDouble> spread_;
       
       bool spreadIsNull_;

};

} //namespaceFpmlSerialized end
#endif

