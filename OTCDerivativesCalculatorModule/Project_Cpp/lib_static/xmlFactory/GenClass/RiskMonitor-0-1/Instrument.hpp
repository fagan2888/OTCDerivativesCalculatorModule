// Instrument.hpp 
#ifndef FpmlSerialized_Instrument_hpp
#define FpmlSerialized_Instrument_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_interface.hpp>
#include <RiskMonitor-0-1/Excel_swapInterface.hpp>

namespace FpmlSerialized {

class Instrument : public ISerialized { 
   public: 
       Instrument(TiXmlNode* xmlNode);

       bool isCode(){return this->codeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCode();


       bool isExcel_interface(){return this->excel_interfaceIsNull_;}
       boost::shared_ptr<Excel_interface> getExcel_interface();


       bool isExcel_swapInterface(){return this->excel_swapInterfaceIsNull_;}
       boost::shared_ptr<Excel_swapInterface> getExcel_swapInterface();


   protected: 
       boost::shared_ptr<XsdTypeToken> code_;
       
       bool codeIsNull_;
       boost::shared_ptr<Excel_interface> excel_interface_;
       
       bool excel_interfaceIsNull_;
       boost::shared_ptr<Excel_swapInterface> excel_swapInterface_;
       
       bool excel_swapInterfaceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

