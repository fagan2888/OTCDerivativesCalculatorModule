// ForwardContractInfo.hpp 
#ifndef FpmlSerialized_ForwardContractInfo_hpp
#define FpmlSerialized_ForwardContractInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class ForwardContractInfo : public ISerialized { 
   public: 
       ForwardContractInfo(TiXmlNode* xmlNode);

       bool isCalculationDate(){return this->calculationDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getCalculationDate();


       bool isSettlementDays(){return this->settlementDaysIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSettlementDays();


       bool isSettlementDate(){return this->settlementDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSettlementDate();


       bool isForwardPoint(){return this->forwardPointIsNull_;}
       boost::shared_ptr<XsdTypeToken> getForwardPoint();


   protected: 
       boost::shared_ptr<XsdTypeToken> calculationDate_;
       
       bool calculationDateIsNull_;
       boost::shared_ptr<XsdTypeToken> settlementDays_;
       
       bool settlementDaysIsNull_;
       boost::shared_ptr<XsdTypeToken> settlementDate_;
       
       bool settlementDateIsNull_;
       boost::shared_ptr<XsdTypeToken> forwardPoint_;
       
       bool forwardPointIsNull_;

};

} //namespaceFpmlSerialized end
#endif

