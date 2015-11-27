// CallPutCompositeReturnCal.hpp 
#ifndef FpmlSerialized_CallPutCompositeReturnCal_hpp
#define FpmlSerialized_CallPutCompositeReturnCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/OptionPayoffFunction.hpp>

namespace FpmlSerialized {

class CallPutCompositeReturnCal : public ISerialized { 
   public: 
       CallPutCompositeReturnCal(TiXmlNode* xmlNode);

       bool isWeight(){return this->weightIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDouble>> getWeight();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isOptionPayoffFunction(){return this->optionPayoffFunctionIsNull_;}
       std::vector<boost::shared_ptr<OptionPayoffFunction>> getOptionPayoffFunction();


   protected: 
       std::vector<boost::shared_ptr<XsdTypeDouble>> weight_;
       
       bool weightIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       std::vector<boost::shared_ptr<OptionPayoffFunction>> optionPayoffFunction_;
       
       bool optionPayoffFunctionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

