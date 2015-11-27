// Approval.hpp 
#ifndef FpmlSerialized_Approval_hpp
#define FpmlSerialized_Approval_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeNormalizedString.hpp>

namespace FpmlSerialized {

class Approval : public ISerialized { 
   public: 
       Approval(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isStatus(){return this->statusIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getStatus();
      std::string getStatusIDRef(){return statusIDRef_;}

       bool isApprover(){return this->approverIsNull_;}
       boost::shared_ptr<XsdTypeNormalizedString> getApprover();
      std::string getApproverIDRef(){return approverIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeNormalizedString> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeNormalizedString> status_;
       std::string statusIDRef_;
       bool statusIsNull_;
       boost::shared_ptr<XsdTypeNormalizedString> approver_;
       std::string approverIDRef_;
       bool approverIsNull_;

};

} //namespaceFpmlSerialized end
#endif

