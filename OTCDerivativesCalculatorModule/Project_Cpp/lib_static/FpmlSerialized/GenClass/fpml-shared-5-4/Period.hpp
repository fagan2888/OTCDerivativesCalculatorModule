// Period.hpp 
#ifndef FpmlSerialized_Period_hpp
#define FpmlSerialized_Period_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <fpml-enum-5-4/PeriodEnum.hpp>

namespace FpmlSerialized {

class Period : public ISerialized { 
   public: 
       Period(TiXmlNode* xmlNode);

       bool isPeriodMultiplier(){return this->periodMultiplierIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getPeriodMultiplier();
      std::string getPeriodMultiplierIDRef(){return periodMultiplierIDRef_;}

       bool isPeriod(){return this->periodIsNull_;}
       boost::shared_ptr<PeriodEnum> getPeriod();
      std::string getPeriodIDRef(){return periodIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeInteger> periodMultiplier_;
       std::string periodMultiplierIDRef_;
       bool periodMultiplierIsNull_;
       boost::shared_ptr<PeriodEnum> period_;
       std::string periodIDRef_;
       bool periodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

