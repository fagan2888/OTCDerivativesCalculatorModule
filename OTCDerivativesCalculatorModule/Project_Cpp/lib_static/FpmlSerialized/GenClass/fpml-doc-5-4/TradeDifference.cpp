// TradeDifference.cpp 
#include "TradeDifference.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

TradeDifference::TradeDifference(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //differenceTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* differenceTypeNode = xmlNode->FirstChildElement("differenceType");

   if(differenceTypeNode){differenceTypeIsNull_ = false;}
   else{differenceTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- differenceTypeNode , address : " << differenceTypeNode << std::endl;
   #endif
   if(differenceTypeNode)
   {
      if(differenceTypeNode->Attribute("href") || differenceTypeNode->Attribute("id"))
      {
          if(differenceTypeNode->Attribute("id"))
          {
             differenceTypeIDRef_ = differenceTypeNode->Attribute("id");
             differenceType_ = boost::shared_ptr<DifferenceTypeEnum>(new DifferenceTypeEnum(differenceTypeNode));
             differenceType_->setID(differenceTypeIDRef_);
             IDManager::instance().setID(differenceTypeIDRef_,differenceType_);
          }
          else if(differenceTypeNode->Attribute("href")) { differenceTypeIDRef_ = differenceTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { differenceType_ = boost::shared_ptr<DifferenceTypeEnum>(new DifferenceTypeEnum(differenceTypeNode));}
   }

   //differenceSeverityNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* differenceSeverityNode = xmlNode->FirstChildElement("differenceSeverity");

   if(differenceSeverityNode){differenceSeverityIsNull_ = false;}
   else{differenceSeverityIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- differenceSeverityNode , address : " << differenceSeverityNode << std::endl;
   #endif
   if(differenceSeverityNode)
   {
      if(differenceSeverityNode->Attribute("href") || differenceSeverityNode->Attribute("id"))
      {
          if(differenceSeverityNode->Attribute("id"))
          {
             differenceSeverityIDRef_ = differenceSeverityNode->Attribute("id");
             differenceSeverity_ = boost::shared_ptr<DifferenceSeverityEnum>(new DifferenceSeverityEnum(differenceSeverityNode));
             differenceSeverity_->setID(differenceSeverityIDRef_);
             IDManager::instance().setID(differenceSeverityIDRef_,differenceSeverity_);
          }
          else if(differenceSeverityNode->Attribute("href")) { differenceSeverityIDRef_ = differenceSeverityNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { differenceSeverity_ = boost::shared_ptr<DifferenceSeverityEnum>(new DifferenceSeverityEnum(differenceSeverityNode));}
   }

   //elementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* elementNode = xmlNode->FirstChildElement("element");

   if(elementNode){elementIsNull_ = false;}
   else{elementIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- elementNode , address : " << elementNode << std::endl;
   #endif
   if(elementNode)
   {
      if(elementNode->Attribute("href") || elementNode->Attribute("id"))
      {
          if(elementNode->Attribute("id"))
          {
             elementIDRef_ = elementNode->Attribute("id");
             element_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(elementNode));
             element_->setID(elementIDRef_);
             IDManager::instance().setID(elementIDRef_,element_);
          }
          else if(elementNode->Attribute("href")) { elementIDRef_ = elementNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { element_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(elementNode));}
   }

   //basePathNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* basePathNode = xmlNode->FirstChildElement("basePath");

   if(basePathNode){basePathIsNull_ = false;}
   else{basePathIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- basePathNode , address : " << basePathNode << std::endl;
   #endif
   if(basePathNode)
   {
      if(basePathNode->Attribute("href") || basePathNode->Attribute("id"))
      {
          if(basePathNode->Attribute("id"))
          {
             basePathIDRef_ = basePathNode->Attribute("id");
             basePath_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(basePathNode));
             basePath_->setID(basePathIDRef_);
             IDManager::instance().setID(basePathIDRef_,basePath_);
          }
          else if(basePathNode->Attribute("href")) { basePathIDRef_ = basePathNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { basePath_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(basePathNode));}
   }

   //baseValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* baseValueNode = xmlNode->FirstChildElement("baseValue");

   if(baseValueNode){baseValueIsNull_ = false;}
   else{baseValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- baseValueNode , address : " << baseValueNode << std::endl;
   #endif
   if(baseValueNode)
   {
      if(baseValueNode->Attribute("href") || baseValueNode->Attribute("id"))
      {
          if(baseValueNode->Attribute("id"))
          {
             baseValueIDRef_ = baseValueNode->Attribute("id");
             baseValue_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(baseValueNode));
             baseValue_->setID(baseValueIDRef_);
             IDManager::instance().setID(baseValueIDRef_,baseValue_);
          }
          else if(baseValueNode->Attribute("href")) { baseValueIDRef_ = baseValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { baseValue_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(baseValueNode));}
   }

   //otherPathNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* otherPathNode = xmlNode->FirstChildElement("otherPath");

   if(otherPathNode){otherPathIsNull_ = false;}
   else{otherPathIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherPathNode , address : " << otherPathNode << std::endl;
   #endif
   if(otherPathNode)
   {
      if(otherPathNode->Attribute("href") || otherPathNode->Attribute("id"))
      {
          if(otherPathNode->Attribute("id"))
          {
             otherPathIDRef_ = otherPathNode->Attribute("id");
             otherPath_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(otherPathNode));
             otherPath_->setID(otherPathIDRef_);
             IDManager::instance().setID(otherPathIDRef_,otherPath_);
          }
          else if(otherPathNode->Attribute("href")) { otherPathIDRef_ = otherPathNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { otherPath_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(otherPathNode));}
   }

   //otherValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* otherValueNode = xmlNode->FirstChildElement("otherValue");

   if(otherValueNode){otherValueIsNull_ = false;}
   else{otherValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- otherValueNode , address : " << otherValueNode << std::endl;
   #endif
   if(otherValueNode)
   {
      if(otherValueNode->Attribute("href") || otherValueNode->Attribute("id"))
      {
          if(otherValueNode->Attribute("id"))
          {
             otherValueIDRef_ = otherValueNode->Attribute("id");
             otherValue_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(otherValueNode));
             otherValue_->setID(otherValueIDRef_);
             IDManager::instance().setID(otherValueIDRef_,otherValue_);
          }
          else if(otherValueNode->Attribute("href")) { otherValueIDRef_ = otherValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { otherValue_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(otherValueNode));}
   }

   //missingElementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* missingElementNode = xmlNode->FirstChildElement("missingElement");

   if(missingElementNode){missingElementIsNull_ = false;}
   else{missingElementIsNull_ = true;}

   if(missingElementNode)
   {
      for(missingElementNode; missingElementNode; missingElementNode = missingElementNode->NextSiblingElement("missingElement")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- missingElementNode , address : " << missingElementNode << std::endl;
          #endif
          if(missingElementNode->Attribute("href") || missingElementNode->Attribute("id"))
          {
              if(missingElementNode->Attribute("id"))
              {
                  missingElementIDRef_ = missingElementNode->Attribute("id");
                  missingElement_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(missingElementNode)));
                  missingElement_.back()->setID(missingElementIDRef_);
                  IDManager::instance().setID(missingElementIDRef_, missingElement_.back());
              }
              else if(missingElementNode->Attribute("href")) { missingElementIDRef_ = missingElementNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { missingElement_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(missingElementNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- missingElementNode , address : " << missingElementNode << std::endl;
       #endif
   }

   //extraElementNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* extraElementNode = xmlNode->FirstChildElement("extraElement");

   if(extraElementNode){extraElementIsNull_ = false;}
   else{extraElementIsNull_ = true;}

   if(extraElementNode)
   {
      for(extraElementNode; extraElementNode; extraElementNode = extraElementNode->NextSiblingElement("extraElement")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extraElementNode , address : " << extraElementNode << std::endl;
          #endif
          if(extraElementNode->Attribute("href") || extraElementNode->Attribute("id"))
          {
              if(extraElementNode->Attribute("id"))
              {
                  extraElementIDRef_ = extraElementNode->Attribute("id");
                  extraElement_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(extraElementNode)));
                  extraElement_.back()->setID(extraElementIDRef_);
                  IDManager::instance().setID(extraElementIDRef_, extraElement_.back());
              }
              else if(extraElementNode->Attribute("href")) { extraElementIDRef_ = extraElementNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { extraElement_.push_back(boost::shared_ptr<XsdTypeString>(new XsdTypeString(extraElementNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- extraElementNode , address : " << extraElementNode << std::endl;
       #endif
   }

   //messageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* messageNode = xmlNode->FirstChildElement("message");

   if(messageNode){messageIsNull_ = false;}
   else{messageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- messageNode , address : " << messageNode << std::endl;
   #endif
   if(messageNode)
   {
      if(messageNode->Attribute("href") || messageNode->Attribute("id"))
      {
          if(messageNode->Attribute("id"))
          {
             messageIDRef_ = messageNode->Attribute("id");
             message_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(messageNode));
             message_->setID(messageIDRef_);
             IDManager::instance().setID(messageIDRef_,message_);
          }
          else if(messageNode->Attribute("href")) { messageIDRef_ = messageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { message_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(messageNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<DifferenceTypeEnum> TradeDifference::getDifferenceType()
{
   if(!this->differenceTypeIsNull_){
        if(differenceTypeIDRef_ != ""){
             return boost::shared_static_cast<DifferenceTypeEnum>(IDManager::instance().getID(differenceTypeIDRef_));
        }else{
             return this->differenceType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DifferenceTypeEnum>();
   }
}
boost::shared_ptr<DifferenceSeverityEnum> TradeDifference::getDifferenceSeverity()
{
   if(!this->differenceSeverityIsNull_){
        if(differenceSeverityIDRef_ != ""){
             return boost::shared_static_cast<DifferenceSeverityEnum>(IDManager::instance().getID(differenceSeverityIDRef_));
        }else{
             return this->differenceSeverity_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DifferenceSeverityEnum>();
   }
}
boost::shared_ptr<XsdTypeString> TradeDifference::getElement()
{
   if(!this->elementIsNull_){
        if(elementIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(elementIDRef_));
        }else{
             return this->element_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> TradeDifference::getBasePath()
{
   if(!this->basePathIsNull_){
        if(basePathIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(basePathIDRef_));
        }else{
             return this->basePath_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> TradeDifference::getBaseValue()
{
   if(!this->baseValueIsNull_){
        if(baseValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(baseValueIDRef_));
        }else{
             return this->baseValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> TradeDifference::getOtherPath()
{
   if(!this->otherPathIsNull_){
        if(otherPathIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(otherPathIDRef_));
        }else{
             return this->otherPath_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> TradeDifference::getOtherValue()
{
   if(!this->otherValueIsNull_){
        if(otherValueIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(otherValueIDRef_));
        }else{
             return this->otherValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
std::vector<boost::shared_ptr<XsdTypeString>> TradeDifference::getMissingElement()
{
   if(!this->missingElementIsNull_){
        if(missingElementIDRef_ != ""){
             return this->missingElement_;
        }else{
             return this->missingElement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeString>>();
   }
}
std::vector<boost::shared_ptr<XsdTypeString>> TradeDifference::getExtraElement()
{
   if(!this->extraElementIsNull_){
        if(extraElementIDRef_ != ""){
             return this->extraElement_;
        }else{
             return this->extraElement_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<XsdTypeString>>();
   }
}
boost::shared_ptr<XsdTypeString> TradeDifference::getMessage()
{
   if(!this->messageIsNull_){
        if(messageIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(messageIDRef_));
        }else{
             return this->message_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
}

