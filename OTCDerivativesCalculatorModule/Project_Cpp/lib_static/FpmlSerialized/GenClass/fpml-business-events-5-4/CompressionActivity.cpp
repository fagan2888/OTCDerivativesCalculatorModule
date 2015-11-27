// CompressionActivity.cpp 
#include "CompressionActivity.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CompressionActivity::CompressionActivity(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //compressionTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* compressionTypeNode = xmlNode->FirstChildElement("compressionType");

   if(compressionTypeNode){compressionTypeIsNull_ = false;}
   else{compressionTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- compressionTypeNode , address : " << compressionTypeNode << std::endl;
   #endif
   if(compressionTypeNode)
   {
      if(compressionTypeNode->Attribute("href") || compressionTypeNode->Attribute("id"))
      {
          if(compressionTypeNode->Attribute("id"))
          {
             compressionTypeIDRef_ = compressionTypeNode->Attribute("id");
             compressionType_ = boost::shared_ptr<CompressionType>(new CompressionType(compressionTypeNode));
             compressionType_->setID(compressionTypeIDRef_);
             IDManager::instance().setID(compressionTypeIDRef_,compressionType_);
          }
          else if(compressionTypeNode->Attribute("href")) { compressionTypeIDRef_ = compressionTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { compressionType_ = boost::shared_ptr<CompressionType>(new CompressionType(compressionTypeNode));}
   }

   //replacementTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* replacementTradeIdentifierNode = xmlNode->FirstChildElement("replacementTradeIdentifier");

   if(replacementTradeIdentifierNode){replacementTradeIdentifierIsNull_ = false;}
   else{replacementTradeIdentifierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- replacementTradeIdentifierNode , address : " << replacementTradeIdentifierNode << std::endl;
   #endif
   if(replacementTradeIdentifierNode)
   {
      if(replacementTradeIdentifierNode->Attribute("href") || replacementTradeIdentifierNode->Attribute("id"))
      {
          if(replacementTradeIdentifierNode->Attribute("id"))
          {
             replacementTradeIdentifierIDRef_ = replacementTradeIdentifierNode->Attribute("id");
             replacementTradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(replacementTradeIdentifierNode));
             replacementTradeIdentifier_->setID(replacementTradeIdentifierIDRef_);
             IDManager::instance().setID(replacementTradeIdentifierIDRef_,replacementTradeIdentifier_);
          }
          else if(replacementTradeIdentifierNode->Attribute("href")) { replacementTradeIdentifierIDRef_ = replacementTradeIdentifierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { replacementTradeIdentifier_ = boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(replacementTradeIdentifierNode));}
   }

   //originatingTradeIdentifierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingTradeIdentifierNode = xmlNode->FirstChildElement("originatingTradeIdentifier");

   if(originatingTradeIdentifierNode){originatingTradeIdentifierIsNull_ = false;}
   else{originatingTradeIdentifierIsNull_ = true;}

   if(originatingTradeIdentifierNode)
   {
      for(originatingTradeIdentifierNode; originatingTradeIdentifierNode; originatingTradeIdentifierNode = originatingTradeIdentifierNode->NextSiblingElement("originatingTradeIdentifier")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingTradeIdentifierNode , address : " << originatingTradeIdentifierNode << std::endl;
          #endif
          if(originatingTradeIdentifierNode->Attribute("href") || originatingTradeIdentifierNode->Attribute("id"))
          {
              if(originatingTradeIdentifierNode->Attribute("id"))
              {
                  originatingTradeIdentifierIDRef_ = originatingTradeIdentifierNode->Attribute("id");
                  originatingTradeIdentifier_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(originatingTradeIdentifierNode)));
                  originatingTradeIdentifier_.back()->setID(originatingTradeIdentifierIDRef_);
                  IDManager::instance().setID(originatingTradeIdentifierIDRef_, originatingTradeIdentifier_.back());
              }
              else if(originatingTradeIdentifierNode->Attribute("href")) { originatingTradeIdentifierIDRef_ = originatingTradeIdentifierNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { originatingTradeIdentifier_.push_back(boost::shared_ptr<TradeIdentifier>(new TradeIdentifier(originatingTradeIdentifierNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingTradeIdentifierNode , address : " << originatingTradeIdentifierNode << std::endl;
       #endif
   }

   //replacementTradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* replacementTradeIdNode = xmlNode->FirstChildElement("replacementTradeId");

   if(replacementTradeIdNode){replacementTradeIdIsNull_ = false;}
   else{replacementTradeIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- replacementTradeIdNode , address : " << replacementTradeIdNode << std::endl;
   #endif
   if(replacementTradeIdNode)
   {
      if(replacementTradeIdNode->Attribute("href") || replacementTradeIdNode->Attribute("id"))
      {
          if(replacementTradeIdNode->Attribute("id"))
          {
             replacementTradeIdIDRef_ = replacementTradeIdNode->Attribute("id");
             replacementTradeId_ = boost::shared_ptr<TradeId>(new TradeId(replacementTradeIdNode));
             replacementTradeId_->setID(replacementTradeIdIDRef_);
             IDManager::instance().setID(replacementTradeIdIDRef_,replacementTradeId_);
          }
          else if(replacementTradeIdNode->Attribute("href")) { replacementTradeIdIDRef_ = replacementTradeIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { replacementTradeId_ = boost::shared_ptr<TradeId>(new TradeId(replacementTradeIdNode));}
   }

   //originatingTradeIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* originatingTradeIdNode = xmlNode->FirstChildElement("originatingTradeId");

   if(originatingTradeIdNode){originatingTradeIdIsNull_ = false;}
   else{originatingTradeIdIsNull_ = true;}

   if(originatingTradeIdNode)
   {
      for(originatingTradeIdNode; originatingTradeIdNode; originatingTradeIdNode = originatingTradeIdNode->NextSiblingElement("originatingTradeId")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingTradeIdNode , address : " << originatingTradeIdNode << std::endl;
          #endif
          if(originatingTradeIdNode->Attribute("href") || originatingTradeIdNode->Attribute("id"))
          {
              if(originatingTradeIdNode->Attribute("id"))
              {
                  originatingTradeIdIDRef_ = originatingTradeIdNode->Attribute("id");
                  originatingTradeId_.push_back(boost::shared_ptr<TradeId>(new TradeId(originatingTradeIdNode)));
                  originatingTradeId_.back()->setID(originatingTradeIdIDRef_);
                  IDManager::instance().setID(originatingTradeIdIDRef_, originatingTradeId_.back());
              }
              else if(originatingTradeIdNode->Attribute("href")) { originatingTradeIdIDRef_ = originatingTradeIdNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { originatingTradeId_.push_back(boost::shared_ptr<TradeId>(new TradeId(originatingTradeIdNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- originatingTradeIdNode , address : " << originatingTradeIdNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CompressionType> CompressionActivity::getCompressionType()
{
   if(!this->compressionTypeIsNull_){
        if(compressionTypeIDRef_ != ""){
             return boost::shared_static_cast<CompressionType>(IDManager::instance().getID(compressionTypeIDRef_));
        }else{
             return this->compressionType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CompressionType>();
   }
}
boost::shared_ptr<TradeIdentifier> CompressionActivity::getReplacementTradeIdentifier()
{
   if(!this->replacementTradeIdentifierIsNull_){
        if(replacementTradeIdentifierIDRef_ != ""){
             return boost::shared_static_cast<TradeIdentifier>(IDManager::instance().getID(replacementTradeIdentifierIDRef_));
        }else{
             return this->replacementTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeIdentifier>();
   }
}
std::vector<boost::shared_ptr<TradeIdentifier>> CompressionActivity::getOriginatingTradeIdentifier()
{
   if(!this->originatingTradeIdentifierIsNull_){
        if(originatingTradeIdentifierIDRef_ != ""){
             return this->originatingTradeIdentifier_;
        }else{
             return this->originatingTradeIdentifier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeIdentifier>>();
   }
}
boost::shared_ptr<TradeId> CompressionActivity::getReplacementTradeId()
{
   if(!this->replacementTradeIdIsNull_){
        if(replacementTradeIdIDRef_ != ""){
             return boost::shared_static_cast<TradeId>(IDManager::instance().getID(replacementTradeIdIDRef_));
        }else{
             return this->replacementTradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TradeId>();
   }
}
std::vector<boost::shared_ptr<TradeId>> CompressionActivity::getOriginatingTradeId()
{
   if(!this->originatingTradeIdIsNull_){
        if(originatingTradeIdIDRef_ != ""){
             return this->originatingTradeId_;
        }else{
             return this->originatingTradeId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<TradeId>>();
   }
}
}

