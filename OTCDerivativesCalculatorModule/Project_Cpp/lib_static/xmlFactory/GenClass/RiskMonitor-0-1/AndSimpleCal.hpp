// AndSimpleCal.hpp 
#ifndef FpmlSerialized_AndSimpleCal_hpp
#define FpmlSerialized_AndSimpleCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class AndSimpleCal : public ISerialized { 
   public: 
       AndSimpleCal(TiXmlNode* xmlNode);

       bool isPastOcc(){return this->pastOccIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPastOcc();


   protected: 
       boost::shared_ptr<XsdTypeBoolean> pastOcc_;
       
       bool pastOccIsNull_;

};

} //namespaceFpmlSerialized end
#endif

