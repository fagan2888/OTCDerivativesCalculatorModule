// IndexChange.cpp 
#include "IndexChange.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IndexChange::IndexChange(TiXmlNode* xmlNode)
: ChangeEvent(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //indexFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexFactorNode = xmlNode->FirstChildElement("indexFactor");

   if(indexFactorNode){indexFactorIsNull_ = false;}
   else{indexFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexFactorNode , address : " << indexFactorNode << std::endl;
   #endif
   if(indexFactorNode)
   {
      if(indexFactorNode->Attribute("href") || indexFactorNode->Attribute("id"))
      {
          if(indexFactorNode->Attribute("id"))
          {
             indexFactorIDRef_ = indexFactorNode->Attribute("id");
             indexFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(indexFactorNode));
             indexFactor_->setID(indexFactorIDRef_);
             IDManager::instance().setID(indexFactorIDRef_,indexFactor_);
          }
          else if(indexFactorNode->Attribute("href")) { indexFactorIDRef_ = indexFactorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexFactor_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(indexFactorNode));}
   }

   //factoredCalculationAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* factoredCalculationAmountNode = xmlNode->FirstChildElement("factoredCalculationAmount");

   if(factoredCalculationAmountNode){factoredCalculationAmountIsNull_ = false;}
   else{factoredCalculationAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- factoredCalculationAmountNode , address : " << factoredCalculationAmountNode << std::endl;
   #endif
   if(factoredCalculationAmountNode)
   {
      if(factoredCalculationAmountNode->Attribute("href") || factoredCalculationAmountNode->Attribute("id"))
      {
          if(factoredCalculationAmountNode->Attribute("id"))
          {
             factoredCalculationAmountIDRef_ = factoredCalculationAmountNode->Attribute("id");
             factoredCalculationAmount_ = boost::shared_ptr<Money>(new Money(factoredCalculationAmountNode));
             factoredCalculationAmount_->setID(factoredCalculationAmountIDRef_);
             IDManager::instance().setID(factoredCalculationAmountIDRef_,factoredCalculationAmount_);
          }
          else if(factoredCalculationAmountNode->Attribute("href")) { factoredCalculationAmountIDRef_ = factoredCalculationAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { factoredCalculationAmount_ = boost::shared_ptr<Money>(new Money(factoredCalculationAmountNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> IndexChange::getIndexFactor()
{
   if(!this->indexFactorIsNull_){
        if(indexFactorIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(indexFactorIDRef_));
        }else{
             return this->indexFactor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Money> IndexChange::getFactoredCalculationAmount()
{
   if(!this->factoredCalculationAmountIsNull_){
        if(factoredCalculationAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(factoredCalculationAmountIDRef_));
        }else{
             return this->factoredCalculationAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
}

