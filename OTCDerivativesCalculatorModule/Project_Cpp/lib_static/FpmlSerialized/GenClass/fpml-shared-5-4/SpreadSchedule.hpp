// SpreadSchedule.hpp 
#ifndef FpmlSerialized_SpreadSchedule_hpp
#define FpmlSerialized_SpreadSchedule_hpp

#include <fpml-shared-5-4/Schedule.hpp>
#include <fpml-shared-5-4/SpreadScheduleType.hpp>

namespace FpmlSerialized {

class SpreadSchedule : public Schedule { 
   public: 
       SpreadSchedule(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<SpreadScheduleType> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

   protected: 
       boost::shared_ptr<SpreadScheduleType> type_;
       std::string typeIDRef_;
       bool typeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

