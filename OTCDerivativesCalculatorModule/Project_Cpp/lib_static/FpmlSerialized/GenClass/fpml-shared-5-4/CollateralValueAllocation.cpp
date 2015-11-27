// CollateralValueAllocation.cpp 
#include "CollateralValueAllocation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CollateralValueAllocation::CollateralValueAllocation(TiXmlNode* xmlNode)
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
             type_ = boost::shared_ptr<CollateralValueAllocationEnum>(new CollateralValueAllocationEnum(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<CollateralValueAllocationEnum>(new CollateralValueAllocationEnum(typeNode));}
   }

   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   if(valueNode)
   {
      for(valueNode; valueNode; valueNode = valueNode->NextSiblingElement("value")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
          #endif
          if(valueNode->Attribute("href") || valueNode->Attribute("id"))
          {
              if(valueNode->Attribute("id"))
              {
                  valueIDRef_ = valueNode->Attribute("id");
                  value_.push_back(boost::shared_ptr<Money>(new Money(valueNode)));
                  value_.back()->setID(valueIDRef_);
                  IDManager::instance().setID(valueIDRef_, value_.back());
              }
              else if(valueNode->Attribute("href")) { valueIDRef_ = valueNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { value_.push_back(boost::shared_ptr<Money>(new Money(valueNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CollateralValueAllocationEnum> CollateralValueAllocation::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<CollateralValueAllocationEnum>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CollateralValueAllocationEnum>();
   }
}
std::vector<boost::shared_ptr<Money>> CollateralValueAllocation::getValue()
{
   if(!this->valueIsNull_){
        if(valueIDRef_ != ""){
             return this->value_;
        }else{
             return this->value_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Money>>();
   }
}
}

