// PayoffInfoAnalytic.cpp 
#include "PayoffInfoAnalytic.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PayoffInfoAnalytic::PayoffInfoAnalytic(TiXmlNode* xmlNode)
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

   //standardPayoff_ANode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardPayoff_ANode = xmlNode->FirstChildElement("standardPayoff_A");

   if(standardPayoff_ANode){standardPayoff_AIsNull_ = false;}
   else{standardPayoff_AIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardPayoff_ANode , address : " << standardPayoff_ANode << std::endl;
   #endif
   if(standardPayoff_ANode)
   {
       standardPayoff_A_ = boost::shared_ptr<StandardPayoff_A>(new StandardPayoff_A(standardPayoff_ANode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> PayoffInfoAnalytic::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<StandardPayoff_A> PayoffInfoAnalytic::getStandardPayoff_A()
{
   if(!this->standardPayoff_AIsNull_){
        return this->standardPayoff_A_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StandardPayoff_A>();
   }
}
}

