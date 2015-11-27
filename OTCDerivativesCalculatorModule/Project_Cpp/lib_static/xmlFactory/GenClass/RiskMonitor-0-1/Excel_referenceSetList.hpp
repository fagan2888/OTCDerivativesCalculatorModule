// Excel_referenceSetList.hpp 
#ifndef FpmlSerialized_Excel_referenceSetList_hpp
#define FpmlSerialized_Excel_referenceSetList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_referenceSet.hpp>

namespace FpmlSerialized {

class Excel_referenceSetList : public ISerialized { 
   public: 
       Excel_referenceSetList(TiXmlNode* xmlNode);

       bool isExcel_referenceSet(){return this->excel_referenceSetIsNull_;}
       std::vector<boost::shared_ptr<Excel_referenceSet>> getExcel_referenceSet();


   protected: 
       std::vector<boost::shared_ptr<Excel_referenceSet>> excel_referenceSet_;
       
       bool excel_referenceSetIsNull_;

};

} //namespaceFpmlSerialized end
#endif

