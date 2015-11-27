// Bond.cpp 
#include "Bond.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Bond::Bond(TiXmlNode* xmlNode)
: UnderlyingAsset(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //parValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* parValueNode = xmlNode->FirstChildElement("parValue");

   if(parValueNode){parValueIsNull_ = false;}
   else{parValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- parValueNode , address : " << parValueNode << std::endl;
   #endif
   if(parValueNode)
   {
      if(parValueNode->Attribute("href") || parValueNode->Attribute("id"))
      {
          if(parValueNode->Attribute("id"))
          {
             parValueIDRef_ = parValueNode->Attribute("id");
             parValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(parValueNode));
             parValue_->setID(parValueIDRef_);
             IDManager::instance().setID(parValueIDRef_,parValue_);
          }
          else if(parValueNode->Attribute("href")) { parValueIDRef_ = parValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { parValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(parValueNode));}
   }

   //faceAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* faceAmountNode = xmlNode->FirstChildElement("faceAmount");

   if(faceAmountNode){faceAmountIsNull_ = false;}
   else{faceAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- faceAmountNode , address : " << faceAmountNode << std::endl;
   #endif
   if(faceAmountNode)
   {
      if(faceAmountNode->Attribute("href") || faceAmountNode->Attribute("id"))
      {
          if(faceAmountNode->Attribute("id"))
          {
             faceAmountIDRef_ = faceAmountNode->Attribute("id");
             faceAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(faceAmountNode));
             faceAmount_->setID(faceAmountIDRef_);
             IDManager::instance().setID(faceAmountIDRef_,faceAmount_);
          }
          else if(faceAmountNode->Attribute("href")) { faceAmountIDRef_ = faceAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { faceAmount_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(faceAmountNode));}
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> Bond::getIssuerName()
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
boost::shared_ptr<PartyReference> Bond::getIssuerPartyReference()
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
boost::shared_ptr<CreditSeniority> Bond::getSeniority()
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
boost::shared_ptr<CouponType> Bond::getCouponType()
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
boost::shared_ptr<XsdTypeDecimal> Bond::getCouponRate()
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
boost::shared_ptr<XsdTypeDate> Bond::getMaturity()
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
boost::shared_ptr<XsdTypeDecimal> Bond::getParValue()
{
   if(!this->parValueIsNull_){
        if(parValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(parValueIDRef_));
        }else{
             return this->parValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Bond::getFaceAmount()
{
   if(!this->faceAmountIsNull_){
        if(faceAmountIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(faceAmountIDRef_));
        }else{
             return this->faceAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<Period> Bond::getPaymentFrequency()
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
boost::shared_ptr<DayCountFraction> Bond::getDayCountFraction()
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
}

