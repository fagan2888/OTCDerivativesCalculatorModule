// GracePeriodExtension.cpp 
#include "GracePeriodExtension.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GracePeriodExtension::GracePeriodExtension(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //applicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* applicableNode = xmlNode->FirstChildElement("applicable");

   if(applicableNode){applicableIsNull_ = false;}
   else{applicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- applicableNode , address : " << applicableNode << std::endl;
   #endif
   if(applicableNode)
   {
      if(applicableNode->Attribute("href") || applicableNode->Attribute("id"))
      {
          if(applicableNode->Attribute("id"))
          {
             applicableIDRef_ = applicableNode->Attribute("id");
             applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));
             applicable_->setID(applicableIDRef_);
             IDManager::instance().setID(applicableIDRef_,applicable_);
          }
          else if(applicableNode->Attribute("href")) { applicableIDRef_ = applicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { applicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(applicableNode));}
   }

   //gracePeriodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gracePeriodNode = xmlNode->FirstChildElement("gracePeriod");

   if(gracePeriodNode){gracePeriodIsNull_ = false;}
   else{gracePeriodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gracePeriodNode , address : " << gracePeriodNode << std::endl;
   #endif
   if(gracePeriodNode)
   {
      if(gracePeriodNode->Attribute("href") || gracePeriodNode->Attribute("id"))
      {
          if(gracePeriodNode->Attribute("id"))
          {
             gracePeriodIDRef_ = gracePeriodNode->Attribute("id");
             gracePeriod_ = boost::shared_ptr<Offset>(new Offset(gracePeriodNode));
             gracePeriod_->setID(gracePeriodIDRef_);
             IDManager::instance().setID(gracePeriodIDRef_,gracePeriod_);
          }
          else if(gracePeriodNode->Attribute("href")) { gracePeriodIDRef_ = gracePeriodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { gracePeriod_ = boost::shared_ptr<Offset>(new Offset(gracePeriodNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> GracePeriodExtension::getApplicable()
{
   if(!this->applicableIsNull_){
        if(applicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(applicableIDRef_));
        }else{
             return this->applicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Offset> GracePeriodExtension::getGracePeriod()
{
   if(!this->gracePeriodIsNull_){
        if(gracePeriodIDRef_ != ""){
             return boost::shared_static_cast<Offset>(IDManager::instance().getID(gracePeriodIDRef_));
        }else{
             return this->gracePeriod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Offset>();
   }
}
}

