// Index.cpp 
#include "Index.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Index::Index(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //krCodeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* krCodeNode = xmlNode->FirstChildElement("krCode");

   if(krCodeNode){krCodeIsNull_ = false;}
   else{krCodeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- krCodeNode , address : " << krCodeNode << std::endl;
   #endif
   if(krCodeNode)
   {
       krCode_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(krCodeNode));
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

   //basePriceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basePriceNode = xmlNode->FirstChildElement("basePrice");

   if(basePriceNode){basePriceIsNull_ = false;}
   else{basePriceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basePriceNode , address : " << basePriceNode << std::endl;
   #endif
   if(basePriceNode)
   {
       basePrice_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(basePriceNode));
   }

   //interestRateIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestRateIndexNode = xmlNode->FirstChildElement("interestRateIndex");

   if(interestRateIndexNode){interestRateIndexIsNull_ = false;}
   else{interestRateIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestRateIndexNode , address : " << interestRateIndexNode << std::endl;
   #endif
   if(interestRateIndexNode)
   {
       interestRateIndex_ = boost::shared_ptr<InterestRateIndex>(new InterestRateIndex(interestRateIndexNode));
   }

   //stockIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stockIndexNode = xmlNode->FirstChildElement("stockIndex");

   if(stockIndexNode){stockIndexIsNull_ = false;}
   else{stockIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stockIndexNode , address : " << stockIndexNode << std::endl;
   #endif
   if(stockIndexNode)
   {
       stockIndex_ = boost::shared_ptr<StockIndex>(new StockIndex(stockIndexNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Index::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Index::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Index::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Index::getBasePrice()
{
   if(!this->basePriceIsNull_){
        return this->basePrice_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<InterestRateIndex> Index::getInterestRateIndex()
{
   if(!this->interestRateIndexIsNull_){
        return this->interestRateIndex_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestRateIndex>();
   }
}
boost::shared_ptr<StockIndex> Index::getStockIndex()
{
   if(!this->stockIndexIsNull_){
        return this->stockIndex_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StockIndex>();
   }
}
}

