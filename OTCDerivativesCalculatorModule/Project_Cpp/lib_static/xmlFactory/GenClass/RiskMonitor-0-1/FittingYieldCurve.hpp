// FittingYieldCurve.hpp 
#ifndef FpmlSerialized_FittingYieldCurve_hpp
#define FpmlSerialized_FittingYieldCurve_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/YieldTermstructure.hpp>

namespace FpmlSerialized {

class FittingYieldCurve : public ISerialized { 
   public: 
       FittingYieldCurve(TiXmlNode* xmlNode);

       bool isYieldTermstructure(){return this->yieldTermstructureIsNull_;}
       boost::shared_ptr<YieldTermstructure> getYieldTermstructure();


   protected: 
       boost::shared_ptr<YieldTermstructure> yieldTermstructure_;
       
       bool yieldTermstructureIsNull_;

};

} //namespaceFpmlSerialized end
#endif

