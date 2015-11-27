// ContractualTermsSupplement.cpp 
#include "ContractualTermsSupplement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ContractualTermsSupplement::ContractualTermsSupplement(TiXmlNode* xmlNode)
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
             type_ = boost::shared_ptr<ContractualSupplement>(new ContractualSupplement(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<ContractualSupplement>(new ContractualSupplement(typeNode));}
   }

   //publicationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* publicationDateNode = xmlNode->FirstChildElement("publicationDate");

   if(publicationDateNode){publicationDateIsNull_ = false;}
   else{publicationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- publicationDateNode , address : " << publicationDateNode << std::endl;
   #endif
   if(publicationDateNode)
   {
      if(publicationDateNode->Attribute("href") || publicationDateNode->Attribute("id"))
      {
          if(publicationDateNode->Attribute("id"))
          {
             publicationDateIDRef_ = publicationDateNode->Attribute("id");
             publicationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(publicationDateNode));
             publicationDate_->setID(publicationDateIDRef_);
             IDManager::instance().setID(publicationDateIDRef_,publicationDate_);
          }
          else if(publicationDateNode->Attribute("href")) { publicationDateIDRef_ = publicationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { publicationDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(publicationDateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ContractualSupplement> ContractualTermsSupplement::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<ContractualSupplement>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ContractualSupplement>();
   }
}
boost::shared_ptr<XsdTypeDate> ContractualTermsSupplement::getPublicationDate()
{
   if(!this->publicationDateIsNull_){
        if(publicationDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(publicationDateIDRef_));
        }else{
             return this->publicationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
}

