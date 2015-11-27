// StructuredProduct.hpp 
#ifndef FpmlSerialized_StructuredProduct_hpp
#define FpmlSerialized_StructuredProduct_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/IssueInformation.hpp>
#include <ahn-product-1-0/StructuredProductPayoff.hpp>

namespace FpmlSerialized {

class StructuredProduct : public ISerialized { 
   public: 
       StructuredProduct(TiXmlNode* xmlNode);

       bool isIssueInformation(){return this->issueInformationIsNull_;}
       boost::shared_ptr<IssueInformation> getIssueInformation();
      std::string getIssueInformationIDRef(){return issueInformationIDRef_;}

       bool isStructuredProductPayoff(){return this->structuredProductPayoffIsNull_;}
       boost::shared_ptr<StructuredProductPayoff> getStructuredProductPayoff();
      std::string getStructuredProductPayoffIDRef(){return structuredProductPayoffIDRef_;}

   protected: 
       boost::shared_ptr<IssueInformation> issueInformation_;
       std::string issueInformationIDRef_;
       bool issueInformationIsNull_;
       boost::shared_ptr<StructuredProductPayoff> structuredProductPayoff_;
       std::string structuredProductPayoffIDRef_;
       bool structuredProductPayoffIsNull_;

};

} //namespaceFpmlSerialized end
#endif

