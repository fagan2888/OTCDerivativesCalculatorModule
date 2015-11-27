// GeneralTerminationEventDetail.cpp 
#include "GeneralTerminationEventDetail.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

GeneralTerminationEventDetail::GeneralTerminationEventDetail(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //general_TerminationEventDetail_creditNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* general_TerminationEventDetail_creditNode = xmlNode->FirstChildElement("general_TerminationEventDetail_credit");

   if(general_TerminationEventDetail_creditNode){general_TerminationEventDetail_creditIsNull_ = false;}
   else{general_TerminationEventDetail_creditIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- general_TerminationEventDetail_creditNode , address : " << general_TerminationEventDetail_creditNode << std::endl;
   #endif
   if(general_TerminationEventDetail_creditNode)
   {
       general_TerminationEventDetail_credit_ = boost::shared_ptr<General_TerminationEventDetail_credit>(new General_TerminationEventDetail_credit(general_TerminationEventDetail_creditNode));
   }

   //general_TerminationEventDetail_targetNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* general_TerminationEventDetail_targetNode = xmlNode->FirstChildElement("general_TerminationEventDetail_target");

   if(general_TerminationEventDetail_targetNode){general_TerminationEventDetail_targetIsNull_ = false;}
   else{general_TerminationEventDetail_targetIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- general_TerminationEventDetail_targetNode , address : " << general_TerminationEventDetail_targetNode << std::endl;
   #endif
   if(general_TerminationEventDetail_targetNode)
   {
       general_TerminationEventDetail_target_ = boost::shared_ptr<General_TerminationEventDetail_target>(new General_TerminationEventDetail_target(general_TerminationEventDetail_targetNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> GeneralTerminationEventDetail::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<General_TerminationEventDetail_credit> GeneralTerminationEventDetail::getGeneral_TerminationEventDetail_credit()
{
   if(!this->general_TerminationEventDetail_creditIsNull_){
        return this->general_TerminationEventDetail_credit_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<General_TerminationEventDetail_credit>();
   }
}
boost::shared_ptr<General_TerminationEventDetail_target> GeneralTerminationEventDetail::getGeneral_TerminationEventDetail_target()
{
   if(!this->general_TerminationEventDetail_targetIsNull_){
        return this->general_TerminationEventDetail_target_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<General_TerminationEventDetail_target>();
   }
}
}

