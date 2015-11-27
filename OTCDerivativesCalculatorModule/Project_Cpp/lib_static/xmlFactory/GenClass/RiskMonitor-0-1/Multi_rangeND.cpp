// Multi_rangeND.cpp 
#include "Multi_rangeND.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Multi_rangeND::Multi_rangeND(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //joint_typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* joint_typeNode = xmlNode->FirstChildElement("joint_type");

   if(joint_typeNode){joint_typeIsNull_ = false;}
   else{joint_typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- joint_typeNode , address : " << joint_typeNode << std::endl;
   #endif
   if(joint_typeNode)
   {
       joint_type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(joint_typeNode));
   }

   //range1DNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* range1DNode = xmlNode->FirstChildElement("range1D");

   if(range1DNode){range1DIsNull_ = false;}
   else{range1DIsNull_ = true;}

   if(range1DNode)
   {
      for(range1DNode; range1DNode; range1DNode = range1DNode->NextSiblingElement("range1D")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- range1DNode , address : " << range1DNode << std::endl;
          #endif
          range1D_.push_back(boost::shared_ptr<Range1D>(new Range1D(range1DNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- range1DNode , address : " << range1DNode << std::endl;
       #endif
   }

   //excel_underlyingCalcIDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_underlyingCalcIDNode = xmlNode->FirstChildElement("excel_underlyingCalcID");

   if(excel_underlyingCalcIDNode){excel_underlyingCalcIDIsNull_ = false;}
   else{excel_underlyingCalcIDIsNull_ = true;}

   if(excel_underlyingCalcIDNode)
   {
      for(excel_underlyingCalcIDNode; excel_underlyingCalcIDNode; excel_underlyingCalcIDNode = excel_underlyingCalcIDNode->NextSiblingElement("excel_underlyingCalcID")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingCalcIDNode , address : " << excel_underlyingCalcIDNode << std::endl;
          #endif
          excel_underlyingCalcID_.push_back(boost::shared_ptr<Excel_underlyingCalcID>(new Excel_underlyingCalcID(excel_underlyingCalcIDNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_underlyingCalcIDNode , address : " << excel_underlyingCalcIDNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Multi_rangeND::getJoint_type()
{
   if(!this->joint_typeIsNull_){
        return this->joint_type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
std::vector<boost::shared_ptr<Range1D>> Multi_rangeND::getRange1D()
{
   if(!this->range1DIsNull_){
        return this->range1D_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Range1D>>();
   }
}
std::vector<boost::shared_ptr<Excel_underlyingCalcID>> Multi_rangeND::getExcel_underlyingCalcID()
{
   if(!this->excel_underlyingCalcIDIsNull_){
        return this->excel_underlyingCalcID_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_underlyingCalcID>>();
   }
}
}

