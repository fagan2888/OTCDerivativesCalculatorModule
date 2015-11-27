// AdjustableDates.hpp 
#ifndef FpmlSerialized_AdjustableDates_hpp
#define FpmlSerialized_AdjustableDates_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/IdentifiedDate.hpp>
#include <fpml-shared-5-4/BusinessDayAdjustments.hpp>

namespace FpmlSerialized {

class AdjustableDates : public ISerialized { 
   public: 
       AdjustableDates(TiXmlNode* xmlNode);

       bool isUnadjustedDate(){return this->unadjustedDateIsNull_;}
       std::vector<boost::shared_ptr<IdentifiedDate>> getUnadjustedDate();
      std::string getUnadjustedDateIDRef(){return unadjustedDateIDRef_;}

       bool isDateAdjustments(){return this->dateAdjustmentsIsNull_;}
       boost::shared_ptr<BusinessDayAdjustments> getDateAdjustments();
      std::string getDateAdjustmentsIDRef(){return dateAdjustmentsIDRef_;}

       bool isAdjustedDate(){return this->adjustedDateIsNull_;}
       std::vector<boost::shared_ptr<IdentifiedDate>> getAdjustedDate();
      std::string getAdjustedDateIDRef(){return adjustedDateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<IdentifiedDate>> unadjustedDate_;
       std::string unadjustedDateIDRef_;
       bool unadjustedDateIsNull_;
       boost::shared_ptr<BusinessDayAdjustments> dateAdjustments_;
       std::string dateAdjustmentsIDRef_;
       bool dateAdjustmentsIsNull_;
       std::vector<boost::shared_ptr<IdentifiedDate>> adjustedDate_;
       std::string adjustedDateIDRef_;
       bool adjustedDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

