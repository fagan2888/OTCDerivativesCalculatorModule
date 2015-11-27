// TelephoneNumber.cpp 
#include "TelephoneNumber.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TelephoneNumber::TelephoneNumber(TiXmlNode* xmlNode)
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
             type_ = boost::shared_ptr<TelephoneTypeEnum>(new TelephoneTypeEnum(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<TelephoneTypeEnum>(new TelephoneTypeEnum(typeNode));}
   }

   //numberNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberNode = xmlNode->FirstChildElement("number");

   if(numberNode){numberIsNull_ = false;}
   else{numberIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberNode , address : " << numberNode << std::endl;
   #endif
   if(numberNode)
   {
      if(numberNode->Attribute("href") || numberNode->Attribute("id"))
      {
          if(numberNode->Attribute("id"))
          {
             numberIDRef_ = numberNode->Attribute("id");
             number_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(numberNode));
             number_->setID(numberIDRef_);
             IDManager::instance().setID(numberIDRef_,number_);
          }
          else if(numberNode->Attribute("href")) { numberIDRef_ = numberNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { number_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(numberNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TelephoneTypeEnum> TelephoneNumber::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<TelephoneTypeEnum>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TelephoneTypeEnum>();
   }
}
boost::shared_ptr<XsdTypeString> TelephoneNumber::getNumber()
{
   if(!this->numberIsNull_){
        if(numberIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(numberIDRef_));
        }else{
             return this->number_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

