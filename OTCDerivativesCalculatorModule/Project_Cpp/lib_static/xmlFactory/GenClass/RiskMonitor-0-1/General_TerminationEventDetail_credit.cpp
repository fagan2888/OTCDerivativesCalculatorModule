// General_TerminationEventDetail_credit.cpp 
#include "General_TerminationEventDetail_credit.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

General_TerminationEventDetail_credit::General_TerminationEventDetail_credit(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //referenceEntityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceEntityNode = xmlNode->FirstChildElement("referenceEntity");

   if(referenceEntityNode){referenceEntityIsNull_ = false;}
   else{referenceEntityIsNull_ = true;}

   if(referenceEntityNode)
   {
      for(referenceEntityNode; referenceEntityNode; referenceEntityNode = referenceEntityNode->NextSiblingElement("referenceEntity")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceEntityNode , address : " << referenceEntityNode << std::endl;
          #endif
          referenceEntity_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(referenceEntityNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceEntityNode , address : " << referenceEntityNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<XsdTypeToken>> General_TerminationEventDetail_credit::getReferenceEntity()
{
   if(!this->referenceEntityIsNull_){
        return this->referenceEntity_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
}

