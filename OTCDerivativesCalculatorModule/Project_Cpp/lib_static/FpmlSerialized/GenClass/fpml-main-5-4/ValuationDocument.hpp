// ValuationDocument.hpp 
#ifndef FpmlSerialized_ValuationDocument_hpp
#define FpmlSerialized_ValuationDocument_hpp

#include <fpml-doc-5-4/DataDocument.hpp>
#include <fpml-riskdef-5-4/Market.hpp>
#include <fpml-valuation-5-4/ValuationSet.hpp>

namespace FpmlSerialized {

class ValuationDocument : public DataDocument { 
   public: 
       ValuationDocument(TiXmlNode* xmlNode);

       bool isMarket(){return this->marketIsNull_;}
       boost::shared_ptr<Market> getMarket();
      std::string getMarketIDRef(){return marketIDRef_;}

       bool isValuationSet(){return this->valuationSetIsNull_;}
       boost::shared_ptr<ValuationSet> getValuationSet();
      std::string getValuationSetIDRef(){return valuationSetIDRef_;}

   protected: 
       boost::shared_ptr<Market> market_;
       std::string marketIDRef_;
       bool marketIsNull_;
       boost::shared_ptr<ValuationSet> valuationSet_;
       std::string valuationSetIDRef_;
       bool valuationSetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

