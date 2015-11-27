// Excel_protectionTerms.hpp 
#ifndef FpmlSerialized_Excel_protectionTerms_hpp
#define FpmlSerialized_Excel_protectionTerms_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_creditEvents.hpp>
#include <RiskMonitor-0-1/Excel_obligations.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class Excel_protectionTerms : public ISerialized { 
   public: 
       Excel_protectionTerms(TiXmlNode* xmlNode);

       bool isExcel_creditEvents(){return this->excel_creditEventsIsNull_;}
       boost::shared_ptr<Excel_creditEvents> getExcel_creditEvents();


       bool isExcel_obligations(){return this->excel_obligationsIsNull_;}
       boost::shared_ptr<Excel_obligations> getExcel_obligations();


       bool isAccrualCoupon(){return this->accrualCouponIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAccrualCoupon();


   protected: 
       boost::shared_ptr<Excel_creditEvents> excel_creditEvents_;
       
       bool excel_creditEventsIsNull_;
       boost::shared_ptr<Excel_obligations> excel_obligations_;
       
       bool excel_obligationsIsNull_;
       boost::shared_ptr<XsdTypeBoolean> accrualCoupon_;
       
       bool accrualCouponIsNull_;

};

} //namespaceFpmlSerialized end
#endif

