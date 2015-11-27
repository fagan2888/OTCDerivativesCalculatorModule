// ExternalDocument.hpp 
#ifndef FpmlSerialized_ExternalDocument_hpp
#define FpmlSerialized_ExternalDocument_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/MimeType.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypeHexBinary.hpp>
#include <built_in_type/XsdTypeBase64Binary.hpp>
#include <built_in_type/XsdTypeAnyURI.hpp>
#include <fpml-shared-5-4/HTTPAttachmentReference.hpp>

namespace FpmlSerialized {

class ExternalDocument : public ISerialized { 
   public: 
       ExternalDocument(TiXmlNode* xmlNode);

       bool isMimeType(){return this->mimeTypeIsNull_;}
       boost::shared_ptr<MimeType> getMimeType();
      std::string getMimeTypeIDRef(){return mimeTypeIDRef_;}

       bool isString(){return this->stringIsNull_;}
       boost::shared_ptr<XsdTypeString> getString();
      std::string getStringIDRef(){return stringIDRef_;}

       bool isHexadecimalBinary(){return this->hexadecimalBinaryIsNull_;}
       boost::shared_ptr<XsdTypeHexBinary> getHexadecimalBinary();
      std::string getHexadecimalBinaryIDRef(){return hexadecimalBinaryIDRef_;}

       bool isBase64Binary(){return this->base64BinaryIsNull_;}
       boost::shared_ptr<XsdTypeBase64Binary> getBase64Binary();
      std::string getBase64BinaryIDRef(){return base64BinaryIDRef_;}

       bool isUrl(){return this->urlIsNull_;}
       boost::shared_ptr<XsdTypeAnyURI> getUrl();
      std::string getUrlIDRef(){return urlIDRef_;}

       bool isAttachmentReference(){return this->attachmentReferenceIsNull_;}
       boost::shared_ptr<HTTPAttachmentReference> getAttachmentReference();
      std::string getAttachmentReferenceIDRef(){return attachmentReferenceIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!stringIsNull_){
                count += 1;
                str = "string" ;
           }
           if(!hexadecimalBinaryIsNull_){
                count += 1;
                str = "hexadecimalBinary" ;
           }
           if(!base64BinaryIsNull_){
                count += 1;
                str = "base64Binary" ;
           }
           if(!urlIsNull_){
                count += 1;
                str = "url" ;
           }
           if(!attachmentReferenceIsNull_){
                count += 1;
                str = "attachmentReference" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<MimeType> mimeType_;
       std::string mimeTypeIDRef_;
       bool mimeTypeIsNull_;
         boost::shared_ptr<XsdTypeString> string_;     //choice
       std::string stringIDRef_;
       bool stringIsNull_;
         boost::shared_ptr<XsdTypeHexBinary> hexadecimalBinary_;     //choice
       std::string hexadecimalBinaryIDRef_;
       bool hexadecimalBinaryIsNull_;
         boost::shared_ptr<XsdTypeBase64Binary> base64Binary_;     //choice
       std::string base64BinaryIDRef_;
       bool base64BinaryIsNull_;
         boost::shared_ptr<XsdTypeAnyURI> url_;     //choice
       std::string urlIDRef_;
       bool urlIsNull_;
         boost::shared_ptr<HTTPAttachmentReference> attachmentReference_;     //choice
       std::string attachmentReferenceIDRef_;
       bool attachmentReferenceIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

