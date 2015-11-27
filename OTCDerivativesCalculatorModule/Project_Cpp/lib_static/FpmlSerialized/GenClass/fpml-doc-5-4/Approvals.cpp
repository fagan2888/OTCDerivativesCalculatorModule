// Approvals.cpp 
#include "Approvals.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Approvals::Approvals(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //approvalNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* approvalNode = xmlNode->FirstChildElement("approval");

   if(approvalNode){approvalIsNull_ = false;}
   else{approvalIsNull_ = true;}

   if(approvalNode)
   {
      for(approvalNode; approvalNode; approvalNode = approvalNode->NextSiblingElement("approval")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- approvalNode , address : " << approvalNode << std::endl;
          #endif
          if(approvalNode->Attribute("href") || approvalNode->Attribute("id"))
          {
              if(approvalNode->Attribute("id"))
              {
                  approvalIDRef_ = approvalNode->Attribute("id");
                  approval_.push_back(boost::shared_ptr<Approval>(new Approval(approvalNode)));
                  approval_.back()->setID(approvalIDRef_);
                  IDManager::instance().setID(approvalIDRef_, approval_.back());
              }
              else if(approvalNode->Attribute("href")) { approvalIDRef_ = approvalNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { approval_.push_back(boost::shared_ptr<Approval>(new Approval(approvalNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- approvalNode , address : " << approvalNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Approval>> Approvals::getApproval()
{
   if(!this->approvalIsNull_){
        if(approvalIDRef_ != ""){
             return this->approval_;
        }else{
             return this->approval_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Approval>>();
   }
}
}

