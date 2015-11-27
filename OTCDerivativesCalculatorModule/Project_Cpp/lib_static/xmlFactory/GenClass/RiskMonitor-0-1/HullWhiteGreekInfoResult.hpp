// HullWhiteGreekInfoResult.hpp 
#ifndef FpmlSerialized_HullWhiteGreekInfoResult_hpp
#define FpmlSerialized_HullWhiteGreekInfoResult_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/HullWhiteGreekResult.hpp>

namespace FpmlSerialized {

class HullWhiteGreekInfoResult : public ISerialized { 
   public: 
       HullWhiteGreekInfoResult(TiXmlNode* xmlNode);

       bool isHullWhiteGreekResult(){return this->hullWhiteGreekResultIsNull_;}
       std::vector<boost::shared_ptr<HullWhiteGreekResult>> getHullWhiteGreekResult();


   protected: 
       std::vector<boost::shared_ptr<HullWhiteGreekResult>> hullWhiteGreekResult_;
       
       bool hullWhiteGreekResultIsNull_;

};

} //namespaceFpmlSerialized end
#endif

