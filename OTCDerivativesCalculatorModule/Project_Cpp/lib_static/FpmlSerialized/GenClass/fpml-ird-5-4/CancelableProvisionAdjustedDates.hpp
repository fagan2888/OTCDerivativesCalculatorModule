// CancelableProvisionAdjustedDates.hpp 
#ifndef FpmlSerialized_CancelableProvisionAdjustedDates_hpp
#define FpmlSerialized_CancelableProvisionAdjustedDates_hpp

#include <ISerialized.hpp>
#include <fpml-ird-5-4/CancellationEvent.hpp>

namespace FpmlSerialized {

class CancelableProvisionAdjustedDates : public ISerialized { 
   public: 
       CancelableProvisionAdjustedDates(TiXmlNode* xmlNode);

       bool isCancellationEvent(){return this->cancellationEventIsNull_;}
       std::vector<boost::shared_ptr<CancellationEvent>> getCancellationEvent();
      std::string getCancellationEventIDRef(){return cancellationEventIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<CancellationEvent>> cancellationEvent_;
       std::string cancellationEventIDRef_;
       bool cancellationEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

