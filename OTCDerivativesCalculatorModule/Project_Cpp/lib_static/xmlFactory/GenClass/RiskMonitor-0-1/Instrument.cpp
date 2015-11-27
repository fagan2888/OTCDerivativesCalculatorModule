// Instrument.cpp 
#include "Instrument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Instrument::Instrument(TiXmlNode* xmlNode)
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

   //excel_interfaceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_interfaceNode = xmlNode->FirstChildElement("excel_interface");

   if(excel_interfaceNode){excel_interfaceIsNull_ = false;}
   else{excel_interfaceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_interfaceNode , address : " << excel_interfaceNode << std::endl;
   #endif
   if(excel_interfaceNode)
   {
       excel_interface_ = boost::shared_ptr<Excel_interface>(new Excel_interface(excel_interfaceNode));
   }

   //excel_swapInterfaceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_swapInterfaceNode = xmlNode->FirstChildElement("excel_swapInterface");

   if(excel_swapInterfaceNode){excel_swapInterfaceIsNull_ = false;}
   else{excel_swapInterfaceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_swapInterfaceNode , address : " << excel_swapInterfaceNode << std::endl;
   #endif
   if(excel_swapInterfaceNode)
   {
       excel_swapInterface_ = boost::shared_ptr<Excel_swapInterface>(new Excel_swapInterface(excel_swapInterfaceNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Instrument::getCode()
{
   if(!this->codeIsNull_){
        return this->code_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_interface> Instrument::getExcel_interface()
{
   if(!this->excel_interfaceIsNull_){
        return this->excel_interface_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_interface>();
   }
}
boost::shared_ptr<Excel_swapInterface> Instrument::getExcel_swapInterface()
{
   if(!this->excel_swapInterfaceIsNull_){
        return this->excel_swapInterface_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_swapInterface>();
   }
}
}

