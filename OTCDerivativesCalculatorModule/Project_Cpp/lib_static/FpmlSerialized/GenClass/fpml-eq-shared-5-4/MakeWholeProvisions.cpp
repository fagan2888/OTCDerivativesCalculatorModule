// MakeWholeProvisions.cpp 
#include "MakeWholeProvisions.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MakeWholeProvisions::MakeWholeProvisions(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //makeWholeDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* makeWholeDateNode = xmlNode->FirstChildElement("makeWholeDate");

   if(makeWholeDateNode){makeWholeDateIsNull_ = false;}
   else{makeWholeDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- makeWholeDateNode , address : " << makeWholeDateNode << std::endl;
   #endif
   if(makeWholeDateNode)
   {
      if(makeWholeDateNode->Attribute("href") || makeWholeDateNode->Attribute("id"))
      {
          if(makeWholeDateNode->Attribute("id"))
          {
             makeWholeDateIDRef_ = makeWholeDateNode->Attribute("id");
             makeWholeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(makeWholeDateNode));
             makeWholeDate_->setID(makeWholeDateIDRef_);
             IDManager::instance().setID(makeWholeDateIDRef_,makeWholeDate_);
          }
          else if(makeWholeDateNode->Attribute("href")) { makeWholeDateIDRef_ = makeWholeDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { makeWholeDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(makeWholeDateNode));}
   }

   //recallSpreadNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* recallSpreadNode = xmlNode->FirstChildElement("recallSpread");

   if(recallSpreadNode){recallSpreadIsNull_ = false;}
   else{recallSpreadIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- recallSpreadNode , address : " << recallSpreadNode << std::endl;
   #endif
   if(recallSpreadNode)
   {
      if(recallSpreadNode->Attribute("href") || recallSpreadNode->Attribute("id"))
      {
          if(recallSpreadNode->Attribute("id"))
          {
             recallSpreadIDRef_ = recallSpreadNode->Attribute("id");
             recallSpread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(recallSpreadNode));
             recallSpread_->setID(recallSpreadIDRef_);
             IDManager::instance().setID(recallSpreadIDRef_,recallSpread_);
          }
          else if(recallSpreadNode->Attribute("href")) { recallSpreadIDRef_ = recallSpreadNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { recallSpread_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(recallSpreadNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDate> MakeWholeProvisions::getMakeWholeDate()
{
   if(!this->makeWholeDateIsNull_){
        if(makeWholeDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(makeWholeDateIDRef_));
        }else{
             return this->makeWholeDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDecimal> MakeWholeProvisions::getRecallSpread()
{
   if(!this->recallSpreadIsNull_){
        if(recallSpreadIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(recallSpreadIDRef_));
        }else{
             return this->recallSpread_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

