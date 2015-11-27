// BarrierDateInfo.hpp 
#ifndef FpmlSerialized_BarrierDateInfo_hpp
#define FpmlSerialized_BarrierDateInfo_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/DateInformation.hpp>

namespace FpmlSerialized {

class BarrierDateInfo : public ISerialized { 
   public: 
       BarrierDateInfo(TiXmlNode* xmlNode);

       bool isDateInformation(){return this->dateInformationIsNull_;}
       boost::shared_ptr<DateInformation> getDateInformation();


   protected: 
       boost::shared_ptr<DateInformation> dateInformation_;
       
       bool dateInformationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

