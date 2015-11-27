// ExercisePeriod.cpp 
#include "ExercisePeriod.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExercisePeriod::ExercisePeriod(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //earliestExerciseDateTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* earliestExerciseDateTenorNode = xmlNode->FirstChildElement("earliestExerciseDateTenor");

   if(earliestExerciseDateTenorNode){earliestExerciseDateTenorIsNull_ = false;}
   else{earliestExerciseDateTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- earliestExerciseDateTenorNode , address : " << earliestExerciseDateTenorNode << std::endl;
   #endif
   if(earliestExerciseDateTenorNode)
   {
      if(earliestExerciseDateTenorNode->Attribute("href") || earliestExerciseDateTenorNode->Attribute("id"))
      {
          if(earliestExerciseDateTenorNode->Attribute("id"))
          {
             earliestExerciseDateTenorIDRef_ = earliestExerciseDateTenorNode->Attribute("id");
             earliestExerciseDateTenor_ = boost::shared_ptr<Period>(new Period(earliestExerciseDateTenorNode));
             earliestExerciseDateTenor_->setID(earliestExerciseDateTenorIDRef_);
             IDManager::instance().setID(earliestExerciseDateTenorIDRef_,earliestExerciseDateTenor_);
          }
          else if(earliestExerciseDateTenorNode->Attribute("href")) { earliestExerciseDateTenorIDRef_ = earliestExerciseDateTenorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { earliestExerciseDateTenor_ = boost::shared_ptr<Period>(new Period(earliestExerciseDateTenorNode));}
   }

   //exerciseFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseFrequencyNode = xmlNode->FirstChildElement("exerciseFrequency");

   if(exerciseFrequencyNode){exerciseFrequencyIsNull_ = false;}
   else{exerciseFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseFrequencyNode , address : " << exerciseFrequencyNode << std::endl;
   #endif
   if(exerciseFrequencyNode)
   {
      if(exerciseFrequencyNode->Attribute("href") || exerciseFrequencyNode->Attribute("id"))
      {
          if(exerciseFrequencyNode->Attribute("id"))
          {
             exerciseFrequencyIDRef_ = exerciseFrequencyNode->Attribute("id");
             exerciseFrequency_ = boost::shared_ptr<Period>(new Period(exerciseFrequencyNode));
             exerciseFrequency_->setID(exerciseFrequencyIDRef_);
             IDManager::instance().setID(exerciseFrequencyIDRef_,exerciseFrequency_);
          }
          else if(exerciseFrequencyNode->Attribute("href")) { exerciseFrequencyIDRef_ = exerciseFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseFrequency_ = boost::shared_ptr<Period>(new Period(exerciseFrequencyNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Period> ExercisePeriod::getEarliestExerciseDateTenor()
{
   if(!this->earliestExerciseDateTenorIsNull_){
        if(earliestExerciseDateTenorIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(earliestExerciseDateTenorIDRef_));
        }else{
             return this->earliestExerciseDateTenor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<Period> ExercisePeriod::getExerciseFrequency()
{
   if(!this->exerciseFrequencyIsNull_){
        if(exerciseFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(exerciseFrequencyIDRef_));
        }else{
             return this->exerciseFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
}

