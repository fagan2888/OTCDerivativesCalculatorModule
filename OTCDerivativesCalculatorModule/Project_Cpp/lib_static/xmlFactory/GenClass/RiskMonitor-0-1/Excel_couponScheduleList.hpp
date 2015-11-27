// Excel_couponScheduleList.hpp 
#ifndef FpmlSerialized_Excel_couponScheduleList_hpp
#define FpmlSerialized_Excel_couponScheduleList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_couponSchedule.hpp>

namespace FpmlSerialized {

class Excel_couponScheduleList : public ISerialized { 
   public: 
       Excel_couponScheduleList(TiXmlNode* xmlNode);

       bool isExcel_couponSchedule(){return this->excel_couponScheduleIsNull_;}
       std::vector<boost::shared_ptr<Excel_couponSchedule>> getExcel_couponSchedule();


   protected: 
       std::vector<boost::shared_ptr<Excel_couponSchedule>> excel_couponSchedule_;
       
       bool excel_couponScheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

