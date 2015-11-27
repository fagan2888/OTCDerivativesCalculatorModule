// ElectricityTransmissionContingency.cpp 
#include "ElectricityTransmissionContingency.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ElectricityTransmissionContingency::ElectricityTransmissionContingency(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //contingencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contingencyNode = xmlNode->FirstChildElement("contingency");

   if(contingencyNode){contingencyIsNull_ = false;}
   else{contingencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contingencyNode , address : " << contingencyNode << std::endl;
   #endif
   if(contingencyNode)
   {
      if(contingencyNode->Attribute("href") || contingencyNode->Attribute("id"))
      {
          if(contingencyNode->Attribute("id"))
          {
             contingencyIDRef_ = contingencyNode->Attribute("id");
             contingency_ = boost::shared_ptr<ElectricityTransmissionContingencyType>(new ElectricityTransmissionContingencyType(contingencyNode));
             contingency_->setID(contingencyIDRef_);
             IDManager::instance().setID(contingencyIDRef_,contingency_);
          }
          else if(contingencyNode->Attribute("href")) { contingencyIDRef_ = contingencyNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { contingency_ = boost::shared_ptr<ElectricityTransmissionContingencyType>(new ElectricityTransmissionContingencyType(contingencyNode));}
   }

   //contingentPartyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* contingentPartyNode = xmlNode->FirstChildElement("contingentParty");

   if(contingentPartyNode){contingentPartyIsNull_ = false;}
   else{contingentPartyIsNull_ = true;}

   if(contingentPartyNode)
   {
      for(contingentPartyNode; contingentPartyNode; contingentPartyNode = contingentPartyNode->NextSiblingElement("contingentParty")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contingentPartyNode , address : " << contingentPartyNode << std::endl;
          #endif
          if(contingentPartyNode->Attribute("href") || contingentPartyNode->Attribute("id"))
          {
              if(contingentPartyNode->Attribute("id"))
              {
                  contingentPartyIDRef_ = contingentPartyNode->Attribute("id");
                  contingentParty_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(contingentPartyNode)));
                  contingentParty_.back()->setID(contingentPartyIDRef_);
                  IDManager::instance().setID(contingentPartyIDRef_, contingentParty_.back());
              }
              else if(contingentPartyNode->Attribute("href")) { contingentPartyIDRef_ = contingentPartyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { contingentParty_.push_back(boost::shared_ptr<PartyReference>(new PartyReference(contingentPartyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- contingentPartyNode , address : " << contingentPartyNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ElectricityTransmissionContingencyType> ElectricityTransmissionContingency::getContingency()
{
   if(!this->contingencyIsNull_){
        if(contingencyIDRef_ != ""){
             return boost::shared_static_cast<ElectricityTransmissionContingencyType>(IDManager::instance().getID(contingencyIDRef_));
        }else{
             return this->contingency_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ElectricityTransmissionContingencyType>();
   }
}
std::vector<boost::shared_ptr<PartyReference>> ElectricityTransmissionContingency::getContingentParty()
{
   if(!this->contingentPartyIsNull_){
        if(contingentPartyIDRef_ != ""){
             return this->contingentParty_;
        }else{
             return this->contingentParty_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PartyReference>>();
   }
}
}

