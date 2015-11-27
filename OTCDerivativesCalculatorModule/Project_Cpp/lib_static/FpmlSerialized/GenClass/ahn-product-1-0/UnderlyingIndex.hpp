// UnderlyingIndex.hpp 
#ifndef FpmlSerialized_UnderlyingIndex_hpp
#define FpmlSerialized_UnderlyingIndex_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/StockIndex.hpp>
#include <ahn-product-1-0/InterestrateIndex.hpp>
#include <ahn-product-1-0/CommodityIndex.hpp>

namespace FpmlSerialized {

class UnderlyingIndex : public ISerialized { 
   public: 
       UnderlyingIndex(TiXmlNode* xmlNode);

       bool isStockIndex(){return this->stockIndexIsNull_;}
       boost::shared_ptr<StockIndex> getStockIndex();
      std::string getStockIndexIDRef(){return stockIndexIDRef_;}

       bool isInterestrateIndex(){return this->interestrateIndexIsNull_;}
       boost::shared_ptr<InterestrateIndex> getInterestrateIndex();
      std::string getInterestrateIndexIDRef(){return interestrateIndexIDRef_;}

       bool isCommodityIndex(){return this->commodityIndexIsNull_;}
       boost::shared_ptr<CommodityIndex> getCommodityIndex();
      std::string getCommodityIndexIDRef(){return commodityIndexIDRef_;}

       std::string getChoiceStr_indexType(){
           std::string str;
           int count = 0;
           if(!stockIndexIsNull_){
                count += 1;
                str = "stockIndex" ;
           }
           if(!interestrateIndexIsNull_){
                count += 1;
                str = "interestrateIndex" ;
           }
           if(!commodityIndexIsNull_){
                count += 1;
                str = "commodityIndex" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_indexType_ = str ;
           return choiceStr_indexType_;
       }
   protected: 
         boost::shared_ptr<StockIndex> stockIndex_;     //choice
       std::string stockIndexIDRef_;
       bool stockIndexIsNull_;
         boost::shared_ptr<InterestrateIndex> interestrateIndex_;     //choice
       std::string interestrateIndexIDRef_;
       bool interestrateIndexIsNull_;
         boost::shared_ptr<CommodityIndex> commodityIndex_;     //choice
       std::string commodityIndexIDRef_;
       bool commodityIndexIsNull_;

       //choiceStr 
       std::string choiceStr_indexType_;

};

} //namespaceFpmlSerialized end
#endif

