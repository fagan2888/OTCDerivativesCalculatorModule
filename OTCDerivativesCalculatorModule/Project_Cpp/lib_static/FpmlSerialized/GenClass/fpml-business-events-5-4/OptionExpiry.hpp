// OptionExpiry.hpp 
#ifndef FpmlSerialized_OptionExpiry_hpp
#define FpmlSerialized_OptionExpiry_hpp

#include <fpml-business-events-5-4/AbstractEvent.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifier.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeTime.hpp>
#include <fpml-shared-5-4/ExerciseProcedureOption.hpp>

namespace FpmlSerialized {

class OptionExpiry : public AbstractEvent { 
   public: 
       OptionExpiry(TiXmlNode* xmlNode);

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       bool isTime(){return this->timeIsNull_;}
       boost::shared_ptr<XsdTypeTime> getTime();
      std::string getTimeIDRef(){return timeIDRef_;}

       bool isExerciseProcedure(){return this->exerciseProcedureIsNull_;}
       boost::shared_ptr<ExerciseProcedureOption> getExerciseProcedure();
      std::string getExerciseProcedureIDRef(){return exerciseProcedureIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PartyTradeIdentifier>> tradeIdentifier_;
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;
       boost::shared_ptr<XsdTypeDate> date_;
       std::string dateIDRef_;
       bool dateIsNull_;
       boost::shared_ptr<XsdTypeTime> time_;
       std::string timeIDRef_;
       bool timeIsNull_;
       boost::shared_ptr<ExerciseProcedureOption> exerciseProcedure_;
       std::string exerciseProcedureIDRef_;
       bool exerciseProcedureIsNull_;

};

} //namespaceFpmlSerialized end
#endif

