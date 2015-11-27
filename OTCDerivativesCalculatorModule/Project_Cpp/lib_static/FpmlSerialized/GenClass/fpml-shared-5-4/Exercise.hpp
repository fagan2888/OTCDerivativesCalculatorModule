// Exercise.hpp 
#ifndef FpmlSerialized_Exercise_hpp
#define FpmlSerialized_Exercise_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Exercise : public ISerialized { 
   public: 
       Exercise(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

