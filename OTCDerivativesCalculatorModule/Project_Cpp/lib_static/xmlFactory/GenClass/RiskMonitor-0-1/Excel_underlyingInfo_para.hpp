// Excel_underlyingInfo_para.hpp 
#ifndef FpmlSerialized_Excel_underlyingInfo_para_hpp
#define FpmlSerialized_Excel_underlyingInfo_para_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingModel_para.hpp>

namespace FpmlSerialized {

class Excel_underlyingInfo_para : public ISerialized { 
   public: 
       Excel_underlyingInfo_para(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isUnderName(){return this->underNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderName();


       bool isBasePrice(){return this->basePriceIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBasePrice();


       bool isSub_type(){return this->sub_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSub_type();


       bool isRate_type(){return this->rate_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRate_type();


       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTenor();


       bool isLegTenor(){return this->legTenorIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLegTenor();


       bool isLinkedCurve(){return this->linkedCurveIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLinkedCurve();


       bool isExcel_underlyingModel_para(){return this->excel_underlyingModel_paraIsNull_;}
       boost::shared_ptr<Excel_underlyingModel_para> getExcel_underlyingModel_para();


       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getValue();


       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDescription();


   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> underName_;
       
       bool underNameIsNull_;
       boost::shared_ptr<XsdTypeToken> basePrice_;
       
       bool basePriceIsNull_;
       boost::shared_ptr<XsdTypeToken> sub_type_;
       
       bool sub_typeIsNull_;
       boost::shared_ptr<XsdTypeToken> rate_type_;
       
       bool rate_typeIsNull_;
       boost::shared_ptr<XsdTypeToken> tenor_;
       
       bool tenorIsNull_;
       boost::shared_ptr<XsdTypeToken> legTenor_;
       
       bool legTenorIsNull_;
       boost::shared_ptr<XsdTypeToken> linkedCurve_;
       
       bool linkedCurveIsNull_;
       boost::shared_ptr<Excel_underlyingModel_para> excel_underlyingModel_para_;
       
       bool excel_underlyingModel_paraIsNull_;
       boost::shared_ptr<XsdTypeToken> value_;
       
       bool valueIsNull_;
       boost::shared_ptr<XsdTypeToken> description_;
       
       bool descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

