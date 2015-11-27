// EquityAsset.hpp 
#ifndef FpmlSerialized_EquityAsset_hpp
#define FpmlSerialized_EquityAsset_hpp

#include <fpml-asset-5-4/ExchangeTraded.hpp>

namespace FpmlSerialized {

class EquityAsset : public ExchangeTraded { 
   public: 
       EquityAsset(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

