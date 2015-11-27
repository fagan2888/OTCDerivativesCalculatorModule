// RequestedWithdrawalAction.hpp 
#ifndef FpmlSerialized_RequestedWithdrawalAction_hpp
#define FpmlSerialized_RequestedWithdrawalAction_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class RequestedWithdrawalAction : public Scheme { 
   public: 
       RequestedWithdrawalAction(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

