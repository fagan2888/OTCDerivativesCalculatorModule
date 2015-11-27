// Representations.hpp 
#ifndef FpmlSerialized_Representations_hpp
#define FpmlSerialized_Representations_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class Representations : public ISerialized { 
   public: 
       Representations(TiXmlNode* xmlNode);

       bool isNonReliance(){return this->nonRelianceIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getNonReliance();
      std::string getNonRelianceIDRef(){return nonRelianceIDRef_;}

       bool isAgreementsRegardingHedging(){return this->agreementsRegardingHedgingIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAgreementsRegardingHedging();
      std::string getAgreementsRegardingHedgingIDRef(){return agreementsRegardingHedgingIDRef_;}

       bool isIndexDisclaimer(){return this->indexDisclaimerIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getIndexDisclaimer();
      std::string getIndexDisclaimerIDRef(){return indexDisclaimerIDRef_;}

       bool isAdditionalAcknowledgements(){return this->additionalAcknowledgementsIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getAdditionalAcknowledgements();
      std::string getAdditionalAcknowledgementsIDRef(){return additionalAcknowledgementsIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> nonReliance_;
       std::string nonRelianceIDRef_;
       bool nonRelianceIsNull_;
       boost::shared_ptr<XsdTypeBoolean> agreementsRegardingHedging_;
       std::string agreementsRegardingHedgingIDRef_;
       bool agreementsRegardingHedgingIsNull_;
       boost::shared_ptr<XsdTypeBoolean> indexDisclaimer_;
       std::string indexDisclaimerIDRef_;
       bool indexDisclaimerIsNull_;
       boost::shared_ptr<XsdTypeBoolean> additionalAcknowledgements_;
       std::string additionalAcknowledgementsIDRef_;
       bool additionalAcknowledgementsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

