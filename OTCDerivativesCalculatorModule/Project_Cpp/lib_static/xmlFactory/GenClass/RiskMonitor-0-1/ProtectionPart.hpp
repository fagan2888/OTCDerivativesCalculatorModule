// ProtectionPart.hpp 
#ifndef FpmlSerialized_ProtectionPart_hpp
#define FpmlSerialized_ProtectionPart_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/ReferenceInformationList.hpp>
#include <RiskMonitor-0-1/ProtectionTerms.hpp>

namespace FpmlSerialized {

class ProtectionPart : public ISerialized { 
   public: 
       ProtectionPart(TiXmlNode* xmlNode);

       bool isPayRecieve(){return this->payRecieveIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayRecieve();


       bool isReferenceInformationList(){return this->referenceInformationListIsNull_;}
       boost::shared_ptr<ReferenceInformationList> getReferenceInformationList();


       bool isProtectionTerms(){return this->protectionTermsIsNull_;}
       boost::shared_ptr<ProtectionTerms> getProtectionTerms();


   protected: 
       boost::shared_ptr<XsdTypeToken> payRecieve_;
       
       bool payRecieveIsNull_;
       boost::shared_ptr<ReferenceInformationList> referenceInformationList_;
       
       bool referenceInformationListIsNull_;
       boost::shared_ptr<ProtectionTerms> protectionTerms_;
       
       bool protectionTermsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

