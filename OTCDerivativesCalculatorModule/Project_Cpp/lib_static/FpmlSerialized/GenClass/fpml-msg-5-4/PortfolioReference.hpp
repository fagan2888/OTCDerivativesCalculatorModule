// PortfolioReference.hpp 
#ifndef FpmlSerialized_PortfolioReference_hpp
#define FpmlSerialized_PortfolioReference_hpp

#include <fpml-msg-5-4/PortfolioReferenceBase.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class PortfolioReference : public PortfolioReferenceBase { 
   public: 
       PortfolioReference(TiXmlNode* xmlNode);

       bool isSequenceNumber(){return this->sequenceNumberIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getSequenceNumber();
      std::string getSequenceNumberIDRef(){return sequenceNumberIDRef_;}

       bool isSubmissionsComplete(){return this->submissionsCompleteIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getSubmissionsComplete();
      std::string getSubmissionsCompleteIDRef(){return submissionsCompleteIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> sequenceNumber_;
       std::string sequenceNumberIDRef_;
       bool sequenceNumberIsNull_;
       boost::shared_ptr<XsdTypeBoolean> submissionsComplete_;
       std::string submissionsCompleteIDRef_;
       bool submissionsCompleteIsNull_;

};

} //namespaceFpmlSerialized end
#endif

