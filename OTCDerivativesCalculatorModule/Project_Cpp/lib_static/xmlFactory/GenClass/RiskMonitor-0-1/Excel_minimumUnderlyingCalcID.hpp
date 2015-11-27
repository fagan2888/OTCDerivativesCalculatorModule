// Excel_minimumUnderlyingCalcID.hpp 
#ifndef FpmlSerialized_Excel_minimumUnderlyingCalcID_hpp
#define FpmlSerialized_Excel_minimumUnderlyingCalcID_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_selectedUnderlying.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_minimumUnderlyingCalcID : public ISerialized { 
   public: 
       Excel_minimumUnderlyingCalcID(TiXmlNode* xmlNode);

       bool isExcel_selectedUnderlying(){return this->excel_selectedUnderlyingIsNull_;}
       std::vector<boost::shared_ptr<Excel_selectedUnderlying>> getExcel_selectedUnderlying();


       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isAverageDays(){return this->averageDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getAverageDays();


   protected: 
       std::vector<boost::shared_ptr<Excel_selectedUnderlying>> excel_selectedUnderlying_;
       
       bool excel_selectedUnderlyingIsNull_;
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> averageDays_;
       
       bool averageDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

