// CommodityIndex.cpp 
#include "CommodityIndex.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CommodityIndex::CommodityIndex(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //codeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* codeNode = xmlNode->FirstChildElement("code");

   if(codeNode){codeIsNull_ = false;}
   else{codeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- codeNode , address : " << codeNode << std::endl;
   #endif
   if(codeNode)
   {
      if(codeNode->Attribute("href") || codeNode->Attribute("id"))
      {
          if(codeNode->Attribute("id"))
          {
             codeIDRef_ = codeNode->Attribute("id");
             code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(codeNode));
             code_->setID(codeIDRef_);
             IDManager::instance().setID(codeIDRef_,code_);
          }
          else if(codeNode->Attribute("href")) { codeIDRef_ = codeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(codeNode));}
   }

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

   //indexTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTypeNode = xmlNode->FirstChildElement("indexType");

   if(indexTypeNode){indexTypeIsNull_ = false;}
   else{indexTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTypeNode , address : " << indexTypeNode << std::endl;
   #endif
   if(indexTypeNode)
   {
      if(indexTypeNode->Attribute("href") || indexTypeNode->Attribute("id"))
      {
          if(indexTypeNode->Attribute("id"))
          {
             indexTypeIDRef_ = indexTypeNode->Attribute("id");
             indexType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(indexTypeNode));
             indexType_->setID(indexTypeIDRef_);
             IDManager::instance().setID(indexTypeIDRef_,indexType_);
          }
          else if(indexTypeNode->Attribute("href")) { indexTypeIDRef_ = indexTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(indexTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CommodityIndex::getCode()
{
   if(!this->codeIsNull_){
        if(codeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(codeIDRef_));
        }else{
             return this->code_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CommodityIndex::getName()
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
boost::shared_ptr<XsdTypeToken> CommodityIndex::getIndexType()
{
   if(!this->indexTypeIsNull_){
        if(indexTypeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(indexTypeIDRef_));
        }else{
             return this->indexType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

