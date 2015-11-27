// SingleValuationDate.hpp 
#ifndef FpmlSerialized_SingleValuationDate_hpp
#define FpmlSerialized_SingleValuationDate_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeNonNegativeInteger.hpp>

namespace FpmlSerialized {

class SingleValuationDate : public ISerialized { 
   public: 
       SingleValuationDate(TiXmlNode* xmlNode);

       bool isBusinessDays(){return this->businessDaysIsNull_;}
       boost::shared_ptr<XsdTypeNonNegativeInteger> getBusinessDays();
      std::string getBusinessDaysIDRef(){return businessDaysIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeNonNegativeInteger> businessDays_;
       std::string businessDaysIDRef_;
       bool businessDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

