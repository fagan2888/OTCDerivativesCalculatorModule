// BusinessCenters.cpp 
#include "BusinessCenters.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BusinessCenters::BusinessCenters(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //businessCenterNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* businessCenterNode = xmlNode->FirstChildElement("businessCenter");

   if(businessCenterNode){businessCenterIsNull_ = false;}
   else{businessCenterIsNull_ = true;}

   if(businessCenterNode)
   {
      for(businessCenterNode; businessCenterNode; businessCenterNode = businessCenterNode->NextSiblingElement("businessCenter")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCenterNode , address : " << businessCenterNode << std::endl;
          #endif
          if(businessCenterNode->Attribute("href") || businessCenterNode->Attribute("id"))
          {
              if(businessCenterNode->Attribute("id"))
              {
                  businessCenterIDRef_ = businessCenterNode->Attribute("id");
                  businessCenter_.push_back(boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode)));
                  businessCenter_.back()->setID(businessCenterIDRef_);
                  IDManager::instance().setID(businessCenterIDRef_, businessCenter_.back());
              }
              else if(businessCenterNode->Attribute("href")) { businessCenterIDRef_ = businessCenterNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { businessCenter_.push_back(boost::shared_ptr<BusinessCenter>(new BusinessCenter(businessCenterNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- businessCenterNode , address : " << businessCenterNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<BusinessCenter>> BusinessCenters::getBusinessCenter()
{
   if(!this->businessCenterIsNull_){
        if(businessCenterIDRef_ != ""){
             return this->businessCenter_;
        }else{
             return this->businessCenter_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<BusinessCenter>>();
   }
}
}

