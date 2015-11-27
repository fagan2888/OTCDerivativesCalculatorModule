// InstrumentTradeQuantity.hpp 
#ifndef FpmlSerialized_InstrumentTradeQuantity_hpp
#define FpmlSerialized_InstrumentTradeQuantity_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/Money.hpp>

namespace FpmlSerialized {

class InstrumentTradeQuantity : public ISerialized { 
   public: 
       InstrumentTradeQuantity(TiXmlNode* xmlNode);

       bool isNumber(){return this->numberIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNumber();
      std::string getNumberIDRef(){return numberIDRef_;}

       bool isNominal(){return this->nominalIsNull_;}
       boost::shared_ptr<Money> getNominal();
      std::string getNominalIDRef(){return nominalIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!numberIsNull_){
                count += 1;
                str = "number" ;
           }
           if(!nominalIsNull_){
                count += 1;
                str = "nominal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> number_;     //choice
       std::string numberIDRef_;
       bool numberIsNull_;
         boost::shared_ptr<Money> nominal_;     //choice
       std::string nominalIDRef_;
       bool nominalIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

