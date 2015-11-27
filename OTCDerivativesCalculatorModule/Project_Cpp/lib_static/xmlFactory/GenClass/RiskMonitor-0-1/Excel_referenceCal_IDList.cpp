// Excel_referenceCal_IDList.cpp 
#include "Excel_referenceCal_IDList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referenceCal_IDList::Excel_referenceCal_IDList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_referenceCal_IDNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_referenceCal_IDNode = xmlNode->FirstChildElement("excel_referenceCal_ID");

   if(excel_referenceCal_IDNode){excel_referenceCal_IDIsNull_ = false;}
   else{excel_referenceCal_IDIsNull_ = true;}

   if(excel_referenceCal_IDNode)
   {
      for(excel_referenceCal_IDNode; excel_referenceCal_IDNode; excel_referenceCal_IDNode = excel_referenceCal_IDNode->NextSiblingElement("excel_referenceCal_ID")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceCal_IDNode , address : " << excel_referenceCal_IDNode << std::endl;
          #endif
          excel_referenceCal_ID_.push_back(boost::shared_ptr<Excel_referenceCal_ID>(new Excel_referenceCal_ID(excel_referenceCal_IDNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceCal_IDNode , address : " << excel_referenceCal_IDNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_referenceCal_ID>> Excel_referenceCal_IDList::getExcel_referenceCal_ID()
{
   if(!this->excel_referenceCal_IDIsNull_){
        return this->excel_referenceCal_ID_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_referenceCal_ID>>();
   }
}
}

