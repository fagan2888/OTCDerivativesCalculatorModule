// CorrelationSwap.hpp 
#ifndef FpmlSerialized_CorrelationSwap_hpp
#define FpmlSerialized_CorrelationSwap_hpp

#include <fpml-eq-shared-5-4/NettedSwapBase.hpp>
#include <fpml-correlation-swaps-5-4/CorrelationLeg.hpp>

namespace FpmlSerialized {

class CorrelationSwap : public NettedSwapBase { 
   public: 
       CorrelationSwap(TiXmlNode* xmlNode);

       bool isCorrelationLeg(){return this->correlationLegIsNull_;}
       boost::shared_ptr<CorrelationLeg> getCorrelationLeg();
      std::string getCorrelationLegIDRef(){return correlationLegIDRef_;}

   protected: 
       boost::shared_ptr<CorrelationLeg> correlationLeg_;
       std::string correlationLegIDRef_;
       bool correlationLegIsNull_;

};

} //namespaceFpmlSerialized end
#endif

