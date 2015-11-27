// MinimumTranTime.cpp 
#include "MinimumTranTime.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

MinimumTranTime::MinimumTranTime(TiXmlNode* xmlNode)
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

   //variableNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* variableNode = xmlNode->FirstChildElement("variable");

   if(variableNode){variableIsNull_ = false;}
   else{variableIsNull_ = true;}

   if(variableNode)
   {
      for(variableNode; variableNode; variableNode = variableNode->NextSiblingElement("variable")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- variableNode , address : " << variableNode << std::endl;
          #endif
          if(variableNode->Attribute("href") || variableNode->Attribute("id"))
          {
              if(variableNode->Attribute("id"))
              {
                  variableIDRef_ = variableNode->Attribute("id");
                  variable_.push_back(boost::shared_ptr<Variable>(new Variable(variableNode)));
                  variable_.back()->setID(variableIDRef_);
                  IDManager::instance().setID(variableIDRef_, variable_.back());
              }
              else if(variableNode->Attribute("href")) { variableIDRef_ = variableNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { variable_.push_back(boost::shared_ptr<Variable>(new Variable(variableNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- variableNode , address : " << variableNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> MinimumTranTime::getSymbolName()
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
std::vector<boost::shared_ptr<Variable>> MinimumTranTime::getVariable()
{
   if(!this->variableIsNull_){
        if(variableIDRef_ != ""){
             return this->variable_;
        }else{
             return this->variable_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Variable>>();
   }
}
}

