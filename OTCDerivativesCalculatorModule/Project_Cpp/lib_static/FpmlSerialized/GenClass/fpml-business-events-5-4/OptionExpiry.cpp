// OptionExpiry.cpp 
#include "OptionExpiry.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionExpiry::OptionExpiry(TiXmlNode* xmlNode)
: AbstractEvent(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //tradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tradeIdentifierNode = xmlNode->FirstChildElement("tradeIdentifier");

   if(tradeIdentifierNode){tradeIdentifierIsNull_ = false;}
   else{tradeIdentifierIsNull_ = true;}

   if(tradeIdentifierNode)
   {
      for(tradeIdentifierNode; tradeIdentifierNode; tradeIdentifierNode = tradeIdentifierNode->NextSiblingElement("tradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
          #endif
          if(tradeIdentifierNode->Attribute("href") || tradeIdentifierNode->Attribute("id"))
          {
              if(tradeIdentifierNode->Attribute("id"))
              {
                  tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("id");
                  tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));
                  tradeIdentifier_.back()->setID(tradeIdentifierIDRef_);
                  IDManager::instance().setID(tradeIdentifierIDRef_, tradeIdentifier_.back());
              }
              else if(tradeIdentifierNode->Attribute("href")) { tradeIdentifierIDRef_ = tradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { tradeIdentifier_.push_back(boost::shared_ptr<PartyTradeIdentifier>(new PartyTradeIdentifier(tradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tradeIdentifierNode , address : " << tradeIdentifierNode << std::endl;
       #endif
   }

   //dateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateNode = xmlNode->FirstChildElement("date");

   if(dateNode){dateIsNull_ = false;}
   else{dateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
   #endif
   if(dateNode)
   {
      if(dateNode->Attribute("href") || dateNode->Attribute("id"))
      {
          if(dateNode->Attribute("id"))
          {
             dateIDRef_ = dateNode->Attribute("id");
             date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));
             date_->setID(dateIDRef_);
             IDManager::instance().setID(dateIDRef_,date_);
          }
          else if(dateNode->Attribute("href")) { dateIDRef_ = dateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));}
   }

   //timeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* timeNode = xmlNode->FirstChildElement("time");

   if(timeNode){timeIsNull_ = false;}
   else{timeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- timeNode , address : " << timeNode << std::endl;
   #endif
   if(timeNode)
   {
      if(timeNode->Attribute("href") || timeNode->Attribute("id"))
      {
          if(timeNode->Attribute("id"))
          {
             timeIDRef_ = timeNode->Attribute("id");
             time_ = boost::shared_ptr<XsdTypeTime>(new XsdTypeTime(timeNode));
             time_->setID(timeIDRef_);
             IDManager::instance().setID(timeIDRef_,time_);
          }
          else if(timeNode->Attribute("href")) { timeIDRef_ = timeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { time_ = boost::shared_ptr<XsdTypeTime>(new XsdTypeTime(timeNode));}
   }

   //exerciseProcedureNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseProcedureNode = xmlNode->FirstChildElement("exerciseProcedure");

   if(exerciseProcedureNode){exerciseProcedureIsNull_ = false;}
   else{exerciseProcedureIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseProcedureNode , address : " << exerciseProcedureNode << std::endl;
   #endif
   if(exerciseProcedureNode)
   {
      if(exerciseProcedureNode->Attribute("href") || exerciseProcedureNode->Attribute("id"))
      {
          if(exerciseProcedureNode->Attribute("id"))
          {
             exerciseProcedureIDRef_ = exerciseProcedureNode->Attribute("id");
             exerciseProcedure_ = boost::shared_ptr<ExerciseProcedureOption>(new ExerciseProcedureOption(exerciseProcedureNode));
             exerciseProcedure_->setID(exerciseProcedureIDRef_);
             IDManager::instance().setID(exerciseProcedureIDRef_,exerciseProcedure_);
          }
          else if(exerciseProcedureNode->Attribute("href")) { exerciseProcedureIDRef_ = exerciseProcedureNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseProcedure_ = boost::shared_ptr<ExerciseProcedureOption>(new ExerciseProcedureOption(exerciseProcedureNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<PartyTradeIdentifier>> OptionExpiry::getTradeIdentifier()
{
   if(!this->tradeIdentifierIsNull_){
        if(tradeIdentifierIDRef_ != ""){
             return this->tradeIdentifier_;
        }else{
             return this->tradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyTradeIdentifier>>();
   }
}
boost::shared_ptr<XsdTypeDate> OptionExpiry::getDate()
{
   if(!this->dateIsNull_){
        if(dateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(dateIDRef_));
        }else{
             return this->date_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeTime> OptionExpiry::getTime()
{
   if(!this->timeIsNull_){
        if(timeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeTime>(IDManager::instance().getID(timeIDRef_));
        }else{
             return this->time_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeTime>();
   }
}
boost::shared_ptr<ExerciseProcedureOption> OptionExpiry::getExerciseProcedure()
{
   if(!this->exerciseProcedureIsNull_){
        if(exerciseProcedureIDRef_ != ""){
             return boost::shared_static_cast<ExerciseProcedureOption>(IDManager::instance().getID(exerciseProcedureIDRef_));
        }else{
             return this->exerciseProcedure_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ExerciseProcedureOption>();
   }
}
}

