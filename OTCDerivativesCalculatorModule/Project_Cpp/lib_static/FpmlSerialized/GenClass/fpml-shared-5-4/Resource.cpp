// Resource.cpp 
#include "Resource.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

Resource::Resource(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //resourceIdNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resourceIdNode = xmlNode->FirstChildElement("resourceId");

   if(resourceIdNode){resourceIdIsNull_ = false;}
   else{resourceIdIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resourceIdNode , address : " << resourceIdNode << std::endl;
   #endif
   if(resourceIdNode)
   {
      if(resourceIdNode->Attribute("href") || resourceIdNode->Attribute("id"))
      {
          if(resourceIdNode->Attribute("id"))
          {
             resourceIdIDRef_ = resourceIdNode->Attribute("id");
             resourceId_ = boost::shared_ptr<ResourceId>(new ResourceId(resourceIdNode));
             resourceId_->setID(resourceIdIDRef_);
             IDManager::instance().setID(resourceIdIDRef_,resourceId_);
          }
          else if(resourceIdNode->Attribute("href")) { resourceIdIDRef_ = resourceIdNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resourceId_ = boost::shared_ptr<ResourceId>(new ResourceId(resourceIdNode));}
   }

   //resourceTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* resourceTypeNode = xmlNode->FirstChildElement("resourceType");

   if(resourceTypeNode){resourceTypeIsNull_ = false;}
   else{resourceTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- resourceTypeNode , address : " << resourceTypeNode << std::endl;
   #endif
   if(resourceTypeNode)
   {
      if(resourceTypeNode->Attribute("href") || resourceTypeNode->Attribute("id"))
      {
          if(resourceTypeNode->Attribute("id"))
          {
             resourceTypeIDRef_ = resourceTypeNode->Attribute("id");
             resourceType_ = boost::shared_ptr<ResourceType>(new ResourceType(resourceTypeNode));
             resourceType_->setID(resourceTypeIDRef_);
             IDManager::instance().setID(resourceTypeIDRef_,resourceType_);
          }
          else if(resourceTypeNode->Attribute("href")) { resourceTypeIDRef_ = resourceTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { resourceType_ = boost::shared_ptr<ResourceType>(new ResourceType(resourceTypeNode));}
   }

   //languageNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* languageNode = xmlNode->FirstChildElement("language");

   if(languageNode){languageIsNull_ = false;}
   else{languageIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- languageNode , address : " << languageNode << std::endl;
   #endif
   if(languageNode)
   {
      if(languageNode->Attribute("href") || languageNode->Attribute("id"))
      {
          if(languageNode->Attribute("id"))
          {
             languageIDRef_ = languageNode->Attribute("id");
             language_ = boost::shared_ptr<Language>(new Language(languageNode));
             language_->setID(languageIDRef_);
             IDManager::instance().setID(languageIDRef_,language_);
          }
          else if(languageNode->Attribute("href")) { languageIDRef_ = languageNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { language_ = boost::shared_ptr<Language>(new Language(languageNode));}
   }

   //sizeInBytesNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* sizeInBytesNode = xmlNode->FirstChildElement("sizeInBytes");

   if(sizeInBytesNode){sizeInBytesIsNull_ = false;}
   else{sizeInBytesIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- sizeInBytesNode , address : " << sizeInBytesNode << std::endl;
   #endif
   if(sizeInBytesNode)
   {
      if(sizeInBytesNode->Attribute("href") || sizeInBytesNode->Attribute("id"))
      {
          if(sizeInBytesNode->Attribute("id"))
          {
             sizeInBytesIDRef_ = sizeInBytesNode->Attribute("id");
             sizeInBytes_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(sizeInBytesNode));
             sizeInBytes_->setID(sizeInBytesIDRef_);
             IDManager::instance().setID(sizeInBytesIDRef_,sizeInBytes_);
          }
          else if(sizeInBytesNode->Attribute("href")) { sizeInBytesIDRef_ = sizeInBytesNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { sizeInBytes_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(sizeInBytesNode));}
   }

   //lengthNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* lengthNode = xmlNode->FirstChildElement("length");

   if(lengthNode){lengthIsNull_ = false;}
   else{lengthIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- lengthNode , address : " << lengthNode << std::endl;
   #endif
   if(lengthNode)
   {
      if(lengthNode->Attribute("href") || lengthNode->Attribute("id"))
      {
          if(lengthNode->Attribute("id"))
          {
             lengthIDRef_ = lengthNode->Attribute("id");
             length_ = boost::shared_ptr<ResourceLength>(new ResourceLength(lengthNode));
             length_->setID(lengthIDRef_);
             IDManager::instance().setID(lengthIDRef_,length_);
          }
          else if(lengthNode->Attribute("href")) { lengthIDRef_ = lengthNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { length_ = boost::shared_ptr<ResourceLength>(new ResourceLength(lengthNode));}
   }

   //mimeTypeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* mimeTypeNode = xmlNode->FirstChildElement("mimeType");

   if(mimeTypeNode){mimeTypeIsNull_ = false;}
   else{mimeTypeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- mimeTypeNode , address : " << mimeTypeNode << std::endl;
   #endif
   if(mimeTypeNode)
   {
      if(mimeTypeNode->Attribute("href") || mimeTypeNode->Attribute("id"))
      {
          if(mimeTypeNode->Attribute("id"))
          {
             mimeTypeIDRef_ = mimeTypeNode->Attribute("id");
             mimeType_ = boost::shared_ptr<MimeType>(new MimeType(mimeTypeNode));
             mimeType_->setID(mimeTypeIDRef_);
             IDManager::instance().setID(mimeTypeIDRef_,mimeType_);
          }
          else if(mimeTypeNode->Attribute("href")) { mimeTypeIDRef_ = mimeTypeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { mimeType_ = boost::shared_ptr<MimeType>(new MimeType(mimeTypeNode));}
   }

   //nameNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* nameNode = xmlNode->FirstChildElement("name");

   if(nameNode){nameIsNull_ = false;}
   else{nameIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- nameNode , address : " << nameNode << std::endl;
   #endif
   if(nameNode)
   {
      if(nameNode->Attribute("href") || nameNode->Attribute("id"))
      {
          if(nameNode->Attribute("id"))
          {
             nameIDRef_ = nameNode->Attribute("id");
             name_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(nameNode));
             name_->setID(nameIDRef_);
             IDManager::instance().setID(nameIDRef_,name_);
          }
          else if(nameNode->Attribute("href")) { nameIDRef_ = nameNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { name_ = boost::shared_ptr<XsdTypeNormalizedString>(new XsdTypeNormalizedString(nameNode));}
   }

   //commentsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* commentsNode = xmlNode->FirstChildElement("comments");

   if(commentsNode){commentsIsNull_ = false;}
   else{commentsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- commentsNode , address : " << commentsNode << std::endl;
   #endif
   if(commentsNode)
   {
      if(commentsNode->Attribute("href") || commentsNode->Attribute("id"))
      {
          if(commentsNode->Attribute("id"))
          {
             commentsIDRef_ = commentsNode->Attribute("id");
             comments_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(commentsNode));
             comments_->setID(commentsIDRef_);
             IDManager::instance().setID(commentsIDRef_,comments_);
          }
          else if(commentsNode->Attribute("href")) { commentsIDRef_ = commentsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { comments_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(commentsNode));}
   }

   //stringNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* stringNode = xmlNode->FirstChildElement("string");

   if(stringNode){stringIsNull_ = false;}
   else{stringIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- stringNode , address : " << stringNode << std::endl;
   #endif
   if(stringNode)
   {
      if(stringNode->Attribute("href") || stringNode->Attribute("id"))
      {
          if(stringNode->Attribute("id"))
          {
             stringIDRef_ = stringNode->Attribute("id");
             string_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(stringNode));
             string_->setID(stringIDRef_);
             IDManager::instance().setID(stringIDRef_,string_);
          }
          else if(stringNode->Attribute("href")) { stringIDRef_ = stringNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { string_ = boost::shared_ptr<XsdTypeString>(new XsdTypeString(stringNode));}
   }

   //hexadecimalBinaryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* hexadecimalBinaryNode = xmlNode->FirstChildElement("hexadecimalBinary");

   if(hexadecimalBinaryNode){hexadecimalBinaryIsNull_ = false;}
   else{hexadecimalBinaryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- hexadecimalBinaryNode , address : " << hexadecimalBinaryNode << std::endl;
   #endif
   if(hexadecimalBinaryNode)
   {
      if(hexadecimalBinaryNode->Attribute("href") || hexadecimalBinaryNode->Attribute("id"))
      {
          if(hexadecimalBinaryNode->Attribute("id"))
          {
             hexadecimalBinaryIDRef_ = hexadecimalBinaryNode->Attribute("id");
             hexadecimalBinary_ = boost::shared_ptr<XsdTypeHexBinary>(new XsdTypeHexBinary(hexadecimalBinaryNode));
             hexadecimalBinary_->setID(hexadecimalBinaryIDRef_);
             IDManager::instance().setID(hexadecimalBinaryIDRef_,hexadecimalBinary_);
          }
          else if(hexadecimalBinaryNode->Attribute("href")) { hexadecimalBinaryIDRef_ = hexadecimalBinaryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { hexadecimalBinary_ = boost::shared_ptr<XsdTypeHexBinary>(new XsdTypeHexBinary(hexadecimalBinaryNode));}
   }

   //base64BinaryNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* base64BinaryNode = xmlNode->FirstChildElement("base64Binary");

   if(base64BinaryNode){base64BinaryIsNull_ = false;}
   else{base64BinaryIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- base64BinaryNode , address : " << base64BinaryNode << std::endl;
   #endif
   if(base64BinaryNode)
   {
      if(base64BinaryNode->Attribute("href") || base64BinaryNode->Attribute("id"))
      {
          if(base64BinaryNode->Attribute("id"))
          {
             base64BinaryIDRef_ = base64BinaryNode->Attribute("id");
             base64Binary_ = boost::shared_ptr<XsdTypeBase64Binary>(new XsdTypeBase64Binary(base64BinaryNode));
             base64Binary_->setID(base64BinaryIDRef_);
             IDManager::instance().setID(base64BinaryIDRef_,base64Binary_);
          }
          else if(base64BinaryNode->Attribute("href")) { base64BinaryIDRef_ = base64BinaryNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { base64Binary_ = boost::shared_ptr<XsdTypeBase64Binary>(new XsdTypeBase64Binary(base64BinaryNode));}
   }

   //urlNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* urlNode = xmlNode->FirstChildElement("url");

   if(urlNode){urlIsNull_ = false;}
   else{urlIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- urlNode , address : " << urlNode << std::endl;
   #endif
   if(urlNode)
   {
      if(urlNode->Attribute("href") || urlNode->Attribute("id"))
      {
          if(urlNode->Attribute("id"))
          {
             urlIDRef_ = urlNode->Attribute("id");
             url_ = boost::shared_ptr<XsdTypeAnyURI>(new XsdTypeAnyURI(urlNode));
             url_->setID(urlIDRef_);
             IDManager::instance().setID(urlIDRef_,url_);
          }
          else if(urlNode->Attribute("href")) { urlIDRef_ = urlNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { url_ = boost::shared_ptr<XsdTypeAnyURI>(new XsdTypeAnyURI(urlNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<ResourceId> Resource::getResourceId()
{
   if(!this->resourceIdIsNull_){
        if(resourceIdIDRef_ != ""){
             return boost::shared_static_cast<ResourceId>(IDManager::instance().getID(resourceIdIDRef_));
        }else{
             return this->resourceId_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResourceId>();
   }
}
boost::shared_ptr<ResourceType> Resource::getResourceType()
{
   if(!this->resourceTypeIsNull_){
        if(resourceTypeIDRef_ != ""){
             return boost::shared_static_cast<ResourceType>(IDManager::instance().getID(resourceTypeIDRef_));
        }else{
             return this->resourceType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResourceType>();
   }
}
boost::shared_ptr<Language> Resource::getLanguage()
{
   if(!this->languageIsNull_){
        if(languageIDRef_ != ""){
             return boost::shared_static_cast<Language>(IDManager::instance().getID(languageIDRef_));
        }else{
             return this->language_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Language>();
   }
}
boost::shared_ptr<XsdTypeDecimal> Resource::getSizeInBytes()
{
   if(!this->sizeInBytesIsNull_){
        if(sizeInBytesIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(sizeInBytesIDRef_));
        }else{
             return this->sizeInBytes_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<ResourceLength> Resource::getLength()
{
   if(!this->lengthIsNull_){
        if(lengthIDRef_ != ""){
             return boost::shared_static_cast<ResourceLength>(IDManager::instance().getID(lengthIDRef_));
        }else{
             return this->length_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ResourceLength>();
   }
}
boost::shared_ptr<MimeType> Resource::getMimeType()
{
   if(!this->mimeTypeIsNull_){
        if(mimeTypeIDRef_ != ""){
             return boost::shared_static_cast<MimeType>(IDManager::instance().getID(mimeTypeIDRef_));
        }else{
             return this->mimeType_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<MimeType>();
   }
}
boost::shared_ptr<XsdTypeNormalizedString> Resource::getName()
{
   if(!this->nameIsNull_){
        if(nameIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeNormalizedString>(IDManager::instance().getID(nameIDRef_));
        }else{
             return this->name_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeNormalizedString>();
   }
}
boost::shared_ptr<XsdTypeString> Resource::getComments()
{
   if(!this->commentsIsNull_){
        if(commentsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(commentsIDRef_));
        }else{
             return this->comments_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeString> Resource::getString()
{
   if(!this->stringIsNull_){
        if(stringIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeString>(IDManager::instance().getID(stringIDRef_));
        }else{
             return this->string_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeString>();
   }
}
boost::shared_ptr<XsdTypeHexBinary> Resource::getHexadecimalBinary()
{
   if(!this->hexadecimalBinaryIsNull_){
        if(hexadecimalBinaryIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeHexBinary>(IDManager::instance().getID(hexadecimalBinaryIDRef_));
        }else{
             return this->hexadecimalBinary_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeHexBinary>();
   }
}
boost::shared_ptr<XsdTypeBase64Binary> Resource::getBase64Binary()
{
   if(!this->base64BinaryIsNull_){
        if(base64BinaryIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeBase64Binary>(IDManager::instance().getID(base64BinaryIDRef_));
        }else{
             return this->base64Binary_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeBase64Binary>();
   }
}
boost::shared_ptr<XsdTypeAnyURI> Resource::getUrl()
{
   if(!this->urlIsNull_){
        if(urlIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeAnyURI>(IDManager::instance().getID(urlIDRef_));
        }else{
             return this->url_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeAnyURI>();
   }
}
}

