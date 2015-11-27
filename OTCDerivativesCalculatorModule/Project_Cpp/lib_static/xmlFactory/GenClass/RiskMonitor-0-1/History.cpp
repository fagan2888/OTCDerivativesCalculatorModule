// History.cpp 
#include "History.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

History::History(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //hisoryDataNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hisoryDataNode = xmlNode->FirstChildElement("hisoryData");

   if(hisoryDataNode){hisoryDataIsNull_ = false;}
   else{hisoryDataIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hisoryDataNode , address : " << hisoryDataNode << std::endl;
   #endif
   if(hisoryDataNode)
   {
       hisoryData_ = boost::shared_ptr<HisoryData>(new HisoryData(hisoryDataNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<HisoryData> History::getHisoryData()
{
   if(!this->hisoryDataIsNull_){
        return this->hisoryData_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<HisoryData>();
   }
}
}

