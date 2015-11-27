// StopLossReturnCal.hpp 
#ifndef FpmlSerialized_StopLossReturnCal_hpp
#define FpmlSerialized_StopLossReturnCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class StopLossReturnCal : public ISerialized { 
   public: 
       StopLossReturnCal(TiXmlNode* xmlNode);

       bool isPower(){return this->powerIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPower();


       bool isLossTrigger(){return this->lossTriggerIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLossTrigger();


       bool isMaximumLoss(){return this->maximumLossIsNull_;}
       boost::shared_ptr<XsdTypeToken> getMaximumLoss();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isWithNotional(){return this->withNotionalIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getWithNotional();


       bool isIsExpired(){return this->isExpiredIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIsExpired();


   protected: 
       boost::shared_ptr<XsdTypeToken> power_;
       
       bool powerIsNull_;
       boost::shared_ptr<XsdTypeToken> lossTrigger_;
       
       bool lossTriggerIsNull_;
       boost::shared_ptr<XsdTypeToken> maximumLoss_;
       
       bool maximumLossIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       boost::shared_ptr<XsdTypeBoolean> withNotional_;
       
       bool withNotionalIsNull_;
       boost::shared_ptr<XsdTypeBoolean> isExpired_;
       
       bool isExpiredIsNull_;

};

} //namespaceFpmlSerialized end
#endif

