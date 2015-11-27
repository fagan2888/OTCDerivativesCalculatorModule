// TermPoint.cpp 
#include "TermPoint.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TermPoint::TermPoint(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //termNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* termNode = xmlNode->FirstChildElement("term");

   if(termNode){termIsNull_ = false;}
   else{termIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- termNode , address : " << termNode << std::endl;
   #endif
   if(termNode)
   {
      if(termNode->Attribute("href") || termNode->Attribute("id"))
      {
          if(termNode->Attribute("id"))
          {
             termIDRef_ = termNode->Attribute("id");
             term_ = boost::shared_ptr<TimeDimension>(new TimeDimension(termNode));
             term_->setID(termIDRef_);
             IDManager::instance().setID(termIDRef_,term_);
          }
          else if(termNode->Attribute("href")) { termIDRef_ = termNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { term_ = boost::shared_ptr<TimeDimension>(new TimeDimension(termNode));}
   }

   //bidNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bidNode = xmlNode->FirstChildElement("bid");

   if(bidNode){bidIsNull_ = false;}
   else{bidIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bidNode , address : " << bidNode << std::endl;
   #endif
   if(bidNode)
   {
      if(bidNode->Attribute("href") || bidNode->Attribute("id"))
      {
          if(bidNode->Attribute("id"))
          {
             bidIDRef_ = bidNode->Attribute("id");
             bid_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(bidNode));
             bid_->setID(bidIDRef_);
             IDManager::instance().setID(bidIDRef_,bid_);
          }
          else if(bidNode->Attribute("href")) { bidIDRef_ = bidNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bid_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(bidNode));}
   }

   //midNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* midNode = xmlNode->FirstChildElement("mid");

   if(midNode){midIsNull_ = false;}
   else{midIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- midNode , address : " << midNode << std::endl;
   #endif
   if(midNode)
   {
      if(midNode->Attribute("href") || midNode->Attribute("id"))
      {
          if(midNode->Attribute("id"))
          {
             midIDRef_ = midNode->Attribute("id");
             mid_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(midNode));
             mid_->setID(midIDRef_);
             IDManager::instance().setID(midIDRef_,mid_);
          }
          else if(midNode->Attribute("href")) { midIDRef_ = midNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mid_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(midNode));}
   }

   //askNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* askNode = xmlNode->FirstChildElement("ask");

   if(askNode){askIsNull_ = false;}
   else{askIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- askNode , address : " << askNode << std::endl;
   #endif
   if(askNode)
   {
      if(askNode->Attribute("href") || askNode->Attribute("id"))
      {
          if(askNode->Attribute("id"))
          {
             askIDRef_ = askNode->Attribute("id");
             ask_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(askNode));
             ask_->setID(askIDRef_);
             IDManager::instance().setID(askIDRef_,ask_);
          }
          else if(askNode->Attribute("href")) { askIDRef_ = askNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { ask_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(askNode));}
   }

   //spreadValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spreadValueNode = xmlNode->FirstChildElement("spreadValue");

   if(spreadValueNode){spreadValueIsNull_ = false;}
   else{spreadValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spreadValueNode , address : " << spreadValueNode << std::endl;
   #endif
   if(spreadValueNode)
   {
      if(spreadValueNode->Attribute("href") || spreadValueNode->Attribute("id"))
      {
          if(spreadValueNode->Attribute("id"))
          {
             spreadValueIDRef_ = spreadValueNode->Attribute("id");
             spreadValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadValueNode));
             spreadValue_->setID(spreadValueIDRef_);
             IDManager::instance().setID(spreadValueIDRef_,spreadValue_);
          }
          else if(spreadValueNode->Attribute("href")) { spreadValueIDRef_ = spreadValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spreadValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(spreadValueNode));}
   }

   //definitionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* definitionNode = xmlNode->FirstChildElement("definition");

   if(definitionNode){definitionIsNull_ = false;}
   else{definitionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- definitionNode , address : " << definitionNode << std::endl;
   #endif
   if(definitionNode)
   {
      if(definitionNode->Attribute("href") || definitionNode->Attribute("id"))
      {
          if(definitionNode->Attribute("id"))
          {
             definitionIDRef_ = definitionNode->Attribute("id");
             definition_ = boost::shared_ptr<AssetReference>(new AssetReference(definitionNode));
             definition_->setID(definitionIDRef_);
             IDManager::instance().setID(definitionIDRef_,definition_);
          }
          else if(definitionNode->Attribute("href")) { definitionIDRef_ = definitionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { definition_ = boost::shared_ptr<AssetReference>(new AssetReference(definitionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TimeDimension> TermPoint::getTerm()
{
   if(!this->termIsNull_){
        if(termIDRef_ != ""){
             return boost::shared_static_cast<TimeDimension>(IDManager::instance().getID(termIDRef_));
        }else{
             return this->term_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeDimension>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TermPoint::getBid()
{
   if(!this->bidIsNull_){
        if(bidIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(bidIDRef_));
        }else{
             return this->bid_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TermPoint::getMid()
{
   if(!this->midIsNull_){
        if(midIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(midIDRef_));
        }else{
             return this->mid_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TermPoint::getAsk()
{
   if(!this->askIsNull_){
        if(askIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(askIDRef_));
        }else{
             return this->ask_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> TermPoint::getSpreadValue()
{
   if(!this->spreadValueIsNull_){
        if(spreadValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(spreadValueIDRef_));
        }else{
             return this->spreadValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<AssetReference> TermPoint::getDefinition()
{
   if(!this->definitionIsNull_){
        if(definitionIDRef_ != ""){
             return boost::shared_static_cast<AssetReference>(IDManager::instance().getID(definitionIDRef_));
        }else{
             return this->definition_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetReference>();
   }
}
}

