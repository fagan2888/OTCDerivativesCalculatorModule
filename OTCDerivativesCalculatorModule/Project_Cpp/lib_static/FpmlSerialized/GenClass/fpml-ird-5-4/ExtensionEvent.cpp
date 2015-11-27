// ExtensionEvent.cpp 
#include "ExtensionEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExtensionEvent::ExtensionEvent(TiXmlNode* xmlNode)
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

   //adjustedExtendedTerminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* adjustedExtendedTerminationDateNode = xmlNode->FirstChildElement("adjustedExtendedTerminationDate");

   if(adjustedExtendedTerminationDateNode){adjustedExtendedTerminationDateIsNull_ = false;}
   else{adjustedExtendedTerminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- adjustedExtendedTerminationDateNode , address : " << adjustedExtendedTerminationDateNode << std::endl;
   #endif
   if(adjustedExtendedTerminationDateNode)
   {
      if(adjustedExtendedTerminationDateNode->Attribute("href") || adjustedExtendedTerminationDateNode->Attribute("id"))
      {
          if(adjustedExtendedTerminationDateNode->Attribute("id"))
          {
             adjustedExtendedTerminationDateIDRef_ = adjustedExtendedTerminationDateNode->Attribute("id");
             adjustedExtendedTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExtendedTerminationDateNode));
             adjustedExtendedTerminationDate_->setID(adjustedExtendedTerminationDateIDRef_);
             IDManager::instance().setID(adjustedExtendedTerminationDateIDRef_,adjustedExtendedTerminationDate_);
          }
          else if(adjustedExtendedTerminationDateNode->Attribute("href")) { adjustedExtendedTerminationDateIDRef_ = adjustedExtendedTerminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { adjustedExtendedTerminationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(adjustedExtendedTerminationDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> ExtensionEvent::getAdjustedExerciseDate()
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
boost::shared_ptr<XsdTypeDate> ExtensionEvent::getAdjustedExtendedTerminationDate()
{
   if(!this->adjustedExtendedTerminationDateIsNull_){
        if(adjustedExtendedTerminationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(adjustedExtendedTerminationDateIDRef_));
        }else{
             return this->adjustedExtendedTerminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

