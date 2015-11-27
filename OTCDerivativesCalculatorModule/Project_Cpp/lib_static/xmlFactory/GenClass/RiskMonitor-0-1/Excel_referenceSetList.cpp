// Excel_referenceSetList.cpp 
#include "Excel_referenceSetList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referenceSetList::Excel_referenceSetList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //excel_referenceSetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_referenceSetNode = xmlNode->FirstChildElement("excel_referenceSet");

   if(excel_referenceSetNode){excel_referenceSetIsNull_ = false;}
   else{excel_referenceSetIsNull_ = true;}

   if(excel_referenceSetNode)
   {
      for(excel_referenceSetNode; excel_referenceSetNode; excel_referenceSetNode = excel_referenceSetNode->NextSiblingElement("excel_referenceSet")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceSetNode , address : " << excel_referenceSetNode << std::endl;
          #endif
          excel_referenceSet_.push_back(boost::shared_ptr<Excel_referenceSet>(new Excel_referenceSet(excel_referenceSetNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceSetNode , address : " << excel_referenceSetNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Excel_referenceSet>> Excel_referenceSetList::getExcel_referenceSet()
{
   if(!this->excel_referenceSetIsNull_){
        return this->excel_referenceSet_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Excel_referenceSet>>();
   }
}
}

