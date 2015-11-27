// StandardInstrument.hpp 
#ifndef FpmlSerialized_StandardInstrument_hpp
#define FpmlSerialized_StandardInstrument_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/IssueInformation.hpp>
#include <RiskMonitor-0-1/UnderlyingInformation.hpp>
#include <RiskMonitor-0-1/PayoffInfo.hpp>

namespace FpmlSerialized {

class StandardInstrument : public ISerialized { 
   public: 
       StandardInstrument(TiXmlNode* xmlNode);

       bool isIssueInformation(){return this->issueInformationIsNull_;}
       boost::shared_ptr<IssueInformation> getIssueInformation();


       bool isUnderlyingInformation(){return this->underlyingInformationIsNull_;}
       boost::shared_ptr<UnderlyingInformation> getUnderlyingInformation();


       bool isPayoffInfo(){return this->payoffInfoIsNull_;}
       boost::shared_ptr<PayoffInfo> getPayoffInfo();


   protected: 
       boost::shared_ptr<IssueInformation> issueInformation_;
       
       bool issueInformationIsNull_;
       boost::shared_ptr<UnderlyingInformation> underlyingInformation_;
       
       bool underlyingInformationIsNull_;
       boost::shared_ptr<PayoffInfo> payoffInfo_;
       
       bool payoffInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

