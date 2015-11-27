// IndexCalculationTime.hpp 
#ifndef FpmlSerialized_IndexCalculationTime_hpp
#define FpmlSerialized_IndexCalculationTime_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/ReturnTranTime.hpp>
#include <ahn-product-1-0/MinimumTran.hpp>

namespace FpmlSerialized {

class IndexCalculationTime : public ISerialized { 
   public: 
       IndexCalculationTime(TiXmlNode* xmlNode);

       bool isReturnTime(){return this->returnTimeIsNull_;}
       boost::shared_ptr<ReturnTranTime> getReturnTime();
      std::string getReturnTimeIDRef(){return returnTimeIDRef_;}

       bool isMinimum(){return this->minimumIsNull_;}
       boost::shared_ptr<MinimumTran> getMinimum();
      std::string getMinimumIDRef(){return minimumIDRef_;}

       std::string getChoiceStr_calType(){
           std::string str;
           int count = 0;
           if(!returnTimeIsNull_){
                count += 1;
                str = "returnTime" ;
           }
           if(!minimumIsNull_){
                count += 1;
                str = "minimum" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_calType_ = str ;
           return choiceStr_calType_;
       }
   protected: 
         boost::shared_ptr<ReturnTranTime> returnTime_;     //choice
       std::string returnTimeIDRef_;
       bool returnTimeIsNull_;
         boost::shared_ptr<MinimumTran> minimum_;     //choice
       std::string minimumIDRef_;
       bool minimumIsNull_;

       //choiceStr 
       std::string choiceStr_calType_;

};

} //namespaceFpmlSerialized end
#endif

