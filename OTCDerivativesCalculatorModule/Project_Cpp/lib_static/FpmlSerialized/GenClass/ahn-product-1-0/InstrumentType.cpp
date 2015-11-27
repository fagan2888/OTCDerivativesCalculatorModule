// InstrumentType.cpp 
#include "InstrumentType.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

InstrumentType::InstrumentType(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //classificationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* classificationNode = xmlNode->FirstChildElement("classification");

   if(classificationNode){classificationIsNull_ = false;}
   else{classificationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- classificationNode , address : " << classificationNode << std::endl;
   #endif
   if(classificationNode)
   {
      if(classificationNode->Attribute("href") || classificationNode->Attribute("id"))
      {
          if(classificationNode->Attribute("id"))
          {
             classificationIDRef_ = classificationNode->Attribute("id");
             classification_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(classificationNode));
             classification_->setID(classificationIDRef_);
             IDManager::instance().setID(classificationIDRef_,classification_);
          }
          else if(classificationNode->Attribute("href")) { classificationIDRef_ = classificationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { classification_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(classificationNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> InstrumentType::getClassification()
{
   if(!this->classificationIsNull_){
        if(classificationIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(classificationIDRef_));
        }else{
             return this->classification_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

