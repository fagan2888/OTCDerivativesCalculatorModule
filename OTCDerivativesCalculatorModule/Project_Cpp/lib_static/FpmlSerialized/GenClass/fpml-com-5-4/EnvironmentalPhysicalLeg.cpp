// EnvironmentalPhysicalLeg.cpp 
#include "EnvironmentalPhysicalLeg.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

EnvironmentalPhysicalLeg::EnvironmentalPhysicalLeg(TiXmlNode* xmlNode)
: PhysicalSwapLeg(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //numberOfAllowancesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* numberOfAllowancesNode = xmlNode->FirstChildElement("numberOfAllowances");

   if(numberOfAllowancesNode){numberOfAllowancesIsNull_ = false;}
   else{numberOfAllowancesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- numberOfAllowancesNode , address : " << numberOfAllowancesNode << std::endl;
   #endif
   if(numberOfAllowancesNode)
   {
      if(numberOfAllowancesNode->Attribute("href") || numberOfAllowancesNode->Attribute("id"))
      {
          if(numberOfAllowancesNode->Attribute("id"))
          {
             numberOfAllowancesIDRef_ = numberOfAllowancesNode->Attribute("id");
             numberOfAllowances_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(numberOfAllowancesNode));
             numberOfAllowances_->setID(numberOfAllowancesIDRef_);
             IDManager::instance().setID(numberOfAllowancesIDRef_,numberOfAllowances_);
          }
          else if(numberOfAllowancesNode->Attribute("href")) { numberOfAllowancesIDRef_ = numberOfAllowancesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { numberOfAllowances_ = boost::shared_ptr<UnitQuantity>(new UnitQuantity(numberOfAllowancesNode));}
   }

   //environmentalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* environmentalNode = xmlNode->FirstChildElement("environmental");

   if(environmentalNode){environmentalIsNull_ = false;}
   else{environmentalIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- environmentalNode , address : " << environmentalNode << std::endl;
   #endif
   if(environmentalNode)
   {
      if(environmentalNode->Attribute("href") || environmentalNode->Attribute("id"))
      {
          if(environmentalNode->Attribute("id"))
          {
             environmentalIDRef_ = environmentalNode->Attribute("id");
             environmental_ = boost::shared_ptr<EnvironmentalProduct>(new EnvironmentalProduct(environmentalNode));
             environmental_->setID(environmentalIDRef_);
             IDManager::instance().setID(environmentalIDRef_,environmental_);
          }
          else if(environmentalNode->Attribute("href")) { environmentalIDRef_ = environmentalNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { environmental_ = boost::shared_ptr<EnvironmentalProduct>(new EnvironmentalProduct(environmentalNode));}
   }

   //abandonmentOfSchemeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* abandonmentOfSchemeNode = xmlNode->FirstChildElement("abandonmentOfScheme");

   if(abandonmentOfSchemeNode){abandonmentOfSchemeIsNull_ = false;}
   else{abandonmentOfSchemeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- abandonmentOfSchemeNode , address : " << abandonmentOfSchemeNode << std::endl;
   #endif
   if(abandonmentOfSchemeNode)
   {
      if(abandonmentOfSchemeNode->Attribute("href") || abandonmentOfSchemeNode->Attribute("id"))
      {
          if(abandonmentOfSchemeNode->Attribute("id"))
          {
             abandonmentOfSchemeIDRef_ = abandonmentOfSchemeNode->Attribute("id");
             abandonmentOfScheme_ = boost::shared_ptr<EnvironmentalAbandonmentOfSchemeEnum>(new EnvironmentalAbandonmentOfSchemeEnum(abandonmentOfSchemeNode));
             abandonmentOfScheme_->setID(abandonmentOfSchemeIDRef_);
             IDManager::instance().setID(abandonmentOfSchemeIDRef_,abandonmentOfScheme_);
          }
          else if(abandonmentOfSchemeNode->Attribute("href")) { abandonmentOfSchemeIDRef_ = abandonmentOfSchemeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { abandonmentOfScheme_ = boost::shared_ptr<EnvironmentalAbandonmentOfSchemeEnum>(new EnvironmentalAbandonmentOfSchemeEnum(abandonmentOfSchemeNode));}
   }

   //deliveryDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* deliveryDateNode = xmlNode->FirstChildElement("deliveryDate");

   if(deliveryDateNode){deliveryDateIsNull_ = false;}
   else{deliveryDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- deliveryDateNode , address : " << deliveryDateNode << std::endl;
   #endif
   if(deliveryDateNode)
   {
      if(deliveryDateNode->Attribute("href") || deliveryDateNode->Attribute("id"))
      {
          if(deliveryDateNode->Attribute("id"))
          {
             deliveryDateIDRef_ = deliveryDateNode->Attribute("id");
             deliveryDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(deliveryDateNode));
             deliveryDate_->setID(deliveryDateIDRef_);
             IDManager::instance().setID(deliveryDateIDRef_,deliveryDate_);
          }
          else if(deliveryDateNode->Attribute("href")) { deliveryDateIDRef_ = deliveryDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { deliveryDate_ = boost::shared_ptr<AdjustableOrRelativeDate>(new AdjustableOrRelativeDate(deliveryDateNode));}
   }

   //paymentDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentDateNode = xmlNode->FirstChildElement("paymentDate");

   if(paymentDateNode){paymentDateIsNull_ = false;}
   else{paymentDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentDateNode , address : " << paymentDateNode << std::endl;
   #endif
   if(paymentDateNode)
   {
      if(paymentDateNode->Attribute("href") || paymentDateNode->Attribute("id"))
      {
          if(paymentDateNode->Attribute("id"))
          {
             paymentDateIDRef_ = paymentDateNode->Attribute("id");
             paymentDate_ = boost::shared_ptr<DateOffset>(new DateOffset(paymentDateNode));
             paymentDate_->setID(paymentDateIDRef_);
             IDManager::instance().setID(paymentDateIDRef_,paymentDate_);
          }
          else if(paymentDateNode->Attribute("href")) { paymentDateIDRef_ = paymentDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentDate_ = boost::shared_ptr<DateOffset>(new DateOffset(paymentDateNode));}
   }

   //businessCentersReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersReferenceNode = xmlNode->FirstChildElement("businessCentersReference");

   if(businessCentersReferenceNode){businessCentersReferenceIsNull_ = false;}
   else{businessCentersReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersReferenceNode , address : " << businessCentersReferenceNode << std::endl;
   #endif
   if(businessCentersReferenceNode)
   {
      if(businessCentersReferenceNode->Attribute("href") || businessCentersReferenceNode->Attribute("id"))
      {
          if(businessCentersReferenceNode->Attribute("id"))
          {
             businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("id");
             businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));
             businessCentersReference_->setID(businessCentersReferenceIDRef_);
             IDManager::instance().setID(businessCentersReferenceIDRef_,businessCentersReference_);
          }
          else if(businessCentersReferenceNode->Attribute("href")) { businessCentersReferenceIDRef_ = businessCentersReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCentersReference_ = boost::shared_ptr<BusinessCentersReference>(new BusinessCentersReference(businessCentersReferenceNode));}
   }

   //businessCentersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCentersNode = xmlNode->FirstChildElement("businessCenters");

   if(businessCentersNode){businessCentersIsNull_ = false;}
   else{businessCentersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCentersNode , address : " << businessCentersNode << std::endl;
   #endif
   if(businessCentersNode)
   {
      if(businessCentersNode->Attribute("href") || businessCentersNode->Attribute("id"))
      {
          if(businessCentersNode->Attribute("id"))
          {
             businessCentersIDRef_ = businessCentersNode->Attribute("id");
             businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));
             businessCenters_->setID(businessCentersIDRef_);
             IDManager::instance().setID(businessCentersIDRef_,businessCenters_);
          }
          else if(businessCentersNode->Attribute("href")) { businessCentersIDRef_ = businessCentersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { businessCenters_ = boost::shared_ptr<BusinessCenters>(new BusinessCenters(businessCentersNode));}
   }

   //failureToDeliverApplicableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* failureToDeliverApplicableNode = xmlNode->FirstChildElement("failureToDeliverApplicable");

   if(failureToDeliverApplicableNode){failureToDeliverApplicableIsNull_ = false;}
   else{failureToDeliverApplicableIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- failureToDeliverApplicableNode , address : " << failureToDeliverApplicableNode << std::endl;
   #endif
   if(failureToDeliverApplicableNode)
   {
      if(failureToDeliverApplicableNode->Attribute("href") || failureToDeliverApplicableNode->Attribute("id"))
      {
          if(failureToDeliverApplicableNode->Attribute("id"))
          {
             failureToDeliverApplicableIDRef_ = failureToDeliverApplicableNode->Attribute("id");
             failureToDeliverApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToDeliverApplicableNode));
             failureToDeliverApplicable_->setID(failureToDeliverApplicableIDRef_);
             IDManager::instance().setID(failureToDeliverApplicableIDRef_,failureToDeliverApplicable_);
          }
          else if(failureToDeliverApplicableNode->Attribute("href")) { failureToDeliverApplicableIDRef_ = failureToDeliverApplicableNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { failureToDeliverApplicable_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(failureToDeliverApplicableNode));}
   }

   //eEPParametersNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* eEPParametersNode = xmlNode->FirstChildElement("eEPParameters");

   if(eEPParametersNode){eEPParametersIsNull_ = false;}
   else{eEPParametersIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- eEPParametersNode , address : " << eEPParametersNode << std::endl;
   #endif
   if(eEPParametersNode)
   {
      if(eEPParametersNode->Attribute("href") || eEPParametersNode->Attribute("id"))
      {
          if(eEPParametersNode->Attribute("id"))
          {
             eEPParametersIDRef_ = eEPParametersNode->Attribute("id");
             eEPParameters_ = boost::shared_ptr<EEPParameters>(new EEPParameters(eEPParametersNode));
             eEPParameters_->setID(eEPParametersIDRef_);
             IDManager::instance().setID(eEPParametersIDRef_,eEPParameters_);
          }
          else if(eEPParametersNode->Attribute("href")) { eEPParametersIDRef_ = eEPParametersNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { eEPParameters_ = boost::shared_ptr<EEPParameters>(new EEPParameters(eEPParametersNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<UnitQuantity> EnvironmentalPhysicalLeg::getNumberOfAllowances()
{
   if(!this->numberOfAllowancesIsNull_){
        if(numberOfAllowancesIDRef_ != ""){
             return boost::shared_static_cast<UnitQuantity>(IDManager::instance().getID(numberOfAllowancesIDRef_));
        }else{
             return this->numberOfAllowances_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<UnitQuantity>();
   }
}
boost::shared_ptr<EnvironmentalProduct> EnvironmentalPhysicalLeg::getEnvironmental()
{
   if(!this->environmentalIsNull_){
        if(environmentalIDRef_ != ""){
             return boost::shared_static_cast<EnvironmentalProduct>(IDManager::instance().getID(environmentalIDRef_));
        }else{
             return this->environmental_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EnvironmentalProduct>();
   }
}
boost::shared_ptr<EnvironmentalAbandonmentOfSchemeEnum> EnvironmentalPhysicalLeg::getAbandonmentOfScheme()
{
   if(!this->abandonmentOfSchemeIsNull_){
        if(abandonmentOfSchemeIDRef_ != ""){
             return boost::shared_static_cast<EnvironmentalAbandonmentOfSchemeEnum>(IDManager::instance().getID(abandonmentOfSchemeIDRef_));
        }else{
             return this->abandonmentOfScheme_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EnvironmentalAbandonmentOfSchemeEnum>();
   }
}
boost::shared_ptr<AdjustableOrRelativeDate> EnvironmentalPhysicalLeg::getDeliveryDate()
{
   if(!this->deliveryDateIsNull_){
        if(deliveryDateIDRef_ != ""){
             return boost::shared_static_cast<AdjustableOrRelativeDate>(IDManager::instance().getID(deliveryDateIDRef_));
        }else{
             return this->deliveryDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdjustableOrRelativeDate>();
   }
}
boost::shared_ptr<DateOffset> EnvironmentalPhysicalLeg::getPaymentDate()
{
   if(!this->paymentDateIsNull_){
        if(paymentDateIDRef_ != ""){
             return boost::shared_static_cast<DateOffset>(IDManager::instance().getID(paymentDateIDRef_));
        }else{
             return this->paymentDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DateOffset>();
   }
}
boost::shared_ptr<BusinessCentersReference> EnvironmentalPhysicalLeg::getBusinessCentersReference()
{
   if(!this->businessCentersReferenceIsNull_){
        if(businessCentersReferenceIDRef_ != ""){
             return boost::shared_static_cast<BusinessCentersReference>(IDManager::instance().getID(businessCentersReferenceIDRef_));
        }else{
             return this->businessCentersReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCentersReference>();
   }
}
boost::shared_ptr<BusinessCenters> EnvironmentalPhysicalLeg::getBusinessCenters()
{
   if(!this->businessCentersIsNull_){
        if(businessCentersIDRef_ != ""){
             return boost::shared_static_cast<BusinessCenters>(IDManager::instance().getID(businessCentersIDRef_));
        }else{
             return this->businessCenters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BusinessCenters>();
   }
}
boost::shared_ptr<XsdTypeBoolean> EnvironmentalPhysicalLeg::getFailureToDeliverApplicable()
{
   if(!this->failureToDeliverApplicableIsNull_){
        if(failureToDeliverApplicableIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(failureToDeliverApplicableIDRef_));
        }else{
             return this->failureToDeliverApplicable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<EEPParameters> EnvironmentalPhysicalLeg::getEEPParameters()
{
   if(!this->eEPParametersIsNull_){
        if(eEPParametersIDRef_ != ""){
             return boost::shared_static_cast<EEPParameters>(IDManager::instance().getID(eEPParametersIDRef_));
        }else{
             return this->eEPParameters_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<EEPParameters>();
   }
}
}

