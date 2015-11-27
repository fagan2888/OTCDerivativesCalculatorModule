// MutualFund.hpp 
#ifndef FpmlSerialized_MutualFund_hpp
#define FpmlSerialized_MutualFund_hpp

#include <fpml-asset-5-4/UnderlyingAsset.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class MutualFund : public UnderlyingAsset { 
   public: 
       MutualFund(TiXmlNode* xmlNode);

       bool isOpenEndedFund(){return this->openEndedFundIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getOpenEndedFund();
      std::string getOpenEndedFundIDRef(){return openEndedFundIDRef_;}

       bool isFundManager(){return this->fundManagerIsNull_;}
       boost::shared_ptr<XsdTypeString> getFundManager();
      std::string getFundManagerIDRef(){return fundManagerIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> openEndedFund_;
       std::string openEndedFundIDRef_;
       bool openEndedFundIsNull_;
       boost::shared_ptr<XsdTypeString> fundManager_;
       std::string fundManagerIDRef_;
       bool fundManagerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

