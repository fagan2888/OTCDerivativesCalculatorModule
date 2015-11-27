// ExerciseProcedure.cpp 
#include "ExerciseProcedure.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExerciseProcedure::ExerciseProcedure(TiXmlNode* xmlNode)
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
             manualExercise_ = boost::shared_ptr<ManualExercise>(new ManualExercise(manualExerciseNode));
             manualExercise_->setID(manualExerciseIDRef_);
             IDManager::instance().setID(manualExerciseIDRef_,manualExercise_);
          }
          else if(manualExerciseNode->Attribute("href")) { manualExerciseIDRef_ = manualExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { manualExercise_ = boost::shared_ptr<ManualExercise>(new ManualExercise(manualExerciseNode));}
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
             automaticExercise_ = boost::shared_ptr<AutomaticExercise>(new AutomaticExercise(automaticExerciseNode));
             automaticExercise_->setID(automaticExerciseIDRef_);
             IDManager::instance().setID(automaticExerciseIDRef_,automaticExercise_);
          }
          else if(automaticExerciseNode->Attribute("href")) { automaticExerciseIDRef_ = automaticExerciseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { automaticExercise_ = boost::shared_ptr<AutomaticExercise>(new AutomaticExercise(automaticExerciseNode));}
   }

   //followUpConfirmationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* followUpConfirmationNode = xmlNode->FirstChildElement("followUpConfirmation");

   if(followUpConfirmationNode){followUpConfirmationIsNull_ = false;}
   else{followUpConfirmationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- followUpConfirmationNode , address : " << followUpConfirmationNode << std::endl;
   #endif
   if(followUpConfirmationNode)
   {
      if(followUpConfirmationNode->Attribute("href") || followUpConfirmationNode->Attribute("id"))
      {
          if(followUpConfirmationNode->Attribute("id"))
          {
             followUpConfirmationIDRef_ = followUpConfirmationNode->Attribute("id");
             followUpConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(followUpConfirmationNode));
             followUpConfirmation_->setID(followUpConfirmationIDRef_);
             IDManager::instance().setID(followUpConfirmationIDRef_,followUpConfirmation_);
          }
          else if(followUpConfirmationNode->Attribute("href")) { followUpConfirmationIDRef_ = followUpConfirmationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { followUpConfirmation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(followUpConfirmationNode));}
   }

   //limitedRightToConfirmNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* limitedRightToConfirmNode = xmlNode->FirstChildElement("limitedRightToConfirm");

   if(limitedRightToConfirmNode){limitedRightToConfirmIsNull_ = false;}
   else{limitedRightToConfirmIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- limitedRightToConfirmNode , address : " << limitedRightToConfirmNode << std::endl;
   #endif
   if(limitedRightToConfirmNode)
   {
      if(limitedRightToConfirmNode->Attribute("href") || limitedRightToConfirmNode->Attribute("id"))
      {
          if(limitedRightToConfirmNode->Attribute("id"))
          {
             limitedRightToConfirmIDRef_ = limitedRightToConfirmNode->Attribute("id");
             limitedRightToConfirm_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(limitedRightToConfirmNode));
             limitedRightToConfirm_->setID(limitedRightToConfirmIDRef_);
             IDManager::instance().setID(limitedRightToConfirmIDRef_,limitedRightToConfirm_);
          }
          else if(limitedRightToConfirmNode->Attribute("href")) { limitedRightToConfirmIDRef_ = limitedRightToConfirmNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { limitedRightToConfirm_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(limitedRightToConfirmNode));}
   }

   //splitTicketNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* splitTicketNode = xmlNode->FirstChildElement("splitTicket");

   if(splitTicketNode){splitTicketIsNull_ = false;}
   else{splitTicketIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- splitTicketNode , address : " << splitTicketNode << std::endl;
   #endif
   if(splitTicketNode)
   {
      if(splitTicketNode->Attribute("href") || splitTicketNode->Attribute("id"))
      {
          if(splitTicketNode->Attribute("id"))
          {
             splitTicketIDRef_ = splitTicketNode->Attribute("id");
             splitTicket_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(splitTicketNode));
             splitTicket_->setID(splitTicketIDRef_);
             IDManager::instance().setID(splitTicketIDRef_,splitTicket_);
          }
          else if(splitTicketNode->Attribute("href")) { splitTicketIDRef_ = splitTicketNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { splitTicket_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(splitTicketNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ManualExercise> ExerciseProcedure::getManualExercise()
{
   if(!this->manualExerciseIsNull_){
        if(manualExerciseIDRef_ != ""){
             return boost::shared_static_cast<ManualExercise>(IDManager::instance().getID(manualExerciseIDRef_));
        }else{
             return this->manualExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ManualExercise>();
   }
}
boost::shared_ptr<AutomaticExercise> ExerciseProcedure::getAutomaticExercise()
{
   if(!this->automaticExerciseIsNull_){
        if(automaticExerciseIDRef_ != ""){
             return boost::shared_static_cast<AutomaticExercise>(IDManager::instance().getID(automaticExerciseIDRef_));
        }else{
             return this->automaticExercise_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AutomaticExercise>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ExerciseProcedure::getFollowUpConfirmation()
{
   if(!this->followUpConfirmationIsNull_){
        if(followUpConfirmationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(followUpConfirmationIDRef_));
        }else{
             return this->followUpConfirmation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ExerciseProcedure::getLimitedRightToConfirm()
{
   if(!this->limitedRightToConfirmIsNull_){
        if(limitedRightToConfirmIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(limitedRightToConfirmIDRef_));
        }else{
             return this->limitedRightToConfirm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> ExerciseProcedure::getSplitTicket()
{
   if(!this->splitTicketIsNull_){
        if(splitTicketIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(splitTicketIDRef_));
        }else{
             return this->splitTicket_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

