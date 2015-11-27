// Allocations.cpp 
#include "Allocations.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Allocations::Allocations(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //allocationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* allocationNode = xmlNode->FirstChildElement("allocation");

   if(allocationNode){allocationIsNull_ = false;}
   else{allocationIsNull_ = true;}

   if(allocationNode)
   {
      for(allocationNode; allocationNode; allocationNode = allocationNode->NextSiblingElement("allocation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationNode , address : " << allocationNode << std::endl;
          #endif
          if(allocationNode->Attribute("href") || allocationNode->Attribute("id"))
          {
              if(allocationNode->Attribute("id"))
              {
                  allocationIDRef_ = allocationNode->Attribute("id");
                  allocation_.push_back(boost::shared_ptr<Allocation>(new Allocation(allocationNode)));
                  allocation_.back()->setID(allocationIDRef_);
                  IDManager::instance().setID(allocationIDRef_, allocation_.back());
              }
              else if(allocationNode->Attribute("href")) { allocationIDRef_ = allocationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { allocation_.push_back(boost::shared_ptr<Allocation>(new Allocation(allocationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- allocationNode , address : " << allocationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Allocation>> Allocations::getAllocation()
{
   if(!this->allocationIsNull_){
        if(allocationIDRef_ != ""){
             return this->allocation_;
        }else{
             return this->allocation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Allocation>>();
   }
}
}

