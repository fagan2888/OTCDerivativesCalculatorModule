// VolatilityMatrix.hpp 
#ifndef FpmlSerialized_VolatilityMatrix_hpp
#define FpmlSerialized_VolatilityMatrix_hpp

#include <fpml-riskdef-5-4/PricingStructureValuation.hpp>
#include <fpml-mktenv-5-4/MultiDimensionalPricingData.hpp>
#include <fpml-mktenv-5-4/ParametricAdjustment.hpp>

namespace FpmlSerialized {

class VolatilityMatrix : public PricingStructureValuation { 
   public: 
       VolatilityMatrix(TiXmlNode* xmlNode);

       bool isDataPoints(){return this->dataPointsIsNull_;}
       boost::shared_ptr<MultiDimensionalPricingData> getDataPoints();
      std::string getDataPointsIDRef(){return dataPointsIDRef_;}

       bool isAdjustment(){return this->adjustmentIsNull_;}
       std::vector<boost::shared_ptr<ParametricAdjustment>> getAdjustment();
      std::string getAdjustmentIDRef(){return adjustmentIDRef_;}

   protected: 
       boost::shared_ptr<MultiDimensionalPricingData> dataPoints_;
       std::string dataPointsIDRef_;
       bool dataPointsIsNull_;
       std::vector<boost::shared_ptr<ParametricAdjustment>> adjustment_;
       std::string adjustmentIDRef_;
       bool adjustmentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

