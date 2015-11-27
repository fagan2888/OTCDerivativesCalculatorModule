// PayoffBase.hpp 
#ifndef FpmlSerialized_PayoffBase_hpp
#define FpmlSerialized_PayoffBase_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <ahn-product-1-0/ConstPayoff.hpp>
#include <ahn-product-1-0/NullPayoff.hpp>
#include <ahn-product-1-0/AverPayoff.hpp>
#include <ahn-product-1-0/ExprPayoff.hpp>
#include <ahn-product-1-0/PreFixPayoff.hpp>

namespace FpmlSerialized {

class PayoffBase : public ISerialized { 
   public: 
       PayoffBase(TiXmlNode* xmlNode);

       bool isPayoffDate(){return this->payoffDateIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffDate();
      std::string getPayoffDateIDRef(){return payoffDateIDRef_;}

       bool isConstPayoff(){return this->constPayoffIsNull_;}
       boost::shared_ptr<ConstPayoff> getConstPayoff();
      std::string getConstPayoffIDRef(){return constPayoffIDRef_;}

       bool isNullPayoff(){return this->nullPayoffIsNull_;}
       boost::shared_ptr<NullPayoff> getNullPayoff();
      std::string getNullPayoffIDRef(){return nullPayoffIDRef_;}

       bool isAverPayoff(){return this->averPayoffIsNull_;}
       boost::shared_ptr<AverPayoff> getAverPayoff();
      std::string getAverPayoffIDRef(){return averPayoffIDRef_;}

       bool isExprPayoff(){return this->exprPayoffIsNull_;}
       boost::shared_ptr<ExprPayoff> getExprPayoff();
      std::string getExprPayoffIDRef(){return exprPayoffIDRef_;}

       bool isPreFixPayoff(){return this->preFixPayoffIsNull_;}
       boost::shared_ptr<PreFixPayoff> getPreFixPayoff();
      std::string getPreFixPayoffIDRef(){return preFixPayoffIDRef_;}

       std::string getChoiceStr_pcType(){
           std::string str;
           int count = 0;
           if(!constPayoffIsNull_){
                count += 1;
                str = "constPayoff" ;
           }
           if(!nullPayoffIsNull_){
                count += 1;
                str = "nullPayoff" ;
           }
           if(!averPayoffIsNull_){
                count += 1;
                str = "averPayoff" ;
           }
           if(!exprPayoffIsNull_){
                count += 1;
                str = "exprPayoff" ;
           }
           if(!preFixPayoffIsNull_){
                count += 1;
                str = "preFixPayoff" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_pcType_ = str ;
           return choiceStr_pcType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> payoffDate_;
       std::string payoffDateIDRef_;
       bool payoffDateIsNull_;
         boost::shared_ptr<ConstPayoff> constPayoff_;     //choice
       std::string constPayoffIDRef_;
       bool constPayoffIsNull_;
         boost::shared_ptr<NullPayoff> nullPayoff_;     //choice
       std::string nullPayoffIDRef_;
       bool nullPayoffIsNull_;
         boost::shared_ptr<AverPayoff> averPayoff_;     //choice
       std::string averPayoffIDRef_;
       bool averPayoffIsNull_;
         boost::shared_ptr<ExprPayoff> exprPayoff_;     //choice
       std::string exprPayoffIDRef_;
       bool exprPayoffIsNull_;
         boost::shared_ptr<PreFixPayoff> preFixPayoff_;     //choice
       std::string preFixPayoffIDRef_;
       bool preFixPayoffIsNull_;

       //choiceStr 
       std::string choiceStr_pcType_;

};

} //namespaceFpmlSerialized end
#endif

