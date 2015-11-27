// FloatingRate.hpp 
#ifndef FpmlSerialized_FloatingRate_hpp
#define FpmlSerialized_FloatingRate_hpp

#include <fpml-shared-5-4/Rate.hpp>
#include <fpml-shared-5-4/FloatingRateIndex.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <fpml-shared-5-4/Schedule.hpp>
#include <fpml-shared-5-4/SpreadSchedule.hpp>
#include <fpml-enum-5-4/RateTreatmentEnum.hpp>
#include <fpml-shared-5-4/StrikeSchedule.hpp>

namespace FpmlSerialized {

class FloatingRate : public Rate { 
   public: 
       FloatingRate(TiXmlNode* xmlNode);

       bool isFloatingRateIndex(){return this->floatingRateIndexIsNull_;}
       boost::shared_ptr<FloatingRateIndex> getFloatingRateIndex();
      std::string getFloatingRateIndexIDRef(){return floatingRateIndexIDRef_;}

       bool isIndexTenor(){return this->indexTenorIsNull_;}
       boost::shared_ptr<Period> getIndexTenor();
      std::string getIndexTenorIDRef(){return indexTenorIDRef_;}

       bool isFloatingRateMultiplierSchedule(){return this->floatingRateMultiplierScheduleIsNull_;}
       boost::shared_ptr<Schedule> getFloatingRateMultiplierSchedule();
      std::string getFloatingRateMultiplierScheduleIDRef(){return floatingRateMultiplierScheduleIDRef_;}

       bool isSpreadSchedule(){return this->spreadScheduleIsNull_;}
       std::vector<boost::shared_ptr<SpreadSchedule>> getSpreadSchedule();
      std::string getSpreadScheduleIDRef(){return spreadScheduleIDRef_;}

       bool isRateTreatment(){return this->rateTreatmentIsNull_;}
       boost::shared_ptr<RateTreatmentEnum> getRateTreatment();
      std::string getRateTreatmentIDRef(){return rateTreatmentIDRef_;}

       bool isCapRateSchedule(){return this->capRateScheduleIsNull_;}
       std::vector<boost::shared_ptr<StrikeSchedule>> getCapRateSchedule();
      std::string getCapRateScheduleIDRef(){return capRateScheduleIDRef_;}

       bool isFloorRateSchedule(){return this->floorRateScheduleIsNull_;}
       std::vector<boost::shared_ptr<StrikeSchedule>> getFloorRateSchedule();
      std::string getFloorRateScheduleIDRef(){return floorRateScheduleIDRef_;}

   protected: 
       boost::shared_ptr<FloatingRateIndex> floatingRateIndex_;
       std::string floatingRateIndexIDRef_;
       bool floatingRateIndexIsNull_;
       boost::shared_ptr<Period> indexTenor_;
       std::string indexTenorIDRef_;
       bool indexTenorIsNull_;
       boost::shared_ptr<Schedule> floatingRateMultiplierSchedule_;
       std::string floatingRateMultiplierScheduleIDRef_;
       bool floatingRateMultiplierScheduleIsNull_;
       std::vector<boost::shared_ptr<SpreadSchedule>> spreadSchedule_;
       std::string spreadScheduleIDRef_;
       bool spreadScheduleIsNull_;
       boost::shared_ptr<RateTreatmentEnum> rateTreatment_;
       std::string rateTreatmentIDRef_;
       bool rateTreatmentIsNull_;
       std::vector<boost::shared_ptr<StrikeSchedule>> capRateSchedule_;
       std::string capRateScheduleIDRef_;
       bool capRateScheduleIsNull_;
       std::vector<boost::shared_ptr<StrikeSchedule>> floorRateSchedule_;
       std::string floorRateScheduleIDRef_;
       bool floorRateScheduleIsNull_;

};

} //namespaceFpmlSerialized end
#endif

