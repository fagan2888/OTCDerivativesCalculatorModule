// Return.cpp 
#include "Return.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Return::Return(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //returnTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* returnTypeNode = xmlNode->FirstChildElement("returnType");

   if(returnTypeNode){returnTypeIsNull_ = false;}
   else{returnTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- returnTypeNode , address : " << returnTypeNode << std::endl;
   #endif
   if(returnTypeNode)
   {
      if(returnTypeNode->Attribute("href") || returnTypeNode->Attribute("id"))
      {
          if(returnTypeNode->Attribute("id"))
          {
             returnTypeIDRef_ = returnTypeNode->Attribute("id");
             returnType_ = boost::shared_ptr<ReturnTypeEnum>(new ReturnTypeEnum(returnTypeNode));
             returnType_->setID(returnTypeIDRef_);
             IDManager::instance().setID(returnTypeIDRef_,returnType_);
          }
          else if(returnTypeNode->Attribute("href")) { returnTypeIDRef_ = returnTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { returnType_ = boost::shared_ptr<ReturnTypeEnum>(new ReturnTypeEnum(returnTypeNode));}
   }

   //dividendConditionsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendConditionsNode = xmlNode->FirstChildElement("dividendConditions");

   if(dividendConditionsNode){dividendConditionsIsNull_ = false;}
   else{dividendConditionsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendConditionsNode , address : " << dividendConditionsNode << std::endl;
   #endif
   if(dividendConditionsNode)
   {
      if(dividendConditionsNode->Attribute("href") || dividendConditionsNode->Attribute("id"))
      {
          if(dividendConditionsNode->Attribute("id"))
          {
             dividendConditionsIDRef_ = dividendConditionsNode->Attribute("id");
             dividendConditions_ = boost::shared_ptr<DividendConditions>(new DividendConditions(dividendConditionsNode));
             dividendConditions_->setID(dividendConditionsIDRef_);
             IDManager::instance().setID(dividendConditionsIDRef_,dividendConditions_);
          }
          else if(dividendConditionsNode->Attribute("href")) { dividendConditionsIDRef_ = dividendConditionsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendConditions_ = boost::shared_ptr<DividendConditions>(new DividendConditions(dividendConditionsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ReturnTypeEnum> Return::getReturnType()
{
   if(!this->returnTypeIsNull_){
        if(returnTypeIDRef_ != ""){
             return boost::shared_static_cast<ReturnTypeEnum>(IDManager::instance().getID(returnTypeIDRef_));
        }else{
             return this->returnType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ReturnTypeEnum>();
   }
}
boost::shared_ptr<DividendConditions> Return::getDividendConditions()
{
   if(!this->dividendConditionsIsNull_){
        if(dividendConditionsIDRef_ != ""){
             return boost::shared_static_cast<DividendConditions>(IDManager::instance().getID(dividendConditionsIDRef_));
        }else{
             return this->dividendConditions_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendConditions>();
   }
}
}

