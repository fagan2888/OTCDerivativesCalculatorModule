// SimpleFra.cpp 
#include "SimpleFra.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SimpleFra::SimpleFra(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //startTermNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* startTermNode = xmlNode->FirstChildElement("startTerm");

   if(startTermNode){startTermIsNull_ = false;}
   else{startTermIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- startTermNode , address : " << startTermNode << std::endl;
   #endif
   if(startTermNode)
   {
      if(startTermNode->Attribute("href") || startTermNode->Attribute("id"))
      {
          if(startTermNode->Attribute("id"))
          {
             startTermIDRef_ = startTermNode->Attribute("id");
             startTerm_ = boost::shared_ptr<Period>(new Period(startTermNode));
             startTerm_->setID(startTermIDRef_);
             IDManager::instance().setID(startTermIDRef_,startTerm_);
          }
          else if(startTermNode->Attribute("href")) { startTermIDRef_ = startTermNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { startTerm_ = boost::shared_ptr<Period>(new Period(startTermNode));}
   }

   //endTermNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endTermNode = xmlNode->FirstChildElement("endTerm");

   if(endTermNode){endTermIsNull_ = false;}
   else{endTermIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endTermNode , address : " << endTermNode << std::endl;
   #endif
   if(endTermNode)
   {
      if(endTermNode->Attribute("href") || endTermNode->Attribute("id"))
      {
          if(endTermNode->Attribute("id"))
          {
             endTermIDRef_ = endTermNode->Attribute("id");
             endTerm_ = boost::shared_ptr<Period>(new Period(endTermNode));
             endTerm_->setID(endTermIDRef_);
             IDManager::instance().setID(endTermIDRef_,endTerm_);
          }
          else if(endTermNode->Attribute("href")) { endTermIDRef_ = endTermNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endTerm_ = boost::shared_ptr<Period>(new Period(endTermNode));}
   }

   //dayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountFractionNode = xmlNode->FirstChildElement("dayCountFraction");

   if(dayCountFractionNode){dayCountFractionIsNull_ = false;}
   else{dayCountFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
   #endif
   if(dayCountFractionNode)
   {
      if(dayCountFractionNode->Attribute("href") || dayCountFractionNode->Attribute("id"))
      {
          if(dayCountFractionNode->Attribute("id"))
          {
             dayCountFractionIDRef_ = dayCountFractionNode->Attribute("id");
             dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));
             dayCountFraction_->setID(dayCountFractionIDRef_);
             IDManager::instance().setID(dayCountFractionIDRef_,dayCountFraction_);
          }
          else if(dayCountFractionNode->Attribute("href")) { dayCountFractionIDRef_ = dayCountFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Period> SimpleFra::getStartTerm()
{
   if(!this->startTermIsNull_){
        if(startTermIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(startTermIDRef_));
        }else{
             return this->startTerm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<Period> SimpleFra::getEndTerm()
{
   if(!this->endTermIsNull_){
        if(endTermIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(endTermIDRef_));
        }else{
             return this->endTerm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<DayCountFraction> SimpleFra::getDayCountFraction()
{
   if(!this->dayCountFractionIsNull_){
        if(dayCountFractionIDRef_ != ""){
             return boost::shared_static_cast<DayCountFraction>(IDManager::instance().getID(dayCountFractionIDRef_));
        }else{
             return this->dayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayCountFraction>();
   }
}
}

