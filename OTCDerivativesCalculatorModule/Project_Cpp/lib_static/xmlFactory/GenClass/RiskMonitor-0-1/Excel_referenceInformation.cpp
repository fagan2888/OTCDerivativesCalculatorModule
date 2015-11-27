// Excel_referenceInformation.cpp 
#include "Excel_referenceInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Excel_referenceInformation::Excel_referenceInformation(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //entityNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entityNameNode = xmlNode->FirstChildElement("entityName");

   if(entityNameNode){entityNameIsNull_ = false;}
   else{entityNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entityNameNode , address : " << entityNameNode << std::endl;
   #endif
   if(entityNameNode)
   {
       entityName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(entityNameNode));
   }

   //entityIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* entityIdNode = xmlNode->FirstChildElement("entityId");

   if(entityIdNode){entityIdIsNull_ = false;}
   else{entityIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- entityIdNode , address : " << entityIdNode << std::endl;
   #endif
   if(entityIdNode)
   {
       entityId_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(entityIdNode));
   }

   //excel_referenceObligationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* excel_referenceObligationNode = xmlNode->FirstChildElement("excel_referenceObligation");

   if(excel_referenceObligationNode){excel_referenceObligationIsNull_ = false;}
   else{excel_referenceObligationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- excel_referenceObligationNode , address : " << excel_referenceObligationNode << std::endl;
   #endif
   if(excel_referenceObligationNode)
   {
       excel_referenceObligation_ = boost::shared_ptr<Excel_referenceObligation>(new Excel_referenceObligation(excel_referenceObligationNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Excel_referenceInformation::getEntityName()
{
   if(!this->entityNameIsNull_){
        return this->entityName_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<XsdTypeToken> Excel_referenceInformation::getEntityId()
{
   if(!this->entityIdIsNull_){
        return this->entityId_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<Excel_referenceObligation> Excel_referenceInformation::getExcel_referenceObligation()
{
   if(!this->excel_referenceObligationIsNull_){
        return this->excel_referenceObligation_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Excel_referenceObligation>();
   }
}
}

