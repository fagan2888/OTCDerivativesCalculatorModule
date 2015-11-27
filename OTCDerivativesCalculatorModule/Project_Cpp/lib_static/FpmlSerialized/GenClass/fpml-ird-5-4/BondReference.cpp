// BondReference.cpp 
#include "BondReference.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BondReference::BondReference(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //bondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bondNode = xmlNode->FirstChildElement("bond");

   if(bondNode){bondIsNull_ = false;}
   else{bondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bondNode , address : " << bondNode << std::endl;
   #endif
   if(bondNode)
   {
      if(bondNode->Attribute("href") || bondNode->Attribute("id"))
      {
          if(bondNode->Attribute("id"))
          {
             bondIDRef_ = bondNode->Attribute("id");
             bond_ = boost::shared_ptr<Bond>(new Bond(bondNode));
             bond_->setID(bondIDRef_);
             IDManager::instance().setID(bondIDRef_,bond_);
          }
          else if(bondNode->Attribute("href")) { bondIDRef_ = bondNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bond_ = boost::shared_ptr<Bond>(new Bond(bondNode));}
   }

   //conditionPrecedentBondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* conditionPrecedentBondNode = xmlNode->FirstChildElement("conditionPrecedentBond");

   if(conditionPrecedentBondNode){conditionPrecedentBondIsNull_ = false;}
   else{conditionPrecedentBondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- conditionPrecedentBondNode , address : " << conditionPrecedentBondNode << std::endl;
   #endif
   if(conditionPrecedentBondNode)
   {
      if(conditionPrecedentBondNode->Attribute("href") || conditionPrecedentBondNode->Attribute("id"))
      {
          if(conditionPrecedentBondNode->Attribute("id"))
          {
             conditionPrecedentBondIDRef_ = conditionPrecedentBondNode->Attribute("id");
             conditionPrecedentBond_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(conditionPrecedentBondNode));
             conditionPrecedentBond_->setID(conditionPrecedentBondIDRef_);
             IDManager::instance().setID(conditionPrecedentBondIDRef_,conditionPrecedentBond_);
          }
          else if(conditionPrecedentBondNode->Attribute("href")) { conditionPrecedentBondIDRef_ = conditionPrecedentBondNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { conditionPrecedentBond_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(conditionPrecedentBondNode));}
   }

   //discrepancyClauseNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* discrepancyClauseNode = xmlNode->FirstChildElement("discrepancyClause");

   if(discrepancyClauseNode){discrepancyClauseIsNull_ = false;}
   else{discrepancyClauseIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- discrepancyClauseNode , address : " << discrepancyClauseNode << std::endl;
   #endif
   if(discrepancyClauseNode)
   {
      if(discrepancyClauseNode->Attribute("href") || discrepancyClauseNode->Attribute("id"))
      {
          if(discrepancyClauseNode->Attribute("id"))
          {
             discrepancyClauseIDRef_ = discrepancyClauseNode->Attribute("id");
             discrepancyClause_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(discrepancyClauseNode));
             discrepancyClause_->setID(discrepancyClauseIDRef_);
             IDManager::instance().setID(discrepancyClauseIDRef_,discrepancyClause_);
          }
          else if(discrepancyClauseNode->Attribute("href")) { discrepancyClauseIDRef_ = discrepancyClauseNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { discrepancyClause_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(discrepancyClauseNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Bond> BondReference::getBond()
{
   if(!this->bondIsNull_){
        if(bondIDRef_ != ""){
             return boost::shared_static_cast<Bond>(IDManager::instance().getID(bondIDRef_));
        }else{
             return this->bond_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Bond>();
   }
}
boost::shared_ptr<XsdTypeBoolean> BondReference::getConditionPrecedentBond()
{
   if(!this->conditionPrecedentBondIsNull_){
        if(conditionPrecedentBondIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(conditionPrecedentBondIDRef_));
        }else{
             return this->conditionPrecedentBond_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> BondReference::getDiscrepancyClause()
{
   if(!this->discrepancyClauseIsNull_){
        if(discrepancyClauseIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(discrepancyClauseIDRef_));
        }else{
             return this->discrepancyClause_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

