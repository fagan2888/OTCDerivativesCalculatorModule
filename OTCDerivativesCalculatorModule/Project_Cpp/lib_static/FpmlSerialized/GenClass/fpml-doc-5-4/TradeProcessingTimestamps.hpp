// TradeProcessingTimestamps.hpp 
#ifndef FpmlSerialized_TradeProcessingTimestamps_hpp
#define FpmlSerialized_TradeProcessingTimestamps_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>
#include <fpml-doc-5-4/TradeTimestamp.hpp>

namespace FpmlSerialized {

class TradeProcessingTimestamps : public ISerialized { 
   public: 
       TradeProcessingTimestamps(TiXmlNode* xmlNode);

       bool isOrderEntered(){return this->orderEnteredIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getOrderEntered();
      std::string getOrderEnteredIDRef(){return orderEnteredIDRef_;}

       bool isOrderSubmitted(){return this->orderSubmittedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getOrderSubmitted();
      std::string getOrderSubmittedIDRef(){return orderSubmittedIDRef_;}

       bool isPubliclyReported(){return this->publiclyReportedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getPubliclyReported();
      std::string getPubliclyReportedIDRef(){return publiclyReportedIDRef_;}

       bool isPublicReportUpdated(){return this->publicReportUpdatedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getPublicReportUpdated();
      std::string getPublicReportUpdatedIDRef(){return publicReportUpdatedIDRef_;}

       bool isNonpubliclyReported(){return this->nonpubliclyReportedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getNonpubliclyReported();
      std::string getNonpubliclyReportedIDRef(){return nonpubliclyReportedIDRef_;}

       bool isNonpublicReportUpdated(){return this->nonpublicReportUpdatedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getNonpublicReportUpdated();
      std::string getNonpublicReportUpdatedIDRef(){return nonpublicReportUpdatedIDRef_;}

       bool isSubmittedForConfirmation(){return this->submittedForConfirmationIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getSubmittedForConfirmation();
      std::string getSubmittedForConfirmationIDRef(){return submittedForConfirmationIDRef_;}

       bool isUpdatedForConfirmation(){return this->updatedForConfirmationIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getUpdatedForConfirmation();
      std::string getUpdatedForConfirmationIDRef(){return updatedForConfirmationIDRef_;}

       bool isConfirmed(){return this->confirmedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getConfirmed();
      std::string getConfirmedIDRef(){return confirmedIDRef_;}

       bool isSubmittedForClearing(){return this->submittedForClearingIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getSubmittedForClearing();
      std::string getSubmittedForClearingIDRef(){return submittedForClearingIDRef_;}

       bool isUpdatedForClearing(){return this->updatedForClearingIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getUpdatedForClearing();
      std::string getUpdatedForClearingIDRef(){return updatedForClearingIDRef_;}

       bool isCleared(){return this->clearedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getCleared();
      std::string getClearedIDRef(){return clearedIDRef_;}

       bool isAllocationsSubmitted(){return this->allocationsSubmittedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getAllocationsSubmitted();
      std::string getAllocationsSubmittedIDRef(){return allocationsSubmittedIDRef_;}

       bool isAllocationsUpdated(){return this->allocationsUpdatedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getAllocationsUpdated();
      std::string getAllocationsUpdatedIDRef(){return allocationsUpdatedIDRef_;}

       bool isAllocationsCompleted(){return this->allocationsCompletedIsNull_;}
       boost::shared_ptr<XsdTypeDateTime> getAllocationsCompleted();
      std::string getAllocationsCompletedIDRef(){return allocationsCompletedIDRef_;}

       bool isTimestamp(){return this->timestampIsNull_;}
       std::vector<boost::shared_ptr<TradeTimestamp>> getTimestamp();
      std::string getTimestampIDRef(){return timestampIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDateTime> orderEntered_;
       std::string orderEnteredIDRef_;
       bool orderEnteredIsNull_;
       boost::shared_ptr<XsdTypeDateTime> orderSubmitted_;
       std::string orderSubmittedIDRef_;
       bool orderSubmittedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> publiclyReported_;
       std::string publiclyReportedIDRef_;
       bool publiclyReportedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> publicReportUpdated_;
       std::string publicReportUpdatedIDRef_;
       bool publicReportUpdatedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> nonpubliclyReported_;
       std::string nonpubliclyReportedIDRef_;
       bool nonpubliclyReportedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> nonpublicReportUpdated_;
       std::string nonpublicReportUpdatedIDRef_;
       bool nonpublicReportUpdatedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> submittedForConfirmation_;
       std::string submittedForConfirmationIDRef_;
       bool submittedForConfirmationIsNull_;
       boost::shared_ptr<XsdTypeDateTime> updatedForConfirmation_;
       std::string updatedForConfirmationIDRef_;
       bool updatedForConfirmationIsNull_;
       boost::shared_ptr<XsdTypeDateTime> confirmed_;
       std::string confirmedIDRef_;
       bool confirmedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> submittedForClearing_;
       std::string submittedForClearingIDRef_;
       bool submittedForClearingIsNull_;
       boost::shared_ptr<XsdTypeDateTime> updatedForClearing_;
       std::string updatedForClearingIDRef_;
       bool updatedForClearingIsNull_;
       boost::shared_ptr<XsdTypeDateTime> cleared_;
       std::string clearedIDRef_;
       bool clearedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> allocationsSubmitted_;
       std::string allocationsSubmittedIDRef_;
       bool allocationsSubmittedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> allocationsUpdated_;
       std::string allocationsUpdatedIDRef_;
       bool allocationsUpdatedIsNull_;
       boost::shared_ptr<XsdTypeDateTime> allocationsCompleted_;
       std::string allocationsCompletedIDRef_;
       bool allocationsCompletedIsNull_;
       std::vector<boost::shared_ptr<TradeTimestamp>> timestamp_;
       std::string timestampIDRef_;
       bool timestampIsNull_;

};

} //namespaceFpmlSerialized end
#endif

