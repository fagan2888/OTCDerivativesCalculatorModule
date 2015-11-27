// AdditionalData.hpp 
#ifndef FpmlSerialized_AdditionalData_hpp
#define FpmlSerialized_AdditionalData_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/MimeType.hpp>
#include <built_in_type/XsdTypeString.hpp>
#include <built_in_type/XsdTypeHexBinary.hpp>
#include <built_in_type/XsdTypeBase64Binary.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class AdditionalData : public ISerialized { 
   public: 
       AdditionalData(TiXmlNode* xmlNode);

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

       bool isOriginalMessage(){return this->originalMessageIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getOriginalMessage();
      std::string getOriginalMessageIDRef(){return originalMessageIDRef_;}

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
           if(!originalMessageIsNull_){
                count += 1;
                str = "originalMessage" ;
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
         boost::shared_ptr<XsdTypeBoolean> originalMessage_;     //choice
       std::string originalMessageIDRef_;
       bool originalMessageIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

