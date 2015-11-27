// Excel_dualBarrierEventCal.cpp 
#include "Excel_dualBarrierEventCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_dualBarrierEventCal::Excel_dualBarrierEventCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //lowerRngNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowerRngNode = xmlNode->FirstChildElement("lowerRng");

   if(lowerRngNode){lowerRngIsNull_ = false;}
   else{lowerRngIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowerRngNode , address : " << lowerRngNode << std::endl;
   #endif
   if(lowerRngNode)
   {
       lowerRng_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(lowerRngNode));
   }

   //upperRngNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* upperRngNode = xmlNode->FirstChildElement("upperRng");

   if(upperRngNode){upperRngIsNull_ = false;}
   else{upperRngIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- upperRngNode , address : " << upperRngNode << std::endl;
   #endif
   if(upperRngNode)
   {
       upperRng_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(upperRngNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_dualBarrierEventCal::getLowerRng()
{
   if(!this->lowerRngIsNull_){
        return this->lowerRng_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_dualBarrierEventCal::getUpperRng()
{
   if(!this->upperRngIsNull_){
        return this->upperRng_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

