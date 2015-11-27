// Metal.cpp 
#include "Metal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Metal::Metal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //materialNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* materialNode = xmlNode->FirstChildElement("material");

   if(materialNode){materialIsNull_ = false;}
   else{materialIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- materialNode , address : " << materialNode << std::endl;
   #endif
   if(materialNode)
   {
      if(materialNode->Attribute("href") || materialNode->Attribute("id"))
      {
          if(materialNode->Attribute("id"))
          {
             materialIDRef_ = materialNode->Attribute("id");
             material_ = boost::shared_ptr<Material>(new Material(materialNode));
             material_->setID(materialIDRef_);
             IDManager::instance().setID(materialIDRef_,material_);
          }
          else if(materialNode->Attribute("href")) { materialIDRef_ = materialNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { material_ = boost::shared_ptr<Material>(new Material(materialNode));}
   }

   //shapeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* shapeNode = xmlNode->FirstChildElement("shape");

   if(shapeNode){shapeIsNull_ = false;}
   else{shapeIsNull_ = true;}

   if(shapeNode)
   {
      for(shapeNode; shapeNode; shapeNode = shapeNode->NextSiblingElement("shape")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shapeNode , address : " << shapeNode << std::endl;
          #endif
          if(shapeNode->Attribute("href") || shapeNode->Attribute("id"))
          {
              if(shapeNode->Attribute("id"))
              {
                  shapeIDRef_ = shapeNode->Attribute("id");
                  shape_.push_back(boost::shared_ptr<CommodityMetalShape>(new CommodityMetalShape(shapeNode)));
                  shape_.back()->setID(shapeIDRef_);
                  IDManager::instance().setID(shapeIDRef_, shape_.back());
              }
              else if(shapeNode->Attribute("href")) { shapeIDRef_ = shapeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { shape_.push_back(boost::shared_ptr<CommodityMetalShape>(new CommodityMetalShape(shapeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- shapeNode , address : " << shapeNode << std::endl;
       #endif
   }

   //brandNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* brandNode = xmlNode->FirstChildElement("brand");

   if(brandNode){brandIsNull_ = false;}
   else{brandIsNull_ = true;}

   if(brandNode)
   {
      for(brandNode; brandNode; brandNode = brandNode->NextSiblingElement("brand")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brandNode , address : " << brandNode << std::endl;
          #endif
          if(brandNode->Attribute("href") || brandNode->Attribute("id"))
          {
              if(brandNode->Attribute("id"))
              {
                  brandIDRef_ = brandNode->Attribute("id");
                  brand_.push_back(boost::shared_ptr<CommodityMetalBrand>(new CommodityMetalBrand(brandNode)));
                  brand_.back()->setID(brandIDRef_);
                  IDManager::instance().setID(brandIDRef_, brand_.back());
              }
              else if(brandNode->Attribute("href")) { brandIDRef_ = brandNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { brand_.push_back(boost::shared_ptr<CommodityMetalBrand>(new CommodityMetalBrand(brandNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- brandNode , address : " << brandNode << std::endl;
       #endif
   }

   //gradeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* gradeNode = xmlNode->FirstChildElement("grade");

   if(gradeNode){gradeIsNull_ = false;}
   else{gradeIsNull_ = true;}

   if(gradeNode)
   {
      for(gradeNode; gradeNode; gradeNode = gradeNode->NextSiblingElement("grade")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gradeNode , address : " << gradeNode << std::endl;
          #endif
          if(gradeNode->Attribute("href") || gradeNode->Attribute("id"))
          {
              if(gradeNode->Attribute("id"))
              {
                  gradeIDRef_ = gradeNode->Attribute("id");
                  grade_.push_back(boost::shared_ptr<CommodityMetalGrade>(new CommodityMetalGrade(gradeNode)));
                  grade_.back()->setID(gradeIDRef_);
                  IDManager::instance().setID(gradeIDRef_, grade_.back());
              }
              else if(gradeNode->Attribute("href")) { gradeIDRef_ = gradeNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { grade_.push_back(boost::shared_ptr<CommodityMetalGrade>(new CommodityMetalGrade(gradeNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- gradeNode , address : " << gradeNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Material> Metal::getMaterial()
{
   if(!this->materialIsNull_){
        if(materialIDRef_ != ""){
             return boost::shared_static_cast<Material>(IDManager::instance().getID(materialIDRef_));
        }else{
             return this->material_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Material>();
   }
}
std::vector<boost::shared_ptr<CommodityMetalShape>> Metal::getShape()
{
   if(!this->shapeIsNull_){
        if(shapeIDRef_ != ""){
             return this->shape_;
        }else{
             return this->shape_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityMetalShape>>();
   }
}
std::vector<boost::shared_ptr<CommodityMetalBrand>> Metal::getBrand()
{
   if(!this->brandIsNull_){
        if(brandIDRef_ != ""){
             return this->brand_;
        }else{
             return this->brand_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityMetalBrand>>();
   }
}
std::vector<boost::shared_ptr<CommodityMetalGrade>> Metal::getGrade()
{
   if(!this->gradeIsNull_){
        if(gradeIDRef_ != ""){
             return this->grade_;
        }else{
             return this->grade_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CommodityMetalGrade>>();
   }
}
}

