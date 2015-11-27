// DateRange.hpp 
#ifndef FpmlSerialized_DateRange_hpp
#define FpmlSerialized_DateRange_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class DateRange : public ISerialized { 
   public: 
       DateRange(TiXmlNode* xmlNode);

       bool isUnadjustedFirstDate(){return this->unadjustedFirstDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getUnadjustedFirstDate();
      std::string getUnadjustedFirstDateIDRef(){return unadjustedFirstDateIDRef_;}

       bool isUnadjustedLastDate(){return this->unadjustedLastDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getUnadjustedLastDate();
      std::string getUnadjustedLastDateIDRef(){return unadjustedLastDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDate> unadjustedFirstDate_;
       std::string unadjustedFirstDateIDRef_;
       bool unadjustedFirstDateIsNull_;
       boost::shared_ptr<XsdTypeDate> unadjustedLastDate_;
       std::string unadjustedLastDateIDRef_;
       bool unadjustedLastDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

