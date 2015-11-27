// Excel_dualRangeEventCal.hpp 
#ifndef FpmlSerialized_Excel_dualRangeEventCal_hpp
#define FpmlSerialized_Excel_dualRangeEventCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcID.hpp>

namespace FpmlSerialized {

class Excel_dualRangeEventCal : public ISerialized { 
   public: 
       Excel_dualRangeEventCal(TiXmlNode* xmlNode);

       bool isLowerRng(){return this->lowerRngIsNull_;}
       boost::shared_ptr<XsdTypeToken> getLowerRng();


       bool isUpperRng(){return this->upperRngIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUpperRng();


       bool isExcel_underlyingCalcID(){return this->excel_underlyingCalcIDIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcID> getExcel_underlyingCalcID();


   protected: 
       boost::shared_ptr<XsdTypeToken> lowerRng_;
       
       bool lowerRngIsNull_;
       boost::shared_ptr<XsdTypeToken> upperRng_;
       
       bool upperRngIsNull_;
       boost::shared_ptr<Excel_underlyingCalcID> excel_underlyingCalcID_;
       
       bool excel_underlyingCalcIDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

