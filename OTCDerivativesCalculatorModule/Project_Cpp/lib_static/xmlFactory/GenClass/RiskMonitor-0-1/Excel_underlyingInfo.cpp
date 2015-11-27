// Excel_underlyingInfo.cpp 
#include "Excel_underlyingInfo.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_underlyingInfo::Excel_underlyingInfo(TiXmlNode* xmlNode)
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

   //excel_stockIndexNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_stockIndexNode = xmlNode->FirstChildElement("excel_stockIndex");

   if(excel_stockIndexNode){excel_stockIndexIsNull_ = false;}
   else{excel_stockIndexIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_stockIndexNode , address : " << excel_stockIndexNode << std::endl;
   #endif
   if(excel_stockIndexNode)
   {
       excel_stockIndex_ = boost::shared_ptr<Excel_stockIndex>(new Excel_stockIndex(excel_stockIndexNode));
   }

   //excel_interestRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_interestRateNode = xmlNode->FirstChildElement("excel_interestRate");

   if(excel_interestRateNode){excel_interestRateIsNull_ = false;}
   else{excel_interestRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_interestRateNode , address : " << excel_interestRateNode << std::endl;
   #endif
   if(excel_interestRateNode)
   {
       excel_interestRate_ = boost::shared_ptr<Excel_interestRate>(new Excel_interestRate(excel_interestRateNode));
   }

   //excel_indexTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_indexTypeNode = xmlNode->FirstChildElement("excel_indexType");

   if(excel_indexTypeNode){excel_indexTypeIsNull_ = false;}
   else{excel_indexTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_indexTypeNode , address : " << excel_indexTypeNode << std::endl;
   #endif
   if(excel_indexTypeNode)
   {
       excel_indexType_ = boost::shared_ptr<Excel_indexType>(new Excel_indexType(excel_indexTypeNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_underlyingInfo::getExcel_type()
{
   if(!this->excel_typeIsNull_){
        return this->excel_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_stockIndex> Excel_underlyingInfo::getExcel_stockIndex()
{
   if(!this->excel_stockIndexIsNull_){
        return this->excel_stockIndex_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_stockIndex>();
   }
}
boost::shared_ptr<Excel_interestRate> Excel_underlyingInfo::getExcel_interestRate()
{
   if(!this->excel_interestRateIsNull_){
        return this->excel_interestRate_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_interestRate>();
   }
}
boost::shared_ptr<Excel_indexType> Excel_underlyingInfo::getExcel_indexType()
{
   if(!this->excel_indexTypeIsNull_){
        return this->excel_indexType_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_indexType>();
   }
}
}

