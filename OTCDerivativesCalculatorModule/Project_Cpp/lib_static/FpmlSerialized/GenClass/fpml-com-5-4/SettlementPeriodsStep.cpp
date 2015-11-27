// SettlementPeriodsStep.cpp 
#include "SettlementPeriodsStep.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementPeriodsStep::SettlementPeriodsStep(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //settlementPeriodsReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementPeriodsReferenceNode = xmlNode->FirstChildElement("settlementPeriodsReference");

   if(settlementPeriodsReferenceNode){settlementPeriodsReferenceIsNull_ = false;}
   else{settlementPeriodsReferenceIsNull_ = true;}

   if(settlementPeriodsReferenceNode)
   {
      for(settlementPeriodsReferenceNode; settlementPeriodsReferenceNode; settlementPeriodsReferenceNode = settlementPeriodsReferenceNode->NextSiblingElement("settlementPeriodsReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsReferenceNode , address : " << settlementPeriodsReferenceNode << std::endl;
          #endif
          if(settlementPeriodsReferenceNode->Attribute("href") || settlementPeriodsReferenceNode->Attribute("id"))
          {
              if(settlementPeriodsReferenceNode->Attribute("id"))
              {
                  settlementPeriodsReferenceIDRef_ = settlementPeriodsReferenceNode->Attribute("id");
                  settlementPeriodsReference_.push_back(boost::shared_ptr<SettlementPeriodsReference>(new SettlementPeriodsReference(settlementPeriodsReferenceNode)));
                  settlementPeriodsReference_.back()->setID(settlementPeriodsReferenceIDRef_);
                  IDManager::instance().setID(settlementPeriodsReferenceIDRef_, settlementPeriodsReference_.back());
              }
              else if(settlementPeriodsReferenceNode->Attribute("href")) { settlementPeriodsReferenceIDRef_ = settlementPeriodsReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { settlementPeriodsReference_.push_back(boost::shared_ptr<SettlementPeriodsReference>(new SettlementPeriodsReference(settlementPeriodsReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementPeriodsReferenceNode , address : " << settlementPeriodsReferenceNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<SettlementPeriodsReference>> SettlementPeriodsStep::getSettlementPeriodsReference()
{
   if(!this->settlementPeriodsReferenceIsNull_){
        if(settlementPeriodsReferenceIDRef_ != ""){
             return this->settlementPeriodsReference_;
        }else{
             return this->settlementPeriodsReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<SettlementPeriodsReference>>();
   }
}
}

