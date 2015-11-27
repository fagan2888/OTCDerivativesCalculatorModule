// ReferenceInformationList.hpp 
#ifndef FpmlSerialized_ReferenceInformationList_hpp
#define FpmlSerialized_ReferenceInformationList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/ReferenceInformation.hpp>

namespace FpmlSerialized {

class ReferenceInformationList : public ISerialized { 
   public: 
       ReferenceInformationList(TiXmlNode* xmlNode);

       bool isReferenceInformation(){return this->referenceInformationIsNull_;}
       std::vector<boost::shared_ptr<ReferenceInformation>> getReferenceInformation();


   protected: 
       std::vector<boost::shared_ptr<ReferenceInformation>> referenceInformation_;
       
       bool referenceInformationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

