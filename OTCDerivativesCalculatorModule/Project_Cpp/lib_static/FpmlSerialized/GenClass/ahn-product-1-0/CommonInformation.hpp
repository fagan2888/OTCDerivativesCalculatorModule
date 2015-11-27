// CommonInformation.hpp 
#ifndef FpmlSerialized_CommonInformation_hpp
#define FpmlSerialized_CommonInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class CommonInformation : public ISerialized { 
   public: 
       CommonInformation(TiXmlNode* xmlNode);

       bool isBusinessDay(){return this->businessDayIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBusinessDay();
      std::string getBusinessDayIDRef(){return businessDayIDRef_;}

       bool isBusinessDayConvenction(){return this->businessDayConvenctionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getBusinessDayConvenction();
      std::string getBusinessDayConvenctionIDRef(){return businessDayConvenctionIDRef_;}

       bool isDaycounter(){return this->daycounterIsNull_;}
       boost::shared_ptr<XsdTypeToken> getDaycounter();
      std::string getDaycounterIDRef(){return daycounterIDRef_;}

       bool isCurrency(){return this->currencyIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCurrency();
      std::string getCurrencyIDRef(){return currencyIDRef_;}

       bool isImbededOption(){return this->imbededOptionIsNull_;}
       boost::shared_ptr<XsdTypeToken> getImbededOption();
      std::string getImbededOptionIDRef(){return imbededOptionIDRef_;}

       bool isCalendar(){return this->calendarIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalendar();
      std::string getCalendarIDRef(){return calendarIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> businessDay_;
       std::string businessDayIDRef_;
       bool businessDayIsNull_;
       boost::shared_ptr<XsdTypeToken> businessDayConvenction_;
       std::string businessDayConvenctionIDRef_;
       bool businessDayConvenctionIsNull_;
       boost::shared_ptr<XsdTypeToken> daycounter_;
       std::string daycounterIDRef_;
       bool daycounterIsNull_;
       boost::shared_ptr<XsdTypeToken> currency_;
       std::string currencyIDRef_;
       bool currencyIsNull_;
       boost::shared_ptr<XsdTypeToken> imbededOption_;
       std::string imbededOptionIDRef_;
       bool imbededOptionIsNull_;
       boost::shared_ptr<XsdTypeToken> calendar_;
       std::string calendarIDRef_;
       bool calendarIsNull_;

};

} //namespaceFpmlSerialized end
#endif

