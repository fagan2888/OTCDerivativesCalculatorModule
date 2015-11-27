// Excel_referenceInformationList.cpp 
#include "Excel_referenceInformationList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referenceInformationList::Excel_referenceInformationList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_referenceInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_referenceInformationNode = xmlNode->FirstChildElement("excel_referenceInformation");

   if(excel_referenceInformationNode){excel_referenceInformationIsNull_ = false;}
   else{excel_referenceInformationIsNull_ = true;}

   if(excel_referenceInformationNode)
   {
      for(excel_referenceInformationNode; excel_referenceInformationNode; excel_referenceInformationNode = excel_referenceInformationNode->NextSiblingElement("excel_referenceInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceInformationNode , address : " << excel_referenceInformationNode << std::endl;
          #endif
          excel_referenceInformation_.push_back(boost::shared_ptr<Excel_referenceInformation>(new Excel_referenceInformation(excel_referenceInformationNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceInformationNode , address : " << excel_referenceInformationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_referenceInformation>> Excel_referenceInformationList::getExcel_referenceInformation()
{
   if(!this->excel_referenceInformationIsNull_){
        return this->excel_referenceInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_referenceInformation>>();
   }
}
}

