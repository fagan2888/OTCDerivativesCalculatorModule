// LoanParticipation.hpp 
#ifndef FpmlSerialized_LoanParticipation_hpp
#define FpmlSerialized_LoanParticipation_hpp

#include <fpml-cd-5-4/PCDeliverableObligationCharac.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class LoanParticipation : public PCDeliverableObligationCharac { 
   public: 
       LoanParticipation(TiXmlNode* xmlNode);

       bool isQualifyingParticipationSeller(){return this->qualifyingParticipationSellerIsNull_;}
       boost::shared_ptr<XsdTypeString> getQualifyingParticipationSeller();
      std::string getQualifyingParticipationSellerIDRef(){return qualifyingParticipationSellerIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeString> qualifyingParticipationSeller_;
       std::string qualifyingParticipationSellerIDRef_;
       bool qualifyingParticipationSellerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

