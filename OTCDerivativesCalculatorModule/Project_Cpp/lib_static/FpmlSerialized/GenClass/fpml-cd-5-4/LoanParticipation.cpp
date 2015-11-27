// LoanParticipation.cpp 
#include "LoanParticipation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

LoanParticipation::LoanParticipation(TiXmlNode* xmlNode)
: PCDeliverableObligationCharac(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //qualifyingParticipationSellerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* qualifyingParticipationSellerNode = xmlNode->FirstChildElement("qualifyingParticipationSeller");

   if(qualifyingParticipationSellerNode){qualifyingParticipationSellerIsNull_ = false;}
   else{qualifyingParticipationSellerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- qualifyingParticipationSellerNode , address : " << qualifyingParticipationSellerNode << std::endl;
   #endif
   if(qualifyingParticipationSellerNode)
   {
      if(qualifyingParticipationSellerNode->Attribute("href") || qualifyingParticipationSellerNode->Attribute("id"))
      {
          if(qualifyingParticipationSellerNode->Attribute("id"))
          {
             qualifyingParticipationSellerIDRef_ = qualifyingParticipationSellerNode->Attribute("id");
             qualifyingParticipationSeller_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(qualifyingParticipationSellerNode));
             qualifyingParticipationSeller_->setID(qualifyingParticipationSellerIDRef_);
             IDManager::instance().setID(qualifyingParticipationSellerIDRef_,qualifyingParticipationSeller_);
          }
          else if(qualifyingParticipationSellerNode->Attribute("href")) { qualifyingParticipationSellerIDRef_ = qualifyingParticipationSellerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { qualifyingParticipationSeller_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(qualifyingParticipationSellerNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeString> LoanParticipation::getQualifyingParticipationSeller()
{
   if(!this->qualifyingParticipationSellerIsNull_){
        if(qualifyingParticipationSellerIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(qualifyingParticipationSellerIDRef_));
        }else{
             return this->qualifyingParticipationSeller_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

