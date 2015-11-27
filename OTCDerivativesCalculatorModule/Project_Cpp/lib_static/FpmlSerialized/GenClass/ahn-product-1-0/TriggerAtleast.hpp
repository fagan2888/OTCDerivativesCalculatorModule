// TriggerAtleast.hpp 
#ifndef FpmlSerialized_TriggerAtleast_hpp
#define FpmlSerialized_TriggerAtleast_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class TriggerAtleast : public ISerialized { 
   public: 
       TriggerAtleast(TiXmlNode* xmlNode);

       bool isCount(){return this->countIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCount();
      std::string getCountIDRef(){return countIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDouble> count_;
       std::string countIDRef_;
       bool countIsNull_;

};

} //namespaceFpmlSerialized end
#endif

