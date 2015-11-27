// ReferenceCurve.hpp 
#ifndef FpmlSerialized_ReferenceCurve_hpp
#define FpmlSerialized_ReferenceCurve_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/CdsSpreadTermstructure.hpp>
#include <RiskMonitor-0-1/YieldTermstructure.hpp>

namespace FpmlSerialized {

class ReferenceCurve : public ISerialized { 
   public: 
       ReferenceCurve(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isCdsSpreadTermstructure(){return this->cdsSpreadTermstructureIsNull_;}
       boost::shared_ptr<CdsSpreadTermstructure> getCdsSpreadTermstructure();


       bool isYieldTermstructure(){return this->yieldTermstructureIsNull_;}
       boost::shared_ptr<YieldTermstructure> getYieldTermstructure();


       std::string getChoiceStr_tsType(){
           std::string str;
           int count = 0;
           if(!cdsSpreadTermstructureIsNull_){
                count += 1;
                str = "cdsSpreadTermstructure" ;
           }
           if(!yieldTermstructureIsNull_){
                count += 1;
                str = "yieldTermstructure" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_tsType_ = str ;
           return choiceStr_tsType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<CdsSpreadTermstructure> cdsSpreadTermstructure_;     //choice
       
       bool cdsSpreadTermstructureIsNull_;
         boost::shared_ptr<YieldTermstructure> yieldTermstructure_;     //choice
       
       bool yieldTermstructureIsNull_;

       //choiceStr 
       std::string choiceStr_tsType_;

};

} //namespaceFpmlSerialized end
#endif

