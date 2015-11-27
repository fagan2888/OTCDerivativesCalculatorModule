// StandardOption.hpp 
#ifndef FpmlSerialized_StandardOption_hpp
#define FpmlSerialized_StandardOption_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/SingleBarrier.hpp>
#include <RiskMonitor-0-1/VanillaCallOption.hpp>
#include <RiskMonitor-0-1/VanillaPutOption.hpp>
#include <RiskMonitor-0-1/BarrierWithConstRebateCallOption.hpp>
#include <RiskMonitor-0-1/BarrierWithConstRebatePutOption.hpp>

namespace FpmlSerialized {

class StandardOption : public ISerialized { 
   public: 
       StandardOption(TiXmlNode* xmlNode);

       bool isUnit(){return this->unitIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getUnit();


       bool isBaseCoupon(){return this->baseCouponIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getBaseCoupon();


       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isSingleBarrier(){return this->singleBarrierIsNull_;}
       boost::shared_ptr<SingleBarrier> getSingleBarrier();


       bool isVanillaCallOption(){return this->vanillaCallOptionIsNull_;}
       boost::shared_ptr<VanillaCallOption> getVanillaCallOption();


       bool isVanillaPutOption(){return this->vanillaPutOptionIsNull_;}
       boost::shared_ptr<VanillaPutOption> getVanillaPutOption();


       bool isBarrierWithConstRebateCallOption(){return this->barrierWithConstRebateCallOptionIsNull_;}
       boost::shared_ptr<BarrierWithConstRebateCallOption> getBarrierWithConstRebateCallOption();


       bool isBarrierWithConstRebatePutOption(){return this->barrierWithConstRebatePutOptionIsNull_;}
       boost::shared_ptr<BarrierWithConstRebatePutOption> getBarrierWithConstRebatePutOption();


       std::string getChoiceStr_standardOptionType(){
           std::string str;
           int count = 0;
           if(!singleBarrierIsNull_){
                count += 1;
                str = "singleBarrier" ;
           }
           if(!vanillaCallOptionIsNull_){
                count += 1;
                str = "vanillaCallOption" ;
           }
           if(!vanillaPutOptionIsNull_){
                count += 1;
                str = "vanillaPutOption" ;
           }
           if(!barrierWithConstRebateCallOptionIsNull_){
                count += 1;
                str = "barrierWithConstRebateCallOption" ;
           }
           if(!barrierWithConstRebatePutOptionIsNull_){
                count += 1;
                str = "barrierWithConstRebatePutOption" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_standardOptionType_ = str ;
           return choiceStr_standardOptionType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeDouble> unit_;
       
       bool unitIsNull_;
       boost::shared_ptr<XsdTypeDouble> baseCoupon_;
       
       bool baseCouponIsNull_;
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
         boost::shared_ptr<SingleBarrier> singleBarrier_;     //choice
       
       bool singleBarrierIsNull_;
         boost::shared_ptr<VanillaCallOption> vanillaCallOption_;     //choice
       
       bool vanillaCallOptionIsNull_;
         boost::shared_ptr<VanillaPutOption> vanillaPutOption_;     //choice
       
       bool vanillaPutOptionIsNull_;
         boost::shared_ptr<BarrierWithConstRebateCallOption> barrierWithConstRebateCallOption_;     //choice
       
       bool barrierWithConstRebateCallOptionIsNull_;
         boost::shared_ptr<BarrierWithConstRebatePutOption> barrierWithConstRebatePutOption_;     //choice
       
       bool barrierWithConstRebatePutOptionIsNull_;

       //choiceStr 
       std::string choiceStr_standardOptionType_;

};

} //namespaceFpmlSerialized end
#endif

