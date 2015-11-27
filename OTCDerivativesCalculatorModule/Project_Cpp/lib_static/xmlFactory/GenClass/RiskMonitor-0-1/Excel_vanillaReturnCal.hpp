// Excel_vanillaReturnCal.hpp 
#ifndef FpmlSerialized_Excel_vanillaReturnCal_hpp
#define FpmlSerialized_Excel_vanillaReturnCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcID.hpp>

namespace FpmlSerialized {

class Excel_vanillaReturnCal : public ISerialized { 
   public: 
       Excel_vanillaReturnCal(TiXmlNode* xmlNode);

       bool isGearing(){return this->gearingIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGearing();


       bool isSpread(){return this->spreadIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSpread();


       bool isExcel_underlyingCalcID(){return this->excel_underlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcID> getExcel_underlyingCalcID();


   protected: 
       boost::shared_ptr<XsdTypeToken> gearing_;
       
       bool gearingIsNull_;
       boost::shared_ptr<XsdTypeToken> spread_;
       
       bool spreadIsNull_;
       boost::shared_ptr<Excel_underlyingCalcID> excel_underlyingCalcID_;
       
       bool excel_underlyingCalcIDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

