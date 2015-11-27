// PhysicalExercise.hpp 
#ifndef FpmlSerialized_PhysicalExercise_hpp
#define FpmlSerialized_PhysicalExercise_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifiers.hpp>

namespace FpmlSerialized {

class PhysicalExercise : public ISerialized { 
   public: 
       PhysicalExercise(TiXmlNode* xmlNode);

       bool isTrade(){return this->tradeIsNull_;}
       boost::shared_ptr<Trade> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isTradeReference(){return this->tradeReferenceIsNull_;}
       boost::shared_ptr<PartyTradeIdentifiers> getTradeReference();
      std::string getTradeReferenceIDRef(){return tradeReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!tradeIsNull_){
                count += 1;
                str = "trade" ;
           }
           if(!tradeReferenceIsNull_){
                count += 1;
                str = "tradeReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<Trade> trade_;     //choice
       std::string tradeIDRef_;
       bool tradeIsNull_;
         boost::shared_ptr<PartyTradeIdentifiers> tradeReference_;     //choice
       std::string tradeReferenceIDRef_;
       bool tradeReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

