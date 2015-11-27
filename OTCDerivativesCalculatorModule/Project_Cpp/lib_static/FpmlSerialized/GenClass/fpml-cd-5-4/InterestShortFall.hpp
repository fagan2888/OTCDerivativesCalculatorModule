// InterestShortFall.hpp 
#ifndef FpmlSerialized_InterestShortFall_hpp
#define FpmlSerialized_InterestShortFall_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/InterestShortfallCapEnum.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/FloatingRateIndex.hpp>

namespace FpmlSerialized {

class InterestShortFall : public ISerialized { 
   public: 
       InterestShortFall(TiXmlNode* xmlNode);

       bool isInterestShortfallCap(){return this->interestShortfallCapIsNull_;}
       boost::shared_ptr<InterestShortfallCapEnum> getInterestShortfallCap();
      std::string getInterestShortfallCapIDRef(){return interestShortfallCapIDRef_;}

       bool isCompounding(){return this->compoundingIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getCompounding();
      std::string getCompoundingIDRef(){return compoundingIDRef_;}

       bool isRateSource(){return this->rateSourceIsNull_;}
       boost::shared_ptr<FloatingRateIndex> getRateSource();
      std::string getRateSourceIDRef(){return rateSourceIDRef_;}

   protected: 
       boost::shared_ptr<InterestShortfallCapEnum> interestShortfallCap_;
       std::string interestShortfallCapIDRef_;
       bool interestShortfallCapIsNull_;
       boost::shared_ptr<XsdTypeBoolean> compounding_;
       std::string compoundingIDRef_;
       bool compoundingIsNull_;
       boost::shared_ptr<FloatingRateIndex> rateSource_;
       std::string rateSourceIDRef_;
       bool rateSourceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

