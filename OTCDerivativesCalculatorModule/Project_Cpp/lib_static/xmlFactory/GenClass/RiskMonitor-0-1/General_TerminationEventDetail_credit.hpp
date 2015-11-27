// General_TerminationEventDetail_credit.hpp 
#ifndef FpmlSerialized_General_TerminationEventDetail_credit_hpp
#define FpmlSerialized_General_TerminationEventDetail_credit_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class General_TerminationEventDetail_credit : public ISerialized { 
   public: 
       General_TerminationEventDetail_credit(TiXmlNode* xmlNode);

       bool isReferenceEntity(){return this->referenceEntityIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getReferenceEntity();


   protected: 
       std::vector<boost::shared_ptr<XsdTypeToken>> referenceEntity_;
       
       bool referenceEntityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

