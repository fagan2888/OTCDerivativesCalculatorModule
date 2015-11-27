// CompressionActivity.hpp 
#ifndef FpmlSerialized_CompressionActivity_hpp
#define FpmlSerialized_CompressionActivity_hpp

#include <ISerialized.hpp>
#include <fpml-business-events-5-4/CompressionType.hpp>
#include <fpml-doc-5-4/TradeIdentifier.hpp>
#include <fpml-doc-5-4/TradeId.hpp>

namespace FpmlSerialized {

class CompressionActivity : public ISerialized { 
   public: 
       CompressionActivity(TiXmlNode* xmlNode);

       bool isCompressionType(){return this->compressionTypeIsNull_;}
       boost::shared_ptr<CompressionType> getCompressionType();
      std::string getCompressionTypeIDRef(){return compressionTypeIDRef_;}

       bool isReplacementTradeIdentifier(){return this->replacementTradeIdentifierIsNull_;}
       boost::shared_ptr<TradeIdentifier> getReplacementTradeIdentifier();
      std::string getReplacementTradeIdentifierIDRef(){return replacementTradeIdentifierIDRef_;}

       bool isOriginatingTradeIdentifier(){return this->originatingTradeIdentifierIsNull_;}
       std::vector<boost::shared_ptr<TradeIdentifier>> getOriginatingTradeIdentifier();
      std::string getOriginatingTradeIdentifierIDRef(){return originatingTradeIdentifierIDRef_;}

       bool isReplacementTradeId(){return this->replacementTradeIdIsNull_;}
       boost::shared_ptr<TradeId> getReplacementTradeId();
      std::string getReplacementTradeIdIDRef(){return replacementTradeIdIDRef_;}

       bool isOriginatingTradeId(){return this->originatingTradeIdIsNull_;}
       std::vector<boost::shared_ptr<TradeId>> getOriginatingTradeId();
      std::string getOriginatingTradeIdIDRef(){return originatingTradeIdIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!replacementTradeIdentifierIsNull_){
                count += 1;
                str = "replacementTradeIdentifier" ;
           }
           if(!originatingTradeIdentifierIsNull_){
                count += 1;
                str = "originatingTradeIdentifier" ;
           }
           if(!replacementTradeIdIsNull_){
                count += 1;
                str = "replacementTradeId" ;
           }
           if(!originatingTradeIdIsNull_){
                count += 1;
                str = "originatingTradeId" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<CompressionType> compressionType_;
       std::string compressionTypeIDRef_;
       bool compressionTypeIsNull_;
         boost::shared_ptr<TradeIdentifier> replacementTradeIdentifier_;     //choice
       std::string replacementTradeIdentifierIDRef_;
       bool replacementTradeIdentifierIsNull_;
         std::vector<boost::shared_ptr<TradeIdentifier>> originatingTradeIdentifier_;     //choice
       std::string originatingTradeIdentifierIDRef_;
       bool originatingTradeIdentifierIsNull_;
         boost::shared_ptr<TradeId> replacementTradeId_;     //choice
       std::string replacementTradeIdIDRef_;
       bool replacementTradeIdIsNull_;
         std::vector<boost::shared_ptr<TradeId>> originatingTradeId_;     //choice
       std::string originatingTradeIdIDRef_;
       bool originatingTradeIdIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

