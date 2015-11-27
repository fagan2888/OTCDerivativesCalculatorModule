// OptionPayoffFunction.hpp 
#ifndef FpmlSerialized_OptionPayoffFunction_hpp
#define FpmlSerialized_OptionPayoffFunction_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/VanillaCallFunction.hpp>
#include <RiskMonitor-0-1/VanillaPutFunction.hpp>

namespace FpmlSerialized {

class OptionPayoffFunction : public ISerialized { 
   public: 
       OptionPayoffFunction(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isVanillaCallFunction(){return this->vanillaCallFunctionIsNull_;}
       boost::shared_ptr<VanillaCallFunction> getVanillaCallFunction();


       bool isVanillaPutFunction(){return this->vanillaPutFunctionIsNull_;}
       boost::shared_ptr<VanillaPutFunction> getVanillaPutFunction();


       std::string getChoiceStr_optionPayoffFunctionType(){
           std::string str;
           int count = 0;
           if(!vanillaCallFunctionIsNull_){
                count += 1;
                str = "vanillaCallFunction" ;
           }
           if(!vanillaPutFunctionIsNull_){
                count += 1;
                str = "vanillaPutFunction" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_optionPayoffFunctionType_ = str ;
           return choiceStr_optionPayoffFunctionType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<VanillaCallFunction> vanillaCallFunction_;     //choice
       
       bool vanillaCallFunctionIsNull_;
         boost::shared_ptr<VanillaPutFunction> vanillaPutFunction_;     //choice
       
       bool vanillaPutFunctionIsNull_;

       //choiceStr 
       std::string choiceStr_optionPayoffFunctionType_;

};

} //namespaceFpmlSerialized end
#endif

