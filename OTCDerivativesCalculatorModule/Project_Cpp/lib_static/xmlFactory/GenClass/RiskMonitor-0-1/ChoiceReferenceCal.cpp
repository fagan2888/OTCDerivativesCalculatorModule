// ChoiceReferenceCal.cpp 
#include "ChoiceReferenceCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ChoiceReferenceCal::ChoiceReferenceCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //selectedUnderNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* selectedUnderNameNode = xmlNode->FirstChildElement("selectedUnderName");

   if(selectedUnderNameNode){selectedUnderNameIsNull_ = false;}
   else{selectedUnderNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- selectedUnderNameNode , address : " << selectedUnderNameNode << std::endl;
   #endif
   if(selectedUnderNameNode)
   {
       selectedUnderName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(selectedUnderNameNode));
   }

   //fixingDateInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* fixingDateInfoNode = xmlNode->FirstChildElement("fixingDateInfo");

   if(fixingDateInfoNode){fixingDateInfoIsNull_ = false;}
   else{fixingDateInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- fixingDateInfoNode , address : " << fixingDateInfoNode << std::endl;
   #endif
   if(fixingDateInfoNode)
   {
       fixingDateInfo_ = boost::shared_ptr<FixingDateInfo>(new FixingDateInfo(fixingDateInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ChoiceReferenceCal::getSelectedUnderName()
{
   if(!this->selectedUnderNameIsNull_){
        return this->selectedUnderName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<FixingDateInfo> ChoiceReferenceCal::getFixingDateInfo()
{
   if(!this->fixingDateInfoIsNull_){
        return this->fixingDateInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FixingDateInfo>();
   }
}
}

