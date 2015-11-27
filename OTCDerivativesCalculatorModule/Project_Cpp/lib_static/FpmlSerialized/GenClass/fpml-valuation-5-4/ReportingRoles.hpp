// ReportingRoles.hpp 
#ifndef FpmlSerialized_ReportingRoles_hpp
#define FpmlSerialized_ReportingRoles_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>
#include <fpml-shared-5-4/AccountReference.hpp>

namespace FpmlSerialized {

class ReportingRoles : public ISerialized { 
   public: 
       ReportingRoles(TiXmlNode* xmlNode);

       bool isBaseParty(){return this->basePartyIsNull_;}
       boost::shared_ptr<PartyReference> getBaseParty();
      std::string getBasePartyIDRef(){return basePartyIDRef_;}

       bool isBaseAccount(){return this->baseAccountIsNull_;}
       boost::shared_ptr<AccountReference> getBaseAccount();
      std::string getBaseAccountIDRef(){return baseAccountIDRef_;}

       bool isActivityProvider(){return this->activityProviderIsNull_;}
       boost::shared_ptr<PartyReference> getActivityProvider();
      std::string getActivityProviderIDRef(){return activityProviderIDRef_;}

       bool isPositionProvider(){return this->positionProviderIsNull_;}
       boost::shared_ptr<PartyReference> getPositionProvider();
      std::string getPositionProviderIDRef(){return positionProviderIDRef_;}

       bool isValuationProvider(){return this->valuationProviderIsNull_;}
       boost::shared_ptr<PartyReference> getValuationProvider();
      std::string getValuationProviderIDRef(){return valuationProviderIDRef_;}

   protected: 
       boost::shared_ptr<PartyReference> baseParty_;
       std::string basePartyIDRef_;
       bool basePartyIsNull_;
       boost::shared_ptr<AccountReference> baseAccount_;
       std::string baseAccountIDRef_;
       bool baseAccountIsNull_;
       boost::shared_ptr<PartyReference> activityProvider_;
       std::string activityProviderIDRef_;
       bool activityProviderIsNull_;
       boost::shared_ptr<PartyReference> positionProvider_;
       std::string positionProviderIDRef_;
       bool positionProviderIsNull_;
       boost::shared_ptr<PartyReference> valuationProvider_;
       std::string valuationProviderIDRef_;
       bool valuationProviderIsNull_;

};

} //namespaceFpmlSerialized end
#endif

