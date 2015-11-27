// CrossRate.hpp 
#ifndef FpmlSerialized_CrossRate_hpp
#define FpmlSerialized_CrossRate_hpp

#include <fpml-shared-5-4/QuotedCurrencyPair.hpp>
#include <fpml-shared-5-4/PositiveDecimal.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class CrossRate : public QuotedCurrencyPair { 
   public: 
       CrossRate(TiXmlNode* xmlNode);

       bool isRate(){return this->rateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getRate();
      std::string getRateIDRef(){return rateIDRef_;}

       bool isSpotRate(){return this->spotRateIsNull_;}
       boost::shared_ptr<PositiveDecimal> getSpotRate();
      std::string getSpotRateIDRef(){return spotRateIDRef_;}

       bool isForwardPoints(){return this->forwardPointsIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getForwardPoints();
      std::string getForwardPointsIDRef(){return forwardPointsIDRef_;}

   protected: 
       boost::shared_ptr<PositiveDecimal> rate_;
       std::string rateIDRef_;
       bool rateIsNull_;
       boost::shared_ptr<PositiveDecimal> spotRate_;
       std::string spotRateIDRef_;
       bool spotRateIsNull_;
       boost::shared_ptr<XsdTypeDecimal> forwardPoints_;
       std::string forwardPointsIDRef_;
       bool forwardPointsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

