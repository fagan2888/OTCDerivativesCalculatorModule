// Approval.cpp 
#include "Approval.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Approval::Approval(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
      if(typeNode->Attribute("href") || typeNode->Attribute("id"))
      {
          if(typeNode->Attribute("id"))
          {
             typeIDRef_ = typeNode->Attribute("id");
             type_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(typeNode));}
   }

   //statusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* statusNode = xmlNode->FirstChildElement("status");

   if(statusNode){statusIsNull_ = false;}
   else{statusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- statusNode , address : " << statusNode << std::endl;
   #endif
   if(statusNode)
   {
      if(statusNode->Attribute("href") || statusNode->Attribute("id"))
      {
          if(statusNode->Attribute("id"))
          {
             statusIDRef_ = statusNode->Attribute("id");
             status_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(statusNode));
             status_->setID(statusIDRef_);
             IDManager::instance().setID(statusIDRef_,status_);
          }
          else if(statusNode->Attribute("href")) { statusIDRef_ = statusNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { status_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(statusNode));}
   }

   //approverNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* approverNode = xmlNode->FirstChildElement("approver");

   if(approverNode){approverIsNull_ = false;}
   else{approverIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- approverNode , address : " << approverNode << std::endl;
   #endif
   if(approverNode)
   {
      if(approverNode->Attribute("href") || approverNode->Attribute("id"))
      {
          if(approverNode->Attribute("id"))
          {
             approverIDRef_ = approverNode->Attribute("id");
             approver_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(approverNode));
             approver_->setID(approverIDRef_);
             IDManager::instance().setID(approverIDRef_,approver_);
          }
          else if(approverNode->Attribute("href")) { approverIDRef_ = approverNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { approver_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(approverNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeNormalizedString> Approval::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<XsdTypeNormalizedString> Approval::getStatus()
{
   if(!this->statusIsNull_){
        if(statusIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(statusIDRef_));
        }else{
             return this->status_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<XsdTypeNormalizedString> Approval::getApprover()
{
   if(!this->approverIsNull_){
        if(approverIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(approverIDRef_));
        }else{
             return this->approver_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
}

