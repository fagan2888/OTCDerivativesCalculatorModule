// SplitSettlement.cpp 
#include "SplitSettlement.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SplitSettlement::SplitSettlement(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //splitSettlementAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* splitSettlementAmountNode = xmlNode->FirstChildElement("splitSettlementAmount");

   if(splitSettlementAmountNode){splitSettlementAmountIsNull_ = false;}
   else{splitSettlementAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- splitSettlementAmountNode , address : " << splitSettlementAmountNode << std::endl;
   #endif
   if(splitSettlementAmountNode)
   {
      if(splitSettlementAmountNode->Attribute("href") || splitSettlementAmountNode->Attribute("id"))
      {
          if(splitSettlementAmountNode->Attribute("id"))
          {
             splitSettlementAmountIDRef_ = splitSettlementAmountNode->Attribute("id");
             splitSettlementAmount_ = boost::shared_ptr<Money>(new Money(splitSettlementAmountNode));
             splitSettlementAmount_->setID(splitSettlementAmountIDRef_);
             IDManager::instance().setID(splitSettlementAmountIDRef_,splitSettlementAmount_);
          }
          else if(splitSettlementAmountNode->Attribute("href")) { splitSettlementAmountIDRef_ = splitSettlementAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { splitSettlementAmount_ = boost::shared_ptr<Money>(new Money(splitSettlementAmountNode));}
   }

   //beneficiaryBankNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* beneficiaryBankNode = xmlNode->FirstChildElement("beneficiaryBank");

   if(beneficiaryBankNode){beneficiaryBankIsNull_ = false;}
   else{beneficiaryBankIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- beneficiaryBankNode , address : " << beneficiaryBankNode << std::endl;
   #endif
   if(beneficiaryBankNode)
   {
      if(beneficiaryBankNode->Attribute("href") || beneficiaryBankNode->Attribute("id"))
      {
          if(beneficiaryBankNode->Attribute("id"))
          {
             beneficiaryBankIDRef_ = beneficiaryBankNode->Attribute("id");
             beneficiaryBank_ = boost::shared_ptr<Routing>(new Routing(beneficiaryBankNode));
             beneficiaryBank_->setID(beneficiaryBankIDRef_);
             IDManager::instance().setID(beneficiaryBankIDRef_,beneficiaryBank_);
          }
          else if(beneficiaryBankNode->Attribute("href")) { beneficiaryBankIDRef_ = beneficiaryBankNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { beneficiaryBank_ = boost::shared_ptr<Routing>(new Routing(beneficiaryBankNode));}
   }

   //beneficiaryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* beneficiaryNode = xmlNode->FirstChildElement("beneficiary");

   if(beneficiaryNode){beneficiaryIsNull_ = false;}
   else{beneficiaryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- beneficiaryNode , address : " << beneficiaryNode << std::endl;
   #endif
   if(beneficiaryNode)
   {
      if(beneficiaryNode->Attribute("href") || beneficiaryNode->Attribute("id"))
      {
          if(beneficiaryNode->Attribute("id"))
          {
             beneficiaryIDRef_ = beneficiaryNode->Attribute("id");
             beneficiary_ = boost::shared_ptr<Routing>(new Routing(beneficiaryNode));
             beneficiary_->setID(beneficiaryIDRef_);
             IDManager::instance().setID(beneficiaryIDRef_,beneficiary_);
          }
          else if(beneficiaryNode->Attribute("href")) { beneficiaryIDRef_ = beneficiaryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { beneficiary_ = boost::shared_ptr<Routing>(new Routing(beneficiaryNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Money> SplitSettlement::getSplitSettlementAmount()
{
   if(!this->splitSettlementAmountIsNull_){
        if(splitSettlementAmountIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(splitSettlementAmountIDRef_));
        }else{
             return this->splitSettlementAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<Routing> SplitSettlement::getBeneficiaryBank()
{
   if(!this->beneficiaryBankIsNull_){
        if(beneficiaryBankIDRef_ != ""){
             return boost::shared_static_cast<Routing>(IDManager::instance().getID(beneficiaryBankIDRef_));
        }else{
             return this->beneficiaryBank_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Routing>();
   }
}
boost::shared_ptr<Routing> SplitSettlement::getBeneficiary()
{
   if(!this->beneficiaryIsNull_){
        if(beneficiaryIDRef_ != ""){
             return boost::shared_static_cast<Routing>(IDManager::instance().getID(beneficiaryIDRef_));
        }else{
             return this->beneficiary_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Routing>();
   }
}
}

