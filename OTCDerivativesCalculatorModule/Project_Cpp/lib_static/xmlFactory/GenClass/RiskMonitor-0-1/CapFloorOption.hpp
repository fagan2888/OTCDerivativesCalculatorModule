// CapFloorOption.hpp 
#ifndef FpmlSerialized_CapFloorOption_hpp
#define FpmlSerialized_CapFloorOption_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/CapOption.hpp>
#include <RiskMonitor-0-1/FloorOption.hpp>

namespace FpmlSerialized {

class CapFloorOption : public ISerialized { 
   public: 
       CapFloorOption(TiXmlNode* xmlNode);

       bool isCapOption(){return this->capOptionIsNull_;}
       boost::shared_ptr<CapOption> getCapOption();


       bool isFloorOption(){return this->floorOptionIsNull_;}
       boost::shared_ptr<FloorOption> getFloorOption();


   protected: 
       boost::shared_ptr<CapOption> capOption_;
       
       bool capOptionIsNull_;
       boost::shared_ptr<FloorOption> floorOption_;
       
       bool floorOptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

