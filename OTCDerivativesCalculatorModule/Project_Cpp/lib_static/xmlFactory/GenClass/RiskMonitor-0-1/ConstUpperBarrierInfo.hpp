// ConstUpperBarrierInfo.hpp 
#ifndef FpmlSerialized_ConstUpperBarrierInfo_hpp
#define FpmlSerialized_ConstUpperBarrierInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/BarrierDateInfo.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class ConstUpperBarrierInfo : public ISerialized { 
   public: 
       ConstUpperBarrierInfo(TiXmlNode* xmlNode);

       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isBarrierDateInfo(){return this->barrierDateInfoIsNull_;}
       boost::shared_ptr<BarrierDateInfo> getBarrierDateInfo();


       bool isTrigger(){return this->triggerIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getTrigger();


       bool isPastEventOccDate(){return this->pastEventOccDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getPastEventOccDate();


       bool isPastEventOccValue(){return this->pastEventOccValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getPastEventOccValue();


       bool isRefVariableFlag_eventOccDate(){return this->refVariableFlag_eventOccDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefVariableFlag_eventOccDate();


       bool isRefVariableFlag_eventOccValue(){return this->refVariableFlag_eventOccValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefVariableFlag_eventOccValue();


   protected: 
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       boost::shared_ptr<BarrierDateInfo> barrierDateInfo_;
       
       bool barrierDateInfoIsNull_;
       boost::shared_ptr<XsdTypeDouble> trigger_;
       
       bool triggerIsNull_;
       boost::shared_ptr<XsdTypeDate> pastEventOccDate_;
       
       bool pastEventOccDateIsNull_;
       boost::shared_ptr<XsdTypeDouble> pastEventOccValue_;
       
       bool pastEventOccValueIsNull_;
       boost::shared_ptr<XsdTypeToken> refVariableFlag_eventOccDate_;
       
       bool refVariableFlag_eventOccDateIsNull_;
       boost::shared_ptr<XsdTypeToken> refVariableFlag_eventOccValue_;
       
       bool refVariableFlag_eventOccValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

