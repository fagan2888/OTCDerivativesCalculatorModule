// OptionalEarlyTerminationAdjustedDates.hpp 
#ifndef FpmlSerialized_OptionalEarlyTerminationAdjustedDates_hpp
#define FpmlSerialized_OptionalEarlyTerminationAdjustedDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/EarlyTerminationEvent.hpp>

namespace FpmlSerialized {

class OptionalEarlyTerminationAdjustedDates : public ISerialized { 
   public: 
       OptionalEarlyTerminationAdjustedDates(TiXmlNode* xmlNode);

       bool isEarlyTerminationEvent(){return this->earlyTerminationEventIsNull_;}
       std::vector<boost::shared_ptr<EarlyTerminationEvent>> getEarlyTerminationEvent();
      std::string getEarlyTerminationEventIDRef(){return earlyTerminationEventIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<EarlyTerminationEvent>> earlyTerminationEvent_;
       std::string earlyTerminationEventIDRef_;
       bool earlyTerminationEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

