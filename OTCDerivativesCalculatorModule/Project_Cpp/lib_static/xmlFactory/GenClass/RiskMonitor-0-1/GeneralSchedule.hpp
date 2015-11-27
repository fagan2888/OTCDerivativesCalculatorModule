// GeneralSchedule.hpp 
#ifndef FpmlSerialized_GeneralSchedule_hpp
#define FpmlSerialized_GeneralSchedule_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/GeneralScheduleDeatil.hpp>

namespace FpmlSerialized {

class GeneralSchedule : public ISerialized { 
   public: 
       GeneralSchedule(TiXmlNode* xmlNode);

       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isDetailScheduleType(){return this->detailScheduleTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDetailScheduleType();


       bool isGeneralScheduleDeatil(){return this->generalScheduleDeatilIsNull_;}
       boost::shared_ptr<GeneralScheduleDeatil> getGeneralScheduleDeatil();


   protected: 
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> detailScheduleType_;
       
       bool detailScheduleTypeIsNull_;
       boost::shared_ptr<GeneralScheduleDeatil> generalScheduleDeatil_;
       
       bool generalScheduleDeatilIsNull_;

};

} //namespaceFpmlSerialized end
#endif

