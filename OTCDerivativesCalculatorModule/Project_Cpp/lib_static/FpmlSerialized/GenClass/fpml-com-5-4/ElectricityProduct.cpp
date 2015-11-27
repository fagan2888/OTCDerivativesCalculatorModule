// ElectricityProduct.cpp 
#include "ElectricityProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityProduct::ElectricityProduct(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
      if(typeNode->Attribute("href") || typeNode->Attribute("id"))
      {
          if(typeNode->Attribute("id"))
          {
             typeIDRef_ = typeNode->Attribute("id");
             type_ = boost::shared_ptr<ElectricityProductTypeEnum>(new ElectricityProductTypeEnum(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<ElectricityProductTypeEnum>(new ElectricityProductTypeEnum(typeNode));}
   }

   //voltageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* voltageNode = xmlNode->FirstChildElement("voltage");

   if(voltageNode){voltageIsNull_ = false;}
   else{voltageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- voltageNode , address : " << voltageNode << std::endl;
   #endif
   if(voltageNode)
   {
      if(voltageNode->Attribute("href") || voltageNode->Attribute("id"))
      {
          if(voltageNode->Attribute("id"))
          {
             voltageIDRef_ = voltageNode->Attribute("id");
             voltage_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(voltageNode));
             voltage_->setID(voltageIDRef_);
             IDManager::instance().setID(voltageIDRef_,voltage_);
          }
          else if(voltageNode->Attribute("href")) { voltageIDRef_ = voltageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { voltage_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(voltageNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ElectricityProductTypeEnum> ElectricityProduct::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<ElectricityProductTypeEnum>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityProductTypeEnum>();
   }
}
boost::shared_ptr<PositiveDecimal> ElectricityProduct::getVoltage()
{
   if(!this->voltageIsNull_){
        if(voltageIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(voltageIDRef_));
        }else{
             return this->voltage_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
}

