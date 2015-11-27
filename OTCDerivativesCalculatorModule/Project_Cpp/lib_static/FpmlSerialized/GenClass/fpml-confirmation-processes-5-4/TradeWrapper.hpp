// TradeWrapper.hpp 
#ifndef FpmlSerialized_TradeWrapper_hpp
#define FpmlSerialized_TradeWrapper_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/OriginatingEvent.hpp>
#include <fpml-doc-5-4/Trade.hpp>
#include <fpml-business-events-5-4/TradeReferenceInformation.hpp>

namespace FpmlSerialized {

class TradeWrapper : public ISerialized { 
   public: 
       TradeWrapper(TiXmlNode* xmlNode);

       bool isOriginatingEvent(){return this->originatingEventIsNull_;}
       boost::shared_ptr<OriginatingEvent> getOriginatingEvent();
      std::string getOriginatingEventIDRef(){return originatingEventIDRef_;}

       bool isTrade(){return this->tradeIsNull_;}
       boost::shared_ptr<Trade> getTrade();
      std::string getTradeIDRef(){return tradeIDRef_;}

       bool isTradeReferenceInformation(){return this->tradeReferenceInformationIsNull_;}
       boost::shared_ptr<TradeReferenceInformation> getTradeReferenceInformation();
      std::string getTradeReferenceInformationIDRef(){return tradeReferenceInformationIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!originatingEventIsNull_){
                count += 1;
                str = "originatingEvent" ;
           }
           if(!tradeIsNull_){
                count += 1;
                str = "trade" ;
           }
           if(!tradeReferenceInformationIsNull_){
                count += 1;
                str = "tradeReferenceInformation" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<OriginatingEvent> originatingEvent_;     //choice
       std::string originatingEventIDRef_;
       bool originatingEventIsNull_;
         boost::shared_ptr<Trade> trade_;     //choice
       std::string tradeIDRef_;
       bool tradeIsNull_;
         boost::shared_ptr<TradeReferenceInformation> tradeReferenceInformation_;     //choice
       std::string tradeReferenceInformationIDRef_;
       bool tradeReferenceInformationIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

