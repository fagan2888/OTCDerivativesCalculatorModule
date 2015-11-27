// TermCurve.hpp 
#ifndef FpmlSerialized_TermCurve_hpp
#define FpmlSerialized_TermCurve_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/InterpolationMethod.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-mktenv-5-4/TermPoint.hpp>

namespace FpmlSerialized {

class TermCurve : public ISerialized { 
   public: 
       TermCurve(TiXmlNode* xmlNode);

       bool isInterpolationMethod(){return this->interpolationMethodIsNull_;}
       boost::shared_ptr<InterpolationMethod> getInterpolationMethod();
      std::string getInterpolationMethodIDRef(){return interpolationMethodIDRef_;}

       bool isExtrapolationPermitted(){return this->extrapolationPermittedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExtrapolationPermitted();
      std::string getExtrapolationPermittedIDRef(){return extrapolationPermittedIDRef_;}

       bool isPoint(){return this->pointIsNull_;}
       std::vector<boost::shared_ptr<TermPoint>> getPoint();
      std::string getPointIDRef(){return pointIDRef_;}

   protected: 
       boost::shared_ptr<InterpolationMethod> interpolationMethod_;
       std::string interpolationMethodIDRef_;
       bool interpolationMethodIsNull_;
       boost::shared_ptr<XsdTypeBoolean> extrapolationPermitted_;
       std::string extrapolationPermittedIDRef_;
       bool extrapolationPermittedIsNull_;
       std::vector<boost::shared_ptr<TermPoint>> point_;
       std::string pointIDRef_;
       bool pointIsNull_;

};

} //namespaceFpmlSerialized end
#endif

