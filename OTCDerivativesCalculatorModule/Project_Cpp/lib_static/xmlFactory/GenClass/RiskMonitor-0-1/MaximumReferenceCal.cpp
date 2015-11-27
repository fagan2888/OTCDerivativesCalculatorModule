// MaximumReferenceCal.cpp 
#include "MaximumReferenceCal.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MaximumReferenceCal::MaximumReferenceCal(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //nthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nthNode = xmlNode->FirstChildElement("nth");

   if(nthNode){nthIsNull_ = false;}
   else{nthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nthNode , address : " << nthNode << std::endl;
   #endif
   if(nthNode)
   {
       nth_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(nthNode));
   }

   //selectedUnderNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* selectedUnderNameNode = xmlNode->FirstChildElement("selectedUnderName");

   if(selectedUnderNameNode){selectedUnderNameIsNull_ = false;}
   else{selectedUnderNameIsNull_ = true;}

   if(selectedUnderNameNode)
   {
      for(selectedUnderNameNode; selectedUnderNameNode; selectedUnderNameNode = selectedUnderNameNode->NextSiblingElement("selectedUnderName")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- selectedUnderNameNode , address : " << selectedUnderNameNode << std::endl;
          #endif
          selectedUnderName_.push_back(boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(selectedUnderNameNode)));
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- selectedUnderNameNode , address : " << selectedUnderNameNode << std::endl;
       #endif
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
boost::shared_ptr<XsdTypeDouble> MaximumReferenceCal::getNth()
{
   if(!this->nthIsNull_){
        return this->nth_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
std::vector<boost::shared_ptr<XsdTypeToken>> MaximumReferenceCal::getSelectedUnderName()
{
   if(!this->selectedUnderNameIsNull_){
        return this->selectedUnderName_;
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeToken>>();
   }
}
boost::shared_ptr<FixingDateInfo> MaximumReferenceCal::getFixingDateInfo()
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

