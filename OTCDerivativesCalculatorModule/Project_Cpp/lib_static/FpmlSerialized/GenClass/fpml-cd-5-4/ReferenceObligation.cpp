// ReferenceObligation.cpp 
#include "ReferenceObligation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceObligation::ReferenceObligation(TiXmlNode* xmlNode)
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

   //convertibleBondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* convertibleBondNode = xmlNode->FirstChildElement("convertibleBond");

   if(convertibleBondNode){convertibleBondIsNull_ = false;}
   else{convertibleBondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- convertibleBondNode , address : " << convertibleBondNode << std::endl;
   #endif
   if(convertibleBondNode)
   {
      if(convertibleBondNode->Attribute("href") || convertibleBondNode->Attribute("id"))
      {
          if(convertibleBondNode->Attribute("id"))
          {
             convertibleBondIDRef_ = convertibleBondNode->Attribute("id");
             convertibleBond_ = boost::shared_ptr<ConvertibleBond>(new ConvertibleBond(convertibleBondNode));
             convertibleBond_->setID(convertibleBondIDRef_);
             IDManager::instance().setID(convertibleBondIDRef_,convertibleBond_);
          }
          else if(convertibleBondNode->Attribute("href")) { convertibleBondIDRef_ = convertibleBondNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { convertibleBond_ = boost::shared_ptr<ConvertibleBond>(new ConvertibleBond(convertibleBondNode));}
   }

   //mortgageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mortgageNode = xmlNode->FirstChildElement("mortgage");

   if(mortgageNode){mortgageIsNull_ = false;}
   else{mortgageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mortgageNode , address : " << mortgageNode << std::endl;
   #endif
   if(mortgageNode)
   {
      if(mortgageNode->Attribute("href") || mortgageNode->Attribute("id"))
      {
          if(mortgageNode->Attribute("id"))
          {
             mortgageIDRef_ = mortgageNode->Attribute("id");
             mortgage_ = boost::shared_ptr<Mortgage>(new Mortgage(mortgageNode));
             mortgage_->setID(mortgageIDRef_);
             IDManager::instance().setID(mortgageIDRef_,mortgage_);
          }
          else if(mortgageNode->Attribute("href")) { mortgageIDRef_ = mortgageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mortgage_ = boost::shared_ptr<Mortgage>(new Mortgage(mortgageNode));}
   }

   //loanNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* loanNode = xmlNode->FirstChildElement("loan");

   if(loanNode){loanIsNull_ = false;}
   else{loanIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- loanNode , address : " << loanNode << std::endl;
   #endif
   if(loanNode)
   {
      if(loanNode->Attribute("href") || loanNode->Attribute("id"))
      {
          if(loanNode->Attribute("id"))
          {
             loanIDRef_ = loanNode->Attribute("id");
             loan_ = boost::shared_ptr<Loan>(new Loan(loanNode));
             loan_->setID(loanIDRef_);
             IDManager::instance().setID(loanIDRef_,loan_);
          }
          else if(loanNode->Attribute("href")) { loanIDRef_ = loanNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { loan_ = boost::shared_ptr<Loan>(new Loan(loanNode));}
   }

   //primaryObligorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* primaryObligorNode = xmlNode->FirstChildElement("primaryObligor");

   if(primaryObligorNode){primaryObligorIsNull_ = false;}
   else{primaryObligorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- primaryObligorNode , address : " << primaryObligorNode << std::endl;
   #endif
   if(primaryObligorNode)
   {
      if(primaryObligorNode->Attribute("href") || primaryObligorNode->Attribute("id"))
      {
          if(primaryObligorNode->Attribute("id"))
          {
             primaryObligorIDRef_ = primaryObligorNode->Attribute("id");
             primaryObligor_ = boost::shared_ptr<LegalEntity>(new LegalEntity(primaryObligorNode));
             primaryObligor_->setID(primaryObligorIDRef_);
             IDManager::instance().setID(primaryObligorIDRef_,primaryObligor_);
          }
          else if(primaryObligorNode->Attribute("href")) { primaryObligorIDRef_ = primaryObligorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { primaryObligor_ = boost::shared_ptr<LegalEntity>(new LegalEntity(primaryObligorNode));}
   }

   //primaryObligorReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* primaryObligorReferenceNode = xmlNode->FirstChildElement("primaryObligorReference");

   if(primaryObligorReferenceNode){primaryObligorReferenceIsNull_ = false;}
   else{primaryObligorReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- primaryObligorReferenceNode , address : " << primaryObligorReferenceNode << std::endl;
   #endif
   if(primaryObligorReferenceNode)
   {
      if(primaryObligorReferenceNode->Attribute("href") || primaryObligorReferenceNode->Attribute("id"))
      {
          if(primaryObligorReferenceNode->Attribute("id"))
          {
             primaryObligorReferenceIDRef_ = primaryObligorReferenceNode->Attribute("id");
             primaryObligorReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(primaryObligorReferenceNode));
             primaryObligorReference_->setID(primaryObligorReferenceIDRef_);
             IDManager::instance().setID(primaryObligorReferenceIDRef_,primaryObligorReference_);
          }
          else if(primaryObligorReferenceNode->Attribute("href")) { primaryObligorReferenceIDRef_ = primaryObligorReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { primaryObligorReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(primaryObligorReferenceNode));}
   }

   //guarantorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* guarantorNode = xmlNode->FirstChildElement("guarantor");

   if(guarantorNode){guarantorIsNull_ = false;}
   else{guarantorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- guarantorNode , address : " << guarantorNode << std::endl;
   #endif
   if(guarantorNode)
   {
      if(guarantorNode->Attribute("href") || guarantorNode->Attribute("id"))
      {
          if(guarantorNode->Attribute("id"))
          {
             guarantorIDRef_ = guarantorNode->Attribute("id");
             guarantor_ = boost::shared_ptr<LegalEntity>(new LegalEntity(guarantorNode));
             guarantor_->setID(guarantorIDRef_);
             IDManager::instance().setID(guarantorIDRef_,guarantor_);
          }
          else if(guarantorNode->Attribute("href")) { guarantorIDRef_ = guarantorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { guarantor_ = boost::shared_ptr<LegalEntity>(new LegalEntity(guarantorNode));}
   }

   //guarantorReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* guarantorReferenceNode = xmlNode->FirstChildElement("guarantorReference");

   if(guarantorReferenceNode){guarantorReferenceIsNull_ = false;}
   else{guarantorReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- guarantorReferenceNode , address : " << guarantorReferenceNode << std::endl;
   #endif
   if(guarantorReferenceNode)
   {
      if(guarantorReferenceNode->Attribute("href") || guarantorReferenceNode->Attribute("id"))
      {
          if(guarantorReferenceNode->Attribute("id"))
          {
             guarantorReferenceIDRef_ = guarantorReferenceNode->Attribute("id");
             guarantorReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(guarantorReferenceNode));
             guarantorReference_->setID(guarantorReferenceIDRef_);
             IDManager::instance().setID(guarantorReferenceIDRef_,guarantorReference_);
          }
          else if(guarantorReferenceNode->Attribute("href")) { guarantorReferenceIDRef_ = guarantorReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { guarantorReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(guarantorReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Bond> ReferenceObligation::getBond()
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
boost::shared_ptr<ConvertibleBond> ReferenceObligation::getConvertibleBond()
{
   if(!this->convertibleBondIsNull_){
        if(convertibleBondIDRef_ != ""){
             return boost::shared_static_cast<ConvertibleBond>(IDManager::instance().getID(convertibleBondIDRef_));
        }else{
             return this->convertibleBond_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConvertibleBond>();
   }
}
boost::shared_ptr<Mortgage> ReferenceObligation::getMortgage()
{
   if(!this->mortgageIsNull_){
        if(mortgageIDRef_ != ""){
             return boost::shared_static_cast<Mortgage>(IDManager::instance().getID(mortgageIDRef_));
        }else{
             return this->mortgage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Mortgage>();
   }
}
boost::shared_ptr<Loan> ReferenceObligation::getLoan()
{
   if(!this->loanIsNull_){
        if(loanIDRef_ != ""){
             return boost::shared_static_cast<Loan>(IDManager::instance().getID(loanIDRef_));
        }else{
             return this->loan_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Loan>();
   }
}
boost::shared_ptr<LegalEntity> ReferenceObligation::getPrimaryObligor()
{
   if(!this->primaryObligorIsNull_){
        if(primaryObligorIDRef_ != ""){
             return boost::shared_static_cast<LegalEntity>(IDManager::instance().getID(primaryObligorIDRef_));
        }else{
             return this->primaryObligor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntity>();
   }
}
boost::shared_ptr<LegalEntityReference> ReferenceObligation::getPrimaryObligorReference()
{
   if(!this->primaryObligorReferenceIsNull_){
        if(primaryObligorReferenceIDRef_ != ""){
             return boost::shared_static_cast<LegalEntityReference>(IDManager::instance().getID(primaryObligorReferenceIDRef_));
        }else{
             return this->primaryObligorReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntityReference>();
   }
}
boost::shared_ptr<LegalEntity> ReferenceObligation::getGuarantor()
{
   if(!this->guarantorIsNull_){
        if(guarantorIDRef_ != ""){
             return boost::shared_static_cast<LegalEntity>(IDManager::instance().getID(guarantorIDRef_));
        }else{
             return this->guarantor_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntity>();
   }
}
boost::shared_ptr<LegalEntityReference> ReferenceObligation::getGuarantorReference()
{
   if(!this->guarantorReferenceIsNull_){
        if(guarantorReferenceIDRef_ != ""){
             return boost::shared_static_cast<LegalEntityReference>(IDManager::instance().getID(guarantorReferenceIDRef_));
        }else{
             return this->guarantorReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntityReference>();
   }
}
}

