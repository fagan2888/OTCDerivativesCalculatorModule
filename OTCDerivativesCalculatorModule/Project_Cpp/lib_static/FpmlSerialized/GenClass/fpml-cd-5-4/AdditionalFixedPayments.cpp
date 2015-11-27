// AdditionalFixedPayments.cpp 
#include "AdditionalFixedPayments.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdditionalFixedPayments::AdditionalFixedPayments(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //interestShortfallReimbursementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestShortfallReimbursementNode = xmlNode->FirstChildElement("interestShortfallReimbursement");

   if(interestShortfallReimbursementNode){interestShortfallReimbursementIsNull_ = false;}
   else{interestShortfallReimbursementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestShortfallReimbursementNode , address : " << interestShortfallReimbursementNode << std::endl;
   #endif
   if(interestShortfallReimbursementNode)
   {
      if(interestShortfallReimbursementNode->Attribute("href") || interestShortfallReimbursementNode->Attribute("id"))
      {
          if(interestShortfallReimbursementNode->Attribute("id"))
          {
             interestShortfallReimbursementIDRef_ = interestShortfallReimbursementNode->Attribute("id");
             interestShortfallReimbursement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(interestShortfallReimbursementNode));
             interestShortfallReimbursement_->setID(interestShortfallReimbursementIDRef_);
             IDManager::instance().setID(interestShortfallReimbursementIDRef_,interestShortfallReimbursement_);
          }
          else if(interestShortfallReimbursementNode->Attribute("href")) { interestShortfallReimbursementIDRef_ = interestShortfallReimbursementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { interestShortfallReimbursement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(interestShortfallReimbursementNode));}
   }

   //principalShortfallReimbursementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalShortfallReimbursementNode = xmlNode->FirstChildElement("principalShortfallReimbursement");

   if(principalShortfallReimbursementNode){principalShortfallReimbursementIsNull_ = false;}
   else{principalShortfallReimbursementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalShortfallReimbursementNode , address : " << principalShortfallReimbursementNode << std::endl;
   #endif
   if(principalShortfallReimbursementNode)
   {
      if(principalShortfallReimbursementNode->Attribute("href") || principalShortfallReimbursementNode->Attribute("id"))
      {
          if(principalShortfallReimbursementNode->Attribute("id"))
          {
             principalShortfallReimbursementIDRef_ = principalShortfallReimbursementNode->Attribute("id");
             principalShortfallReimbursement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(principalShortfallReimbursementNode));
             principalShortfallReimbursement_->setID(principalShortfallReimbursementIDRef_);
             IDManager::instance().setID(principalShortfallReimbursementIDRef_,principalShortfallReimbursement_);
          }
          else if(principalShortfallReimbursementNode->Attribute("href")) { principalShortfallReimbursementIDRef_ = principalShortfallReimbursementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principalShortfallReimbursement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(principalShortfallReimbursementNode));}
   }

   //writedownReimbursementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* writedownReimbursementNode = xmlNode->FirstChildElement("writedownReimbursement");

   if(writedownReimbursementNode){writedownReimbursementIsNull_ = false;}
   else{writedownReimbursementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- writedownReimbursementNode , address : " << writedownReimbursementNode << std::endl;
   #endif
   if(writedownReimbursementNode)
   {
      if(writedownReimbursementNode->Attribute("href") || writedownReimbursementNode->Attribute("id"))
      {
          if(writedownReimbursementNode->Attribute("id"))
          {
             writedownReimbursementIDRef_ = writedownReimbursementNode->Attribute("id");
             writedownReimbursement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writedownReimbursementNode));
             writedownReimbursement_->setID(writedownReimbursementIDRef_);
             IDManager::instance().setID(writedownReimbursementIDRef_,writedownReimbursement_);
          }
          else if(writedownReimbursementNode->Attribute("href")) { writedownReimbursementIDRef_ = writedownReimbursementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { writedownReimbursement_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writedownReimbursementNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> AdditionalFixedPayments::getInterestShortfallReimbursement()
{
   if(!this->interestShortfallReimbursementIsNull_){
        if(interestShortfallReimbursementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(interestShortfallReimbursementIDRef_));
        }else{
             return this->interestShortfallReimbursement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalFixedPayments::getPrincipalShortfallReimbursement()
{
   if(!this->principalShortfallReimbursementIsNull_){
        if(principalShortfallReimbursementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(principalShortfallReimbursementIDRef_));
        }else{
             return this->principalShortfallReimbursement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalFixedPayments::getWritedownReimbursement()
{
   if(!this->writedownReimbursementIsNull_){
        if(writedownReimbursementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(writedownReimbursementIDRef_));
        }else{
             return this->writedownReimbursement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

