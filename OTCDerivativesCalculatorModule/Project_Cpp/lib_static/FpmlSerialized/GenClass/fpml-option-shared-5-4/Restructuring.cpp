// Restructuring.cpp 
#include "Restructuring.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Restructuring::Restructuring(TiXmlNode* xmlNode)
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

   //restructuringTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* restructuringTypeNode = xmlNode->FirstChildElement("restructuringType");

   if(restructuringTypeNode){restructuringTypeIsNull_ = false;}
   else{restructuringTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- restructuringTypeNode , address : " << restructuringTypeNode << std::endl;
   #endif
   if(restructuringTypeNode)
   {
      if(restructuringTypeNode->Attribute("href") || restructuringTypeNode->Attribute("id"))
      {
          if(restructuringTypeNode->Attribute("id"))
          {
             restructuringTypeIDRef_ = restructuringTypeNode->Attribute("id");
             restructuringType_ = boost::shared_ptr<RestructuringType>(new RestructuringType(restructuringTypeNode));
             restructuringType_->setID(restructuringTypeIDRef_);
             IDManager::instance().setID(restructuringTypeIDRef_,restructuringType_);
          }
          else if(restructuringTypeNode->Attribute("href")) { restructuringTypeIDRef_ = restructuringTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { restructuringType_ = boost::shared_ptr<RestructuringType>(new RestructuringType(restructuringTypeNode));}
   }

   //multipleHolderObligationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleHolderObligationNode = xmlNode->FirstChildElement("multipleHolderObligation");

   if(multipleHolderObligationNode){multipleHolderObligationIsNull_ = false;}
   else{multipleHolderObligationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleHolderObligationNode , address : " << multipleHolderObligationNode << std::endl;
   #endif
   if(multipleHolderObligationNode)
   {
      if(multipleHolderObligationNode->Attribute("href") || multipleHolderObligationNode->Attribute("id"))
      {
          if(multipleHolderObligationNode->Attribute("id"))
          {
             multipleHolderObligationIDRef_ = multipleHolderObligationNode->Attribute("id");
             multipleHolderObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleHolderObligationNode));
             multipleHolderObligation_->setID(multipleHolderObligationIDRef_);
             IDManager::instance().setID(multipleHolderObligationIDRef_,multipleHolderObligation_);
          }
          else if(multipleHolderObligationNode->Attribute("href")) { multipleHolderObligationIDRef_ = multipleHolderObligationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleHolderObligation_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleHolderObligationNode));}
   }

   //multipleCreditEventNoticesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleCreditEventNoticesNode = xmlNode->FirstChildElement("multipleCreditEventNotices");

   if(multipleCreditEventNoticesNode){multipleCreditEventNoticesIsNull_ = false;}
   else{multipleCreditEventNoticesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleCreditEventNoticesNode , address : " << multipleCreditEventNoticesNode << std::endl;
   #endif
   if(multipleCreditEventNoticesNode)
   {
      if(multipleCreditEventNoticesNode->Attribute("href") || multipleCreditEventNoticesNode->Attribute("id"))
      {
          if(multipleCreditEventNoticesNode->Attribute("id"))
          {
             multipleCreditEventNoticesIDRef_ = multipleCreditEventNoticesNode->Attribute("id");
             multipleCreditEventNotices_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleCreditEventNoticesNode));
             multipleCreditEventNotices_->setID(multipleCreditEventNoticesIDRef_);
             IDManager::instance().setID(multipleCreditEventNoticesIDRef_,multipleCreditEventNotices_);
          }
          else if(multipleCreditEventNoticesNode->Attribute("href")) { multipleCreditEventNoticesIDRef_ = multipleCreditEventNoticesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { multipleCreditEventNotices_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(multipleCreditEventNoticesNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> Restructuring::getApplicable()
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
boost::shared_ptr<RestructuringType> Restructuring::getRestructuringType()
{
   if(!this->restructuringTypeIsNull_){
        if(restructuringTypeIDRef_ != ""){
             return boost::shared_static_cast<RestructuringType>(IDManager::instance().getID(restructuringTypeIDRef_));
        }else{
             return this->restructuringType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestructuringType>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Restructuring::getMultipleHolderObligation()
{
   if(!this->multipleHolderObligationIsNull_){
        if(multipleHolderObligationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(multipleHolderObligationIDRef_));
        }else{
             return this->multipleHolderObligation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Restructuring::getMultipleCreditEventNotices()
{
   if(!this->multipleCreditEventNoticesIsNull_){
        if(multipleCreditEventNoticesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(multipleCreditEventNoticesIDRef_));
        }else{
             return this->multipleCreditEventNotices_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

