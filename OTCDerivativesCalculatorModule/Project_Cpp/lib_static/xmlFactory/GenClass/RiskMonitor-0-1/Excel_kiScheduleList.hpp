// Excel_kiScheduleList.hpp 
#ifndef FpmlSerialized_Excel_kiScheduleList_hpp
#define FpmlSerialized_Excel_kiScheduleList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_schedule.hpp>

namespace FpmlSerialized {

class Excel_kiScheduleList : public ISerialized { 
   public: 
       Excel_kiScheduleList(TiXmlNode* xmlNode);

       bool isExcel_schedule(){return this->excel_scheduleIsNull_;}
       std::vector<boost::shared_ptr<Excel_schedule>> getExcel_schedule();


   protected: 
       std::vector<boost::shared_ptr<Excel_schedule>> excel_schedule_;
       
       bool excel_scheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

