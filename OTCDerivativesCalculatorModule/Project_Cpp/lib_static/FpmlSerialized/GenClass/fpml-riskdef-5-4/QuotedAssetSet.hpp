// QuotedAssetSet.hpp 
#ifndef FpmlSerialized_QuotedAssetSet_hpp
#define FpmlSerialized_QuotedAssetSet_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/InstrumentSet.hpp>
#include <fpml-riskdef-5-4/BasicAssetValuation.hpp>

namespace FpmlSerialized {

class QuotedAssetSet : public ISerialized { 
   public: 
       QuotedAssetSet(TiXmlNode* xmlNode);

       bool isInstrumentSet(){return this->instrumentSetIsNull_;}
       boost::shared_ptr<InstrumentSet> getInstrumentSet();
      std::string getInstrumentSetIDRef(){return instrumentSetIDRef_;}

       bool isAssetQuote(){return this->assetQuoteIsNull_;}
       std::vector<boost::shared_ptr<BasicAssetValuation>> getAssetQuote();
      std::string getAssetQuoteIDRef(){return assetQuoteIDRef_;}

   protected: 
       boost::shared_ptr<InstrumentSet> instrumentSet_;
       std::string instrumentSetIDRef_;
       bool instrumentSetIsNull_;
       std::vector<boost::shared_ptr<BasicAssetValuation>> assetQuote_;
       std::string assetQuoteIDRef_;
       bool assetQuoteIsNull_;

};

} //namespaceFpmlSerialized end
#endif

