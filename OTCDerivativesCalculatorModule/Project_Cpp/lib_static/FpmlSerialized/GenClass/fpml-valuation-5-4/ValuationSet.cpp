// ValuationSet.cpp 
#include "ValuationSet.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ValuationSet::ValuationSet(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(nameNode));}
   }

   //valuationScenarioNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationScenarioNode = xmlNode->FirstChildElement("valuationScenario");

   if(valuationScenarioNode){valuationScenarioIsNull_ = false;}
   else{valuationScenarioIsNull_ = true;}

   if(valuationScenarioNode)
   {
      for(valuationScenarioNode; valuationScenarioNode; valuationScenarioNode = valuationScenarioNode->NextSiblingElement("valuationScenario")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationScenarioNode , address : " << valuationScenarioNode << std::endl;
          #endif
          if(valuationScenarioNode->Attribute("href") || valuationScenarioNode->Attribute("id"))
          {
              if(valuationScenarioNode->Attribute("id"))
              {
                  valuationScenarioIDRef_ = valuationScenarioNode->Attribute("id");
                  valuationScenario_.push_back(boost::shared_ptr<ValuationScenario>(new ValuationScenario(valuationScenarioNode)));
                  valuationScenario_.back()->setID(valuationScenarioIDRef_);
                  IDManager::instance().setID(valuationScenarioIDRef_, valuationScenario_.back());
              }
              else if(valuationScenarioNode->Attribute("href")) { valuationScenarioIDRef_ = valuationScenarioNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { valuationScenario_.push_back(boost::shared_ptr<ValuationScenario>(new ValuationScenario(valuationScenarioNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationScenarioNode , address : " << valuationScenarioNode << std::endl;
       #endif
   }

   //valuationScenarioReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationScenarioReferenceNode = xmlNode->FirstChildElement("valuationScenarioReference");

   if(valuationScenarioReferenceNode){valuationScenarioReferenceIsNull_ = false;}
   else{valuationScenarioReferenceIsNull_ = true;}

   if(valuationScenarioReferenceNode)
   {
      for(valuationScenarioReferenceNode; valuationScenarioReferenceNode; valuationScenarioReferenceNode = valuationScenarioReferenceNode->NextSiblingElement("valuationScenarioReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationScenarioReferenceNode , address : " << valuationScenarioReferenceNode << std::endl;
          #endif
          if(valuationScenarioReferenceNode->Attribute("href") || valuationScenarioReferenceNode->Attribute("id"))
          {
              if(valuationScenarioReferenceNode->Attribute("id"))
              {
                  valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode->Attribute("id");
                  valuationScenarioReference_.push_back(boost::shared_ptr<ValuationScenarioReference>(new ValuationScenarioReference(valuationScenarioReferenceNode)));
                  valuationScenarioReference_.back()->setID(valuationScenarioReferenceIDRef_);
                  IDManager::instance().setID(valuationScenarioReferenceIDRef_, valuationScenarioReference_.back());
              }
              else if(valuationScenarioReferenceNode->Attribute("href")) { valuationScenarioReferenceIDRef_ = valuationScenarioReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { valuationScenarioReference_.push_back(boost::shared_ptr<ValuationScenarioReference>(new ValuationScenarioReference(valuationScenarioReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationScenarioReferenceNode , address : " << valuationScenarioReferenceNode << std::endl;
       #endif
   }

   //basePartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basePartyNode = xmlNode->FirstChildElement("baseParty");

   if(basePartyNode){basePartyIsNull_ = false;}
   else{basePartyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basePartyNode , address : " << basePartyNode << std::endl;
   #endif
   if(basePartyNode)
   {
      if(basePartyNode->Attribute("href") || basePartyNode->Attribute("id"))
      {
          if(basePartyNode->Attribute("id"))
          {
             basePartyIDRef_ = basePartyNode->Attribute("id");
             baseParty_ = boost::shared_ptr<PartyReference>(new PartyReference(basePartyNode));
             baseParty_->setID(basePartyIDRef_);
             IDManager::instance().setID(basePartyIDRef_,baseParty_);
          }
          else if(basePartyNode->Attribute("href")) { basePartyIDRef_ = basePartyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseParty_ = boost::shared_ptr<PartyReference>(new PartyReference(basePartyNode));}
   }

   //quotationCharacteristicsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotationCharacteristicsNode = xmlNode->FirstChildElement("quotationCharacteristics");

   if(quotationCharacteristicsNode){quotationCharacteristicsIsNull_ = false;}
   else{quotationCharacteristicsIsNull_ = true;}

   if(quotationCharacteristicsNode)
   {
      for(quotationCharacteristicsNode; quotationCharacteristicsNode; quotationCharacteristicsNode = quotationCharacteristicsNode->NextSiblingElement("quotationCharacteristics")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationCharacteristicsNode , address : " << quotationCharacteristicsNode << std::endl;
          #endif
          if(quotationCharacteristicsNode->Attribute("href") || quotationCharacteristicsNode->Attribute("id"))
          {
              if(quotationCharacteristicsNode->Attribute("id"))
              {
                  quotationCharacteristicsIDRef_ = quotationCharacteristicsNode->Attribute("id");
                  quotationCharacteristics_.push_back(boost::shared_ptr<QuotationCharacteristics>(new QuotationCharacteristics(quotationCharacteristicsNode)));
                  quotationCharacteristics_.back()->setID(quotationCharacteristicsIDRef_);
                  IDManager::instance().setID(quotationCharacteristicsIDRef_, quotationCharacteristics_.back());
              }
              else if(quotationCharacteristicsNode->Attribute("href")) { quotationCharacteristicsIDRef_ = quotationCharacteristicsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { quotationCharacteristics_.push_back(boost::shared_ptr<QuotationCharacteristics>(new QuotationCharacteristics(quotationCharacteristicsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotationCharacteristicsNode , address : " << quotationCharacteristicsNode << std::endl;
       #endif
   }

   //sensitivitySetDefinitionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sensitivitySetDefinitionNode = xmlNode->FirstChildElement("sensitivitySetDefinition");

   if(sensitivitySetDefinitionNode){sensitivitySetDefinitionIsNull_ = false;}
   else{sensitivitySetDefinitionIsNull_ = true;}

   if(sensitivitySetDefinitionNode)
   {
      for(sensitivitySetDefinitionNode; sensitivitySetDefinitionNode; sensitivitySetDefinitionNode = sensitivitySetDefinitionNode->NextSiblingElement("sensitivitySetDefinition")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sensitivitySetDefinitionNode , address : " << sensitivitySetDefinitionNode << std::endl;
          #endif
          if(sensitivitySetDefinitionNode->Attribute("href") || sensitivitySetDefinitionNode->Attribute("id"))
          {
              if(sensitivitySetDefinitionNode->Attribute("id"))
              {
                  sensitivitySetDefinitionIDRef_ = sensitivitySetDefinitionNode->Attribute("id");
                  sensitivitySetDefinition_.push_back(boost::shared_ptr<SensitivitySetDefinition>(new SensitivitySetDefinition(sensitivitySetDefinitionNode)));
                  sensitivitySetDefinition_.back()->setID(sensitivitySetDefinitionIDRef_);
                  IDManager::instance().setID(sensitivitySetDefinitionIDRef_, sensitivitySetDefinition_.back());
              }
              else if(sensitivitySetDefinitionNode->Attribute("href")) { sensitivitySetDefinitionIDRef_ = sensitivitySetDefinitionNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { sensitivitySetDefinition_.push_back(boost::shared_ptr<SensitivitySetDefinition>(new SensitivitySetDefinition(sensitivitySetDefinitionNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sensitivitySetDefinitionNode , address : " << sensitivitySetDefinitionNode << std::endl;
       #endif
   }

   //detailNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* detailNode = xmlNode->FirstChildElement("detail");

   if(detailNode){detailIsNull_ = false;}
   else{detailIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- detailNode , address : " << detailNode << std::endl;
   #endif
   if(detailNode)
   {
      if(detailNode->Attribute("href") || detailNode->Attribute("id"))
      {
          if(detailNode->Attribute("id"))
          {
             detailIDRef_ = detailNode->Attribute("id");
             detail_ = boost::shared_ptr<ValuationSetDetail>(new ValuationSetDetail(detailNode));
             detail_->setID(detailIDRef_);
             IDManager::instance().setID(detailIDRef_,detail_);
          }
          else if(detailNode->Attribute("href")) { detailIDRef_ = detailNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { detail_ = boost::shared_ptr<ValuationSetDetail>(new ValuationSetDetail(detailNode));}
   }

   //assetValuationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* assetValuationNode = xmlNode->FirstChildElement("assetValuation");

   if(assetValuationNode){assetValuationIsNull_ = false;}
   else{assetValuationIsNull_ = true;}

   if(assetValuationNode)
   {
      for(assetValuationNode; assetValuationNode; assetValuationNode = assetValuationNode->NextSiblingElement("assetValuation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assetValuationNode , address : " << assetValuationNode << std::endl;
          #endif
          if(assetValuationNode->Attribute("href") || assetValuationNode->Attribute("id"))
          {
              if(assetValuationNode->Attribute("id"))
              {
                  assetValuationIDRef_ = assetValuationNode->Attribute("id");
                  assetValuation_.push_back(boost::shared_ptr<AssetValuation>(new AssetValuation(assetValuationNode)));
                  assetValuation_.back()->setID(assetValuationIDRef_);
                  IDManager::instance().setID(assetValuationIDRef_, assetValuation_.back());
              }
              else if(assetValuationNode->Attribute("href")) { assetValuationIDRef_ = assetValuationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { assetValuation_.push_back(boost::shared_ptr<AssetValuation>(new AssetValuation(assetValuationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- assetValuationNode , address : " << assetValuationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> ValuationSet::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
std::vector<boost::shared_ptr<ValuationScenario>> ValuationSet::getValuationScenario()
{
   if(!this->valuationScenarioIsNull_){
        if(valuationScenarioIDRef_ != ""){
             return this->valuationScenario_;
        }else{
             return this->valuationScenario_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ValuationScenario>>();
   }
}
std::vector<boost::shared_ptr<ValuationScenarioReference>> ValuationSet::getValuationScenarioReference()
{
   if(!this->valuationScenarioReferenceIsNull_){
        if(valuationScenarioReferenceIDRef_ != ""){
             return this->valuationScenarioReference_;
        }else{
             return this->valuationScenarioReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ValuationScenarioReference>>();
   }
}
boost::shared_ptr<PartyReference> ValuationSet::getBaseParty()
{
   if(!this->basePartyIsNull_){
        if(basePartyIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(basePartyIDRef_));
        }else{
             return this->baseParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
std::vector<boost::shared_ptr<QuotationCharacteristics>> ValuationSet::getQuotationCharacteristics()
{
   if(!this->quotationCharacteristicsIsNull_){
        if(quotationCharacteristicsIDRef_ != ""){
             return this->quotationCharacteristics_;
        }else{
             return this->quotationCharacteristics_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<QuotationCharacteristics>>();
   }
}
std::vector<boost::shared_ptr<SensitivitySetDefinition>> ValuationSet::getSensitivitySetDefinition()
{
   if(!this->sensitivitySetDefinitionIsNull_){
        if(sensitivitySetDefinitionIDRef_ != ""){
             return this->sensitivitySetDefinition_;
        }else{
             return this->sensitivitySetDefinition_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SensitivitySetDefinition>>();
   }
}
boost::shared_ptr<ValuationSetDetail> ValuationSet::getDetail()
{
   if(!this->detailIsNull_){
        if(detailIDRef_ != ""){
             return boost::shared_static_cast<ValuationSetDetail>(IDManager::instance().getID(detailIDRef_));
        }else{
             return this->detail_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ValuationSetDetail>();
   }
}
std::vector<boost::shared_ptr<AssetValuation>> ValuationSet::getAssetValuation()
{
   if(!this->assetValuationIsNull_){
        if(assetValuationIDRef_ != ""){
             return this->assetValuation_;
        }else{
             return this->assetValuation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<AssetValuation>>();
   }
}
}

