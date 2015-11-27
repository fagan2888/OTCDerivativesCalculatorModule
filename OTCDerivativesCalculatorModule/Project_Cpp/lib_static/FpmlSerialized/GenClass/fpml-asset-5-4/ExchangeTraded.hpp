// ExchangeTraded.hpp 
#ifndef FpmlSerialized_ExchangeTraded_hpp
#define FpmlSerialized_ExchangeTraded_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <fpml-shared-5-4/ExchangeId.hpp>

namespace FpmlSerialized {

class ExchangeTraded : public UnderlyingAsset { 
   public: 
       ExchangeTraded(TiXmlNode* xmlNode);

       bool isRelatedExchangeId(){return this->relatedExchangeIdIsNull_;}
       std::vector<boost::shared_ptr<ExchangeId>> getRelatedExchangeId();
      std::string getRelatedExchangeIdIDRef(){return relatedExchangeIdIDRef_;}

       bool isOptionsExchangeId(){return this->optionsExchangeIdIsNull_;}
       std::vector<boost::shared_ptr<ExchangeId>> getOptionsExchangeId();
      std::string getOptionsExchangeIdIDRef(){return optionsExchangeIdIDRef_;}

       bool isSpecifiedExchangeId(){return this->specifiedExchangeIdIsNull_;}
       std::vector<boost::shared_ptr<ExchangeId>> getSpecifiedExchangeId();
      std::string getSpecifiedExchangeIdIDRef(){return specifiedExchangeIdIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ExchangeId>> relatedExchangeId_;
       std::string relatedExchangeIdIDRef_;
       bool relatedExchangeIdIsNull_;
       std::vector<boost::shared_ptr<ExchangeId>> optionsExchangeId_;
       std::string optionsExchangeIdIDRef_;
       bool optionsExchangeIdIsNull_;
       std::vector<boost::shared_ptr<ExchangeId>> specifiedExchangeId_;
       std::string specifiedExchangeIdIDRef_;
       bool specifiedExchangeIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif

