// Underlying_para.hpp 
#ifndef FpmlSerialized_Underlying_para_hpp
#define FpmlSerialized_Underlying_para_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/GeometricBM.hpp>
#include <RiskMonitor-0-1/HullWhiteOneFactor.hpp>
#include <RiskMonitor-0-1/ForwardModel.hpp>

namespace FpmlSerialized {

class Underlying_para : public ISerialized { 
   public: 
       Underlying_para(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isKrCode(){return this->krCodeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getKrCode();


       bool isUnderName(){return this->underNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getUnderName();


       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeToken> getValue();


       bool isGeometricBM(){return this->geometricBMIsNull_;}
       boost::shared_ptr<GeometricBM> getGeometricBM();


       bool isHullWhiteOneFactor(){return this->hullWhiteOneFactorIsNull_;}
       boost::shared_ptr<HullWhiteOneFactor> getHullWhiteOneFactor();


       bool isForwardModel(){return this->forwardModelIsNull_;}
       boost::shared_ptr<ForwardModel> getForwardModel();


       std::string getChoiceStr_underParaType(){
           std::string str;
           int count = 0;
           if(!geometricBMIsNull_){
                count += 1;
                str = "geometricBM" ;
           }
           if(!hullWhiteOneFactorIsNull_){
                count += 1;
                str = "hullWhiteOneFactor" ;
           }
           if(!forwardModelIsNull_){
                count += 1;
                str = "forwardModel" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_underParaType_ = str ;
           return choiceStr_underParaType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeToken> krCode_;
       
       bool krCodeIsNull_;
       boost::shared_ptr<XsdTypeToken> underName_;
       
       bool underNameIsNull_;
       boost::shared_ptr<XsdTypeToken> value_;
       
       bool valueIsNull_;
         boost::shared_ptr<GeometricBM> geometricBM_;     //choice
       
       bool geometricBMIsNull_;
         boost::shared_ptr<HullWhiteOneFactor> hullWhiteOneFactor_;     //choice
       
       bool hullWhiteOneFactorIsNull_;
         boost::shared_ptr<ForwardModel> forwardModel_;     //choice
       
       bool forwardModelIsNull_;

       //choiceStr 
       std::string choiceStr_underParaType_;

};

} //namespaceFpmlSerialized end
#endif

