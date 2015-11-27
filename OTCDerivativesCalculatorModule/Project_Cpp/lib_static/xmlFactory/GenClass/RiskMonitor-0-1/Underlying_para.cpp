// Underlying_para.cpp 
#include "Underlying_para.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Underlying_para::Underlying_para(TiXmlNode* xmlNode)
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

   //underNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* underNameNode = xmlNode->FirstChildElement("underName");

   if(underNameNode){underNameIsNull_ = false;}
   else{underNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- underNameNode , address : " << underNameNode << std::endl;
   #endif
   if(underNameNode)
   {
       underName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(underNameNode));
   }

   //valueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* valueNode = xmlNode->FirstChildElement("value");

   if(valueNode){valueIsNull_ = false;}
   else{valueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- valueNode , address : " << valueNode << std::endl;
   #endif
   if(valueNode)
   {
       value_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(valueNode));
   }

   //geometricBMNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* geometricBMNode = xmlNode->FirstChildElement("geometricBM");

   if(geometricBMNode){geometricBMIsNull_ = false;}
   else{geometricBMIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- geometricBMNode , address : " << geometricBMNode << std::endl;
   #endif
   if(geometricBMNode)
   {
       geometricBM_ = boost::shared_ptr<GeometricBM>(new GeometricBM(geometricBMNode));
   }

   //hullWhiteOneFactorNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hullWhiteOneFactorNode = xmlNode->FirstChildElement("hullWhiteOneFactor");

   if(hullWhiteOneFactorNode){hullWhiteOneFactorIsNull_ = false;}
   else{hullWhiteOneFactorIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hullWhiteOneFactorNode , address : " << hullWhiteOneFactorNode << std::endl;
   #endif
   if(hullWhiteOneFactorNode)
   {
       hullWhiteOneFactor_ = boost::shared_ptr<HullWhiteOneFactor>(new HullWhiteOneFactor(hullWhiteOneFactorNode));
   }

   //forwardModelNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardModelNode = xmlNode->FirstChildElement("forwardModel");

   if(forwardModelNode){forwardModelIsNull_ = false;}
   else{forwardModelIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardModelNode , address : " << forwardModelNode << std::endl;
   #endif
   if(forwardModelNode)
   {
       forwardModel_ = boost::shared_ptr<ForwardModel>(new ForwardModel(forwardModelNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Underlying_para::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Underlying_para::getKrCode()
{
   if(!this->krCodeIsNull_){
        return this->krCode_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Underlying_para::getUnderName()
{
   if(!this->underNameIsNull_){
        return this->underName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Underlying_para::getValue()
{
   if(!this->valueIsNull_){
        return this->value_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<GeometricBM> Underlying_para::getGeometricBM()
{
   if(!this->geometricBMIsNull_){
        return this->geometricBM_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GeometricBM>();
   }
}
boost::shared_ptr<HullWhiteOneFactor> Underlying_para::getHullWhiteOneFactor()
{
   if(!this->hullWhiteOneFactorIsNull_){
        return this->hullWhiteOneFactor_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<HullWhiteOneFactor>();
   }
}
boost::shared_ptr<ForwardModel> Underlying_para::getForwardModel()
{
   if(!this->forwardModelIsNull_){
        return this->forwardModel_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ForwardModel>();
   }
}
}

