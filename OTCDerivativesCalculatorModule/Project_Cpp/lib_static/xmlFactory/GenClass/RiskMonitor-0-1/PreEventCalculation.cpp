// PreEventCalculation.cpp 
#include "PreEventCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PreEventCalculation::PreEventCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //eventCalculationListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eventCalculationListNode = xmlNode->FirstChildElement("eventCalculationList");

   if(eventCalculationListNode){eventCalculationListIsNull_ = false;}
   else{eventCalculationListIsNull_ = true;}

   if(eventCalculationListNode)
   {
      for(eventCalculationListNode; eventCalculationListNode; eventCalculationListNode = eventCalculationListNode->NextSiblingElement("eventCalculationList")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCalculationListNode , address : " << eventCalculationListNode << std::endl;
          #endif
          eventCalculationList_.push_back(boost::shared_ptr<EventCalculationList>(new EventCalculationList(eventCalculationListNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eventCalculationListNode , address : " << eventCalculationListNode << std::endl;
       #endif
   }

   //jointEventCalculationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* jointEventCalculationNode = xmlNode->FirstChildElement("jointEventCalculation");

   if(jointEventCalculationNode){jointEventCalculationIsNull_ = false;}
   else{jointEventCalculationIsNull_ = true;}

   if(jointEventCalculationNode)
   {
      for(jointEventCalculationNode; jointEventCalculationNode; jointEventCalculationNode = jointEventCalculationNode->NextSiblingElement("jointEventCalculation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointEventCalculationNode , address : " << jointEventCalculationNode << std::endl;
          #endif
          jointEventCalculation_.push_back(boost::shared_ptr<JointEventCalculation>(new JointEventCalculation(jointEventCalculationNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- jointEventCalculationNode , address : " << jointEventCalculationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<EventCalculationList>> PreEventCalculation::getEventCalculationList()
{
   if(!this->eventCalculationListIsNull_){
        return this->eventCalculationList_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventCalculationList>>();
   }
}
std::vector<boost::shared_ptr<JointEventCalculation>> PreEventCalculation::getJointEventCalculation()
{
   if(!this->jointEventCalculationIsNull_){
        return this->jointEventCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<JointEventCalculation>>();
   }
}
}

