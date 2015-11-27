// DiscountCurve_para.hpp 
#ifndef FpmlSerialized_DiscountCurve_para_hpp
#define FpmlSerialized_DiscountCurve_para_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/YieldTermstructure.hpp>

namespace FpmlSerialized {

class DiscountCurve_para : public ISerialized { 
   public: 
       DiscountCurve_para(TiXmlNode* xmlNode);

       bool isYieldTermstructure(){return this->yieldTermstructureIsNull_;}
       boost::shared_ptr<YieldTermstructure> getYieldTermstructure();


   protected: 
       boost::shared_ptr<YieldTermstructure> yieldTermstructure_;
       
       bool yieldTermstructureIsNull_;

};

} //namespaceFpmlSerialized end
#endif

