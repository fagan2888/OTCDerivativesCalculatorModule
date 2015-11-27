// ResetFrequency.hpp 
#ifndef FpmlSerialized_ResetFrequency_hpp
#define FpmlSerialized_ResetFrequency_hpp

#include <fpml-shared-5-4/Frequency.hpp>
#include <fpml-enum-5-4/WeeklyRollConventionEnum.hpp>

namespace FpmlSerialized {

class ResetFrequency : public Frequency { 
   public: 
       ResetFrequency(TiXmlNode* xmlNode);

       bool isWeeklyRollConvention(){return this->weeklyRollConventionIsNull_;}
       boost::shared_ptr<WeeklyRollConventionEnum> getWeeklyRollConvention();
      std::string getWeeklyRollConventionIDRef(){return weeklyRollConventionIDRef_;}

   protected: 
       boost::shared_ptr<WeeklyRollConventionEnum> weeklyRollConvention_;
       std::string weeklyRollConventionIDRef_;
       bool weeklyRollConventionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

