// Excel_referenceInformationList.hpp 
#ifndef FpmlSerialized_Excel_referenceInformationList_hpp
#define FpmlSerialized_Excel_referenceInformationList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_referenceInformation.hpp>

namespace FpmlSerialized {

class Excel_referenceInformationList : public ISerialized { 
   public: 
       Excel_referenceInformationList(TiXmlNode* xmlNode);

       bool isExcel_referenceInformation(){return this->excel_referenceInformationIsNull_;}
       std::vector<boost::shared_ptr<Excel_referenceInformation>> getExcel_referenceInformation();


   protected: 
       std::vector<boost::shared_ptr<Excel_referenceInformation>> excel_referenceInformation_;
       
       bool excel_referenceInformationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

