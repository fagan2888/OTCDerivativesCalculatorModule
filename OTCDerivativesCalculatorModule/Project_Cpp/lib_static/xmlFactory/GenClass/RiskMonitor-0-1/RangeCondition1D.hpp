// RangeCondition1D.hpp 
#ifndef FpmlSerialized_RangeCondition1D_hpp
#define FpmlSerialized_RangeCondition1D_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Range1D.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class RangeCondition1D : public ISerialized { 
   public: 
       RangeCondition1D(TiXmlNode* xmlNode);

       bool isRange1D(){return this->range1DIsNull_;}
       boost::shared_ptr<Range1D> getRange1D();


       bool isConstValue(){return this->constValueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getConstValue();


       bool isRefName(){return this->refNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRefName();


   protected: 
       boost::shared_ptr<Range1D> range1D_;
       
       bool range1DIsNull_;
       boost::shared_ptr<XsdTypeToken> constValue_;
       
       bool constValueIsNull_;
       boost::shared_ptr<XsdTypeToken> refName_;
       
       bool refNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

