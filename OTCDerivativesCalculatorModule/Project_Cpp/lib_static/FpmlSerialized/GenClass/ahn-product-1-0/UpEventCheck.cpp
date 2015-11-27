// UpEventCheck.cpp 
#include "UpEventCheck.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

UpEventCheck::UpEventCheck(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //checkValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* checkValueNode = xmlNode->FirstChildElement("checkValue");

   if(checkValueNode){checkValueIsNull_ = false;}
   else{checkValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- checkValueNode , address : " << checkValueNode << std::endl;
   #endif
   if(checkValueNode)
   {
      if(checkValueNode->Attribute("href") || checkValueNode->Attribute("id"))
      {
          if(checkValueNode->Attribute("id"))
          {
             checkValueIDRef_ = checkValueNode->Attribute("id");
             checkValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(checkValueNode));
             checkValue_->setID(checkValueIDRef_);
             IDManager::instance().setID(checkValueIDRef_,checkValue_);
          }
          else if(checkValueNode->Attribute("href")) { checkValueIDRef_ = checkValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { checkValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(checkValueNode));}
   }

   //equalityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* equalityNode = xmlNode->FirstChildElement("equality");

   if(equalityNode){equalityIsNull_ = false;}
   else{equalityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- equalityNode , address : " << equalityNode << std::endl;
   #endif
   if(equalityNode)
   {
      if(equalityNode->Attribute("href") || equalityNode->Attribute("id"))
      {
          if(equalityNode->Attribute("id"))
          {
             equalityIDRef_ = equalityNode->Attribute("id");
             equality_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(equalityNode));
             equality_->setID(equalityIDRef_);
             IDManager::instance().setID(equalityIDRef_,equality_);
          }
          else if(equalityNode->Attribute("href")) { equalityIDRef_ = equalityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { equality_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(equalityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> UpEventCheck::getCheckValue()
{
   if(!this->checkValueIsNull_){
        if(checkValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDouble>(IDManager::instance().getID(checkValueIDRef_));
        }else{
             return this->checkValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeBoolean> UpEventCheck::getEquality()
{
   if(!this->equalityIsNull_){
        if(equalityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(equalityIDRef_));
        }else{
             return this->equality_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

