// NetAndGross.cpp 
#include "NetAndGross.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NetAndGross::NetAndGross(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //netNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* netNode = xmlNode->FirstChildElement("net");

   if(netNode){netIsNull_ = false;}
   else{netIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- netNode , address : " << netNode << std::endl;
   #endif
   if(netNode)
   {
      if(netNode->Attribute("href") || netNode->Attribute("id"))
      {
          if(netNode->Attribute("id"))
          {
             netIDRef_ = netNode->Attribute("id");
             net_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(netNode));
             net_->setID(netIDRef_);
             IDManager::instance().setID(netIDRef_,net_);
          }
          else if(netNode->Attribute("href")) { netIDRef_ = netNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { net_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(netNode));}
   }

   //grossNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* grossNode = xmlNode->FirstChildElement("gross");

   if(grossNode){grossIsNull_ = false;}
   else{grossIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- grossNode , address : " << grossNode << std::endl;
   #endif
   if(grossNode)
   {
      if(grossNode->Attribute("href") || grossNode->Attribute("id"))
      {
          if(grossNode->Attribute("id"))
          {
             grossIDRef_ = grossNode->Attribute("id");
             gross_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(grossNode));
             gross_->setID(grossIDRef_);
             IDManager::instance().setID(grossIDRef_,gross_);
          }
          else if(grossNode->Attribute("href")) { grossIDRef_ = grossNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { gross_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(grossNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDecimal> NetAndGross::getNet()
{
   if(!this->netIsNull_){
        if(netIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(netIDRef_));
        }else{
             return this->net_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> NetAndGross::getGross()
{
   if(!this->grossIsNull_){
        if(grossIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(grossIDRef_));
        }else{
             return this->gross_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

