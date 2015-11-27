// AffectedTransactions.hpp 
#ifndef FpmlSerialized_AffectedTransactions_hpp
#define FpmlSerialized_AffectedTransactions_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class AffectedTransactions : public ISerialized { 
   public: 
       AffectedTransactions(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

