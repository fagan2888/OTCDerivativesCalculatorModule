// DailyReturnReferenceCal.hpp 
#ifndef FpmlSerialized_DailyReturnReferenceCal_hpp
#define FpmlSerialized_DailyReturnReferenceCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/FixingDateInfo.hpp>

namespace FpmlSerialized {

class DailyReturnReferenceCal : public ISerialized { 
   public: 
       DailyReturnReferenceCal(TiXmlNode* xmlNode);

       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isFixingDateInfo(){return this->fixingDateInfoIsNull_;}
       boost::shared_ptr<FixingDateInfo> getFixingDateInfo();


   protected: 
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
       
       bool fixingDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

