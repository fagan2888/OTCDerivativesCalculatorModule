// Mortgage.cpp 
#include "Mortgage.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Mortgage::Mortgage(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //insurerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* insurerNode = xmlNode->FirstChildElement("insurer");

   if(insurerNode){insurerIsNull_ = false;}
   else{insurerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- insurerNode , address : " << insurerNode << std::endl;
   #endif
   if(insurerNode)
   {
      if(insurerNode->Attribute("href") || insurerNode->Attribute("id"))
      {
          if(insurerNode->Attribute("id"))
          {
             insurerIDRef_ = insurerNode->Attribute("id");
             insurer_ = boost::shared_ptr<LegalEntity>(new LegalEntity(insurerNode));
             insurer_->setID(insurerIDRef_);
             IDManager::instance().setID(insurerIDRef_,insurer_);
          }
          else if(insurerNode->Attribute("href")) { insurerIDRef_ = insurerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { insurer_ = boost::shared_ptr<LegalEntity>(new LegalEntity(insurerNode));}
   }

   //insurerReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* insurerReferenceNode = xmlNode->FirstChildElement("insurerReference");

   if(insurerReferenceNode){insurerReferenceIsNull_ = false;}
   else{insurerReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- insurerReferenceNode , address : " << insurerReferenceNode << std::endl;
   #endif
   if(insurerReferenceNode)
   {
      if(insurerReferenceNode->Attribute("href") || insurerReferenceNode->Attribute("id"))
      {
          if(insurerReferenceNode->Attribute("id"))
          {
             insurerReferenceIDRef_ = insurerReferenceNode->Attribute("id");
             insurerReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(insurerReferenceNode));
             insurerReference_->setID(insurerReferenceIDRef_);
             IDManager::instance().setID(insurerReferenceIDRef_,insurerReference_);
          }
          else if(insurerReferenceNode->Attribute("href")) { insurerReferenceIDRef_ = insurerReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { insurerReference_ = boost::shared_ptr<LegalEntityReference>(new LegalEntityReference(insurerReferenceNode));}
   }

   //issuerNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* issuerNameNode = xmlNode->FirstChildElement("issuerName");

   if(issuerNameNode){issuerNameIsNull_ = false;}
   else{issuerNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- issuerNameNode , address : " << issuerNameNode << std::endl;
   #endif
   if(issuerNameNode)
   {
      if(issuerNameNode->Attribute("href") || issuerNameNode->Attribute("id"))
      {
          if(issuerNameNode->Attribute("id"))
          {
             issuerNameIDRef_ = issuerNameNode->Attribute("id");
             issuerName_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(issuerNameNode));
             issuerName_->setID(issuerNameIDRef_);
             IDManager::instance().setID(issuerNameIDRef_,issuerName_);
          }
          else if(issuerNameNode->Attribute("href")) { issuerNameIDRef_ = issuerNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { issuerName_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(issuerNameNode));}
   }

   //issuerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* issuerPartyReferenceNode = xmlNode->FirstChildElement("issuerPartyReference");

   if(issuerPartyReferenceNode){issuerPartyReferenceIsNull_ = false;}
   else{issuerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- issuerPartyReferenceNode , address : " << issuerPartyReferenceNode << std::endl;
   #endif
   if(issuerPartyReferenceNode)
   {
      if(issuerPartyReferenceNode->Attribute("href") || issuerPartyReferenceNode->Attribute("id"))
      {
          if(issuerPartyReferenceNode->Attribute("id"))
          {
             issuerPartyReferenceIDRef_ = issuerPartyReferenceNode->Attribute("id");
             issuerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(issuerPartyReferenceNode));
             issuerPartyReference_->setID(issuerPartyReferenceIDRef_);
             IDManager::instance().setID(issuerPartyReferenceIDRef_,issuerPartyReference_);
          }
          else if(issuerPartyReferenceNode->Attribute("href")) { issuerPartyReferenceIDRef_ = issuerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { issuerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(issuerPartyReferenceNode));}
   }

   //seniorityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* seniorityNode = xmlNode->FirstChildElement("seniority");

   if(seniorityNode){seniorityIsNull_ = false;}
   else{seniorityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- seniorityNode , address : " << seniorityNode << std::endl;
   #endif
   if(seniorityNode)
   {
      if(seniorityNode->Attribute("href") || seniorityNode->Attribute("id"))
      {
          if(seniorityNode->Attribute("id"))
          {
             seniorityIDRef_ = seniorityNode->Attribute("id");
             seniority_ = boost::shared_ptr<CreditSeniority>(new CreditSeniority(seniorityNode));
             seniority_->setID(seniorityIDRef_);
             IDManager::instance().setID(seniorityIDRef_,seniority_);
          }
          else if(seniorityNode->Attribute("href")) { seniorityIDRef_ = seniorityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { seniority_ = boost::shared_ptr<CreditSeniority>(new CreditSeniority(seniorityNode));}
   }

   //couponTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponTypeNode = xmlNode->FirstChildElement("couponType");

   if(couponTypeNode){couponTypeIsNull_ = false;}
   else{couponTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponTypeNode , address : " << couponTypeNode << std::endl;
   #endif
   if(couponTypeNode)
   {
      if(couponTypeNode->Attribute("href") || couponTypeNode->Attribute("id"))
      {
          if(couponTypeNode->Attribute("id"))
          {
             couponTypeIDRef_ = couponTypeNode->Attribute("id");
             couponType_ = boost::shared_ptr<CouponType>(new CouponType(couponTypeNode));
             couponType_->setID(couponTypeIDRef_);
             IDManager::instance().setID(couponTypeIDRef_,couponType_);
          }
          else if(couponTypeNode->Attribute("href")) { couponTypeIDRef_ = couponTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { couponType_ = boost::shared_ptr<CouponType>(new CouponType(couponTypeNode));}
   }

   //couponRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* couponRateNode = xmlNode->FirstChildElement("couponRate");

   if(couponRateNode){couponRateIsNull_ = false;}
   else{couponRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- couponRateNode , address : " << couponRateNode << std::endl;
   #endif
   if(couponRateNode)
   {
      if(couponRateNode->Attribute("href") || couponRateNode->Attribute("id"))
      {
          if(couponRateNode->Attribute("id"))
          {
             couponRateIDRef_ = couponRateNode->Attribute("id");
             couponRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(couponRateNode));
             couponRate_->setID(couponRateIDRef_);
             IDManager::instance().setID(couponRateIDRef_,couponRate_);
          }
          else if(couponRateNode->Attribute("href")) { couponRateIDRef_ = couponRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { couponRate_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(couponRateNode));}
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

   //paymentFrequencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentFrequencyNode = xmlNode->FirstChildElement("paymentFrequency");

   if(paymentFrequencyNode){paymentFrequencyIsNull_ = false;}
   else{paymentFrequencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentFrequencyNode , address : " << paymentFrequencyNode << std::endl;
   #endif
   if(paymentFrequencyNode)
   {
      if(paymentFrequencyNode->Attribute("href") || paymentFrequencyNode->Attribute("id"))
      {
          if(paymentFrequencyNode->Attribute("id"))
          {
             paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("id");
             paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));
             paymentFrequency_->setID(paymentFrequencyIDRef_);
             IDManager::instance().setID(paymentFrequencyIDRef_,paymentFrequency_);
          }
          else if(paymentFrequencyNode->Attribute("href")) { paymentFrequencyIDRef_ = paymentFrequencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentFrequency_ = boost::shared_ptr<Period>(new Period(paymentFrequencyNode));}
   }

   //dayCountFractionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dayCountFractionNode = xmlNode->FirstChildElement("dayCountFraction");

   if(dayCountFractionNode){dayCountFractionIsNull_ = false;}
   else{dayCountFractionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dayCountFractionNode , address : " << dayCountFractionNode << std::endl;
   #endif
   if(dayCountFractionNode)
   {
      if(dayCountFractionNode->Attribute("href") || dayCountFractionNode->Attribute("id"))
      {
          if(dayCountFractionNode->Attribute("id"))
          {
             dayCountFractionIDRef_ = dayCountFractionNode->Attribute("id");
             dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));
             dayCountFraction_->setID(dayCountFractionIDRef_);
             IDManager::instance().setID(dayCountFractionIDRef_,dayCountFraction_);
          }
          else if(dayCountFractionNode->Attribute("href")) { dayCountFractionIDRef_ = dayCountFractionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dayCountFraction_ = boost::shared_ptr<DayCountFraction>(new DayCountFraction(dayCountFractionNode));}
   }

   //originalPrincipalAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originalPrincipalAmountNode = xmlNode->FirstChildElement("originalPrincipalAmount");

   if(originalPrincipalAmountNode){originalPrincipalAmountIsNull_ = false;}
   else{originalPrincipalAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originalPrincipalAmountNode , address : " << originalPrincipalAmountNode << std::endl;
   #endif
   if(originalPrincipalAmountNode)
   {
      if(originalPrincipalAmountNode->Attribute("href") || originalPrincipalAmountNode->Attribute("id"))
      {
          if(originalPrincipalAmountNode->Attribute("id"))
          {
             originalPrincipalAmountIDRef_ = originalPrincipalAmountNode->Attribute("id");
             originalPrincipalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(originalPrincipalAmountNode));
             originalPrincipalAmount_->setID(originalPrincipalAmountIDRef_);
             IDManager::instance().setID(originalPrincipalAmountIDRef_,originalPrincipalAmount_);
          }
          else if(originalPrincipalAmountNode->Attribute("href")) { originalPrincipalAmountIDRef_ = originalPrincipalAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { originalPrincipalAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(originalPrincipalAmountNode));}
   }

   //poolNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* poolNode = xmlNode->FirstChildElement("pool");

   if(poolNode){poolIsNull_ = false;}
   else{poolIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- poolNode , address : " << poolNode << std::endl;
   #endif
   if(poolNode)
   {
      if(poolNode->Attribute("href") || poolNode->Attribute("id"))
      {
          if(poolNode->Attribute("id"))
          {
             poolIDRef_ = poolNode->Attribute("id");
             pool_ = boost::shared_ptr<AssetPool>(new AssetPool(poolNode));
             pool_->setID(poolIDRef_);
             IDManager::instance().setID(poolIDRef_,pool_);
          }
          else if(poolNode->Attribute("href")) { poolIDRef_ = poolNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pool_ = boost::shared_ptr<AssetPool>(new AssetPool(poolNode));}
   }

   //sectorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sectorNode = xmlNode->FirstChildElement("sector");

   if(sectorNode){sectorIsNull_ = false;}
   else{sectorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sectorNode , address : " << sectorNode << std::endl;
   #endif
   if(sectorNode)
   {
      if(sectorNode->Attribute("href") || sectorNode->Attribute("id"))
      {
          if(sectorNode->Attribute("id"))
          {
             sectorIDRef_ = sectorNode->Attribute("id");
             sector_ = boost::shared_ptr<MortgageSector>(new MortgageSector(sectorNode));
             sector_->setID(sectorIDRef_);
             IDManager::instance().setID(sectorIDRef_,sector_);
          }
          else if(sectorNode->Attribute("href")) { sectorIDRef_ = sectorNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sector_ = boost::shared_ptr<MortgageSector>(new MortgageSector(sectorNode));}
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
             tranche_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(trancheNode));
             tranche_->setID(trancheIDRef_);
             IDManager::instance().setID(trancheIDRef_,tranche_);
          }
          else if(trancheNode->Attribute("href")) { trancheIDRef_ = trancheNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { tranche_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(trancheNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LegalEntity> Mortgage::getInsurer()
{
   if(!this->insurerIsNull_){
        if(insurerIDRef_ != ""){
             return boost::shared_static_cast<LegalEntity>(IDManager::instance().getID(insurerIDRef_));
        }else{
             return this->insurer_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntity>();
   }
}
boost::shared_ptr<LegalEntityReference> Mortgage::getInsurerReference()
{
   if(!this->insurerReferenceIsNull_){
        if(insurerReferenceIDRef_ != ""){
             return boost::shared_static_cast<LegalEntityReference>(IDManager::instance().getID(insurerReferenceIDRef_));
        }else{
             return this->insurerReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LegalEntityReference>();
   }
}
boost::shared_ptr<XsdTypeString> Mortgage::getIssuerName()
{
   if(!this->issuerNameIsNull_){
        if(issuerNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(issuerNameIDRef_));
        }else{
             return this->issuerName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<PartyReference> Mortgage::getIssuerPartyReference()
{
   if(!this->issuerPartyReferenceIsNull_){
        if(issuerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(issuerPartyReferenceIDRef_));
        }else{
             return this->issuerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<CreditSeniority> Mortgage::getSeniority()
{
   if(!this->seniorityIsNull_){
        if(seniorityIDRef_ != ""){
             return boost::shared_static_cast<CreditSeniority>(IDManager::instance().getID(seniorityIDRef_));
        }else{
             return this->seniority_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditSeniority>();
   }
}
boost::shared_ptr<CouponType> Mortgage::getCouponType()
{
   if(!this->couponTypeIsNull_){
        if(couponTypeIDRef_ != ""){
             return boost::shared_static_cast<CouponType>(IDManager::instance().getID(couponTypeIDRef_));
        }else{
             return this->couponType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CouponType>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Mortgage::getCouponRate()
{
   if(!this->couponRateIsNull_){
        if(couponRateIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(couponRateIDRef_));
        }else{
             return this->couponRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDate> Mortgage::getMaturity()
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
boost::shared_ptr<Period> Mortgage::getPaymentFrequency()
{
   if(!this->paymentFrequencyIsNull_){
        if(paymentFrequencyIDRef_ != ""){
             return boost::shared_static_cast<Period>(IDManager::instance().getID(paymentFrequencyIDRef_));
        }else{
             return this->paymentFrequency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Period>();
   }
}
boost::shared_ptr<DayCountFraction> Mortgage::getDayCountFraction()
{
   if(!this->dayCountFractionIsNull_){
        if(dayCountFractionIDRef_ != ""){
             return boost::shared_static_cast<DayCountFraction>(IDManager::instance().getID(dayCountFractionIDRef_));
        }else{
             return this->dayCountFraction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DayCountFraction>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Mortgage::getOriginalPrincipalAmount()
{
   if(!this->originalPrincipalAmountIsNull_){
        if(originalPrincipalAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(originalPrincipalAmountIDRef_));
        }else{
             return this->originalPrincipalAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<AssetPool> Mortgage::getPool()
{
   if(!this->poolIsNull_){
        if(poolIDRef_ != ""){
             return boost::shared_static_cast<AssetPool>(IDManager::instance().getID(poolIDRef_));
        }else{
             return this->pool_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AssetPool>();
   }
}
boost::shared_ptr<MortgageSector> Mortgage::getSector()
{
   if(!this->sectorIsNull_){
        if(sectorIDRef_ != ""){
             return boost::shared_static_cast<MortgageSector>(IDManager::instance().getID(sectorIDRef_));
        }else{
             return this->sector_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MortgageSector>();
   }
}
boost::shared_ptr<XsdTypeToken> Mortgage::getTranche()
{
   if(!this->trancheIsNull_){
        if(trancheIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(trancheIDRef_));
        }else{
             return this->tranche_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

