// PositionConstituent.hpp 
#ifndef FpmlSerialized_PositionConstituent_hpp
#define FpmlSerialized_PositionConstituent_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-doc-5-4/PartyTradeIdentifiers.hpp>

namespace FpmlSerialized {

class PositionConstituent : public ISerialized { 
   public: 
       PositionConstituent(TiXmlNode* xmlNode);

       bool isTrade(){return this->tradeIsNull_;}
       boost::shared_ptr<Trade> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isPositionVersionReference(){return this->positionVersionReferenceIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getPositionVersionReference();
      std::string getPositionVersionReferenceIDRef(){return positionVersionReferenceIDRef_;}

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
           if(!positionVersionReferenceIsNull_){
                count += 1;
                str = "positionVersionReference" ;
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
         boost::shared_ptr<XsdTypePositiveInteger> positionVersionReference_;     //choice
       std::string positionVersionReferenceIDRef_;
       bool positionVersionReferenceIsNull_;
         boost::shared_ptr<PartyTradeIdentifiers> tradeReference_;     //choice
       std::string tradeReferenceIDRef_;
       bool tradeReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

