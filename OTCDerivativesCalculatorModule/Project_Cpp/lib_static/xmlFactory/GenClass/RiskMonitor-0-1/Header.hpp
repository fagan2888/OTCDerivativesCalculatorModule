// Header.hpp 
#ifndef FpmlSerialized_Header_hpp
#define FpmlSerialized_Header_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Header : public ISerialized { 
   public: 
       Header(TiXmlNode* xmlNode);

       bool isProductName(){return this->productNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getProductName();


       bool isProductType(){return this->productTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getProductType();


       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


   protected: 
       boost::shared_ptr<XsdTypeToken> productName_;
       
       bool productNameIsNull_;
       boost::shared_ptr<XsdTypeToken> productType_;
       
       bool productTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

