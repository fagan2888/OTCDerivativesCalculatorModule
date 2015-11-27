// Offset.hpp 
#ifndef FpmlSerialized_Offset_hpp
#define FpmlSerialized_Offset_hpp

#include <fpml-shared-5-4/Period.hpp>
#include <fpml-enum-5-4/DayTypeEnum.hpp>

namespace FpmlSerialized {

class Offset : public Period { 
   public: 
       Offset(TiXmlNode* xmlNode);

       bool isDayType(){return this->dayTypeIsNull_;}
       boost::shared_ptr<DayTypeEnum> getDayType();
      std::string getDayTypeIDRef(){return dayTypeIDRef_;}

   protected: 
       boost::shared_ptr<DayTypeEnum> dayType_;
       std::string dayTypeIDRef_;
       bool dayTypeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

