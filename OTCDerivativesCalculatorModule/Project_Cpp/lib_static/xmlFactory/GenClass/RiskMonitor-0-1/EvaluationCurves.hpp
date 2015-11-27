// EvaluationCurves.hpp 
#ifndef FpmlSerialized_EvaluationCurves_hpp
#define FpmlSerialized_EvaluationCurves_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class EvaluationCurves : public ISerialized { 
   public: 
       EvaluationCurves(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

