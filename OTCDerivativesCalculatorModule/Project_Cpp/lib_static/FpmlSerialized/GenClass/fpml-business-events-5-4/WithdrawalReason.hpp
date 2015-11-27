// WithdrawalReason.hpp 
#ifndef FpmlSerialized_WithdrawalReason_hpp
#define FpmlSerialized_WithdrawalReason_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class WithdrawalReason : public Scheme { 
   public: 
       WithdrawalReason(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

