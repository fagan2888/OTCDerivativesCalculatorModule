// Greek_result.hpp 
#ifndef FpmlSerialized_Greek_result_hpp
#define FpmlSerialized_Greek_result_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Greek_underlying.hpp>

namespace FpmlSerialized {

class Greek_result : public ISerialized { 
   public: 
       Greek_result(TiXmlNode* xmlNode);

       bool isGreek_underlying(){return this->greek_underlyingIsNull_;}
       std::vector<boost::shared_ptr<Greek_underlying>> getGreek_underlying();


   protected: 
       std::vector<boost::shared_ptr<Greek_underlying>> greek_underlying_;
       
       bool greek_underlyingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

