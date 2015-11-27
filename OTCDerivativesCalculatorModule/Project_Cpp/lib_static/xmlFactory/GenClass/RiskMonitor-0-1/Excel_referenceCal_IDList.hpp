// Excel_referenceCal_IDList.hpp 
#ifndef FpmlSerialized_Excel_referenceCal_IDList_hpp
#define FpmlSerialized_Excel_referenceCal_IDList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_referenceCal_ID.hpp>

namespace FpmlSerialized {

class Excel_referenceCal_IDList : public ISerialized { 
   public: 
       Excel_referenceCal_IDList(TiXmlNode* xmlNode);

       bool isExcel_referenceCal_ID(){return this->excel_referenceCal_IDIsNull_;}
       std::vector<boost::shared_ptr<Excel_referenceCal_ID>> getExcel_referenceCal_ID();


   protected: 
       std::vector<boost::shared_ptr<Excel_referenceCal_ID>> excel_referenceCal_ID_;
       
       bool excel_referenceCal_IDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

