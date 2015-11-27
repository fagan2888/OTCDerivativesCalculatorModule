// ConstReturnCal.hpp 
#ifndef FpmlSerialized_ConstReturnCal_hpp
#define FpmlSerialized_ConstReturnCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class ConstReturnCal : public ISerialized { 
   public: 
       ConstReturnCal(TiXmlNode* xmlNode);

       bool isConstReturn(){return this->constReturnIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getConstReturn();


   protected: 
       boost::shared_ptr<XsdTypeDouble> constReturn_;
       
       bool constReturnIsNull_;

};

} //namespaceFpmlSerialized end
#endif

