// SimpleRangeReturn.hpp 
#ifndef FpmlSerialized_SimpleRangeReturn_hpp
#define FpmlSerialized_SimpleRangeReturn_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/SimpleRangeEventCal.hpp>
#include <RiskMonitor-0-1/ReturnCalculation.hpp>

namespace FpmlSerialized {

class SimpleRangeReturn : public ISerialized { 
   public: 
       SimpleRangeReturn(TiXmlNode* xmlNode);

       bool isSimpleRangeEventCal(){return this->simpleRangeEventCalIsNull_;}
       boost::shared_ptr<SimpleRangeEventCal> getSimpleRangeEventCal();


       bool isReturnCalculation(){return this->returnCalculationIsNull_;}
       boost::shared_ptr<ReturnCalculation> getReturnCalculation();


   protected: 
       boost::shared_ptr<SimpleRangeEventCal> simpleRangeEventCal_;
       
       bool simpleRangeEventCalIsNull_;
       boost::shared_ptr<ReturnCalculation> returnCalculation_;
       
       bool returnCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

