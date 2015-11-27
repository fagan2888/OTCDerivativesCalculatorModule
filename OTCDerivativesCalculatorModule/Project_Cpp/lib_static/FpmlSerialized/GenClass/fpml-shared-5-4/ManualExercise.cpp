// ManualExercise.cpp 
#include "ManualExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ManualExercise::ManualExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //exerciseNoticeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseNoticeNode = xmlNode->FirstChildElement("exerciseNotice");

   if(exerciseNoticeNode){exerciseNoticeIsNull_ = false;}
   else{exerciseNoticeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNoticeNode , address : " << exerciseNoticeNode << std::endl;
   #endif
   if(exerciseNoticeNode)
   {
      if(exerciseNoticeNode->Attribute("href") || exerciseNoticeNode->Attribute("id"))
      {
          if(exerciseNoticeNode->Attribute("id"))
          {
             exerciseNoticeIDRef_ = exerciseNoticeNode->Attribute("id");
             exerciseNotice_ = boost::shared_ptr<ExerciseNotice>(new ExerciseNotice(exerciseNoticeNode));
             exerciseNotice_->setID(exerciseNoticeIDRef_);
             IDManager::instance().setID(exerciseNoticeIDRef_,exerciseNotice_);
          }
          else if(exerciseNoticeNode->Attribute("href")) { exerciseNoticeIDRef_ = exerciseNoticeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseNotice_ = boost::shared_ptr<ExerciseNotice>(new ExerciseNotice(exerciseNoticeNode));}
   }

   //fallbackExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fallbackExerciseNode = xmlNode->FirstChildElement("fallbackExercise");

   if(fallbackExerciseNode){fallbackExerciseIsNull_ = false;}
   else{fallbackExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fallbackExerciseNode , address : " << fallbackExerciseNode << std::endl;
   #endif
   if(fallbackExerciseNode)
   {
      if(fallbackExerciseNode->Attribute("href") || fallbackExerciseNode->Attribute("id"))
      {
          if(fallbackExerciseNode->Attribute("id"))
          {
             fallbackExerciseIDRef_ = fallbackExerciseNode->Attribute("id");
             fallbackExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fallbackExerciseNode));
             fallbackExercise_->setID(fallbackExerciseIDRef_);
             IDManager::instance().setID(fallbackExerciseIDRef_,fallbackExercise_);
          }
          else if(fallbackExerciseNode->Attribute("href")) { fallbackExerciseIDRef_ = fallbackExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fallbackExercise_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fallbackExerciseNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ExerciseNotice> ManualExercise::getExerciseNotice()
{
   if(!this->exerciseNoticeIsNull_){
        if(exerciseNoticeIDRef_ != ""){
             return boost::shared_static_cast<ExerciseNotice>(IDManager::instance().getID(exerciseNoticeIDRef_));
        }else{
             return this->exerciseNotice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExerciseNotice>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ManualExercise::getFallbackExercise()
{
   if(!this->fallbackExerciseIsNull_){
        if(fallbackExerciseIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(fallbackExerciseIDRef_));
        }else{
             return this->fallbackExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

