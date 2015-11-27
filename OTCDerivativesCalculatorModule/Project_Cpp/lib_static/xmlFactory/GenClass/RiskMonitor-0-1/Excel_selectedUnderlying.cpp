// Excel_selectedUnderlying.cpp 
#include "Excel_selectedUnderlying.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_selectedUnderlying::Excel_selectedUnderlying(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //checkedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* checkedNode = xmlNode->FirstChildElement("checked");

   if(checkedNode){checkedIsNull_ = false;}
   else{checkedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- checkedNode , address : " << checkedNode << std::endl;
   #endif
   if(checkedNode)
   {
       checked_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(checkedNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_selectedUnderlying::getCode()
{
   if(!this->codeIsNull_){
        return this->code_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_selectedUnderlying::getName()
{
   if(!this->nameIsNull_){
        return this->name_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_selectedUnderlying::getChecked()
{
   if(!this->checkedIsNull_){
        return this->checked_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

