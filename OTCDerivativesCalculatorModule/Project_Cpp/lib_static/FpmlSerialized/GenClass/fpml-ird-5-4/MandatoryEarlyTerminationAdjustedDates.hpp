// MandatoryEarlyTerminationAdjustedDates.hpp 
#ifndef FpmlSerialized_MandatoryEarlyTerminationAdjustedDates_hpp
#define FpmlSerialized_MandatoryEarlyTerminationAdjustedDates_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class MandatoryEarlyTerminationAdjustedDates : public ISerialized { 
   public: 
       MandatoryEarlyTerminationAdjustedDates(TiXmlNode* xmlNode);

       bool isAdjustedEarlyTerminationDate(){return this->adjustedEarlyTerminationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedEarlyTerminationDate();
      std::string getAdjustedEarlyTerminationDateIDRef(){return adjustedEarlyTerminationDateIDRef_;}

       bool isAdjustedCashSettlementValuationDate(){return this->adjustedCashSettlementValuationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedCashSettlementValuationDate();
      std::string getAdjustedCashSettlementValuationDateIDRef(){return adjustedCashSettlementValuationDateIDRef_;}

       bool isAdjustedCashSettlementPaymentDate(){return this->adjustedCashSettlementPaymentDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getAdjustedCashSettlementPaymentDate();
      std::string getAdjustedCashSettlementPaymentDateIDRef(){return adjustedCashSettlementPaymentDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> adjustedEarlyTerminationDate_;
       std::string adjustedEarlyTerminationDateIDRef_;
       bool adjustedEarlyTerminationDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedCashSettlementValuationDate_;
       std::string adjustedCashSettlementValuationDateIDRef_;
       bool adjustedCashSettlementValuationDateIsNull_;
       boost::shared_ptr<XsdTypeDate> adjustedCashSettlementPaymentDate_;
       std::string adjustedCashSettlementPaymentDateIDRef_;
       bool adjustedCashSettlementPaymentDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

