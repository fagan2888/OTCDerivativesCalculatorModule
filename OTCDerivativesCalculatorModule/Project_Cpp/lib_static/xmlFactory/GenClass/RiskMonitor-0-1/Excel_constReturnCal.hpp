// Excel_constReturnCal.hpp 
#ifndef FpmlSerialized_Excel_constReturnCal_hpp
#define FpmlSerialized_Excel_constReturnCal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_constReturnCal : public ISerialized { 
   public: 
       Excel_constReturnCal(TiXmlNode* xmlNode);

       bool isConstReturn(){return this->constReturnIsNull_;}
       boost::shared_ptr<XsdTypeToken> getConstReturn();


   protected: 
       boost::shared_ptr<XsdTypeToken> constReturn_;
       
       bool constReturnIsNull_;

};

} //namespaceFpmlSerialized end
#endif

