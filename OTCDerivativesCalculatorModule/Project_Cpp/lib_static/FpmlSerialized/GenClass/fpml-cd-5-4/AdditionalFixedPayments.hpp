// AdditionalFixedPayments.hpp 
#ifndef FpmlSerialized_AdditionalFixedPayments_hpp
#define FpmlSerialized_AdditionalFixedPayments_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class AdditionalFixedPayments : public ISerialized { 
   public: 
       AdditionalFixedPayments(TiXmlNode* xmlNode);

       bool isInterestShortfallReimbursement(){return this->interestShortfallReimbursementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getInterestShortfallReimbursement();
      std::string getInterestShortfallReimbursementIDRef(){return interestShortfallReimbursementIDRef_;}

       bool isPrincipalShortfallReimbursement(){return this->principalShortfallReimbursementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getPrincipalShortfallReimbursement();
      std::string getPrincipalShortfallReimbursementIDRef(){return principalShortfallReimbursementIDRef_;}

       bool isWritedownReimbursement(){return this->writedownReimbursementIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getWritedownReimbursement();
      std::string getWritedownReimbursementIDRef(){return writedownReimbursementIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> interestShortfallReimbursement_;
       std::string interestShortfallReimbursementIDRef_;
       bool interestShortfallReimbursementIsNull_;
       boost::shared_ptr<XsdTypeBoolean> principalShortfallReimbursement_;
       std::string principalShortfallReimbursementIDRef_;
       bool principalShortfallReimbursementIsNull_;
       boost::shared_ptr<XsdTypeBoolean> writedownReimbursement_;
       std::string writedownReimbursementIDRef_;
       bool writedownReimbursementIsNull_;

};

} //namespaceFpmlSerialized end
#endif

