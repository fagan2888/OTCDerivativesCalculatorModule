// Excel_yieldCurve.hpp 
#ifndef FpmlSerialized_Excel_yieldCurve_hpp
#define FpmlSerialized_Excel_yieldCurve_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_interpolation.hpp>
#include <RiskMonitor-0-1/Excel_rateData.hpp>

namespace FpmlSerialized {

class Excel_yieldCurve : public ISerialized { 
   public: 
       Excel_yieldCurve(TiXmlNode* xmlNode);

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();


       bool isCode(){return this->codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCode();


       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDescription();


       bool isExcel_interpolation(){return this->excel_interpolationIsNull_;}
       boost::shared_ptr<Excel_interpolation> getExcel_interpolation();


       bool isExcel_rateData(){return this->excel_rateDataIsNull_;}
       std::vector<boost::shared_ptr<Excel_rateData>> getExcel_rateData();


   protected: 
       boost::shared_ptr<XsdTypeToken> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> code_;
       
       bool codeIsNull_;
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> description_;
       
       bool descriptionIsNull_;
       boost::shared_ptr<Excel_interpolation> excel_interpolation_;
       
       bool excel_interpolationIsNull_;
       std::vector<boost::shared_ptr<Excel_rateData>> excel_rateData_;
       
       bool excel_rateDataIsNull_;

};

} //namespaceFpmlSerialized end
#endif

