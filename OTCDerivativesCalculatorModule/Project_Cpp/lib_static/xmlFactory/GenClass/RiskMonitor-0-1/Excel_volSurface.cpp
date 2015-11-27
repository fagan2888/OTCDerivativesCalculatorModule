// Excel_volSurface.cpp 
#include "Excel_volSurface.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_volSurface::Excel_volSurface(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //refDateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* refDateNode = xmlNode->FirstChildElement("refDate");

   if(refDateNode){refDateIsNull_ = false;}
   else{refDateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- refDateNode , address : " << refDateNode << std::endl;
   #endif
   if(refDateNode)
   {
       refDate_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(refDateNode));
   }

   //codeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* codeNode = xmlNode->FirstChildElement("code");

   if(codeNode){codeIsNull_ = false;}
   else{codeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- codeNode , address : " << codeNode << std::endl;
   #endif
   if(codeNode)
   {
       code_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(codeNode));
   }

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

   //tenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNode = xmlNode->FirstChildElement("tenor");

   if(tenorNode){tenorIsNull_ = false;}
   else{tenorIsNull_ = true;}

   if(tenorNode)
   {
      for(tenorNode; tenorNode; tenorNode = tenorNode->NextSiblingElement("tenor")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
          #endif
          tenor_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(tenorNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
       #endif
   }

   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   if(strikeNode)
   {
      for(strikeNode; strikeNode; strikeNode = strikeNode->NextSiblingElement("strike")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
          #endif
          strike_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(strikeNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_volSurface::getRefDate()
{
   if(!this->refDateIsNull_){
        return this->refDate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_volSurface::getCode()
{
   if(!this->codeIsNull_){
        return this->code_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_volSurface::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<XsdTypeToken>> Excel_volSurface::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
std::vector<boost::shared_ptr<XsdTypeToken>> Excel_volSurface::getStrike()
{
   if(!this->strikeIsNull_){
        return this->strike_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
}

