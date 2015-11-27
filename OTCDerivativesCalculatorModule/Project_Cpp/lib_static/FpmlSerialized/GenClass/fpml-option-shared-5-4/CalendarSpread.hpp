// CalendarSpread.hpp 
#ifndef FpmlSerialized_CalendarSpread_hpp
#define FpmlSerialized_CalendarSpread_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/AdjustableOrRelativeDate.hpp>

namespace FpmlSerialized {

class CalendarSpread : public ISerialized { 
   public: 
       CalendarSpread(TiXmlNode* xmlNode);

       bool isExpirationDateTwo(){return this->expirationDateTwoIsNull_;}
       boost::shared_ptr<AdjustableOrRelativeDate> getExpirationDateTwo();
      std::string getExpirationDateTwoIDRef(){return expirationDateTwoIDRef_;}

   protected: 
       boost::shared_ptr<AdjustableOrRelativeDate> expirationDateTwo_;
       std::string expirationDateTwoIDRef_;
       bool expirationDateTwoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

