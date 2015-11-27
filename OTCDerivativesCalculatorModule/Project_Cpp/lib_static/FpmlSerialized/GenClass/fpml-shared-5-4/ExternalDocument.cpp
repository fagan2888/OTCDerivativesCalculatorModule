// ExternalDocument.cpp 
#include "ExternalDocument.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExternalDocument::ExternalDocument(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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

   //attachmentReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* attachmentReferenceNode = xmlNode->FirstChildElement("attachmentReference");

   if(attachmentReferenceNode){attachmentReferenceIsNull_ = false;}
   else{attachmentReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- attachmentReferenceNode , address : " << attachmentReferenceNode << std::endl;
   #endif
   if(attachmentReferenceNode)
   {
      if(attachmentReferenceNode->Attribute("href") || attachmentReferenceNode->Attribute("id"))
      {
          if(attachmentReferenceNode->Attribute("id"))
          {
             attachmentReferenceIDRef_ = attachmentReferenceNode->Attribute("id");
             attachmentReference_ = boost::shared_ptr<HTTPAttachmentReference>(new HTTPAttachmentReference(attachmentReferenceNode));
             attachmentReference_->setID(attachmentReferenceIDRef_);
             IDManager::instance().setID(attachmentReferenceIDRef_,attachmentReference_);
          }
          else if(attachmentReferenceNode->Attribute("href")) { attachmentReferenceIDRef_ = attachmentReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { attachmentReference_ = boost::shared_ptr<HTTPAttachmentReference>(new HTTPAttachmentReference(attachmentReferenceNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<MimeType> ExternalDocument::getMimeType()
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
boost::shared_ptr<XsdTypeString> ExternalDocument::getString()
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
boost::shared_ptr<XsdTypeHexBinary> ExternalDocument::getHexadecimalBinary()
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
boost::shared_ptr<XsdTypeBase64Binary> ExternalDocument::getBase64Binary()
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
boost::shared_ptr<XsdTypeAnyURI> ExternalDocument::getUrl()
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
boost::shared_ptr<HTTPAttachmentReference> ExternalDocument::getAttachmentReference()
{
   if(!this->attachmentReferenceIsNull_){
        if(attachmentReferenceIDRef_ != ""){
             return boost::shared_static_cast<HTTPAttachmentReference>(IDManager::instance().getID(attachmentReferenceIDRef_));
        }else{
             return this->attachmentReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<HTTPAttachmentReference>();
   }
}
}

