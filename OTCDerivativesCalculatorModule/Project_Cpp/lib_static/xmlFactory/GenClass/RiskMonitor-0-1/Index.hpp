// Index.hpp 
#ifndef FpmlSerialized_Index_hpp
#define FpmlSerialized_Index_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/InterestRateIndex.hpp>
#include <RiskMonitor-0-1/StockIndex.hpp>

namespace FpmlSerialized {

class Index : public ISerialized { 
   public: 
       Index(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isBasePrice(){return this->basePriceIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBasePrice();


       bool isInterestRateIndex(){return this->interestRateIndexIsNull_;}
       boost::shared_ptr<InterestRateIndex> getInterestRateIndex();


       bool isStockIndex(){return this->stockIndexIsNull_;}
       boost::shared_ptr<StockIndex> getStockIndex();


       std::string getChoiceStr_indexType(){
           std::string str;
           int count = 0;
           if(!interestRateIndexIsNull_){
                count += 1;
                str = "interestRateIndex" ;
           }
           if(!stockIndexIsNull_){
                count += 1;
                str = "stockIndex" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_indexType_ = str ;
           return choiceStr_indexType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> basePrice_;
       
       bool basePriceIsNull_;
         boost::shared_ptr<InterestRateIndex> interestRateIndex_;     //choice
       
       bool interestRateIndexIsNull_;
         boost::shared_ptr<StockIndex> stockIndex_;     //choice
       
       bool stockIndexIsNull_;

       //choiceStr 
       std::string choiceStr_indexType_;

};

} //namespaceFpmlSerialized end
#endif

