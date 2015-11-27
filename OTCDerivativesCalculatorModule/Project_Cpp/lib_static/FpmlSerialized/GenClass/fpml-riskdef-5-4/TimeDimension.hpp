// TimeDimension.hpp 
#ifndef FpmlSerialized_TimeDimension_hpp
#define FpmlSerialized_TimeDimension_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/Period.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class TimeDimension : public ISerialized { 
   public: 
       TimeDimension(TiXmlNode* xmlNode);

       bool isTenor(){return this->tenorIsNull_;}
       boost::shared_ptr<Period> getTenor();
      std::string getTenorIDRef(){return tenorIDRef_;}

       bool isDate(){return this->dateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!tenorIsNull_){
                count += 1;
                str = "tenor" ;
           }
           if(!dateIsNull_){
                count += 1;
                str = "date" ;
           }
           if(!tenorIsNull_){
                count += 1;
                str = "tenor" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<Period> tenor_;     //choice
       std::string tenorIDRef_;
       bool tenorIsNull_;
         boost::shared_ptr<XsdTypeDate> date_;     //choice
       std::string dateIDRef_;
       bool dateIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

