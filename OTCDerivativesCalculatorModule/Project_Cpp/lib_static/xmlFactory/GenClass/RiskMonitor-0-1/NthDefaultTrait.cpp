// NthDefaultTrait.cpp 
#include "NthDefaultTrait.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

NthDefaultTrait::NthDefaultTrait(TiXmlNode* xmlNode)
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

   //nthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nthNode = xmlNode->FirstChildElement("nth");

   if(nthNode){nthIsNull_ = false;}
   else{nthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nthNode , address : " << nthNode << std::endl;
   #endif
   if(nthNode)
   {
       nth_ = boost::shared_ptr<XsdTypeInt>(new XsdTypeInt(nthNode));
   }

   //correlationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* correlationNode = xmlNode->FirstChildElement("correlation");

   if(correlationNode){correlationIsNull_ = false;}
   else{correlationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- correlationNode , address : " << correlationNode << std::endl;
   #endif
   if(correlationNode)
   {
       correlation_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(correlationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> NthDefaultTrait::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeInt> NthDefaultTrait::getNth()
{
   if(!this->nthIsNull_){
        return this->nth_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeInt>();
   }
}
boost::shared_ptr<XsdTypeDouble> NthDefaultTrait::getCorrelation()
{
   if(!this->correlationIsNull_){
        return this->correlation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

