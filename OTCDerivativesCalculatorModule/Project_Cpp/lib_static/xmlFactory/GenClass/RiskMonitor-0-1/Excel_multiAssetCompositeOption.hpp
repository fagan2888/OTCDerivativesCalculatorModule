// Excel_multiAssetCompositeOption.hpp 
#ifndef FpmlSerialized_Excel_multiAssetCompositeOption_hpp
#define FpmlSerialized_Excel_multiAssetCompositeOption_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_issueInfo.hpp>
#include <RiskMonitor-0-1/Excel_underlyingCalcInfo.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_multiAsset_compositeOption_subtype.hpp>

namespace FpmlSerialized {

class Excel_multiAssetCompositeOption : public ISerialized { 
   public: 
       Excel_multiAssetCompositeOption(TiXmlNode* xmlNode);

       bool isExcel_issueInfo(){return this->excel_issueInfoIsNull_;}
       boost::shared_ptr<Excel_issueInfo> getExcel_issueInfo();


       bool isExcel_underlyingCalcInfo(){return this->excel_underlyingCalcInfoIsNull_;}
       boost::shared_ptr<Excel_underlyingCalcInfo> getExcel_underlyingCalcInfo();


       bool isExerciseDate(){return this->exerciseDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getExerciseDate();


       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();


       bool isNotionalMaturityPayment(){return this->notionalMaturityPaymentIsNull_;}
       boost::shared_ptr<XsdTypeToken> getNotionalMaturityPayment();


       bool isExcel_multiAsset_compositeOption_subtype(){return this->excel_multiAsset_compositeOption_subtypeIsNull_;}
       std::vector<boost::shared_ptr<Excel_multiAsset_compositeOption_subtype>> getExcel_multiAsset_compositeOption_subtype();


   protected: 
       boost::shared_ptr<Excel_issueInfo> excel_issueInfo_;
       
       bool excel_issueInfoIsNull_;
       boost::shared_ptr<Excel_underlyingCalcInfo> excel_underlyingCalcInfo_;
       
       bool excel_underlyingCalcInfoIsNull_;
       boost::shared_ptr<XsdTypeToken> exerciseDate_;
       
       bool exerciseDateIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       
       bool payoffDateIsNull_;
       boost::shared_ptr<XsdTypeToken> notionalMaturityPayment_;
       
       bool notionalMaturityPaymentIsNull_;
       std::vector<boost::shared_ptr<Excel_multiAsset_compositeOption_subtype>> excel_multiAsset_compositeOption_subtype_;
       
       bool excel_multiAsset_compositeOption_subtypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

