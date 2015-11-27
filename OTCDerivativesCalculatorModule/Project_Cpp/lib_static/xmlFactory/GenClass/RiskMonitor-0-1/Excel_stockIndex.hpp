// Excel_stockIndex.hpp 
#ifndef FpmlSerialized_Excel_stockIndex_hpp
#define FpmlSerialized_Excel_stockIndex_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_stockIndex : public ISerialized { 
   public: 
       Excel_stockIndex(TiXmlNode* xmlNode);

       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isBasePrice(){return this->basePriceIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBasePrice();


   protected: 
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> basePrice_;
       
       bool basePriceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

