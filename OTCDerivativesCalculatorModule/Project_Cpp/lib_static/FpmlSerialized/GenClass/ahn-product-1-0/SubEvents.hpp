// SubEvents.hpp 
#ifndef FpmlSerialized_SubEvents_hpp
#define FpmlSerialized_SubEvents_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class SubEvents : public ISerialized { 
   public: 
       SubEvents(TiXmlNode* xmlNode);

       bool isRefEvent(){return this->refEventIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getRefEvent();
      std::string getRefEventIDRef(){return refEventIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<XsdTypeToken>> refEvent_;
       std::string refEventIDRef_;
       bool refEventIsNull_;

};

} //namespaceFpmlSerialized end
#endif

