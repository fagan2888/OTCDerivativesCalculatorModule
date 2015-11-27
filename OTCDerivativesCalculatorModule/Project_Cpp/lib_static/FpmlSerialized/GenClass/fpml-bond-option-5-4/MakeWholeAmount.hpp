// MakeWholeAmount.hpp 
#ifndef FpmlSerialized_MakeWholeAmount_hpp
#define FpmlSerialized_MakeWholeAmount_hpp

#include <fpml-bond-option-5-4/SwapCurveValuation.hpp>
#include <fpml-shared-5-4/InterpolationMethod.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>

namespace FpmlSerialized {

class MakeWholeAmount : public SwapCurveValuation { 
   public: 
       MakeWholeAmount(TiXmlNode* xmlNode);

       bool isInterpolationMethod(){return this->interpolationMethodIsNull_;}
       boost::shared_ptr<InterpolationMethod> getInterpolationMethod();
      std::string getInterpolationMethodIDRef(){return interpolationMethodIDRef_;}

       bool isEarlyCallDate(){return this->earlyCallDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getEarlyCallDate();
      std::string getEarlyCallDateIDRef(){return earlyCallDateIDRef_;}

   protected: 
       boost::shared_ptr<InterpolationMethod> interpolationMethod_;
       std::string interpolationMethodIDRef_;
       bool interpolationMethodIsNull_;
       boost::shared_ptr<IdentifiedDate> earlyCallDate_;
       std::string earlyCallDateIDRef_;
       bool earlyCallDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

