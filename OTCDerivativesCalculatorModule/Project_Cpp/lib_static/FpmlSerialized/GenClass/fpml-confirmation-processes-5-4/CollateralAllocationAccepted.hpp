// CollateralAllocationAccepted.hpp 
#ifndef FpmlSerialized_CollateralAllocationAccepted_hpp
#define FpmlSerialized_CollateralAllocationAccepted_hpp

#include <fpml-msg-5-4/ResponseMessage.hpp>

namespace FpmlSerialized {

class CollateralAllocationAccepted : public ResponseMessage { 
   public: 
       CollateralAllocationAccepted(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

