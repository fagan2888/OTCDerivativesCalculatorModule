// ParametorCalculation.cpp 
#include "ParametorCalculation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ParametorCalculation::ParametorCalculation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //dateRefNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateRefNode = xmlNode->FirstChildElement("dateRef");

   if(dateRefNode){dateRefIsNull_ = false;}
   else{dateRefIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateRefNode , address : " << dateRefNode << std::endl;
   #endif
   if(dateRefNode)
   {
      if(dateRefNode->Attribute("href") || dateRefNode->Attribute("id"))
      {
          if(dateRefNode->Attribute("id"))
          {
             dateRefIDRef_ = dateRefNode->Attribute("id");
             dateRef_ = boost::shared_ptr<DateRef>(new DateRef(dateRefNode));
             dateRef_->setID(dateRefIDRef_);
             IDManager::instance().setID(dateRefIDRef_,dateRef_);
          }
          else if(dateRefNode->Attribute("href")) { dateRefIDRef_ = dateRefNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateRef_ = boost::shared_ptr<DateRef>(new DateRef(dateRefNode));}
   }

   //symbolNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* symbolNameNode = xmlNode->FirstChildElement("symbolName");

   if(symbolNameNode){symbolNameIsNull_ = false;}
   else{symbolNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- symbolNameNode , address : " << symbolNameNode << std::endl;
   #endif
   if(symbolNameNode)
   {
      if(symbolNameNode->Attribute("href") || symbolNameNode->Attribute("id"))
      {
          if(symbolNameNode->Attribute("id"))
          {
             symbolNameIDRef_ = symbolNameNode->Attribute("id");
             symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));
             symbolName_->setID(symbolNameIDRef_);
             IDManager::instance().setID(symbolNameIDRef_,symbolName_);
          }
          else if(symbolNameNode->Attribute("href")) { symbolNameIDRef_ = symbolNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));}
   }

   //constValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constValueNode = xmlNode->FirstChildElement("constValue");

   if(constValueNode){constValueIsNull_ = false;}
   else{constValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constValueNode , address : " << constValueNode << std::endl;
   #endif
   if(constValueNode)
   {
      if(constValueNode->Attribute("href") || constValueNode->Attribute("id"))
      {
          if(constValueNode->Attribute("id"))
          {
             constValueIDRef_ = constValueNode->Attribute("id");
             constValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(constValueNode));
             constValue_->setID(constValueIDRef_);
             IDManager::instance().setID(constValueIDRef_,constValue_);
          }
          else if(constValueNode->Attribute("href")) { constValueIDRef_ = constValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { constValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(constValueNode));}
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
             date_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dateNode));
             date_->setID(dateIDRef_);
             IDManager::instance().setID(dateIDRef_,date_);
          }
          else if(dateNode->Attribute("href")) { dateIDRef_ = dateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { date_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dateNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DateRef> ParametorCalculation::getDateRef()
{
   if(!this->dateRefIsNull_){
        if(dateRefIDRef_ != ""){
             return boost::shared_static_cast<DateRef>(IDManager::instance().getID(dateRefIDRef_));
        }else{
             return this->dateRef_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateRef>();
   }
}
boost::shared_ptr<XsdTypeToken> ParametorCalculation::getSymbolName()
{
   if(!this->symbolNameIsNull_){
        if(symbolNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(symbolNameIDRef_));
        }else{
             return this->symbolName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeDouble> ParametorCalculation::getConstValue()
{
   if(!this->constValueIsNull_){
        if(constValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDouble>(IDManager::instance().getID(constValueIDRef_));
        }else{
             return this->constValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeToken> ParametorCalculation::getDate()
{
   if(!this->dateIsNull_){
        if(dateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(dateIDRef_));
        }else{
             return this->date_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

