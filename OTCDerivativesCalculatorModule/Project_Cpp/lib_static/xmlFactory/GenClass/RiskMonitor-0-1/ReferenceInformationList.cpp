// ReferenceInformationList.cpp 
#include "ReferenceInformationList.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ReferenceInformationList::ReferenceInformationList(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceInformationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceInformationNode = xmlNode->FirstChildElement("referenceInformation");

   if(referenceInformationNode){referenceInformationIsNull_ = false;}
   else{referenceInformationIsNull_ = true;}

   if(referenceInformationNode)
   {
      for(referenceInformationNode; referenceInformationNode; referenceInformationNode = referenceInformationNode->NextSiblingElement("referenceInformation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceInformationNode , address : " << referenceInformationNode << std::endl;
          #endif
          referenceInformation_.push_back(boost::shared_ptr<ReferenceInformation>(new ReferenceInformation(referenceInformationNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceInformationNode , address : " << referenceInformationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<ReferenceInformation>> ReferenceInformationList::getReferenceInformation()
{
   if(!this->referenceInformationIsNull_){
        return this->referenceInformation_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<ReferenceInformation>>();
   }
}
}

