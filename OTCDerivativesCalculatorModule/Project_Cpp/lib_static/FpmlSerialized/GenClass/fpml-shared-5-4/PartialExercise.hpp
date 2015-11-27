// PartialExercise.hpp 
#ifndef FpmlSerialized_PartialExercise_hpp
#define FpmlSerialized_PartialExercise_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/NotionalReference.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>

namespace FpmlSerialized {

class PartialExercise : public ISerialized { 
   public: 
       PartialExercise(TiXmlNode* xmlNode);

       bool isNotionalReference(){return this->notionalReferenceIsNull_;}
       std::vector<boost::shared_ptr<NotionalReference>> getNotionalReference();
      std::string getNotionalReferenceIDRef(){return notionalReferenceIDRef_;}

       bool isIntegralMultipleAmount(){return this->integralMultipleAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getIntegralMultipleAmount();
      std::string getIntegralMultipleAmountIDRef(){return integralMultipleAmountIDRef_;}

       bool isMinimumNotionalAmount(){return this->minimumNotionalAmountIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getMinimumNotionalAmount();
      std::string getMinimumNotionalAmountIDRef(){return minimumNotionalAmountIDRef_;}

       bool isMinimumNumberOfOptions(){return this->minimumNumberOfOptionsIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getMinimumNumberOfOptions();
      std::string getMinimumNumberOfOptionsIDRef(){return minimumNumberOfOptionsIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!minimumNotionalAmountIsNull_){
                count += 1;
                str = "minimumNotionalAmount" ;
           }
           if(!minimumNumberOfOptionsIsNull_){
                count += 1;
                str = "minimumNumberOfOptions" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       std::vector<boost::shared_ptr<NotionalReference>> notionalReference_;
       std::string notionalReferenceIDRef_;
       bool notionalReferenceIsNull_;
       boost::shared_ptr<XsdTypeDecimal> integralMultipleAmount_;
       std::string integralMultipleAmountIDRef_;
       bool integralMultipleAmountIsNull_;
         boost::shared_ptr<XsdTypeDecimal> minimumNotionalAmount_;     //choice
       std::string minimumNotionalAmountIDRef_;
       bool minimumNotionalAmountIsNull_;
         boost::shared_ptr<XsdTypeNonNegativeInteger> minimumNumberOfOptions_;     //choice
       std::string minimumNumberOfOptionsIDRef_;
       bool minimumNumberOfOptionsIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

