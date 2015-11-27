// Excel_referenceInfo_para.hpp 
#ifndef FpmlSerialized_Excel_referenceInfo_para_hpp
#define FpmlSerialized_Excel_referenceInfo_para_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_defaultCurve.hpp>

namespace FpmlSerialized {

class Excel_referenceInfo_para : public ISerialized { 
   public: 
       Excel_referenceInfo_para(TiXmlNode* xmlNode);

       bool isExcel_type(){return this->excel_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExcel_type();


       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isReferenceName(){return this->referenceNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceName();


       bool isModel(){return this->modelIsNull_;}
       boost::shared_ptr<XsdTypeToken> getModel();


       bool isExcel_defaultCurve(){return this->excel_defaultCurveIsNull_;}
       boost::shared_ptr<Excel_defaultCurve> getExcel_defaultCurve();


       bool isDescription(){return this->descriptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDescription();


   protected: 
       boost::shared_ptr<XsdTypeToken> excel_type_;
       
       bool excel_typeIsNull_;
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> referenceName_;
       
       bool referenceNameIsNull_;
       boost::shared_ptr<XsdTypeToken> model_;
       
       bool modelIsNull_;
       boost::shared_ptr<Excel_defaultCurve> excel_defaultCurve_;
       
       bool excel_defaultCurveIsNull_;
       boost::shared_ptr<XsdTypeToken> description_;
       
       bool descriptionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

