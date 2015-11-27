// ReturnCalculationInfo.hpp 
#ifndef FpmlSerialized_ReturnCalculationInfo_hpp
#define FpmlSerialized_ReturnCalculationInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ReturnCalculation.hpp>
#include <RiskMonitor-0-1/OperatorND.hpp>

namespace FpmlSerialized {

class ReturnCalculationInfo : public ISerialized { 
   public: 
       ReturnCalculationInfo(TiXmlNode* xmlNode);

       bool isReturnCalculation(){return this->returnCalculationIsNull_;}
       std::vector<boost::shared_ptr<ReturnCalculation>> getReturnCalculation();


       bool isOperatorND(){return this->operatorNDIsNull_;}
       boost::shared_ptr<OperatorND> getOperatorND();


   protected: 
       std::vector<boost::shared_ptr<ReturnCalculation>> returnCalculation_;
       
       bool returnCalculationIsNull_;
       boost::shared_ptr<OperatorND> operatorND_;
       
       bool operatorNDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

