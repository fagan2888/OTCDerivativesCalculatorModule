// SubEvent.cpp 
#include "SubEvent.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SubEvent::SubEvent(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //refEventIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refEventIDNode = xmlNode->FirstChildElement("refEventID");

   if(refEventIDNode){refEventIDIsNull_ = false;}
   else{refEventIDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refEventIDNode , address : " << refEventIDNode << std::endl;
   #endif
   if(refEventIDNode)
   {
      if(refEventIDNode->Attribute("href") || refEventIDNode->Attribute("id"))
      {
          if(refEventIDNode->Attribute("id"))
          {
             refEventIDIDRef_ = refEventIDNode->Attribute("id");
             refEventID_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refEventIDNode));
             refEventID_->setID(refEventIDIDRef_);
             IDManager::instance().setID(refEventIDIDRef_,refEventID_);
          }
          else if(refEventIDNode->Attribute("href")) { refEventIDIDRef_ = refEventIDNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { refEventID_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refEventIDNode));}
   }

   //truefalseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* truefalseNode = xmlNode->FirstChildElement("truefalse");

   if(truefalseNode){truefalseIsNull_ = false;}
   else{truefalseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- truefalseNode , address : " << truefalseNode << std::endl;
   #endif
   if(truefalseNode)
   {
      if(truefalseNode->Attribute("href") || truefalseNode->Attribute("id"))
      {
          if(truefalseNode->Attribute("id"))
          {
             truefalseIDRef_ = truefalseNode->Attribute("id");
             truefalse_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(truefalseNode));
             truefalse_->setID(truefalseIDRef_);
             IDManager::instance().setID(truefalseIDRef_,truefalse_);
          }
          else if(truefalseNode->Attribute("href")) { truefalseIDRef_ = truefalseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { truefalse_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(truefalseNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> SubEvent::getRefEventID()
{
   if(!this->refEventIDIsNull_){
        if(refEventIDIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(refEventIDIDRef_));
        }else{
             return this->refEventID_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeBoolean> SubEvent::getTruefalse()
{
   if(!this->truefalseIsNull_){
        if(truefalseIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(truefalseIDRef_));
        }else{
             return this->truefalse_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

