// FinalCalculationPeriodDateAdjustment.hpp 
#ifndef FpmlSerialized_FinalCalculationPeriodDateAdjustment_hpp
#define FpmlSerialized_FinalCalculationPeriodDateAdjustment_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/RelevantUnderlyingDateReference.hpp>
#include <fpml-ird-5-4/InterestRateStreamReference.hpp>
#include <fpml-enum-5-4/BusinessDayConventionEnum.hpp>

namespace FpmlSerialized {

class FinalCalculationPeriodDateAdjustment : public ISerialized { 
   public: 
       FinalCalculationPeriodDateAdjustment(TiXmlNode* xmlNode);

       bool isRelevantUnderlyingDateReference(){return this->relevantUnderlyingDateReferenceIsNull_;}
       boost::shared_ptr<RelevantUnderlyingDateReference> getRelevantUnderlyingDateReference();
      std::string getRelevantUnderlyingDateReferenceIDRef(){return relevantUnderlyingDateReferenceIDRef_;}

       bool isSwapStreamReference(){return this->swapStreamReferenceIsNull_;}
       boost::shared_ptr<InterestRateStreamReference> getSwapStreamReference();
      std::string getSwapStreamReferenceIDRef(){return swapStreamReferenceIDRef_;}

       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<BusinessDayConventionEnum> getBusinessDayConvention();
      std::string getBusinessDayConventionIDRef(){return businessDayConventionIDRef_;}

   protected: 
       boost::shared_ptr<RelevantUnderlyingDateReference> relevantUnderlyingDateReference_;
       std::string relevantUnderlyingDateReferenceIDRef_;
       bool relevantUnderlyingDateReferenceIsNull_;
       boost::shared_ptr<InterestRateStreamReference> swapStreamReference_;
       std::string swapStreamReferenceIDRef_;
       bool swapStreamReferenceIsNull_;
       boost::shared_ptr<BusinessDayConventionEnum> businessDayConvention_;
       std::string businessDayConventionIDRef_;
       bool businessDayConventionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

