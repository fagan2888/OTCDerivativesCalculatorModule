// OperatorND.hpp 
#ifndef FpmlSerialized_OperatorND_hpp
#define FpmlSerialized_OperatorND_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/AdditionOperND.hpp>
#include <RiskMonitor-0-1/MultipleOperND.hpp>
#include <RiskMonitor-0-1/DivisionOperND.hpp>
#include <RiskMonitor-0-1/MaximumOperND.hpp>

namespace FpmlSerialized {

class OperatorND : public ISerialized { 
   public: 
       OperatorND(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isAdditionOperND(){return this->additionOperNDIsNull_;}
       boost::shared_ptr<AdditionOperND> getAdditionOperND();


       bool isMultipleOperND(){return this->multipleOperNDIsNull_;}
       boost::shared_ptr<MultipleOperND> getMultipleOperND();


       bool isDivisionOperND(){return this->divisionOperNDIsNull_;}
       boost::shared_ptr<DivisionOperND> getDivisionOperND();


       bool isMaximumOperND(){return this->maximumOperNDIsNull_;}
       boost::shared_ptr<MaximumOperND> getMaximumOperND();


       std::string getChoiceStr_operatorNDType(){
           std::string str;
           int count = 0;
           if(!additionOperNDIsNull_){
                count += 1;
                str = "additionOperND" ;
           }
           if(!multipleOperNDIsNull_){
                count += 1;
                str = "multipleOperND" ;
           }
           if(!divisionOperNDIsNull_){
                count += 1;
                str = "divisionOperND" ;
           }
           if(!maximumOperNDIsNull_){
                count += 1;
                str = "maximumOperND" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_operatorNDType_ = str ;
           return choiceStr_operatorNDType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<AdditionOperND> additionOperND_;     //choice
       
       bool additionOperNDIsNull_;
         boost::shared_ptr<MultipleOperND> multipleOperND_;     //choice
       
       bool multipleOperNDIsNull_;
         boost::shared_ptr<DivisionOperND> divisionOperND_;     //choice
       
       bool divisionOperNDIsNull_;
         boost::shared_ptr<MaximumOperND> maximumOperND_;     //choice
       
       bool maximumOperNDIsNull_;

       //choiceStr 
       std::string choiceStr_operatorNDType_;

};

} //namespaceFpmlSerialized end
#endif

