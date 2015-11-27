// Excel_valueSideResult.hpp 
#ifndef FpmlSerialized_Excel_valueSideResult_hpp
#define FpmlSerialized_Excel_valueSideResult_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class Excel_valueSideResult : public ISerialized { 
   public: 
       Excel_valueSideResult(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCurrency();


       bool isDirty(){return this->dirtyIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getDirty();


       bool isClean(){return this->cleanIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getClean();


       bool isAccrualAmt(){return this->accrualAmtIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getAccrualAmt();


       bool isOption(){return this->optionIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getOption();


   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeDouble> currency_;
       
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeDouble> dirty_;
       
       bool dirtyIsNull_;
       boost::shared_ptr<XsdTypeDouble> clean_;
       
       bool cleanIsNull_;
       boost::shared_ptr<XsdTypeDouble> accrualAmt_;
       
       bool accrualAmtIsNull_;
       boost::shared_ptr<XsdTypeDouble> option_;
       
       bool optionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

