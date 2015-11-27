// Method.hpp 
#ifndef FpmlSerialized_Method_hpp
#define FpmlSerialized_Method_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Monte.hpp>

namespace FpmlSerialized {

class Method : public ISerialized { 
   public: 
       Method(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isMonte(){return this->monteIsNull_;}
       boost::shared_ptr<Monte> getMonte();


       std::string getChoiceStr_methodType(){
           std::string str;
           int count = 0;
           if(!monteIsNull_){
                count += 1;
                str = "monte" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_methodType_ = str ;
           return choiceStr_methodType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<Monte> monte_;     //choice
       
       bool monteIsNull_;

       //choiceStr 
       std::string choiceStr_methodType_;

};

} //namespaceFpmlSerialized end
#endif

