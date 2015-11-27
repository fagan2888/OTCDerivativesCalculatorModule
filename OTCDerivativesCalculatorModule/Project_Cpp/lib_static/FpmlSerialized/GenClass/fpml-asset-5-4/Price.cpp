// Price.cpp 
#include "Price.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Price::Price(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //commissionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commissionNode = xmlNode->FirstChildElement("commission");

   if(commissionNode){commissionIsNull_ = false;}
   else{commissionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commissionNode , address : " << commissionNode << std::endl;
   #endif
   if(commissionNode)
   {
      if(commissionNode->Attribute("href") || commissionNode->Attribute("id"))
      {
          if(commissionNode->Attribute("id"))
          {
             commissionIDRef_ = commissionNode->Attribute("id");
             commission_ = boost::shared_ptr<Commission>(new Commission(commissionNode));
             commission_->setID(commissionIDRef_);
             IDManager::instance().setID(commissionIDRef_,commission_);
          }
          else if(commissionNode->Attribute("href")) { commissionIDRef_ = commissionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { commission_ = boost::shared_ptr<Commission>(new Commission(commissionNode));}
   }

   //determinationMethodNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* determinationMethodNode = xmlNode->FirstChildElement("determinationMethod");

   if(determinationMethodNode){determinationMethodIsNull_ = false;}
   else{determinationMethodIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- determinationMethodNode , address : " << determinationMethodNode << std::endl;
   #endif
   if(determinationMethodNode)
   {
      if(determinationMethodNode->Attribute("href") || determinationMethodNode->Attribute("id"))
      {
          if(determinationMethodNode->Attribute("id"))
          {
             determinationMethodIDRef_ = determinationMethodNode->Attribute("id");
             determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));
             determinationMethod_->setID(determinationMethodIDRef_);
             IDManager::instance().setID(determinationMethodIDRef_,determinationMethod_);
          }
          else if(determinationMethodNode->Attribute("href")) { determinationMethodIDRef_ = determinationMethodNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { determinationMethod_ = boost::shared_ptr<DeterminationMethod>(new DeterminationMethod(determinationMethodNode));}
   }

   //grossPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* grossPriceNode = xmlNode->FirstChildElement("grossPrice");

   if(grossPriceNode){grossPriceIsNull_ = false;}
   else{grossPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- grossPriceNode , address : " << grossPriceNode << std::endl;
   #endif
   if(grossPriceNode)
   {
      if(grossPriceNode->Attribute("href") || grossPriceNode->Attribute("id"))
      {
          if(grossPriceNode->Attribute("id"))
          {
             grossPriceIDRef_ = grossPriceNode->Attribute("id");
             grossPrice_ = boost::shared_ptr<ActualPrice>(new ActualPrice(grossPriceNode));
             grossPrice_->setID(grossPriceIDRef_);
             IDManager::instance().setID(grossPriceIDRef_,grossPrice_);
          }
          else if(grossPriceNode->Attribute("href")) { grossPriceIDRef_ = grossPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { grossPrice_ = boost::shared_ptr<ActualPrice>(new ActualPrice(grossPriceNode));}
   }

   //netPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* netPriceNode = xmlNode->FirstChildElement("netPrice");

   if(netPriceNode){netPriceIsNull_ = false;}
   else{netPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- netPriceNode , address : " << netPriceNode << std::endl;
   #endif
   if(netPriceNode)
   {
      if(netPriceNode->Attribute("href") || netPriceNode->Attribute("id"))
      {
          if(netPriceNode->Attribute("id"))
          {
             netPriceIDRef_ = netPriceNode->Attribute("id");
             netPrice_ = boost::shared_ptr<ActualPrice>(new ActualPrice(netPriceNode));
             netPrice_->setID(netPriceIDRef_);
             IDManager::instance().setID(netPriceIDRef_,netPrice_);
          }
          else if(netPriceNode->Attribute("href")) { netPriceIDRef_ = netPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { netPrice_ = boost::shared_ptr<ActualPrice>(new ActualPrice(netPriceNode));}
   }

   //accruedInterestPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accruedInterestPriceNode = xmlNode->FirstChildElement("accruedInterestPrice");

   if(accruedInterestPriceNode){accruedInterestPriceIsNull_ = false;}
   else{accruedInterestPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accruedInterestPriceNode , address : " << accruedInterestPriceNode << std::endl;
   #endif
   if(accruedInterestPriceNode)
   {
      if(accruedInterestPriceNode->Attribute("href") || accruedInterestPriceNode->Attribute("id"))
      {
          if(accruedInterestPriceNode->Attribute("id"))
          {
             accruedInterestPriceIDRef_ = accruedInterestPriceNode->Attribute("id");
             accruedInterestPrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(accruedInterestPriceNode));
             accruedInterestPrice_->setID(accruedInterestPriceIDRef_);
             IDManager::instance().setID(accruedInterestPriceIDRef_,accruedInterestPrice_);
          }
          else if(accruedInterestPriceNode->Attribute("href")) { accruedInterestPriceIDRef_ = accruedInterestPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { accruedInterestPrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(accruedInterestPriceNode));}
   }

   //fxConversionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fxConversionNode = xmlNode->FirstChildElement("fxConversion");

   if(fxConversionNode){fxConversionIsNull_ = false;}
   else{fxConversionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fxConversionNode , address : " << fxConversionNode << std::endl;
   #endif
   if(fxConversionNode)
   {
      if(fxConversionNode->Attribute("href") || fxConversionNode->Attribute("id"))
      {
          if(fxConversionNode->Attribute("id"))
          {
             fxConversionIDRef_ = fxConversionNode->Attribute("id");
             fxConversion_ = boost::shared_ptr<FxConversion>(new FxConversion(fxConversionNode));
             fxConversion_->setID(fxConversionIDRef_);
             IDManager::instance().setID(fxConversionIDRef_,fxConversion_);
          }
          else if(fxConversionNode->Attribute("href")) { fxConversionIDRef_ = fxConversionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { fxConversion_ = boost::shared_ptr<FxConversion>(new FxConversion(fxConversionNode));}
   }

   //amountRelativeToNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* amountRelativeToNode = xmlNode->FirstChildElement("amountRelativeTo");

   if(amountRelativeToNode){amountRelativeToIsNull_ = false;}
   else{amountRelativeToIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- amountRelativeToNode , address : " << amountRelativeToNode << std::endl;
   #endif
   if(amountRelativeToNode)
   {
      if(amountRelativeToNode->Attribute("href") || amountRelativeToNode->Attribute("id"))
      {
          if(amountRelativeToNode->Attribute("id"))
          {
             amountRelativeToIDRef_ = amountRelativeToNode->Attribute("id");
             amountRelativeTo_ = boost::shared_ptr<AmountReference>(new AmountReference(amountRelativeToNode));
             amountRelativeTo_->setID(amountRelativeToIDRef_);
             IDManager::instance().setID(amountRelativeToIDRef_,amountRelativeTo_);
          }
          else if(amountRelativeToNode->Attribute("href")) { amountRelativeToIDRef_ = amountRelativeToNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { amountRelativeTo_ = boost::shared_ptr<AmountReference>(new AmountReference(amountRelativeToNode));}
   }

   //cleanNetPriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* cleanNetPriceNode = xmlNode->FirstChildElement("cleanNetPrice");

   if(cleanNetPriceNode){cleanNetPriceIsNull_ = false;}
   else{cleanNetPriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- cleanNetPriceNode , address : " << cleanNetPriceNode << std::endl;
   #endif
   if(cleanNetPriceNode)
   {
      if(cleanNetPriceNode->Attribute("href") || cleanNetPriceNode->Attribute("id"))
      {
          if(cleanNetPriceNode->Attribute("id"))
          {
             cleanNetPriceIDRef_ = cleanNetPriceNode->Attribute("id");
             cleanNetPrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(cleanNetPriceNode));
             cleanNetPrice_->setID(cleanNetPriceIDRef_);
             IDManager::instance().setID(cleanNetPriceIDRef_,cleanNetPrice_);
          }
          else if(cleanNetPriceNode->Attribute("href")) { cleanNetPriceIDRef_ = cleanNetPriceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { cleanNetPrice_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(cleanNetPriceNode));}
   }

   //quotationCharacteristicsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotationCharacteristicsNode = xmlNode->FirstChildElement("quotationCharacteristics");

   if(quotationCharacteristicsNode){quotationCharacteristicsIsNull_ = false;}
   else{quotationCharacteristicsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationCharacteristicsNode , address : " << quotationCharacteristicsNode << std::endl;
   #endif
   if(quotationCharacteristicsNode)
   {
      if(quotationCharacteristicsNode->Attribute("href") || quotationCharacteristicsNode->Attribute("id"))
      {
          if(quotationCharacteristicsNode->Attribute("id"))
          {
             quotationCharacteristicsIDRef_ = quotationCharacteristicsNode->Attribute("id");
             quotationCharacteristics_ = boost::shared_ptr<QuotationCharacteristics>(new QuotationCharacteristics(quotationCharacteristicsNode));
             quotationCharacteristics_->setID(quotationCharacteristicsIDRef_);
             IDManager::instance().setID(quotationCharacteristicsIDRef_,quotationCharacteristics_);
          }
          else if(quotationCharacteristicsNode->Attribute("href")) { quotationCharacteristicsIDRef_ = quotationCharacteristicsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotationCharacteristics_ = boost::shared_ptr<QuotationCharacteristics>(new QuotationCharacteristics(quotationCharacteristicsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Commission> Price::getCommission()
{
   if(!this->commissionIsNull_){
        if(commissionIDRef_ != ""){
             return boost::shared_static_cast<Commission>(IDManager::instance().getID(commissionIDRef_));
        }else{
             return this->commission_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Commission>();
   }
}
boost::shared_ptr<DeterminationMethod> Price::getDeterminationMethod()
{
   if(!this->determinationMethodIsNull_){
        if(determinationMethodIDRef_ != ""){
             return boost::shared_static_cast<DeterminationMethod>(IDManager::instance().getID(determinationMethodIDRef_));
        }else{
             return this->determinationMethod_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DeterminationMethod>();
   }
}
boost::shared_ptr<ActualPrice> Price::getGrossPrice()
{
   if(!this->grossPriceIsNull_){
        if(grossPriceIDRef_ != ""){
             return boost::shared_static_cast<ActualPrice>(IDManager::instance().getID(grossPriceIDRef_));
        }else{
             return this->grossPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ActualPrice>();
   }
}
boost::shared_ptr<ActualPrice> Price::getNetPrice()
{
   if(!this->netPriceIsNull_){
        if(netPriceIDRef_ != ""){
             return boost::shared_static_cast<ActualPrice>(IDManager::instance().getID(netPriceIDRef_));
        }else{
             return this->netPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ActualPrice>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Price::getAccruedInterestPrice()
{
   if(!this->accruedInterestPriceIsNull_){
        if(accruedInterestPriceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(accruedInterestPriceIDRef_));
        }else{
             return this->accruedInterestPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<FxConversion> Price::getFxConversion()
{
   if(!this->fxConversionIsNull_){
        if(fxConversionIDRef_ != ""){
             return boost::shared_static_cast<FxConversion>(IDManager::instance().getID(fxConversionIDRef_));
        }else{
             return this->fxConversion_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FxConversion>();
   }
}
boost::shared_ptr<AmountReference> Price::getAmountRelativeTo()
{
   if(!this->amountRelativeToIsNull_){
        if(amountRelativeToIDRef_ != ""){
             return boost::shared_static_cast<AmountReference>(IDManager::instance().getID(amountRelativeToIDRef_));
        }else{
             return this->amountRelativeTo_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AmountReference>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Price::getCleanNetPrice()
{
   if(!this->cleanNetPriceIsNull_){
        if(cleanNetPriceIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(cleanNetPriceIDRef_));
        }else{
             return this->cleanNetPrice_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<QuotationCharacteristics> Price::getQuotationCharacteristics()
{
   if(!this->quotationCharacteristicsIsNull_){
        if(quotationCharacteristicsIDRef_ != ""){
             return boost::shared_static_cast<QuotationCharacteristics>(IDManager::instance().getID(quotationCharacteristicsIDRef_));
        }else{
             return this->quotationCharacteristics_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotationCharacteristics>();
   }
}
}

