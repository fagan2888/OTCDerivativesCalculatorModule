// ExerciseNotice.cpp 
#include "ExerciseNotice.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExerciseNotice::ExerciseNotice(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyReferenceNode = xmlNode->FirstChildElement("partyReference");

   if(partyReferenceNode){partyReferenceIsNull_ = false;}
   else{partyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyReferenceNode , address : " << partyReferenceNode << std::endl;
   #endif
   if(partyReferenceNode)
   {
      if(partyReferenceNode->Attribute("href") || partyReferenceNode->Attribute("id"))
      {
          if(partyReferenceNode->Attribute("id"))
          {
             partyReferenceIDRef_ = partyReferenceNode->Attribute("id");
             partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));
             partyReference_->setID(partyReferenceIDRef_);
             IDManager::instance().setID(partyReferenceIDRef_,partyReference_);
          }
          else if(partyReferenceNode->Attribute("href")) { partyReferenceIDRef_ = partyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));}
   }

   //exerciseNoticePartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exerciseNoticePartyReferenceNode = xmlNode->FirstChildElement("exerciseNoticePartyReference");

   if(exerciseNoticePartyReferenceNode){exerciseNoticePartyReferenceIsNull_ = false;}
   else{exerciseNoticePartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exerciseNoticePartyReferenceNode , address : " << exerciseNoticePartyReferenceNode << std::endl;
   #endif
   if(exerciseNoticePartyReferenceNode)
   {
      if(exerciseNoticePartyReferenceNode->Attribute("href") || exerciseNoticePartyReferenceNode->Attribute("id"))
      {
          if(exerciseNoticePartyReferenceNode->Attribute("id"))
          {
             exerciseNoticePartyReferenceIDRef_ = exerciseNoticePartyReferenceNode->Attribute("id");
             exerciseNoticePartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(exerciseNoticePartyReferenceNode));
             exerciseNoticePartyReference_->setID(exerciseNoticePartyReferenceIDRef_);
             IDManager::instance().setID(exerciseNoticePartyReferenceIDRef_,exerciseNoticePartyReference_);
          }
          else if(exerciseNoticePartyReferenceNode->Attribute("href")) { exerciseNoticePartyReferenceIDRef_ = exerciseNoticePartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exerciseNoticePartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(exerciseNoticePartyReferenceNode));}
   }

   //businessCenterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCenterNode = xmlNode->FirstChildElement("businessCenter");

   if(businessCenterNode){businessCenterIsNull_ = false;}
   else{businessCenterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCenterNode , address : " << businessCenterNode << std::endl;
   #endif
   if(businessCenterNode)
   {
      if(businessCenterNode->Attribute("href") || businessCenterNode->Attribute("id"))
      {
          if(businessCenterNode->Attribute("id"))
          {
             businessCenterIDRef_ = businessCenterNode->Attribute("id");
             businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));
             businessCenter_->setID(businessCenterIDRef_);
             IDManager::instance().setID(businessCenterIDRef_,businessCenter_);
          }
          else if(businessCenterNode->Attribute("href")) { businessCenterIDRef_ = businessCenterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenter_ = boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ExerciseNotice::getPartyReference()
{
   if(!this->partyReferenceIsNull_){
        if(partyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(partyReferenceIDRef_));
        }else{
             return this->partyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<PartyReference> ExerciseNotice::getExerciseNoticePartyReference()
{
   if(!this->exerciseNoticePartyReferenceIsNull_){
        if(exerciseNoticePartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(exerciseNoticePartyReferenceIDRef_));
        }else{
             return this->exerciseNoticePartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<BusinessCenter> ExerciseNotice::getBusinessCenter()
{
   if(!this->businessCenterIsNull_){
        if(businessCenterIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenter>(IDManager::instance().getID(businessCenterIDRef_));
        }else{
             return this->businessCenter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenter>();
   }
}
}

