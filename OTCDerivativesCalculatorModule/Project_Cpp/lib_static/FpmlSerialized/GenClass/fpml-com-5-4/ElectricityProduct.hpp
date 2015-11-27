// ElectricityProduct.hpp 
#ifndef FpmlSerialized_ElectricityProduct_hpp
#define FpmlSerialized_ElectricityProduct_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/ElectricityProductTypeEnum.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class ElectricityProduct : public ISerialized { 
   public: 
       ElectricityProduct(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<ElectricityProductTypeEnum> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isVoltage(){return this->voltageIsNull_;}
       boost::shared_ptr<PositiveDecimal> getVoltage();
      std::string getVoltageIDRef(){return voltageIDRef_;}

   protected: 
       boost::shared_ptr<ElectricityProductTypeEnum> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<PositiveDecimal> voltage_;
       std::string voltageIDRef_;
       bool voltageIsNull_;

};

} //namespaceFpmlSerialized end
#endif

