// ReferenceBank.cpp 
#include "ReferenceBank.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceBank::ReferenceBank(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceBankIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceBankIdNode = xmlNode->FirstChildElement("referenceBankId");

   if(referenceBankIdNode){referenceBankIdIsNull_ = false;}
   else{referenceBankIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceBankIdNode , address : " << referenceBankIdNode << std::endl;
   #endif
   if(referenceBankIdNode)
   {
      if(referenceBankIdNode->Attribute("href") || referenceBankIdNode->Attribute("id"))
      {
          if(referenceBankIdNode->Attribute("id"))
          {
             referenceBankIdIDRef_ = referenceBankIdNode->Attribute("id");
             referenceBankId_ = boost::shared_ptr<ReferenceBankId>(new ReferenceBankId(referenceBankIdNode));
             referenceBankId_->setID(referenceBankIdIDRef_);
             IDManager::instance().setID(referenceBankIdIDRef_,referenceBankId_);
          }
          else if(referenceBankIdNode->Attribute("href")) { referenceBankIdIDRef_ = referenceBankIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceBankId_ = boost::shared_ptr<ReferenceBankId>(new ReferenceBankId(referenceBankIdNode));}
   }

   //referenceBankNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceBankNameNode = xmlNode->FirstChildElement("referenceBankName");

   if(referenceBankNameNode){referenceBankNameIsNull_ = false;}
   else{referenceBankNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceBankNameNode , address : " << referenceBankNameNode << std::endl;
   #endif
   if(referenceBankNameNode)
   {
      if(referenceBankNameNode->Attribute("href") || referenceBankNameNode->Attribute("id"))
      {
          if(referenceBankNameNode->Attribute("id"))
          {
             referenceBankNameIDRef_ = referenceBankNameNode->Attribute("id");
             referenceBankName_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(referenceBankNameNode));
             referenceBankName_->setID(referenceBankNameIDRef_);
             IDManager::instance().setID(referenceBankNameIDRef_,referenceBankName_);
          }
          else if(referenceBankNameNode->Attribute("href")) { referenceBankNameIDRef_ = referenceBankNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceBankName_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(referenceBankNameNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReferenceBankId> ReferenceBank::getReferenceBankId()
{
   if(!this->referenceBankIdIsNull_){
        if(referenceBankIdIDRef_ != ""){
             return boost::shared_static_cast<ReferenceBankId>(IDManager::instance().getID(referenceBankIdIDRef_));
        }else{
             return this->referenceBankId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceBankId>();
   }
}
boost::shared_ptr<XsdTypeString> ReferenceBank::getReferenceBankName()
{
   if(!this->referenceBankNameIsNull_){
        if(referenceBankNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(referenceBankNameIDRef_));
        }else{
             return this->referenceBankName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

