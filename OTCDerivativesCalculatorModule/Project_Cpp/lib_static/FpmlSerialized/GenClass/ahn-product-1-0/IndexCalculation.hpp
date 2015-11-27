// IndexCalculation.hpp 
#ifndef FpmlSerialized_IndexCalculation_hpp
#define FpmlSerialized_IndexCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <ahn-product-1-0/ReturnTran.hpp>
#include <ahn-product-1-0/MinimumTran.hpp>
#include <ahn-product-1-0/BasketAver.hpp>

namespace FpmlSerialized {

class IndexCalculation : public ISerialized { 
   public: 
       IndexCalculation(TiXmlNode* xmlNode);

       bool isTimeType(){return this->timeTypeIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getTimeType();
      std::string getTimeTypeIDRef(){return timeTypeIDRef_;}

       bool isReturn(){return this->returnIsNull_;}
       boost::shared_ptr<ReturnTran> getReturn();
      std::string getReturnIDRef(){return returnIDRef_;}

       bool isMinimum(){return this->minimumIsNull_;}
       boost::shared_ptr<MinimumTran> getMinimum();
      std::string getMinimumIDRef(){return minimumIDRef_;}

       bool isBasketAver(){return this->basketAverIsNull_;}
       boost::shared_ptr<BasketAver> getBasketAver();
      std::string getBasketAverIDRef(){return basketAverIDRef_;}

       std::string getChoiceStr_tran(){
           std::string str;
           int count = 0;
           if(!returnIsNull_){
                count += 1;
                str = "return" ;
           }
           if(!minimumIsNull_){
                count += 1;
                str = "minimum" ;
           }
           if(!basketAverIsNull_){
                count += 1;
                str = "basketAver" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_tran_ = str ;
           return choiceStr_tran_;
       }
   protected: 
       boost::shared_ptr<XsdTypeBoolean> timeType_;
       std::string timeTypeIDRef_;
       bool timeTypeIsNull_;
         boost::shared_ptr<ReturnTran> return_;     //choice
       std::string returnIDRef_;
       bool returnIsNull_;
         boost::shared_ptr<MinimumTran> minimum_;     //choice
       std::string minimumIDRef_;
       bool minimumIsNull_;
         boost::shared_ptr<BasketAver> basketAver_;     //choice
       std::string basketAverIDRef_;
       bool basketAverIsNull_;

       //choiceStr 
       std::string choiceStr_tran_;

};

} //namespaceFpmlSerialized end
#endif

