// AdditionalDisruptionEvents.cpp 
#include "AdditionalDisruptionEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdditionalDisruptionEvents::AdditionalDisruptionEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //changeInLawNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* changeInLawNode = xmlNode->FirstChildElement("changeInLaw");

   if(changeInLawNode){changeInLawIsNull_ = false;}
   else{changeInLawIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- changeInLawNode , address : " << changeInLawNode << std::endl;
   #endif
   if(changeInLawNode)
   {
      if(changeInLawNode->Attribute("href") || changeInLawNode->Attribute("id"))
      {
          if(changeInLawNode->Attribute("id"))
          {
             changeInLawIDRef_ = changeInLawNode->Attribute("id");
             changeInLaw_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(changeInLawNode));
             changeInLaw_->setID(changeInLawIDRef_);
             IDManager::instance().setID(changeInLawIDRef_,changeInLaw_);
          }
          else if(changeInLawNode->Attribute("href")) { changeInLawIDRef_ = changeInLawNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { changeInLaw_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(changeInLawNode));}
   }

   //failureToDeliverNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToDeliverNode = xmlNode->FirstChildElement("failureToDeliver");

   if(failureToDeliverNode){failureToDeliverIsNull_ = false;}
   else{failureToDeliverIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToDeliverNode , address : " << failureToDeliverNode << std::endl;
   #endif
   if(failureToDeliverNode)
   {
      if(failureToDeliverNode->Attribute("href") || failureToDeliverNode->Attribute("id"))
      {
          if(failureToDeliverNode->Attribute("id"))
          {
             failureToDeliverIDRef_ = failureToDeliverNode->Attribute("id");
             failureToDeliver_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToDeliverNode));
             failureToDeliver_->setID(failureToDeliverIDRef_);
             IDManager::instance().setID(failureToDeliverIDRef_,failureToDeliver_);
          }
          else if(failureToDeliverNode->Attribute("href")) { failureToDeliverIDRef_ = failureToDeliverNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToDeliver_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToDeliverNode));}
   }

   //insolvencyFilingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* insolvencyFilingNode = xmlNode->FirstChildElement("insolvencyFiling");

   if(insolvencyFilingNode){insolvencyFilingIsNull_ = false;}
   else{insolvencyFilingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- insolvencyFilingNode , address : " << insolvencyFilingNode << std::endl;
   #endif
   if(insolvencyFilingNode)
   {
      if(insolvencyFilingNode->Attribute("href") || insolvencyFilingNode->Attribute("id"))
      {
          if(insolvencyFilingNode->Attribute("id"))
          {
             insolvencyFilingIDRef_ = insolvencyFilingNode->Attribute("id");
             insolvencyFiling_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(insolvencyFilingNode));
             insolvencyFiling_->setID(insolvencyFilingIDRef_);
             IDManager::instance().setID(insolvencyFilingIDRef_,insolvencyFiling_);
          }
          else if(insolvencyFilingNode->Attribute("href")) { insolvencyFilingIDRef_ = insolvencyFilingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { insolvencyFiling_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(insolvencyFilingNode));}
   }

   //hedgingDisruptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hedgingDisruptionNode = xmlNode->FirstChildElement("hedgingDisruption");

   if(hedgingDisruptionNode){hedgingDisruptionIsNull_ = false;}
   else{hedgingDisruptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hedgingDisruptionNode , address : " << hedgingDisruptionNode << std::endl;
   #endif
   if(hedgingDisruptionNode)
   {
      if(hedgingDisruptionNode->Attribute("href") || hedgingDisruptionNode->Attribute("id"))
      {
          if(hedgingDisruptionNode->Attribute("id"))
          {
             hedgingDisruptionIDRef_ = hedgingDisruptionNode->Attribute("id");
             hedgingDisruption_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(hedgingDisruptionNode));
             hedgingDisruption_->setID(hedgingDisruptionIDRef_);
             IDManager::instance().setID(hedgingDisruptionIDRef_,hedgingDisruption_);
          }
          else if(hedgingDisruptionNode->Attribute("href")) { hedgingDisruptionIDRef_ = hedgingDisruptionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { hedgingDisruption_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(hedgingDisruptionNode));}
   }

   //lossOfStockBorrowNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lossOfStockBorrowNode = xmlNode->FirstChildElement("lossOfStockBorrow");

   if(lossOfStockBorrowNode){lossOfStockBorrowIsNull_ = false;}
   else{lossOfStockBorrowIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lossOfStockBorrowNode , address : " << lossOfStockBorrowNode << std::endl;
   #endif
   if(lossOfStockBorrowNode)
   {
      if(lossOfStockBorrowNode->Attribute("href") || lossOfStockBorrowNode->Attribute("id"))
      {
          if(lossOfStockBorrowNode->Attribute("id"))
          {
             lossOfStockBorrowIDRef_ = lossOfStockBorrowNode->Attribute("id");
             lossOfStockBorrow_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(lossOfStockBorrowNode));
             lossOfStockBorrow_->setID(lossOfStockBorrowIDRef_);
             IDManager::instance().setID(lossOfStockBorrowIDRef_,lossOfStockBorrow_);
          }
          else if(lossOfStockBorrowNode->Attribute("href")) { lossOfStockBorrowIDRef_ = lossOfStockBorrowNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lossOfStockBorrow_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(lossOfStockBorrowNode));}
   }

   //maximumStockLoanRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumStockLoanRateNode = xmlNode->FirstChildElement("maximumStockLoanRate");

   if(maximumStockLoanRateNode){maximumStockLoanRateIsNull_ = false;}
   else{maximumStockLoanRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumStockLoanRateNode , address : " << maximumStockLoanRateNode << std::endl;
   #endif
   if(maximumStockLoanRateNode)
   {
      if(maximumStockLoanRateNode->Attribute("href") || maximumStockLoanRateNode->Attribute("id"))
      {
          if(maximumStockLoanRateNode->Attribute("id"))
          {
             maximumStockLoanRateIDRef_ = maximumStockLoanRateNode->Attribute("id");
             maximumStockLoanRate_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(maximumStockLoanRateNode));
             maximumStockLoanRate_->setID(maximumStockLoanRateIDRef_);
             IDManager::instance().setID(maximumStockLoanRateIDRef_,maximumStockLoanRate_);
          }
          else if(maximumStockLoanRateNode->Attribute("href")) { maximumStockLoanRateIDRef_ = maximumStockLoanRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumStockLoanRate_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(maximumStockLoanRateNode));}
   }

   //increasedCostOfStockBorrowNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* increasedCostOfStockBorrowNode = xmlNode->FirstChildElement("increasedCostOfStockBorrow");

   if(increasedCostOfStockBorrowNode){increasedCostOfStockBorrowIsNull_ = false;}
   else{increasedCostOfStockBorrowIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- increasedCostOfStockBorrowNode , address : " << increasedCostOfStockBorrowNode << std::endl;
   #endif
   if(increasedCostOfStockBorrowNode)
   {
      if(increasedCostOfStockBorrowNode->Attribute("href") || increasedCostOfStockBorrowNode->Attribute("id"))
      {
          if(increasedCostOfStockBorrowNode->Attribute("id"))
          {
             increasedCostOfStockBorrowIDRef_ = increasedCostOfStockBorrowNode->Attribute("id");
             increasedCostOfStockBorrow_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(increasedCostOfStockBorrowNode));
             increasedCostOfStockBorrow_->setID(increasedCostOfStockBorrowIDRef_);
             IDManager::instance().setID(increasedCostOfStockBorrowIDRef_,increasedCostOfStockBorrow_);
          }
          else if(increasedCostOfStockBorrowNode->Attribute("href")) { increasedCostOfStockBorrowIDRef_ = increasedCostOfStockBorrowNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { increasedCostOfStockBorrow_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(increasedCostOfStockBorrowNode));}
   }

   //initialStockLoanRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialStockLoanRateNode = xmlNode->FirstChildElement("initialStockLoanRate");

   if(initialStockLoanRateNode){initialStockLoanRateIsNull_ = false;}
   else{initialStockLoanRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialStockLoanRateNode , address : " << initialStockLoanRateNode << std::endl;
   #endif
   if(initialStockLoanRateNode)
   {
      if(initialStockLoanRateNode->Attribute("href") || initialStockLoanRateNode->Attribute("id"))
      {
          if(initialStockLoanRateNode->Attribute("id"))
          {
             initialStockLoanRateIDRef_ = initialStockLoanRateNode->Attribute("id");
             initialStockLoanRate_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(initialStockLoanRateNode));
             initialStockLoanRate_->setID(initialStockLoanRateIDRef_);
             IDManager::instance().setID(initialStockLoanRateIDRef_,initialStockLoanRate_);
          }
          else if(initialStockLoanRateNode->Attribute("href")) { initialStockLoanRateIDRef_ = initialStockLoanRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialStockLoanRate_ = boost::shared_ptr<RestrictedPercentage>(new RestrictedPercentage(initialStockLoanRateNode));}
   }

   //increasedCostOfHedgingNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* increasedCostOfHedgingNode = xmlNode->FirstChildElement("increasedCostOfHedging");

   if(increasedCostOfHedgingNode){increasedCostOfHedgingIsNull_ = false;}
   else{increasedCostOfHedgingIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- increasedCostOfHedgingNode , address : " << increasedCostOfHedgingNode << std::endl;
   #endif
   if(increasedCostOfHedgingNode)
   {
      if(increasedCostOfHedgingNode->Attribute("href") || increasedCostOfHedgingNode->Attribute("id"))
      {
          if(increasedCostOfHedgingNode->Attribute("id"))
          {
             increasedCostOfHedgingIDRef_ = increasedCostOfHedgingNode->Attribute("id");
             increasedCostOfHedging_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(increasedCostOfHedgingNode));
             increasedCostOfHedging_->setID(increasedCostOfHedgingIDRef_);
             IDManager::instance().setID(increasedCostOfHedgingIDRef_,increasedCostOfHedging_);
          }
          else if(increasedCostOfHedgingNode->Attribute("href")) { increasedCostOfHedgingIDRef_ = increasedCostOfHedgingNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { increasedCostOfHedging_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(increasedCostOfHedgingNode));}
   }

   //determiningPartyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determiningPartyReferenceNode = xmlNode->FirstChildElement("determiningPartyReference");

   if(determiningPartyReferenceNode){determiningPartyReferenceIsNull_ = false;}
   else{determiningPartyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determiningPartyReferenceNode , address : " << determiningPartyReferenceNode << std::endl;
   #endif
   if(determiningPartyReferenceNode)
   {
      if(determiningPartyReferenceNode->Attribute("href") || determiningPartyReferenceNode->Attribute("id"))
      {
          if(determiningPartyReferenceNode->Attribute("id"))
          {
             determiningPartyReferenceIDRef_ = determiningPartyReferenceNode->Attribute("id");
             determiningPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(determiningPartyReferenceNode));
             determiningPartyReference_->setID(determiningPartyReferenceIDRef_);
             IDManager::instance().setID(determiningPartyReferenceIDRef_,determiningPartyReference_);
          }
          else if(determiningPartyReferenceNode->Attribute("href")) { determiningPartyReferenceIDRef_ = determiningPartyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { determiningPartyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(determiningPartyReferenceNode));}
   }

   //foreignOwnershipEventNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* foreignOwnershipEventNode = xmlNode->FirstChildElement("foreignOwnershipEvent");

   if(foreignOwnershipEventNode){foreignOwnershipEventIsNull_ = false;}
   else{foreignOwnershipEventIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- foreignOwnershipEventNode , address : " << foreignOwnershipEventNode << std::endl;
   #endif
   if(foreignOwnershipEventNode)
   {
      if(foreignOwnershipEventNode->Attribute("href") || foreignOwnershipEventNode->Attribute("id"))
      {
          if(foreignOwnershipEventNode->Attribute("id"))
          {
             foreignOwnershipEventIDRef_ = foreignOwnershipEventNode->Attribute("id");
             foreignOwnershipEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(foreignOwnershipEventNode));
             foreignOwnershipEvent_->setID(foreignOwnershipEventIDRef_);
             IDManager::instance().setID(foreignOwnershipEventIDRef_,foreignOwnershipEvent_);
          }
          else if(foreignOwnershipEventNode->Attribute("href")) { foreignOwnershipEventIDRef_ = foreignOwnershipEventNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { foreignOwnershipEvent_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(foreignOwnershipEventNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getChangeInLaw()
{
   if(!this->changeInLawIsNull_){
        if(changeInLawIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(changeInLawIDRef_));
        }else{
             return this->changeInLaw_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getFailureToDeliver()
{
   if(!this->failureToDeliverIsNull_){
        if(failureToDeliverIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(failureToDeliverIDRef_));
        }else{
             return this->failureToDeliver_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getInsolvencyFiling()
{
   if(!this->insolvencyFilingIsNull_){
        if(insolvencyFilingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(insolvencyFilingIDRef_));
        }else{
             return this->insolvencyFiling_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getHedgingDisruption()
{
   if(!this->hedgingDisruptionIsNull_){
        if(hedgingDisruptionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(hedgingDisruptionIDRef_));
        }else{
             return this->hedgingDisruption_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getLossOfStockBorrow()
{
   if(!this->lossOfStockBorrowIsNull_){
        if(lossOfStockBorrowIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(lossOfStockBorrowIDRef_));
        }else{
             return this->lossOfStockBorrow_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<RestrictedPercentage> AdditionalDisruptionEvents::getMaximumStockLoanRate()
{
   if(!this->maximumStockLoanRateIsNull_){
        if(maximumStockLoanRateIDRef_ != ""){
             return boost::shared_static_cast<RestrictedPercentage>(IDManager::instance().getID(maximumStockLoanRateIDRef_));
        }else{
             return this->maximumStockLoanRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestrictedPercentage>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getIncreasedCostOfStockBorrow()
{
   if(!this->increasedCostOfStockBorrowIsNull_){
        if(increasedCostOfStockBorrowIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(increasedCostOfStockBorrowIDRef_));
        }else{
             return this->increasedCostOfStockBorrow_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<RestrictedPercentage> AdditionalDisruptionEvents::getInitialStockLoanRate()
{
   if(!this->initialStockLoanRateIsNull_){
        if(initialStockLoanRateIDRef_ != ""){
             return boost::shared_static_cast<RestrictedPercentage>(IDManager::instance().getID(initialStockLoanRateIDRef_));
        }else{
             return this->initialStockLoanRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RestrictedPercentage>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getIncreasedCostOfHedging()
{
   if(!this->increasedCostOfHedgingIsNull_){
        if(increasedCostOfHedgingIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(increasedCostOfHedgingIDRef_));
        }else{
             return this->increasedCostOfHedging_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<PartyReference> AdditionalDisruptionEvents::getDeterminingPartyReference()
{
   if(!this->determiningPartyReferenceIsNull_){
        if(determiningPartyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(determiningPartyReferenceIDRef_));
        }else{
             return this->determiningPartyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
boost::shared_ptr<XsdTypeBoolean> AdditionalDisruptionEvents::getForeignOwnershipEvent()
{
   if(!this->foreignOwnershipEventIsNull_){
        if(foreignOwnershipEventIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(foreignOwnershipEventIDRef_));
        }else{
             return this->foreignOwnershipEvent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

