// PrevailingTime.hpp 
#ifndef FpmlSerialized_PrevailingTime_hpp
#define FpmlSerialized_PrevailingTime_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/HourMinuteTime.hpp>
#include <fpml-shared-5-4/TimezoneLocation.hpp>

namespace FpmlSerialized {

class PrevailingTime : public ISerialized { 
   public: 
       PrevailingTime(TiXmlNode* xmlNode);

       bool isHourMinuteTime(){return this->hourMinuteTimeIsNull_;}
       boost::shared_ptr<HourMinuteTime> getHourMinuteTime();
      std::string getHourMinuteTimeIDRef(){return hourMinuteTimeIDRef_;}

       bool isLocation(){return this->locationIsNull_;}
       boost::shared_ptr<TimezoneLocation> getLocation();
      std::string getLocationIDRef(){return locationIDRef_;}

   protected: 
       boost::shared_ptr<HourMinuteTime> hourMinuteTime_;
       std::string hourMinuteTimeIDRef_;
       bool hourMinuteTimeIsNull_;
       boost::shared_ptr<TimezoneLocation> location_;
       std::string locationIDRef_;
       bool locationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

