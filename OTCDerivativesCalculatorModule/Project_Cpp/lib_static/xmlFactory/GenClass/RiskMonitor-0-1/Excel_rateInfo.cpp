// Excel_rateInfo.cpp 
#include "Excel_rateInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_rateInfo::Excel_rateInfo(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //currencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* currencyNode = xmlNode->FirstChildElement("currency");

   if(currencyNode){currencyIsNull_ = false;}
   else{currencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- currencyNode , address : " << currencyNode << std::endl;
   #endif
   if(currencyNode)
   {
       currency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(currencyNode));
   }

   //indexTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* indexTypeNode = xmlNode->FirstChildElement("indexType");

   if(indexTypeNode){indexTypeIsNull_ = false;}
   else{indexTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- indexTypeNode , address : " << indexTypeNode << std::endl;
   #endif
   if(indexTypeNode)
   {
       indexType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(indexTypeNode));
   }

   //tenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* tenorNode = xmlNode->FirstChildElement("tenor");

   if(tenorNode){tenorIsNull_ = false;}
   else{tenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- tenorNode , address : " << tenorNode << std::endl;
   #endif
   if(tenorNode)
   {
       tenor_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(tenorNode));
   }

   //legTenorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* legTenorNode = xmlNode->FirstChildElement("legTenor");

   if(legTenorNode){legTenorIsNull_ = false;}
   else{legTenorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- legTenorNode , address : " << legTenorNode << std::endl;
   #endif
   if(legTenorNode)
   {
       legTenor_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(legTenorNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_rateInfo::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_rateInfo::getIndexType()
{
   if(!this->indexTypeIsNull_){
        return this->indexType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_rateInfo::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_rateInfo::getLegTenor()
{
   if(!this->legTenorIsNull_){
        return this->legTenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

