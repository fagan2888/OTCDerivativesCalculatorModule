// History.hpp 
#ifndef FpmlSerialized_History_hpp
#define FpmlSerialized_History_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/HisoryData.hpp>

namespace FpmlSerialized {

class History : public ISerialized { 
   public: 
       History(TiXmlNode* xmlNode);

       bool isHisoryData(){return this->hisoryDataIsNull_;}
       boost::shared_ptr<HisoryData> getHisoryData();


   protected: 
       boost::shared_ptr<HisoryData> hisoryData_;
       
       bool hisoryDataIsNull_;

};

} //namespaceFpmlSerialized end
#endif

