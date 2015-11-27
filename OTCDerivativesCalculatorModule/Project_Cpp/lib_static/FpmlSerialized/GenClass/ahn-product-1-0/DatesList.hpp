// DatesList.hpp 
#ifndef FpmlSerialized_DatesList_hpp
#define FpmlSerialized_DatesList_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class DatesList : public ISerialized { 
   public: 
       DatesList(TiXmlNode* xmlNode);

       bool isDate(){return this->dateIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDate>> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dateIsNull_){
                count += 1;
                str = "date" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         std::vector<boost::shared_ptr<XsdTypeDate>> date_;     //choice
       std::string dateIDRef_;
       bool dateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

