// DateList.hpp 
#ifndef FpmlSerialized_DateList_hpp
#define FpmlSerialized_DateList_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class DateList : public ISerialized { 
   public: 
       DateList(TiXmlNode* xmlNode);

       bool isDate(){return this->dateIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDate>> getDate();


   protected: 
       std::vector<boost::shared_ptr<XsdTypeDate>> date_;
       
       bool dateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

