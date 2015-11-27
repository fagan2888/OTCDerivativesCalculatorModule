// DividendPeriod.hpp 
#ifndef FpmlSerialized_DividendPeriod_hpp
#define FpmlSerialized_DividendPeriod_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>
#include <fpml-asset-5-4/AssetReference.hpp>

namespace FpmlSerialized {

class DividendPeriod : public ISerialized { 
   public: 
       DividendPeriod(TiXmlNode* xmlNode);

       bool isUnadjustedStartDate(){return this->unadjustedStartDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getUnadjustedStartDate();
      std::string getUnadjustedStartDateIDRef(){return unadjustedStartDateIDRef_;}

       bool isUnadjustedEndDate(){return this->unadjustedEndDateIsNull_;}
       boost::shared_ptr<IdentifiedDate> getUnadjustedEndDate();
      std::string getUnadjustedEndDateIDRef(){return unadjustedEndDateIDRef_;}

       bool isDateAdjustments(){return this->dateAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getDateAdjustments();
      std::string getDateAdjustmentsIDRef(){return dateAdjustmentsIDRef_;}

       bool isUnderlyerReference(){return this->underlyerReferenceIsNull_;}
       boost::shared_ptr<AssetReference> getUnderlyerReference();
      std::string getUnderlyerReferenceIDRef(){return underlyerReferenceIDRef_;}

   protected: 
       boost::shared_ptr<IdentifiedDate> unadjustedStartDate_;
       std::string unadjustedStartDateIDRef_;
       bool unadjustedStartDateIsNull_;
       boost::shared_ptr<IdentifiedDate> unadjustedEndDate_;
       std::string unadjustedEndDateIDRef_;
       bool unadjustedEndDateIsNull_;
       boost::shared_ptr<BusinessDayAdjustments> dateAdjustments_;
       std::string dateAdjustmentsIDRef_;
       bool dateAdjustmentsIsNull_;
       boost::shared_ptr<AssetReference> underlyerReference_;
       std::string underlyerReferenceIDRef_;
       bool underlyerReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

