// FixedBondInstrument.hpp 
#ifndef FpmlSerialized_FixedBondInstrument_hpp
#define FpmlSerialized_FixedBondInstrument_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/BondInformation.hpp>
#include <RiskMonitor-0-1/BondCouponInfo.hpp>
#include <RiskMonitor-0-1/PayoffInfoAnalytic.hpp>

namespace FpmlSerialized {

class FixedBondInstrument : public ISerialized { 
   public: 
       FixedBondInstrument(TiXmlNode* xmlNode);

       bool isBondInformation(){return this->bondInformationIsNull_;}
       boost::shared_ptr<BondInformation> getBondInformation();


       bool isBondCouponInfo(){return this->bondCouponInfoIsNull_;}
       boost::shared_ptr<BondCouponInfo> getBondCouponInfo();


       bool isPayoffInfoAnalytic(){return this->payoffInfoAnalyticIsNull_;}
       boost::shared_ptr<PayoffInfoAnalytic> getPayoffInfoAnalytic();


   protected: 
       boost::shared_ptr<BondInformation> bondInformation_;
       
       bool bondInformationIsNull_;
       boost::shared_ptr<BondCouponInfo> bondCouponInfo_;
       
       bool bondCouponInfoIsNull_;
       boost::shared_ptr<PayoffInfoAnalytic> payoffInfoAnalytic_;
       
       bool payoffInfoAnalyticIsNull_;

};

} //namespaceFpmlSerialized end
#endif

