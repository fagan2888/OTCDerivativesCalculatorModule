// WeatherStationWMO.hpp 
#ifndef FpmlSerialized_WeatherStationWMO_hpp
#define FpmlSerialized_WeatherStationWMO_hpp

#include <fpml-shared-5-4/Scheme.hpp>

namespace FpmlSerialized {

class WeatherStationWMO : public Scheme { 
   public: 
       WeatherStationWMO(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

