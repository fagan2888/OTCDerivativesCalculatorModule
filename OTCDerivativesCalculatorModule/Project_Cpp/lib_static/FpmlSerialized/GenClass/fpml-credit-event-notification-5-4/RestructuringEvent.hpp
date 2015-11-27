// RestructuringEvent.hpp 
#ifndef FpmlSerialized_RestructuringEvent_hpp
#define FpmlSerialized_RestructuringEvent_hpp

#include <fpml-credit-event-notification-5-4/CreditEvent.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class RestructuringEvent : public CreditEvent { 
   public: 
       RestructuringEvent(TiXmlNode* xmlNode);

       bool isPartialExerciseAmount(){return this->partialExerciseAmountIsNull_;}
       boost::shared_ptr<Money> getPartialExerciseAmount();
      std::string getPartialExerciseAmountIDRef(){return partialExerciseAmountIDRef_;}

   protected: 
       boost::shared_ptr<Money> partialExerciseAmount_;
       std::string partialExerciseAmountIDRef_;
       bool partialExerciseAmountIsNull_;

};

} //namespaceFpmlSerialized end
#endif

