// Excel_creditEventInfo.hpp 
#ifndef FpmlSerialized_Excel_creditEventInfo_hpp
#define FpmlSerialized_Excel_creditEventInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_referenceInformationList.hpp>
#include <RiskMonitor-0-1/Excel_jointProbabilityTrait.hpp>
#include <RiskMonitor-0-1/Excel_protectionTerms.hpp>

namespace FpmlSerialized {

class Excel_creditEventInfo : public ISerialized { 
   public: 
       Excel_creditEventInfo(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_referenceInformationList(){return this->excel_referenceInformationListIsNull_;}
       boost::shared_ptr<Excel_referenceInformationList> getExcel_referenceInformationList();


       bool isExcel_jointProbabilityTrait(){return this->excel_jointProbabilityTraitIsNull_;}
       boost::shared_ptr<Excel_jointProbabilityTrait> getExcel_jointProbabilityTrait();


       bool isExcel_protectionTerms(){return this->excel_protectionTermsIsNull_;}
       boost::shared_ptr<Excel_protectionTerms> getExcel_protectionTerms();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       boost::shared_ptr<Excel_referenceInformationList> excel_referenceInformationList_;
       
       bool excel_referenceInformationListIsNull_;
       boost::shared_ptr<Excel_jointProbabilityTrait> excel_jointProbabilityTrait_;
       
       bool excel_jointProbabilityTraitIsNull_;
       boost::shared_ptr<Excel_protectionTerms> excel_protectionTerms_;
       
       bool excel_protectionTermsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

