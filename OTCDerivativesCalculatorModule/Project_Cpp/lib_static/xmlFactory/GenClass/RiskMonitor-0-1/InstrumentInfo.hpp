// InstrumentInfo.hpp 
#ifndef FpmlSerialized_InstrumentInfo_hpp
#define FpmlSerialized_InstrumentInfo_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/StandardInstrument.hpp>
#include <RiskMonitor-0-1/StandardSwapInstrument.hpp>
#include <RiskMonitor-0-1/CreditInstrument.hpp>
#include <RiskMonitor-0-1/FixedBondInstrument.hpp>

namespace FpmlSerialized {

class InstrumentInfo : public ISerialized { 
   public: 
       InstrumentInfo(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isStandardInstrument(){return this->standardInstrumentIsNull_;}
       boost::shared_ptr<StandardInstrument> getStandardInstrument();


       bool isStandardSwapInstrument(){return this->standardSwapInstrumentIsNull_;}
       boost::shared_ptr<StandardSwapInstrument> getStandardSwapInstrument();


       bool isCreditInstrument(){return this->creditInstrumentIsNull_;}
       boost::shared_ptr<CreditInstrument> getCreditInstrument();


       bool isFixedBondInstrument(){return this->fixedBondInstrumentIsNull_;}
       boost::shared_ptr<FixedBondInstrument> getFixedBondInstrument();


       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!standardInstrumentIsNull_){
                count += 1;
                str = "standardInstrument" ;
           }
           if(!standardSwapInstrumentIsNull_){
                count += 1;
                str = "standardSwapInstrument" ;
           }
           if(!creditInstrumentIsNull_){
                count += 1;
                str = "creditInstrument" ;
           }
           if(!fixedBondInstrumentIsNull_){
                count += 1;
                str = "fixedBondInstrument" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<StandardInstrument> standardInstrument_;     //choice
       
       bool standardInstrumentIsNull_;
         boost::shared_ptr<StandardSwapInstrument> standardSwapInstrument_;     //choice
       
       bool standardSwapInstrumentIsNull_;
         boost::shared_ptr<CreditInstrument> creditInstrument_;     //choice
       
       bool creditInstrumentIsNull_;
         boost::shared_ptr<FixedBondInstrument> fixedBondInstrument_;     //choice
       
       bool fixedBondInstrumentIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

