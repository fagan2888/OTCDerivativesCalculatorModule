// EventFunctionM.cpp 
#include "EventFunctionM.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EventFunctionM::EventFunctionM(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));}
   }

   //indexSymbolNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexSymbolNode = xmlNode->FirstChildElement("indexSymbol");

   if(indexSymbolNode){indexSymbolIsNull_ = false;}
   else{indexSymbolIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexSymbolNode , address : " << indexSymbolNode << std::endl;
   #endif
   if(indexSymbolNode)
   {
      if(indexSymbolNode->Attribute("href") || indexSymbolNode->Attribute("id"))
      {
          if(indexSymbolNode->Attribute("id"))
          {
             indexSymbolIDRef_ = indexSymbolNode->Attribute("id");
             indexSymbol_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(indexSymbolNode));
             indexSymbol_->setID(indexSymbolIDRef_);
             IDManager::instance().setID(indexSymbolIDRef_,indexSymbol_);
          }
          else if(indexSymbolNode->Attribute("href")) { indexSymbolIDRef_ = indexSymbolNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexSymbol_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(indexSymbolNode));}
   }

   //upEventCheckNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upEventCheckNode = xmlNode->FirstChildElement("upEventCheck");

   if(upEventCheckNode){upEventCheckIsNull_ = false;}
   else{upEventCheckIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upEventCheckNode , address : " << upEventCheckNode << std::endl;
   #endif
   if(upEventCheckNode)
   {
      if(upEventCheckNode->Attribute("href") || upEventCheckNode->Attribute("id"))
      {
          if(upEventCheckNode->Attribute("id"))
          {
             upEventCheckIDRef_ = upEventCheckNode->Attribute("id");
             upEventCheck_ = boost::shared_ptr<UpEventCheck>(new UpEventCheck(upEventCheckNode));
             upEventCheck_->setID(upEventCheckIDRef_);
             IDManager::instance().setID(upEventCheckIDRef_,upEventCheck_);
          }
          else if(upEventCheckNode->Attribute("href")) { upEventCheckIDRef_ = upEventCheckNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { upEventCheck_ = boost::shared_ptr<UpEventCheck>(new UpEventCheck(upEventCheckNode));}
   }

   //downEventCheckNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* downEventCheckNode = xmlNode->FirstChildElement("downEventCheck");

   if(downEventCheckNode){downEventCheckIsNull_ = false;}
   else{downEventCheckIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- downEventCheckNode , address : " << downEventCheckNode << std::endl;
   #endif
   if(downEventCheckNode)
   {
      if(downEventCheckNode->Attribute("href") || downEventCheckNode->Attribute("id"))
      {
          if(downEventCheckNode->Attribute("id"))
          {
             downEventCheckIDRef_ = downEventCheckNode->Attribute("id");
             downEventCheck_ = boost::shared_ptr<DownEventCheck>(new DownEventCheck(downEventCheckNode));
             downEventCheck_->setID(downEventCheckIDRef_);
             IDManager::instance().setID(downEventCheckIDRef_,downEventCheck_);
          }
          else if(downEventCheckNode->Attribute("href")) { downEventCheckIDRef_ = downEventCheckNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { downEventCheck_ = boost::shared_ptr<DownEventCheck>(new DownEventCheck(downEventCheckNode));}
   }

   //updownEventCheckNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* updownEventCheckNode = xmlNode->FirstChildElement("updownEventCheck");

   if(updownEventCheckNode){updownEventCheckIsNull_ = false;}
   else{updownEventCheckIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- updownEventCheckNode , address : " << updownEventCheckNode << std::endl;
   #endif
   if(updownEventCheckNode)
   {
      if(updownEventCheckNode->Attribute("href") || updownEventCheckNode->Attribute("id"))
      {
          if(updownEventCheckNode->Attribute("id"))
          {
             updownEventCheckIDRef_ = updownEventCheckNode->Attribute("id");
             updownEventCheck_ = boost::shared_ptr<UpDownEventCheck>(new UpDownEventCheck(updownEventCheckNode));
             updownEventCheck_->setID(updownEventCheckIDRef_);
             IDManager::instance().setID(updownEventCheckIDRef_,updownEventCheck_);
          }
          else if(updownEventCheckNode->Attribute("href")) { updownEventCheckIDRef_ = updownEventCheckNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { updownEventCheck_ = boost::shared_ptr<UpDownEventCheck>(new UpDownEventCheck(updownEventCheckNode));}
   }

   //rangeEventCheckNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rangeEventCheckNode = xmlNode->FirstChildElement("rangeEventCheck");

   if(rangeEventCheckNode){rangeEventCheckIsNull_ = false;}
   else{rangeEventCheckIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rangeEventCheckNode , address : " << rangeEventCheckNode << std::endl;
   #endif
   if(rangeEventCheckNode)
   {
      if(rangeEventCheckNode->Attribute("href") || rangeEventCheckNode->Attribute("id"))
      {
          if(rangeEventCheckNode->Attribute("id"))
          {
             rangeEventCheckIDRef_ = rangeEventCheckNode->Attribute("id");
             rangeEventCheck_ = boost::shared_ptr<RangeEventCheck>(new RangeEventCheck(rangeEventCheckNode));
             rangeEventCheck_->setID(rangeEventCheckIDRef_);
             IDManager::instance().setID(rangeEventCheckIDRef_,rangeEventCheck_);
          }
          else if(rangeEventCheckNode->Attribute("href")) { rangeEventCheckIDRef_ = rangeEventCheckNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rangeEventCheck_ = boost::shared_ptr<RangeEventCheck>(new RangeEventCheck(rangeEventCheckNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> EventFunctionM::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> EventFunctionM::getIndexSymbol()
{
   if(!this->indexSymbolIsNull_){
        if(indexSymbolIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(indexSymbolIDRef_));
        }else{
             return this->indexSymbol_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<UpEventCheck> EventFunctionM::getUpEventCheck()
{
   if(!this->upEventCheckIsNull_){
        if(upEventCheckIDRef_ != ""){
             return boost::shared_static_cast<UpEventCheck>(IDManager::instance().getID(upEventCheckIDRef_));
        }else{
             return this->upEventCheck_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UpEventCheck>();
   }
}
boost::shared_ptr<DownEventCheck> EventFunctionM::getDownEventCheck()
{
   if(!this->downEventCheckIsNull_){
        if(downEventCheckIDRef_ != ""){
             return boost::shared_static_cast<DownEventCheck>(IDManager::instance().getID(downEventCheckIDRef_));
        }else{
             return this->downEventCheck_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DownEventCheck>();
   }
}
boost::shared_ptr<UpDownEventCheck> EventFunctionM::getUpdownEventCheck()
{
   if(!this->updownEventCheckIsNull_){
        if(updownEventCheckIDRef_ != ""){
             return boost::shared_static_cast<UpDownEventCheck>(IDManager::instance().getID(updownEventCheckIDRef_));
        }else{
             return this->updownEventCheck_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UpDownEventCheck>();
   }
}
boost::shared_ptr<RangeEventCheck> EventFunctionM::getRangeEventCheck()
{
   if(!this->rangeEventCheckIsNull_){
        if(rangeEventCheckIDRef_ != ""){
             return boost::shared_static_cast<RangeEventCheck>(IDManager::instance().getID(rangeEventCheckIDRef_));
        }else{
             return this->rangeEventCheck_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RangeEventCheck>();
   }
}
}

