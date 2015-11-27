// BusinessCenterTime.hpp 
#ifndef FpmlSerialized_BusinessCenterTime_hpp
#define FpmlSerialized_BusinessCenterTime_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/HourMinuteTime.hpp>
#include <fpml-shared-5-4/BusinessCenter.hpp>

namespace FpmlSerialized {

class BusinessCenterTime : public ISerialized { 
   public: 
       BusinessCenterTime(TiXmlNode* xmlNode);

       bool isHourMinuteTime(){return this->hourMinuteTimeIsNull_;}
       boost::shared_ptr<HourMinuteTime> getHourMinuteTime();
      std::string getHourMinuteTimeIDRef(){return hourMinuteTimeIDRef_;}

       bool isBusinessCenter(){return this->businessCenterIsNull_;}
       boost::shared_ptr<BusinessCenter> getBusinessCenter();
      std::string getBusinessCenterIDRef(){return businessCenterIDRef_;}

   protected: 
       boost::shared_ptr<HourMinuteTime> hourMinuteTime_;
       std::string hourMinuteTimeIDRef_;
       bool hourMinuteTimeIsNull_;
       boost::shared_ptr<BusinessCenter> businessCenter_;
       std::string businessCenterIDRef_;
       bool businessCenterIsNull_;

};

} //namespaceFpmlSerialized end
#endif

