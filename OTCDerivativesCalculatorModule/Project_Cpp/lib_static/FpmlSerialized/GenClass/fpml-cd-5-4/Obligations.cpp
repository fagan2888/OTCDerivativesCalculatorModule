// Obligations.cpp 
#include "Obligations.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Obligations::Obligations(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //categoryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* categoryNode = xmlNode->FirstChildElement("category");

   if(categoryNode){categoryIsNull_ = false;}
   else{categoryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- categoryNode , address : " << categoryNode << std::endl;
   #endif
   if(categoryNode)
   {
      if(categoryNode->Attribute("href") || categoryNode->Attribute("id"))
      {
          if(categoryNode->Attribute("id"))
          {
             categoryIDRef_ = categoryNode->Attribute("id");
             category_ = boost::shared_ptr<ObligationCategoryEnum>(new ObligationCategoryEnum(categoryNode));
             category_->setID(categoryIDRef_);
             IDManager::instance().setID(categoryIDRef_,category_);
          }
          else if(categoryNode->Attribute("href")) { categoryIDRef_ = categoryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { category_ = boost::shared_ptr<ObligationCategoryEnum>(new ObligationCategoryEnum(categoryNode));}
   }

   //notSubordinatedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notSubordinatedNode = xmlNode->FirstChildElement("notSubordinated");

   if(notSubordinatedNode){notSubordinatedIsNull_ = false;}
   else{notSubordinatedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notSubordinatedNode , address : " << notSubordinatedNode << std::endl;
   #endif
   if(notSubordinatedNode)
   {
      if(notSubordinatedNode->Attribute("href") || notSubordinatedNode->Attribute("id"))
      {
          if(notSubordinatedNode->Attribute("id"))
          {
             notSubordinatedIDRef_ = notSubordinatedNode->Attribute("id");
             notSubordinated_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSubordinatedNode));
             notSubordinated_->setID(notSubordinatedIDRef_);
             IDManager::instance().setID(notSubordinatedIDRef_,notSubordinated_);
          }
          else if(notSubordinatedNode->Attribute("href")) { notSubordinatedIDRef_ = notSubordinatedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notSubordinated_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSubordinatedNode));}
   }

   //specifiedCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* specifiedCurrencyNode = xmlNode->FirstChildElement("specifiedCurrency");

   if(specifiedCurrencyNode){specifiedCurrencyIsNull_ = false;}
   else{specifiedCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- specifiedCurrencyNode , address : " << specifiedCurrencyNode << std::endl;
   #endif
   if(specifiedCurrencyNode)
   {
      if(specifiedCurrencyNode->Attribute("href") || specifiedCurrencyNode->Attribute("id"))
      {
          if(specifiedCurrencyNode->Attribute("id"))
          {
             specifiedCurrencyIDRef_ = specifiedCurrencyNode->Attribute("id");
             specifiedCurrency_ = boost::shared_ptr<SpecifiedCurrency>(new SpecifiedCurrency(specifiedCurrencyNode));
             specifiedCurrency_->setID(specifiedCurrencyIDRef_);
             IDManager::instance().setID(specifiedCurrencyIDRef_,specifiedCurrency_);
          }
          else if(specifiedCurrencyNode->Attribute("href")) { specifiedCurrencyIDRef_ = specifiedCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { specifiedCurrency_ = boost::shared_ptr<SpecifiedCurrency>(new SpecifiedCurrency(specifiedCurrencyNode));}
   }

   //notSovereignLenderNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notSovereignLenderNode = xmlNode->FirstChildElement("notSovereignLender");

   if(notSovereignLenderNode){notSovereignLenderIsNull_ = false;}
   else{notSovereignLenderIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notSovereignLenderNode , address : " << notSovereignLenderNode << std::endl;
   #endif
   if(notSovereignLenderNode)
   {
      if(notSovereignLenderNode->Attribute("href") || notSovereignLenderNode->Attribute("id"))
      {
          if(notSovereignLenderNode->Attribute("id"))
          {
             notSovereignLenderIDRef_ = notSovereignLenderNode->Attribute("id");
             notSovereignLender_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSovereignLenderNode));
             notSovereignLender_->setID(notSovereignLenderIDRef_);
             IDManager::instance().setID(notSovereignLenderIDRef_,notSovereignLender_);
          }
          else if(notSovereignLenderNode->Attribute("href")) { notSovereignLenderIDRef_ = notSovereignLenderNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notSovereignLender_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notSovereignLenderNode));}
   }

   //notDomesticCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticCurrencyNode = xmlNode->FirstChildElement("notDomesticCurrency");

   if(notDomesticCurrencyNode){notDomesticCurrencyIsNull_ = false;}
   else{notDomesticCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticCurrencyNode , address : " << notDomesticCurrencyNode << std::endl;
   #endif
   if(notDomesticCurrencyNode)
   {
      if(notDomesticCurrencyNode->Attribute("href") || notDomesticCurrencyNode->Attribute("id"))
      {
          if(notDomesticCurrencyNode->Attribute("id"))
          {
             notDomesticCurrencyIDRef_ = notDomesticCurrencyNode->Attribute("id");
             notDomesticCurrency_ = boost::shared_ptr<NotDomesticCurrency>(new NotDomesticCurrency(notDomesticCurrencyNode));
             notDomesticCurrency_->setID(notDomesticCurrencyIDRef_);
             IDManager::instance().setID(notDomesticCurrencyIDRef_,notDomesticCurrency_);
          }
          else if(notDomesticCurrencyNode->Attribute("href")) { notDomesticCurrencyIDRef_ = notDomesticCurrencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notDomesticCurrency_ = boost::shared_ptr<NotDomesticCurrency>(new NotDomesticCurrency(notDomesticCurrencyNode));}
   }

   //notDomesticLawNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticLawNode = xmlNode->FirstChildElement("notDomesticLaw");

   if(notDomesticLawNode){notDomesticLawIsNull_ = false;}
   else{notDomesticLawIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticLawNode , address : " << notDomesticLawNode << std::endl;
   #endif
   if(notDomesticLawNode)
   {
      if(notDomesticLawNode->Attribute("href") || notDomesticLawNode->Attribute("id"))
      {
          if(notDomesticLawNode->Attribute("id"))
          {
             notDomesticLawIDRef_ = notDomesticLawNode->Attribute("id");
             notDomesticLaw_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticLawNode));
             notDomesticLaw_->setID(notDomesticLawIDRef_);
             IDManager::instance().setID(notDomesticLawIDRef_,notDomesticLaw_);
          }
          else if(notDomesticLawNode->Attribute("href")) { notDomesticLawIDRef_ = notDomesticLawNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notDomesticLaw_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticLawNode));}
   }

   //listedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* listedNode = xmlNode->FirstChildElement("listed");

   if(listedNode){listedIsNull_ = false;}
   else{listedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- listedNode , address : " << listedNode << std::endl;
   #endif
   if(listedNode)
   {
      if(listedNode->Attribute("href") || listedNode->Attribute("id"))
      {
          if(listedNode->Attribute("id"))
          {
             listedIDRef_ = listedNode->Attribute("id");
             listed_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(listedNode));
             listed_->setID(listedIDRef_);
             IDManager::instance().setID(listedIDRef_,listed_);
          }
          else if(listedNode->Attribute("href")) { listedIDRef_ = listedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { listed_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(listedNode));}
   }

   //notDomesticIssuanceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticIssuanceNode = xmlNode->FirstChildElement("notDomesticIssuance");

   if(notDomesticIssuanceNode){notDomesticIssuanceIsNull_ = false;}
   else{notDomesticIssuanceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticIssuanceNode , address : " << notDomesticIssuanceNode << std::endl;
   #endif
   if(notDomesticIssuanceNode)
   {
      if(notDomesticIssuanceNode->Attribute("href") || notDomesticIssuanceNode->Attribute("id"))
      {
          if(notDomesticIssuanceNode->Attribute("id"))
          {
             notDomesticIssuanceIDRef_ = notDomesticIssuanceNode->Attribute("id");
             notDomesticIssuance_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticIssuanceNode));
             notDomesticIssuance_->setID(notDomesticIssuanceIDRef_);
             IDManager::instance().setID(notDomesticIssuanceIDRef_,notDomesticIssuance_);
          }
          else if(notDomesticIssuanceNode->Attribute("href")) { notDomesticIssuanceIDRef_ = notDomesticIssuanceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notDomesticIssuance_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notDomesticIssuanceNode));}
   }

   //fullFaithAndCreditObLiabilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fullFaithAndCreditObLiabilityNode = xmlNode->FirstChildElement("fullFaithAndCreditObLiability");

   if(fullFaithAndCreditObLiabilityNode){fullFaithAndCreditObLiabilityIsNull_ = false;}
   else{fullFaithAndCreditObLiabilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fullFaithAndCreditObLiabilityNode , address : " << fullFaithAndCreditObLiabilityNode << std::endl;
   #endif
   if(fullFaithAndCreditObLiabilityNode)
   {
      if(fullFaithAndCreditObLiabilityNode->Attribute("href") || fullFaithAndCreditObLiabilityNode->Attribute("id"))
      {
          if(fullFaithAndCreditObLiabilityNode->Attribute("id"))
          {
             fullFaithAndCreditObLiabilityIDRef_ = fullFaithAndCreditObLiabilityNode->Attribute("id");
             fullFaithAndCreditObLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullFaithAndCreditObLiabilityNode));
             fullFaithAndCreditObLiability_->setID(fullFaithAndCreditObLiabilityIDRef_);
             IDManager::instance().setID(fullFaithAndCreditObLiabilityIDRef_,fullFaithAndCreditObLiability_);
          }
          else if(fullFaithAndCreditObLiabilityNode->Attribute("href")) { fullFaithAndCreditObLiabilityIDRef_ = fullFaithAndCreditObLiabilityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fullFaithAndCreditObLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(fullFaithAndCreditObLiabilityNode));}
   }

   //generalFundObligationLiabilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* generalFundObligationLiabilityNode = xmlNode->FirstChildElement("generalFundObligationLiability");

   if(generalFundObligationLiabilityNode){generalFundObligationLiabilityIsNull_ = false;}
   else{generalFundObligationLiabilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- generalFundObligationLiabilityNode , address : " << generalFundObligationLiabilityNode << std::endl;
   #endif
   if(generalFundObligationLiabilityNode)
   {
      if(generalFundObligationLiabilityNode->Attribute("href") || generalFundObligationLiabilityNode->Attribute("id"))
      {
          if(generalFundObligationLiabilityNode->Attribute("id"))
          {
             generalFundObligationLiabilityIDRef_ = generalFundObligationLiabilityNode->Attribute("id");
             generalFundObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(generalFundObligationLiabilityNode));
             generalFundObligationLiability_->setID(generalFundObligationLiabilityIDRef_);
             IDManager::instance().setID(generalFundObligationLiabilityIDRef_,generalFundObligationLiability_);
          }
          else if(generalFundObligationLiabilityNode->Attribute("href")) { generalFundObligationLiabilityIDRef_ = generalFundObligationLiabilityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { generalFundObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(generalFundObligationLiabilityNode));}
   }

   //revenueObligationLiabilityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* revenueObligationLiabilityNode = xmlNode->FirstChildElement("revenueObligationLiability");

   if(revenueObligationLiabilityNode){revenueObligationLiabilityIsNull_ = false;}
   else{revenueObligationLiabilityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- revenueObligationLiabilityNode , address : " << revenueObligationLiabilityNode << std::endl;
   #endif
   if(revenueObligationLiabilityNode)
   {
      if(revenueObligationLiabilityNode->Attribute("href") || revenueObligationLiabilityNode->Attribute("id"))
      {
          if(revenueObligationLiabilityNode->Attribute("id"))
          {
             revenueObligationLiabilityIDRef_ = revenueObligationLiabilityNode->Attribute("id");
             revenueObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(revenueObligationLiabilityNode));
             revenueObligationLiability_->setID(revenueObligationLiabilityIDRef_);
             IDManager::instance().setID(revenueObligationLiabilityIDRef_,revenueObligationLiability_);
          }
          else if(revenueObligationLiabilityNode->Attribute("href")) { revenueObligationLiabilityIDRef_ = revenueObligationLiabilityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { revenueObligationLiability_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(revenueObligationLiabilityNode));}
   }

   //notContingentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notContingentNode = xmlNode->FirstChildElement("notContingent");

   if(notContingentNode){notContingentIsNull_ = false;}
   else{notContingentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notContingentNode , address : " << notContingentNode << std::endl;
   #endif
   if(notContingentNode)
   {
      if(notContingentNode->Attribute("href") || notContingentNode->Attribute("id"))
      {
          if(notContingentNode->Attribute("id"))
          {
             notContingentIDRef_ = notContingentNode->Attribute("id");
             notContingent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notContingentNode));
             notContingent_->setID(notContingentIDRef_);
             IDManager::instance().setID(notContingentIDRef_,notContingent_);
          }
          else if(notContingentNode->Attribute("href")) { notContingentIDRef_ = notContingentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { notContingent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(notContingentNode));}
   }

   //excludedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excludedNode = xmlNode->FirstChildElement("excluded");

   if(excludedNode){excludedIsNull_ = false;}
   else{excludedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excludedNode , address : " << excludedNode << std::endl;
   #endif
   if(excludedNode)
   {
      if(excludedNode->Attribute("href") || excludedNode->Attribute("id"))
      {
          if(excludedNode->Attribute("id"))
          {
             excludedIDRef_ = excludedNode->Attribute("id");
             excluded_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(excludedNode));
             excluded_->setID(excludedIDRef_);
             IDManager::instance().setID(excludedIDRef_,excluded_);
          }
          else if(excludedNode->Attribute("href")) { excludedIDRef_ = excludedNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { excluded_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(excludedNode));}
   }

   //othReferenceEntityObligationsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* othReferenceEntityObligationsNode = xmlNode->FirstChildElement("othReferenceEntityObligations");

   if(othReferenceEntityObligationsNode){othReferenceEntityObligationsIsNull_ = false;}
   else{othReferenceEntityObligationsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- othReferenceEntityObligationsNode , address : " << othReferenceEntityObligationsNode << std::endl;
   #endif
   if(othReferenceEntityObligationsNode)
   {
      if(othReferenceEntityObligationsNode->Attribute("href") || othReferenceEntityObligationsNode->Attribute("id"))
      {
          if(othReferenceEntityObligationsNode->Attribute("id"))
          {
             othReferenceEntityObligationsIDRef_ = othReferenceEntityObligationsNode->Attribute("id");
             othReferenceEntityObligations_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(othReferenceEntityObligationsNode));
             othReferenceEntityObligations_->setID(othReferenceEntityObligationsIDRef_);
             IDManager::instance().setID(othReferenceEntityObligationsIDRef_,othReferenceEntityObligations_);
          }
          else if(othReferenceEntityObligationsNode->Attribute("href")) { othReferenceEntityObligationsIDRef_ = othReferenceEntityObligationsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { othReferenceEntityObligations_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(othReferenceEntityObligationsNode));}
   }

   //designatedPriorityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* designatedPriorityNode = xmlNode->FirstChildElement("designatedPriority");

   if(designatedPriorityNode){designatedPriorityIsNull_ = false;}
   else{designatedPriorityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- designatedPriorityNode , address : " << designatedPriorityNode << std::endl;
   #endif
   if(designatedPriorityNode)
   {
      if(designatedPriorityNode->Attribute("href") || designatedPriorityNode->Attribute("id"))
      {
          if(designatedPriorityNode->Attribute("id"))
          {
             designatedPriorityIDRef_ = designatedPriorityNode->Attribute("id");
             designatedPriority_ = boost::shared_ptr<Lien>(new Lien(designatedPriorityNode));
             designatedPriority_->setID(designatedPriorityIDRef_);
             IDManager::instance().setID(designatedPriorityIDRef_,designatedPriority_);
          }
          else if(designatedPriorityNode->Attribute("href")) { designatedPriorityIDRef_ = designatedPriorityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { designatedPriority_ = boost::shared_ptr<Lien>(new Lien(designatedPriorityNode));}
   }

   //cashSettlementOnlyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cashSettlementOnlyNode = xmlNode->FirstChildElement("cashSettlementOnly");

   if(cashSettlementOnlyNode){cashSettlementOnlyIsNull_ = false;}
   else{cashSettlementOnlyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cashSettlementOnlyNode , address : " << cashSettlementOnlyNode << std::endl;
   #endif
   if(cashSettlementOnlyNode)
   {
      if(cashSettlementOnlyNode->Attribute("href") || cashSettlementOnlyNode->Attribute("id"))
      {
          if(cashSettlementOnlyNode->Attribute("id"))
          {
             cashSettlementOnlyIDRef_ = cashSettlementOnlyNode->Attribute("id");
             cashSettlementOnly_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(cashSettlementOnlyNode));
             cashSettlementOnly_->setID(cashSettlementOnlyIDRef_);
             IDManager::instance().setID(cashSettlementOnlyIDRef_,cashSettlementOnly_);
          }
          else if(cashSettlementOnlyNode->Attribute("href")) { cashSettlementOnlyIDRef_ = cashSettlementOnlyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cashSettlementOnly_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(cashSettlementOnlyNode));}
   }

   //deliveryOfCommitmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryOfCommitmentsNode = xmlNode->FirstChildElement("deliveryOfCommitments");

   if(deliveryOfCommitmentsNode){deliveryOfCommitmentsIsNull_ = false;}
   else{deliveryOfCommitmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryOfCommitmentsNode , address : " << deliveryOfCommitmentsNode << std::endl;
   #endif
   if(deliveryOfCommitmentsNode)
   {
      if(deliveryOfCommitmentsNode->Attribute("href") || deliveryOfCommitmentsNode->Attribute("id"))
      {
          if(deliveryOfCommitmentsNode->Attribute("id"))
          {
             deliveryOfCommitmentsIDRef_ = deliveryOfCommitmentsNode->Attribute("id");
             deliveryOfCommitments_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deliveryOfCommitmentsNode));
             deliveryOfCommitments_->setID(deliveryOfCommitmentsIDRef_);
             IDManager::instance().setID(deliveryOfCommitmentsIDRef_,deliveryOfCommitments_);
          }
          else if(deliveryOfCommitmentsNode->Attribute("href")) { deliveryOfCommitmentsIDRef_ = deliveryOfCommitmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryOfCommitments_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(deliveryOfCommitmentsNode));}
   }

   //continuityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* continuityNode = xmlNode->FirstChildElement("continuity");

   if(continuityNode){continuityIsNull_ = false;}
   else{continuityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- continuityNode , address : " << continuityNode << std::endl;
   #endif
   if(continuityNode)
   {
      if(continuityNode->Attribute("href") || continuityNode->Attribute("id"))
      {
          if(continuityNode->Attribute("id"))
          {
             continuityIDRef_ = continuityNode->Attribute("id");
             continuity_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(continuityNode));
             continuity_->setID(continuityIDRef_);
             IDManager::instance().setID(continuityIDRef_,continuity_);
          }
          else if(continuityNode->Attribute("href")) { continuityIDRef_ = continuityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { continuity_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(continuityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ObligationCategoryEnum> Obligations::getCategory()
{
   if(!this->categoryIsNull_){
        if(categoryIDRef_ != ""){
             return boost::shared_static_cast<ObligationCategoryEnum>(IDManager::instance().getID(categoryIDRef_));
        }else{
             return this->category_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ObligationCategoryEnum>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getNotSubordinated()
{
   if(!this->notSubordinatedIsNull_){
        if(notSubordinatedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notSubordinatedIDRef_));
        }else{
             return this->notSubordinated_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<SpecifiedCurrency> Obligations::getSpecifiedCurrency()
{
   if(!this->specifiedCurrencyIsNull_){
        if(specifiedCurrencyIDRef_ != ""){
             return boost::shared_static_cast<SpecifiedCurrency>(IDManager::instance().getID(specifiedCurrencyIDRef_));
        }else{
             return this->specifiedCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SpecifiedCurrency>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getNotSovereignLender()
{
   if(!this->notSovereignLenderIsNull_){
        if(notSovereignLenderIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notSovereignLenderIDRef_));
        }else{
             return this->notSovereignLender_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<NotDomesticCurrency> Obligations::getNotDomesticCurrency()
{
   if(!this->notDomesticCurrencyIsNull_){
        if(notDomesticCurrencyIDRef_ != ""){
             return boost::shared_static_cast<NotDomesticCurrency>(IDManager::instance().getID(notDomesticCurrencyIDRef_));
        }else{
             return this->notDomesticCurrency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NotDomesticCurrency>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getNotDomesticLaw()
{
   if(!this->notDomesticLawIsNull_){
        if(notDomesticLawIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notDomesticLawIDRef_));
        }else{
             return this->notDomesticLaw_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getListed()
{
   if(!this->listedIsNull_){
        if(listedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(listedIDRef_));
        }else{
             return this->listed_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getNotDomesticIssuance()
{
   if(!this->notDomesticIssuanceIsNull_){
        if(notDomesticIssuanceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notDomesticIssuanceIDRef_));
        }else{
             return this->notDomesticIssuance_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getFullFaithAndCreditObLiability()
{
   if(!this->fullFaithAndCreditObLiabilityIsNull_){
        if(fullFaithAndCreditObLiabilityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(fullFaithAndCreditObLiabilityIDRef_));
        }else{
             return this->fullFaithAndCreditObLiability_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getGeneralFundObligationLiability()
{
   if(!this->generalFundObligationLiabilityIsNull_){
        if(generalFundObligationLiabilityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(generalFundObligationLiabilityIDRef_));
        }else{
             return this->generalFundObligationLiability_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getRevenueObligationLiability()
{
   if(!this->revenueObligationLiabilityIsNull_){
        if(revenueObligationLiabilityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(revenueObligationLiabilityIDRef_));
        }else{
             return this->revenueObligationLiability_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getNotContingent()
{
   if(!this->notContingentIsNull_){
        if(notContingentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(notContingentIDRef_));
        }else{
             return this->notContingent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeString> Obligations::getExcluded()
{
   if(!this->excludedIsNull_){
        if(excludedIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(excludedIDRef_));
        }else{
             return this->excluded_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> Obligations::getOthReferenceEntityObligations()
{
   if(!this->othReferenceEntityObligationsIsNull_){
        if(othReferenceEntityObligationsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(othReferenceEntityObligationsIDRef_));
        }else{
             return this->othReferenceEntityObligations_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<Lien> Obligations::getDesignatedPriority()
{
   if(!this->designatedPriorityIsNull_){
        if(designatedPriorityIDRef_ != ""){
             return boost::shared_static_cast<Lien>(IDManager::instance().getID(designatedPriorityIDRef_));
        }else{
             return this->designatedPriority_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Lien>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getCashSettlementOnly()
{
   if(!this->cashSettlementOnlyIsNull_){
        if(cashSettlementOnlyIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(cashSettlementOnlyIDRef_));
        }else{
             return this->cashSettlementOnly_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getDeliveryOfCommitments()
{
   if(!this->deliveryOfCommitmentsIsNull_){
        if(deliveryOfCommitmentsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(deliveryOfCommitmentsIDRef_));
        }else{
             return this->deliveryOfCommitments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> Obligations::getContinuity()
{
   if(!this->continuityIsNull_){
        if(continuityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(continuityIDRef_));
        }else{
             return this->continuity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

