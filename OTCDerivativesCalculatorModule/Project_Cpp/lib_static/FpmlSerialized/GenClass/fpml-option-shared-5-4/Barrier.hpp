// Barrier.hpp 
#ifndef FpmlSerialized_Barrier_hpp
#define FpmlSerialized_Barrier_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/TriggerEvent.hpp>

namespace FpmlSerialized {

class Barrier : public ISerialized { 
   public: 
       Barrier(TiXmlNode* xmlNode);

       bool isBarrierCap(){return this->barrierCapIsNull_;}
       boost::shared_ptr<TriggerEvent> getBarrierCap();
      std::string getBarrierCapIDRef(){return barrierCapIDRef_;}

       bool isBarrierFloor(){return this->barrierFloorIsNull_;}
       boost::shared_ptr<TriggerEvent> getBarrierFloor();
      std::string getBarrierFloorIDRef(){return barrierFloorIDRef_;}

   protected: 
       boost::shared_ptr<TriggerEvent> barrierCap_;
       std::string barrierCapIDRef_;
       bool barrierCapIsNull_;
       boost::shared_ptr<TriggerEvent> barrierFloor_;
       std::string barrierFloorIDRef_;
       bool barrierFloorIsNull_;

};

} //namespaceFpmlSerialized end
#endif

