// Rounding.cpp 
#include "Rounding.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Rounding::Rounding(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //roundingDirectionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* roundingDirectionNode = xmlNode->FirstChildElement("roundingDirection");

   if(roundingDirectionNode){roundingDirectionIsNull_ = false;}
   else{roundingDirectionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- roundingDirectionNode , address : " << roundingDirectionNode << std::endl;
   #endif
   if(roundingDirectionNode)
   {
      if(roundingDirectionNode->Attribute("href") || roundingDirectionNode->Attribute("id"))
      {
          if(roundingDirectionNode->Attribute("id"))
          {
             roundingDirectionIDRef_ = roundingDirectionNode->Attribute("id");
             roundingDirection_ = boost::shared_ptr<RoundingDirectionEnum>(new RoundingDirectionEnum(roundingDirectionNode));
             roundingDirection_->setID(roundingDirectionIDRef_);
             IDManager::instance().setID(roundingDirectionIDRef_,roundingDirection_);
          }
          else if(roundingDirectionNode->Attribute("href")) { roundingDirectionIDRef_ = roundingDirectionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { roundingDirection_ = boost::shared_ptr<RoundingDirectionEnum>(new RoundingDirectionEnum(roundingDirectionNode));}
   }

   //precisionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* precisionNode = xmlNode->FirstChildElement("precision");

   if(precisionNode){precisionIsNull_ = false;}
   else{precisionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- precisionNode , address : " << precisionNode << std::endl;
   #endif
   if(precisionNode)
   {
      if(precisionNode->Attribute("href") || precisionNode->Attribute("id"))
      {
          if(precisionNode->Attribute("id"))
          {
             precisionIDRef_ = precisionNode->Attribute("id");
             precision_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(precisionNode));
             precision_->setID(precisionIDRef_);
             IDManager::instance().setID(precisionIDRef_,precision_);
          }
          else if(precisionNode->Attribute("href")) { precisionIDRef_ = precisionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { precision_ = boost::shared_ptr<XsdTypeNonNegativeInteger>(new XsdTypeNonNegativeInteger(precisionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RoundingDirectionEnum> Rounding::getRoundingDirection()
{
   if(!this->roundingDirectionIsNull_){
        if(roundingDirectionIDRef_ != ""){
             return boost::shared_static_cast<RoundingDirectionEnum>(IDManager::instance().getID(roundingDirectionIDRef_));
        }else{
             return this->roundingDirection_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RoundingDirectionEnum>();
   }
}
boost::shared_ptr<XsdTypeNonNegativeInteger> Rounding::getPrecision()
{
   if(!this->precisionIsNull_){
        if(precisionIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNonNegativeInteger>(IDManager::instance().getID(precisionIDRef_));
        }else{
             return this->precision_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNonNegativeInteger>();
   }
}
}

