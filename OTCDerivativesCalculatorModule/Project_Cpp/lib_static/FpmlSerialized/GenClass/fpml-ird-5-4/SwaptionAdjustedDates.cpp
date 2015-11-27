// SwaptionAdjustedDates.cpp 
#include "SwaptionAdjustedDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwaptionAdjustedDates::SwaptionAdjustedDates(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //exerciseEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseEventNode = xmlNode->FirstChildElement("exerciseEvent");

   if(exerciseEventNode){exerciseEventIsNull_ = false;}
   else{exerciseEventIsNull_ = true;}

   if(exerciseEventNode)
   {
      for(exerciseEventNode; exerciseEventNode; exerciseEventNode = exerciseEventNode->NextSiblingElement("exerciseEvent")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseEventNode , address : " << exerciseEventNode << std::endl;
          #endif
          if(exerciseEventNode->Attribute("href") || exerciseEventNode->Attribute("id"))
          {
              if(exerciseEventNode->Attribute("id"))
              {
                  exerciseEventIDRef_ = exerciseEventNode->Attribute("id");
                  exerciseEvent_.push_back(boost::shared_ptr<ExerciseEvent>(new ExerciseEvent(exerciseEventNode)));
                  exerciseEvent_.back()->setID(exerciseEventIDRef_);
                  IDManager::instance().setID(exerciseEventIDRef_, exerciseEvent_.back());
              }
              else if(exerciseEventNode->Attribute("href")) { exerciseEventIDRef_ = exerciseEventNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { exerciseEvent_.push_back(boost::shared_ptr<ExerciseEvent>(new ExerciseEvent(exerciseEventNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseEventNode , address : " << exerciseEventNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ExerciseEvent>> SwaptionAdjustedDates::getExerciseEvent()
{
   if(!this->exerciseEventIsNull_){
        if(exerciseEventIDRef_ != ""){
             return this->exerciseEvent_;
        }else{
             return this->exerciseEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ExerciseEvent>>();
   }
}
}

