// Functions.cpp 
#include "Functions.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Functions::Functions(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //functionNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* functionNode = xmlNode->FirstChildElement("function");

   if(functionNode){functionIsNull_ = false;}
   else{functionIsNull_ = true;}

   if(functionNode)
   {
      for(functionNode; functionNode; functionNode = functionNode->NextSiblingElement("function")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- functionNode , address : " << functionNode << std::endl;
          #endif
          if(functionNode->Attribute("href") || functionNode->Attribute("id"))
          {
              if(functionNode->Attribute("id"))
              {
                  functionIDRef_ = functionNode->Attribute("id");
                  function_.push_back(boost::shared_ptr<Function>(new Function(functionNode)));
                  function_.back()->setID(functionIDRef_);
                  IDManager::instance().setID(functionIDRef_, function_.back());
              }
              else if(functionNode->Attribute("href")) { functionIDRef_ = functionNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { function_.push_back(boost::shared_ptr<Function>(new Function(functionNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- functionNode , address : " << functionNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<Function>> Functions::getFunction()
{
   if(!this->functionIsNull_){
        if(functionIDRef_ != ""){
             return this->function_;
        }else{
             return this->function_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Function>>();
   }
}
}

