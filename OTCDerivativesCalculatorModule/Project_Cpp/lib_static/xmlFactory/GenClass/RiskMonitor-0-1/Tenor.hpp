// Tenor.hpp 
#ifndef FpmlSerialized_Tenor_hpp
#define FpmlSerialized_Tenor_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Tenor : public ISerialized { 
   public: 
       Tenor(TiXmlNode* xmlNode);

       bool isPeriodMultiplier(){return this->periodMultiplierIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getPeriodMultiplier();


       bool isPeriod(){return this->periodIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPeriod();


   protected: 
       boost::shared_ptr<XsdTypeInteger> periodMultiplier_;
       
       bool periodMultiplierIsNull_;
       boost::shared_ptr<XsdTypeToken> period_;
       
       bool periodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

