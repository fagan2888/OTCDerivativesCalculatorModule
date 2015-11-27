// Obligations.cpp 
#include "Obligations.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Obligations::Obligations(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //categoryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* categoryNode = xmlNode->FirstChildElement("category");

   if(categoryNode){categoryIsNull_ = false;}
   else{categoryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- categoryNode , address : " << categoryNode << std::endl;
   #endif
   if(categoryNode)
   {
       category_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(categoryNode));
   }

   //notSubordinatedNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notSubordinatedNode = xmlNode->FirstChildElement("notSubordinated");

   if(notSubordinatedNode){notSubordinatedIsNull_ = false;}
   else{notSubordinatedIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notSubordinatedNode , address : " << notSubordinatedNode << std::endl;
   #endif
   if(notSubordinatedNode)
   {
       notSubordinated_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notSubordinatedNode));
   }

   //notDomesticCurrencyNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticCurrencyNode = xmlNode->FirstChildElement("notDomesticCurrency");

   if(notDomesticCurrencyNode){notDomesticCurrencyIsNull_ = false;}
   else{notDomesticCurrencyIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticCurrencyNode , address : " << notDomesticCurrencyNode << std::endl;
   #endif
   if(notDomesticCurrencyNode)
   {
       notDomesticCurrency_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notDomesticCurrencyNode));
   }

   //notDomesticLawNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticLawNode = xmlNode->FirstChildElement("notDomesticLaw");

   if(notDomesticLawNode){notDomesticLawIsNull_ = false;}
   else{notDomesticLawIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticLawNode , address : " << notDomesticLawNode << std::endl;
   #endif
   if(notDomesticLawNode)
   {
       notDomesticLaw_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notDomesticLawNode));
   }

   //notDomesticIssuanceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* notDomesticIssuanceNode = xmlNode->FirstChildElement("notDomesticIssuance");

   if(notDomesticIssuanceNode){notDomesticIssuanceIsNull_ = false;}
   else{notDomesticIssuanceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- notDomesticIssuanceNode , address : " << notDomesticIssuanceNode << std::endl;
   #endif
   if(notDomesticIssuanceNode)
   {
       notDomesticIssuance_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(notDomesticIssuanceNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Obligations::getCategory()
{
   if(!this->categoryIsNull_){
        return this->category_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Obligations::getNotSubordinated()
{
   if(!this->notSubordinatedIsNull_){
        return this->notSubordinated_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Obligations::getNotDomesticCurrency()
{
   if(!this->notDomesticCurrencyIsNull_){
        return this->notDomesticCurrency_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Obligations::getNotDomesticLaw()
{
   if(!this->notDomesticLawIsNull_){
        return this->notDomesticLaw_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Obligations::getNotDomesticIssuance()
{
   if(!this->notDomesticIssuanceIsNull_){
        return this->notDomesticIssuance_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

