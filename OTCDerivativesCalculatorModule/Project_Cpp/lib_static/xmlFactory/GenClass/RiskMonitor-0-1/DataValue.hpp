// DataValue.hpp 
#ifndef FpmlSerialized_DataValue_hpp
#define FpmlSerialized_DataValue_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class DataValue : public ISerialized { 
   public: 
       DataValue(TiXmlNode* xmlNode);

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

