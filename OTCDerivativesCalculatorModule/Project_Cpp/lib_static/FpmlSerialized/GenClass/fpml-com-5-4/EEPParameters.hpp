// EEPParameters.hpp 
#ifndef FpmlSerialized_EEPParameters_hpp
#define FpmlSerialized_EEPParameters_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-com-5-4/EEPRiskPeriod.hpp>

namespace FpmlSerialized {

class EEPParameters : public ISerialized { 
   public: 
       EEPParameters(TiXmlNode* xmlNode);

       bool isEEPApplicable(){return this->eEPApplicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getEEPApplicable();
      std::string getEEPApplicableIDRef(){return eEPApplicableIDRef_;}

       bool isRiskPeriod(){return this->riskPeriodIsNull_;}
       boost::shared_ptr<EEPRiskPeriod> getRiskPeriod();
      std::string getRiskPeriodIDRef(){return riskPeriodIDRef_;}

       bool isEquivalentApplicable(){return this->equivalentApplicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getEquivalentApplicable();
      std::string getEquivalentApplicableIDRef(){return equivalentApplicableIDRef_;}

       bool isPenaltyApplicable(){return this->penaltyApplicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPenaltyApplicable();
      std::string getPenaltyApplicableIDRef(){return penaltyApplicableIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> eEPApplicable_;
       std::string eEPApplicableIDRef_;
       bool eEPApplicableIsNull_;
       boost::shared_ptr<EEPRiskPeriod> riskPeriod_;
       std::string riskPeriodIDRef_;
       bool riskPeriodIsNull_;
       boost::shared_ptr<XsdTypeBoolean> equivalentApplicable_;
       std::string equivalentApplicableIDRef_;
       bool equivalentApplicableIsNull_;
       boost::shared_ptr<XsdTypeBoolean> penaltyApplicable_;
       std::string penaltyApplicableIDRef_;
       bool penaltyApplicableIsNull_;

};

} //namespaceFpmlSerialized end
#endif

