// Function.cpp 
#include "Function.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Function::Function(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));}
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
boost::shared_ptr<XsdTypeToken> Function::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Function::getTruefalse()
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

