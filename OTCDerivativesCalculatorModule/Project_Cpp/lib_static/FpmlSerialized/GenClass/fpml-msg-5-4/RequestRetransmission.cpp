// RequestRetransmission.cpp 
#include "RequestRetransmission.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RequestRetransmission::RequestRetransmission(TiXmlNode* xmlNode)
: NonCorrectableRequestMessage(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //portfolioReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* portfolioReferenceNode = xmlNode->FirstChildElement("portfolioReference");

   if(portfolioReferenceNode){portfolioReferenceIsNull_ = false;}
   else{portfolioReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioReferenceNode , address : " << portfolioReferenceNode << std::endl;
   #endif
   if(portfolioReferenceNode)
   {
      if(portfolioReferenceNode->Attribute("href") || portfolioReferenceNode->Attribute("id"))
      {
          if(portfolioReferenceNode->Attribute("id"))
          {
             portfolioReferenceIDRef_ = portfolioReferenceNode->Attribute("id");
             portfolioReference_ = boost::shared_ptr<PortfolioConstituentReference>(new PortfolioConstituentReference(portfolioReferenceNode));
             portfolioReference_->setID(portfolioReferenceIDRef_);
             IDManager::instance().setID(portfolioReferenceIDRef_,portfolioReference_);
          }
          else if(portfolioReferenceNode->Attribute("href")) { portfolioReferenceIDRef_ = portfolioReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { portfolioReference_ = boost::shared_ptr<PortfolioConstituentReference>(new PortfolioConstituentReference(portfolioReferenceNode));}
   }

   //reportIdentificationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* reportIdentificationNode = xmlNode->FirstChildElement("reportIdentification");

   if(reportIdentificationNode){reportIdentificationIsNull_ = false;}
   else{reportIdentificationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- reportIdentificationNode , address : " << reportIdentificationNode << std::endl;
   #endif
   if(reportIdentificationNode)
   {
      if(reportIdentificationNode->Attribute("href") || reportIdentificationNode->Attribute("id"))
      {
          if(reportIdentificationNode->Attribute("id"))
          {
             reportIdentificationIDRef_ = reportIdentificationNode->Attribute("id");
             reportIdentification_ = boost::shared_ptr<ReportSectionIdentification>(new ReportSectionIdentification(reportIdentificationNode));
             reportIdentification_->setID(reportIdentificationIDRef_);
             IDManager::instance().setID(reportIdentificationIDRef_,reportIdentification_);
          }
          else if(reportIdentificationNode->Attribute("href")) { reportIdentificationIDRef_ = reportIdentificationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { reportIdentification_ = boost::shared_ptr<ReportSectionIdentification>(new ReportSectionIdentification(reportIdentificationNode));}
   }

   //partyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* partyNode = xmlNode->FirstChildElement("party");

   if(partyNode){partyIsNull_ = false;}
   else{partyIsNull_ = true;}

   if(partyNode)
   {
      for(partyNode; partyNode; partyNode = partyNode->NextSiblingElement("party")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
          #endif
          if(partyNode->Attribute("href") || partyNode->Attribute("id"))
          {
              if(partyNode->Attribute("id"))
              {
                  partyIDRef_ = partyNode->Attribute("id");
                  party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));
                  party_.back()->setID(partyIDRef_);
                  IDManager::instance().setID(partyIDRef_, party_.back());
              }
              else if(partyNode->Attribute("href")) { partyIDRef_ = partyNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { party_.push_back(boost::shared_ptr<Party>(new Party(partyNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- partyNode , address : " << partyNode << std::endl;
       #endif
   }

   //accountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* accountNode = xmlNode->FirstChildElement("account");

   if(accountNode){accountIsNull_ = false;}
   else{accountIsNull_ = true;}

   if(accountNode)
   {
      for(accountNode; accountNode; accountNode = accountNode->NextSiblingElement("account")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountNode , address : " << accountNode << std::endl;
          #endif
          if(accountNode->Attribute("href") || accountNode->Attribute("id"))
          {
              if(accountNode->Attribute("id"))
              {
                  accountIDRef_ = accountNode->Attribute("id");
                  account_.push_back(boost::shared_ptr<Account>(new Account(accountNode)));
                  account_.back()->setID(accountIDRef_);
                  IDManager::instance().setID(accountIDRef_, account_.back());
              }
              else if(accountNode->Attribute("href")) { accountIDRef_ = accountNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { account_.push_back(boost::shared_ptr<Account>(new Account(accountNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- accountNode , address : " << accountNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PortfolioConstituentReference> RequestRetransmission::getPortfolioReference()
{
   if(!this->portfolioReferenceIsNull_){
        if(portfolioReferenceIDRef_ != ""){
             return boost::shared_static_cast<PortfolioConstituentReference>(IDManager::instance().getID(portfolioReferenceIDRef_));
        }else{
             return this->portfolioReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PortfolioConstituentReference>();
   }
}
boost::shared_ptr<ReportSectionIdentification> RequestRetransmission::getReportIdentification()
{
   if(!this->reportIdentificationIsNull_){
        if(reportIdentificationIDRef_ != ""){
             return boost::shared_static_cast<ReportSectionIdentification>(IDManager::instance().getID(reportIdentificationIDRef_));
        }else{
             return this->reportIdentification_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReportSectionIdentification>();
   }
}
std::vector<boost::shared_ptr<Party>> RequestRetransmission::getParty()
{
   if(!this->partyIsNull_){
        if(partyIDRef_ != ""){
             return this->party_;
        }else{
             return this->party_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Party>>();
   }
}
std::vector<boost::shared_ptr<Account>> RequestRetransmission::getAccount()
{
   if(!this->accountIsNull_){
        if(accountIDRef_ != ""){
             return this->account_;
        }else{
             return this->account_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Account>>();
   }
}
}

