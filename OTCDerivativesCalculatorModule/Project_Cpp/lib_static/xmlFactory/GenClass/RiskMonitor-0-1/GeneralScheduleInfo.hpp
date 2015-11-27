// GeneralScheduleInfo.hpp 
#ifndef FpmlSerialized_GeneralScheduleInfo_hpp
#define FpmlSerialized_GeneralScheduleInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/GeneralSchedule.hpp>

namespace FpmlSerialized {

class GeneralScheduleInfo : public ISerialized { 
   public: 
       GeneralScheduleInfo(TiXmlNode* xmlNode);

       bool isGeneralSchedule(){return this->generalScheduleIsNull_;}
       std::vector<boost::shared_ptr<GeneralSchedule>> getGeneralSchedule();


   protected: 
       std::vector<boost::shared_ptr<GeneralSchedule>> generalSchedule_;
       
       bool generalScheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

