// AbsoluteTolerance.hpp 
#ifndef FpmlSerialized_AbsoluteTolerance_hpp
#define FpmlSerialized_AbsoluteTolerance_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>
#include <fpml-asset-5-4/QuantityUnit.hpp>
#include <fpml-shared-5-4/PartyReference.hpp>

namespace FpmlSerialized {

class AbsoluteTolerance : public ISerialized { 
   public: 
       AbsoluteTolerance(TiXmlNode* xmlNode);

       bool isPositive(){return this->positiveIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getPositive();
      std::string getPositiveIDRef(){return positiveIDRef_;}

       bool isNegative(){return this->negativeIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getNegative();
      std::string getNegativeIDRef(){return negativeIDRef_;}

       bool isUnit(){return this->unitIsNull_;}
       boost::shared_ptr<QuantityUnit> getUnit();
      std::string getUnitIDRef(){return unitIDRef_;}

       bool isOptionOwnerPartyReference(){return this->optionOwnerPartyReferenceIsNull_;}
       boost::shared_ptr<PartyReference> getOptionOwnerPartyReference();
      std::string getOptionOwnerPartyReferenceIDRef(){return optionOwnerPartyReferenceIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDecimal> positive_;
       std::string positiveIDRef_;
       bool positiveIsNull_;
       boost::shared_ptr<XsdTypeDecimal> negative_;
       std::string negativeIDRef_;
       bool negativeIsNull_;
       boost::shared_ptr<QuantityUnit> unit_;
       std::string unitIDRef_;
       bool unitIsNull_;
       boost::shared_ptr<PartyReference> optionOwnerPartyReference_;
       std::string optionOwnerPartyReferenceIDRef_;
       bool optionOwnerPartyReferenceIsNull_;

};

} //namespaceFpmlSerialized end
#endif

