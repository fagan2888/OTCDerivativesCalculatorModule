// DateOffset.hpp 
#ifndef FpmlSerialized_DateOffset_hpp
#define FpmlSerialized_DateOffset_hpp

#include <fpml-shared-5-4/Offset.hpp>
#include <fpml-enum-5-4/BusinessDayConventionEnum.hpp>

namespace FpmlSerialized {

class DateOffset : public Offset { 
   public: 
       DateOffset(TiXmlNode* xmlNode);

       bool isBusinessDayConvention(){return this->businessDayConventionIsNull_;}
       boost::shared_ptr<BusinessDayConventionEnum> getBusinessDayConvention();
      std::string getBusinessDayConventionIDRef(){return businessDayConventionIDRef_;}

   protected: 
       boost::shared_ptr<BusinessDayConventionEnum> businessDayConvention_;
       std::string businessDayConventionIDRef_;
       bool businessDayConventionIsNull_;

};

} //namespaceFpmlSerialized end
#endif

