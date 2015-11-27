// ProtectionPart.cpp 
#include "ProtectionPart.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ProtectionPart::ProtectionPart(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //payRecieveNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* payRecieveNode = xmlNode->FirstChildElement("payRecieve");

   if(payRecieveNode){payRecieveIsNull_ = false;}
   else{payRecieveIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- payRecieveNode , address : " << payRecieveNode << std::endl;
   #endif
   if(payRecieveNode)
   {
       payRecieve_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(payRecieveNode));
   }

   //referenceInformationListNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* referenceInformationListNode = xmlNode->FirstChildElement("referenceInformationList");

   if(referenceInformationListNode){referenceInformationListIsNull_ = false;}
   else{referenceInformationListIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- referenceInformationListNode , address : " << referenceInformationListNode << std::endl;
   #endif
   if(referenceInformationListNode)
   {
       referenceInformationList_ = boost::shared_ptr<ReferenceInformationList>(new ReferenceInformationList(referenceInformationListNode));
   }

   //protectionTermsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* protectionTermsNode = xmlNode->FirstChildElement("protectionTerms");

   if(protectionTermsNode){protectionTermsIsNull_ = false;}
   else{protectionTermsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- protectionTermsNode , address : " << protectionTermsNode << std::endl;
   #endif
   if(protectionTermsNode)
   {
       protectionTerms_ = boost::shared_ptr<ProtectionTerms>(new ProtectionTerms(protectionTermsNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> ProtectionPart::getPayRecieve()
{
   if(!this->payRecieveIsNull_){
        return this->payRecieve_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<ReferenceInformationList> ProtectionPart::getReferenceInformationList()
{
   if(!this->referenceInformationListIsNull_){
        return this->referenceInformationList_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReferenceInformationList>();
   }
}
boost::shared_ptr<ProtectionTerms> ProtectionPart::getProtectionTerms()
{
   if(!this->protectionTermsIsNull_){
        return this->protectionTerms_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ProtectionTerms>();
   }
}
}

