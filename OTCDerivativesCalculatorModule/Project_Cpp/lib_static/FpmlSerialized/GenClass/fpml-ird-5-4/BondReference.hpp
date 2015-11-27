// BondReference.hpp 
#ifndef FpmlSerialized_BondReference_hpp
#define FpmlSerialized_BondReference_hpp

#include <ISerialized.hpp>
#include <fpml-asset-5-4/Bond.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class BondReference : public ISerialized { 
   public: 
       BondReference(TiXmlNode* xmlNode);

       bool isBond(){return this->bondIsNull_;}
       boost::shared_ptr<Bond> getBond();
      std::string getBondIDRef(){return bondIDRef_;}

       bool isConditionPrecedentBond(){return this->conditionPrecedentBondIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getConditionPrecedentBond();
      std::string getConditionPrecedentBondIDRef(){return conditionPrecedentBondIDRef_;}

       bool isDiscrepancyClause(){return this->discrepancyClauseIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getDiscrepancyClause();
      std::string getDiscrepancyClauseIDRef(){return discrepancyClauseIDRef_;}

   protected: 
       boost::shared_ptr<Bond> bond_;
       std::string bondIDRef_;
       bool bondIsNull_;
       boost::shared_ptr<XsdTypeBoolean> conditionPrecedentBond_;
       std::string conditionPrecedentBondIDRef_;
       bool conditionPrecedentBondIsNull_;
       boost::shared_ptr<XsdTypeBoolean> discrepancyClause_;
       std::string discrepancyClauseIDRef_;
       bool discrepancyClauseIsNull_;

};

} //namespaceFpmlSerialized end
#endif

