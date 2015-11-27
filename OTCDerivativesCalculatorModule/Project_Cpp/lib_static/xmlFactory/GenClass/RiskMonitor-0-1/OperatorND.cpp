// OperatorND.cpp 
#include "OperatorND.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OperatorND::OperatorND(TiXmlNode* xmlNode)
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

   //additionOperNDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionOperNDNode = xmlNode->FirstChildElement("additionOperND");

   if(additionOperNDNode){additionOperNDIsNull_ = false;}
   else{additionOperNDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionOperNDNode , address : " << additionOperNDNode << std::endl;
   #endif
   if(additionOperNDNode)
   {
       additionOperND_ = boost::shared_ptr<AdditionOperND>(new AdditionOperND(additionOperNDNode));
   }

   //multipleOperNDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* multipleOperNDNode = xmlNode->FirstChildElement("multipleOperND");

   if(multipleOperNDNode){multipleOperNDIsNull_ = false;}
   else{multipleOperNDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- multipleOperNDNode , address : " << multipleOperNDNode << std::endl;
   #endif
   if(multipleOperNDNode)
   {
       multipleOperND_ = boost::shared_ptr<MultipleOperND>(new MultipleOperND(multipleOperNDNode));
   }

   //divisionOperNDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* divisionOperNDNode = xmlNode->FirstChildElement("divisionOperND");

   if(divisionOperNDNode){divisionOperNDIsNull_ = false;}
   else{divisionOperNDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- divisionOperNDNode , address : " << divisionOperNDNode << std::endl;
   #endif
   if(divisionOperNDNode)
   {
       divisionOperND_ = boost::shared_ptr<DivisionOperND>(new DivisionOperND(divisionOperNDNode));
   }

   //maximumOperNDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* maximumOperNDNode = xmlNode->FirstChildElement("maximumOperND");

   if(maximumOperNDNode){maximumOperNDIsNull_ = false;}
   else{maximumOperNDIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- maximumOperNDNode , address : " << maximumOperNDNode << std::endl;
   #endif
   if(maximumOperNDNode)
   {
       maximumOperND_ = boost::shared_ptr<MaximumOperND>(new MaximumOperND(maximumOperNDNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> OperatorND::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<AdditionOperND> OperatorND::getAdditionOperND()
{
   if(!this->additionOperNDIsNull_){
        return this->additionOperND_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionOperND>();
   }
}
boost::shared_ptr<MultipleOperND> OperatorND::getMultipleOperND()
{
   if(!this->multipleOperNDIsNull_){
        return this->multipleOperND_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MultipleOperND>();
   }
}
boost::shared_ptr<DivisionOperND> OperatorND::getDivisionOperND()
{
   if(!this->divisionOperNDIsNull_){
        return this->divisionOperND_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DivisionOperND>();
   }
}
boost::shared_ptr<MaximumOperND> OperatorND::getMaximumOperND()
{
   if(!this->maximumOperNDIsNull_){
        return this->maximumOperND_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MaximumOperND>();
   }
}
}

