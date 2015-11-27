// PartyPortfolioName.cpp 
#include "PartyPortfolioName.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PartyPortfolioName::PartyPortfolioName(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //partyReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyReferenceNode = xmlNode->FirstChildElement("partyReference");

   if(partyReferenceNode){partyReferenceIsNull_ = false;}
   else{partyReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyReferenceNode , address : " << partyReferenceNode << std::endl;
   #endif
   if(partyReferenceNode)
   {
      if(partyReferenceNode->Attribute("href") || partyReferenceNode->Attribute("id"))
      {
          if(partyReferenceNode->Attribute("id"))
          {
             partyReferenceIDRef_ = partyReferenceNode->Attribute("id");
             partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));
             partyReference_->setID(partyReferenceIDRef_);
             IDManager::instance().setID(partyReferenceIDRef_,partyReference_);
          }
          else if(partyReferenceNode->Attribute("href")) { partyReferenceIDRef_ = partyReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { partyReference_ = boost::shared_ptr<PartyReference>(new PartyReference(partyReferenceNode));}
   }

   //portfolioNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* portfolioNameNode = xmlNode->FirstChildElement("portfolioName");

   if(portfolioNameNode){portfolioNameIsNull_ = false;}
   else{portfolioNameIsNull_ = true;}

   if(portfolioNameNode)
   {
      for(portfolioNameNode; portfolioNameNode; portfolioNameNode = portfolioNameNode->NextSiblingElement("portfolioName")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioNameNode , address : " << portfolioNameNode << std::endl;
          #endif
          if(portfolioNameNode->Attribute("href") || portfolioNameNode->Attribute("id"))
          {
              if(portfolioNameNode->Attribute("id"))
              {
                  portfolioNameIDRef_ = portfolioNameNode->Attribute("id");
                  portfolioName_.push_back(boost::shared_ptr<PortfolioName>(new PortfolioName(portfolioNameNode)));
                  portfolioName_.back()->setID(portfolioNameIDRef_);
                  IDManager::instance().setID(portfolioNameIDRef_, portfolioName_.back());
              }
              else if(portfolioNameNode->Attribute("href")) { portfolioNameIDRef_ = portfolioNameNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { portfolioName_.push_back(boost::shared_ptr<PortfolioName>(new PortfolioName(portfolioNameNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioNameNode , address : " << portfolioNameNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PartyReference> PartyPortfolioName::getPartyReference()
{
   if(!this->partyReferenceIsNull_){
        if(partyReferenceIDRef_ != ""){
             return boost::shared_static_cast<PartyReference>(IDManager::instance().getID(partyReferenceIDRef_));
        }else{
             return this->partyReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PartyReference>();
   }
}
std::vector<boost::shared_ptr<PortfolioName>> PartyPortfolioName::getPortfolioName()
{
   if(!this->portfolioNameIsNull_){
        if(portfolioNameIDRef_ != ""){
             return this->portfolioName_;
        }else{
             return this->portfolioName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PortfolioName>>();
   }
}
}

