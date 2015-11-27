// FloatingRateDefinition.hpp 
#ifndef FpmlSerialized_FloatingRateDefinition_hpp
#define FpmlSerialized_FloatingRateDefinition_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/RateObservation.hpp>
#include <fpml-shared-5-4/Strike.hpp>

namespace FpmlSerialized {

class FloatingRateDefinition : public ISerialized { 
   public: 
       FloatingRateDefinition(TiXmlNode* xmlNode);

       bool isCalculatedRate(){return this->calculatedRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getCalculatedRate();
      std::string getCalculatedRateIDRef(){return calculatedRateIDRef_;}

       bool isRateObservation(){return this->rateObservationIsNull_;}
       std::vector<boost::shared_ptr<RateObservation>> getRateObservation();
      std::string getRateObservationIDRef(){return rateObservationIDRef_;}

       bool isFloatingRateMultiplier(){return this->floatingRateMultiplierIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getFloatingRateMultiplier();
      std::string getFloatingRateMultiplierIDRef(){return floatingRateMultiplierIDRef_;}

       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSpread();
      std::string getSpreadIDRef(){return spreadIDRef_;}

       bool isCapRate(){return this->capRateIsNull_;}
       std::vector<boost::shared_ptr<Strike>> getCapRate();
      std::string getCapRateIDRef(){return capRateIDRef_;}

       bool isFloorRate(){return this->floorRateIsNull_;}
       std::vector<boost::shared_ptr<Strike>> getFloorRate();
      std::string getFloorRateIDRef(){return floorRateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> calculatedRate_;
       std::string calculatedRateIDRef_;
       bool calculatedRateIsNull_;
       std::vector<boost::shared_ptr<RateObservation>> rateObservation_;
       std::string rateObservationIDRef_;
       bool rateObservationIsNull_;
       boost::shared_ptr<XsdTypeDecimal> floatingRateMultiplier_;
       std::string floatingRateMultiplierIDRef_;
       bool floatingRateMultiplierIsNull_;
       boost::shared_ptr<XsdTypeDecimal> spread_;
       std::string spreadIDRef_;
       bool spreadIsNull_;
       std::vector<boost::shared_ptr<Strike>> capRate_;
       std::string capRateIDRef_;
       bool capRateIsNull_;
       std::vector<boost::shared_ptr<Strike>> floorRate_;
       std::string floorRateIDRef_;
       bool floorRateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

