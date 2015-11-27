// Fixing.hpp 
#ifndef FpmlSerialized_Fixing_hpp
#define FpmlSerialized_Fixing_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class Fixing : public ISerialized { 
   public: 
       Fixing(TiXmlNode* xmlNode);

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();


       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getValue();


   protected: 
       boost::shared_ptr<XsdTypeDate> date_;
       
       bool dateIsNull_;
       boost::shared_ptr<XsdTypeDouble> value_;
       
       bool valueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

