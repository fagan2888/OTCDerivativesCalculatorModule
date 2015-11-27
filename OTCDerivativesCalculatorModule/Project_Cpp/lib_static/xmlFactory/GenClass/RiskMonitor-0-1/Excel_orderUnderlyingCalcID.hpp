// Excel_orderUnderlyingCalcID.hpp 
#ifndef FpmlSerialized_Excel_orderUnderlyingCalcID_hpp
#define FpmlSerialized_Excel_orderUnderlyingCalcID_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_selectedUnderlying.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_orderUnderlyingCalcID : public ISerialized { 
   public: 
       Excel_orderUnderlyingCalcID(TiXmlNode* xmlNode);

       bool isExcel_selectedUnderlying(){return this->excel_selectedUnderlyingIsNull_;}
       std::vector<boost::shared_ptr<Excel_selectedUnderlying>> getExcel_selectedUnderlying();


       bool isEventDate(){return this->eventDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEventDate();


       bool isNth(){return this->nthIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNth();


   protected: 
       std::vector<boost::shared_ptr<Excel_selectedUnderlying>> excel_selectedUnderlying_;
       
       bool excel_selectedUnderlyingIsNull_;
       boost::shared_ptr<XsdTypeToken> eventDate_;
       
       bool eventDateIsNull_;
       boost::shared_ptr<XsdTypeToken> nth_;
       
       bool nthIsNull_;

};

} //namespaceFpmlSerialized end
#endif

