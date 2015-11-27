// GeneralTerms.cpp 
#include "GeneralTerms.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GeneralTerms::GeneralTerms(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //effectiveDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* effectiveDateNode = xmlNode->FirstChildElement("effectiveDate");

   if(effectiveDateNode){effectiveDateIsNull_ = false;}
   else{effectiveDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- effectiveDateNode , address : " << effectiveDateNode << std::endl;
   #endif
   if(effectiveDateNode)
   {
      if(effectiveDateNode->Attribute("href") || effectiveDateNode->Attribute("id"))
      {
          if(effectiveDateNode->Attribute("id"))
          {
             effectiveDateIDRef_ = effectiveDateNode->Attribute("id");
             effectiveDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(effectiveDateNode));
             effectiveDate_->setID(effectiveDateIDRef_);
             IDManager::instance().setID(effectiveDateIDRef_,effectiveDate_);
          }
          else if(effectiveDateNode->Attribute("href")) { effectiveDateIDRef_ = effectiveDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { effectiveDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(effectiveDateNode));}
   }

   //scheduledTerminationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* scheduledTerminationDateNode = xmlNode->FirstChildElement("scheduledTerminationDate");

   if(scheduledTerminationDateNode){scheduledTerminationDateIsNull_ = false;}
   else{scheduledTerminationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- scheduledTerminationDateNode , address : " << scheduledTerminationDateNode << std::endl;
   #endif
   if(scheduledTerminationDateNode)
   {
      if(scheduledTerminationDateNode->Attribute("href") || scheduledTerminationDateNode->Attribute("id"))
      {
          if(scheduledTerminationDateNode->Attribute("id"))
          {
             scheduledTerminationDateIDRef_ = scheduledTerminationDateNode->Attribute("id");
             scheduledTerminationDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(scheduledTerminationDateNode));
             scheduledTerminationDate_->setID(scheduledTerminationDateIDRef_);
             IDManager::instance().setID(scheduledTerminationDateIDRef_,scheduledTerminationDate_);
          }
          else if(scheduledTerminationDateNode->Attribute("href")) { scheduledTerminationDateIDRef_ = scheduledTerminationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { scheduledTerminationDate_ = boost::shared_ptr<AdjustableDate2>(new AdjustableDate2(scheduledTerminationDateNode));}
   }

   //buyerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerPartyReferenceNode = xmlNode->FirstChildElement("buyerPartyReference");

   if(buyerPartyReferenceNode){buyerPartyReferenceIsNull_ = false;}
   else{buyerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerPartyReferenceNode , address : " << buyerPartyReferenceNode << std::endl;
   #endif
   if(buyerPartyReferenceNode)
   {
      if(buyerPartyReferenceNode->Attribute("href") || buyerPartyReferenceNode->Attribute("id"))
      {
          if(buyerPartyReferenceNode->Attribute("id"))
          {
             buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("id");
             buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));
             buyerPartyReference_->setID(buyerPartyReferenceIDRef_);
             IDManager::instance().setID(buyerPartyReferenceIDRef_,buyerPartyReference_);
          }
          else if(buyerPartyReferenceNode->Attribute("href")) { buyerPartyReferenceIDRef_ = buyerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(buyerPartyReferenceNode));}
   }

   //buyerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* buyerAccountReferenceNode = xmlNode->FirstChildElement("buyerAccountReference");

   if(buyerAccountReferenceNode){buyerAccountReferenceIsNull_ = false;}
   else{buyerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- buyerAccountReferenceNode , address : " << buyerAccountReferenceNode << std::endl;
   #endif
   if(buyerAccountReferenceNode)
   {
      if(buyerAccountReferenceNode->Attribute("href") || buyerAccountReferenceNode->Attribute("id"))
      {
          if(buyerAccountReferenceNode->Attribute("id"))
          {
             buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("id");
             buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));
             buyerAccountReference_->setID(buyerAccountReferenceIDRef_);
             IDManager::instance().setID(buyerAccountReferenceIDRef_,buyerAccountReference_);
          }
          else if(buyerAccountReferenceNode->Attribute("href")) { buyerAccountReferenceIDRef_ = buyerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { buyerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(buyerAccountReferenceNode));}
   }

   //sellerPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerPartyReferenceNode = xmlNode->FirstChildElement("sellerPartyReference");

   if(sellerPartyReferenceNode){sellerPartyReferenceIsNull_ = false;}
   else{sellerPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerPartyReferenceNode , address : " << sellerPartyReferenceNode << std::endl;
   #endif
   if(sellerPartyReferenceNode)
   {
      if(sellerPartyReferenceNode->Attribute("href") || sellerPartyReferenceNode->Attribute("id"))
      {
          if(sellerPartyReferenceNode->Attribute("id"))
          {
             sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("id");
             sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));
             sellerPartyReference_->setID(sellerPartyReferenceIDRef_);
             IDManager::instance().setID(sellerPartyReferenceIDRef_,sellerPartyReference_);
          }
          else if(sellerPartyReferenceNode->Attribute("href")) { sellerPartyReferenceIDRef_ = sellerPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(sellerPartyReferenceNode));}
   }

   //sellerAccountReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sellerAccountReferenceNode = xmlNode->FirstChildElement("sellerAccountReference");

   if(sellerAccountReferenceNode){sellerAccountReferenceIsNull_ = false;}
   else{sellerAccountReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sellerAccountReferenceNode , address : " << sellerAccountReferenceNode << std::endl;
   #endif
   if(sellerAccountReferenceNode)
   {
      if(sellerAccountReferenceNode->Attribute("href") || sellerAccountReferenceNode->Attribute("id"))
      {
          if(sellerAccountReferenceNode->Attribute("id"))
          {
             sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("id");
             sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));
             sellerAccountReference_->setID(sellerAccountReferenceIDRef_);
             IDManager::instance().setID(sellerAccountReferenceIDRef_,sellerAccountReference_);
          }
          else if(sellerAccountReferenceNode->Attribute("href")) { sellerAccountReferenceIDRef_ = sellerAccountReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sellerAccountReference_ = boost::shared_ptr<AccountReference>(new AccountReference(sellerAccountReferenceNode));}
   }

   //dateAdjustmentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dateAdjustmentsNode = xmlNode->FirstChildElement("dateAdjustments");

   if(dateAdjustmentsNode){dateAdjustmentsIsNull_ = false;}
   else{dateAdjustmentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dateAdjustmentsNode , address : " << dateAdjustmentsNode << std::endl;
   #endif
   if(dateAdjustmentsNode)
   {
      if(dateAdjustmentsNode->Attribute("href") || dateAdjustmentsNode->Attribute("id"))
      {
          if(dateAdjustmentsNode->Attribute("id"))
          {
             dateAdjustmentsIDRef_ = dateAdjustmentsNode->Attribute("id");
             dateAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(dateAdjustmentsNode));
             dateAdjustments_->setID(dateAdjustmentsIDRef_);
             IDManager::instance().setID(dateAdjustmentsIDRef_,dateAdjustments_);
          }
          else if(dateAdjustmentsNode->Attribute("href")) { dateAdjustmentsIDRef_ = dateAdjustmentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dateAdjustments_ = boost::shared_ptr<BusinessDayAdjustments>(new BusinessDayAdjustments(dateAdjustmentsNode));}
   }

   //referenceInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceInformationNode = xmlNode->FirstChildElement("referenceInformation");

   if(referenceInformationNode){referenceInformationIsNull_ = false;}
   else{referenceInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceInformationNode , address : " << referenceInformationNode << std::endl;
   #endif
   if(referenceInformationNode)
   {
      if(referenceInformationNode->Attribute("href") || referenceInformationNode->Attribute("id"))
      {
          if(referenceInformationNode->Attribute("id"))
          {
             referenceInformationIDRef_ = referenceInformationNode->Attribute("id");
             referenceInformation_ = boost::shared_ptr<ReferenceInformation>(new ReferenceInformation(referenceInformationNode));
             referenceInformation_->setID(referenceInformationIDRef_);
             IDManager::instance().setID(referenceInformationIDRef_,referenceInformation_);
          }
          else if(referenceInformationNode->Attribute("href")) { referenceInformationIDRef_ = referenceInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { referenceInformation_ = boost::shared_ptr<ReferenceInformation>(new ReferenceInformation(referenceInformationNode));}
   }

   //indexReferenceInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexReferenceInformationNode = xmlNode->FirstChildElement("indexReferenceInformation");

   if(indexReferenceInformationNode){indexReferenceInformationIsNull_ = false;}
   else{indexReferenceInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexReferenceInformationNode , address : " << indexReferenceInformationNode << std::endl;
   #endif
   if(indexReferenceInformationNode)
   {
      if(indexReferenceInformationNode->Attribute("href") || indexReferenceInformationNode->Attribute("id"))
      {
          if(indexReferenceInformationNode->Attribute("id"))
          {
             indexReferenceInformationIDRef_ = indexReferenceInformationNode->Attribute("id");
             indexReferenceInformation_ = boost::shared_ptr<IndexReferenceInformation>(new IndexReferenceInformation(indexReferenceInformationNode));
             indexReferenceInformation_->setID(indexReferenceInformationIDRef_);
             IDManager::instance().setID(indexReferenceInformationIDRef_,indexReferenceInformation_);
          }
          else if(indexReferenceInformationNode->Attribute("href")) { indexReferenceInformationIDRef_ = indexReferenceInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { indexReferenceInformation_ = boost::shared_ptr<IndexReferenceInformation>(new IndexReferenceInformation(indexReferenceInformationNode));}
   }

   //basketReferenceInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basketReferenceInformationNode = xmlNode->FirstChildElement("basketReferenceInformation");

   if(basketReferenceInformationNode){basketReferenceInformationIsNull_ = false;}
   else{basketReferenceInformationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basketReferenceInformationNode , address : " << basketReferenceInformationNode << std::endl;
   #endif
   if(basketReferenceInformationNode)
   {
      if(basketReferenceInformationNode->Attribute("href") || basketReferenceInformationNode->Attribute("id"))
      {
          if(basketReferenceInformationNode->Attribute("id"))
          {
             basketReferenceInformationIDRef_ = basketReferenceInformationNode->Attribute("id");
             basketReferenceInformation_ = boost::shared_ptr<BasketReferenceInformation>(new BasketReferenceInformation(basketReferenceInformationNode));
             basketReferenceInformation_->setID(basketReferenceInformationIDRef_);
             IDManager::instance().setID(basketReferenceInformationIDRef_,basketReferenceInformation_);
          }
          else if(basketReferenceInformationNode->Attribute("href")) { basketReferenceInformationIDRef_ = basketReferenceInformationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basketReferenceInformation_ = boost::shared_ptr<BasketReferenceInformation>(new BasketReferenceInformation(basketReferenceInformationNode));}
   }

   //additionalTermNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionalTermNode = xmlNode->FirstChildElement("additionalTerm");

   if(additionalTermNode){additionalTermIsNull_ = false;}
   else{additionalTermIsNull_ = true;}

   if(additionalTermNode)
   {
      for(additionalTermNode; additionalTermNode; additionalTermNode = additionalTermNode->NextSiblingElement("additionalTerm")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalTermNode , address : " << additionalTermNode << std::endl;
          #endif
          if(additionalTermNode->Attribute("href") || additionalTermNode->Attribute("id"))
          {
              if(additionalTermNode->Attribute("id"))
              {
                  additionalTermIDRef_ = additionalTermNode->Attribute("id");
                  additionalTerm_.push_back(boost::shared_ptr<AdditionalTerm>(new AdditionalTerm(additionalTermNode)));
                  additionalTerm_.back()->setID(additionalTermIDRef_);
                  IDManager::instance().setID(additionalTermIDRef_, additionalTerm_.back());
              }
              else if(additionalTermNode->Attribute("href")) { additionalTermIDRef_ = additionalTermNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { additionalTerm_.push_back(boost::shared_ptr<AdditionalTerm>(new AdditionalTerm(additionalTermNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionalTermNode , address : " << additionalTermNode << std::endl;
       #endif
   }

   //substitutionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* substitutionNode = xmlNode->FirstChildElement("substitution");

   if(substitutionNode){substitutionIsNull_ = false;}
   else{substitutionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- substitutionNode , address : " << substitutionNode << std::endl;
   #endif
   if(substitutionNode)
   {
      if(substitutionNode->Attribute("href") || substitutionNode->Attribute("id"))
      {
          if(substitutionNode->Attribute("id"))
          {
             substitutionIDRef_ = substitutionNode->Attribute("id");
             substitution_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(substitutionNode));
             substitution_->setID(substitutionIDRef_);
             IDManager::instance().setID(substitutionIDRef_,substitution_);
          }
          else if(substitutionNode->Attribute("href")) { substitutionIDRef_ = substitutionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { substitution_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(substitutionNode));}
   }

   //modifiedEquityDeliveryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* modifiedEquityDeliveryNode = xmlNode->FirstChildElement("modifiedEquityDelivery");

   if(modifiedEquityDeliveryNode){modifiedEquityDeliveryIsNull_ = false;}
   else{modifiedEquityDeliveryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- modifiedEquityDeliveryNode , address : " << modifiedEquityDeliveryNode << std::endl;
   #endif
   if(modifiedEquityDeliveryNode)
   {
      if(modifiedEquityDeliveryNode->Attribute("href") || modifiedEquityDeliveryNode->Attribute("id"))
      {
          if(modifiedEquityDeliveryNode->Attribute("id"))
          {
             modifiedEquityDeliveryIDRef_ = modifiedEquityDeliveryNode->Attribute("id");
             modifiedEquityDelivery_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(modifiedEquityDeliveryNode));
             modifiedEquityDelivery_->setID(modifiedEquityDeliveryIDRef_);
             IDManager::instance().setID(modifiedEquityDeliveryIDRef_,modifiedEquityDelivery_);
          }
          else if(modifiedEquityDeliveryNode->Attribute("href")) { modifiedEquityDeliveryIDRef_ = modifiedEquityDeliveryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { modifiedEquityDelivery_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(modifiedEquityDeliveryNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<AdjustableDate2> GeneralTerms::getEffectiveDate()
{
   if(!this->effectiveDateIsNull_){
        if(effectiveDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate2>(IDManager::instance().getID(effectiveDateIDRef_));
        }else{
             return this->effectiveDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate2>();
   }
}
boost::shared_ptr<AdjustableDate2> GeneralTerms::getScheduledTerminationDate()
{
   if(!this->scheduledTerminationDateIsNull_){
        if(scheduledTerminationDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableDate2>(IDManager::instance().getID(scheduledTerminationDateIDRef_));
        }else{
             return this->scheduledTerminationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableDate2>();
   }
}
boost::shared_ptr<PartyReference> GeneralTerms::getBuyerPartyReference()
{
   if(!this->buyerPartyReferenceIsNull_){
        if(buyerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(buyerPartyReferenceIDRef_));
        }else{
             return this->buyerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> GeneralTerms::getBuyerAccountReference()
{
   if(!this->buyerAccountReferenceIsNull_){
        if(buyerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(buyerAccountReferenceIDRef_));
        }else{
             return this->buyerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<PartyReference> GeneralTerms::getSellerPartyReference()
{
   if(!this->sellerPartyReferenceIsNull_){
        if(sellerPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(sellerPartyReferenceIDRef_));
        }else{
             return this->sellerPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<AccountReference> GeneralTerms::getSellerAccountReference()
{
   if(!this->sellerAccountReferenceIsNull_){
        if(sellerAccountReferenceIDRef_ != ""){
             return boost::shared_static_cast<AccountReference>(IDManager::instance().getID(sellerAccountReferenceIDRef_));
        }else{
             return this->sellerAccountReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AccountReference>();
   }
}
boost::shared_ptr<BusinessDayAdjustments> GeneralTerms::getDateAdjustments()
{
   if(!this->dateAdjustmentsIsNull_){
        if(dateAdjustmentsIDRef_ != ""){
             return boost::shared_static_cast<BusinessDayAdjustments>(IDManager::instance().getID(dateAdjustmentsIDRef_));
        }else{
             return this->dateAdjustments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessDayAdjustments>();
   }
}
boost::shared_ptr<ReferenceInformation> GeneralTerms::getReferenceInformation()
{
   if(!this->referenceInformationIsNull_){
        if(referenceInformationIDRef_ != ""){
             return boost::shared_static_cast<ReferenceInformation>(IDManager::instance().getID(referenceInformationIDRef_));
        }else{
             return this->referenceInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceInformation>();
   }
}
boost::shared_ptr<IndexReferenceInformation> GeneralTerms::getIndexReferenceInformation()
{
   if(!this->indexReferenceInformationIsNull_){
        if(indexReferenceInformationIDRef_ != ""){
             return boost::shared_static_cast<IndexReferenceInformation>(IDManager::instance().getID(indexReferenceInformationIDRef_));
        }else{
             return this->indexReferenceInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IndexReferenceInformation>();
   }
}
boost::shared_ptr<BasketReferenceInformation> GeneralTerms::getBasketReferenceInformation()
{
   if(!this->basketReferenceInformationIsNull_){
        if(basketReferenceInformationIDRef_ != ""){
             return boost::shared_static_cast<BasketReferenceInformation>(IDManager::instance().getID(basketReferenceInformationIDRef_));
        }else{
             return this->basketReferenceInformation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BasketReferenceInformation>();
   }
}
std::vector<boost::shared_ptr<AdditionalTerm>> GeneralTerms::getAdditionalTerm()
{
   if(!this->additionalTermIsNull_){
        if(additionalTermIDRef_ != ""){
             return this->additionalTerm_;
        }else{
             return this->additionalTerm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AdditionalTerm>>();
   }
}
boost::shared_ptr<XsdTypeBoolean> GeneralTerms::getSubstitution()
{
   if(!this->substitutionIsNull_){
        if(substitutionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(substitutionIDRef_));
        }else{
             return this->substitution_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> GeneralTerms::getModifiedEquityDelivery()
{
   if(!this->modifiedEquityDeliveryIsNull_){
        if(modifiedEquityDeliveryIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(modifiedEquityDeliveryIDRef_));
        }else{
             return this->modifiedEquityDelivery_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

