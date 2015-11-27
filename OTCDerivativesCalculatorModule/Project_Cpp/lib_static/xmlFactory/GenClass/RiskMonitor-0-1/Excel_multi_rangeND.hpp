// Excel_multi_rangeND.hpp 
#ifndef FpmlSerialized_Excel_multi_rangeND_hpp
#define FpmlSerialized_Excel_multi_rangeND_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Range1D.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcID.hpp>

namespace FpmlSerialized {

class Excel_multi_rangeND : public ISerialized { 
   public: 
       Excel_multi_rangeND(TiXmlNode* xmlNode);

       bool isJoint_type(){return this->joint_typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getJoint_type();


       bool isRange1D(){return this->range1DIsNull_;}
       std::vector<boost::shared_ptr<Range1D>> getRange1D();


       bool isExcel_underlyingCalcID(){return this->excel_underlyingCalcIDIsNull_;}
       std::vector<boost::shared_ptr<Excel_underlyingCalcID>> getExcel_underlyingCalcID();


   protected: 
       boost::shared_ptr<XsdTypeToken> joint_type_;
       
       bool joint_typeIsNull_;
       std::vector<boost::shared_ptr<Range1D>> range1D_;
       
       bool range1DIsNull_;
       std::vector<boost::shared_ptr<Excel_underlyingCalcID>> excel_underlyingCalcID_;
       
       bool excel_underlyingCalcIDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

