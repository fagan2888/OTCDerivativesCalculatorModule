// MasterAgreement.cpp 
#include "MasterAgreement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MasterAgreement::MasterAgreement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //masterAgreementTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterAgreementTypeNode = xmlNode->FirstChildElement("masterAgreementType");

   if(masterAgreementTypeNode){masterAgreementTypeIsNull_ = false;}
   else{masterAgreementTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterAgreementTypeNode , address : " << masterAgreementTypeNode << std::endl;
   #endif
   if(masterAgreementTypeNode)
   {
      if(masterAgreementTypeNode->Attribute("href") || masterAgreementTypeNode->Attribute("id"))
      {
          if(masterAgreementTypeNode->Attribute("id"))
          {
             masterAgreementTypeIDRef_ = masterAgreementTypeNode->Attribute("id");
             masterAgreementType_ = boost::shared_ptr<MasterAgreementType>(new MasterAgreementType(masterAgreementTypeNode));
             masterAgreementType_->setID(masterAgreementTypeIDRef_);
             IDManager::instance().setID(masterAgreementTypeIDRef_,masterAgreementType_);
          }
          else if(masterAgreementTypeNode->Attribute("href")) { masterAgreementTypeIDRef_ = masterAgreementTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterAgreementType_ = boost::shared_ptr<MasterAgreementType>(new MasterAgreementType(masterAgreementTypeNode));}
   }

   //masterAgreementVersionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterAgreementVersionNode = xmlNode->FirstChildElement("masterAgreementVersion");

   if(masterAgreementVersionNode){masterAgreementVersionIsNull_ = false;}
   else{masterAgreementVersionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterAgreementVersionNode , address : " << masterAgreementVersionNode << std::endl;
   #endif
   if(masterAgreementVersionNode)
   {
      if(masterAgreementVersionNode->Attribute("href") || masterAgreementVersionNode->Attribute("id"))
      {
          if(masterAgreementVersionNode->Attribute("id"))
          {
             masterAgreementVersionIDRef_ = masterAgreementVersionNode->Attribute("id");
             masterAgreementVersion_ = boost::shared_ptr<MasterAgreementVersion>(new MasterAgreementVersion(masterAgreementVersionNode));
             masterAgreementVersion_->setID(masterAgreementVersionIDRef_);
             IDManager::instance().setID(masterAgreementVersionIDRef_,masterAgreementVersion_);
          }
          else if(masterAgreementVersionNode->Attribute("href")) { masterAgreementVersionIDRef_ = masterAgreementVersionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterAgreementVersion_ = boost::shared_ptr<MasterAgreementVersion>(new MasterAgreementVersion(masterAgreementVersionNode));}
   }

   //masterAgreementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterAgreementDateNode = xmlNode->FirstChildElement("masterAgreementDate");

   if(masterAgreementDateNode){masterAgreementDateIsNull_ = false;}
   else{masterAgreementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterAgreementDateNode , address : " << masterAgreementDateNode << std::endl;
   #endif
   if(masterAgreementDateNode)
   {
      if(masterAgreementDateNode->Attribute("href") || masterAgreementDateNode->Attribute("id"))
      {
          if(masterAgreementDateNode->Attribute("id"))
          {
             masterAgreementDateIDRef_ = masterAgreementDateNode->Attribute("id");
             masterAgreementDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterAgreementDateNode));
             masterAgreementDate_->setID(masterAgreementDateIDRef_);
             IDManager::instance().setID(masterAgreementDateIDRef_,masterAgreementDate_);
          }
          else if(masterAgreementDateNode->Attribute("href")) { masterAgreementDateIDRef_ = masterAgreementDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterAgreementDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterAgreementDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MasterAgreementType> MasterAgreement::getMasterAgreementType()
{
   if(!this->masterAgreementTypeIsNull_){
        if(masterAgreementTypeIDRef_ != ""){
             return boost::shared_static_cast<MasterAgreementType>(IDManager::instance().getID(masterAgreementTypeIDRef_));
        }else{
             return this->masterAgreementType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MasterAgreementType>();
   }
}
boost::shared_ptr<MasterAgreementVersion> MasterAgreement::getMasterAgreementVersion()
{
   if(!this->masterAgreementVersionIsNull_){
        if(masterAgreementVersionIDRef_ != ""){
             return boost::shared_static_cast<MasterAgreementVersion>(IDManager::instance().getID(masterAgreementVersionIDRef_));
        }else{
             return this->masterAgreementVersion_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MasterAgreementVersion>();
   }
}
boost::shared_ptr<XsdTypeDate> MasterAgreement::getMasterAgreementDate()
{
   if(!this->masterAgreementDateIsNull_){
        if(masterAgreementDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(masterAgreementDateIDRef_));
        }else{
             return this->masterAgreementDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

