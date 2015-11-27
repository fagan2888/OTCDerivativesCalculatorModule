// EventDate.hpp 
#ifndef FpmlSerialized_EventDate_hpp
#define FpmlSerialized_EventDate_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class EventDate : public ISerialized { 
   public: 
       EventDate(TiXmlNode* xmlNode);

       bool isDateSingle(){return this->dateSingleIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDateSingle();
      std::string getDateSingleIDRef(){return dateSingleIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!dateSingleIsNull_){
                count += 1;
                str = "dateSingle" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDate> dateSingle_;     //choice
       std::string dateSingleIDRef_;
       bool dateSingleIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

