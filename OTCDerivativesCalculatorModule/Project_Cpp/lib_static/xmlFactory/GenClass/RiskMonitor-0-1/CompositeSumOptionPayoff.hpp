// CompositeSumOptionPayoff.hpp 
#ifndef FpmlSerialized_CompositeSumOptionPayoff_hpp
#define FpmlSerialized_CompositeSumOptionPayoff_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/FixingDateInfo.hpp>
#include <RiskMonitor-0-1/PayoffDateInfo.hpp>
#include <RiskMonitor-0-1/ReferenceCalculationInfo.hpp>
#include <RiskMonitor-0-1/StandardOption.hpp>

namespace FpmlSerialized {

class CompositeSumOptionPayoff : public ISerialized { 
   public: 
       CompositeSumOptionPayoff(TiXmlNode* xmlNode);

       bool isFixingDateInfo(){return this->fixingDateInfoIsNull_;}
       boost::shared_ptr<FixingDateInfo> getFixingDateInfo();


       bool isPayoffDateInfo(){return this->payoffDateInfoIsNull_;}
       boost::shared_ptr<PayoffDateInfo> getPayoffDateInfo();


       bool isReferenceCalculationInfo(){return this->referenceCalculationInfoIsNull_;}
       boost::shared_ptr<ReferenceCalculationInfo> getReferenceCalculationInfo();


       bool isStandardOption(){return this->standardOptionIsNull_;}
       std::vector<boost::shared_ptr<StandardOption>> getStandardOption();


   protected: 
       boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
       
       bool fixingDateInfoIsNull_;
       boost::shared_ptr<PayoffDateInfo> payoffDateInfo_;
       
       bool payoffDateInfoIsNull_;
       boost::shared_ptr<ReferenceCalculationInfo> referenceCalculationInfo_;
       
       bool referenceCalculationInfoIsNull_;
       std::vector<boost::shared_ptr<StandardOption>> standardOption_;
       
       bool standardOptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

