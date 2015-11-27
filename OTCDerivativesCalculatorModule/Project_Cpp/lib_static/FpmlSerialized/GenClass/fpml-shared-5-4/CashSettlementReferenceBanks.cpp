// CashSettlementReferenceBanks.cpp 
#include "CashSettlementReferenceBanks.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CashSettlementReferenceBanks::CashSettlementReferenceBanks(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceBankNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceBankNode = xmlNode->FirstChildElement("referenceBank");

   if(referenceBankNode){referenceBankIsNull_ = false;}
   else{referenceBankIsNull_ = true;}

   if(referenceBankNode)
   {
      for(referenceBankNode; referenceBankNode; referenceBankNode = referenceBankNode->NextSiblingElement("referenceBank")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceBankNode , address : " << referenceBankNode << std::endl;
          #endif
          if(referenceBankNode->Attribute("href") || referenceBankNode->Attribute("id"))
          {
              if(referenceBankNode->Attribute("id"))
              {
                  referenceBankIDRef_ = referenceBankNode->Attribute("id");
                  referenceBank_.push_back(boost::shared_ptr<ReferenceBank>(new ReferenceBank(referenceBankNode)));
                  referenceBank_.back()->setID(referenceBankIDRef_);
                  IDManager::instance().setID(referenceBankIDRef_, referenceBank_.back());
              }
              else if(referenceBankNode->Attribute("href")) { referenceBankIDRef_ = referenceBankNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { referenceBank_.push_back(boost::shared_ptr<ReferenceBank>(new ReferenceBank(referenceBankNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceBankNode , address : " << referenceBankNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ReferenceBank>> CashSettlementReferenceBanks::getReferenceBank()
{
   if(!this->referenceBankIsNull_){
        if(referenceBankIDRef_ != ""){
             return this->referenceBank_;
        }else{
             return this->referenceBank_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReferenceBank>>();
   }
}
}

