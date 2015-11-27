// ExerciseEvent.hpp 
#ifndef FpmlSerialized_ExerciseEvent_hpp
#define FpmlSerialized_ExerciseEvent_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class ExerciseEvent : public ISerialized { 
   public: 
       ExerciseEvent(TiXmlNode* xmlNode);

       bool isAdjustedExerciseDate(){return this->adjustedExerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedExerciseDate();
      std::string getAdjustedExerciseDateIDRef(){return adjustedExerciseDateIDRef_;}

       bool isAdjustedRelevantSwapEffectiveDate(){return this->adjustedRelevantSwapEffectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedRelevantSwapEffectiveDate();
      std::string getAdjustedRelevantSwapEffectiveDateIDRef(){return adjustedRelevantSwapEffectiveDateIDRef_;}

       bool isAdjustedCashSettlementValuationDate(){return this->adjustedCashSettlementValuationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedCashSettlementValuationDate();
      std::string getAdjustedCashSettlementValuationDateIDRef(){return adjustedCashSettlementValuationDateIDRef_;}

       bool isAdjustedCashSettlementPaymentDate(){return this->adjustedCashSettlementPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedCashSettlementPaymentDate();
      std::string getAdjustedCashSettlementPaymentDateIDRef(){return adjustedCashSettlementPaymentDateIDRef_;}

       bool isAdjustedExerciseFeePaymentDate(){return this->adjustedExerciseFeePaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedExerciseFeePaymentDate();
      std::string getAdjustedExerciseFeePaymentDateIDRef(){return adjustedExerciseFeePaymentDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> adjustedExerciseDate_;
       std::string adjustedExerciseDateIDRef_;
       bool adjustedExerciseDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedRelevantSwapEffectiveDate_;
       std::string adjustedRelevantSwapEffectiveDateIDRef_;
       bool adjustedRelevantSwapEffectiveDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedCashSettlementValuationDate_;
       std::string adjustedCashSettlementValuationDateIDRef_;
       bool adjustedCashSettlementValuationDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedCashSettlementPaymentDate_;
       std::string adjustedCashSettlementPaymentDateIDRef_;
       bool adjustedCashSettlementPaymentDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedExerciseFeePaymentDate_;
       std::string adjustedExerciseFeePaymentDateIDRef_;
       bool adjustedExerciseFeePaymentDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

