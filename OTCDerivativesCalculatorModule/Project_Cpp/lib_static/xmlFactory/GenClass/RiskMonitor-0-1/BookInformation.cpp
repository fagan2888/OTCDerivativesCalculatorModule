// BookInformation.cpp 
#include "BookInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BookInformation::BookInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
       name_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(nameNode));
   }

   //pathInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pathInfoNode = xmlNode->FirstChildElement("pathInfo");

   if(pathInfoNode){pathInfoIsNull_ = false;}
   else{pathInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pathInfoNode , address : " << pathInfoNode << std::endl;
   #endif
   if(pathInfoNode)
   {
       pathInfo_ = boost::shared_ptr<PathInfo>(new PathInfo(pathInfoNode));
   }

   //instrumentListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* instrumentListNode = xmlNode->FirstChildElement("instrumentList");

   if(instrumentListNode){instrumentListIsNull_ = false;}
   else{instrumentListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- instrumentListNode , address : " << instrumentListNode << std::endl;
   #endif
   if(instrumentListNode)
   {
       instrumentList_ = boost::shared_ptr<InstrumentList>(new InstrumentList(instrumentListNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> BookInformation::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<PathInfo> BookInformation::getPathInfo()
{
   if(!this->pathInfoIsNull_){
        return this->pathInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PathInfo>();
   }
}
boost::shared_ptr<InstrumentList> BookInformation::getInstrumentList()
{
   if(!this->instrumentListIsNull_){
        return this->instrumentList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InstrumentList>();
   }
}
}

