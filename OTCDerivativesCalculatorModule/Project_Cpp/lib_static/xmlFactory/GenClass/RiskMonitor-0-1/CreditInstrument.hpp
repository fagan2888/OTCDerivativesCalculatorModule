// CreditInstrument.hpp 
#ifndef FpmlSerialized_CreditInstrument_hpp
#define FpmlSerialized_CreditInstrument_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/IssueInformation.hpp>
#include <RiskMonitor-0-1/UnderlyingInformation.hpp>
#include <RiskMonitor-0-1/CreditPayoffInfo.hpp>

namespace FpmlSerialized {

class CreditInstrument : public ISerialized { 
   public: 
       CreditInstrument(TiXmlNode* xmlNode);

       bool isIssueInformation(){return this->issueInformationIsNull_;}
       boost::shared_ptr<IssueInformation> getIssueInformation();


       bool isUnderlyingInformation(){return this->underlyingInformationIsNull_;}
       boost::shared_ptr<UnderlyingInformation> getUnderlyingInformation();


       bool isCreditPayoffInfo(){return this->creditPayoffInfoIsNull_;}
       boost::shared_ptr<CreditPayoffInfo> getCreditPayoffInfo();


   protected: 
       boost::shared_ptr<IssueInformation> issueInformation_;
       
       bool issueInformationIsNull_;
       boost::shared_ptr<UnderlyingInformation> underlyingInformation_;
       
       bool underlyingInformationIsNull_;
       boost::shared_ptr<CreditPayoffInfo> creditPayoffInfo_;
       
       bool creditPayoffInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

