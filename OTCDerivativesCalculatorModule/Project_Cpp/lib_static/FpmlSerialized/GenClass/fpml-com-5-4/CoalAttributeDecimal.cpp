// CoalAttributeDecimal.cpp 
#include "CoalAttributeDecimal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CoalAttributeDecimal::CoalAttributeDecimal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //standardContentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardContentNode = xmlNode->FirstChildElement("standardContent");

   if(standardContentNode){standardContentIsNull_ = false;}
   else{standardContentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardContentNode , address : " << standardContentNode << std::endl;
   #endif
   if(standardContentNode)
   {
      if(standardContentNode->Attribute("href") || standardContentNode->Attribute("id"))
      {
          if(standardContentNode->Attribute("id"))
          {
             standardContentIDRef_ = standardContentNode->Attribute("id");
             standardContent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(standardContentNode));
             standardContent_->setID(standardContentIDRef_);
             IDManager::instance().setID(standardContentIDRef_,standardContent_);
          }
          else if(standardContentNode->Attribute("href")) { standardContentIDRef_ = standardContentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { standardContent_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(standardContentNode));}
   }

   //rejectionLimitNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rejectionLimitNode = xmlNode->FirstChildElement("rejectionLimit");

   if(rejectionLimitNode){rejectionLimitIsNull_ = false;}
   else{rejectionLimitIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rejectionLimitNode , address : " << rejectionLimitNode << std::endl;
   #endif
   if(rejectionLimitNode)
   {
      if(rejectionLimitNode->Attribute("href") || rejectionLimitNode->Attribute("id"))
      {
          if(rejectionLimitNode->Attribute("id"))
          {
             rejectionLimitIDRef_ = rejectionLimitNode->Attribute("id");
             rejectionLimit_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(rejectionLimitNode));
             rejectionLimit_->setID(rejectionLimitIDRef_);
             IDManager::instance().setID(rejectionLimitIDRef_,rejectionLimit_);
          }
          else if(rejectionLimitNode->Attribute("href")) { rejectionLimitIDRef_ = rejectionLimitNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rejectionLimit_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(rejectionLimitNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> CoalAttributeDecimal::getStandardContent()
{
   if(!this->standardContentIsNull_){
        if(standardContentIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(standardContentIDRef_));
        }else{
             return this->standardContent_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CoalAttributeDecimal::getRejectionLimit()
{
   if(!this->rejectionLimitIsNull_){
        if(rejectionLimitIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(rejectionLimitIDRef_));
        }else{
             return this->rejectionLimit_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

