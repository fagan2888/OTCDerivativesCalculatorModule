// Excel_referSimpleCalculation.hpp 
#ifndef FpmlSerialized_Excel_referSimpleCalculation_hpp
#define FpmlSerialized_Excel_referSimpleCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_referSimpleCalculation : public ISerialized { 
   public: 
       Excel_referSimpleCalculation(TiXmlNode* xmlNode);

       bool isCalculationID(){return this->calculationIDIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationID();


       bool isReferenceType(){return this->referenceTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceType();


       bool isReferenceSet(){return this->referenceSetIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReferenceSet();


       bool isNth(){return this->nthIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNth();


       bool isAverageDays(){return this->averageDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getAverageDays();


   protected: 
       boost::shared_ptr<XsdTypeToken> calculationID_;
       
       bool calculationIDIsNull_;
       boost::shared_ptr<XsdTypeToken> referenceType_;
       
       bool referenceTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> referenceSet_;
       
       bool referenceSetIsNull_;
       boost::shared_ptr<XsdTypeToken> nth_;
       
       bool nthIsNull_;
       boost::shared_ptr<XsdTypeToken> averageDays_;
       
       bool averageDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

