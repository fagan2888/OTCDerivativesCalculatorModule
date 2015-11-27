// RestructuringEvent.cpp 
#include "RestructuringEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RestructuringEvent::RestructuringEvent(TiXmlNode* xmlNode)
: CreditEvent(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partialExerciseAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partialExerciseAmountNode = xmlNode->FirstChildElement("partialExerciseAmount");

   if(partialExerciseAmountNode){partialExerciseAmountIsNull_ = false;}
   else{partialExerciseAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partialExerciseAmountNode , address : " << partialExerciseAmountNode << std::endl;
   #endif
   if(partialExerciseAmountNode)
   {
      if(partialExerciseAmountNode->Attribute("href") || partialExerciseAmountNode->Attribute("id"))
      {
          if(partialExerciseAmountNode->Attribute("id"))
          {
             partialExerciseAmountIDRef_ = partialExerciseAmountNode->Attribute("id");
             partialExerciseAmount_ = boost::shared_ptr<Money>(new Money(partialExerciseAmountNode));
             partialExerciseAmount_->setID(partialExerciseAmountIDRef_);
             IDManager::instance().setID(partialExerciseAmountIDRef_,partialExerciseAmount_);
          }
          else if(partialExerciseAmountNode->Attribute("href")) { partialExerciseAmountIDRef_ = partialExerciseAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partialExerciseAmount_ = boost::shared_ptr<Money>(new Money(partialExerciseAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Money> RestructuringEvent::getPartialExerciseAmount()
{
   if(!this->partialExerciseAmountIsNull_){
        if(partialExerciseAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(partialExerciseAmountIDRef_));
        }else{
             return this->partialExerciseAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

