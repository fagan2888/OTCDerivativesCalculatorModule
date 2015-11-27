// TriggerEvent.hpp 
#ifndef FpmlSerialized_TriggerEvent_hpp
#define FpmlSerialized_TriggerEvent_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/AveragingSchedule.hpp>
#include <fpml-shared-5-4/DateList.hpp>
#include <fpml-option-shared-5-4/Trigger.hpp>
#include <fpml-option-shared-5-4/FeaturePayment.hpp>

namespace FpmlSerialized {

class TriggerEvent : public ISerialized { 
   public: 
       TriggerEvent(TiXmlNode* xmlNode);

       bool isSchedule(){return this->scheduleIsNull_;}
       std::vector<boost::shared_ptr<AveragingSchedule>> getSchedule();
      std::string getScheduleIDRef(){return scheduleIDRef_;}

       bool isTriggerDates(){return this->triggerDatesIsNull_;}
       boost::shared_ptr<DateList> getTriggerDates();
      std::string getTriggerDatesIDRef(){return triggerDatesIDRef_;}

       bool isTrigger(){return this->triggerIsNull_;}
       boost::shared_ptr<Trigger> getTrigger();
      std::string getTriggerIDRef(){return triggerIDRef_;}

       bool isFeaturePayment(){return this->featurePaymentIsNull_;}
       boost::shared_ptr<FeaturePayment> getFeaturePayment();
      std::string getFeaturePaymentIDRef(){return featurePaymentIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<AveragingSchedule>> schedule_;
       std::string scheduleIDRef_;
       bool scheduleIsNull_;
       boost::shared_ptr<DateList> triggerDates_;
       std::string triggerDatesIDRef_;
       bool triggerDatesIsNull_;
       boost::shared_ptr<Trigger> trigger_;
       std::string triggerIDRef_;
       bool triggerIsNull_;
       boost::shared_ptr<FeaturePayment> featurePayment_;
       std::string featurePaymentIDRef_;
       bool featurePaymentIsNull_;

};

} //namespaceFpmlSerialized end
#endif

