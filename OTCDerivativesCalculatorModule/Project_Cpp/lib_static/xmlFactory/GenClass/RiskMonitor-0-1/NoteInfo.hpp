// NoteInfo.hpp 
#ifndef FpmlSerialized_NoteInfo_hpp
#define FpmlSerialized_NoteInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <RiskMonitor-0-1/CalculationAmount.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class NoteInfo : public ISerialized { 
   public: 
       NoteInfo(TiXmlNode* xmlNode);

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<XsdTypeDate> getNotional();


       bool isTradeDate(){return this->tradeDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getTradeDate();


       bool isEffectiveDate(){return this->effectiveDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getEffectiveDate();


       bool isMaturityDate(){return this->maturityDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getMaturityDate();


       bool isCalculationAmount(){return this->calculationAmountIsNull_;}
       boost::shared_ptr<CalculationAmount> getCalculationAmount();


       bool isPremium(){return this->premiumIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getPremium();


   protected: 
       boost::shared_ptr<XsdTypeDate> notional_;
       
       bool notionalIsNull_;
       boost::shared_ptr<XsdTypeDate> tradeDate_;
       
       bool tradeDateIsNull_;
       boost::shared_ptr<XsdTypeDate> effectiveDate_;
       
       bool effectiveDateIsNull_;
       boost::shared_ptr<XsdTypeDate> maturityDate_;
       
       bool maturityDateIsNull_;
       boost::shared_ptr<CalculationAmount> calculationAmount_;
       
       bool calculationAmountIsNull_;
       boost::shared_ptr<XsdTypeDouble> premium_;
       
       bool premiumIsNull_;

};

} //namespaceFpmlSerialized end
#endif

