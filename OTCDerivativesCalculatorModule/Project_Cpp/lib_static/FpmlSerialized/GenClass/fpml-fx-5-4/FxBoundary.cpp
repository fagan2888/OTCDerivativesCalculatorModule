// FxBoundary.cpp 
#include "FxBoundary.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

FxBoundary::FxBoundary(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //inclusiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inclusiveNode = xmlNode->FirstChildElement("inclusive");

   if(inclusiveNode){inclusiveIsNull_ = false;}
   else{inclusiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inclusiveNode , address : " << inclusiveNode << std::endl;
   #endif
   if(inclusiveNode)
   {
      if(inclusiveNode->Attribute("href") || inclusiveNode->Attribute("id"))
      {
          if(inclusiveNode->Attribute("id"))
          {
             inclusiveIDRef_ = inclusiveNode->Attribute("id");
             inclusive_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(inclusiveNode));
             inclusive_->setID(inclusiveIDRef_);
             IDManager::instance().setID(inclusiveIDRef_,inclusive_);
          }
          else if(inclusiveNode->Attribute("href")) { inclusiveIDRef_ = inclusiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { inclusive_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(inclusiveNode));}
   }

   //exclusiveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* exclusiveNode = xmlNode->FirstChildElement("exclusive");

   if(exclusiveNode){exclusiveIsNull_ = false;}
   else{exclusiveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- exclusiveNode , address : " << exclusiveNode << std::endl;
   #endif
   if(exclusiveNode)
   {
      if(exclusiveNode->Attribute("href") || exclusiveNode->Attribute("id"))
      {
          if(exclusiveNode->Attribute("id"))
          {
             exclusiveIDRef_ = exclusiveNode->Attribute("id");
             exclusive_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(exclusiveNode));
             exclusive_->setID(exclusiveIDRef_);
             IDManager::instance().setID(exclusiveIDRef_,exclusive_);
          }
          else if(exclusiveNode->Attribute("href")) { exclusiveIDRef_ = exclusiveNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { exclusive_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(exclusiveNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> FxBoundary::getInclusive()
{
   if(!this->inclusiveIsNull_){
        if(inclusiveIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(inclusiveIDRef_));
        }else{
             return this->inclusive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> FxBoundary::getExclusive()
{
   if(!this->exclusiveIsNull_){
        if(exclusiveIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(exclusiveIDRef_));
        }else{
             return this->exclusive_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

