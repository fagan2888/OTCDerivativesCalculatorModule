// TradeTimestamp.cpp 
#include "TradeTimestamp.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeTimestamp::TradeTimestamp(TiXmlNode* xmlNode)
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
             type_ = boost::shared_ptr<TimestampTypeScheme>(new TimestampTypeScheme(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<TimestampTypeScheme>(new TimestampTypeScheme(typeNode));}
   }

   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
      if(valueNode->Attribute("href") || valueNode->Attribute("id"))
      {
          if(valueNode->Attribute("id"))
          {
             valueIDRef_ = valueNode->Attribute("id");
             value_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(valueNode));
             value_->setID(valueIDRef_);
             IDManager::instance().setID(valueIDRef_,value_);
          }
          else if(valueNode->Attribute("href")) { valueIDRef_ = valueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { value_ = boost::shared_ptr<XsdTypeDateTime>(new XsdTypeDateTime(valueNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TimestampTypeScheme> TradeTimestamp::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<TimestampTypeScheme>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimestampTypeScheme>();
   }
}
boost::shared_ptr<XsdTypeDateTime> TradeTimestamp::getValue()
{
   if(!this->valueIsNull_){
        if(valueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDateTime>(IDManager::instance().getID(valueIDRef_));
        }else{
             return this->value_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDateTime>();
   }
}
}

