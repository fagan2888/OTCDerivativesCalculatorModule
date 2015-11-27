// CommodityMultipleExercise.hpp 
#ifndef FpmlSerialized_CommodityMultipleExercise_hpp
#define FpmlSerialized_CommodityMultipleExercise_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CommodityNotionalQuantity.hpp>

namespace FpmlSerialized {

class CommodityMultipleExercise : public ISerialized { 
   public: 
       CommodityMultipleExercise(TiXmlNode* xmlNode);

       bool isIntegralMultipleQuantity(){return this->integralMultipleQuantityIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantity> getIntegralMultipleQuantity();
      std::string getIntegralMultipleQuantityIDRef(){return integralMultipleQuantityIDRef_;}

       bool isMinimumNotionalQuantity(){return this->minimumNotionalQuantityIsNull_;}
       boost::shared_ptr<CommodityNotionalQuantity> getMinimumNotionalQuantity();
      std::string getMinimumNotionalQuantityIDRef(){return minimumNotionalQuantityIDRef_;}

   protected: 
       boost::shared_ptr<CommodityNotionalQuantity> integralMultipleQuantity_;
       std::string integralMultipleQuantityIDRef_;
       bool integralMultipleQuantityIsNull_;
       boost::shared_ptr<CommodityNotionalQuantity> minimumNotionalQuantity_;
       std::string minimumNotionalQuantityIDRef_;
       bool minimumNotionalQuantityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

