// Excel_compositeOption_subtype.cpp 
#include "Excel_compositeOption_subtype.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_compositeOption_subtype::Excel_compositeOption_subtype(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_typeNode = xmlNode->FirstChildElement("excel_type");

   if(excel_typeNode){excel_typeIsNull_ = false;}
   else{excel_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_typeNode , address : " << excel_typeNode << std::endl;
   #endif
   if(excel_typeNode)
   {
       excel_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(excel_typeNode));
   }

   //excel_vanillaCallPutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_vanillaCallPutNode = xmlNode->FirstChildElement("excel_vanillaCallPut");

   if(excel_vanillaCallPutNode){excel_vanillaCallPutIsNull_ = false;}
   else{excel_vanillaCallPutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_vanillaCallPutNode , address : " << excel_vanillaCallPutNode << std::endl;
   #endif
   if(excel_vanillaCallPutNode)
   {
       excel_vanillaCallPut_ = boost::shared_ptr<Excel_vanillaCallPut>(new Excel_vanillaCallPut(excel_vanillaCallPutNode));
   }

   //excel_upInOutCallNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_upInOutCallNode = xmlNode->FirstChildElement("excel_upInOutCall");

   if(excel_upInOutCallNode){excel_upInOutCallIsNull_ = false;}
   else{excel_upInOutCallIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_upInOutCallNode , address : " << excel_upInOutCallNode << std::endl;
   #endif
   if(excel_upInOutCallNode)
   {
       excel_upInOutCall_ = boost::shared_ptr<Excel_upInOutCall>(new Excel_upInOutCall(excel_upInOutCallNode));
   }

   //excel_downInOutPutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_downInOutPutNode = xmlNode->FirstChildElement("excel_downInOutPut");

   if(excel_downInOutPutNode){excel_downInOutPutIsNull_ = false;}
   else{excel_downInOutPutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_downInOutPutNode , address : " << excel_downInOutPutNode << std::endl;
   #endif
   if(excel_downInOutPutNode)
   {
       excel_downInOutPut_ = boost::shared_ptr<Excel_downInOutPut>(new Excel_downInOutPut(excel_downInOutPutNode));
   }

   //excel_digitalCallPutNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_digitalCallPutNode = xmlNode->FirstChildElement("excel_digitalCallPut");

   if(excel_digitalCallPutNode){excel_digitalCallPutIsNull_ = false;}
   else{excel_digitalCallPutIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_digitalCallPutNode , address : " << excel_digitalCallPutNode << std::endl;
   #endif
   if(excel_digitalCallPutNode)
   {
       excel_digitalCallPut_ = boost::shared_ptr<Excel_digitalCallPut>(new Excel_digitalCallPut(excel_digitalCallPutNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_compositeOption_subtype::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_vanillaCallPut> Excel_compositeOption_subtype::getExcel_vanillaCallPut()
{
   if(!this->excel_vanillaCallPutIsNull_){
        return this->excel_vanillaCallPut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_vanillaCallPut>();
   }
}
boost::shared_ptr<Excel_upInOutCall> Excel_compositeOption_subtype::getExcel_upInOutCall()
{
   if(!this->excel_upInOutCallIsNull_){
        return this->excel_upInOutCall_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_upInOutCall>();
   }
}
boost::shared_ptr<Excel_downInOutPut> Excel_compositeOption_subtype::getExcel_downInOutPut()
{
   if(!this->excel_downInOutPutIsNull_){
        return this->excel_downInOutPut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_downInOutPut>();
   }
}
boost::shared_ptr<Excel_digitalCallPut> Excel_compositeOption_subtype::getExcel_digitalCallPut()
{
   if(!this->excel_digitalCallPutIsNull_){
        return this->excel_digitalCallPut_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_digitalCallPut>();
   }
}
}

