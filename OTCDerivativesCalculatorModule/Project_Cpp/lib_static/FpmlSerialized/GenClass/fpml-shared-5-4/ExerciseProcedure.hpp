// ExerciseProcedure.hpp 
#ifndef FpmlSerialized_ExerciseProcedure_hpp
#define FpmlSerialized_ExerciseProcedure_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ManualExercise.hpp>
#include <fpml-shared-5-4/AutomaticExercise.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class ExerciseProcedure : public ISerialized { 
   public: 
       ExerciseProcedure(TiXmlNode* xmlNode);

       bool isManualExercise(){return this->manualExerciseIsNull_;}
       boost::shared_ptr<ManualExercise> getManualExercise();
      std::string getManualExerciseIDRef(){return manualExerciseIDRef_;}

       bool isAutomaticExercise(){return this->automaticExerciseIsNull_;}
       boost::shared_ptr<AutomaticExercise> getAutomaticExercise();
      std::string getAutomaticExerciseIDRef(){return automaticExerciseIDRef_;}

       bool isFollowUpConfirmation(){return this->followUpConfirmationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getFollowUpConfirmation();
      std::string getFollowUpConfirmationIDRef(){return followUpConfirmationIDRef_;}

       bool isLimitedRightToConfirm(){return this->limitedRightToConfirmIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getLimitedRightToConfirm();
      std::string getLimitedRightToConfirmIDRef(){return limitedRightToConfirmIDRef_;}

       bool isSplitTicket(){return this->splitTicketIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSplitTicket();
      std::string getSplitTicketIDRef(){return splitTicketIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!manualExerciseIsNull_){
                count += 1;
                str = "manualExercise" ;
           }
           if(!automaticExerciseIsNull_){
                count += 1;
                str = "automaticExercise" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<ManualExercise> manualExercise_;     //choice
       std::string manualExerciseIDRef_;
       bool manualExerciseIsNull_;
         boost::shared_ptr<AutomaticExercise> automaticExercise_;     //choice
       std::string automaticExerciseIDRef_;
       bool automaticExerciseIsNull_;
       boost::shared_ptr<XsdTypeBoolean> followUpConfirmation_;
       std::string followUpConfirmationIDRef_;
       bool followUpConfirmationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> limitedRightToConfirm_;
       std::string limitedRightToConfirmIDRef_;
       bool limitedRightToConfirmIsNull_;
       boost::shared_ptr<XsdTypeBoolean> splitTicket_;
       std::string splitTicketIDRef_;
       bool splitTicketIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

