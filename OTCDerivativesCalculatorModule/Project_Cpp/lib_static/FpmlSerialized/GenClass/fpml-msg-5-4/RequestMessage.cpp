// RequestMessage.cpp 
#include "RequestMessage.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

RequestMessage::RequestMessage(TiXmlNode* xmlNode)
: Message(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //headerNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* headerNode = xmlNode->FirstChildElement("header");

   if(headerNode){headerIsNull_ = false;}
   else{headerIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- headerNode , address : " << headerNode << std::endl;
   #endif
   if(headerNode)
   {
      if(headerNode->Attribute("href") || headerNode->Attribute("id"))
      {
          if(headerNode->Attribute("id"))
          {
             headerIDRef_ = headerNode->Attribute("id");
             header_ = boost::shared_ptr<RequestMessageHeader>(new RequestMessageHeader(headerNode));
             header_->setID(headerIDRef_);
             IDManager::instance().setID(headerIDRef_,header_);
          }
          else if(headerNode->Attribute("href")) { headerIDRef_ = headerNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { header_ = boost::shared_ptr<RequestMessageHeader>(new RequestMessageHeader(headerNode));}
   }

   //validationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* validationNode = xmlNode->FirstChildElement("validation");

   if(validationNode){validationIsNull_ = false;}
   else{validationIsNull_ = true;}

   if(validationNode)
   {
      for(validationNode; validationNode; validationNode = validationNode->NextSiblingElement("validation")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- validationNode , address : " << validationNode << std::endl;
          #endif
          if(validationNode->Attribute("href") || validationNode->Attribute("id"))
          {
              if(validationNode->Attribute("id"))
              {
                  validationIDRef_ = validationNode->Attribute("id");
                  validation_.push_back(boost::shared_ptr<Validation>(new Validation(validationNode)));
                  validation_.back()->setID(validationIDRef_);
                  IDManager::instance().setID(validationIDRef_, validation_.back());
              }
              else if(validationNode->Attribute("href")) { validationIDRef_ = validationNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { validation_.push_back(boost::shared_ptr<Validation>(new Validation(validationNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- validationNode , address : " << validationNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<RequestMessageHeader> RequestMessage::getHeader()
{
   if(!this->headerIsNull_){
        if(headerIDRef_ != ""){
             return boost::shared_static_cast<RequestMessageHeader>(IDManager::instance().getID(headerIDRef_));
        }else{
             return this->header_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<RequestMessageHeader>();
   }
}
std::vector<boost::shared_ptr<Validation>> RequestMessage::getValidation()
{
   if(!this->validationIsNull_){
        if(validationIDRef_ != ""){
             return this->validation_;
        }else{
             return this->validation_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<Validation>>();
   }
}
}

