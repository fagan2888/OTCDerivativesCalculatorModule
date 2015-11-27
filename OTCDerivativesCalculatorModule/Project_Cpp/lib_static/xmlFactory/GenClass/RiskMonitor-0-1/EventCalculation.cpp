// EventCalculation.cpp 
#include "EventCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventCalculation::EventCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
       name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));
   }

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

   //upperBarrierEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperBarrierEventCalNode = xmlNode->FirstChildElement("upperBarrierEventCal");

   if(upperBarrierEventCalNode){upperBarrierEventCalIsNull_ = false;}
   else{upperBarrierEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperBarrierEventCalNode , address : " << upperBarrierEventCalNode << std::endl;
   #endif
   if(upperBarrierEventCalNode)
   {
       upperBarrierEventCal_ = boost::shared_ptr<UpperBarrierEventCal>(new UpperBarrierEventCal(upperBarrierEventCalNode));
   }

   //lowerBarrierEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerBarrierEventCalNode = xmlNode->FirstChildElement("lowerBarrierEventCal");

   if(lowerBarrierEventCalNode){lowerBarrierEventCalIsNull_ = false;}
   else{lowerBarrierEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerBarrierEventCalNode , address : " << lowerBarrierEventCalNode << std::endl;
   #endif
   if(lowerBarrierEventCalNode)
   {
       lowerBarrierEventCal_ = boost::shared_ptr<LowerBarrierEventCal>(new LowerBarrierEventCal(lowerBarrierEventCalNode));
   }

   //dualBarrierEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dualBarrierEventCalNode = xmlNode->FirstChildElement("dualBarrierEventCal");

   if(dualBarrierEventCalNode){dualBarrierEventCalIsNull_ = false;}
   else{dualBarrierEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dualBarrierEventCalNode , address : " << dualBarrierEventCalNode << std::endl;
   #endif
   if(dualBarrierEventCalNode)
   {
       dualBarrierEventCal_ = boost::shared_ptr<DualBarrierEventCal>(new DualBarrierEventCal(dualBarrierEventCalNode));
   }

   //simpleRangeEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* simpleRangeEventCalNode = xmlNode->FirstChildElement("simpleRangeEventCal");

   if(simpleRangeEventCalNode){simpleRangeEventCalIsNull_ = false;}
   else{simpleRangeEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- simpleRangeEventCalNode , address : " << simpleRangeEventCalNode << std::endl;
   #endif
   if(simpleRangeEventCalNode)
   {
       simpleRangeEventCal_ = boost::shared_ptr<SimpleRangeEventCal>(new SimpleRangeEventCal(simpleRangeEventCalNode));
   }

   //referenceEventCalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceEventCalNode = xmlNode->FirstChildElement("referenceEventCal");

   if(referenceEventCalNode){referenceEventCalIsNull_ = false;}
   else{referenceEventCalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceEventCalNode , address : " << referenceEventCalNode << std::endl;
   #endif
   if(referenceEventCalNode)
   {
       referenceEventCal_ = boost::shared_ptr<ReferenceEventCal>(new ReferenceEventCal(referenceEventCalNode));
   }

   //pastEventOccNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pastEventOccNode = xmlNode->FirstChildElement("pastEventOcc");

   if(pastEventOccNode){pastEventOccIsNull_ = false;}
   else{pastEventOccIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pastEventOccNode , address : " << pastEventOccNode << std::endl;
   #endif
   if(pastEventOccNode)
   {
       pastEventOcc_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(pastEventOccNode));
   }

   //refVariable_eventOccNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refVariable_eventOccNode = xmlNode->FirstChildElement("refVariable_eventOcc");

   if(refVariable_eventOccNode){refVariable_eventOccIsNull_ = false;}
   else{refVariable_eventOccIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refVariable_eventOccNode , address : " << refVariable_eventOccNode << std::endl;
   #endif
   if(refVariable_eventOccNode)
   {
       refVariable_eventOcc_ = boost::shared_ptr<RefVariable_eventOcc>(new RefVariable_eventOcc(refVariable_eventOccNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> EventCalculation::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> EventCalculation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<PreConditionEvent> EventCalculation::getPreConditionEvent()
{
   if(!this->preConditionEventIsNull_){
        return this->preConditionEvent_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreConditionEvent>();
   }
}
boost::shared_ptr<UpperBarrierEventCal> EventCalculation::getUpperBarrierEventCal()
{
   if(!this->upperBarrierEventCalIsNull_){
        return this->upperBarrierEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UpperBarrierEventCal>();
   }
}
boost::shared_ptr<LowerBarrierEventCal> EventCalculation::getLowerBarrierEventCal()
{
   if(!this->lowerBarrierEventCalIsNull_){
        return this->lowerBarrierEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LowerBarrierEventCal>();
   }
}
boost::shared_ptr<DualBarrierEventCal> EventCalculation::getDualBarrierEventCal()
{
   if(!this->dualBarrierEventCalIsNull_){
        return this->dualBarrierEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DualBarrierEventCal>();
   }
}
boost::shared_ptr<SimpleRangeEventCal> EventCalculation::getSimpleRangeEventCal()
{
   if(!this->simpleRangeEventCalIsNull_){
        return this->simpleRangeEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SimpleRangeEventCal>();
   }
}
boost::shared_ptr<ReferenceEventCal> EventCalculation::getReferenceEventCal()
{
   if(!this->referenceEventCalIsNull_){
        return this->referenceEventCal_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceEventCal>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EventCalculation::getPastEventOcc()
{
   if(!this->pastEventOccIsNull_){
        return this->pastEventOcc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<RefVariable_eventOcc> EventCalculation::getRefVariable_eventOcc()
{
   if(!this->refVariable_eventOccIsNull_){
        return this->refVariable_eventOcc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RefVariable_eventOcc>();
   }
}
}

