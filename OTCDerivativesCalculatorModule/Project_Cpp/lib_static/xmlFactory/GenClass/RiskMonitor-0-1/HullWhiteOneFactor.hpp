// HullWhiteOneFactor.hpp 
#ifndef FpmlSerialized_HullWhiteOneFactor_hpp
#define FpmlSerialized_HullWhiteOneFactor_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/Tenor.hpp>
#include <RiskMonitor-0-1/FittingYieldCurve.hpp>

namespace FpmlSerialized {

class HullWhiteOneFactor : public ISerialized { 
   public: 
       HullWhiteOneFactor(TiXmlNode* xmlNode);

       bool isCurrentValue(){return this->currentValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCurrentValue();


       bool isAlpha(){return this->alphaIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getAlpha();


       bool isSigma(){return this->sigmaIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getSigma();


       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<Tenor> getTenor();


       bool isFittingYieldCurve(){return this->fittingYieldCurveIsNull_;}
       boost::shared_ptr<FittingYieldCurve> getFittingYieldCurve();


   protected: 
       boost::shared_ptr<XsdTypeDouble> currentValue_;
       
       bool currentValueIsNull_;
       boost::shared_ptr<XsdTypeDouble> alpha_;
       
       bool alphaIsNull_;
       boost::shared_ptr<XsdTypeDouble> sigma_;
       
       bool sigmaIsNull_;
       boost::shared_ptr<Tenor> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<FittingYieldCurve> fittingYieldCurve_;
       
       bool fittingYieldCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

