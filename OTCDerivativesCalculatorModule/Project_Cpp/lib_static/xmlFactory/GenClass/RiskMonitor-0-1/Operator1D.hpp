// Operator1D.hpp 
#ifndef FpmlSerialized_Operator1D_hpp
#define FpmlSerialized_Operator1D_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/AdditionOper1D.hpp>
#include <RiskMonitor-0-1/MultipleOper1D.hpp>
#include <RiskMonitor-0-1/MaximumOper1D.hpp>

namespace FpmlSerialized {

class Operator1D : public ISerialized { 
   public: 
       Operator1D(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isAdditionOper1D(){return this->additionOper1DIsNull_;}
       boost::shared_ptr<AdditionOper1D> getAdditionOper1D();


       bool isMultipleOper1D(){return this->multipleOper1DIsNull_;}
       boost::shared_ptr<MultipleOper1D> getMultipleOper1D();


       bool isMaximumOper1D(){return this->maximumOper1DIsNull_;}
       boost::shared_ptr<MaximumOper1D> getMaximumOper1D();


       std::string getChoiceStr_operator1DType(){
           std::string str;
           int count = 0;
           if(!additionOper1DIsNull_){
                count += 1;
                str = "additionOper1D" ;
           }
           if(!multipleOper1DIsNull_){
                count += 1;
                str = "multipleOper1D" ;
           }
           if(!maximumOper1DIsNull_){
                count += 1;
                str = "maximumOper1D" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_operator1DType_ = str ;
           return choiceStr_operator1DType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<AdditionOper1D> additionOper1D_;     //choice
       
       bool additionOper1DIsNull_;
         boost::shared_ptr<MultipleOper1D> multipleOper1D_;     //choice
       
       bool multipleOper1DIsNull_;
         boost::shared_ptr<MaximumOper1D> maximumOper1D_;     //choice
       
       bool maximumOper1DIsNull_;

       //choiceStr 
       std::string choiceStr_operator1DType_;

};

} //namespaceFpmlSerialized end
#endif

