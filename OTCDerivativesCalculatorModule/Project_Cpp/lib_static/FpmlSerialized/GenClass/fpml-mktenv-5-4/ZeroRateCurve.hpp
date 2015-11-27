// ZeroRateCurve.hpp 
#ifndef FpmlSerialized_ZeroRateCurve_hpp
#define FpmlSerialized_ZeroRateCurve_hpp

#include <ISerialized.hpp>
#include <fpml-mktenv-5-4/CompoundingFrequency.hpp>
#include <fpml-mktenv-5-4/TermCurve.hpp>

namespace FpmlSerialized {

class ZeroRateCurve : public ISerialized { 
   public: 
       ZeroRateCurve(TiXmlNode* xmlNode);

       bool isCompoundingFrequency(){return this->compoundingFrequencyIsNull_;}
       boost::shared_ptr<CompoundingFrequency> getCompoundingFrequency();
      std::string getCompoundingFrequencyIDRef(){return compoundingFrequencyIDRef_;}

       bool isRateCurve(){return this->rateCurveIsNull_;}
       boost::shared_ptr<TermCurve> getRateCurve();
      std::string getRateCurveIDRef(){return rateCurveIDRef_;}

   protected: 
       boost::shared_ptr<CompoundingFrequency> compoundingFrequency_;
       std::string compoundingFrequencyIDRef_;
       bool compoundingFrequencyIsNull_;
       boost::shared_ptr<TermCurve> rateCurve_;
       std::string rateCurveIDRef_;
       bool rateCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

