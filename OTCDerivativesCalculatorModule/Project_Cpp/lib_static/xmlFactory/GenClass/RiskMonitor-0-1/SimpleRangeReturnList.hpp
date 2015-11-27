// SimpleRangeReturnList.hpp 
#ifndef FpmlSerialized_SimpleRangeReturnList_hpp
#define FpmlSerialized_SimpleRangeReturnList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/SimpleRangeReturn.hpp>

namespace FpmlSerialized {

class SimpleRangeReturnList : public ISerialized { 
   public: 
       SimpleRangeReturnList(TiXmlNode* xmlNode);

       bool isSimpleRangeReturn(){return this->simpleRangeReturnIsNull_;}
       std::vector<boost::shared_ptr<SimpleRangeReturn>> getSimpleRangeReturn();


   protected: 
       std::vector<boost::shared_ptr<SimpleRangeReturn>> simpleRangeReturn_;
       
       bool simpleRangeReturnIsNull_;

};

} //namespaceFpmlSerialized end
#endif

