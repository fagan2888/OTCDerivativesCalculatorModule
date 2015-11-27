// OffsetPrevailingTime.hpp 
#ifndef FpmlSerialized_OffsetPrevailingTime_hpp
#define FpmlSerialized_OffsetPrevailingTime_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PrevailingTime.hpp>
#include <fpml-shared-5-4/Offset.hpp>

namespace FpmlSerialized {

class OffsetPrevailingTime : public ISerialized { 
   public: 
       OffsetPrevailingTime(TiXmlNode* xmlNode);

       bool isTime(){return this->timeIsNull_;}
       boost::shared_ptr<PrevailingTime> getTime();
      std::string getTimeIDRef(){return timeIDRef_;}

       bool isOffset(){return this->offsetIsNull_;}
       boost::shared_ptr<Offset> getOffset();
      std::string getOffsetIDRef(){return offsetIDRef_;}

   protected: 
       boost::shared_ptr<PrevailingTime> time_;
       std::string timeIDRef_;
       bool timeIsNull_;
       boost::shared_ptr<Offset> offset_;
       std::string offsetIDRef_;
       bool offsetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

