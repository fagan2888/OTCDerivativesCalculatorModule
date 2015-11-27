// Excel_general.hpp 
#ifndef FpmlSerialized_Excel_general_hpp
#define FpmlSerialized_Excel_general_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/GeneralSchedule.hpp>
#include <RiskMonitor-0-1/GeneralTerminationEvent.hpp>

namespace FpmlSerialized {

class Excel_general : public ISerialized { 
   public: 
       Excel_general(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isGeneralSchedule(){return this->generalScheduleIsNull_;}
       std::vector<boost::shared_ptr<GeneralSchedule>> getGeneralSchedule();


       bool isGeneralTerminationEvent(){return this->generalTerminationEventIsNull_;}
       std::vector<boost::shared_ptr<GeneralTerminationEvent>> getGeneralTerminationEvent();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       std::vector<boost::shared_ptr<GeneralSchedule>> generalSchedule_;
       
       bool generalScheduleIsNull_;
       std::vector<boost::shared_ptr<GeneralTerminationEvent>> generalTerminationEvent_;
       
       bool generalTerminationEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

