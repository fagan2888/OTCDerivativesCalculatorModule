// ReferenceObligation.hpp 
#ifndef FpmlSerialized_ReferenceObligation_hpp
#define FpmlSerialized_ReferenceObligation_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Bond.hpp>

namespace FpmlSerialized {

class ReferenceObligation : public ISerialized { 
   public: 
       ReferenceObligation(TiXmlNode* xmlNode);

       bool isBond(){return this->bondIsNull_;}
       boost::shared_ptr<Bond> getBond();


   protected: 
       boost::shared_ptr<Bond> bond_;
       
       bool bondIsNull_;

};

} //namespaceFpmlSerialized end
#endif

