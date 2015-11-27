// GenericAgreement.cpp 
#include "GenericAgreement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GenericAgreement::GenericAgreement(TiXmlNode* xmlNode)
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
             type_ = boost::shared_ptr<AgreementType>(new AgreementType(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<AgreementType>(new AgreementType(typeNode));}
   }

   //versionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* versionNode = xmlNode->FirstChildElement("version");

   if(versionNode){versionIsNull_ = false;}
   else{versionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- versionNode , address : " << versionNode << std::endl;
   #endif
   if(versionNode)
   {
      if(versionNode->Attribute("href") || versionNode->Attribute("id"))
      {
          if(versionNode->Attribute("id"))
          {
             versionIDRef_ = versionNode->Attribute("id");
             version_ = boost::shared_ptr<AgreementVersion>(new AgreementVersion(versionNode));
             version_->setID(versionIDRef_);
             IDManager::instance().setID(versionIDRef_,version_);
          }
          else if(versionNode->Attribute("href")) { versionIDRef_ = versionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { version_ = boost::shared_ptr<AgreementVersion>(new AgreementVersion(versionNode));}
   }

   //dateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateNode = xmlNode->FirstChildElement("date");

   if(dateNode){dateIsNull_ = false;}
   else{dateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateNode , address : " << dateNode << std::endl;
   #endif
   if(dateNode)
   {
      if(dateNode->Attribute("href") || dateNode->Attribute("id"))
      {
          if(dateNode->Attribute("id"))
          {
             dateIDRef_ = dateNode->Attribute("id");
             date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));
             date_->setID(dateIDRef_);
             IDManager::instance().setID(dateIDRef_,date_);
          }
          else if(dateNode->Attribute("href")) { dateIDRef_ = dateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { date_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(dateNode));}
   }

   //amendmentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amendmentDateNode = xmlNode->FirstChildElement("amendmentDate");

   if(amendmentDateNode){amendmentDateIsNull_ = false;}
   else{amendmentDateIsNull_ = true;}

   if(amendmentDateNode)
   {
      for(amendmentDateNode; amendmentDateNode; amendmentDateNode = amendmentDateNode->NextSiblingElement("amendmentDate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amendmentDateNode , address : " << amendmentDateNode << std::endl;
          #endif
          if(amendmentDateNode->Attribute("href") || amendmentDateNode->Attribute("id"))
          {
              if(amendmentDateNode->Attribute("id"))
              {
                  amendmentDateIDRef_ = amendmentDateNode->Attribute("id");
                  amendmentDate_.push_back(boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(amendmentDateNode)));
                  amendmentDate_.back()->setID(amendmentDateIDRef_);
                  IDManager::instance().setID(amendmentDateIDRef_, amendmentDate_.back());
              }
              else if(amendmentDateNode->Attribute("href")) { amendmentDateIDRef_ = amendmentDateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { amendmentDate_.push_back(boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(amendmentDateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amendmentDateNode , address : " << amendmentDateNode << std::endl;
       #endif
   }

   //governingLawNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* governingLawNode = xmlNode->FirstChildElement("governingLaw");

   if(governingLawNode){governingLawIsNull_ = false;}
   else{governingLawIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- governingLawNode , address : " << governingLawNode << std::endl;
   #endif
   if(governingLawNode)
   {
      if(governingLawNode->Attribute("href") || governingLawNode->Attribute("id"))
      {
          if(governingLawNode->Attribute("id"))
          {
             governingLawIDRef_ = governingLawNode->Attribute("id");
             governingLaw_ = boost::shared_ptr<GoverningLaw>(new GoverningLaw(governingLawNode));
             governingLaw_->setID(governingLawIDRef_);
             IDManager::instance().setID(governingLawIDRef_,governingLaw_);
          }
          else if(governingLawNode->Attribute("href")) { governingLawIDRef_ = governingLawNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { governingLaw_ = boost::shared_ptr<GoverningLaw>(new GoverningLaw(governingLawNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AgreementType> GenericAgreement::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<AgreementType>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AgreementType>();
   }
}
boost::shared_ptr<AgreementVersion> GenericAgreement::getVersion()
{
   if(!this->versionIsNull_){
        if(versionIDRef_ != ""){
             return boost::shared_static_cast<AgreementVersion>(IDManager::instance().getID(versionIDRef_));
        }else{
             return this->version_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AgreementVersion>();
   }
}
boost::shared_ptr<XsdTypeDate> GenericAgreement::getDate()
{
   if(!this->dateIsNull_){
        if(dateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(dateIDRef_));
        }else{
             return this->date_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
std::vector<boost::shared_ptr<XsdTypeDate>> GenericAgreement::getAmendmentDate()
{
   if(!this->amendmentDateIsNull_){
        if(amendmentDateIDRef_ != ""){
             return this->amendmentDate_;
        }else{
             return this->amendmentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeDate>>();
   }
}
boost::shared_ptr<GoverningLaw> GenericAgreement::getGoverningLaw()
{
   if(!this->governingLawIsNull_){
        if(governingLawIDRef_ != ""){
             return boost::shared_static_cast<GoverningLaw>(IDManager::instance().getID(governingLawIDRef_));
        }else{
             return this->governingLaw_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GoverningLaw>();
   }
}
}

