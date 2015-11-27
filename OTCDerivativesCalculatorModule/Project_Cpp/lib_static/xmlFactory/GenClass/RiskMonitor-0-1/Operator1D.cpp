// Operator1D.cpp 
#include "Operator1D.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Operator1D::Operator1D(TiXmlNode* xmlNode)
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

   //additionOper1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionOper1DNode = xmlNode->FirstChildElement("additionOper1D");

   if(additionOper1DNode){additionOper1DIsNull_ = false;}
   else{additionOper1DIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionOper1DNode , address : " << additionOper1DNode << std::endl;
   #endif
   if(additionOper1DNode)
   {
       additionOper1D_ = boost::shared_ptr<AdditionOper1D>(new AdditionOper1D(additionOper1DNode));
   }

   //multipleOper1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleOper1DNode = xmlNode->FirstChildElement("multipleOper1D");

   if(multipleOper1DNode){multipleOper1DIsNull_ = false;}
   else{multipleOper1DIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleOper1DNode , address : " << multipleOper1DNode << std::endl;
   #endif
   if(multipleOper1DNode)
   {
       multipleOper1D_ = boost::shared_ptr<MultipleOper1D>(new MultipleOper1D(multipleOper1DNode));
   }

   //maximumOper1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumOper1DNode = xmlNode->FirstChildElement("maximumOper1D");

   if(maximumOper1DNode){maximumOper1DIsNull_ = false;}
   else{maximumOper1DIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumOper1DNode , address : " << maximumOper1DNode << std::endl;
   #endif
   if(maximumOper1DNode)
   {
       maximumOper1D_ = boost::shared_ptr<MaximumOper1D>(new MaximumOper1D(maximumOper1DNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Operator1D::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<AdditionOper1D> Operator1D::getAdditionOper1D()
{
   if(!this->additionOper1DIsNull_){
        return this->additionOper1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionOper1D>();
   }
}
boost::shared_ptr<MultipleOper1D> Operator1D::getMultipleOper1D()
{
   if(!this->multipleOper1DIsNull_){
        return this->multipleOper1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MultipleOper1D>();
   }
}
boost::shared_ptr<MaximumOper1D> Operator1D::getMaximumOper1D()
{
   if(!this->maximumOper1DIsNull_){
        return this->maximumOper1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MaximumOper1D>();
   }
}
}

