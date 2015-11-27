// ParametorCalculation.hpp 
#ifndef FpmlSerialized_ParametorCalculation_hpp
#define FpmlSerialized_ParametorCalculation_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/DateRef.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class ParametorCalculation : public ISerialized { 
   public: 
       ParametorCalculation(TiXmlNode* xmlNode);

       bool isDateRef(){return this->dateRefIsNull_;}
       boost::shared_ptr<DateRef> getDateRef();
      std::string getDateRefIDRef(){return dateRefIDRef_;}

       bool isSymbolName(){return this->symbolNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSymbolName();
      std::string getSymbolNameIDRef(){return symbolNameIDRef_;}

       bool isConstValue(){return this->constValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getConstValue();
      std::string getConstValueIDRef(){return constValueIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       std::string getChoiceStr_paraType(){
           std::string str;
           int count = 0;
           if(!dateRefIsNull_){
                count += 1;
                str = "dateRef" ;
           }
           if(!symbolNameIsNull_){
                count += 1;
                str = "symbolName" ;
           }
           if(!constValueIsNull_){
                count += 1;
                str = "constValue" ;
           }
           if(!dateIsNull_){
                count += 1;
                str = "date" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_paraType_ = str ;
           return choiceStr_paraType_;
       }
   protected: 
         boost::shared_ptr<DateRef> dateRef_;     //choice
       std::string dateRefIDRef_;
       bool dateRefIsNull_;
         boost::shared_ptr<XsdTypeToken> symbolName_;     //choice
       std::string symbolNameIDRef_;
       bool symbolNameIsNull_;
         boost::shared_ptr<XsdTypeDouble> constValue_;     //choice
       std::string constValueIDRef_;
       bool constValueIsNull_;
         boost::shared_ptr<XsdTypeToken> date_;     //choice
       std::string dateIDRef_;
       bool dateIsNull_;

       //choiceStr 
       std::string choiceStr_paraType_;

};

} //namespaceFpmlSerialized end
#endif

