// Frequency.hpp 
#ifndef FpmlSerialized_Frequency_hpp
#define FpmlSerialized_Frequency_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-enum-5-4/PeriodExtendedEnum.hpp>

namespace FpmlSerialized {

class Frequency : public ISerialized { 
   public: 
       Frequency(TiXmlNode* xmlNode);

       bool isPeriodMultiplier(){return this->periodMultiplierIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getPeriodMultiplier();
      std::string getPeriodMultiplierIDRef(){return periodMultiplierIDRef_;}

       bool isPeriod(){return this->periodIsNull_;}
       boost::shared_ptr<PeriodExtendedEnum> getPeriod();
      std::string getPeriodIDRef(){return periodIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> periodMultiplier_;
       std::string periodMultiplierIDRef_;
       bool periodMultiplierIsNull_;
       boost::shared_ptr<PeriodExtendedEnum> period_;
       std::string periodIDRef_;
       bool periodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

