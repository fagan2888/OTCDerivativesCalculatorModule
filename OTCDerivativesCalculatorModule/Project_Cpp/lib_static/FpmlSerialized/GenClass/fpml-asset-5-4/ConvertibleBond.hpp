// ConvertibleBond.hpp 
#ifndef FpmlSerialized_ConvertibleBond_hpp
#define FpmlSerialized_ConvertibleBond_hpp

#include <fpml-asset-5-4/Bond.hpp>
#include <fpml-asset-5-4/EquityAsset.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class ConvertibleBond : public Bond { 
   public: 
       ConvertibleBond(TiXmlNode* xmlNode);

       bool isUnderlyingEquity(){return this->underlyingEquityIsNull_;}
       boost::shared_ptr<EquityAsset> getUnderlyingEquity();
      std::string getUnderlyingEquityIDRef(){return underlyingEquityIDRef_;}

       bool isRedemptionDate(){return this->redemptionDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getRedemptionDate();
      std::string getRedemptionDateIDRef(){return redemptionDateIDRef_;}

   protected: 
       boost::shared_ptr<EquityAsset> underlyingEquity_;
       std::string underlyingEquityIDRef_;
       bool underlyingEquityIsNull_;
       boost::shared_ptr<XsdTypeDate> redemptionDate_;
       std::string redemptionDateIDRef_;
       bool redemptionDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

