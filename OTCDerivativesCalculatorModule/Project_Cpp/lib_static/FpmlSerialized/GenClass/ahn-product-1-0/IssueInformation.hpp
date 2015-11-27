// IssueInformation.hpp 
#ifndef FpmlSerialized_IssueInformation_hpp
#define FpmlSerialized_IssueInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <ahn-product-1-0/EventDate.hpp>

namespace FpmlSerialized {

class IssueInformation : public ISerialized { 
   public: 
       IssueInformation(TiXmlNode* xmlNode);

       bool isProductType(){return this->productTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getProductType();
      std::string getProductTypeIDRef(){return productTypeIDRef_;}

       bool isInstrumentID(){return this->instrumentIDIsNull_;}
       boost::shared_ptr<XsdTypeToken> getInstrumentID();
      std::string getInstrumentIDIDRef(){return instrumentIDIDRef_;}

       bool isNotional(){return this->notionalIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNotional();
      std::string getNotionalIDRef(){return notionalIDRef_;}

       bool isIssueDate(){return this->issueDateIsNull_;}
       boost::shared_ptr<EventDate> getIssueDate();
      std::string getIssueDateIDRef(){return issueDateIDRef_;}

       bool isMaturityDate(){return this->maturityDateIsNull_;}
       boost::shared_ptr<EventDate> getMaturityDate();
      std::string getMaturityDateIDRef(){return maturityDateIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> productType_;
       std::string productTypeIDRef_;
       bool productTypeIsNull_;
       boost::shared_ptr<XsdTypeToken> instrumentID_;
       std::string instrumentIDIDRef_;
       bool instrumentIDIsNull_;
       boost::shared_ptr<XsdTypeDecimal> notional_;
       std::string notionalIDRef_;
       bool notionalIsNull_;
       boost::shared_ptr<EventDate> issueDate_;
       std::string issueDateIDRef_;
       bool issueDateIsNull_;
       boost::shared_ptr<EventDate> maturityDate_;
       std::string maturityDateIDRef_;
       bool maturityDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

