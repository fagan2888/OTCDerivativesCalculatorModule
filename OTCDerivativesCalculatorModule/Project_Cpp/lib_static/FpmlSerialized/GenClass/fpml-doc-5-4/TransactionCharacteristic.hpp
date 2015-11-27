// TransactionCharacteristic.hpp 
#ifndef FpmlSerialized_TransactionCharacteristic_hpp
#define FpmlSerialized_TransactionCharacteristic_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class TransactionCharacteristic : public Scheme { 
   public: 
       TransactionCharacteristic(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

