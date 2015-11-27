// SimpleRangeEventList.hpp 
#ifndef FpmlSerialized_SimpleRangeEventList_hpp
#define FpmlSerialized_SimpleRangeEventList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/SimpleRangeEventCal.hpp>

namespace FpmlSerialized {

class SimpleRangeEventList : public ISerialized { 
   public: 
       SimpleRangeEventList(TiXmlNode* xmlNode);

       bool isSimpleRangeEventCal(){return this->simpleRangeEventCalIsNull_;}
       std::vector<boost::shared_ptr<SimpleRangeEventCal>> getSimpleRangeEventCal();


   protected: 
       std::vector<boost::shared_ptr<SimpleRangeEventCal>> simpleRangeEventCal_;
       
       bool simpleRangeEventCalIsNull_;

};

} //namespaceFpmlSerialized end
#endif

