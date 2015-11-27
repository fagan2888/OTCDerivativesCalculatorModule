// ConventionSet.hpp 
#ifndef FpmlSerialized_ConventionSet_hpp
#define FpmlSerialized_ConventionSet_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class ConventionSet : public ISerialized { 
   public: 
       ConventionSet(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

