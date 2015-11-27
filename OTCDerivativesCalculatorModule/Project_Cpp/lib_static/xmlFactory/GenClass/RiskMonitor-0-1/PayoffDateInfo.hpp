// PayoffDateInfo.hpp 
#ifndef FpmlSerialized_PayoffDateInfo_hpp
#define FpmlSerialized_PayoffDateInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/FixingDateInfo.hpp>

namespace FpmlSerialized {

class PayoffDateInfo : public ISerialized { 
   public: 
       PayoffDateInfo(TiXmlNode* xmlNode);

       bool isFixingDateInfo(){return this->fixingDateInfoIsNull_;}
       boost::shared_ptr<FixingDateInfo> getFixingDateInfo();


   protected: 
       boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
       
       bool fixingDateInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

