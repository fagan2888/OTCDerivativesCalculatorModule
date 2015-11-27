// PreDefinedVariableList.hpp 
#ifndef FpmlSerialized_PreDefinedVariableList_hpp
#define FpmlSerialized_PreDefinedVariableList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/PreDefinedVariableInfo.hpp>

namespace FpmlSerialized {

class PreDefinedVariableList : public ISerialized { 
   public: 
       PreDefinedVariableList(TiXmlNode* xmlNode);

       bool isPreDefinedVariableInfo(){return this->preDefinedVariableInfoIsNull_;}
       std::vector<boost::shared_ptr<PreDefinedVariableInfo>> getPreDefinedVariableInfo();


   protected: 
       std::vector<boost::shared_ptr<PreDefinedVariableInfo>> preDefinedVariableInfo_;
       
       bool preDefinedVariableInfoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

