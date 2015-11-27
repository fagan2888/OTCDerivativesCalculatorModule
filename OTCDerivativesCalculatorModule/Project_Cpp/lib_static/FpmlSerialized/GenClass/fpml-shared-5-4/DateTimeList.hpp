// DateTimeList.hpp 
#ifndef FpmlSerialized_DateTimeList_hpp
#define FpmlSerialized_DateTimeList_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDateTime.hpp>

namespace FpmlSerialized {

class DateTimeList : public ISerialized { 
   public: 
       DateTimeList(TiXmlNode* xmlNode);

       bool isDateTime(){return this->dateTimeIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDateTime>> getDateTime();
      std::string getDateTimeIDRef(){return dateTimeIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<XsdTypeDateTime>> dateTime_;
       std::string dateTimeIDRef_;
       bool dateTimeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

