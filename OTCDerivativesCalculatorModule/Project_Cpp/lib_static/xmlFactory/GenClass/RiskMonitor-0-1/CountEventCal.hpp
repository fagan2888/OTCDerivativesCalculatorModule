// CountEventCal.hpp 
#ifndef FpmlSerialized_CountEventCal_hpp
#define FpmlSerialized_CountEventCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeInteger.hpp>
#include <RiskMonitor-0-1/EventCalculationList.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class CountEventCal : public ISerialized { 
   public: 
       CountEventCal(TiXmlNode* xmlNode);

       bool isNum(){return this->numIsNull_;}
       boost::shared_ptr<XsdTypeInteger> getNum();


       bool isEventCalculationList(){return this->eventCalculationListIsNull_;}
       boost::shared_ptr<EventCalculationList> getEventCalculationList();


       bool isComplement(){return this->complementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getComplement();


   protected: 
       boost::shared_ptr<XsdTypeInteger> num_;
       
       bool numIsNull_;
       boost::shared_ptr<EventCalculationList> eventCalculationList_;
       
       bool eventCalculationListIsNull_;
       boost::shared_ptr<XsdTypeBoolean> complement_;
       
       bool complementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

