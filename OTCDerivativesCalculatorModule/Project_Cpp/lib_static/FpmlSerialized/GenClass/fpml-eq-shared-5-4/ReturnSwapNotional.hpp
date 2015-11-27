// ReturnSwapNotional.hpp 
#ifndef FpmlSerialized_ReturnSwapNotional_hpp
#define FpmlSerialized_ReturnSwapNotional_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ReturnSwapNotionalAmountReference.hpp>
#include <fpml-shared-5-4/DeterminationMethodReference.hpp>
#include <fpml-shared-5-4/DeterminationMethod.hpp>
#include <fpml-shared-5-4/NotionalAmount.hpp>

namespace FpmlSerialized {

class ReturnSwapNotional : public ISerialized { 
   public: 
       ReturnSwapNotional(TiXmlNode* xmlNode);

       bool isRelativeNotionalAmount(){return this->relativeNotionalAmountIsNull_;}
       boost::shared_ptr<ReturnSwapNotionalAmountReference> getRelativeNotionalAmount();
      std::string getRelativeNotionalAmountIDRef(){return relativeNotionalAmountIDRef_;}

       bool isRelativeDeterminationMethod(){return this->relativeDeterminationMethodIsNull_;}
       boost::shared_ptr<DeterminationMethodReference> getRelativeDeterminationMethod();
      std::string getRelativeDeterminationMethodIDRef(){return relativeDeterminationMethodIDRef_;}

       bool isDeterminationMethod(){return this->determinationMethodIsNull_;}
       boost::shared_ptr<DeterminationMethod> getDeterminationMethod();
      std::string getDeterminationMethodIDRef(){return determinationMethodIDRef_;}

       bool isNotionalAmount(){return this->notionalAmountIsNull_;}
       boost::shared_ptr<NotionalAmount> getNotionalAmount();
      std::string getNotionalAmountIDRef(){return notionalAmountIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!relativeNotionalAmountIsNull_){
                count += 1;
                str = "relativeNotionalAmount" ;
           }
           if(!relativeDeterminationMethodIsNull_){
                count += 1;
                str = "relativeDeterminationMethod" ;
           }
           if(!determinationMethodIsNull_){
                count += 1;
                str = "determinationMethod" ;
           }
           if(!notionalAmountIsNull_){
                count += 1;
                str = "notionalAmount" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<ReturnSwapNotionalAmountReference> relativeNotionalAmount_;     //choice
       std::string relativeNotionalAmountIDRef_;
       bool relativeNotionalAmountIsNull_;
         boost::shared_ptr<DeterminationMethodReference> relativeDeterminationMethod_;     //choice
       std::string relativeDeterminationMethodIDRef_;
       bool relativeDeterminationMethodIsNull_;
         boost::shared_ptr<DeterminationMethod> determinationMethod_;     //choice
       std::string determinationMethodIDRef_;
       bool determinationMethodIsNull_;
         boost::shared_ptr<NotionalAmount> notionalAmount_;     //choice
       std::string notionalAmountIDRef_;
       bool notionalAmountIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

