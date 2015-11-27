// Cash.hpp 
#ifndef FpmlSerialized_Cash_hpp
#define FpmlSerialized_Cash_hpp

#include <fpml-asset-5-4/Asset.hpp>
#include <fpml-shared-5-4/InstrumentId.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <fpml-shared-5-4/Currency.hpp>

namespace FpmlSerialized {

class Cash : public Asset { 
   public: 
       Cash(TiXmlNode* xmlNode);

       bool isInstrumentId(){return this->instrumentIdIsNull_;}
       std::vector<boost::shared_ptr<InstrumentId>> getInstrumentId();
      std::string getInstrumentIdIDRef(){return instrumentIdIDRef_;}

       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeString> getDescription();
      std::string getDescriptionIDRef(){return descriptionIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<Currency> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<InstrumentId>> instrumentId_;
       std::string instrumentIdIDRef_;
       bool instrumentIdIsNull_;
       boost::shared_ptr<XsdTypeString> description_;
       std::string descriptionIDRef_;
       bool descriptionIsNull_;
       boost::shared_ptr<Currency> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;

};

} //namespaceFpmlSerialized end
#endif

