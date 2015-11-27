// RangeEventCheck.cpp 
#include "RangeEventCheck.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RangeEventCheck::RangeEventCheck(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //highCheckValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* highCheckValueNode = xmlNode->FirstChildElement("highCheckValue");

   if(highCheckValueNode){highCheckValueIsNull_ = false;}
   else{highCheckValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- highCheckValueNode , address : " << highCheckValueNode << std::endl;
   #endif
   if(highCheckValueNode)
   {
      if(highCheckValueNode->Attribute("href") || highCheckValueNode->Attribute("id"))
      {
          if(highCheckValueNode->Attribute("id"))
          {
             highCheckValueIDRef_ = highCheckValueNode->Attribute("id");
             highCheckValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(highCheckValueNode));
             highCheckValue_->setID(highCheckValueIDRef_);
             IDManager::instance().setID(highCheckValueIDRef_,highCheckValue_);
          }
          else if(highCheckValueNode->Attribute("href")) { highCheckValueIDRef_ = highCheckValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { highCheckValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(highCheckValueNode));}
   }

   //highEqualityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* highEqualityNode = xmlNode->FirstChildElement("highEquality");

   if(highEqualityNode){highEqualityIsNull_ = false;}
   else{highEqualityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- highEqualityNode , address : " << highEqualityNode << std::endl;
   #endif
   if(highEqualityNode)
   {
      if(highEqualityNode->Attribute("href") || highEqualityNode->Attribute("id"))
      {
          if(highEqualityNode->Attribute("id"))
          {
             highEqualityIDRef_ = highEqualityNode->Attribute("id");
             highEquality_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(highEqualityNode));
             highEquality_->setID(highEqualityIDRef_);
             IDManager::instance().setID(highEqualityIDRef_,highEquality_);
          }
          else if(highEqualityNode->Attribute("href")) { highEqualityIDRef_ = highEqualityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { highEquality_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(highEqualityNode));}
   }

   //lowCheckValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowCheckValueNode = xmlNode->FirstChildElement("lowCheckValue");

   if(lowCheckValueNode){lowCheckValueIsNull_ = false;}
   else{lowCheckValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowCheckValueNode , address : " << lowCheckValueNode << std::endl;
   #endif
   if(lowCheckValueNode)
   {
      if(lowCheckValueNode->Attribute("href") || lowCheckValueNode->Attribute("id"))
      {
          if(lowCheckValueNode->Attribute("id"))
          {
             lowCheckValueIDRef_ = lowCheckValueNode->Attribute("id");
             lowCheckValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(lowCheckValueNode));
             lowCheckValue_->setID(lowCheckValueIDRef_);
             IDManager::instance().setID(lowCheckValueIDRef_,lowCheckValue_);
          }
          else if(lowCheckValueNode->Attribute("href")) { lowCheckValueIDRef_ = lowCheckValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lowCheckValue_ = boost::shared_ptr<XsdTypeDouble>(new XsdTypeDouble(lowCheckValueNode));}
   }

   //lowEqualityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lowEqualityNode = xmlNode->FirstChildElement("lowEquality");

   if(lowEqualityNode){lowEqualityIsNull_ = false;}
   else{lowEqualityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lowEqualityNode , address : " << lowEqualityNode << std::endl;
   #endif
   if(lowEqualityNode)
   {
      if(lowEqualityNode->Attribute("href") || lowEqualityNode->Attribute("id"))
      {
          if(lowEqualityNode->Attribute("id"))
          {
             lowEqualityIDRef_ = lowEqualityNode->Attribute("id");
             lowEquality_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(lowEqualityNode));
             lowEquality_->setID(lowEqualityIDRef_);
             IDManager::instance().setID(lowEqualityIDRef_,lowEquality_);
          }
          else if(lowEqualityNode->Attribute("href")) { lowEqualityIDRef_ = lowEqualityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { lowEquality_ = boost::shared_ptr<XsdTypeBoolean>(new XsdTypeBoolean(lowEqualityNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeDouble> RangeEventCheck::getHighCheckValue()
{
   if(!this->highCheckValueIsNull_){
        if(highCheckValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDouble>(IDManager::instance().getID(highCheckValueIDRef_));
        }else{
             return this->highCheckValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeBoolean> RangeEventCheck::getHighEquality()
{
   if(!this->highEqualityIsNull_){
        if(highEqualityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(highEqualityIDRef_));
        }else{
             return this->highEquality_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
boost::shared_ptr<XsdTypeDouble> RangeEventCheck::getLowCheckValue()
{
   if(!this->lowCheckValueIsNull_){
        if(lowCheckValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDouble>(IDManager::instance().getID(lowCheckValueIDRef_));
        }else{
             return this->lowCheckValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDouble>();
   }
}
boost::shared_ptr<XsdTypeBoolean> RangeEventCheck::getLowEquality()
{
   if(!this->lowEqualityIsNull_){
        if(lowEqualityIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBoolean>(IDManager::instance().getID(lowEqualityIDRef_));
        }else{
             return this->lowEquality_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBoolean>();
   }
}
}

