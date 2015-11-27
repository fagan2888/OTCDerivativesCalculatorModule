// SwapStreamPara.hpp 
#ifndef FpmlSerialized_SwapStreamPara_hpp
#define FpmlSerialized_SwapStreamPara_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/DiscountCurve_para.hpp>

namespace FpmlSerialized {

class SwapStreamPara : public ISerialized { 
   public: 
       SwapStreamPara(TiXmlNode* xmlNode);

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getNotional();


       bool isDiscountCurve_para(){return this->discountCurve_paraIsNull_;}
       boost::shared_ptr<DiscountCurve_para> getDiscountCurve_para();


   protected: 
       boost::shared_ptr<XsdTypeDouble> notional_;
       
       bool notionalIsNull_;
       boost::shared_ptr<DiscountCurve_para> discountCurve_para_;
       
       bool discountCurve_paraIsNull_;

};

} //namespaceFpmlSerialized end
#endif

