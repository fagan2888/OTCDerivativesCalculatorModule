// ServiceStatus.hpp 
#ifndef FpmlSerialized_ServiceStatus_hpp
#define FpmlSerialized_ServiceStatus_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class ServiceStatus : public Scheme { 
   public: 
       ServiceStatus(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

