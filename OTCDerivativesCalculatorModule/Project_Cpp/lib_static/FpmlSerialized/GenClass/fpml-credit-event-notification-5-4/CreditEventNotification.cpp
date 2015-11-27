// CreditEventNotification.cpp 
#include "CreditEventNotification.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditEventNotification::CreditEventNotification(TiXmlNode* xmlNode)
: CorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //creditEventNoticeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventNoticeNode = xmlNode->FirstChildElement("creditEventNotice");

   if(creditEventNoticeNode){creditEventNoticeIsNull_ = false;}
   else{creditEventNoticeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventNoticeNode , address : " << creditEventNoticeNode << std::endl;
   #endif
   if(creditEventNoticeNode)
   {
      if(creditEventNoticeNode->Attribute("href") || creditEventNoticeNode->Attribute("id"))
      {
          if(creditEventNoticeNode->Attribute("id"))
          {
             creditEventNoticeIDRef_ = creditEventNoticeNode->Attribute("id");
             creditEventNotice_ = boost::shared_ptr<CreditEventNoticeDocument>(new CreditEventNoticeDocument(creditEventNoticeNode));
             creditEventNotice_->setID(creditEventNoticeIDRef_);
             IDManager::instance().setID(creditEventNoticeIDRef_,creditEventNotice_);
          }
          else if(creditEventNoticeNode->Attribute("href")) { creditEventNoticeIDRef_ = creditEventNoticeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEventNotice_ = boost::shared_ptr<CreditEventNoticeDocument>(new CreditEventNoticeDocument(creditEventNoticeNode));}
   }

   //partyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyNode = xmlNode->FirstChildElement("party");

   if(partyNode){partyIsNull_ = false;}
   else{partyIsNull_ = true;}

   if(partyNode)
   {
      for(partyNode; partyNode; partyNode = partyNode->NextSiblingElement("party")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
          #endif
          if(partyNode->Attribute("href") || partyNode->Attribute("id"))
          {
              if(partyNode->Attribute("id"))
              {
                  partyIDRef_ = partyNode->Attribute("id");
                  party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));
                  party_.back()->setID(partyIDRef_);
                  IDManager::instance().setID(partyIDRef_, party_.back());
              }
              else if(partyNode->Attribute("href")) { partyIDRef_ = partyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CreditEventNoticeDocument> CreditEventNotification::getCreditEventNotice()
{
   if(!this->creditEventNoticeIsNull_){
        if(creditEventNoticeIDRef_ != ""){
             return boost::shared_static_cast<CreditEventNoticeDocument>(IDManager::instance().getID(creditEventNoticeIDRef_));
        }else{
             return this->creditEventNotice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEventNoticeDocument>();
   }
}
std::vector<boost::shared_ptr<Party>> CreditEventNotification::getParty()
{
   if(!this->partyIsNull_){
        if(partyIDRef_ != ""){
             return this->party_;
        }else{
             return this->party_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Party>>();
   }
}
}

