// EventTrigger.cpp 
#include "EventTrigger.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventTrigger::EventTrigger(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //eventDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventDateNode = xmlNode->FirstChildElement("eventDate");

   if(eventDateNode){eventDateIsNull_ = false;}
   else{eventDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventDateNode , address : " << eventDateNode << std::endl;
   #endif
   if(eventDateNode)
   {
       eventDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(eventDateNode));
   }

   //autoTerminationTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoTerminationTriggerNode = xmlNode->FirstChildElement("autoTerminationTrigger");

   if(autoTerminationTriggerNode){autoTerminationTriggerIsNull_ = false;}
   else{autoTerminationTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoTerminationTriggerNode , address : " << autoTerminationTriggerNode << std::endl;
   #endif
   if(autoTerminationTriggerNode)
   {
       autoTerminationTrigger_ = boost::shared_ptr<AutoTerminationTrigger>(new AutoTerminationTrigger(autoTerminationTriggerNode));
   }

   //preEventCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* preEventCalculationNode = xmlNode->FirstChildElement("preEventCalculation");

   if(preEventCalculationNode){preEventCalculationIsNull_ = false;}
   else{preEventCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preEventCalculationNode , address : " << preEventCalculationNode << std::endl;
   #endif
   if(preEventCalculationNode)
   {
       preEventCalculation_ = boost::shared_ptr<PreEventCalculation>(new PreEventCalculation(preEventCalculationNode));
   }

   //preConditionEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* preConditionEventNode = xmlNode->FirstChildElement("preConditionEvent");

   if(preConditionEventNode){preConditionEventIsNull_ = false;}
   else{preConditionEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preConditionEventNode , address : " << preConditionEventNode << std::endl;
   #endif
   if(preConditionEventNode)
   {
       preConditionEvent_ = boost::shared_ptr<PreConditionEvent>(new PreConditionEvent(preConditionEventNode));
   }

   //autoCallConstReturnTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallConstReturnTriggerNode = xmlNode->FirstChildElement("autoCallConstReturnTrigger");

   if(autoCallConstReturnTriggerNode){autoCallConstReturnTriggerIsNull_ = false;}
   else{autoCallConstReturnTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallConstReturnTriggerNode , address : " << autoCallConstReturnTriggerNode << std::endl;
   #endif
   if(autoCallConstReturnTriggerNode)
   {
       autoCallConstReturnTrigger_ = boost::shared_ptr<AutoCallConstReturnTrigger>(new AutoCallConstReturnTrigger(autoCallConstReturnTriggerNode));
   }

   //simpleRangeConstReturnTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeConstReturnTriggerNode = xmlNode->FirstChildElement("simpleRangeConstReturnTrigger");

   if(simpleRangeConstReturnTriggerNode){simpleRangeConstReturnTriggerIsNull_ = false;}
   else{simpleRangeConstReturnTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeConstReturnTriggerNode , address : " << simpleRangeConstReturnTriggerNode << std::endl;
   #endif
   if(simpleRangeConstReturnTriggerNode)
   {
       simpleRangeConstReturnTrigger_ = boost::shared_ptr<SimpleRangeConstReturnTrigger>(new SimpleRangeConstReturnTrigger(simpleRangeConstReturnTriggerNode));
   }

   //simpleRangeRateTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeRateTriggerNode = xmlNode->FirstChildElement("simpleRangeRateTrigger");

   if(simpleRangeRateTriggerNode){simpleRangeRateTriggerIsNull_ = false;}
   else{simpleRangeRateTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeRateTriggerNode , address : " << simpleRangeRateTriggerNode << std::endl;
   #endif
   if(simpleRangeRateTriggerNode)
   {
       simpleRangeRateTrigger_ = boost::shared_ptr<SimpleRangeRateTrigger>(new SimpleRangeRateTrigger(simpleRangeRateTriggerNode));
   }

   //simpleRangeAccrualRateTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeAccrualRateTriggerNode = xmlNode->FirstChildElement("simpleRangeAccrualRateTrigger");

   if(simpleRangeAccrualRateTriggerNode){simpleRangeAccrualRateTriggerIsNull_ = false;}
   else{simpleRangeAccrualRateTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeAccrualRateTriggerNode , address : " << simpleRangeAccrualRateTriggerNode << std::endl;
   #endif
   if(simpleRangeAccrualRateTriggerNode)
   {
       simpleRangeAccrualRateTrigger_ = boost::shared_ptr<SimpleRangeAccrualRateTrigger>(new SimpleRangeAccrualRateTrigger(simpleRangeAccrualRateTriggerNode));
   }

   //fixedRateTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedRateTriggerNode = xmlNode->FirstChildElement("fixedRateTrigger");

   if(fixedRateTriggerNode){fixedRateTriggerIsNull_ = false;}
   else{fixedRateTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedRateTriggerNode , address : " << fixedRateTriggerNode << std::endl;
   #endif
   if(fixedRateTriggerNode)
   {
       fixedRateTrigger_ = boost::shared_ptr<FixedRateTrigger>(new FixedRateTrigger(fixedRateTriggerNode));
   }

   //vanillaRateTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaRateTriggerNode = xmlNode->FirstChildElement("vanillaRateTrigger");

   if(vanillaRateTriggerNode){vanillaRateTriggerIsNull_ = false;}
   else{vanillaRateTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaRateTriggerNode , address : " << vanillaRateTriggerNode << std::endl;
   #endif
   if(vanillaRateTriggerNode)
   {
       vanillaRateTrigger_ = boost::shared_ptr<VanillaRateTrigger>(new VanillaRateTrigger(vanillaRateTriggerNode));
   }

   //redemptionNotionalTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* redemptionNotionalTriggerNode = xmlNode->FirstChildElement("redemptionNotionalTrigger");

   if(redemptionNotionalTriggerNode){redemptionNotionalTriggerIsNull_ = false;}
   else{redemptionNotionalTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- redemptionNotionalTriggerNode , address : " << redemptionNotionalTriggerNode << std::endl;
   #endif
   if(redemptionNotionalTriggerNode)
   {
       redemptionNotionalTrigger_ = boost::shared_ptr<RedemptionNotionalTrigger>(new RedemptionNotionalTrigger(redemptionNotionalTriggerNode));
   }

   //autoCallRangeReturnTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* autoCallRangeReturnTriggerNode = xmlNode->FirstChildElement("autoCallRangeReturnTrigger");

   if(autoCallRangeReturnTriggerNode){autoCallRangeReturnTriggerIsNull_ = false;}
   else{autoCallRangeReturnTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- autoCallRangeReturnTriggerNode , address : " << autoCallRangeReturnTriggerNode << std::endl;
   #endif
   if(autoCallRangeReturnTriggerNode)
   {
       autoCallRangeReturnTrigger_ = boost::shared_ptr<AutoCallRangeReturnTrigger>(new AutoCallRangeReturnTrigger(autoCallRangeReturnTriggerNode));
   }

   //vanillaCouponTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* vanillaCouponTriggerNode = xmlNode->FirstChildElement("vanillaCouponTrigger");

   if(vanillaCouponTriggerNode){vanillaCouponTriggerIsNull_ = false;}
   else{vanillaCouponTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- vanillaCouponTriggerNode , address : " << vanillaCouponTriggerNode << std::endl;
   #endif
   if(vanillaCouponTriggerNode)
   {
       vanillaCouponTrigger_ = boost::shared_ptr<VanillaCouponTrigger>(new VanillaCouponTrigger(vanillaCouponTriggerNode));
   }

   //simpleEventCouponTriggerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleEventCouponTriggerNode = xmlNode->FirstChildElement("simpleEventCouponTrigger");

   if(simpleEventCouponTriggerNode){simpleEventCouponTriggerIsNull_ = false;}
   else{simpleEventCouponTriggerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleEventCouponTriggerNode , address : " << simpleEventCouponTriggerNode << std::endl;
   #endif
   if(simpleEventCouponTriggerNode)
   {
       simpleEventCouponTrigger_ = boost::shared_ptr<SimpleEventCouponTrigger>(new SimpleEventCouponTrigger(simpleEventCouponTriggerNode));
   }

   //postCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* postCalculationNode = xmlNode->FirstChildElement("postCalculation");

   if(postCalculationNode){postCalculationIsNull_ = false;}
   else{postCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- postCalculationNode , address : " << postCalculationNode << std::endl;
   #endif
   if(postCalculationNode)
   {
       postCalculation_ = boost::shared_ptr<PostCalculation>(new PostCalculation(postCalculationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> EventTrigger::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDate> EventTrigger::getEventDate()
{
   if(!this->eventDateIsNull_){
        return this->eventDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<AutoTerminationTrigger> EventTrigger::getAutoTerminationTrigger()
{
   if(!this->autoTerminationTriggerIsNull_){
        return this->autoTerminationTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AutoTerminationTrigger>();
   }
}
boost::shared_ptr<PreEventCalculation> EventTrigger::getPreEventCalculation()
{
   if(!this->preEventCalculationIsNull_){
        return this->preEventCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreEventCalculation>();
   }
}
boost::shared_ptr<PreConditionEvent> EventTrigger::getPreConditionEvent()
{
   if(!this->preConditionEventIsNull_){
        return this->preConditionEvent_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreConditionEvent>();
   }
}
boost::shared_ptr<AutoCallConstReturnTrigger> EventTrigger::getAutoCallConstReturnTrigger()
{
   if(!this->autoCallConstReturnTriggerIsNull_){
        return this->autoCallConstReturnTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AutoCallConstReturnTrigger>();
   }
}
boost::shared_ptr<SimpleRangeConstReturnTrigger> EventTrigger::getSimpleRangeConstReturnTrigger()
{
   if(!this->simpleRangeConstReturnTriggerIsNull_){
        return this->simpleRangeConstReturnTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeConstReturnTrigger>();
   }
}
boost::shared_ptr<SimpleRangeRateTrigger> EventTrigger::getSimpleRangeRateTrigger()
{
   if(!this->simpleRangeRateTriggerIsNull_){
        return this->simpleRangeRateTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeRateTrigger>();
   }
}
boost::shared_ptr<SimpleRangeAccrualRateTrigger> EventTrigger::getSimpleRangeAccrualRateTrigger()
{
   if(!this->simpleRangeAccrualRateTriggerIsNull_){
        return this->simpleRangeAccrualRateTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeAccrualRateTrigger>();
   }
}
boost::shared_ptr<FixedRateTrigger> EventTrigger::getFixedRateTrigger()
{
   if(!this->fixedRateTriggerIsNull_){
        return this->fixedRateTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedRateTrigger>();
   }
}
boost::shared_ptr<VanillaRateTrigger> EventTrigger::getVanillaRateTrigger()
{
   if(!this->vanillaRateTriggerIsNull_){
        return this->vanillaRateTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaRateTrigger>();
   }
}
boost::shared_ptr<RedemptionNotionalTrigger> EventTrigger::getRedemptionNotionalTrigger()
{
   if(!this->redemptionNotionalTriggerIsNull_){
        return this->redemptionNotionalTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RedemptionNotionalTrigger>();
   }
}
boost::shared_ptr<AutoCallRangeReturnTrigger> EventTrigger::getAutoCallRangeReturnTrigger()
{
   if(!this->autoCallRangeReturnTriggerIsNull_){
        return this->autoCallRangeReturnTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AutoCallRangeReturnTrigger>();
   }
}
boost::shared_ptr<VanillaCouponTrigger> EventTrigger::getVanillaCouponTrigger()
{
   if(!this->vanillaCouponTriggerIsNull_){
        return this->vanillaCouponTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<VanillaCouponTrigger>();
   }
}
boost::shared_ptr<SimpleEventCouponTrigger> EventTrigger::getSimpleEventCouponTrigger()
{
   if(!this->simpleEventCouponTriggerIsNull_){
        return this->simpleEventCouponTrigger_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleEventCouponTrigger>();
   }
}
boost::shared_ptr<PostCalculation> EventTrigger::getPostCalculation()
{
   if(!this->postCalculationIsNull_){
        return this->postCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PostCalculation>();
   }
}
}

