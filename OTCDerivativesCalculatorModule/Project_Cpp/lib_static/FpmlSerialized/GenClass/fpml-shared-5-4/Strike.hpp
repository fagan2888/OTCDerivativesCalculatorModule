// Strike.hpp 
#ifndef FpmlSerialized_Strike_hpp
#define FpmlSerialized_Strike_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-shared-5-4/IdentifiedPayerReceiver.hpp>

namespace FpmlSerialized {

class Strike : public ISerialized { 
   public: 
       Strike(TiXmlNode* xmlNode);

       bool isStrikeRate(){return this->strikeRateIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getStrikeRate();
      std::string getStrikeRateIDRef(){return strikeRateIDRef_;}

       bool isBuyer(){return this->buyerIsNull_;}
       boost::shared_ptr<IdentifiedPayerReceiver> getBuyer();
      std::string getBuyerIDRef(){return buyerIDRef_;}

       bool isSeller(){return this->sellerIsNull_;}
       boost::shared_ptr<IdentifiedPayerReceiver> getSeller();
      std::string getSellerIDRef(){return sellerIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> strikeRate_;
       std::string strikeRateIDRef_;
       bool strikeRateIsNull_;
       boost::shared_ptr<IdentifiedPayerReceiver> buyer_;
       std::string buyerIDRef_;
       bool buyerIsNull_;
       boost::shared_ptr<IdentifiedPayerReceiver> seller_;
       std::string sellerIDRef_;
       bool sellerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

