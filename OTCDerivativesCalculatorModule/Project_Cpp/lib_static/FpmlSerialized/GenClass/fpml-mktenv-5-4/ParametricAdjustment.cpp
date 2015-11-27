// ParametricAdjustment.cpp 
#include "ParametricAdjustment.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ParametricAdjustment::ParametricAdjustment(TiXmlNode* xmlNode)
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
             name_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(nameNode));}
   }

   //inputUnitsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* inputUnitsNode = xmlNode->FirstChildElement("inputUnits");

   if(inputUnitsNode){inputUnitsIsNull_ = false;}
   else{inputUnitsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- inputUnitsNode , address : " << inputUnitsNode << std::endl;
   #endif
   if(inputUnitsNode)
   {
      if(inputUnitsNode->Attribute("href") || inputUnitsNode->Attribute("id"))
      {
          if(inputUnitsNode->Attribute("id"))
          {
             inputUnitsIDRef_ = inputUnitsNode->Attribute("id");
             inputUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(inputUnitsNode));
             inputUnits_->setID(inputUnitsIDRef_);
             IDManager::instance().setID(inputUnitsIDRef_,inputUnits_);
          }
          else if(inputUnitsNode->Attribute("href")) { inputUnitsIDRef_ = inputUnitsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { inputUnits_ = boost::shared_ptr<PriceQuoteUnits>(new PriceQuoteUnits(inputUnitsNode));}
   }

   //datapointNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* datapointNode = xmlNode->FirstChildElement("datapoint");

   if(datapointNode){datapointIsNull_ = false;}
   else{datapointIsNull_ = true;}

   if(datapointNode)
   {
      for(datapointNode; datapointNode; datapointNode = datapointNode->NextSiblingElement("datapoint")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- datapointNode , address : " << datapointNode << std::endl;
          #endif
          if(datapointNode->Attribute("href") || datapointNode->Attribute("id"))
          {
              if(datapointNode->Attribute("id"))
              {
                  datapointIDRef_ = datapointNode->Attribute("id");
                  datapoint_.push_back(boost::shared_ptr<ParametricAdjustmentPoint>(new ParametricAdjustmentPoint(datapointNode)));
                  datapoint_.back()->setID(datapointIDRef_);
                  IDManager::instance().setID(datapointIDRef_, datapoint_.back());
              }
              else if(datapointNode->Attribute("href")) { datapointIDRef_ = datapointNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { datapoint_.push_back(boost::shared_ptr<ParametricAdjustmentPoint>(new ParametricAdjustmentPoint(datapointNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- datapointNode , address : " << datapointNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeNormalizedString> ParametricAdjustment::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<PriceQuoteUnits> ParametricAdjustment::getInputUnits()
{
   if(!this->inputUnitsIsNull_){
        if(inputUnitsIDRef_ != ""){
             return boost::shared_static_cast<PriceQuoteUnits>(IDManager::instance().getID(inputUnitsIDRef_));
        }else{
             return this->inputUnits_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PriceQuoteUnits>();
   }
}
std::vector<boost::shared_ptr<ParametricAdjustmentPoint>> ParametricAdjustment::getDatapoint()
{
   if(!this->datapointIsNull_){
        if(datapointIDRef_ != ""){
             return this->datapoint_;
        }else{
             return this->datapoint_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ParametricAdjustmentPoint>>();
   }
}
}

