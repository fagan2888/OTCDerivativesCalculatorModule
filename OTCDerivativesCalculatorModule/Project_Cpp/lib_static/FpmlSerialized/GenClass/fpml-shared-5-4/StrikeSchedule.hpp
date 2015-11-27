// StrikeSchedule.hpp 
#ifndef FpmlSerialized_StrikeSchedule_hpp
#define FpmlSerialized_StrikeSchedule_hpp

#include <fpml-shared-5-4/Schedule.hpp>
#include <fpml-shared-5-4/IdentifiedPayerReceiver.hpp>

namespace FpmlSerialized {

class StrikeSchedule : public Schedule { 
   public: 
       StrikeSchedule(TiXmlNode* xmlNode);

       bool isBuyer(){return this->buyerIsNull_;}
       boost::shared_ptr<IdentifiedPayerReceiver> getBuyer();
      std::string getBuyerIDRef(){return buyerIDRef_;}

       bool isSeller(){return this->sellerIsNull_;}
       boost::shared_ptr<IdentifiedPayerReceiver> getSeller();
      std::string getSellerIDRef(){return sellerIDRef_;}

   protected: 
       boost::shared_ptr<IdentifiedPayerReceiver> buyer_;
       std::string buyerIDRef_;
       bool buyerIsNull_;
       boost::shared_ptr<IdentifiedPayerReceiver> seller_;
       std::string sellerIDRef_;
       bool sellerIsNull_;

};

} //namespaceFpmlSerialized end
#endif

