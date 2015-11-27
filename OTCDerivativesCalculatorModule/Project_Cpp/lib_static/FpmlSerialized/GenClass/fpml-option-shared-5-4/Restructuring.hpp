// Restructuring.hpp 
#ifndef FpmlSerialized_Restructuring_hpp
#define FpmlSerialized_Restructuring_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>
#include <fpml-option-shared-5-4/RestructuringType.hpp>

namespace FpmlSerialized {

class Restructuring : public ISerialized { 
   public: 
       Restructuring(TiXmlNode* xmlNode);

       bool isApplicable(){return this->applicableIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getApplicable();
      std::string getApplicableIDRef(){return applicableIDRef_;}

       bool isRestructuringType(){return this->restructuringTypeIsNull_;}
       boost::shared_ptr<RestructuringType> getRestructuringType();
      std::string getRestructuringTypeIDRef(){return restructuringTypeIDRef_;}

       bool isMultipleHolderObligation(){return this->multipleHolderObligationIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMultipleHolderObligation();
      std::string getMultipleHolderObligationIDRef(){return multipleHolderObligationIDRef_;}

       bool isMultipleCreditEventNotices(){return this->multipleCreditEventNoticesIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getMultipleCreditEventNotices();
      std::string getMultipleCreditEventNoticesIDRef(){return multipleCreditEventNoticesIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeBoolean> applicable_;
       std::string applicableIDRef_;
       bool applicableIsNull_;
       boost::shared_ptr<RestructuringType> restructuringType_;
       std::string restructuringTypeIDRef_;
       bool restructuringTypeIsNull_;
       boost::shared_ptr<XsdTypeBoolean> multipleHolderObligation_;
       std::string multipleHolderObligationIDRef_;
       bool multipleHolderObligationIsNull_;
       boost::shared_ptr<XsdTypeBoolean> multipleCreditEventNotices_;
       std::string multipleCreditEventNoticesIDRef_;
       bool multipleCreditEventNoticesIsNull_;

};

} //namespaceFpmlSerialized end
#endif

