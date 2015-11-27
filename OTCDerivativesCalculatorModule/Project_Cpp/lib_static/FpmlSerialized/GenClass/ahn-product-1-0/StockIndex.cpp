// StockIndex.cpp 
#include "StockIndex.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StockIndex::StockIndex(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //codeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* codeNode = xmlNode->FirstChildElement("code");

   if(codeNode){codeIsNull_ = false;}
   else{codeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- codeNode , address : " << codeNode << std::endl;
   #endif
   if(codeNode)
   {
      if(codeNode->Attribute("href") || codeNode->Attribute("id"))
      {
          if(codeNode->Attribute("id"))
          {
             codeIDRef_ = codeNode->Attribute("id");
             code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(codeNode));
             code_->setID(codeIDRef_);
             IDManager::instance().setID(codeIDRef_,code_);
          }
          else if(codeNode->Attribute("href")) { codeIDRef_ = codeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(codeNode));}
   }

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

   //indexTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTypeNode = xmlNode->FirstChildElement("indexType");

   if(indexTypeNode){indexTypeIsNull_ = false;}
   else{indexTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTypeNode , address : " << indexTypeNode << std::endl;
   #endif
   if(indexTypeNode)
   {
      if(indexTypeNode->Attribute("href") || indexTypeNode->Attribute("id"))
      {
          if(indexTypeNode->Attribute("id"))
          {
             indexTypeIDRef_ = indexTypeNode->Attribute("id");
             indexType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(indexTypeNode));
             indexType_->setID(indexTypeIDRef_);
             IDManager::instance().setID(indexTypeIDRef_,indexType_);
          }
          else if(indexTypeNode->Attribute("href")) { indexTypeIDRef_ = indexTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(indexTypeNode));}
   }

   //businessDayConventionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessDayConventionNode = xmlNode->FirstChildElement("businessDayConvention");

   if(businessDayConventionNode){businessDayConventionIsNull_ = false;}
   else{businessDayConventionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessDayConventionNode , address : " << businessDayConventionNode << std::endl;
   #endif
   if(businessDayConventionNode)
   {
      if(businessDayConventionNode->Attribute("href") || businessDayConventionNode->Attribute("id"))
      {
          if(businessDayConventionNode->Attribute("id"))
          {
             businessDayConventionIDRef_ = businessDayConventionNode->Attribute("id");
             businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));
             businessDayConvention_->setID(businessDayConventionIDRef_);
             IDManager::instance().setID(businessDayConventionIDRef_,businessDayConvention_);
          }
          else if(businessDayConventionNode->Attribute("href")) { businessDayConventionIDRef_ = businessDayConventionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessDayConvention_ = boost::shared_ptr<BusinessDayConventionEnum>(new BusinessDayConventionEnum(businessDayConventionNode));}
   }

   //endOfMonthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* endOfMonthNode = xmlNode->FirstChildElement("endOfMonth");

   if(endOfMonthNode){endOfMonthIsNull_ = false;}
   else{endOfMonthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- endOfMonthNode , address : " << endOfMonthNode << std::endl;
   #endif
   if(endOfMonthNode)
   {
      if(endOfMonthNode->Attribute("href") || endOfMonthNode->Attribute("id"))
      {
          if(endOfMonthNode->Attribute("id"))
          {
             endOfMonthIDRef_ = endOfMonthNode->Attribute("id");
             endOfMonth_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(endOfMonthNode));
             endOfMonth_->setID(endOfMonthIDRef_);
             IDManager::instance().setID(endOfMonthIDRef_,endOfMonth_);
          }
          else if(endOfMonthNode->Attribute("href")) { endOfMonthIDRef_ = endOfMonthNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { endOfMonth_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(endOfMonthNode));}
   }

   //dayCounterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCounterNode = xmlNode->FirstChildElement("dayCounter");

   if(dayCounterNode){dayCounterIsNull_ = false;}
   else{dayCounterIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCounterNode , address : " << dayCounterNode << std::endl;
   #endif
   if(dayCounterNode)
   {
      if(dayCounterNode->Attribute("href") || dayCounterNode->Attribute("id"))
      {
          if(dayCounterNode->Attribute("id"))
          {
             dayCounterIDRef_ = dayCounterNode->Attribute("id");
             dayCounter_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dayCounterNode));
             dayCounter_->setID(dayCounterIDRef_);
             IDManager::instance().setID(dayCounterIDRef_,dayCounter_);
          }
          else if(dayCounterNode->Attribute("href")) { dayCounterIDRef_ = dayCounterNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCounter_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(dayCounterNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> StockIndex::getCode()
{
   if(!this->codeIsNull_){
        if(codeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(codeIDRef_));
        }else{
             return this->code_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> StockIndex::getName()
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
boost::shared_ptr<XsdTypeToken> StockIndex::getIndexType()
{
   if(!this->indexTypeIsNull_){
        if(indexTypeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(indexTypeIDRef_));
        }else{
             return this->indexType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<BusinessDayConventionEnum> StockIndex::getBusinessDayConvention()
{
   if(!this->businessDayConventionIsNull_){
        if(businessDayConventionIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayConventionEnum>(IDManager::instance().getID(businessDayConventionIDRef_));
        }else{
             return this->businessDayConvention_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayConventionEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> StockIndex::getEndOfMonth()
{
   if(!this->endOfMonthIsNull_){
        if(endOfMonthIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(endOfMonthIDRef_));
        }else{
             return this->endOfMonth_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeToken> StockIndex::getDayCounter()
{
   if(!this->dayCounterIsNull_){
        if(dayCounterIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(dayCounterIDRef_));
        }else{
             return this->dayCounter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

