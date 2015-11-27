// ReturnSwap.hpp 
#ifndef FpmlSerialized_ReturnSwap_hpp
#define FpmlSerialized_ReturnSwap_hpp

#include <fpml-eq-shared-5-4/ReturnSwapBase.hpp>
#include <fpml-eq-shared-5-4/ReturnSwapAdditionalPayment.hpp>
#include <fpml-eq-shared-5-4/ReturnSwapEarlyTermination.hpp>
#include <fpml-eq-shared-5-4/ExtraordinaryEvents.hpp>

namespace FpmlSerialized {

class ReturnSwap : public ReturnSwapBase { 
   public: 
       ReturnSwap(TiXmlNode* xmlNode);

       bool isAdditionalPayment(){return this->additionalPaymentIsNull_;}
       std::vector<boost::shared_ptr<ReturnSwapAdditionalPayment>> getAdditionalPayment();
      std::string getAdditionalPaymentIDRef(){return additionalPaymentIDRef_;}

       bool isEarlyTermination(){return this->earlyTerminationIsNull_;}
       std::vector<boost::shared_ptr<ReturnSwapEarlyTermination>> getEarlyTermination();
      std::string getEarlyTerminationIDRef(){return earlyTerminationIDRef_;}

       bool isExtraordinaryEvents(){return this->extraordinaryEventsIsNull_;}
       boost::shared_ptr<ExtraordinaryEvents> getExtraordinaryEvents();
      std::string getExtraordinaryEventsIDRef(){return extraordinaryEventsIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<ReturnSwapAdditionalPayment>> additionalPayment_;
       std::string additionalPaymentIDRef_;
       bool additionalPaymentIsNull_;
       std::vector<boost::shared_ptr<ReturnSwapEarlyTermination>> earlyTermination_;
       std::string earlyTerminationIDRef_;
       bool earlyTerminationIsNull_;
       boost::shared_ptr<ExtraordinaryEvents> extraordinaryEvents_;
       std::string extraordinaryEventsIDRef_;
       bool extraordinaryEventsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

