// Approvals.hpp 
#ifndef FpmlSerialized_Approvals_hpp
#define FpmlSerialized_Approvals_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/Approval.hpp>

namespace FpmlSerialized {

class Approvals : public ISerialized { 
   public: 
       Approvals(TiXmlNode* xmlNode);

       bool isApproval(){return this->approvalIsNull_;}
       std::vector<boost::shared_ptr<Approval>> getApproval();
      std::string getApprovalIDRef(){return approvalIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<Approval>> approval_;
       std::string approvalIDRef_;
       bool approvalIsNull_;

};

} //namespaceFpmlSerialized end
#endif

