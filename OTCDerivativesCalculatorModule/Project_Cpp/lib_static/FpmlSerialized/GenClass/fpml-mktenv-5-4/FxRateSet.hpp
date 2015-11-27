// FxRateSet.hpp 
#ifndef FpmlSerialized_FxRateSet_hpp
#define FpmlSerialized_FxRateSet_hpp

#include <fpml-riskdef-5-4/QuotedAssetSet.hpp>

namespace FpmlSerialized {

class FxRateSet : public QuotedAssetSet { 
   public: 
       FxRateSet(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

