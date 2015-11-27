// InstrumentList.hpp 
#ifndef FpmlSerialized_InstrumentList_hpp
#define FpmlSerialized_InstrumentList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/InstHirachyInfo.hpp>

namespace FpmlSerialized {

class InstrumentList : public ISerialized { 
   public: 
       InstrumentList(TiXmlNode* xmlNode);

       bool isInstHirachyInfo(){return this->instHirachyInfoIsNull_;}
       std::vector<boost::shared_ptr<InstHirachyInfo>> getInstHirachyInfo();


   protected: 
       std::vector<boost::shared_ptr<InstHirachyInfo>> instHirachyInfo_;
       
       bool instHirachyInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

