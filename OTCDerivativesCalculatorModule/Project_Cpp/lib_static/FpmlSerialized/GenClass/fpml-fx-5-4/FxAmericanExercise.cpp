// FxAmericanExercise.cpp 
#include "FxAmericanExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxAmericanExercise::FxAmericanExercise(TiXmlNode* xmlNode)
: FxDigitalAmericanExercise(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //multipleExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleExerciseNode = xmlNode->FirstChildElement("multipleExercise");

   if(multipleExerciseNode){multipleExerciseIsNull_ = false;}
   else{multipleExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleExerciseNode , address : " << multipleExerciseNode << std::endl;
   #endif
   if(multipleExerciseNode)
   {
      if(multipleExerciseNode->Attribute("href") || multipleExerciseNode->Attribute("id"))
      {
          if(multipleExerciseNode->Attribute("id"))
          {
             multipleExerciseIDRef_ = multipleExerciseNode->Attribute("id");
             multipleExercise_ = boost::shared_ptr<FxMultipleExercise>(new FxMultipleExercise(multipleExerciseNode));
             multipleExercise_->setID(multipleExerciseIDRef_);
             IDManager::instance().setID(multipleExerciseIDRef_,multipleExercise_);
          }
          else if(multipleExerciseNode->Attribute("href")) { multipleExerciseIDRef_ = multipleExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleExercise_ = boost::shared_ptr<FxMultipleExercise>(new FxMultipleExercise(multipleExerciseNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FxMultipleExercise> FxAmericanExercise::getMultipleExercise()
{
   if(!this->multipleExerciseIsNull_){
        if(multipleExerciseIDRef_ != ""){
             return boost::shared_static_cast<FxMultipleExercise>(IDManager::instance().getID(multipleExerciseIDRef_));
        }else{
             return this->multipleExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxMultipleExercise>();
   }
}
}

