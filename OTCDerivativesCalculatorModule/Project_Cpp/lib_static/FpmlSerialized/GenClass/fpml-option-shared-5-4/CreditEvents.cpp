// CreditEvents.cpp 
#include "CreditEvents.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CreditEvents::CreditEvents(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //bankruptcyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bankruptcyNode = xmlNode->FirstChildElement("bankruptcy");

   if(bankruptcyNode){bankruptcyIsNull_ = false;}
   else{bankruptcyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bankruptcyNode , address : " << bankruptcyNode << std::endl;
   #endif
   if(bankruptcyNode)
   {
      if(bankruptcyNode->Attribute("href") || bankruptcyNode->Attribute("id"))
      {
          if(bankruptcyNode->Attribute("id"))
          {
             bankruptcyIDRef_ = bankruptcyNode->Attribute("id");
             bankruptcy_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(bankruptcyNode));
             bankruptcy_->setID(bankruptcyIDRef_);
             IDManager::instance().setID(bankruptcyIDRef_,bankruptcy_);
          }
          else if(bankruptcyNode->Attribute("href")) { bankruptcyIDRef_ = bankruptcyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bankruptcy_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(bankruptcyNode));}
   }

   //failureToPayNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToPayNode = xmlNode->FirstChildElement("failureToPay");

   if(failureToPayNode){failureToPayIsNull_ = false;}
   else{failureToPayIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToPayNode , address : " << failureToPayNode << std::endl;
   #endif
   if(failureToPayNode)
   {
      if(failureToPayNode->Attribute("href") || failureToPayNode->Attribute("id"))
      {
          if(failureToPayNode->Attribute("id"))
          {
             failureToPayIDRef_ = failureToPayNode->Attribute("id");
             failureToPay_ = boost::shared_ptr<FailureToPay>(new FailureToPay(failureToPayNode));
             failureToPay_->setID(failureToPayIDRef_);
             IDManager::instance().setID(failureToPayIDRef_,failureToPay_);
          }
          else if(failureToPayNode->Attribute("href")) { failureToPayIDRef_ = failureToPayNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToPay_ = boost::shared_ptr<FailureToPay>(new FailureToPay(failureToPayNode));}
   }

   //failureToPayPrincipalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToPayPrincipalNode = xmlNode->FirstChildElement("failureToPayPrincipal");

   if(failureToPayPrincipalNode){failureToPayPrincipalIsNull_ = false;}
   else{failureToPayPrincipalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToPayPrincipalNode , address : " << failureToPayPrincipalNode << std::endl;
   #endif
   if(failureToPayPrincipalNode)
   {
      if(failureToPayPrincipalNode->Attribute("href") || failureToPayPrincipalNode->Attribute("id"))
      {
          if(failureToPayPrincipalNode->Attribute("id"))
          {
             failureToPayPrincipalIDRef_ = failureToPayPrincipalNode->Attribute("id");
             failureToPayPrincipal_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToPayPrincipalNode));
             failureToPayPrincipal_->setID(failureToPayPrincipalIDRef_);
             IDManager::instance().setID(failureToPayPrincipalIDRef_,failureToPayPrincipal_);
          }
          else if(failureToPayPrincipalNode->Attribute("href")) { failureToPayPrincipalIDRef_ = failureToPayPrincipalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToPayPrincipal_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToPayPrincipalNode));}
   }

   //failureToPayInterestNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToPayInterestNode = xmlNode->FirstChildElement("failureToPayInterest");

   if(failureToPayInterestNode){failureToPayInterestIsNull_ = false;}
   else{failureToPayInterestIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToPayInterestNode , address : " << failureToPayInterestNode << std::endl;
   #endif
   if(failureToPayInterestNode)
   {
      if(failureToPayInterestNode->Attribute("href") || failureToPayInterestNode->Attribute("id"))
      {
          if(failureToPayInterestNode->Attribute("id"))
          {
             failureToPayInterestIDRef_ = failureToPayInterestNode->Attribute("id");
             failureToPayInterest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToPayInterestNode));
             failureToPayInterest_->setID(failureToPayInterestIDRef_);
             IDManager::instance().setID(failureToPayInterestIDRef_,failureToPayInterest_);
          }
          else if(failureToPayInterestNode->Attribute("href")) { failureToPayInterestIDRef_ = failureToPayInterestNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToPayInterest_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToPayInterestNode));}
   }

   //obligationDefaultNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationDefaultNode = xmlNode->FirstChildElement("obligationDefault");

   if(obligationDefaultNode){obligationDefaultIsNull_ = false;}
   else{obligationDefaultIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationDefaultNode , address : " << obligationDefaultNode << std::endl;
   #endif
   if(obligationDefaultNode)
   {
      if(obligationDefaultNode->Attribute("href") || obligationDefaultNode->Attribute("id"))
      {
          if(obligationDefaultNode->Attribute("id"))
          {
             obligationDefaultIDRef_ = obligationDefaultNode->Attribute("id");
             obligationDefault_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(obligationDefaultNode));
             obligationDefault_->setID(obligationDefaultIDRef_);
             IDManager::instance().setID(obligationDefaultIDRef_,obligationDefault_);
          }
          else if(obligationDefaultNode->Attribute("href")) { obligationDefaultIDRef_ = obligationDefaultNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { obligationDefault_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(obligationDefaultNode));}
   }

   //obligationAccelerationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* obligationAccelerationNode = xmlNode->FirstChildElement("obligationAcceleration");

   if(obligationAccelerationNode){obligationAccelerationIsNull_ = false;}
   else{obligationAccelerationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- obligationAccelerationNode , address : " << obligationAccelerationNode << std::endl;
   #endif
   if(obligationAccelerationNode)
   {
      if(obligationAccelerationNode->Attribute("href") || obligationAccelerationNode->Attribute("id"))
      {
          if(obligationAccelerationNode->Attribute("id"))
          {
             obligationAccelerationIDRef_ = obligationAccelerationNode->Attribute("id");
             obligationAcceleration_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(obligationAccelerationNode));
             obligationAcceleration_->setID(obligationAccelerationIDRef_);
             IDManager::instance().setID(obligationAccelerationIDRef_,obligationAcceleration_);
          }
          else if(obligationAccelerationNode->Attribute("href")) { obligationAccelerationIDRef_ = obligationAccelerationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { obligationAcceleration_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(obligationAccelerationNode));}
   }

   //repudiationMoratoriumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* repudiationMoratoriumNode = xmlNode->FirstChildElement("repudiationMoratorium");

   if(repudiationMoratoriumNode){repudiationMoratoriumIsNull_ = false;}
   else{repudiationMoratoriumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- repudiationMoratoriumNode , address : " << repudiationMoratoriumNode << std::endl;
   #endif
   if(repudiationMoratoriumNode)
   {
      if(repudiationMoratoriumNode->Attribute("href") || repudiationMoratoriumNode->Attribute("id"))
      {
          if(repudiationMoratoriumNode->Attribute("id"))
          {
             repudiationMoratoriumIDRef_ = repudiationMoratoriumNode->Attribute("id");
             repudiationMoratorium_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(repudiationMoratoriumNode));
             repudiationMoratorium_->setID(repudiationMoratoriumIDRef_);
             IDManager::instance().setID(repudiationMoratoriumIDRef_,repudiationMoratorium_);
          }
          else if(repudiationMoratoriumNode->Attribute("href")) { repudiationMoratoriumIDRef_ = repudiationMoratoriumNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { repudiationMoratorium_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(repudiationMoratoriumNode));}
   }

   //restructuringNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* restructuringNode = xmlNode->FirstChildElement("restructuring");

   if(restructuringNode){restructuringIsNull_ = false;}
   else{restructuringIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- restructuringNode , address : " << restructuringNode << std::endl;
   #endif
   if(restructuringNode)
   {
      if(restructuringNode->Attribute("href") || restructuringNode->Attribute("id"))
      {
          if(restructuringNode->Attribute("id"))
          {
             restructuringIDRef_ = restructuringNode->Attribute("id");
             restructuring_ = boost::shared_ptr<Restructuring>(new Restructuring(restructuringNode));
             restructuring_->setID(restructuringIDRef_);
             IDManager::instance().setID(restructuringIDRef_,restructuring_);
          }
          else if(restructuringNode->Attribute("href")) { restructuringIDRef_ = restructuringNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { restructuring_ = boost::shared_ptr<Restructuring>(new Restructuring(restructuringNode));}
   }

   //distressedRatingsDowngradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* distressedRatingsDowngradeNode = xmlNode->FirstChildElement("distressedRatingsDowngrade");

   if(distressedRatingsDowngradeNode){distressedRatingsDowngradeIsNull_ = false;}
   else{distressedRatingsDowngradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- distressedRatingsDowngradeNode , address : " << distressedRatingsDowngradeNode << std::endl;
   #endif
   if(distressedRatingsDowngradeNode)
   {
      if(distressedRatingsDowngradeNode->Attribute("href") || distressedRatingsDowngradeNode->Attribute("id"))
      {
          if(distressedRatingsDowngradeNode->Attribute("id"))
          {
             distressedRatingsDowngradeIDRef_ = distressedRatingsDowngradeNode->Attribute("id");
             distressedRatingsDowngrade_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(distressedRatingsDowngradeNode));
             distressedRatingsDowngrade_->setID(distressedRatingsDowngradeIDRef_);
             IDManager::instance().setID(distressedRatingsDowngradeIDRef_,distressedRatingsDowngrade_);
          }
          else if(distressedRatingsDowngradeNode->Attribute("href")) { distressedRatingsDowngradeIDRef_ = distressedRatingsDowngradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { distressedRatingsDowngrade_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(distressedRatingsDowngradeNode));}
   }

   //maturityExtensionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maturityExtensionNode = xmlNode->FirstChildElement("maturityExtension");

   if(maturityExtensionNode){maturityExtensionIsNull_ = false;}
   else{maturityExtensionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maturityExtensionNode , address : " << maturityExtensionNode << std::endl;
   #endif
   if(maturityExtensionNode)
   {
      if(maturityExtensionNode->Attribute("href") || maturityExtensionNode->Attribute("id"))
      {
          if(maturityExtensionNode->Attribute("id"))
          {
             maturityExtensionIDRef_ = maturityExtensionNode->Attribute("id");
             maturityExtension_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(maturityExtensionNode));
             maturityExtension_->setID(maturityExtensionIDRef_);
             IDManager::instance().setID(maturityExtensionIDRef_,maturityExtension_);
          }
          else if(maturityExtensionNode->Attribute("href")) { maturityExtensionIDRef_ = maturityExtensionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maturityExtension_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(maturityExtensionNode));}
   }

   //writedownNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* writedownNode = xmlNode->FirstChildElement("writedown");

   if(writedownNode){writedownIsNull_ = false;}
   else{writedownIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- writedownNode , address : " << writedownNode << std::endl;
   #endif
   if(writedownNode)
   {
      if(writedownNode->Attribute("href") || writedownNode->Attribute("id"))
      {
          if(writedownNode->Attribute("id"))
          {
             writedownIDRef_ = writedownNode->Attribute("id");
             writedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writedownNode));
             writedown_->setID(writedownIDRef_);
             IDManager::instance().setID(writedownIDRef_,writedown_);
          }
          else if(writedownNode->Attribute("href")) { writedownIDRef_ = writedownNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { writedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(writedownNode));}
   }

   //impliedWritedownNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* impliedWritedownNode = xmlNode->FirstChildElement("impliedWritedown");

   if(impliedWritedownNode){impliedWritedownIsNull_ = false;}
   else{impliedWritedownIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- impliedWritedownNode , address : " << impliedWritedownNode << std::endl;
   #endif
   if(impliedWritedownNode)
   {
      if(impliedWritedownNode->Attribute("href") || impliedWritedownNode->Attribute("id"))
      {
          if(impliedWritedownNode->Attribute("id"))
          {
             impliedWritedownIDRef_ = impliedWritedownNode->Attribute("id");
             impliedWritedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(impliedWritedownNode));
             impliedWritedown_->setID(impliedWritedownIDRef_);
             IDManager::instance().setID(impliedWritedownIDRef_,impliedWritedown_);
          }
          else if(impliedWritedownNode->Attribute("href")) { impliedWritedownIDRef_ = impliedWritedownNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { impliedWritedown_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(impliedWritedownNode));}
   }

   //defaultRequirementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* defaultRequirementNode = xmlNode->FirstChildElement("defaultRequirement");

   if(defaultRequirementNode){defaultRequirementIsNull_ = false;}
   else{defaultRequirementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- defaultRequirementNode , address : " << defaultRequirementNode << std::endl;
   #endif
   if(defaultRequirementNode)
   {
      if(defaultRequirementNode->Attribute("href") || defaultRequirementNode->Attribute("id"))
      {
          if(defaultRequirementNode->Attribute("id"))
          {
             defaultRequirementIDRef_ = defaultRequirementNode->Attribute("id");
             defaultRequirement_ = boost::shared_ptr<Money>(new Money(defaultRequirementNode));
             defaultRequirement_->setID(defaultRequirementIDRef_);
             IDManager::instance().setID(defaultRequirementIDRef_,defaultRequirement_);
          }
          else if(defaultRequirementNode->Attribute("href")) { defaultRequirementIDRef_ = defaultRequirementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { defaultRequirement_ = boost::shared_ptr<Money>(new Money(defaultRequirementNode));}
   }

   //creditEventNoticeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditEventNoticeNode = xmlNode->FirstChildElement("creditEventNotice");

   if(creditEventNoticeNode){creditEventNoticeIsNull_ = false;}
   else{creditEventNoticeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditEventNoticeNode , address : " << creditEventNoticeNode << std::endl;
   #endif
   if(creditEventNoticeNode)
   {
      if(creditEventNoticeNode->Attribute("href") || creditEventNoticeNode->Attribute("id"))
      {
          if(creditEventNoticeNode->Attribute("id"))
          {
             creditEventNoticeIDRef_ = creditEventNoticeNode->Attribute("id");
             creditEventNotice_ = boost::shared_ptr<CreditEventNotice>(new CreditEventNotice(creditEventNoticeNode));
             creditEventNotice_->setID(creditEventNoticeIDRef_);
             IDManager::instance().setID(creditEventNoticeIDRef_,creditEventNotice_);
          }
          else if(creditEventNoticeNode->Attribute("href")) { creditEventNoticeIDRef_ = creditEventNoticeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { creditEventNotice_ = boost::shared_ptr<CreditEventNotice>(new CreditEventNotice(creditEventNoticeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getBankruptcy()
{
   if(!this->bankruptcyIsNull_){
        if(bankruptcyIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(bankruptcyIDRef_));
        }else{
             return this->bankruptcy_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<FailureToPay> CreditEvents::getFailureToPay()
{
   if(!this->failureToPayIsNull_){
        if(failureToPayIDRef_ != ""){
             return boost::shared_static_cast<FailureToPay>(IDManager::instance().getID(failureToPayIDRef_));
        }else{
             return this->failureToPay_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FailureToPay>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getFailureToPayPrincipal()
{
   if(!this->failureToPayPrincipalIsNull_){
        if(failureToPayPrincipalIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(failureToPayPrincipalIDRef_));
        }else{
             return this->failureToPayPrincipal_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getFailureToPayInterest()
{
   if(!this->failureToPayInterestIsNull_){
        if(failureToPayInterestIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(failureToPayInterestIDRef_));
        }else{
             return this->failureToPayInterest_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getObligationDefault()
{
   if(!this->obligationDefaultIsNull_){
        if(obligationDefaultIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(obligationDefaultIDRef_));
        }else{
             return this->obligationDefault_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getObligationAcceleration()
{
   if(!this->obligationAccelerationIsNull_){
        if(obligationAccelerationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(obligationAccelerationIDRef_));
        }else{
             return this->obligationAcceleration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getRepudiationMoratorium()
{
   if(!this->repudiationMoratoriumIsNull_){
        if(repudiationMoratoriumIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(repudiationMoratoriumIDRef_));
        }else{
             return this->repudiationMoratorium_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Restructuring> CreditEvents::getRestructuring()
{
   if(!this->restructuringIsNull_){
        if(restructuringIDRef_ != ""){
             return boost::shared_static_cast<Restructuring>(IDManager::instance().getID(restructuringIDRef_));
        }else{
             return this->restructuring_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Restructuring>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getDistressedRatingsDowngrade()
{
   if(!this->distressedRatingsDowngradeIsNull_){
        if(distressedRatingsDowngradeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(distressedRatingsDowngradeIDRef_));
        }else{
             return this->distressedRatingsDowngrade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getMaturityExtension()
{
   if(!this->maturityExtensionIsNull_){
        if(maturityExtensionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(maturityExtensionIDRef_));
        }else{
             return this->maturityExtension_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getWritedown()
{
   if(!this->writedownIsNull_){
        if(writedownIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(writedownIDRef_));
        }else{
             return this->writedown_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeBoolean> CreditEvents::getImpliedWritedown()
{
   if(!this->impliedWritedownIsNull_){
        if(impliedWritedownIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(impliedWritedownIDRef_));
        }else{
             return this->impliedWritedown_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<Money> CreditEvents::getDefaultRequirement()
{
   if(!this->defaultRequirementIsNull_){
        if(defaultRequirementIDRef_ != ""){
             return boost::shared_static_cast<Money>(IDManager::instance().getID(defaultRequirementIDRef_));
        }else{
             return this->defaultRequirement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Money>();
   }
}
boost::shared_ptr<CreditEventNotice> CreditEvents::getCreditEventNotice()
{
   if(!this->creditEventNoticeIsNull_){
        if(creditEventNoticeIDRef_ != ""){
             return boost::shared_static_cast<CreditEventNotice>(IDManager::instance().getID(creditEventNoticeIDRef_));
        }else{
             return this->creditEventNotice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditEventNotice>();
   }
}
}

