// FixingInformation.hpp 
#ifndef FpmlSerialized_FixingInformation_hpp
#define FpmlSerialized_FixingInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <RiskMonitor-0-1/Fixing.hpp>

namespace FpmlSerialized {

class FixingInformation : public ISerialized { 
   public: 
       FixingInformation(TiXmlNode* xmlNode);

       bool isInitialValue(){return this->initialValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getInitialValue();


       bool isFixing(){return this->fixingIsNull_;}
       std::vector<boost::shared_ptr<Fixing>> getFixing();


   protected: 
       boost::shared_ptr<XsdTypeDouble> initialValue_;
       
       bool initialValueIsNull_;
       std::vector<boost::shared_ptr<Fixing>> fixing_;
       
       bool fixingIsNull_;

};

} //namespaceFpmlSerialized end
#endif

