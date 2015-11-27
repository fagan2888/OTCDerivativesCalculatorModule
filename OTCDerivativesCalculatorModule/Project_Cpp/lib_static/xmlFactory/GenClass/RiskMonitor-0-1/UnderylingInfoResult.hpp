// UnderylingInfoResult.hpp 
#ifndef FpmlSerialized_UnderylingInfoResult_hpp
#define FpmlSerialized_UnderylingInfoResult_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/UnderylingResult.hpp>

namespace FpmlSerialized {

class UnderylingInfoResult : public ISerialized { 
   public: 
       UnderylingInfoResult(TiXmlNode* xmlNode);

       bool isUnderylingResult(){return this->underylingResultIsNull_;}
       std::vector<boost::shared_ptr<UnderylingResult>> getUnderylingResult();


   protected: 
       std::vector<boost::shared_ptr<UnderylingResult>> underylingResult_;
       
       bool underylingResultIsNull_;

};

} //namespaceFpmlSerialized end
#endif

