// StepDownKIResult.hpp 
#ifndef FpmlSerialized_StepDownKIResult_hpp
#define FpmlSerialized_StepDownKIResult_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/UnderylingInfoResult.hpp>
#include <RiskMonitor-0-1/CashFlowInfoResult.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class StepDownKIResult : public ISerialized { 
   public: 
       StepDownKIResult(TiXmlNode* xmlNode);

       bool isUnderylingInfoResult(){return this->underylingInfoResultIsNull_;}
       boost::shared_ptr<UnderylingInfoResult> getUnderylingInfoResult();


       bool isCashFlowInfoResult(){return this->cashFlowInfoResultIsNull_;}
       boost::shared_ptr<CashFlowInfoResult> getCashFlowInfoResult();


       bool isTheta(){return this->thetaIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getTheta();


   protected: 
       boost::shared_ptr<UnderylingInfoResult> underylingInfoResult_;
       
       bool underylingInfoResultIsNull_;
       boost::shared_ptr<CashFlowInfoResult> cashFlowInfoResult_;
       
       bool cashFlowInfoResultIsNull_;
       boost::shared_ptr<XsdTypeDouble> theta_;
       
       bool thetaIsNull_;

};

} //namespaceFpmlSerialized end
#endif

