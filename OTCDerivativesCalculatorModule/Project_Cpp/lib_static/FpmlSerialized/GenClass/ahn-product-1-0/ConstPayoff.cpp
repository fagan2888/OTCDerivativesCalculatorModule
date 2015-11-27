// ConstPayoff.cpp 
#include "ConstPayoff.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ConstPayoff::ConstPayoff(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //constValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* constValueNode = xmlNode->FirstChildElement("constValue");

   if(constValueNode){constValueIsNull_ = false;}
   else{constValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- constValueNode , address : " << constValueNode << std::endl;
   #endif
   if(constValueNode)
   {
      if(constValueNode->Attribute("href") || constValueNode->Attribute("id"))
      {
          if(constValueNode->Attribute("id"))
          {
             constValueIDRef_ = constValueNode->Attribute("id");
             constValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(constValueNode));
             constValue_->setID(constValueIDRef_);
             IDManager::instance().setID(constValueIDRef_,constValue_);
          }
          else if(constValueNode->Attribute("href")) { constValueIDRef_ = constValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { constValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(constValueNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> ConstPayoff::getConstValue()
{
   if(!this->constValueIsNull_){
        if(constValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDouble>(IDManager::instance().getID(constValueIDRef_));
        }else{
             return this->constValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
}

