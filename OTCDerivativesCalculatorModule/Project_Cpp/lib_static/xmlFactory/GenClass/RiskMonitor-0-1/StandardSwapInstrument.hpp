// StandardSwapInstrument.hpp 
#ifndef FpmlSerialized_StandardSwapInstrument_hpp
#define FpmlSerialized_StandardSwapInstrument_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/IssueInformation.hpp>
#include <RiskMonitor-0-1/UnderlyingInformation.hpp>
#include <RiskMonitor-0-1/SwapPayoffInfo.hpp>

namespace FpmlSerialized {

class StandardSwapInstrument : public ISerialized { 
   public: 
       StandardSwapInstrument(TiXmlNode* xmlNode);

       bool isIssueInformation(){return this->issueInformationIsNull_;}
       boost::shared_ptr<IssueInformation> getIssueInformation();


       bool isUnderlyingInformation(){return this->underlyingInformationIsNull_;}
       boost::shared_ptr<UnderlyingInformation> getUnderlyingInformation();


       bool isSwapPayoffInfo(){return this->swapPayoffInfoIsNull_;}
       boost::shared_ptr<SwapPayoffInfo> getSwapPayoffInfo();


   protected: 
       boost::shared_ptr<IssueInformation> issueInformation_;
       
       bool issueInformationIsNull_;
       boost::shared_ptr<UnderlyingInformation> underlyingInformation_;
       
       bool underlyingInformationIsNull_;
       boost::shared_ptr<SwapPayoffInfo> swapPayoffInfo_;
       
       bool swapPayoffInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

