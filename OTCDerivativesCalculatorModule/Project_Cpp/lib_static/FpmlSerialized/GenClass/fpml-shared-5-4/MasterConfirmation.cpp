// MasterConfirmation.cpp 
#include "MasterConfirmation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MasterConfirmation::MasterConfirmation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //masterConfirmationTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterConfirmationTypeNode = xmlNode->FirstChildElement("masterConfirmationType");

   if(masterConfirmationTypeNode){masterConfirmationTypeIsNull_ = false;}
   else{masterConfirmationTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterConfirmationTypeNode , address : " << masterConfirmationTypeNode << std::endl;
   #endif
   if(masterConfirmationTypeNode)
   {
      if(masterConfirmationTypeNode->Attribute("href") || masterConfirmationTypeNode->Attribute("id"))
      {
          if(masterConfirmationTypeNode->Attribute("id"))
          {
             masterConfirmationTypeIDRef_ = masterConfirmationTypeNode->Attribute("id");
             masterConfirmationType_ = boost::shared_ptr<MasterConfirmationType>(new MasterConfirmationType(masterConfirmationTypeNode));
             masterConfirmationType_->setID(masterConfirmationTypeIDRef_);
             IDManager::instance().setID(masterConfirmationTypeIDRef_,masterConfirmationType_);
          }
          else if(masterConfirmationTypeNode->Attribute("href")) { masterConfirmationTypeIDRef_ = masterConfirmationTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterConfirmationType_ = boost::shared_ptr<MasterConfirmationType>(new MasterConfirmationType(masterConfirmationTypeNode));}
   }

   //masterConfirmationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterConfirmationDateNode = xmlNode->FirstChildElement("masterConfirmationDate");

   if(masterConfirmationDateNode){masterConfirmationDateIsNull_ = false;}
   else{masterConfirmationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterConfirmationDateNode , address : " << masterConfirmationDateNode << std::endl;
   #endif
   if(masterConfirmationDateNode)
   {
      if(masterConfirmationDateNode->Attribute("href") || masterConfirmationDateNode->Attribute("id"))
      {
          if(masterConfirmationDateNode->Attribute("id"))
          {
             masterConfirmationDateIDRef_ = masterConfirmationDateNode->Attribute("id");
             masterConfirmationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterConfirmationDateNode));
             masterConfirmationDate_->setID(masterConfirmationDateIDRef_);
             IDManager::instance().setID(masterConfirmationDateIDRef_,masterConfirmationDate_);
          }
          else if(masterConfirmationDateNode->Attribute("href")) { masterConfirmationDateIDRef_ = masterConfirmationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterConfirmationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterConfirmationDateNode));}
   }

   //masterConfirmationAnnexDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterConfirmationAnnexDateNode = xmlNode->FirstChildElement("masterConfirmationAnnexDate");

   if(masterConfirmationAnnexDateNode){masterConfirmationAnnexDateIsNull_ = false;}
   else{masterConfirmationAnnexDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterConfirmationAnnexDateNode , address : " << masterConfirmationAnnexDateNode << std::endl;
   #endif
   if(masterConfirmationAnnexDateNode)
   {
      if(masterConfirmationAnnexDateNode->Attribute("href") || masterConfirmationAnnexDateNode->Attribute("id"))
      {
          if(masterConfirmationAnnexDateNode->Attribute("id"))
          {
             masterConfirmationAnnexDateIDRef_ = masterConfirmationAnnexDateNode->Attribute("id");
             masterConfirmationAnnexDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterConfirmationAnnexDateNode));
             masterConfirmationAnnexDate_->setID(masterConfirmationAnnexDateIDRef_);
             IDManager::instance().setID(masterConfirmationAnnexDateIDRef_,masterConfirmationAnnexDate_);
          }
          else if(masterConfirmationAnnexDateNode->Attribute("href")) { masterConfirmationAnnexDateIDRef_ = masterConfirmationAnnexDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterConfirmationAnnexDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(masterConfirmationAnnexDateNode));}
   }

   //masterConfirmationAnnexTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* masterConfirmationAnnexTypeNode = xmlNode->FirstChildElement("masterConfirmationAnnexType");

   if(masterConfirmationAnnexTypeNode){masterConfirmationAnnexTypeIsNull_ = false;}
   else{masterConfirmationAnnexTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- masterConfirmationAnnexTypeNode , address : " << masterConfirmationAnnexTypeNode << std::endl;
   #endif
   if(masterConfirmationAnnexTypeNode)
   {
      if(masterConfirmationAnnexTypeNode->Attribute("href") || masterConfirmationAnnexTypeNode->Attribute("id"))
      {
          if(masterConfirmationAnnexTypeNode->Attribute("id"))
          {
             masterConfirmationAnnexTypeIDRef_ = masterConfirmationAnnexTypeNode->Attribute("id");
             masterConfirmationAnnexType_ = boost::shared_ptr<MasterConfirmationAnnexType>(new MasterConfirmationAnnexType(masterConfirmationAnnexTypeNode));
             masterConfirmationAnnexType_->setID(masterConfirmationAnnexTypeIDRef_);
             IDManager::instance().setID(masterConfirmationAnnexTypeIDRef_,masterConfirmationAnnexType_);
          }
          else if(masterConfirmationAnnexTypeNode->Attribute("href")) { masterConfirmationAnnexTypeIDRef_ = masterConfirmationAnnexTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { masterConfirmationAnnexType_ = boost::shared_ptr<MasterConfirmationAnnexType>(new MasterConfirmationAnnexType(masterConfirmationAnnexTypeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MasterConfirmationType> MasterConfirmation::getMasterConfirmationType()
{
   if(!this->masterConfirmationTypeIsNull_){
        if(masterConfirmationTypeIDRef_ != ""){
             return boost::shared_static_cast<MasterConfirmationType>(IDManager::instance().getID(masterConfirmationTypeIDRef_));
        }else{
             return this->masterConfirmationType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MasterConfirmationType>();
   }
}
boost::shared_ptr<XsdTypeDate> MasterConfirmation::getMasterConfirmationDate()
{
   if(!this->masterConfirmationDateIsNull_){
        if(masterConfirmationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(masterConfirmationDateIDRef_));
        }else{
             return this->masterConfirmationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> MasterConfirmation::getMasterConfirmationAnnexDate()
{
   if(!this->masterConfirmationAnnexDateIsNull_){
        if(masterConfirmationAnnexDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(masterConfirmationAnnexDateIDRef_));
        }else{
             return this->masterConfirmationAnnexDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<MasterConfirmationAnnexType> MasterConfirmation::getMasterConfirmationAnnexType()
{
   if(!this->masterConfirmationAnnexTypeIsNull_){
        if(masterConfirmationAnnexTypeIDRef_ != ""){
             return boost::shared_static_cast<MasterConfirmationAnnexType>(IDManager::instance().getID(masterConfirmationAnnexTypeIDRef_));
        }else{
             return this->masterConfirmationAnnexType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MasterConfirmationAnnexType>();
   }
}
}

