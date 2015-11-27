// CancellationEvent.cpp 
#include "CancellationEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CancellationEvent::CancellationEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //adjustedExerciseDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedExerciseDateNode = xmlNode->FirstChildElement("adjustedExerciseDate");

   if(adjustedExerciseDateNode){adjustedExerciseDateIsNull_ = false;}
   else{adjustedExerciseDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedExerciseDateNode , address : " << adjustedExerciseDateNode << std::endl;
   #endif
   if(adjustedExerciseDateNode)
   {
      if(adjustedExerciseDateNode->Attribute("href") || adjustedExerciseDateNode->Attribute("id"))
      {
          if(adjustedExerciseDateNode->Attribute("id"))
          {
             adjustedExerciseDateIDRef_ = adjustedExerciseDateNode->Attribute("id");
             adjustedExerciseDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExerciseDateNode));
             adjustedExerciseDate_->setID(adjustedExerciseDateIDRef_);
             IDManager::instance().setID(adjustedExerciseDateIDRef_,adjustedExerciseDate_);
          }
          else if(adjustedExerciseDateNode->Attribute("href")) { adjustedExerciseDateIDRef_ = adjustedExerciseDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedExerciseDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExerciseDateNode));}
   }

   //adjustedEarlyTerminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedEarlyTerminationDateNode = xmlNode->FirstChildElement("adjustedEarlyTerminationDate");

   if(adjustedEarlyTerminationDateNode){adjustedEarlyTerminationDateIsNull_ = false;}
   else{adjustedEarlyTerminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedEarlyTerminationDateNode , address : " << adjustedEarlyTerminationDateNode << std::endl;
   #endif
   if(adjustedEarlyTerminationDateNode)
   {
      if(adjustedEarlyTerminationDateNode->Attribute("href") || adjustedEarlyTerminationDateNode->Attribute("id"))
      {
          if(adjustedEarlyTerminationDateNode->Attribute("id"))
          {
             adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode->Attribute("id");
             adjustedEarlyTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedEarlyTerminationDateNode));
             adjustedEarlyTerminationDate_->setID(adjustedEarlyTerminationDateIDRef_);
             IDManager::instance().setID(adjustedEarlyTerminationDateIDRef_,adjustedEarlyTerminationDate_);
          }
          else if(adjustedEarlyTerminationDateNode->Attribute("href")) { adjustedEarlyTerminationDateIDRef_ = adjustedEarlyTerminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedEarlyTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedEarlyTerminationDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> CancellationEvent::getAdjustedExerciseDate()
{
   if(!this->adjustedExerciseDateIsNull_){
        if(adjustedExerciseDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedExerciseDateIDRef_));
        }else{
             return this->adjustedExerciseDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> CancellationEvent::getAdjustedEarlyTerminationDate()
{
   if(!this->adjustedEarlyTerminationDateIsNull_){
        if(adjustedEarlyTerminationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedEarlyTerminationDateIDRef_));
        }else{
             return this->adjustedEarlyTerminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

