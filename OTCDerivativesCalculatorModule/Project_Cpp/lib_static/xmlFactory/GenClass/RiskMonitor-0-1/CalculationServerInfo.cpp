// CalculationServerInfo.cpp 
#include "CalculationServerInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CalculationServerInfo::CalculationServerInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //server_nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_nameNode = xmlNode->FirstChildElement("server_name");

   if(server_nameNode){server_nameIsNull_ = false;}
   else{server_nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_nameNode , address : " << server_nameNode << std::endl;
   #endif
   if(server_nameNode)
   {
       server_name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_nameNode));
   }

   //server_ipNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_ipNode = xmlNode->FirstChildElement("server_ip");

   if(server_ipNode){server_ipIsNull_ = false;}
   else{server_ipIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_ipNode , address : " << server_ipNode << std::endl;
   #endif
   if(server_ipNode)
   {
       server_ip_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_ipNode));
   }

   //server_portNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_portNode = xmlNode->FirstChildElement("server_port");

   if(server_portNode){server_portIsNull_ = false;}
   else{server_portIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_portNode , address : " << server_portNode << std::endl;
   #endif
   if(server_portNode)
   {
       server_port_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_portNode));
   }

   //server_statusNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_statusNode = xmlNode->FirstChildElement("server_status");

   if(server_statusNode){server_statusIsNull_ = false;}
   else{server_statusIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_statusNode , address : " << server_statusNode << std::endl;
   #endif
   if(server_statusNode)
   {
       server_status_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_statusNode));
   }

   //server_coreNumNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_coreNumNode = xmlNode->FirstChildElement("server_coreNum");

   if(server_coreNumNode){server_coreNumIsNull_ = false;}
   else{server_coreNumIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_coreNumNode , address : " << server_coreNumNode << std::endl;
   #endif
   if(server_coreNumNode)
   {
       server_coreNum_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_coreNumNode));
   }

   //server_useNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_useNode = xmlNode->FirstChildElement("server_use");

   if(server_useNode){server_useIsNull_ = false;}
   else{server_useIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_useNode , address : " << server_useNode << std::endl;
   #endif
   if(server_useNode)
   {
       server_use_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_useNode));
   }

   //server_aliveTimeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_aliveTimeNode = xmlNode->FirstChildElement("server_aliveTime");

   if(server_aliveTimeNode){server_aliveTimeIsNull_ = false;}
   else{server_aliveTimeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_aliveTimeNode , address : " << server_aliveTimeNode << std::endl;
   #endif
   if(server_aliveTimeNode)
   {
       server_aliveTime_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_aliveTimeNode));
   }

   //server_descriptionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* server_descriptionNode = xmlNode->FirstChildElement("server_description");

   if(server_descriptionNode){server_descriptionIsNull_ = false;}
   else{server_descriptionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- server_descriptionNode , address : " << server_descriptionNode << std::endl;
   #endif
   if(server_descriptionNode)
   {
       server_description_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(server_descriptionNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_name()
{
   if(!this->server_nameIsNull_){
        return this->server_name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_ip()
{
   if(!this->server_ipIsNull_){
        return this->server_ip_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_port()
{
   if(!this->server_portIsNull_){
        return this->server_port_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_status()
{
   if(!this->server_statusIsNull_){
        return this->server_status_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_coreNum()
{
   if(!this->server_coreNumIsNull_){
        return this->server_coreNum_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_use()
{
   if(!this->server_useIsNull_){
        return this->server_use_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_aliveTime()
{
   if(!this->server_aliveTimeIsNull_){
        return this->server_aliveTime_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> CalculationServerInfo::getServer_description()
{
   if(!this->server_descriptionIsNull_){
        return this->server_description_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

