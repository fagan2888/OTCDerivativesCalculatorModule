// VarianceSwap.hpp 
#ifndef FpmlSerialized_VarianceSwap_hpp
#define FpmlSerialized_VarianceSwap_hpp

#include <fpml-eq-shared-5-4/NettedSwapBase.hpp>
#include <fpml-variance-swaps-5-4/VarianceLeg.hpp>

namespace FpmlSerialized {

class VarianceSwap : public NettedSwapBase { 
   public: 
       VarianceSwap(TiXmlNode* xmlNode);

       bool isVarianceLeg(){return this->varianceLegIsNull_;}
       std::vector<boost::shared_ptr<VarianceLeg>> getVarianceLeg();
      std::string getVarianceLegIDRef(){return varianceLegIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<VarianceLeg>> varianceLeg_;
       std::string varianceLegIDRef_;
       bool varianceLegIsNull_;

};

} //namespaceFpmlSerialized end
#endif

