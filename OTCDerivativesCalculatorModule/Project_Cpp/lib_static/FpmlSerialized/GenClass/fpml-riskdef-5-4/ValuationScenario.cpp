// ValuationScenario.cpp 
#include "ValuationScenario.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ValuationScenario::ValuationScenario(TiXmlNode* xmlNode)
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

   //valuationDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valuationDateNode = xmlNode->FirstChildElement("valuationDate");

   if(valuationDateNode){valuationDateIsNull_ = false;}
   else{valuationDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valuationDateNode , address : " << valuationDateNode << std::endl;
   #endif
   if(valuationDateNode)
   {
      if(valuationDateNode->Attribute("href") || valuationDateNode->Attribute("id"))
      {
          if(valuationDateNode->Attribute("id"))
          {
             valuationDateIDRef_ = valuationDateNode->Attribute("id");
             valuationDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(valuationDateNode));
             valuationDate_->setID(valuationDateIDRef_);
             IDManager::instance().setID(valuationDateIDRef_,valuationDate_);
          }
          else if(valuationDateNode->Attribute("href")) { valuationDateIDRef_ = valuationDateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { valuationDate_ = boost::shared_ptr<IdentifiedDate>(new IdentifiedDate(valuationDateNode));}
   }

   //marketReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* marketReferenceNode = xmlNode->FirstChildElement("marketReference");

   if(marketReferenceNode){marketReferenceIsNull_ = false;}
   else{marketReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- marketReferenceNode , address : " << marketReferenceNode << std::endl;
   #endif
   if(marketReferenceNode)
   {
      if(marketReferenceNode->Attribute("href") || marketReferenceNode->Attribute("id"))
      {
          if(marketReferenceNode->Attribute("id"))
          {
             marketReferenceIDRef_ = marketReferenceNode->Attribute("id");
             marketReference_ = boost::shared_ptr<MarketReference>(new MarketReference(marketReferenceNode));
             marketReference_->setID(marketReferenceIDRef_);
             IDManager::instance().setID(marketReferenceIDRef_,marketReference_);
          }
          else if(marketReferenceNode->Attribute("href")) { marketReferenceIDRef_ = marketReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { marketReference_ = boost::shared_ptr<MarketReference>(new MarketReference(marketReferenceNode));}
   }

   //shiftNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* shiftNode = xmlNode->FirstChildElement("shift");

   if(shiftNode){shiftIsNull_ = false;}
   else{shiftIsNull_ = true;}

   if(shiftNode)
   {
      for(shiftNode; shiftNode; shiftNode = shiftNode->NextSiblingElement("shift")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shiftNode , address : " << shiftNode << std::endl;
          #endif
          if(shiftNode->Attribute("href") || shiftNode->Attribute("id"))
          {
              if(shiftNode->Attribute("id"))
              {
                  shiftIDRef_ = shiftNode->Attribute("id");
                  shift_.push_back(boost::shared_ptr<PricingParameterShift>(new PricingParameterShift(shiftNode)));
                  shift_.back()->setID(shiftIDRef_);
                  IDManager::instance().setID(shiftIDRef_, shift_.back());
              }
              else if(shiftNode->Attribute("href")) { shiftIDRef_ = shiftNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { shift_.push_back(boost::shared_ptr<PricingParameterShift>(new PricingParameterShift(shiftNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shiftNode , address : " << shiftNode << std::endl;
       #endif
   }

   //replacementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* replacementNode = xmlNode->FirstChildElement("replacement");

   if(replacementNode){replacementIsNull_ = false;}
   else{replacementIsNull_ = true;}

   if(replacementNode)
   {
      for(replacementNode; replacementNode; replacementNode = replacementNode->NextSiblingElement("replacement")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- replacementNode , address : " << replacementNode << std::endl;
          #endif
          if(replacementNode->Attribute("href") || replacementNode->Attribute("id"))
          {
              if(replacementNode->Attribute("id"))
              {
                  replacementIDRef_ = replacementNode->Attribute("id");
                  replacement_.push_back(boost::shared_ptr<PricingInputReplacement>(new PricingInputReplacement(replacementNode)));
                  replacement_.back()->setID(replacementIDRef_);
                  IDManager::instance().setID(replacementIDRef_, replacement_.back());
              }
              else if(replacementNode->Attribute("href")) { replacementIDRef_ = replacementNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { replacement_.push_back(boost::shared_ptr<PricingInputReplacement>(new PricingInputReplacement(replacementNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- replacementNode , address : " << replacementNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> ValuationScenario::getName()
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
boost::shared_ptr<IdentifiedDate> ValuationScenario::getValuationDate()
{
   if(!this->valuationDateIsNull_){
        if(valuationDateIDRef_ != ""){
             return boost::shared_static_cast<IdentifiedDate>(IDManager::instance().getID(valuationDateIDRef_));
        }else{
             return this->valuationDate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<IdentifiedDate>();
   }
}
boost::shared_ptr<MarketReference> ValuationScenario::getMarketReference()
{
   if(!this->marketReferenceIsNull_){
        if(marketReferenceIDRef_ != ""){
             return boost::shared_static_cast<MarketReference>(IDManager::instance().getID(marketReferenceIDRef_));
        }else{
             return this->marketReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MarketReference>();
   }
}
std::vector<boost::shared_ptr<PricingParameterShift>> ValuationScenario::getShift()
{
   if(!this->shiftIsNull_){
        if(shiftIDRef_ != ""){
             return this->shift_;
        }else{
             return this->shift_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PricingParameterShift>>();
   }
}
std::vector<boost::shared_ptr<PricingInputReplacement>> ValuationScenario::getReplacement()
{
   if(!this->replacementIsNull_){
        if(replacementIDRef_ != ""){
             return this->replacement_;
        }else{
             return this->replacement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PricingInputReplacement>>();
   }
}
}

