// Lag.hpp 
#ifndef FpmlSerialized_Lag_hpp
#define FpmlSerialized_Lag_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Period.hpp>

namespace FpmlSerialized {

class Lag : public ISerialized { 
   public: 
       Lag(TiXmlNode* xmlNode);

       bool isLagDuration(){return this->lagDurationIsNull_;}
       boost::shared_ptr<Period> getLagDuration();
      std::string getLagDurationIDRef(){return lagDurationIDRef_;}

       bool isFirstObservationDateOffset(){return this->firstObservationDateOffsetIsNull_;}
       boost::shared_ptr<Period> getFirstObservationDateOffset();
      std::string getFirstObservationDateOffsetIDRef(){return firstObservationDateOffsetIDRef_;}

   protected: 
       boost::shared_ptr<Period> lagDuration_;
       std::string lagDurationIDRef_;
       bool lagDurationIsNull_;
       boost::shared_ptr<Period> firstObservationDateOffset_;
       std::string firstObservationDateOffsetIDRef_;
       bool firstObservationDateOffsetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

