// Compounding.hpp 
#ifndef FpmlSerialized_Compounding_hpp
#define FpmlSerialized_Compounding_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/CompoundingMethodEnum.hpp>
#include <fpml-eq-shared-5-4/CompoundingRate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/AdjustableRelativeOrPeriodicDates2.hpp>

namespace FpmlSerialized {

class Compounding : public ISerialized { 
   public: 
       Compounding(TiXmlNode* xmlNode);

       bool isCompoundingMethod(){return this->compoundingMethodIsNull_;}
       boost::shared_ptr<CompoundingMethodEnum> getCompoundingMethod();
      std::string getCompoundingMethodIDRef(){return compoundingMethodIDRef_;}

       bool isCompoundingRate(){return this->compoundingRateIsNull_;}
       boost::shared_ptr<CompoundingRate> getCompoundingRate();
      std::string getCompoundingRateIDRef(){return compoundingRateIDRef_;}

       bool isCompoundingSpread(){return this->compoundingSpreadIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCompoundingSpread();
      std::string getCompoundingSpreadIDRef(){return compoundingSpreadIDRef_;}

       bool isCompoundingDates(){return this->compoundingDatesIsNull_;}
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> getCompoundingDates();
      std::string getCompoundingDatesIDRef(){return compoundingDatesIDRef_;}

   protected: 
       boost::shared_ptr<CompoundingMethodEnum> compoundingMethod_;
       std::string compoundingMethodIDRef_;
       bool compoundingMethodIsNull_;
       boost::shared_ptr<CompoundingRate> compoundingRate_;
       std::string compoundingRateIDRef_;
       bool compoundingRateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> compoundingSpread_;
       std::string compoundingSpreadIDRef_;
       bool compoundingSpreadIsNull_;
       boost::shared_ptr<AdjustableRelativeOrPeriodicDates2> compoundingDates_;
       std::string compoundingDatesIDRef_;
       bool compoundingDatesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

