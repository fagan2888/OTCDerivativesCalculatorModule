// ReferenceCalculation.hpp 
#ifndef FpmlSerialized_ReferenceCalculation_hpp
#define FpmlSerialized_ReferenceCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixingInformation.hpp>
#include <RiskMonitor-0-1/ChoiceReferenceCal.hpp>
#include <RiskMonitor-0-1/IdentityReferenceCal.hpp>
#include <RiskMonitor-0-1/MaximumReferenceCal.hpp>
#include <RiskMonitor-0-1/MinimumReferenceCal.hpp>
#include <RiskMonitor-0-1/RefVariableReferenceCal.hpp>
#include <RiskMonitor-0-1/DailyReturnReferenceCal.hpp>
#include <RiskMonitor-0-1/PostCalculation.hpp>
#include <RiskMonitor-0-1/RefVariable_referenceValue.hpp>

namespace FpmlSerialized {

class ReferenceCalculation : public ISerialized { 
   public: 
       ReferenceCalculation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isFixingInformation(){return this->fixingInformationIsNull_;}
       boost::shared_ptr<FixingInformation> getFixingInformation();


       bool isChoiceReferenceCal(){return this->choiceReferenceCalIsNull_;}
       boost::shared_ptr<ChoiceReferenceCal> getChoiceReferenceCal();


       bool isIdentityReferenceCal(){return this->identityReferenceCalIsNull_;}
       boost::shared_ptr<IdentityReferenceCal> getIdentityReferenceCal();


       bool isMaximumReferenceCal(){return this->maximumReferenceCalIsNull_;}
       boost::shared_ptr<MaximumReferenceCal> getMaximumReferenceCal();


       bool isMinimumReferenceCal(){return this->minimumReferenceCalIsNull_;}
       boost::shared_ptr<MinimumReferenceCal> getMinimumReferenceCal();


       bool isRefVariableReferenceCal(){return this->refVariableReferenceCalIsNull_;}
       boost::shared_ptr<RefVariableReferenceCal> getRefVariableReferenceCal();


       bool isDailyReturnReferenceCal(){return this->dailyReturnReferenceCalIsNull_;}
       boost::shared_ptr<DailyReturnReferenceCal> getDailyReturnReferenceCal();


       bool isPostCalculation(){return this->postCalculationIsNull_;}
       boost::shared_ptr<PostCalculation> getPostCalculation();


       bool isRefVariable_referenceValue(){return this->refVariable_referenceValueIsNull_;}
       boost::shared_ptr<RefVariable_referenceValue> getRefVariable_referenceValue();


       std::string getChoiceStr_referenceCalType(){
           std::string str;
           int count = 0;
           if(!choiceReferenceCalIsNull_){
                count += 1;
                str = "choiceReferenceCal" ;
           }
           if(!identityReferenceCalIsNull_){
                count += 1;
                str = "identityReferenceCal" ;
           }
           if(!maximumReferenceCalIsNull_){
                count += 1;
                str = "maximumReferenceCal" ;
           }
           if(!minimumReferenceCalIsNull_){
                count += 1;
                str = "minimumReferenceCal" ;
           }
           if(!refVariableReferenceCalIsNull_){
                count += 1;
                str = "refVariableReferenceCal" ;
           }
           if(!dailyReturnReferenceCalIsNull_){
                count += 1;
                str = "dailyReturnReferenceCal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_referenceCalType_ = str ;
           return choiceStr_referenceCalType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<FixingInformation> fixingInformation_;
       
       bool fixingInformationIsNull_;
         boost::shared_ptr<ChoiceReferenceCal> choiceReferenceCal_;     //choice
       
       bool choiceReferenceCalIsNull_;
         boost::shared_ptr<IdentityReferenceCal> identityReferenceCal_;     //choice
       
       bool identityReferenceCalIsNull_;
         boost::shared_ptr<MaximumReferenceCal> maximumReferenceCal_;     //choice
       
       bool maximumReferenceCalIsNull_;
         boost::shared_ptr<MinimumReferenceCal> minimumReferenceCal_;     //choice
       
       bool minimumReferenceCalIsNull_;
         boost::shared_ptr<RefVariableReferenceCal> refVariableReferenceCal_;     //choice
       
       bool refVariableReferenceCalIsNull_;
         boost::shared_ptr<DailyReturnReferenceCal> dailyReturnReferenceCal_;     //choice
       
       bool dailyReturnReferenceCalIsNull_;
       boost::shared_ptr<PostCalculation> postCalculation_;
       
       bool postCalculationIsNull_;
       boost::shared_ptr<RefVariable_referenceValue> refVariable_referenceValue_;
       
       bool refVariable_referenceValueIsNull_;

       //choiceStr 
       std::string choiceStr_referenceCalType_;

};

} //namespaceFpmlSerialized end
#endif

