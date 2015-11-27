// Loan.cpp 
#include "Loan.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Loan::Loan(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //borrowerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* borrowerNode = xmlNode->FirstChildElement("borrower");

   if(borrowerNode){borrowerIsNull_ = false;}
   else{borrowerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- borrowerNode , address : " << borrowerNode << std::endl;
   #endif
   if(borrowerNode)
   {
      if(borrowerNode->Attribute("href") || borrowerNode->Attribute("id"))
      {
          if(borrowerNode->Attribute("id"))
          {
             borrowerIDRef_ = borrowerNode->Attribute("id");
             borrower_ = boost::shared_ptr<LegalEntity>(new LegalEntity(borrowerNode));
             borrower_->setID(borrowerIDRef_);
             IDManager::instance().setID(borrowerIDRef_,borrower_);
          }
          else if(borrowerNode->Attribute("href")) { borrowerIDRef_ = borrowerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { borrower_ = boost::shared_ptr<LegalEntity>(new LegalEntity(borrowerNode));}
   }

   //borrowerReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* borrowerReferenceNode = xmlNode->FirstChildElement("borrowerReference");

   if(borrowerReferenceNode){borrowerReferenceIsNull_ = false;}
   else{borrowerReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- borrowerReferenceNode , address : " << borrowerReferenceNode << std::endl;
   #endif
   if(borrowerReferenceNode)
   {
      if(borrowerReferenceNode->Attribute("href") || borrowerReferenceNode->Attribute("id"))
      {
          if(borrowerReferenceNode->Attribute("id"))
          {
             borrowerReferenceIDRef_ = borrowerReferenceNode->Attribute("id");
             borrowerReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(borrowerReferenceNode));
             borrowerReference_->setID(borrowerReferenceIDRef_);
             IDManager::instance().setID(borrowerReferenceIDRef_,borrowerReference_);
          }
          else if(borrowerReferenceNode->Attribute("href")) { borrowerReferenceIDRef_ = borrowerReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { borrowerReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(borrowerReferenceNode));}
   }

   //lienNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lienNode = xmlNode->FirstChildElement("lien");

   if(lienNode){lienIsNull_ = false;}
   else{lienIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lienNode , address : " << lienNode << std::endl;
   #endif
   if(lienNode)
   {
      if(lienNode->Attribute("href") || lienNode->Attribute("id"))
      {
          if(lienNode->Attribute("id"))
          {
             lienIDRef_ = lienNode->Attribute("id");
             lien_ = boost::shared_ptr<Lien>(new Lien(lienNode));
             lien_->setID(lienIDRef_);
             IDManager::instance().setID(lienIDRef_,lien_);
          }
          else if(lienNode->Attribute("href")) { lienIDRef_ = lienNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lien_ = boost::shared_ptr<Lien>(new Lien(lienNode));}
   }

   //facilityTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* facilityTypeNode = xmlNode->FirstChildElement("facilityType");

   if(facilityTypeNode){facilityTypeIsNull_ = false;}
   else{facilityTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- facilityTypeNode , address : " << facilityTypeNode << std::endl;
   #endif
   if(facilityTypeNode)
   {
      if(facilityTypeNode->Attribute("href") || facilityTypeNode->Attribute("id"))
      {
          if(facilityTypeNode->Attribute("id"))
          {
             facilityTypeIDRef_ = facilityTypeNode->Attribute("id");
             facilityType_ = boost::shared_ptr<FacilityType>(new FacilityType(facilityTypeNode));
             facilityType_->setID(facilityTypeIDRef_);
             IDManager::instance().setID(facilityTypeIDRef_,facilityType_);
          }
          else if(facilityTypeNode->Attribute("href")) { facilityTypeIDRef_ = facilityTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { facilityType_ = boost::shared_ptr<FacilityType>(new FacilityType(facilityTypeNode));}
   }

   //maturityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityNode = xmlNode->FirstChildElement("maturity");

   if(maturityNode){maturityIsNull_ = false;}
   else{maturityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityNode , address : " << maturityNode << std::endl;
   #endif
   if(maturityNode)
   {
      if(maturityNode->Attribute("href") || maturityNode->Attribute("id"))
      {
          if(maturityNode->Attribute("id"))
          {
             maturityIDRef_ = maturityNode->Attribute("id");
             maturity_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityNode));
             maturity_->setID(maturityIDRef_);
             IDManager::instance().setID(maturityIDRef_,maturity_);
          }
          else if(maturityNode->Attribute("href")) { maturityIDRef_ = maturityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maturity_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(maturityNode));}
   }

   //creditAgreementDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditAgreementDateNode = xmlNode->FirstChildElement("creditAgreementDate");

   if(creditAgreementDateNode){creditAgreementDateIsNull_ = false;}
   else{creditAgreementDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditAgreementDateNode , address : " << creditAgreementDateNode << std::endl;
   #endif
   if(creditAgreementDateNode)
   {
      if(creditAgreementDateNode->Attribute("href") || creditAgreementDateNode->Attribute("id"))
      {
          if(creditAgreementDateNode->Attribute("id"))
          {
             creditAgreementDateIDRef_ = creditAgreementDateNode->Attribute("id");
             creditAgreementDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creditAgreementDateNode));
             creditAgreementDate_->setID(creditAgreementDateIDRef_);
             IDManager::instance().setID(creditAgreementDateIDRef_,creditAgreementDate_);
          }
          else if(creditAgreementDateNode->Attribute("href")) { creditAgreementDateIDRef_ = creditAgreementDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditAgreementDate_ = boost::shared_ptr<XsdTypeDate>(new XsdTypeDate(creditAgreementDateNode));}
   }

   //trancheNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* trancheNode = xmlNode->FirstChildElement("tranche");

   if(trancheNode){trancheIsNull_ = false;}
   else{trancheIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- trancheNode , address : " << trancheNode << std::endl;
   #endif
   if(trancheNode)
   {
      if(trancheNode->Attribute("href") || trancheNode->Attribute("id"))
      {
          if(trancheNode->Attribute("id"))
          {
             trancheIDRef_ = trancheNode->Attribute("id");
             tranche_ = boost::shared_ptr<UnderlyingAssetTranche>(new UnderlyingAssetTranche(trancheNode));
             tranche_->setID(trancheIDRef_);
             IDManager::instance().setID(trancheIDRef_,tranche_);
          }
          else if(trancheNode->Attribute("href")) { trancheIDRef_ = trancheNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tranche_ = boost::shared_ptr<UnderlyingAssetTranche>(new UnderlyingAssetTranche(trancheNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LegalEntity> Loan::getBorrower()
{
   if(!this->borrowerIsNull_){
        if(borrowerIDRef_ != ""){
             return boost::shared_static_cast<LegalEntity>(IDManager::instance().getID(borrowerIDRef_));
        }else{
             return this->borrower_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntity>();
   }
}
boost::shared_ptr<LegalEntityReference> Loan::getBorrowerReference()
{
   if(!this->borrowerReferenceIsNull_){
        if(borrowerReferenceIDRef_ != ""){
             return boost::shared_static_cast<LegalEntityReference>(IDManager::instance().getID(borrowerReferenceIDRef_));
        }else{
             return this->borrowerReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntityReference>();
   }
}
boost::shared_ptr<Lien> Loan::getLien()
{
   if(!this->lienIsNull_){
        if(lienIDRef_ != ""){
             return boost::shared_static_cast<Lien>(IDManager::instance().getID(lienIDRef_));
        }else{
             return this->lien_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Lien>();
   }
}
boost::shared_ptr<FacilityType> Loan::getFacilityType()
{
   if(!this->facilityTypeIsNull_){
        if(facilityTypeIDRef_ != ""){
             return boost::shared_static_cast<FacilityType>(IDManager::instance().getID(facilityTypeIDRef_));
        }else{
             return this->facilityType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FacilityType>();
   }
}
boost::shared_ptr<XsdTypeDate> Loan::getMaturity()
{
   if(!this->maturityIsNull_){
        if(maturityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(maturityIDRef_));
        }else{
             return this->maturity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<XsdTypeDate> Loan::getCreditAgreementDate()
{
   if(!this->creditAgreementDateIsNull_){
        if(creditAgreementDateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDate>(IDManager::instance().getID(creditAgreementDateIDRef_));
        }else{
             return this->creditAgreementDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDate>();
   }
}
boost::shared_ptr<UnderlyingAssetTranche> Loan::getTranche()
{
   if(!this->trancheIsNull_){
        if(trancheIDRef_ != ""){
             return boost::shared_static_cast<UnderlyingAssetTranche>(IDManager::instance().getID(trancheIDRef_));
        }else{
             return this->tranche_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnderlyingAssetTranche>();
   }
}
}

