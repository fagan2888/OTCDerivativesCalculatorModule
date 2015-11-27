// CoalAttributePercentage.hpp 
#ifndef FpmlSerialized_CoalAttributePercentage_hpp
#define FpmlSerialized_CoalAttributePercentage_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/RestrictedPercentage.hpp>

namespace FpmlSerialized {

class CoalAttributePercentage : public ISerialized { 
   public: 
       CoalAttributePercentage(TiXmlNode* xmlNode);

       bool isStandardContent(){return this->standardContentIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getStandardContent();
      std::string getStandardContentIDRef(){return standardContentIDRef_;}

       bool isRejectionLimit(){return this->rejectionLimitIsNull_;}
       boost::shared_ptr<RestrictedPercentage> getRejectionLimit();
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
         boost::shared_ptr<RestrictedPercentage> standardContent_;     //choice
       std::string standardContentIDRef_;
       bool standardContentIsNull_;
         boost::shared_ptr<RestrictedPercentage> rejectionLimit_;     //choice
       std::string rejectionLimitIDRef_;
       bool rejectionLimitIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

