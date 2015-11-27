// Root.hpp 
#ifndef FpmlSerialized_Root_hpp
#define FpmlSerialized_Root_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Instrument.hpp>

namespace FpmlSerialized {

class Root : public ISerialized { 
   public: 
       Root(TiXmlNode* xmlNode);

       bool isInstrument(){return this->instrumentIsNull_;}
       boost::shared_ptr<Instrument> getInstrument();


   protected: 
       boost::shared_ptr<Instrument> instrument_;
       
       bool instrumentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

