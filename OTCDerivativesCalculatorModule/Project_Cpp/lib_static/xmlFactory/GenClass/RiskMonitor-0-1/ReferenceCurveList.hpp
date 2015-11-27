// ReferenceCurveList.hpp 
#ifndef FpmlSerialized_ReferenceCurveList_hpp
#define FpmlSerialized_ReferenceCurveList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ReferenceCurve.hpp>

namespace FpmlSerialized {

class ReferenceCurveList : public ISerialized { 
   public: 
       ReferenceCurveList(TiXmlNode* xmlNode);

       bool isReferenceCurve(){return this->referenceCurveIsNull_;}
       std::vector<boost::shared_ptr<ReferenceCurve>> getReferenceCurve();


   protected: 
       std::vector<boost::shared_ptr<ReferenceCurve>> referenceCurve_;
       
       bool referenceCurveIsNull_;

};

} //namespaceFpmlSerialized end
#endif

