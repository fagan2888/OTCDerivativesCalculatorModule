// ResourceLength.cpp 
#include "ResourceLength.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ResourceLength::ResourceLength(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //lengthUnitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lengthUnitNode = xmlNode->FirstChildElement("lengthUnit");

   if(lengthUnitNode){lengthUnitIsNull_ = false;}
   else{lengthUnitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lengthUnitNode , address : " << lengthUnitNode << std::endl;
   #endif
   if(lengthUnitNode)
   {
      if(lengthUnitNode->Attribute("href") || lengthUnitNode->Attribute("id"))
      {
          if(lengthUnitNode->Attribute("id"))
          {
             lengthUnitIDRef_ = lengthUnitNode->Attribute("id");
             lengthUnit_ = boost::shared_ptr<LengthUnitEnum>(new LengthUnitEnum(lengthUnitNode));
             lengthUnit_->setID(lengthUnitIDRef_);
             IDManager::instance().setID(lengthUnitIDRef_,lengthUnit_);
          }
          else if(lengthUnitNode->Attribute("href")) { lengthUnitIDRef_ = lengthUnitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lengthUnit_ = boost::shared_ptr<LengthUnitEnum>(new LengthUnitEnum(lengthUnitNode));}
   }

   //lengthValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lengthValueNode = xmlNode->FirstChildElement("lengthValue");

   if(lengthValueNode){lengthValueIsNull_ = false;}
   else{lengthValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lengthValueNode , address : " << lengthValueNode << std::endl;
   #endif
   if(lengthValueNode)
   {
      if(lengthValueNode->Attribute("href") || lengthValueNode->Attribute("id"))
      {
          if(lengthValueNode->Attribute("id"))
          {
             lengthValueIDRef_ = lengthValueNode->Attribute("id");
             lengthValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(lengthValueNode));
             lengthValue_->setID(lengthValueIDRef_);
             IDManager::instance().setID(lengthValueIDRef_,lengthValue_);
          }
          else if(lengthValueNode->Attribute("href")) { lengthValueIDRef_ = lengthValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lengthValue_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(lengthValueNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<LengthUnitEnum> ResourceLength::getLengthUnit()
{
   if(!this->lengthUnitIsNull_){
        if(lengthUnitIDRef_ != ""){
             return boost::shared_static_cast<LengthUnitEnum>(IDManager::instance().getID(lengthUnitIDRef_));
        }else{
             return this->lengthUnit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<LengthUnitEnum>();
   }
}
boost::shared_ptr<XsdTypeDecimal> ResourceLength::getLengthValue()
{
   if(!this->lengthValueIsNull_){
        if(lengthValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(lengthValueIDRef_));
        }else{
             return this->lengthValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

