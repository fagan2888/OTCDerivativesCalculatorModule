// TradeDifference.hpp 
#ifndef FpmlSerialized_TradeDifference_hpp
#define FpmlSerialized_TradeDifference_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/DifferenceTypeEnum.hpp>
#include <fpml-enum-5-4/DifferenceSeverityEnum.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class TradeDifference : public ISerialized { 
   public: 
       TradeDifference(TiXmlNode* xmlNode);

       bool isDifferenceType(){return this->differenceTypeIsNull_;}
       boost::shared_ptr<DifferenceTypeEnum> getDifferenceType();
      std::string getDifferenceTypeIDRef(){return differenceTypeIDRef_;}

       bool isDifferenceSeverity(){return this->differenceSeverityIsNull_;}
       boost::shared_ptr<DifferenceSeverityEnum> getDifferenceSeverity();
      std::string getDifferenceSeverityIDRef(){return differenceSeverityIDRef_;}

       bool isElement(){return this->elementIsNull_;}
       boost::shared_ptr<XsdTypeString> getElement();
      std::string getElementIDRef(){return elementIDRef_;}

       bool isBasePath(){return this->basePathIsNull_;}
       boost::shared_ptr<XsdTypeString> getBasePath();
      std::string getBasePathIDRef(){return basePathIDRef_;}

       bool isBaseValue(){return this->baseValueIsNull_;}
       boost::shared_ptr<XsdTypeString> getBaseValue();
      std::string getBaseValueIDRef(){return baseValueIDRef_;}

       bool isOtherPath(){return this->otherPathIsNull_;}
       boost::shared_ptr<XsdTypeString> getOtherPath();
      std::string getOtherPathIDRef(){return otherPathIDRef_;}

       bool isOtherValue(){return this->otherValueIsNull_;}
       boost::shared_ptr<XsdTypeString> getOtherValue();
      std::string getOtherValueIDRef(){return otherValueIDRef_;}

       bool isMissingElement(){return this->missingElementIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeString>> getMissingElement();
      std::string getMissingElementIDRef(){return missingElementIDRef_;}

       bool isExtraElement(){return this->extraElementIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeString>> getExtraElement();
      std::string getExtraElementIDRef(){return extraElementIDRef_;}

       bool isMessage(){return this->messageIsNull_;}
       boost::shared_ptr<XsdTypeString> getMessage();
      std::string getMessageIDRef(){return messageIDRef_;}

   protected: 
       boost::shared_ptr<DifferenceTypeEnum> differenceType_;
       std::string differenceTypeIDRef_;
       bool differenceTypeIsNull_;
       boost::shared_ptr<DifferenceSeverityEnum> differenceSeverity_;
       std::string differenceSeverityIDRef_;
       bool differenceSeverityIsNull_;
       boost::shared_ptr<XsdTypeString> element_;
       std::string elementIDRef_;
       bool elementIsNull_;
       boost::shared_ptr<XsdTypeString> basePath_;
       std::string basePathIDRef_;
       bool basePathIsNull_;
       boost::shared_ptr<XsdTypeString> baseValue_;
       std::string baseValueIDRef_;
       bool baseValueIsNull_;
       boost::shared_ptr<XsdTypeString> otherPath_;
       std::string otherPathIDRef_;
       bool otherPathIsNull_;
       boost::shared_ptr<XsdTypeString> otherValue_;
       std::string otherValueIDRef_;
       bool otherValueIsNull_;
       std::vector<boost::shared_ptr<XsdTypeString>> missingElement_;
       std::string missingElementIDRef_;
       bool missingElementIsNull_;
       std::vector<boost::shared_ptr<XsdTypeString>> extraElement_;
       std::string extraElementIDRef_;
       bool extraElementIsNull_;
       boost::shared_ptr<XsdTypeString> message_;
       std::string messageIDRef_;
       bool messageIsNull_;

};

} //namespaceFpmlSerialized end
#endif

