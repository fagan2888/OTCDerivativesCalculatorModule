// PrincipalExchangeFeatures.cpp 
#include "PrincipalExchangeFeatures.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PrincipalExchangeFeatures::PrincipalExchangeFeatures(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //principalExchangesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalExchangesNode = xmlNode->FirstChildElement("principalExchanges");

   if(principalExchangesNode){principalExchangesIsNull_ = false;}
   else{principalExchangesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangesNode , address : " << principalExchangesNode << std::endl;
   #endif
   if(principalExchangesNode)
   {
      if(principalExchangesNode->Attribute("href") || principalExchangesNode->Attribute("id"))
      {
          if(principalExchangesNode->Attribute("id"))
          {
             principalExchangesIDRef_ = principalExchangesNode->Attribute("id");
             principalExchanges_ = boost::shared_ptr<PrincipalExchanges>(new PrincipalExchanges(principalExchangesNode));
             principalExchanges_->setID(principalExchangesIDRef_);
             IDManager::instance().setID(principalExchangesIDRef_,principalExchanges_);
          }
          else if(principalExchangesNode->Attribute("href")) { principalExchangesIDRef_ = principalExchangesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { principalExchanges_ = boost::shared_ptr<PrincipalExchanges>(new PrincipalExchanges(principalExchangesNode));}
   }

   //principalExchangeDescriptionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* principalExchangeDescriptionsNode = xmlNode->FirstChildElement("principalExchangeDescriptions");

   if(principalExchangeDescriptionsNode){principalExchangeDescriptionsIsNull_ = false;}
   else{principalExchangeDescriptionsIsNull_ = true;}

   if(principalExchangeDescriptionsNode)
   {
      for(principalExchangeDescriptionsNode; principalExchangeDescriptionsNode; principalExchangeDescriptionsNode = principalExchangeDescriptionsNode->NextSiblingElement("principalExchangeDescriptions")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangeDescriptionsNode , address : " << principalExchangeDescriptionsNode << std::endl;
          #endif
          if(principalExchangeDescriptionsNode->Attribute("href") || principalExchangeDescriptionsNode->Attribute("id"))
          {
              if(principalExchangeDescriptionsNode->Attribute("id"))
              {
                  principalExchangeDescriptionsIDRef_ = principalExchangeDescriptionsNode->Attribute("id");
                  principalExchangeDescriptions_.push_back(boost::shared_ptr<PrincipalExchangeDescriptions>(new PrincipalExchangeDescriptions(principalExchangeDescriptionsNode)));
                  principalExchangeDescriptions_.back()->setID(principalExchangeDescriptionsIDRef_);
                  IDManager::instance().setID(principalExchangeDescriptionsIDRef_, principalExchangeDescriptions_.back());
              }
              else if(principalExchangeDescriptionsNode->Attribute("href")) { principalExchangeDescriptionsIDRef_ = principalExchangeDescriptionsNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { principalExchangeDescriptions_.push_back(boost::shared_ptr<PrincipalExchangeDescriptions>(new PrincipalExchangeDescriptions(principalExchangeDescriptionsNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- principalExchangeDescriptionsNode , address : " << principalExchangeDescriptionsNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PrincipalExchanges> PrincipalExchangeFeatures::getPrincipalExchanges()
{
   if(!this->principalExchangesIsNull_){
        if(principalExchangesIDRef_ != ""){
             return boost::shared_static_cast<PrincipalExchanges>(IDManager::instance().getID(principalExchangesIDRef_));
        }else{
             return this->principalExchanges_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PrincipalExchanges>();
   }
}
std::vector<boost::shared_ptr<PrincipalExchangeDescriptions>> PrincipalExchangeFeatures::getPrincipalExchangeDescriptions()
{
   if(!this->principalExchangeDescriptionsIsNull_){
        if(principalExchangeDescriptionsIDRef_ != ""){
             return this->principalExchangeDescriptions_;
        }else{
             return this->principalExchangeDescriptions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<PrincipalExchangeDescriptions>>();
   }
}
}

