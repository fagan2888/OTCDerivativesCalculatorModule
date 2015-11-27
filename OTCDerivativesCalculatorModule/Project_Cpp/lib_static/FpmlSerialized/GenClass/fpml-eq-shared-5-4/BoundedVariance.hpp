// BoundedVariance.hpp 
#ifndef FpmlSerialized_BoundedVariance_hpp
#define FpmlSerialized_BoundedVariance_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/RealisedVarianceMethodEnum.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class BoundedVariance : public ISerialized { 
   public: 
       BoundedVariance(TiXmlNode* xmlNode);

       bool isRealisedVarianceMethod(){return this->realisedVarianceMethodIsNull_;}
       boost::shared_ptr<RealisedVarianceMethodEnum> getRealisedVarianceMethod();
      std::string getRealisedVarianceMethodIDRef(){return realisedVarianceMethodIDRef_;}

       bool isDaysInRangeAdjustment(){return this->daysInRangeAdjustmentIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDaysInRangeAdjustment();
      std::string getDaysInRangeAdjustmentIDRef(){return daysInRangeAdjustmentIDRef_;}

       bool isUpperBarrier(){return this->upperBarrierIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getUpperBarrier();
      std::string getUpperBarrierIDRef(){return upperBarrierIDRef_;}

       bool isLowerBarrier(){return this->lowerBarrierIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getLowerBarrier();
      std::string getLowerBarrierIDRef(){return lowerBarrierIDRef_;}

   protected: 
       boost::shared_ptr<RealisedVarianceMethodEnum> realisedVarianceMethod_;
       std::string realisedVarianceMethodIDRef_;
       bool realisedVarianceMethodIsNull_;
       boost::shared_ptr<XsdTypeBoolean> daysInRangeAdjustment_;
       std::string daysInRangeAdjustmentIDRef_;
       bool daysInRangeAdjustmentIsNull_;
       boost::shared_ptr<NonNegativeDecimal> upperBarrier_;
       std::string upperBarrierIDRef_;
       bool upperBarrierIsNull_;
       boost::shared_ptr<NonNegativeDecimal> lowerBarrier_;
       std::string lowerBarrierIDRef_;
       bool lowerBarrierIsNull_;

};

} //namespaceFpmlSerialized end
#endif

