// GridCalculation.hpp 
#ifndef FpmlSerialized_GridCalculation_hpp
#define FpmlSerialized_GridCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/ProductInnerXml.hpp>

namespace FpmlSerialized {

class GridCalculation : public ISerialized { 
   public: 
       GridCalculation(TiXmlNode* xmlNode);

       bool isInst_code(){return this->inst_codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInst_code();


       bool isInst_name(){return this->inst_nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInst_name();


       bool isInst_type(){return this->inst_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInst_type();


       bool isPara_refDate(){return this->para_refDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPara_refDate();


       bool isProductInnerXml(){return this->productInnerXmlIsNull_;}
       boost::shared_ptr<ProductInnerXml> getProductInnerXml();


   protected: 
       boost::shared_ptr<XsdTypeToken> inst_code_;
       
       bool inst_codeIsNull_;
       boost::shared_ptr<XsdTypeToken> inst_name_;
       
       bool inst_nameIsNull_;
       boost::shared_ptr<XsdTypeToken> inst_type_;
       
       bool inst_typeIsNull_;
       boost::shared_ptr<XsdTypeToken> para_refDate_;
       
       bool para_refDateIsNull_;
       boost::shared_ptr<ProductInnerXml> productInnerXml_;
       
       bool productInnerXmlIsNull_;

};

} //namespaceFpmlSerialized end
#endif

