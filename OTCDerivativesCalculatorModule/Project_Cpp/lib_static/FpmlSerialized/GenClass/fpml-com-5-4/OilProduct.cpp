// OilProduct.cpp 
#include "OilProduct.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OilProduct::OilProduct(TiXmlNode* xmlNode)
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
             type_ = boost::shared_ptr<OilProductType>(new OilProductType(typeNode));
             type_->setID(typeIDRef_);
             IDManager::instance().setID(typeIDRef_,type_);
          }
          else if(typeNode->Attribute("href")) { typeIDRef_ = typeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { type_ = boost::shared_ptr<OilProductType>(new OilProductType(typeNode));}
   }

   //gradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gradeNode = xmlNode->FirstChildElement("grade");

   if(gradeNode){gradeIsNull_ = false;}
   else{gradeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gradeNode , address : " << gradeNode << std::endl;
   #endif
   if(gradeNode)
   {
      if(gradeNode->Attribute("href") || gradeNode->Attribute("id"))
      {
          if(gradeNode->Attribute("id"))
          {
             gradeIDRef_ = gradeNode->Attribute("id");
             grade_ = boost::shared_ptr<CommodityProductGrade>(new CommodityProductGrade(gradeNode));
             grade_->setID(gradeIDRef_);
             IDManager::instance().setID(gradeIDRef_,grade_);
          }
          else if(gradeNode->Attribute("href")) { gradeIDRef_ = gradeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { grade_ = boost::shared_ptr<CommodityProductGrade>(new CommodityProductGrade(gradeNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<OilProductType> OilProduct::getType()
{
   if(!this->typeIsNull_){
        if(typeIDRef_ != ""){
             return boost::shared_static_cast<OilProductType>(IDManager::instance().getID(typeIDRef_));
        }else{
             return this->type_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OilProductType>();
   }
}
boost::shared_ptr<CommodityProductGrade> OilProduct::getGrade()
{
   if(!this->gradeIsNull_){
        if(gradeIDRef_ != ""){
             return boost::shared_static_cast<CommodityProductGrade>(IDManager::instance().getID(gradeIDRef_));
        }else{
             return this->grade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CommodityProductGrade>();
   }
}
}

