// BrokerEquityOption.hpp 
#ifndef FpmlSerialized_BrokerEquityOption_hpp
#define FpmlSerialized_BrokerEquityOption_hpp

#include <fpml-eqd-5-4/EquityDerivativeShortFormBase.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-shared-5-4/Money.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class BrokerEquityOption : public EquityDerivativeShortFormBase { 
   public: 
       BrokerEquityOption(TiXmlNode* xmlNode);

       bool isDeltaCrossed(){return this->deltaCrossedIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDeltaCrossed();
      std::string getDeltaCrossedIDRef(){return deltaCrossedIDRef_;}

       bool isBrokerageFee(){return this->brokerageFeeIsNull_;}
       boost::shared_ptr<Money> getBrokerageFee();
      std::string getBrokerageFeeIDRef(){return brokerageFeeIDRef_;}

       bool isBrokerNotes(){return this->brokerNotesIsNull_;}
       boost::shared_ptr<XsdTypeString> getBrokerNotes();
      std::string getBrokerNotesIDRef(){return brokerNotesIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> deltaCrossed_;
       std::string deltaCrossedIDRef_;
       bool deltaCrossedIsNull_;
       boost::shared_ptr<Money> brokerageFee_;
       std::string brokerageFeeIDRef_;
       bool brokerageFeeIsNull_;
       boost::shared_ptr<XsdTypeString> brokerNotes_;
       std::string brokerNotesIDRef_;
       bool brokerNotesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

