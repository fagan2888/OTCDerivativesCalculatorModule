// ExerciseProcedureOption.cpp 
#include "ExerciseProcedureOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExerciseProcedureOption::ExerciseProcedureOption(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //manualExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* manualExerciseNode = xmlNode->FirstChildElement("manualExercise");

   if(manualExerciseNode){manualExerciseIsNull_ = false;}
   else{manualExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- manualExerciseNode , address : " << manualExerciseNode << std::endl;
   #endif
   if(manualExerciseNode)
   {
      if(manualExerciseNode->Attribute("href") || manualExerciseNode->Attribute("id"))
      {
          if(manualExerciseNode->Attribute("id"))
          {
             manualExerciseIDRef_ = manualExerciseNode->Attribute("id");
             manualExercise_ = boost::shared_ptr<Empty>(new Empty(manualExerciseNode));
             manualExercise_->setID(manualExerciseIDRef_);
             IDManager::instance().setID(manualExerciseIDRef_,manualExercise_);
          }
          else if(manualExerciseNode->Attribute("href")) { manualExerciseIDRef_ = manualExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { manualExercise_ = boost::shared_ptr<Empty>(new Empty(manualExerciseNode));}
   }

   //automaticExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* automaticExerciseNode = xmlNode->FirstChildElement("automaticExercise");

   if(automaticExerciseNode){automaticExerciseIsNull_ = false;}
   else{automaticExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- automaticExerciseNode , address : " << automaticExerciseNode << std::endl;
   #endif
   if(automaticExerciseNode)
   {
      if(automaticExerciseNode->Attribute("href") || automaticExerciseNode->Attribute("id"))
      {
          if(automaticExerciseNode->Attribute("id"))
          {
             automaticExerciseIDRef_ = automaticExerciseNode->Attribute("id");
             automaticExercise_ = boost::shared_ptr<Empty>(new Empty(automaticExerciseNode));
             automaticExercise_->setID(automaticExerciseIDRef_);
             IDManager::instance().setID(automaticExerciseIDRef_,automaticExercise_);
          }
          else if(automaticExerciseNode->Attribute("href")) { automaticExerciseIDRef_ = automaticExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { automaticExercise_ = boost::shared_ptr<Empty>(new Empty(automaticExerciseNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Empty> ExerciseProcedureOption::getManualExercise()
{
   if(!this->manualExerciseIsNull_){
        if(manualExerciseIDRef_ != ""){
             return boost::shared_static_cast<Empty>(IDManager::instance().getID(manualExerciseIDRef_));
        }else{
             return this->manualExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Empty>();
   }
}
boost::shared_ptr<Empty> ExerciseProcedureOption::getAutomaticExercise()
{
   if(!this->automaticExerciseIsNull_){
        if(automaticExerciseIDRef_ != ""){
             return boost::shared_static_cast<Empty>(IDManager::instance().getID(automaticExerciseIDRef_));
        }else{
             return this->automaticExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Empty>();
   }
}
}

