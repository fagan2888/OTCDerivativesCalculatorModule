// ReturnSwapEarlyTermination.cpp 
#include "ReturnSwapEarlyTermination.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReturnSwapEarlyTermination::ReturnSwapEarlyTermination(TiXmlNode* xmlNode)
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

   //startingDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* startingDateNode = xmlNode->FirstChildElement("startingDate");

   if(startingDateNode){startingDateIsNull_ = false;}
   else{startingDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- startingDateNode , address : " << startingDateNode << std::endl;
   #endif
   if(startingDateNode)
   {
      if(startingDateNode->Attribute("href") || startingDateNode->Attribute("id"))
      {
          if(startingDateNode->Attribute("id"))
          {
             startingDateIDRef_ = startingDateNode->Attribute("id");
             startingDate_ = boost::shared_ptr<StartingDate>(new StartingDate(startingDateNode));
             startingDate_->setID(startingDateIDRef_);
             IDManager::instance().setID(startingDateIDRef_,startingDate_);
          }
          else if(startingDateNode->Attribute("href")) { startingDateIDRef_ = startingDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { startingDate_ = boost::shared_ptr<StartingDate>(new StartingDate(startingDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> ReturnSwapEarlyTermination::getPartyReference()
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
boost::shared_ptr<StartingDate> ReturnSwapEarlyTermination::getStartingDate()
{
   if(!this->startingDateIsNull_){
        if(startingDateIDRef_ != ""){
             return boost::shared_static_cast<StartingDate>(IDManager::instance().getID(startingDateIDRef_));
        }else{
             return this->startingDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StartingDate>();
   }
}
}

