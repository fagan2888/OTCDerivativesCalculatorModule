// EventCalculationInfo.cpp 
#include "EventCalculationInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventCalculationInfo::EventCalculationInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //eventCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventCalculationNode = xmlNode->FirstChildElement("eventCalculation");

   if(eventCalculationNode){eventCalculationIsNull_ = false;}
   else{eventCalculationIsNull_ = true;}

   if(eventCalculationNode)
   {
      for(eventCalculationNode; eventCalculationNode; eventCalculationNode = eventCalculationNode->NextSiblingElement("eventCalculation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCalculationNode , address : " << eventCalculationNode << std::endl;
          #endif
          eventCalculation_.push_back(boost::shared_ptr<EventCalculation>(new EventCalculation(eventCalculationNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCalculationNode , address : " << eventCalculationNode << std::endl;
       #endif
   }

   //jointSimpleCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointSimpleCalculationNode = xmlNode->FirstChildElement("jointSimpleCalculation");

   if(jointSimpleCalculationNode){jointSimpleCalculationIsNull_ = false;}
   else{jointSimpleCalculationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointSimpleCalculationNode , address : " << jointSimpleCalculationNode << std::endl;
   #endif
   if(jointSimpleCalculationNode)
   {
       jointSimpleCalculation_ = boost::shared_ptr<JointSimpleCalculation>(new JointSimpleCalculation(jointSimpleCalculationNode));
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
boost::shared_ptr<PreConditionEvent> EventCalculationInfo::getPreConditionEvent()
{
   if(!this->preConditionEventIsNull_){
        return this->preConditionEvent_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreConditionEvent>();
   }
}
std::vector<boost::shared_ptr<EventCalculation>> EventCalculationInfo::getEventCalculation()
{
   if(!this->eventCalculationIsNull_){
        return this->eventCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventCalculation>>();
   }
}
boost::shared_ptr<JointSimpleCalculation> EventCalculationInfo::getJointSimpleCalculation()
{
   if(!this->jointSimpleCalculationIsNull_){
        return this->jointSimpleCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<JointSimpleCalculation>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EventCalculationInfo::getPastEventOcc()
{
   if(!this->pastEventOccIsNull_){
        return this->pastEventOcc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<RefVariable_eventOcc> EventCalculationInfo::getRefVariable_eventOcc()
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

