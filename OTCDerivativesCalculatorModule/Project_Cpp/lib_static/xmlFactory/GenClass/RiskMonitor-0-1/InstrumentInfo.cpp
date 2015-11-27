// InstrumentInfo.cpp 
#include "InstrumentInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentInfo::InstrumentInfo(TiXmlNode* xmlNode)
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

   //standardInstrumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardInstrumentNode = xmlNode->FirstChildElement("standardInstrument");

   if(standardInstrumentNode){standardInstrumentIsNull_ = false;}
   else{standardInstrumentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardInstrumentNode , address : " << standardInstrumentNode << std::endl;
   #endif
   if(standardInstrumentNode)
   {
       standardInstrument_ = boost::shared_ptr<StandardInstrument>(new StandardInstrument(standardInstrumentNode));
   }

   //standardSwapInstrumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardSwapInstrumentNode = xmlNode->FirstChildElement("standardSwapInstrument");

   if(standardSwapInstrumentNode){standardSwapInstrumentIsNull_ = false;}
   else{standardSwapInstrumentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardSwapInstrumentNode , address : " << standardSwapInstrumentNode << std::endl;
   #endif
   if(standardSwapInstrumentNode)
   {
       standardSwapInstrument_ = boost::shared_ptr<StandardSwapInstrument>(new StandardSwapInstrument(standardSwapInstrumentNode));
   }

   //creditInstrumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* creditInstrumentNode = xmlNode->FirstChildElement("creditInstrument");

   if(creditInstrumentNode){creditInstrumentIsNull_ = false;}
   else{creditInstrumentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- creditInstrumentNode , address : " << creditInstrumentNode << std::endl;
   #endif
   if(creditInstrumentNode)
   {
       creditInstrument_ = boost::shared_ptr<CreditInstrument>(new CreditInstrument(creditInstrumentNode));
   }

   //fixedBondInstrumentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixedBondInstrumentNode = xmlNode->FirstChildElement("fixedBondInstrument");

   if(fixedBondInstrumentNode){fixedBondInstrumentIsNull_ = false;}
   else{fixedBondInstrumentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixedBondInstrumentNode , address : " << fixedBondInstrumentNode << std::endl;
   #endif
   if(fixedBondInstrumentNode)
   {
       fixedBondInstrument_ = boost::shared_ptr<FixedBondInstrument>(new FixedBondInstrument(fixedBondInstrumentNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> InstrumentInfo::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<StandardInstrument> InstrumentInfo::getStandardInstrument()
{
   if(!this->standardInstrumentIsNull_){
        return this->standardInstrument_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StandardInstrument>();
   }
}
boost::shared_ptr<StandardSwapInstrument> InstrumentInfo::getStandardSwapInstrument()
{
   if(!this->standardSwapInstrumentIsNull_){
        return this->standardSwapInstrument_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StandardSwapInstrument>();
   }
}
boost::shared_ptr<CreditInstrument> InstrumentInfo::getCreditInstrument()
{
   if(!this->creditInstrumentIsNull_){
        return this->creditInstrument_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CreditInstrument>();
   }
}
boost::shared_ptr<FixedBondInstrument> InstrumentInfo::getFixedBondInstrument()
{
   if(!this->fixedBondInstrumentIsNull_){
        return this->fixedBondInstrument_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixedBondInstrument>();
   }
}
}

