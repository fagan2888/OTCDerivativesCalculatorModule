// UpperBound.hpp 
#ifndef FpmlSerialized_UpperBound_hpp
#define FpmlSerialized_UpperBound_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class UpperBound : public ISerialized { 
   public: 
       UpperBound(TiXmlNode* xmlNode);

       bool isMaximumInclusive(){return this->maximumInclusiveIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMaximumInclusive();
      std::string getMaximumInclusiveIDRef(){return maximumInclusiveIDRef_;}

       bool isMaximumExclusive(){return this->maximumExclusiveIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMaximumExclusive();
      std::string getMaximumExclusiveIDRef(){return maximumExclusiveIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!maximumInclusiveIsNull_){
                count += 1;
                str = "maximumInclusive" ;
           }
           if(!maximumExclusiveIsNull_){
                count += 1;
                str = "maximumExclusive" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<PositiveDecimal> maximumInclusive_;     //choice
       std::string maximumInclusiveIDRef_;
       bool maximumInclusiveIsNull_;
         boost::shared_ptr<PositiveDecimal> maximumExclusive_;     //choice
       std::string maximumExclusiveIDRef_;
       bool maximumExclusiveIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

