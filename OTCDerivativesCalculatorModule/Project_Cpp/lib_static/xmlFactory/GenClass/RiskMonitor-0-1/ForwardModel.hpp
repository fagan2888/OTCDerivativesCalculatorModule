// ForwardModel.hpp 
#ifndef FpmlSerialized_ForwardModel_hpp
#define FpmlSerialized_ForwardModel_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/Tenor.hpp>
#include <RiskMonitor-0-1/FittingYieldCurve.hpp>

namespace FpmlSerialized {

class ForwardModel : public ISerialized { 
   public: 
       ForwardModel(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCurrentValue();


       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<Tenor> getTenor();


       bool isFittingYieldCurve(){return this->fittingYieldCurveIsNull_;}
       boost::shared_ptr<FittingYieldCurve> getFittingYieldCurve();


   protected: 
       boost::shared_ptr<XsdTypeDouble> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<Tenor> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<FittingYieldCurve> fittingYieldCurve_;
       
       bool fittingYieldCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

