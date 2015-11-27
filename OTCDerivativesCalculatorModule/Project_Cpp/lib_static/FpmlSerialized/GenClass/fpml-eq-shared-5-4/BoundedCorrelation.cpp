// BoundedCorrelation.cpp 
#include "BoundedCorrelation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BoundedCorrelation::BoundedCorrelation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //minimumBoundaryPercentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* minimumBoundaryPercentNode = xmlNode->FirstChildElement("minimumBoundaryPercent");

   if(minimumBoundaryPercentNode){minimumBoundaryPercentIsNull_ = false;}
   else{minimumBoundaryPercentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- minimumBoundaryPercentNode , address : " << minimumBoundaryPercentNode << std::endl;
   #endif
   if(minimumBoundaryPercentNode)
   {
      if(minimumBoundaryPercentNode->Attribute("href") || minimumBoundaryPercentNode->Attribute("id"))
      {
          if(minimumBoundaryPercentNode->Attribute("id"))
          {
             minimumBoundaryPercentIDRef_ = minimumBoundaryPercentNode->Attribute("id");
             minimumBoundaryPercent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(minimumBoundaryPercentNode));
             minimumBoundaryPercent_->setID(minimumBoundaryPercentIDRef_);
             IDManager::instance().setID(minimumBoundaryPercentIDRef_,minimumBoundaryPercent_);
          }
          else if(minimumBoundaryPercentNode->Attribute("href")) { minimumBoundaryPercentIDRef_ = minimumBoundaryPercentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { minimumBoundaryPercent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(minimumBoundaryPercentNode));}
   }

   //maximumBoundaryPercentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumBoundaryPercentNode = xmlNode->FirstChildElement("maximumBoundaryPercent");

   if(maximumBoundaryPercentNode){maximumBoundaryPercentIsNull_ = false;}
   else{maximumBoundaryPercentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumBoundaryPercentNode , address : " << maximumBoundaryPercentNode << std::endl;
   #endif
   if(maximumBoundaryPercentNode)
   {
      if(maximumBoundaryPercentNode->Attribute("href") || maximumBoundaryPercentNode->Attribute("id"))
      {
          if(maximumBoundaryPercentNode->Attribute("id"))
          {
             maximumBoundaryPercentIDRef_ = maximumBoundaryPercentNode->Attribute("id");
             maximumBoundaryPercent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(maximumBoundaryPercentNode));
             maximumBoundaryPercent_->setID(maximumBoundaryPercentIDRef_);
             IDManager::instance().setID(maximumBoundaryPercentIDRef_,maximumBoundaryPercent_);
          }
          else if(maximumBoundaryPercentNode->Attribute("href")) { maximumBoundaryPercentIDRef_ = maximumBoundaryPercentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { maximumBoundaryPercent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(maximumBoundaryPercentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> BoundedCorrelation::getMinimumBoundaryPercent()
{
   if(!this->minimumBoundaryPercentIsNull_){
        if(minimumBoundaryPercentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(minimumBoundaryPercentIDRef_));
        }else{
             return this->minimumBoundaryPercent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> BoundedCorrelation::getMaximumBoundaryPercent()
{
   if(!this->maximumBoundaryPercentIsNull_){
        if(maximumBoundaryPercentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(maximumBoundaryPercentIDRef_));
        }else{
             return this->maximumBoundaryPercent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

