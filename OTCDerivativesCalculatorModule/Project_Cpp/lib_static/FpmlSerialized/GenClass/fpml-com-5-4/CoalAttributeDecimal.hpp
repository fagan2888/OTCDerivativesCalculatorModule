// CoalAttributeDecimal.hpp 
#ifndef FpmlSerialized_CoalAttributeDecimal_hpp
#define FpmlSerialized_CoalAttributeDecimal_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class CoalAttributeDecimal : public ISerialized { 
   public: 
       CoalAttributeDecimal(TiXmlNode* xmlNode);

       bool isStandardContent(){return this->standardContentIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStandardContent();
      std::string getStandardContentIDRef(){return standardContentIDRef_;}

       bool isRejectionLimit(){return this->rejectionLimitIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getRejectionLimit();
      std::string getRejectionLimitIDRef(){return rejectionLimitIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!standardContentIsNull_){
                count += 1;
                str = "standardContent" ;
           }
           if(!rejectionLimitIsNull_){
                count += 1;
                str = "rejectionLimit" ;
           }
           if(!rejectionLimitIsNull_){
                count += 1;
                str = "rejectionLimit" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeDecimal> standardContent_;     //choice
       std::string standardContentIDRef_;
       bool standardContentIsNull_;
         boost::shared_ptr<XsdTypeDecimal> rejectionLimit_;     //choice
       std::string rejectionLimitIDRef_;
       bool rejectionLimitIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

