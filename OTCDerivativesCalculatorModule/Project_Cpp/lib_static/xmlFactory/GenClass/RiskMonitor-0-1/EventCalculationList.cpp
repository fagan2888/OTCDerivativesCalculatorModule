// EventCalculationList.cpp 
#include "EventCalculationList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventCalculationList::EventCalculationList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<EventCalculation>> EventCalculationList::getEventCalculation()
{
   if(!this->eventCalculationIsNull_){
        return this->eventCalculation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<EventCalculation>>();
   }
}
}

