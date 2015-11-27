// SingeSimpleCal.hpp 
#ifndef FpmlSerialized_SingeSimpleCal_hpp
#define FpmlSerialized_SingeSimpleCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class SingeSimpleCal : public ISerialized { 
   public: 
       SingeSimpleCal(TiXmlNode* xmlNode);

       bool isPastOcc(){return this->pastOccIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPastOcc();


   protected: 
       boost::shared_ptr<XsdTypeBoolean> pastOcc_;
       
       bool pastOccIsNull_;

};

} //namespaceFpmlSerialized end
#endif

