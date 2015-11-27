// GbmGreekInfoResult.hpp 
#ifndef FpmlSerialized_GbmGreekInfoResult_hpp
#define FpmlSerialized_GbmGreekInfoResult_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/GbmGreekResult.hpp>

namespace FpmlSerialized {

class GbmGreekInfoResult : public ISerialized { 
   public: 
       GbmGreekInfoResult(TiXmlNode* xmlNode);

       bool isGbmGreekResult(){return this->gbmGreekResultIsNull_;}
       std::vector<boost::shared_ptr<GbmGreekResult>> getGbmGreekResult();


   protected: 
       std::vector<boost::shared_ptr<GbmGreekResult>> gbmGreekResult_;
       
       bool gbmGreekResultIsNull_;

};

} //namespaceFpmlSerialized end
#endif

