// VariableValue.cpp 
#include "VariableValue.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VariableValue::VariableValue(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //indexRefNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexRefNode = xmlNode->FirstChildElement("indexRef");

   if(indexRefNode){indexRefIsNull_ = false;}
   else{indexRefIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexRefNode , address : " << indexRefNode << std::endl;
   #endif
   if(indexRefNode)
   {
      if(indexRefNode->Attribute("href") || indexRefNode->Attribute("id"))
      {
          if(indexRefNode->Attribute("id"))
          {
             indexRefIDRef_ = indexRefNode->Attribute("id");
             indexRef_ = boost::shared_ptr<IndexRef>(new IndexRef(indexRefNode));
             indexRef_->setID(indexRefIDRef_);
             IDManager::instance().setID(indexRefIDRef_,indexRef_);
          }
          else if(indexRefNode->Attribute("href")) { indexRefIDRef_ = indexRefNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexRef_ = boost::shared_ptr<IndexRef>(new IndexRef(indexRefNode));}
   }

   //indexTimeRefNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTimeRefNode = xmlNode->FirstChildElement("indexTimeRef");

   if(indexTimeRefNode){indexTimeRefIsNull_ = false;}
   else{indexTimeRefIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTimeRefNode , address : " << indexTimeRefNode << std::endl;
   #endif
   if(indexTimeRefNode)
   {
      if(indexTimeRefNode->Attribute("href") || indexTimeRefNode->Attribute("id"))
      {
          if(indexTimeRefNode->Attribute("id"))
          {
             indexTimeRefIDRef_ = indexTimeRefNode->Attribute("id");
             indexTimeRef_ = boost::shared_ptr<IndexTimeRef>(new IndexTimeRef(indexTimeRefNode));
             indexTimeRef_->setID(indexTimeRefIDRef_);
             IDManager::instance().setID(indexTimeRefIDRef_,indexTimeRef_);
          }
          else if(indexTimeRefNode->Attribute("href")) { indexTimeRefIDRef_ = indexTimeRefNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexTimeRef_ = boost::shared_ptr<IndexTimeRef>(new IndexTimeRef(indexTimeRefNode));}
   }

   //symbolNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* symbolNameNode = xmlNode->FirstChildElement("symbolName");

   if(symbolNameNode){symbolNameIsNull_ = false;}
   else{symbolNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- symbolNameNode , address : " << symbolNameNode << std::endl;
   #endif
   if(symbolNameNode)
   {
      if(symbolNameNode->Attribute("href") || symbolNameNode->Attribute("id"))
      {
          if(symbolNameNode->Attribute("id"))
          {
             symbolNameIDRef_ = symbolNameNode->Attribute("id");
             symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));
             symbolName_->setID(symbolNameIDRef_);
             IDManager::instance().setID(symbolNameIDRef_,symbolName_);
          }
          else if(symbolNameNode->Attribute("href")) { symbolNameIDRef_ = symbolNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));}
   }

   //constValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constValueNode = xmlNode->FirstChildElement("constValue");

   if(constValueNode){constValueIsNull_ = false;}
   else{constValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constValueNode , address : " << constValueNode << std::endl;
   #endif
   if(constValueNode)
   {
      if(constValueNode->Attribute("href") || constValueNode->Attribute("id"))
      {
          if(constValueNode->Attribute("id"))
          {
             constValueIDRef_ = constValueNode->Attribute("id");
             constValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(constValueNode));
             constValue_->setID(constValueIDRef_);
             IDManager::instance().setID(constValueIDRef_,constValue_);
          }
          else if(constValueNode->Attribute("href")) { constValueIDRef_ = constValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { constValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(constValueNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<IndexRef> VariableValue::getIndexRef()
{
   if(!this->indexRefIsNull_){
        if(indexRefIDRef_ != ""){
             return boost::shared_static_cast<IndexRef>(IDManager::instance().getID(indexRefIDRef_));
        }else{
             return this->indexRef_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexRef>();
   }
}
boost::shared_ptr<IndexTimeRef> VariableValue::getIndexTimeRef()
{
   if(!this->indexTimeRefIsNull_){
        if(indexTimeRefIDRef_ != ""){
             return boost::shared_static_cast<IndexTimeRef>(IDManager::instance().getID(indexTimeRefIDRef_));
        }else{
             return this->indexTimeRef_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexTimeRef>();
   }
}
boost::shared_ptr<XsdTypeToken> VariableValue::getSymbolName()
{
   if(!this->symbolNameIsNull_){
        if(symbolNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(symbolNameIDRef_));
        }else{
             return this->symbolName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDouble> VariableValue::getConstValue()
{
   if(!this->constValueIsNull_){
        if(constValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDouble>(IDManager::instance().getID(constValueIDRef_));
        }else{
             return this->constValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

