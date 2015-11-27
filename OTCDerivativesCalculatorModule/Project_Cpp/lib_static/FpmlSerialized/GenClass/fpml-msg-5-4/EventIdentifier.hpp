// EventIdentifier.hpp 
#ifndef FpmlSerialized_EventIdentifier_hpp
#define FpmlSerialized_EventIdentifier_hpp

#include <ISerialized.hpp>
#include <fpml-msg-5-4/CorrelationId.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <fpml-doc-5-4/TradeIdentifier.hpp>

namespace FpmlSerialized {

class EventIdentifier : public ISerialized { 
   public: 
       EventIdentifier(TiXmlNode* xmlNode);

       bool isCorrelationId(){return this->correlationIdIsNull_;}
       boost::shared_ptr<CorrelationId> getCorrelationId();
      std::string getCorrelationIdIDRef(){return correlationIdIDRef_;}

       bool isSequenceNumber(){return this->sequenceNumberIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getSequenceNumber();
      std::string getSequenceNumberIDRef(){return sequenceNumberIDRef_;}

       bool isTradeIdentifier(){return this->tradeIdentifierIsNull_;}
       boost::shared_ptr<TradeIdentifier> getTradeIdentifier();
      std::string getTradeIdentifierIDRef(){return tradeIdentifierIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!correlationIdIsNull_){
                count += 1;
                str = "correlationId" ;
           }
           if(!sequenceNumberIsNull_){
                count += 1;
                str = "sequenceNumber" ;
           }
           if(!tradeIdentifierIsNull_){
                count += 1;
                str = "tradeIdentifier" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<CorrelationId> correlationId_;     //choice
       std::string correlationIdIDRef_;
       bool correlationIdIsNull_;
         boost::shared_ptr<XsdTypePositiveInteger> sequenceNumber_;     //choice
       std::string sequenceNumberIDRef_;
       bool sequenceNumberIsNull_;
         boost::shared_ptr<TradeIdentifier> tradeIdentifier_;     //choice
       std::string tradeIdentifierIDRef_;
       bool tradeIdentifierIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

