// Discounting.hpp 
#ifndef FpmlSerialized_Discounting_hpp
#define FpmlSerialized_Discounting_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/DiscountingTypeEnum.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/DayCountFraction.hpp>

namespace FpmlSerialized {

class Discounting : public ISerialized { 
   public: 
       Discounting(TiXmlNode* xmlNode);

       bool isDiscountingType(){return this->discountingTypeIsNull_;}
       boost::shared_ptr<DiscountingTypeEnum> getDiscountingType();
      std::string getDiscountingTypeIDRef(){return discountingTypeIDRef_;}

       bool isDiscountRate(){return this->discountRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getDiscountRate();
      std::string getDiscountRateIDRef(){return discountRateIDRef_;}

       bool isDiscountRateDayCountFraction(){return this->discountRateDayCountFractionIsNull_;}
       boost::shared_ptr<DayCountFraction> getDiscountRateDayCountFraction();
      std::string getDiscountRateDayCountFractionIDRef(){return discountRateDayCountFractionIDRef_;}

   protected: 
       boost::shared_ptr<DiscountingTypeEnum> discountingType_;
       std::string discountingTypeIDRef_;
       bool discountingTypeIsNull_;
       boost::shared_ptr<XsdTypeDecimal> discountRate_;
       std::string discountRateIDRef_;
       bool discountRateIsNull_;
       boost::shared_ptr<DayCountFraction> discountRateDayCountFraction_;
       std::string discountRateDayCountFractionIDRef_;
       bool discountRateDayCountFractionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

