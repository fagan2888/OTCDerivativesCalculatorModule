// PortfolioReferenceBase.cpp 
#include "PortfolioReferenceBase.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PortfolioReferenceBase::PortfolioReferenceBase(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //portfolioNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* portfolioNameNode = xmlNode->FirstChildElement("portfolioName");

   if(portfolioNameNode){portfolioNameIsNull_ = false;}
   else{portfolioNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- portfolioNameNode , address : " << portfolioNameNode << std::endl;
   #endif
   if(portfolioNameNode)
   {
      if(portfolioNameNode->Attribute("href") || portfolioNameNode->Attribute("id"))
      {
          if(portfolioNameNode->Attribute("id"))
          {
             portfolioNameIDRef_ = portfolioNameNode->Attribute("id");
             portfolioName_ = boost::shared_ptr<PortfolioName>(new PortfolioName(portfolioNameNode));
             portfolioName_->setID(portfolioNameIDRef_);
             IDManager::instance().setID(portfolioNameIDRef_,portfolioName_);
          }
          else if(portfolioNameNode->Attribute("href")) { portfolioNameIDRef_ = portfolioNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { portfolioName_ = boost::shared_ptr<PortfolioName>(new PortfolioName(portfolioNameNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PortfolioName> PortfolioReferenceBase::getPortfolioName()
{
   if(!this->portfolioNameIsNull_){
        if(portfolioNameIDRef_ != ""){
             return boost::shared_static_cast<PortfolioName>(IDManager::instance().getID(portfolioNameIDRef_));
        }else{
             return this->portfolioName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PortfolioName>();
   }
}
}

