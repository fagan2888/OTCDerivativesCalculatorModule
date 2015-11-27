// AndSimpleCal.cpp 
#include "AndSimpleCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AndSimpleCal::AndSimpleCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //pastOccNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pastOccNode = xmlNode->FirstChildElement("pastOcc");

   if(pastOccNode){pastOccIsNull_ = false;}
   else{pastOccIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pastOccNode , address : " << pastOccNode << std::endl;
   #endif
   if(pastOccNode)
   {
       pastOcc_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(pastOccNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeBoolean> AndSimpleCal::getPastOcc()
{
   if(!this->pastOccIsNull_){
        return this->pastOcc_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

