// Notional.hpp 
#ifndef FpmlSerialized_Notional_hpp
#define FpmlSerialized_Notional_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/NonNegativeAmountSchedule.hpp>
#include <fpml-ird-5-4/NotionalStepRule.hpp>

namespace FpmlSerialized {

class Notional : public ISerialized { 
   public: 
       Notional(TiXmlNode* xmlNode);

       bool isNotionalStepSchedule(){return this->notionalStepScheduleIsNull_;}
       boost::shared_ptr<NonNegativeAmountSchedule> getNotionalStepSchedule();
      std::string getNotionalStepScheduleIDRef(){return notionalStepScheduleIDRef_;}

       bool isNotionalStepParameters(){return this->notionalStepParametersIsNull_;}
       boost::shared_ptr<NotionalStepRule> getNotionalStepParameters();
      std::string getNotionalStepParametersIDRef(){return notionalStepParametersIDRef_;}

   protected: 
       boost::shared_ptr<NonNegativeAmountSchedule> notionalStepSchedule_;
       std::string notionalStepScheduleIDRef_;
       bool notionalStepScheduleIsNull_;
       boost::shared_ptr<NotionalStepRule> notionalStepParameters_;
       std::string notionalStepParametersIDRef_;
       bool notionalStepParametersIsNull_;

};

} //namespaceFpmlSerialized end
#endif

