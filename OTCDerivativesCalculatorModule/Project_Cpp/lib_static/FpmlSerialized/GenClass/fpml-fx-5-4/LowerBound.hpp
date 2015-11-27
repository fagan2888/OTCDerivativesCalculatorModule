// LowerBound.hpp 
#ifndef FpmlSerialized_LowerBound_hpp
#define FpmlSerialized_LowerBound_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>

namespace FpmlSerialized {

class LowerBound : public ISerialized { 
   public: 
       LowerBound(TiXmlNode* xmlNode);

       bool isMinimumInclusive(){return this->minimumInclusiveIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMinimumInclusive();
      std::string getMinimumInclusiveIDRef(){return minimumInclusiveIDRef_;}

       bool isMinimumExclusive(){return this->minimumExclusiveIsNull_;}
       boost::shared_ptr<PositiveDecimal> getMinimumExclusive();
      std::string getMinimumExclusiveIDRef(){return minimumExclusiveIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!minimumInclusiveIsNull_){
                count += 1;
                str = "minimumInclusive" ;
           }
           if(!minimumExclusiveIsNull_){
                count += 1;
                str = "minimumExclusive" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<PositiveDecimal> minimumInclusive_;     //choice
       std::string minimumInclusiveIDRef_;
       bool minimumInclusiveIsNull_;
         boost::shared_ptr<PositiveDecimal> minimumExclusive_;     //choice
       std::string minimumExclusiveIDRef_;
       bool minimumExclusiveIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

