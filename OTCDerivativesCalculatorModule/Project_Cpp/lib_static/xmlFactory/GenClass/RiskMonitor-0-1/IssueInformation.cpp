// IssueInformation.cpp 
#include "IssueInformation.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

IssueInformation::IssueInformation(TiXmlNode* xmlNode)
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

   //swapInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* swapInfoNode = xmlNode->FirstChildElement("swapInfo");

   if(swapInfoNode){swapInfoIsNull_ = false;}
   else{swapInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- swapInfoNode , address : " << swapInfoNode << std::endl;
   #endif
   if(swapInfoNode)
   {
       swapInfo_ = boost::shared_ptr<SwapInfo>(new SwapInfo(swapInfoNode));
   }

   //noteInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* noteInfoNode = xmlNode->FirstChildElement("noteInfo");

   if(noteInfoNode){noteInfoIsNull_ = false;}
   else{noteInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- noteInfoNode , address : " << noteInfoNode << std::endl;
   #endif
   if(noteInfoNode)
   {
       noteInfo_ = boost::shared_ptr<NoteInfo>(new NoteInfo(noteInfoNode));
   }

   //optionInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* optionInfoNode = xmlNode->FirstChildElement("optionInfo");

   if(optionInfoNode){optionInfoIsNull_ = false;}
   else{optionInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- optionInfoNode , address : " << optionInfoNode << std::endl;
   #endif
   if(optionInfoNode)
   {
       optionInfo_ = boost::shared_ptr<OptionInfo>(new OptionInfo(optionInfoNode));
   }

   //securitiesInfoNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* securitiesInfoNode = xmlNode->FirstChildElement("securitiesInfo");

   if(securitiesInfoNode){securitiesInfoIsNull_ = false;}
   else{securitiesInfoIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- securitiesInfoNode , address : " << securitiesInfoNode << std::endl;
   #endif
   if(securitiesInfoNode)
   {
       securitiesInfo_ = boost::shared_ptr<SecuritiesInfo>(new SecuritiesInfo(securitiesInfoNode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> IssueInformation::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<SwapInfo> IssueInformation::getSwapInfo()
{
   if(!this->swapInfoIsNull_){
        return this->swapInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SwapInfo>();
   }
}
boost::shared_ptr<NoteInfo> IssueInformation::getNoteInfo()
{
   if(!this->noteInfoIsNull_){
        return this->noteInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NoteInfo>();
   }
}
boost::shared_ptr<OptionInfo> IssueInformation::getOptionInfo()
{
   if(!this->optionInfoIsNull_){
        return this->optionInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<OptionInfo>();
   }
}
boost::shared_ptr<SecuritiesInfo> IssueInformation::getSecuritiesInfo()
{
   if(!this->securitiesInfoIsNull_){
        return this->securitiesInfo_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<SecuritiesInfo>();
   }
}
}

