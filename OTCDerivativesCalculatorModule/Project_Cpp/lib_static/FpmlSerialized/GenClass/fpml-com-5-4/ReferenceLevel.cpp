// ReferenceLevel.cpp 
#include "ReferenceLevel.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceLevel::ReferenceLevel(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //amountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountNode = xmlNode->FirstChildElement("amount");

   if(amountNode){amountIsNull_ = false;}
   else{amountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountNode , address : " << amountNode << std::endl;
   #endif
   if(amountNode)
   {
      if(amountNode->Attribute("href") || amountNode->Attribute("id"))
      {
          if(amountNode->Attribute("id"))
          {
             amountIDRef_ = amountNode->Attribute("id");
             amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));
             amount_->setID(amountIDRef_);
             IDManager::instance().setID(amountIDRef_,amount_);
          }
          else if(amountNode->Attribute("href")) { amountIDRef_ = amountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(amountNode));}
   }

   //referenceLevelUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceLevelUnitNode = xmlNode->FirstChildElement("referenceLevelUnit");

   if(referenceLevelUnitNode){referenceLevelUnitIsNull_ = false;}
   else{referenceLevelUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceLevelUnitNode , address : " << referenceLevelUnitNode << std::endl;
   #endif
   if(referenceLevelUnitNode)
   {
      if(referenceLevelUnitNode->Attribute("href") || referenceLevelUnitNode->Attribute("id"))
      {
          if(referenceLevelUnitNode->Attribute("id"))
          {
             referenceLevelUnitIDRef_ = referenceLevelUnitNode->Attribute("id");
             referenceLevelUnit_ = boost::shared_ptr<ReferenceLevelUnit>(new ReferenceLevelUnit(referenceLevelUnitNode));
             referenceLevelUnit_->setID(referenceLevelUnitIDRef_);
             IDManager::instance().setID(referenceLevelUnitIDRef_,referenceLevelUnit_);
          }
          else if(referenceLevelUnitNode->Attribute("href")) { referenceLevelUnitIDRef_ = referenceLevelUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceLevelUnit_ = boost::shared_ptr<ReferenceLevelUnit>(new ReferenceLevelUnit(referenceLevelUnitNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> ReferenceLevel::getAmount()
{
   if(!this->amountIsNull_){
        if(amountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(amountIDRef_));
        }else{
             return this->amount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<ReferenceLevelUnit> ReferenceLevel::getReferenceLevelUnit()
{
   if(!this->referenceLevelUnitIsNull_){
        if(referenceLevelUnitIDRef_ != ""){
             return boost::shared_static_cast<ReferenceLevelUnit>(IDManager::instance().getID(referenceLevelUnitIDRef_));
        }else{
             return this->referenceLevelUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceLevelUnit>();
   }
}
}

