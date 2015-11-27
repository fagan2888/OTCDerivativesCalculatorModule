// FxAverageRateObservation.hpp 
#ifndef FpmlSerialized_FxAverageRateObservation_hpp
#define FpmlSerialized_FxAverageRateObservation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/NonNegativeDecimal.hpp>

namespace FpmlSerialized {

class FxAverageRateObservation : public ISerialized { 
   public: 
       FxAverageRateObservation(TiXmlNode* xmlNode);

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       bool isAverageRateWeightingFactor(){return this->averageRateWeightingFactorIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getAverageRateWeightingFactor();
      std::string getAverageRateWeightingFactorIDRef(){return averageRateWeightingFactorIDRef_;}

       bool isRate(){return this->rateIsNull_;}
       boost::shared_ptr<NonNegativeDecimal> getRate();
      std::string getRateIDRef(){return rateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> date_;
       std::string dateIDRef_;
       bool dateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> averageRateWeightingFactor_;
       std::string averageRateWeightingFactorIDRef_;
       bool averageRateWeightingFactorIsNull_;
       boost::shared_ptr<NonNegativeDecimal> rate_;
       std::string rateIDRef_;
       bool rateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

