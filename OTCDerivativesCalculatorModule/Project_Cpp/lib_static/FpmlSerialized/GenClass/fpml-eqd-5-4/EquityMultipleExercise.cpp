// EquityMultipleExercise.cpp 
#include "EquityMultipleExercise.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EquityMultipleExercise::EquityMultipleExercise(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //integralMultipleExerciseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* integralMultipleExerciseNode = xmlNode->FirstChildElement("integralMultipleExercise");

   if(integralMultipleExerciseNode){integralMultipleExerciseIsNull_ = false;}
   else{integralMultipleExerciseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- integralMultipleExerciseNode , address : " << integralMultipleExerciseNode << std::endl;
   #endif
   if(integralMultipleExerciseNode)
   {
      if(integralMultipleExerciseNode->Attribute("href") || integralMultipleExerciseNode->Attribute("id"))
      {
          if(integralMultipleExerciseNode->Attribute("id"))
          {
             integralMultipleExerciseIDRef_ = integralMultipleExerciseNode->Attribute("id");
             integralMultipleExercise_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(integralMultipleExerciseNode));
             integralMultipleExercise_->setID(integralMultipleExerciseIDRef_);
             IDManager::instance().setID(integralMultipleExerciseIDRef_,integralMultipleExercise_);
          }
          else if(integralMultipleExerciseNode->Attribute("href")) { integralMultipleExerciseIDRef_ = integralMultipleExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { integralMultipleExercise_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(integralMultipleExerciseNode));}
   }

   //minimumNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumNumberOfOptionsNode = xmlNode->FirstChildElement("minimumNumberOfOptions");

   if(minimumNumberOfOptionsNode){minimumNumberOfOptionsIsNull_ = false;}
   else{minimumNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumNumberOfOptionsNode , address : " << minimumNumberOfOptionsNode << std::endl;
   #endif
   if(minimumNumberOfOptionsNode)
   {
      if(minimumNumberOfOptionsNode->Attribute("href") || minimumNumberOfOptionsNode->Attribute("id"))
      {
          if(minimumNumberOfOptionsNode->Attribute("id"))
          {
             minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode->Attribute("id");
             minimumNumberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(minimumNumberOfOptionsNode));
             minimumNumberOfOptions_->setID(minimumNumberOfOptionsIDRef_);
             IDManager::instance().setID(minimumNumberOfOptionsIDRef_,minimumNumberOfOptions_);
          }
          else if(minimumNumberOfOptionsNode->Attribute("href")) { minimumNumberOfOptionsIDRef_ = minimumNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumNumberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(minimumNumberOfOptionsNode));}
   }

   //maximumNumberOfOptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumNumberOfOptionsNode = xmlNode->FirstChildElement("maximumNumberOfOptions");

   if(maximumNumberOfOptionsNode){maximumNumberOfOptionsIsNull_ = false;}
   else{maximumNumberOfOptionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumNumberOfOptionsNode , address : " << maximumNumberOfOptionsNode << std::endl;
   #endif
   if(maximumNumberOfOptionsNode)
   {
      if(maximumNumberOfOptionsNode->Attribute("href") || maximumNumberOfOptionsNode->Attribute("id"))
      {
          if(maximumNumberOfOptionsNode->Attribute("id"))
          {
             maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode->Attribute("id");
             maximumNumberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(maximumNumberOfOptionsNode));
             maximumNumberOfOptions_->setID(maximumNumberOfOptionsIDRef_);
             IDManager::instance().setID(maximumNumberOfOptionsIDRef_,maximumNumberOfOptions_);
          }
          else if(maximumNumberOfOptionsNode->Attribute("href")) { maximumNumberOfOptionsIDRef_ = maximumNumberOfOptionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumNumberOfOptions_ = boost::shared_ptr<NonNegativeDecimal>(new NonNegativeDecimal(maximumNumberOfOptionsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveDecimal> EquityMultipleExercise::getIntegralMultipleExercise()
{
   if(!this->integralMultipleExerciseIsNull_){
        if(integralMultipleExerciseIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(integralMultipleExerciseIDRef_));
        }else{
             return this->integralMultipleExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> EquityMultipleExercise::getMinimumNumberOfOptions()
{
   if(!this->minimumNumberOfOptionsIsNull_){
        if(minimumNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(minimumNumberOfOptionsIDRef_));
        }else{
             return this->minimumNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
boost::shared_ptr<NonNegativeDecimal> EquityMultipleExercise::getMaximumNumberOfOptions()
{
   if(!this->maximumNumberOfOptionsIsNull_){
        if(maximumNumberOfOptionsIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeDecimal>(IDManager::instance().getID(maximumNumberOfOptionsIDRef_));
        }else{
             return this->maximumNumberOfOptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeDecimal>();
   }
}
}

