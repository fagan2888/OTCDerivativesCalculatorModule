// RelativeDateSequence.hpp 
#ifndef FpmlSerialized_RelativeDateSequence_hpp
#define FpmlSerialized_RelativeDateSequence_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/DateReference.hpp>
#include <fpml-shared-5-4/DateOffset.hpp>
#include <fpml-shared-5-4/BusinessCentersReference.hpp>
#include <fpml-shared-5-4/BusinessCenters.hpp>

namespace FpmlSerialized {

class RelativeDateSequence : public ISerialized { 
   public: 
       RelativeDateSequence(TiXmlNode* xmlNode);

       bool isDateRelativeTo(){return this->dateRelativeToIsNull_;}
       boost::shared_ptr<DateReference> getDateRelativeTo();
      std::string getDateRelativeToIDRef(){return dateRelativeToIDRef_;}

       bool isDateOffset(){return this->dateOffsetIsNull_;}
       std::vector<boost::shared_ptr<DateOffset>> getDateOffset();
      std::string getDateOffsetIDRef(){return dateOffsetIDRef_;}

       bool isBusinessCentersReference(){return this->businessCentersReferenceIsNull_;}
       boost::shared_ptr<BusinessCentersReference> getBusinessCentersReference();
      std::string getBusinessCentersReferenceIDRef(){return businessCentersReferenceIDRef_;}

       bool isBusinessCenters(){return this->businessCentersIsNull_;}
       boost::shared_ptr<BusinessCenters> getBusinessCenters();
      std::string getBusinessCentersIDRef(){return businessCentersIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!businessCentersReferenceIsNull_){
                count += 1;
                str = "businessCentersReference" ;
           }
           if(!businessCentersIsNull_){
                count += 1;
                str = "businessCenters" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<DateReference> dateRelativeTo_;
       std::string dateRelativeToIDRef_;
       bool dateRelativeToIsNull_;
       std::vector<boost::shared_ptr<DateOffset>> dateOffset_;
       std::string dateOffsetIDRef_;
       bool dateOffsetIsNull_;
         boost::shared_ptr<BusinessCentersReference> businessCentersReference_;     //choice
       std::string businessCentersReferenceIDRef_;
       bool businessCentersReferenceIsNull_;
         boost::shared_ptr<BusinessCenters> businessCenters_;     //choice
       std::string businessCentersIDRef_;
       bool businessCentersIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

