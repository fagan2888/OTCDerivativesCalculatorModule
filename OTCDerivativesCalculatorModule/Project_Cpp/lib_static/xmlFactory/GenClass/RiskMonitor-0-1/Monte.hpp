// Monte.hpp 
#ifndef FpmlSerialized_Monte_hpp
#define FpmlSerialized_Monte_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>

namespace FpmlSerialized {

class Monte : public ISerialized { 
   public: 
       Monte(TiXmlNode* xmlNode);

       bool isSimulationNum(){return this->simulationNumIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getSimulationNum();


   protected: 
       boost::shared_ptr<XsdTypeInteger> simulationNum_;
       
       bool simulationNumIsNull_;

};

} //namespaceFpmlSerialized end
#endif

