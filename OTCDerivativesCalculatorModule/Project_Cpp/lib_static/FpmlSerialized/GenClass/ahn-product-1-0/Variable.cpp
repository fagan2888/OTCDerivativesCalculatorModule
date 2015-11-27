// Variable.cpp 
#include "Variable.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Variable::Variable(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //symbolNameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* symbolNameNode = xmlNode->FirstChildElement("symbolName");

   if(symbolNameNode){symbolNameIsNull_ = false;}
   else{symbolNameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- symbolNameNode , address : " << symbolNameNode << std::endl;
   #endif
   if(symbolNameNode)
   {
      if(symbolNameNode->Attribute("href") || symbolNameNode->Attribute("id"))
      {
          if(symbolNameNode->Attribute("id"))
          {
             symbolNameIDRef_ = symbolNameNode->Attribute("id");
             symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));
             symbolName_->setID(symbolNameIDRef_);
             IDManager::instance().setID(symbolNameIDRef_,symbolName_);
          }
          else if(symbolNameNode->Attribute("href")) { symbolNameIDRef_ = symbolNameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { symbolName_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(symbolNameNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> Variable::getSymbolName()
{
   if(!this->symbolNameIsNull_){
        if(symbolNameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeToken>(IDManager::instance().getID(symbolNameIDRef_));
        }else{
             return this->symbolName_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
}

