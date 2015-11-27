// VariableInfo.cpp 
#include "VariableInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

VariableInfo::VariableInfo(TiXmlNode* xmlNode)
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

   //nullVariableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nullVariableInfoNode = xmlNode->FirstChildElement("nullVariableInfo");

   if(nullVariableInfoNode){nullVariableInfoIsNull_ = false;}
   else{nullVariableInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nullVariableInfoNode , address : " << nullVariableInfoNode << std::endl;
   #endif
   if(nullVariableInfoNode)
   {
       nullVariableInfo_ = boost::shared_ptr<NullVariableInfo>(new NullVariableInfo(nullVariableInfoNode));
   }

   //overWriteVariableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* overWriteVariableInfoNode = xmlNode->FirstChildElement("overWriteVariableInfo");

   if(overWriteVariableInfoNode){overWriteVariableInfoIsNull_ = false;}
   else{overWriteVariableInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- overWriteVariableInfoNode , address : " << overWriteVariableInfoNode << std::endl;
   #endif
   if(overWriteVariableInfoNode)
   {
       overWriteVariableInfo_ = boost::shared_ptr<OverWriteVariableInfo>(new OverWriteVariableInfo(overWriteVariableInfoNode));
   }

   //additionVariableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* additionVariableInfoNode = xmlNode->FirstChildElement("additionVariableInfo");

   if(additionVariableInfoNode){additionVariableInfoIsNull_ = false;}
   else{additionVariableInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- additionVariableInfoNode , address : " << additionVariableInfoNode << std::endl;
   #endif
   if(additionVariableInfoNode)
   {
       additionVariableInfo_ = boost::shared_ptr<AdditionVariableInfo>(new AdditionVariableInfo(additionVariableInfoNode));
   }

   //preDefinedVariableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* preDefinedVariableInfoNode = xmlNode->FirstChildElement("preDefinedVariableInfo");

   if(preDefinedVariableInfoNode){preDefinedVariableInfoIsNull_ = false;}
   else{preDefinedVariableInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- preDefinedVariableInfoNode , address : " << preDefinedVariableInfoNode << std::endl;
   #endif
   if(preDefinedVariableInfoNode)
   {
       preDefinedVariableInfo_ = boost::shared_ptr<PreDefinedVariableInfo>(new PreDefinedVariableInfo(preDefinedVariableInfoNode));
   }

   //definedVariableInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* definedVariableInfoNode = xmlNode->FirstChildElement("definedVariableInfo");

   if(definedVariableInfoNode){definedVariableInfoIsNull_ = false;}
   else{definedVariableInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- definedVariableInfoNode , address : " << definedVariableInfoNode << std::endl;
   #endif
   if(definedVariableInfoNode)
   {
       definedVariableInfo_ = boost::shared_ptr<DefinedVariableInfo>(new DefinedVariableInfo(definedVariableInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> VariableInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<NullVariableInfo> VariableInfo::getNullVariableInfo()
{
   if(!this->nullVariableInfoIsNull_){
        return this->nullVariableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NullVariableInfo>();
   }
}
boost::shared_ptr<OverWriteVariableInfo> VariableInfo::getOverWriteVariableInfo()
{
   if(!this->overWriteVariableInfoIsNull_){
        return this->overWriteVariableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OverWriteVariableInfo>();
   }
}
boost::shared_ptr<AdditionVariableInfo> VariableInfo::getAdditionVariableInfo()
{
   if(!this->additionVariableInfoIsNull_){
        return this->additionVariableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<AdditionVariableInfo>();
   }
}
boost::shared_ptr<PreDefinedVariableInfo> VariableInfo::getPreDefinedVariableInfo()
{
   if(!this->preDefinedVariableInfoIsNull_){
        return this->preDefinedVariableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PreDefinedVariableInfo>();
   }
}
boost::shared_ptr<DefinedVariableInfo> VariableInfo::getDefinedVariableInfo()
{
   if(!this->definedVariableInfoIsNull_){
        return this->definedVariableInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DefinedVariableInfo>();
   }
}
}

