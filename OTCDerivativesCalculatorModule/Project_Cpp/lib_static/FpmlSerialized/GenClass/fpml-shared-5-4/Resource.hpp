// Resource.hpp 
#ifndef FpmlSerialized_Resource_hpp
#define FpmlSerialized_Resource_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ResourceId.hpp>
#include <fpml-shared-5-4/ResourceType.hpp>
#include <fpml-shared-5-4/Language.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/ResourceLength.hpp>
#include <fpml-shared-5-4/MimeType.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypeHexBinary.hpp>
#include <built_in_type/XsdTypeBase64Binary.hpp>
#include <built_in_type/XsdTypeAnyURI.hpp>

namespace FpmlSerialized {

class Resource : public ISerialized { 
   public: 
       Resource(TiXmlNode* xmlNode);

       bool isResourceId(){return this->resourceIdIsNull_;}
       boost::shared_ptr<ResourceId> getResourceId();
      std::string getResourceIdIDRef(){return resourceIdIDRef_;}

       bool isResourceType(){return this->resourceTypeIsNull_;}
       boost::shared_ptr<ResourceType> getResourceType();
      std::string getResourceTypeIDRef(){return resourceTypeIDRef_;}

       bool isLanguage(){return this->languageIsNull_;}
       boost::shared_ptr<Language> getLanguage();
      std::string getLanguageIDRef(){return languageIDRef_;}

       bool isSizeInBytes(){return this->sizeInBytesIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getSizeInBytes();
      std::string getSizeInBytesIDRef(){return sizeInBytesIDRef_;}

       bool isLength(){return this->lengthIsNull_;}
       boost::shared_ptr<ResourceLength> getLength();
      std::string getLengthIDRef(){return lengthIDRef_;}

       bool isMimeType(){return this->mimeTypeIsNull_;}
       boost::shared_ptr<MimeType> getMimeType();
      std::string getMimeTypeIDRef(){return mimeTypeIDRef_;}

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isComments(){return this->commentsIsNull_;}
       boost::shared_ptr<XsdTypeString> getComments();
      std::string getCommentsIDRef(){return commentsIDRef_;}

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
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
       boost::shared_ptr<ResourceId> resourceId_;
       std::string resourceIdIDRef_;
       bool resourceIdIsNull_;
       boost::shared_ptr<ResourceType> resourceType_;
       std::string resourceTypeIDRef_;
       bool resourceTypeIsNull_;
       boost::shared_ptr<Language> language_;
       std::string languageIDRef_;
       bool languageIsNull_;
       boost::shared_ptr<XsdTypeDecimal> sizeInBytes_;
       std::string sizeInBytesIDRef_;
       bool sizeInBytesIsNull_;
       boost::shared_ptr<ResourceLength> length_;
       std::string lengthIDRef_;
       bool lengthIsNull_;
       boost::shared_ptr<MimeType> mimeType_;
       std::string mimeTypeIDRef_;
       bool mimeTypeIsNull_;
       boost::shared_ptr<XsdTypeNormalizedString> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeString> comments_;
       std::string commentsIDRef_;
       bool commentsIsNull_;
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

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

