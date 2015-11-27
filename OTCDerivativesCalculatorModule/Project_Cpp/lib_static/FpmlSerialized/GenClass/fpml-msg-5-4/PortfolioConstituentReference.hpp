// PortfolioConstituentReference.hpp 
#ifndef FpmlSerialized_PortfolioConstituentReference_hpp
#define FpmlSerialized_PortfolioConstituentReference_hpp

#include <fpml-msg-5-4/PortfolioReferenceBase.hpp>
#include <built_in_type/XsdTypePositiveInteger.hpp>

namespace FpmlSerialized {

class PortfolioConstituentReference : public PortfolioReferenceBase { 
   public: 
       PortfolioConstituentReference(TiXmlNode* xmlNode);

       bool isSequenceNumber(){return this->sequenceNumberIsNull_;}
       boost::shared_ptr<XsdTypePositiveInteger> getSequenceNumber();
      std::string getSequenceNumberIDRef(){return sequenceNumberIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypePositiveInteger> sequenceNumber_;
       std::string sequenceNumberIDRef_;
       bool sequenceNumberIsNull_;

};

} //namespaceFpmlSerialized end
#endif

