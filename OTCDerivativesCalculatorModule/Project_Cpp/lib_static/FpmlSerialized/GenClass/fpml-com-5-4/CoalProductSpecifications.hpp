// CoalProductSpecifications.hpp 
#ifndef FpmlSerialized_CoalProductSpecifications_hpp
#define FpmlSerialized_CoalProductSpecifications_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/CoalStandardQuality.hpp>
#include <fpml-com-5-4/CoalStandardQualitySchedule.hpp>

namespace FpmlSerialized {

class CoalProductSpecifications : public ISerialized { 
   public: 
       CoalProductSpecifications(TiXmlNode* xmlNode);

       bool isStandardQuality(){return this->standardQualityIsNull_;}
       boost::shared_ptr<CoalStandardQuality> getStandardQuality();
      std::string getStandardQualityIDRef(){return standardQualityIDRef_;}

       bool isStandardQualitySchedule(){return this->standardQualityScheduleIsNull_;}
       boost::shared_ptr<CoalStandardQualitySchedule> getStandardQualitySchedule();
      std::string getStandardQualityScheduleIDRef(){return standardQualityScheduleIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!standardQualityIsNull_){
                count += 1;
                str = "standardQuality" ;
           }
           if(!standardQualityScheduleIsNull_){
                count += 1;
                str = "standardQualitySchedule" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<CoalStandardQuality> standardQuality_;     //choice
       std::string standardQualityIDRef_;
       bool standardQualityIsNull_;
         boost::shared_ptr<CoalStandardQualitySchedule> standardQualitySchedule_;     //choice
       std::string standardQualityScheduleIDRef_;
       bool standardQualityScheduleIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

