// Excel_referenceInformation.hpp 
#ifndef FpmlSerialized_Excel_referenceInformation_hpp
#define FpmlSerialized_Excel_referenceInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Excel_referenceObligation.hpp>

namespace FpmlSerialized {

class Excel_referenceInformation : public ISerialized { 
   public: 
       Excel_referenceInformation(TiXmlNode* xmlNode);

       bool isEntityName(){return this->entityNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEntityName();


       bool isEntityId(){return this->entityIdIsNull_;}
       boost::shared_ptr<XsdTypeToken> getEntityId();


       bool isExcel_referenceObligation(){return this->excel_referenceObligationIsNull_;}
       boost::shared_ptr<Excel_referenceObligation> getExcel_referenceObligation();


   protected: 
       boost::shared_ptr<XsdTypeToken> entityName_;
       
       bool entityNameIsNull_;
       boost::shared_ptr<XsdTypeToken> entityId_;
       
       bool entityIdIsNull_;
       boost::shared_ptr<Excel_referenceObligation> excel_referenceObligation_;
       
       bool excel_referenceObligationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

