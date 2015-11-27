// Excel_indexType.cpp 
#include "Excel_indexType.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_indexType::Excel_indexType(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //sub_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sub_typeNode = xmlNode->FirstChildElement("sub_type");

   if(sub_typeNode){sub_typeIsNull_ = false;}
   else{sub_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sub_typeNode , address : " << sub_typeNode << std::endl;
   #endif
   if(sub_typeNode)
   {
       sub_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(sub_typeNode));
   }

   //rateTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateTypeNode = xmlNode->FirstChildElement("rateType");

   if(rateTypeNode){rateTypeIsNull_ = false;}
   else{rateTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateTypeNode , address : " << rateTypeNode << std::endl;
   #endif
   if(rateTypeNode)
   {
       rateType_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(rateTypeNode));
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

   //linkedCurveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* linkedCurveNode = xmlNode->FirstChildElement("linkedCurve");

   if(linkedCurveNode){linkedCurveIsNull_ = false;}
   else{linkedCurveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- linkedCurveNode , address : " << linkedCurveNode << std::endl;
   #endif
   if(linkedCurveNode)
   {
       linkedCurve_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(linkedCurveNode));
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

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getCurrency()
{
   if(!this->currencyIsNull_){
        return this->currency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getSub_type()
{
   if(!this->sub_typeIsNull_){
        return this->sub_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getRateType()
{
   if(!this->rateTypeIsNull_){
        return this->rateType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getTenor()
{
   if(!this->tenorIsNull_){
        return this->tenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getLegTenor()
{
   if(!this->legTenorIsNull_){
        return this->legTenor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getLinkedCurve()
{
   if(!this->linkedCurveIsNull_){
        return this->linkedCurve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_indexType::getBasePrice()
{
   if(!this->basePriceIsNull_){
        return this->basePrice_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

