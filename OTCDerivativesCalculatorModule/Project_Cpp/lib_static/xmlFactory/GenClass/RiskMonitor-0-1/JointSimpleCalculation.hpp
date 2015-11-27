// JointSimpleCalculation.hpp 
#ifndef FpmlSerialized_JointSimpleCalculation_hpp
#define FpmlSerialized_JointSimpleCalculation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/AndSimpleCal.hpp>
#include <RiskMonitor-0-1/SingeSimpleCal.hpp>

namespace FpmlSerialized {

class JointSimpleCalculation : public ISerialized { 
   public: 
       JointSimpleCalculation(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isAndSimpleCal(){return this->andSimpleCalIsNull_;}
       boost::shared_ptr<AndSimpleCal> getAndSimpleCal();


       bool isSingeSimpleCal(){return this->singeSimpleCalIsNull_;}
       boost::shared_ptr<SingeSimpleCal> getSingeSimpleCal();


       std::string getChoiceStr_jointSimpleType(){
           std::string str;
           int count = 0;
           if(!andSimpleCalIsNull_){
                count += 1;
                str = "andSimpleCal" ;
           }
           if(!singeSimpleCalIsNull_){
                count += 1;
                str = "singeSimpleCal" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_jointSimpleType_ = str ;
           return choiceStr_jointSimpleType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<AndSimpleCal> andSimpleCal_;     //choice
       
       bool andSimpleCalIsNull_;
         boost::shared_ptr<SingeSimpleCal> singeSimpleCal_;     //choice
       
       bool singeSimpleCalIsNull_;

       //choiceStr 
       std::string choiceStr_jointSimpleType_;

};

} //namespaceFpmlSerialized end
#endif

