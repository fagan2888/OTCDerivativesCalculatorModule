// SettlementInformation.cpp 
#include "SettlementInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SettlementInformation::SettlementInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //standardSettlementStyleNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* standardSettlementStyleNode = xmlNode->FirstChildElement("standardSettlementStyle");

   if(standardSettlementStyleNode){standardSettlementStyleIsNull_ = false;}
   else{standardSettlementStyleIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- standardSettlementStyleNode , address : " << standardSettlementStyleNode << std::endl;
   #endif
   if(standardSettlementStyleNode)
   {
      if(standardSettlementStyleNode->Attribute("href") || standardSettlementStyleNode->Attribute("id"))
      {
          if(standardSettlementStyleNode->Attribute("id"))
          {
             standardSettlementStyleIDRef_ = standardSettlementStyleNode->Attribute("id");
             standardSettlementStyle_ = boost::shared_ptr<StandardSettlementStyleEnum>(new StandardSettlementStyleEnum(standardSettlementStyleNode));
             standardSettlementStyle_->setID(standardSettlementStyleIDRef_);
             IDManager::instance().setID(standardSettlementStyleIDRef_,standardSettlementStyle_);
          }
          else if(standardSettlementStyleNode->Attribute("href")) { standardSettlementStyleIDRef_ = standardSettlementStyleNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { standardSettlementStyle_ = boost::shared_ptr<StandardSettlementStyleEnum>(new StandardSettlementStyleEnum(standardSettlementStyleNode));}
   }

   //settlementInstructionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* settlementInstructionNode = xmlNode->FirstChildElement("settlementInstruction");

   if(settlementInstructionNode){settlementInstructionIsNull_ = false;}
   else{settlementInstructionIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- settlementInstructionNode , address : " << settlementInstructionNode << std::endl;
   #endif
   if(settlementInstructionNode)
   {
      if(settlementInstructionNode->Attribute("href") || settlementInstructionNode->Attribute("id"))
      {
          if(settlementInstructionNode->Attribute("id"))
          {
             settlementInstructionIDRef_ = settlementInstructionNode->Attribute("id");
             settlementInstruction_ = boost::shared_ptr<SettlementInstruction>(new SettlementInstruction(settlementInstructionNode));
             settlementInstruction_->setID(settlementInstructionIDRef_);
             IDManager::instance().setID(settlementInstructionIDRef_,settlementInstruction_);
          }
          else if(settlementInstructionNode->Attribute("href")) { settlementInstructionIDRef_ = settlementInstructionNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { settlementInstruction_ = boost::shared_ptr<SettlementInstruction>(new SettlementInstruction(settlementInstructionNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<StandardSettlementStyleEnum> SettlementInformation::getStandardSettlementStyle()
{
   if(!this->standardSettlementStyleIsNull_){
        if(standardSettlementStyleIDRef_ != ""){
             return boost::shared_static_cast<StandardSettlementStyleEnum>(IDManager::instance().getID(standardSettlementStyleIDRef_));
        }else{
             return this->standardSettlementStyle_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StandardSettlementStyleEnum>();
   }
}
boost::shared_ptr<SettlementInstruction> SettlementInformation::getSettlementInstruction()
{
   if(!this->settlementInstructionIsNull_){
        if(settlementInstructionIDRef_ != ""){
             return boost::shared_static_cast<SettlementInstruction>(IDManager::instance().getID(settlementInstructionIDRef_));
        }else{
             return this->settlementInstruction_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SettlementInstruction>();
   }
}
}

